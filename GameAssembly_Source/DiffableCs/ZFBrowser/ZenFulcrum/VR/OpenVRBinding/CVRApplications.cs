namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRApplications
{
	private IVRApplications FnTable; //Field offset: 0x10

	internal CVRApplications(IntPtr pInterface) { }

	public EVRApplicationError AddApplicationManifest(string pchApplicationManifestFullPath, bool bTemporary) { }

	public bool CancelApplicationLaunch(string pchAppKey) { }

	public bool GetApplicationAutoLaunch(string pchAppKey) { }

	public uint GetApplicationCount() { }

	public EVRApplicationError GetApplicationKeyByIndex(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	public EVRApplicationError GetApplicationKeyByProcessId(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	public uint GetApplicationLaunchArguments(uint unHandle, StringBuilder pchArgs, uint unArgs) { }

	public uint GetApplicationProcessId(string pchAppKey) { }

	public bool GetApplicationPropertyBool(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) { }

	public uint GetApplicationPropertyString(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError) { }

	public ulong GetApplicationPropertyUint64(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) { }

	public string GetApplicationsErrorNameFromEnum(EVRApplicationError error) { }

	public uint GetApplicationsThatSupportMimeType(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer) { }

	public string GetApplicationsTransitionStateNameFromEnum(EVRApplicationTransitionState state) { }

	public bool GetApplicationSupportedMimeTypes(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer) { }

	public uint GetCurrentSceneProcessId() { }

	public bool GetDefaultApplicationForMimeType(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	public EVRApplicationError GetStartingApplication(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	public EVRApplicationTransitionState GetTransitionState() { }

	public EVRApplicationError IdentifyApplication(uint unProcessId, string pchAppKey) { }

	public bool IsApplicationInstalled(string pchAppKey) { }

	public bool IsQuitUserPromptRequested() { }

	public EVRApplicationError LaunchApplication(string pchAppKey) { }

	public EVRApplicationError LaunchApplicationFromMimeType(string pchMimeType, string pchArgs) { }

	public EVRApplicationError LaunchDashboardOverlay(string pchAppKey) { }

	public EVRApplicationError LaunchInternalProcess(string pchBinaryPath, string pchArguments, string pchWorkingDirectory) { }

	public EVRApplicationError LaunchTemplateApplication(string pchTemplateAppKey, string pchNewAppKey, AppOverrideKeys_t[] pKeys) { }

	public EVRApplicationError PerformApplicationPrelaunchCheck(string pchAppKey) { }

	public EVRApplicationError RemoveApplicationManifest(string pchApplicationManifestFullPath) { }

	public EVRApplicationError SetApplicationAutoLaunch(string pchAppKey, bool bAutoLaunch) { }

	public EVRApplicationError SetDefaultApplicationForMimeType(string pchAppKey, string pchMimeType) { }

}

