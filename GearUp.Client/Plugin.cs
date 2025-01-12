using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using DMM.Games.Client.Sdk.Connection;
using HarmonyLib;
using System.Linq;
using System.Reflection;

namespace GearUp.Client;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public const string ServerUrl = "https://localhost/";
    
    new public static readonly ManualLogSource Log = Logger.CreateLogSource(MyPluginInfo.PLUGIN_NAME);

    public override void Load()
    {
        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        Log.LogInfo($"{harmony.GetPatchedMethods().Count()} methods patched!");

        Endpoint.PRODUCTION = ServerUrl + "api/sdk";

        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
