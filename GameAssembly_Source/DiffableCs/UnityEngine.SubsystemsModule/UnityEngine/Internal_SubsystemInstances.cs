namespace UnityEngine;

internal static class Internal_SubsystemInstances
{
	internal static List<ISubsystem> s_IntegratedSubsystemInstances; //Field offset: 0x0
	internal static List<ISubsystem> s_StandaloneSubsystemInstances; //Field offset: 0x8

	private static Internal_SubsystemInstances() { }

	[RequiredByNativeCode]
	internal static void Internal_ClearManagedInstances() { }

	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCode]
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

}

