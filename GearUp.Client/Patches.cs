using HarmonyLib;
using IFix;
using UnityEngine;

namespace GearUp.Client;

[HarmonyPatch]
class Patches
{
    [HarmonyPrefix, HarmonyPatch(typeof(NetGameApiSdkArgsModel), nameof(NetGameApiSdkArgsModel.Load), [])]
    public static bool NetGameApiSdkArgsModel_Load_Prefix(ref NetGameApiSdkArgsModel __result)
    {
        Plugin.Log.LogInfo("NetGameApiSdkArgsModel.Load() override");

        var token = SHA.SHA1(SystemInfo.deviceUniqueIdentifier + Application.dataPath);
        __result = new NetGameApiSdkArgsModel()
        {
            ViewerId = "123",
            AccessToken = "456",
            OnetimeToken = token
        };

        return false;
    }

    [HarmonyPrefix, HarmonyPatch(typeof(URLString), nameof(URLString.GetPlat))]
    public static bool URLString_GetPlat_Prefix(ref string __result)
    {
        Plugin.Log.LogInfo("URLString.GetPlat() override");

        __result = $"https://localhost?q=gateway&v={Const.GetScriptClientVersion()}";

        return false;
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
