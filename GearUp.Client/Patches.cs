using HarmonyLib;
using IFix;

namespace GearUp.Client;

[HarmonyPatch]
class Patches
{
    [HarmonyPrefix, HarmonyPatch(typeof(NetGameApiSdkArgsModel), nameof(NetGameApiSdkArgsModel.Load), [])]
    public static bool NetGameApiSdkArgsModel_Load_Prefix(ref NetGameApiSdkArgsModel __result)
    {
        Plugin.Log.LogInfo("NetGameApiSdkArgsModel.Load() override");

        __result = new NetGameApiSdkArgsModel()
        {
            ViewerId = "123",
            AccessToken = "456",
            OnetimeToken = "789"
        };

        return false;
    }

    [HarmonyPostfix, HarmonyPatch(typeof(URLString), nameof(URLString.GetPlat))]
    public static void URLString_GetPlat_Postfix(ref string __result)
    {
        Plugin.Log.LogInfo("URLString.GetPlat() override");

        __result = $"https://localhost?q=gateway&v={Const.GetScriptClientVersion()}";
    }

    [HarmonyPrefix, HarmonyPatch(typeof(WrappersManagerImpl), nameof(WrappersManagerImpl.IsPatched))]
    public static bool WrappersManagerImpl_IsPatched_Prefix(int id, ref bool __result)
    {
        if (id == 1858) // Prevents new account creation
        {
            Plugin.Log.LogInfo("IFix patch 1858 override to false");
            __result = false;
            return false;
        }

        return true;
    }
}
