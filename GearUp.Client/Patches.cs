using HarmonyLib;
using IFix;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace GearUp.Client
{
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

            __result = string.Format("https://localhost?q=gateway&v={0}", Const.GetScriptClientVersion());
        }

        [HarmonyPrefix, HarmonyPatch(typeof(WrappersManagerImpl), nameof(WrappersManagerImpl.IsPatched))]
        public static bool WrappersManagerImpl_IsPatched_Prefix(int id, ref bool __result)
        {
            if (id == 1858)
            {
                Plugin.Log.LogInfo("IFix patch 1858 override to false");
                __result = false;
                return false;
            }

            return true;
        }

        /*[HarmonyPrefix, HarmonyPatch(typeof(DataTools), nameof(DataTools.GetLanguageString), [typeof(int)])]
        public static bool DataTools_GetLanguageString_Int32_Prefix(int languageId, ref string __result)
        {
            if (languageId == 10099999)
            {
                __result = "I'm the thing prevent you from creating a new account after announcement, hehe!";
                Plugin.Log.LogInfo("DataTools.GetLanguageString(int) override");

                // No, this doesn't work as expected...
                // Plugin.Log.LogInfo(Environment.StackTrace);
                return false;
            }
            return true;
        }*/
    }
}