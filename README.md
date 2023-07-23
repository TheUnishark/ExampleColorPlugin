# Example Color Plugin

Example Color Plugin is an example plugin for the Broke Protocol plugin **[ColorSystem](#)** that brings a system to change entities primary and secondary color.
This plugin adds the commands `/color1 (byte)red (byte)green (byte)blue` and `/color2 (byte)red (byte)green (byte)blue` to change the player's vehicle colors, and the permission `ecp.color` to execute the commands.

## Install the plugin
1. Download [ColorSystem](#) from Steam (or use the [Steam Workshop Downloader](https://james121op.me/toolbox/steamworkshopdownloader/) by James).
2. Copy the plugin from `Steam\steamapps\workshop\content\696370\XXX` (or where you downloaded it) to `BROKE PROTOCOL\Plugins`
3. Download the [latest version](https://github.com/TheUnishark/ExampleColorPlugin/releases/latest) of the plugin.
4. Put the file in the `BROKE PROTOCOL\Plugins` directory.
5. Add the permission `ecp.color` to the desired group(s).
6. Start your server or Offline Mode.
7. You can now use `/color1` and `/color2` in compatible vehicles!

## Build the plugin
1. Set the environment variable `BPDIR` to your Broke Protocol directory (or change every `$(BPDIR)` instances to your BP directory path in the csproj file).
2. Build the project using any IDE.
3. The plugin should be automatically copied to your BP Plugins directory.
