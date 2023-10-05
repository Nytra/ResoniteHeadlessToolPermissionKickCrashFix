using FrooxEngine;
using HarmonyLib;
using ResoniteModLoader;
using System;

namespace HeadlessToolPermissionKickCrashFix
{
    public class HeadlessToolPermissionKickCrashFix : ResoniteMod
    {
        public override string Name => "HeadlessToolPermissionKickCrashFix";
        public override string Author => "Nytra / Rucio";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/Nytra/ResoniteHeadlessToolPermissionKickCrashFix";
        public override void OnEngineInit()
        {
            try
            {
                Harmony harmony = new Harmony($"owo.{Author}.{Name}");
                Type resoniteHeadless = AccessTools.TypeByName("FrooxEngine.Headless.Program");
                if (resoniteHeadless != null)
                {
                    harmony.PatchAll();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        [HarmonyPatch(typeof(InteractionHandler))]
        public class InteractionHandlerPatch
        {
            [HarmonyPrefix]
            [HarmonyPatch("ToolDequipped")]
            public static bool CommonTool_ToolDequipped_Prefix(ITool tooltip, ref bool popOff)
            {
                popOff = false;
                return true;
            }
        }
    }
}
