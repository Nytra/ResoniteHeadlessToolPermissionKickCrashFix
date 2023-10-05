# HeadlessToolPermissionKickCrashFix

A [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader/) mod for the [Resonite](https://resonite.com/) Headless Server that prevents tool permission kicks from causing a world crash.

This mod fixes the non-builder grabbing builder crash bug.

It must be installed on the Resonite Headless Server which is hosting the session for it to work. Does nothing if installed on a regular client.

This is the specific issue it addresses (From Neos GitHub): https://github.com/Neos-Metaverse/NeosPublic/issues/1693

Thanks to Rucio for porting the mod to Resonite, and thanks to Stiefeljackal and TheSpecterLemon for testing it.

## Installation
1. Install [ResoniteModLoader](https://github.com/resonite-modding-group/ResoniteModLoader/) for the Headless Server.
1. Place [HeadlessToolPermissionKickCrashFix.dll](https://github.com/Nytra/ResoniteHeadlessToolPermissionKickCrashFix/releases/latest/download/HeadlessToolPermissionKickCrashFix.dll) into your `rml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\Resonite\Headless\rml_mods` for a default install. You can create it if it's missing, or if you launch the game once with NeosModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Resonite logs.

## History

Originally https://github.com/Nytra/NeosHeadlessToolTipKickCrashFix
