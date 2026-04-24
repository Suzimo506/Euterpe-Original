namespace ZenFulcrum.VR.OpenVRBinding;

public class CVRSystem
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerStatePacked : MulticastDelegate
	{

		public _GetControllerStatePacked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t_Packed pControllerState, IAsyncResult result) { }

		public override bool Invoke(uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerStateWithPosePacked : MulticastDelegate
	{

		public _GetControllerStateWithPosePacked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t_Packed pControllerState, ref TrackedDevicePose_t pTrackedDevicePose, IAsyncResult result) { }

		public override bool Invoke(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t_Packed pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PollNextEventPacked : MulticastDelegate
	{

		public _PollNextEventPacked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref VREvent_t_Packed pEvent, uint uncbVREvent, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VREvent_t_Packed pEvent, IAsyncResult result) { }

		public override bool Invoke(ref VREvent_t_Packed pEvent, uint uncbVREvent) { }

	}

	private struct GetControllerStateUnion
	{
		public _GetControllerState pGetControllerState; //Field offset: 0x0
		public _GetControllerStatePacked pGetControllerStatePacked; //Field offset: 0x0

	}

	private struct GetControllerStateWithPoseUnion
	{
		public _GetControllerStateWithPose pGetControllerStateWithPose; //Field offset: 0x0
		public _GetControllerStateWithPosePacked pGetControllerStateWithPosePacked; //Field offset: 0x0

	}

	private struct PollNextEventUnion
	{
		public _PollNextEvent pPollNextEvent; //Field offset: 0x0
		public _PollNextEventPacked pPollNextEventPacked; //Field offset: 0x0

	}

	private IVRSystem FnTable; //Field offset: 0x10

	internal CVRSystem(IntPtr pInterface) { }

	public void AcknowledgeQuit_Exiting() { }

	public void AcknowledgeQuit_UserPrompt() { }

	public void ApplyTransform(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform) { }

	public bool ComputeDistortion(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates) { }

	public uint DriverDebugRequest(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize) { }

	public uint GetArrayTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError) { }

	public bool GetBoolTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	public string GetButtonIdNameFromEnum(EVRButtonId eButtonId) { }

	public string GetControllerAxisTypeNameFromEnum(EVRControllerAxisType eAxisType) { }

	public ETrackedControllerRole GetControllerRoleForTrackedDeviceIndex(uint unDeviceIndex) { }

	public bool GetControllerState(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize) { }

	public bool GetControllerStateWithPose(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose) { }

	public int GetD3D9AdapterIndex() { }

	public void GetDeviceToAbsoluteTrackingPose(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, TrackedDevicePose_t[] pTrackedDevicePoseArray) { }

	public void GetDXGIOutputInfo(ref int pnAdapterIndex) { }

	public string GetEventTypeNameFromEnum(EVREventType eType) { }

	public HmdMatrix34_t GetEyeToHeadTransform(EVREye eEye) { }

	public float GetFloatTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	public HiddenAreaMesh_t GetHiddenAreaMesh(EVREye eEye, EHiddenAreaMeshType type) { }

	public int GetInt32TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	public HmdMatrix34_t GetMatrix34TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	public void GetOutputDevice(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance) { }

	public HmdMatrix44_t GetProjectionMatrix(EVREye eEye, float fNearZ, float fFarZ) { }

	public void GetProjectionRaw(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom) { }

	public string GetPropErrorNameFromEnum(ETrackedPropertyError error) { }

	public HmdMatrix34_t GetRawZeroPoseToStandingAbsoluteTrackingPose() { }

	public void GetRecommendedRenderTargetSize(ref uint pnWidth, ref uint pnHeight) { }

	public HmdMatrix34_t GetSeatedZeroPoseToStandingAbsoluteTrackingPose() { }

	public uint GetSortedTrackedDeviceIndicesOfClass(ETrackedDeviceClass eTrackedDeviceClass, UInt32[] punTrackedDeviceIndexArray, uint unRelativeToTrackedDeviceIndex) { }

	public uint GetStringTrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError) { }

	public bool GetTimeSinceLastVsync(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter) { }

	public EDeviceActivityLevel GetTrackedDeviceActivityLevel(uint unDeviceId) { }

	public ETrackedDeviceClass GetTrackedDeviceClass(uint unDeviceIndex) { }

	public uint GetTrackedDeviceIndexForControllerRole(ETrackedControllerRole unDeviceType) { }

	public ulong GetUint64TrackedDeviceProperty(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	public bool IsDisplayOnDesktop() { }

	public bool IsInputAvailable() { }

	public bool IsSteamVRDrawingControllers() { }

	public bool IsTrackedDeviceConnected(uint unDeviceIndex) { }

	public EVRFirmwareError PerformFirmwareUpdate(uint unDeviceIndex) { }

	public bool PollNextEvent(ref VREvent_t pEvent, uint uncbVREvent) { }

	public bool PollNextEventWithPose(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose) { }

	public void ResetSeatedZeroPose() { }

	public bool SetDisplayVisibility(bool bIsVisibleOnDesktop) { }

	public bool ShouldApplicationPause() { }

	public bool ShouldApplicationReduceRenderingWork() { }

	public void TriggerHapticPulse(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec) { }

}

