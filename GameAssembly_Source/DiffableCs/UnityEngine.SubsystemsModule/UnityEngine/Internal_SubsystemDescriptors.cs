namespace UnityEngine;

internal static class Internal_SubsystemDescriptors
{
	internal static List<ISubsystemDescriptorImpl> s_IntegratedSubsystemDescriptors; //Field offset: 0x0
	internal static List<ISubsystemDescriptor> s_StandaloneSubsystemDescriptors; //Field offset: 0x8

	private static Internal_SubsystemDescriptors() { }

	[RequiredByNativeCode]
	internal static bool Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	[RequiredByNativeCode]
	internal static void Internal_ClearManagedDescriptors() { }

	[RequiredByNativeCode]
	internal static void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

}

