namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVRSystem
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _AcknowledgeQuit_Exiting : MulticastDelegate
	{

		public _AcknowledgeQuit_Exiting(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _AcknowledgeQuit_UserPrompt : MulticastDelegate
	{

		public _AcknowledgeQuit_UserPrompt(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ApplyTransform : MulticastDelegate
	{

		public _ApplyTransform(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform, IAsyncResult result) { }

		public override void Invoke(ref TrackedDevicePose_t pOutputPose, ref TrackedDevicePose_t pTrackedDevicePose, ref HmdMatrix34_t pTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ComputeDistortion : MulticastDelegate
	{

		public _ComputeDistortion(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref DistortionCoordinates_t pDistortionCoordinates, IAsyncResult result) { }

		public override bool Invoke(EVREye eEye, float fU, float fV, ref DistortionCoordinates_t pDistortionCoordinates) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _DriverDebugRequest : MulticastDelegate
	{

		public _DriverDebugRequest(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(uint unDeviceIndex, string pchRequest, StringBuilder pchResponseBuffer, uint unResponseBufferSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetArrayTrackedDeviceProperty : MulticastDelegate
	{

		public _GetArrayTrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override uint Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, uint propType, IntPtr pBuffer, uint unBufferSize, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetBoolTrackedDeviceProperty : MulticastDelegate
	{

		public _GetBoolTrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override bool Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetButtonIdNameFromEnum : MulticastDelegate
	{

		public _GetButtonIdNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRButtonId eButtonId, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRButtonId eButtonId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerAxisTypeNameFromEnum : MulticastDelegate
	{

		public _GetControllerAxisTypeNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVRControllerAxisType eAxisType, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVRControllerAxisType eAxisType) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerRoleForTrackedDeviceIndex : MulticastDelegate
	{

		public _GetControllerRoleForTrackedDeviceIndex(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, AsyncCallback callback, object object) { }

		public override ETrackedControllerRole EndInvoke(IAsyncResult result) { }

		public override ETrackedControllerRole Invoke(uint unDeviceIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerState : MulticastDelegate
	{

		public _GetControllerState(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t pControllerState, IAsyncResult result) { }

		public override bool Invoke(uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetControllerStateWithPose : MulticastDelegate
	{

		public _GetControllerStateWithPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VRControllerState_t pControllerState, ref TrackedDevicePose_t pTrackedDevicePose, IAsyncResult result) { }

		public override bool Invoke(ETrackingUniverseOrigin eOrigin, uint unControllerDeviceIndex, ref VRControllerState_t pControllerState, uint unControllerStateSize, ref TrackedDevicePose_t pTrackedDevicePose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetD3D9AdapterIndex : MulticastDelegate
	{

		public _GetD3D9AdapterIndex(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDeviceToAbsoluteTrackingPose : MulticastDelegate
	{

		public _GetDeviceToAbsoluteTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, out TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ETrackingUniverseOrigin eOrigin, float fPredictedSecondsToPhotonsFromNow, out TrackedDevicePose_t[] pTrackedDevicePoseArray, uint unTrackedDevicePoseArrayCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDXGIOutputInfo : MulticastDelegate
	{

		public _GetDXGIOutputInfo(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref int pnAdapterIndex, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref int pnAdapterIndex, IAsyncResult result) { }

		public override void Invoke(ref int pnAdapterIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetEventTypeNameFromEnum : MulticastDelegate
	{

		public _GetEventTypeNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREventType eType, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVREventType eType) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetEyeToHeadTransform : MulticastDelegate
	{

		public _GetEyeToHeadTransform(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, AsyncCallback callback, object object) { }

		public override HmdMatrix34_t EndInvoke(IAsyncResult result) { }

		public override HmdMatrix34_t Invoke(EVREye eEye) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetFloatTrackedDeviceProperty : MulticastDelegate
	{

		public _GetFloatTrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override float EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override float Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetHiddenAreaMesh : MulticastDelegate
	{

		public _GetHiddenAreaMesh(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, EHiddenAreaMeshType type, AsyncCallback callback, object object) { }

		public override HiddenAreaMesh_t EndInvoke(IAsyncResult result) { }

		public override HiddenAreaMesh_t Invoke(EVREye eEye, EHiddenAreaMeshType type) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetInt32TrackedDeviceProperty : MulticastDelegate
	{

		public _GetInt32TrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override int EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override int Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetMatrix34TrackedDeviceProperty : MulticastDelegate
	{

		public _GetMatrix34TrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override HmdMatrix34_t EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override HmdMatrix34_t Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOutputDevice : MulticastDelegate
	{

		public _GetOutputDevice(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref ulong pnDevice, IAsyncResult result) { }

		public override void Invoke(ref ulong pnDevice, ETextureType textureType, IntPtr pInstance) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetProjectionMatrix : MulticastDelegate
	{

		public _GetProjectionMatrix(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, float fNearZ, float fFarZ, AsyncCallback callback, object object) { }

		public override HmdMatrix44_t EndInvoke(IAsyncResult result) { }

		public override HmdMatrix44_t Invoke(EVREye eEye, float fNearZ, float fFarZ) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetProjectionRaw : MulticastDelegate
	{

		public _GetProjectionRaw(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom, IAsyncResult result) { }

		public override void Invoke(EVREye eEye, ref float pfLeft, ref float pfRight, ref float pfTop, ref float pfBottom) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetPropErrorNameFromEnum : MulticastDelegate
	{

		public _GetPropErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackedPropertyError error, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(ETrackedPropertyError error) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRawZeroPoseToStandingAbsoluteTrackingPose : MulticastDelegate
	{

		public _GetRawZeroPoseToStandingAbsoluteTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override HmdMatrix34_t EndInvoke(IAsyncResult result) { }

		public override HmdMatrix34_t Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetRecommendedRenderTargetSize : MulticastDelegate
	{

		public _GetRecommendedRenderTargetSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref uint pnWidth, ref uint pnHeight, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref uint pnWidth, ref uint pnHeight, IAsyncResult result) { }

		public override void Invoke(ref uint pnWidth, ref uint pnHeight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSeatedZeroPoseToStandingAbsoluteTrackingPose : MulticastDelegate
	{

		public _GetSeatedZeroPoseToStandingAbsoluteTrackingPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override HmdMatrix34_t EndInvoke(IAsyncResult result) { }

		public override HmdMatrix34_t Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetSortedTrackedDeviceIndicesOfClass : MulticastDelegate
	{

		public _GetSortedTrackedDeviceIndicesOfClass(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackedDeviceClass eTrackedDeviceClass, out UInt32[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(ETrackedDeviceClass eTrackedDeviceClass, out UInt32[] punTrackedDeviceIndexArray, uint unTrackedDeviceIndexArrayCount, uint unRelativeToTrackedDeviceIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetStringTrackedDeviceProperty : MulticastDelegate
	{

		public _GetStringTrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override uint Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, StringBuilder pchValue, uint unBufferSize, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTimeSinceLastVsync : MulticastDelegate
	{

		public _GetTimeSinceLastVsync(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter, IAsyncResult result) { }

		public override bool Invoke(ref float pfSecondsSinceLastVsync, ref ulong pulFrameCounter) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTrackedDeviceActivityLevel : MulticastDelegate
	{

		public _GetTrackedDeviceActivityLevel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceId, AsyncCallback callback, object object) { }

		public override EDeviceActivityLevel EndInvoke(IAsyncResult result) { }

		public override EDeviceActivityLevel Invoke(uint unDeviceId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTrackedDeviceClass : MulticastDelegate
	{

		public _GetTrackedDeviceClass(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, AsyncCallback callback, object object) { }

		public override ETrackedDeviceClass EndInvoke(IAsyncResult result) { }

		public override ETrackedDeviceClass Invoke(uint unDeviceIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTrackedDeviceIndexForControllerRole : MulticastDelegate
	{

		public _GetTrackedDeviceIndexForControllerRole(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackedControllerRole unDeviceType, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(ETrackedControllerRole unDeviceType) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetUint64TrackedDeviceProperty : MulticastDelegate
	{

		public _GetUint64TrackedDeviceProperty(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError, AsyncCallback callback, object object) { }

		public override ulong EndInvoke(ref ETrackedPropertyError pError, IAsyncResult result) { }

		public override ulong Invoke(uint unDeviceIndex, ETrackedDeviceProperty prop, ref ETrackedPropertyError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsDisplayOnDesktop : MulticastDelegate
	{

		public _IsDisplayOnDesktop(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsInputAvailable : MulticastDelegate
	{

		public _IsInputAvailable(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsSteamVRDrawingControllers : MulticastDelegate
	{

		public _IsSteamVRDrawingControllers(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsTrackedDeviceConnected : MulticastDelegate
	{

		public _IsTrackedDeviceConnected(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(uint unDeviceIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PerformFirmwareUpdate : MulticastDelegate
	{

		public _PerformFirmwareUpdate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unDeviceIndex, AsyncCallback callback, object object) { }

		public override EVRFirmwareError EndInvoke(IAsyncResult result) { }

		public override EVRFirmwareError Invoke(uint unDeviceIndex) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PollNextEvent : MulticastDelegate
	{

		public _PollNextEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ref VREvent_t pEvent, uint uncbVREvent, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VREvent_t pEvent, IAsyncResult result) { }

		public override bool Invoke(ref VREvent_t pEvent, uint uncbVREvent) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PollNextEventWithPose : MulticastDelegate
	{

		public _PollNextEventWithPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VREvent_t pEvent, ref TrackedDevicePose_t pTrackedDevicePose, IAsyncResult result) { }

		public override bool Invoke(ETrackingUniverseOrigin eOrigin, ref VREvent_t pEvent, uint uncbVREvent, ref TrackedDevicePose_t pTrackedDevicePose) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ResetSeatedZeroPose : MulticastDelegate
	{

		public _ResetSeatedZeroPose(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetDisplayVisibility : MulticastDelegate
	{

		public _SetDisplayVisibility(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool bIsVisibleOnDesktop, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(bool bIsVisibleOnDesktop) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShouldApplicationPause : MulticastDelegate
	{

		public _ShouldApplicationPause(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShouldApplicationReduceRenderingWork : MulticastDelegate
	{

		public _ShouldApplicationReduceRenderingWork(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _TriggerHapticPulse : MulticastDelegate
	{

		public _TriggerHapticPulse(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(uint unControllerDeviceIndex, uint unAxisId, ushort usDurationMicroSec) { }

	}

	internal _GetRecommendedRenderTargetSize GetRecommendedRenderTargetSize; //Field offset: 0x0
	internal _GetProjectionMatrix GetProjectionMatrix; //Field offset: 0x8
	internal _GetProjectionRaw GetProjectionRaw; //Field offset: 0x10
	internal _ComputeDistortion ComputeDistortion; //Field offset: 0x18
	internal _GetEyeToHeadTransform GetEyeToHeadTransform; //Field offset: 0x20
	internal _GetTimeSinceLastVsync GetTimeSinceLastVsync; //Field offset: 0x28
	internal _GetD3D9AdapterIndex GetD3D9AdapterIndex; //Field offset: 0x30
	internal _GetDXGIOutputInfo GetDXGIOutputInfo; //Field offset: 0x38
	internal _GetOutputDevice GetOutputDevice; //Field offset: 0x40
	internal _IsDisplayOnDesktop IsDisplayOnDesktop; //Field offset: 0x48
	internal _SetDisplayVisibility SetDisplayVisibility; //Field offset: 0x50
	internal _GetDeviceToAbsoluteTrackingPose GetDeviceToAbsoluteTrackingPose; //Field offset: 0x58
	internal _ResetSeatedZeroPose ResetSeatedZeroPose; //Field offset: 0x60
	internal _GetSeatedZeroPoseToStandingAbsoluteTrackingPose GetSeatedZeroPoseToStandingAbsoluteTrackingPose; //Field offset: 0x68
	internal _GetRawZeroPoseToStandingAbsoluteTrackingPose GetRawZeroPoseToStandingAbsoluteTrackingPose; //Field offset: 0x70
	internal _GetSortedTrackedDeviceIndicesOfClass GetSortedTrackedDeviceIndicesOfClass; //Field offset: 0x78
	internal _GetTrackedDeviceActivityLevel GetTrackedDeviceActivityLevel; //Field offset: 0x80
	internal _ApplyTransform ApplyTransform; //Field offset: 0x88
	internal _GetTrackedDeviceIndexForControllerRole GetTrackedDeviceIndexForControllerRole; //Field offset: 0x90
	internal _GetControllerRoleForTrackedDeviceIndex GetControllerRoleForTrackedDeviceIndex; //Field offset: 0x98
	internal _GetTrackedDeviceClass GetTrackedDeviceClass; //Field offset: 0xA0
	internal _IsTrackedDeviceConnected IsTrackedDeviceConnected; //Field offset: 0xA8
	internal _GetBoolTrackedDeviceProperty GetBoolTrackedDeviceProperty; //Field offset: 0xB0
	internal _GetFloatTrackedDeviceProperty GetFloatTrackedDeviceProperty; //Field offset: 0xB8
	internal _GetInt32TrackedDeviceProperty GetInt32TrackedDeviceProperty; //Field offset: 0xC0
	internal _GetUint64TrackedDeviceProperty GetUint64TrackedDeviceProperty; //Field offset: 0xC8
	internal _GetMatrix34TrackedDeviceProperty GetMatrix34TrackedDeviceProperty; //Field offset: 0xD0
	internal _GetArrayTrackedDeviceProperty GetArrayTrackedDeviceProperty; //Field offset: 0xD8
	internal _GetStringTrackedDeviceProperty GetStringTrackedDeviceProperty; //Field offset: 0xE0
	internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum; //Field offset: 0xE8
	internal _PollNextEvent PollNextEvent; //Field offset: 0xF0
	internal _PollNextEventWithPose PollNextEventWithPose; //Field offset: 0xF8
	internal _GetEventTypeNameFromEnum GetEventTypeNameFromEnum; //Field offset: 0x100
	internal _GetHiddenAreaMesh GetHiddenAreaMesh; //Field offset: 0x108
	internal _GetControllerState GetControllerState; //Field offset: 0x110
	internal _GetControllerStateWithPose GetControllerStateWithPose; //Field offset: 0x118
	internal _TriggerHapticPulse TriggerHapticPulse; //Field offset: 0x120
	internal _GetButtonIdNameFromEnum GetButtonIdNameFromEnum; //Field offset: 0x128
	internal _GetControllerAxisTypeNameFromEnum GetControllerAxisTypeNameFromEnum; //Field offset: 0x130
	internal _IsInputAvailable IsInputAvailable; //Field offset: 0x138
	internal _IsSteamVRDrawingControllers IsSteamVRDrawingControllers; //Field offset: 0x140
	internal _ShouldApplicationPause ShouldApplicationPause; //Field offset: 0x148
	internal _ShouldApplicationReduceRenderingWork ShouldApplicationReduceRenderingWork; //Field offset: 0x150
	internal _DriverDebugRequest DriverDebugRequest; //Field offset: 0x158
	internal _PerformFirmwareUpdate PerformFirmwareUpdate; //Field offset: 0x160
	internal _AcknowledgeQuit_Exiting AcknowledgeQuit_Exiting; //Field offset: 0x168
	internal _AcknowledgeQuit_UserPrompt AcknowledgeQuit_UserPrompt; //Field offset: 0x170

}

