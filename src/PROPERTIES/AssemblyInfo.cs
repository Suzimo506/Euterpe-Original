using System;
using System.Reflection;
using MelonLoader;
using ModManager = Euterpe.Core.ModManager;

[assembly: MelonInfo(typeof(ModManager), "Euterpe", "1.0.0", "Suzimo")]
[assembly: MelonGame("PeroPeroGames", "MuseDash")]

// --- Advanced Feature Flags ---
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonPlatformDomain(MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]
// ------------------

[assembly: AssemblyTitle("Euterpe")]
[assembly: AssemblyDescription("Beautiful Harmony for Muse Dash")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Euterpe Community")]
[assembly: AssemblyProduct("Euterpe")]
[assembly: AssemblyCopyright("Copyright © 2026")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]