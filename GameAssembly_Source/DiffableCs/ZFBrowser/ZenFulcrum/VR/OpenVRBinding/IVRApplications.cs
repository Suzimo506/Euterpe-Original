namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRApplications
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _AddApplicationManifest : MulticastDelegate
	{

		public _AddApplicationManifest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchApplicationManifestFullPath, bool bTemporary, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchApplicationManifestFullPath, bool bTemporary) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CancelApplicationLaunch : MulticastDelegate
	{

		public _CancelApplicationLaunch(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationAutoLaunch : MulticastDelegate
	{

		public _GetApplicationAutoLaunch(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationCount : MulticastDelegate
	{

		public _GetApplicationCount(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationKeyByIndex : MulticastDelegate
	{

		public _GetApplicationKeyByIndex(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(uint unApplicationIndex, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationKeyByProcessId : MulticastDelegate
	{

		public _GetApplicationKeyByProcessId(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(uint unProcessId, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationLaunchArguments : MulticastDelegate
	{

		public _GetApplicationLaunchArguments(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unHandle, StringBuilder pchArgs, uint unArgs, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(uint unHandle, StringBuilder pchArgs, uint unArgs) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationProcessId : MulticastDelegate
	{

		public _GetApplicationProcessId(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationPropertyBool : MulticastDelegate
	{

		public _GetApplicationPropertyBool(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref EVRApplicationError peError, IAsyncResult result) { }

		public override bool Invoke(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationPropertyString : MulticastDelegate
	{

		public _GetApplicationPropertyString(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVRApplicationError peError, IAsyncResult result) { }

		public override uint Invoke(string pchAppKey, EVRApplicationProperty eProperty, StringBuilder pchPropertyValueBuffer, uint unPropertyValueBufferLen, ref EVRApplicationError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationPropertyUint64 : MulticastDelegate
	{

		public _GetApplicationPropertyUint64(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(ref EVRApplicationError peError, IAsyncResult result) { }

		public override ulong Invoke(string pchAppKey, EVRApplicationProperty eProperty, ref EVRApplicationError peError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationsErrorNameFromEnum : MulticastDelegate
	{

		public _GetApplicationsErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRApplicationError error, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRApplicationError error) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationsThatSupportMimeType : MulticastDelegate
	{

		public _GetApplicationsThatSupportMimeType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(string pchMimeType, StringBuilder pchAppKeysThatSupportBuffer, uint unAppKeysThatSupportBuffer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationsTransitionStateNameFromEnum : MulticastDelegate
	{

		public _GetApplicationsTransitionStateNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRApplicationTransitionState state, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRApplicationTransitionState state) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetApplicationSupportedMimeTypes : MulticastDelegate
	{

		public _GetApplicationSupportedMimeTypes(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchAppKey, StringBuilder pchMimeTypesBuffer, uint unMimeTypesBuffer) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetCurrentSceneProcessId : MulticastDelegate
	{

		public _GetCurrentSceneProcessId(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDefaultApplicationForMimeType : MulticastDelegate
	{

		public _GetDefaultApplicationForMimeType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchMimeType, StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetStartingApplication : MulticastDelegate
	{

		public _GetStartingApplication(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(StringBuilder pchAppKeyBuffer, uint unAppKeyBufferLen) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTransitionState : MulticastDelegate
	{

		public _GetTransitionState(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override EVRApplicationTransitionState EndInvoke(IAsyncResult result) { }

		public override EVRApplicationTransitionState Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IdentifyApplication : MulticastDelegate
	{

		public _IdentifyApplication(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unProcessId, string pchAppKey, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(uint unProcessId, string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsApplicationInstalled : MulticastDelegate
	{

		public _IsApplicationInstalled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsQuitUserPromptRequested : MulticastDelegate
	{

		public _IsQuitUserPromptRequested(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LaunchApplication : MulticastDelegate
	{

		public _LaunchApplication(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LaunchApplicationFromMimeType : MulticastDelegate
	{

		public _LaunchApplicationFromMimeType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchMimeType, string pchArgs, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchMimeType, string pchArgs) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LaunchDashboardOverlay : MulticastDelegate
	{

		public _LaunchDashboardOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LaunchInternalProcess : MulticastDelegate
	{

		public _LaunchInternalProcess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchBinaryPath, string pchArguments, string pchWorkingDirectory, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchBinaryPath, string pchArguments, string pchWorkingDirectory) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _LaunchTemplateApplication : MulticastDelegate
	{

		public _LaunchTemplateApplication(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchTemplateAppKey, string pchNewAppKey, out AppOverrideKeys_t[] pKeys, uint unKeys, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchTemplateAppKey, string pchNewAppKey, out AppOverrideKeys_t[] pKeys, uint unKeys) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PerformApplicationPrelaunchCheck : MulticastDelegate
	{

		public _PerformApplicationPrelaunchCheck(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchAppKey) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _RemoveApplicationManifest : MulticastDelegate
	{

		public _RemoveApplicationManifest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchApplicationManifestFullPath, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchApplicationManifestFullPath) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetApplicationAutoLaunch : MulticastDelegate
	{

		public _SetApplicationAutoLaunch(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, bool bAutoLaunch, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchAppKey, bool bAutoLaunch) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetDefaultApplicationForMimeType : MulticastDelegate
	{

		public _SetDefaultApplicationForMimeType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchAppKey, string pchMimeType, AsyncCallback callback, object object) { }

		public override EVRApplicationError EndInvoke(IAsyncResult result) { }

		public override EVRApplicationError Invoke(string pchAppKey, string pchMimeType) { }

	}

	internal _AddApplicationManifest AddApplicationManifest; //Field offset: 0x0
	internal _RemoveApplicationManifest RemoveApplicationManifest; //Field offset: 0x8
	internal _IsApplicationInstalled IsApplicationInstalled; //Field offset: 0x10
	internal _GetApplicationCount GetApplicationCount; //Field offset: 0x18
	internal _GetApplicationKeyByIndex GetApplicationKeyByIndex; //Field offset: 0x20
	internal _GetApplicationKeyByProcessId GetApplicationKeyByProcessId; //Field offset: 0x28
	internal _LaunchApplication LaunchApplication; //Field offset: 0x30
	internal _LaunchTemplateApplication LaunchTemplateApplication; //Field offset: 0x38
	internal _LaunchApplicationFromMimeType LaunchApplicationFromMimeType; //Field offset: 0x40
	internal _LaunchDashboardOverlay LaunchDashboardOverlay; //Field offset: 0x48
	internal _CancelApplicationLaunch CancelApplicationLaunch; //Field offset: 0x50
	internal _IdentifyApplication IdentifyApplication; //Field offset: 0x58
	internal _GetApplicationProcessId GetApplicationProcessId; //Field offset: 0x60
	internal _GetApplicationsErrorNameFromEnum GetApplicationsErrorNameFromEnum; //Field offset: 0x68
	internal _GetApplicationPropertyString GetApplicationPropertyString; //Field offset: 0x70
	internal _GetApplicationPropertyBool GetApplicationPropertyBool; //Field offset: 0x78
	internal _GetApplicationPropertyUint64 GetApplicationPropertyUint64; //Field offset: 0x80
	internal _SetApplicationAutoLaunch SetApplicationAutoLaunch; //Field offset: 0x88
	internal _GetApplicationAutoLaunch GetApplicationAutoLaunch; //Field offset: 0x90
	internal _SetDefaultApplicationForMimeType SetDefaultApplicationForMimeType; //Field offset: 0x98
	internal _GetDefaultApplicationForMimeType GetDefaultApplicationForMimeType; //Field offset: 0xA0
	internal _GetApplicationSupportedMimeTypes GetApplicationSupportedMimeTypes; //Field offset: 0xA8
	internal _GetApplicationsThatSupportMimeType GetApplicationsThatSupportMimeType; //Field offset: 0xB0
	internal _GetApplicationLaunchArguments GetApplicationLaunchArguments; //Field offset: 0xB8
	internal _GetStartingApplication GetStartingApplication; //Field offset: 0xC0
	internal _GetTransitionState GetTransitionState; //Field offset: 0xC8
	internal _PerformApplicationPrelaunchCheck PerformApplicationPrelaunchCheck; //Field offset: 0xD0
	internal _GetApplicationsTransitionStateNameFromEnum GetApplicationsTransitionStateNameFromEnum; //Field offset: 0xD8
	internal _IsQuitUserPromptRequested IsQuitUserPromptRequested; //Field offset: 0xE0
	internal _LaunchInternalProcess LaunchInternalProcess; //Field offset: 0xE8
	internal _GetCurrentSceneProcessId GetCurrentSceneProcessId; //Field offset: 0xF0

}

