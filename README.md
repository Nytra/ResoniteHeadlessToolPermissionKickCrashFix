# HeadlessToolTipKickCrashFix

A [NeosModLoader](https://github.com/zkxs/NeosModLoader) mod for [Neos](https://neos.com/) Headless Client that prevents tooltip permission kicks from causing a world crash.

This mod fixes the non-builder grabbing builder crash bug.

It must be installed on the Neos Headless Client which is hosting the session for it to work.

This is the specific issue it addresses: https://github.com/Neos-Metaverse/NeosPublic/issues/1693

## Installation
1. Install [NeosModLoader](https://github.com/zkxs/NeosModLoader) for the Headless Client.
1. Place [HeadlessToolTipKickCrashFix.dll](https://github.com/Nytra/NeosHeadlessToolTipKickCrashFix/releases/latest/download/HeadlessToolTipKickCrashFix.dll) into your `nml_mods` folder. This folder should be at `C:\Program Files (x86)\Steam\steamapps\common\NeosVR\HeadlessClient\nml_mods` for a default install. You can create it if it's missing, or if you launch the game once with NeosModLoader installed it will create the folder for you.
1. Start the game. If you want to verify that the mod is working you can check your Neos logs.
