using System;
using System.Reflection;
using MelonLoader;
using Main = ModManager.Main;

[assembly: MelonInfo(typeof(Main), "ModManager", "1.0.0", "Suzimo")]
[assembly: MelonGame("PeroPeroGames", "MuseDash")]

// --- 进阶特性设置 ---
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
// ------------------

[assembly: AssemblyTitle("ModManager")]
[assembly: AssemblyDescription("Beautiful Harmony for Muse Dash")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Muse Dash Modding Community")]
[assembly: AssemblyProduct("ModManager")]
[assembly: AssemblyCopyright("Copyright © 2024")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]