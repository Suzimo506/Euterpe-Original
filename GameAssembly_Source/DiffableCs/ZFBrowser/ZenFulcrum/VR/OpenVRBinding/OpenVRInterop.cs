namespace ZenFulcrum.VR.OpenVRBinding;

public class OpenVRInterop
{

	public OpenVRInterop() { }

	internal static IntPtr GetGenericInterface(in string pchInterfaceVersion, ref EVRInitError peError) { }

	internal static uint GetInitToken() { }

	internal static IntPtr GetStringForHmdError(EVRInitError error) { }

	internal static uint InitInternal(ref EVRInitError peError, EVRApplicationType eApplicationType) { }

	internal static uint InitInternal2(ref EVRInitError peError, EVRApplicationType eApplicationType, in string pStartupInfo) { }

	internal static bool IsHmdPresent() { }

	internal static bool IsInterfaceVersionValid(in string pchInterfaceVersion) { }

	internal static bool IsRuntimeInstalled() { }

	internal static string RuntimePath() { }

	internal static void ShutdownInternal() { }

}

