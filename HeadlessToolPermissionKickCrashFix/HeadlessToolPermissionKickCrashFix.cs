using FrooxEngine;
using HarmonyLib;
using NeosModLoader;
using System.Reflection;
using System;

namespace HeadlessToolTipKickCrashFix
{
    public class HeadlessToolTipKickCrashFix : NeosMod
    {
        public override string Name => "HeadlessToolTipKickCrashFix";
        public override string Author => "Nytra";
        public override string Version => "1.0.1";
        public override string Link => "https://github.com/Nytra/NeosHeadlessToolTipKickCrashFix";
        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony($"owo.{Author}.{Name}");

            // Check if we are loaded by a headless client
            // (Thanks to HeadlessTweaks for this next line)
            Type neosHeadless = AccessTools.TypeByName("NeosHeadless.Program");
            if (neosHeadless != null)
            {
                MethodInfo originalMethod = AccessTools.DeclaredMethod(typeof(CommonTool), "TooltipDequipped", new Type[] { typeof(IToolTip), typeof(bool) });
                MethodInfo replacementMethod = AccessTools.DeclaredMethod(typeof(HeadlessToolTipKickCrashFix), nameof(CommonTool_TooltipDequipped_Prefix));
                harmony.Patch(originalMethod, prefix: new HarmonyMethod(replacementMethod));
            }
        }

        public static bool CommonTool_TooltipDequipped_Prefix(IToolTip tooltip, ref bool popOff)
        {
            popOff = false;
            return true;
        }
    }
}
