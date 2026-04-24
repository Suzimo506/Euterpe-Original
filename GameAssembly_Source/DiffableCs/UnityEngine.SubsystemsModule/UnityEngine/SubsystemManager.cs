namespace UnityEngine;

[NativeType]
public static class SubsystemManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action reloadSubsytemsStarted; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action reloadSubsytemsCompleted; //Field offset: 0x8

	private static SubsystemManager() { }

	[RequiredByNativeCode]
	private static void Internal_ReloadSubsystemsCompleted() { }

	[RequiredByNativeCode]
	private static void Internal_ReloadSubsystemsStarted() { }

	internal static void ReportSingleSubsystemAnalytics(string id) { }

	internal static void StaticConstructScriptingClassMap() { }

}

