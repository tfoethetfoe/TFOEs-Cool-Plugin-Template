# TFOE's Cool Plugin Template
TFOE's Cool Plugin Template is a template used for developing custom plugins for TFOE's Cool Menu 1.0.3+. This plugin template is meant for plugin developers, if you don't know what you're doing stick to the plugin library.

## Do I need permission to use this?
No, this template is free and public for anyone to use. You are welcome to utilize it for your projects, modify it to suit your needs, and share it with others. We believe in a collaborative and open community where resources are accessible to all.

---

# Installation

- Download the source code
- Change your `<GamePath>` (Gorilla Tag directory) in `Directory.Build.props` if required
- Remove and re-add the TFOE's Cool Menu dependency if required
- Change the plugin namespace by right clicking `TFOEsCoolPlugin` at the top of your Solution Explorer (.csproj, the one with C# next to it), renaming it, then syncing the namespaces 
- Change the plugin name and description in `Plugin.cs`
- Add the mods you like in `PluginMods.cs`
- Edit the plugin methods, names and descriptions in `Plugin.cs`
- Build with `Ctrl` + `Shift` + `B`, it will get put in your custom plugins folder automatically
"# TFOEs-Cool-Plugin-Template" 
