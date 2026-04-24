namespace ZenFulcrum.VR.OpenVRBinding;

public struct IVROverlay
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ClearOverlayTexture : MulticastDelegate
	{

		public _ClearOverlayTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CloseMessageOverlay : MulticastDelegate
	{

		public _CloseMessageOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ComputeOverlayIntersection : MulticastDelegate
	{

		public _ComputeOverlayIntersection(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults, IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CreateDashboardOverlay : MulticastDelegate
	{

		public _CreateDashboardOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref ulong pMainHandle, ref ulong pThumbnailHandle, IAsyncResult result) { }

		public override EVROverlayError Invoke(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _CreateOverlay : MulticastDelegate
	{

		public _CreateOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref ulong pOverlayHandle, IAsyncResult result) { }

		public override EVROverlayError Invoke(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _DestroyOverlay : MulticastDelegate
	{

		public _DestroyOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _FindOverlay : MulticastDelegate
	{

		public _FindOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchOverlayKey, ref ulong pOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref ulong pOverlayHandle, IAsyncResult result) { }

		public override EVROverlayError Invoke(string pchOverlayKey, ref ulong pOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetDashboardOverlaySceneProcess : MulticastDelegate
	{

		public _GetDashboardOverlaySceneProcess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint punProcessId, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint punProcessId, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint punProcessId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetGamepadFocusOverlay : MulticastDelegate
	{

		public _GetGamepadFocusOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetHighQualityOverlay : MulticastDelegate
	{

		public _GetHighQualityOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override ulong EndInvoke(IAsyncResult result) { }

		public override ulong Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetKeyboardText : MulticastDelegate
	{

		public _GetKeyboardText(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(StringBuilder pchText, uint cchText, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(StringBuilder pchText, uint cchText) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayAlpha : MulticastDelegate
	{

		public _GetOverlayAlpha(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref float pfAlpha, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref float pfAlpha, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref float pfAlpha) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayAutoCurveDistanceRangeInMeters : MulticastDelegate
	{

		public _GetOverlayAutoCurveDistanceRangeInMeters(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayColor : MulticastDelegate
	{

		public _GetOverlayColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref float pfRed, ref float pfGreen, ref float pfBlue, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayDualAnalogTransform : MulticastDelegate
	{

		public _GetOverlayDualAnalogTransform(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdVector2_t pvCenter, ref float pfRadius, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayErrorNameFromEnum : MulticastDelegate
	{

		public _GetOverlayErrorNameFromEnum(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EVROverlayError error, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(EVROverlayError error) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayFlag : MulticastDelegate
	{

		public _GetOverlayFlag(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref bool pbEnabled, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayFlags : MulticastDelegate
	{

		public _GetOverlayFlags(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint pFlags, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint pFlags, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint pFlags) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayImageData : MulticastDelegate
	{

		public _GetOverlayImageData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint punWidth, ref uint punHeight, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayInputMethod : MulticastDelegate
	{

		public _GetOverlayInputMethod(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref VROverlayInputMethod peInputMethod, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayKey : MulticastDelegate
	{

		public _GetOverlayKey(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVROverlayError pError, IAsyncResult result) { }

		public override uint Invoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayMouseScale : MulticastDelegate
	{

		public _GetOverlayMouseScale(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdVector2_t pvecMouseScale, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayName : MulticastDelegate
	{

		public _GetOverlayName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref EVROverlayError pError, IAsyncResult result) { }

		public override uint Invoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayRenderingPid : MulticastDelegate
	{

		public _GetOverlayRenderingPid(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayRenderModel : MulticastDelegate
	{

		public _GetOverlayRenderModel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError, AsyncCallback callback, object object) { }

		public override uint EndInvoke(ref HmdColor_t pColor, ref EVROverlayError pError, IAsyncResult result) { }

		public override uint Invoke(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlaySortOrder : MulticastDelegate
	{

		public _GetOverlaySortOrder(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint punSortOrder, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint punSortOrder, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint punSortOrder) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTexelAspect : MulticastDelegate
	{

		public _GetOverlayTexelAspect(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref float pfTexelAspect, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref float pfTexelAspect, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref float pfTexelAspect) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTexture : MulticastDelegate
	{

		public _GetOverlayTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref IntPtr pNativeTextureHandle, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTextureBounds : MulticastDelegate
	{

		public _GetOverlayTextureBounds(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref VRTextureBounds_t pOverlayTextureBounds, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTextureColorSpace : MulticastDelegate
	{

		public _GetOverlayTextureColorSpace(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref EColorSpace peTextureColorSpace, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTextureSize : MulticastDelegate
	{

		public _GetOverlayTextureSize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint pWidth, ref uint pHeight, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTransformAbsolute : MulticastDelegate
	{

		public _GetOverlayTransformAbsolute(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTransformOverlayRelative : MulticastDelegate
	{

		public _GetOverlayTransformOverlayRelative(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTransformTrackedDeviceComponent : MulticastDelegate
	{

		public _GetOverlayTransformTrackedDeviceComponent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint punDeviceIndex, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTransformTrackedDeviceRelative : MulticastDelegate
	{

		public _GetOverlayTransformTrackedDeviceRelative(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayTransformType : MulticastDelegate
	{

		public _GetOverlayTransformType(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref VROverlayTransformType peTransformType, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetOverlayWidthInMeters : MulticastDelegate
	{

		public _GetOverlayWidthInMeters(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref float pfWidthInMeters, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref float pfWidthInMeters, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref float pfWidthInMeters) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetPrimaryDashboardDevice : MulticastDelegate
	{

		public _GetPrimaryDashboardDevice(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override uint EndInvoke(IAsyncResult result) { }

		public override uint Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _GetTransformForOverlayCoordinates : MulticastDelegate
	{

		public _GetTransformForOverlayCoordinates(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdMatrix34_t pmatTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HideKeyboard : MulticastDelegate
	{

		public _HideKeyboard(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _HideOverlay : MulticastDelegate
	{

		public _HideOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsActiveDashboardOverlay : MulticastDelegate
	{

		public _IsActiveDashboardOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsDashboardVisible : MulticastDelegate
	{

		public _IsDashboardVisible(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsHoverTargetOverlay : MulticastDelegate
	{

		public _IsHoverTargetOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _IsOverlayVisible : MulticastDelegate
	{

		public _IsOverlayVisible(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _MoveGamepadFocusToNeighbor : MulticastDelegate
	{

		public _MoveGamepadFocusToNeighbor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EOverlayDirection eDirection, ulong ulFrom, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(EOverlayDirection eDirection, ulong ulFrom) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PollNextOverlayEvent : MulticastDelegate
	{

		public _PollNextOverlayEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VREvent_t pEvent, IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ReleaseNativeOverlayHandle : MulticastDelegate
	{

		public _ReleaseNativeOverlayHandle(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, IntPtr pNativeTextureHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, IntPtr pNativeTextureHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetDashboardOverlaySceneProcess : MulticastDelegate
	{

		public _SetDashboardOverlaySceneProcess(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, uint unProcessId, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, uint unProcessId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetGamepadFocusOverlay : MulticastDelegate
	{

		public _SetGamepadFocusOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulNewFocusOverlay, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulNewFocusOverlay) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetHighQualityOverlay : MulticastDelegate
	{

		public _SetHighQualityOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetKeyboardPositionForOverlay : MulticastDelegate
	{

		public _SetKeyboardPositionForOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, HmdRect2_t avoidRect, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(ulong ulOverlayHandle, HmdRect2_t avoidRect) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetKeyboardTransformAbsolute : MulticastDelegate
	{

		public _SetKeyboardTransformAbsolute(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform, IAsyncResult result) { }

		public override void Invoke(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayAlpha : MulticastDelegate
	{

		public _SetOverlayAlpha(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, float fAlpha, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, float fAlpha) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayAutoCurveDistanceRangeInMeters : MulticastDelegate
	{

		public _SetOverlayAutoCurveDistanceRangeInMeters(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayColor : MulticastDelegate
	{

		public _SetOverlayColor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayDualAnalogTransform : MulticastDelegate
	{

		public _SetOverlayDualAnalogTransform(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, float fRadius, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdVector2_t pvCenter, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, float fRadius) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayFlag : MulticastDelegate
	{

		public _SetOverlayFlag(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayFromFile : MulticastDelegate
	{

		public _SetOverlayFromFile(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, string pchFilePath, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, string pchFilePath) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayInputMethod : MulticastDelegate
	{

		public _SetOverlayInputMethod(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayIntersectionMask : MulticastDelegate
	{

		public _SetOverlayIntersectionMask(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayMouseScale : MulticastDelegate
	{

		public _SetOverlayMouseScale(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdVector2_t pvecMouseScale, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayName : MulticastDelegate
	{

		public _SetOverlayName(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, string pchName, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, string pchName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayNeighbor : MulticastDelegate
	{

		public _SetOverlayNeighbor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayRaw : MulticastDelegate
	{

		public _SetOverlayRaw(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayRenderingPid : MulticastDelegate
	{

		public _SetOverlayRenderingPid(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, uint unPID, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, uint unPID) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayRenderModel : MulticastDelegate
	{

		public _SetOverlayRenderModel(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdColor_t pColor, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlaySortOrder : MulticastDelegate
	{

		public _SetOverlaySortOrder(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, uint unSortOrder, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, uint unSortOrder) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTexelAspect : MulticastDelegate
	{

		public _SetOverlayTexelAspect(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, float fTexelAspect, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, float fTexelAspect) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTexture : MulticastDelegate
	{

		public _SetOverlayTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref Texture_t pTexture, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref Texture_t pTexture, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref Texture_t pTexture) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTextureBounds : MulticastDelegate
	{

		public _SetOverlayTextureBounds(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref VRTextureBounds_t pOverlayTextureBounds, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTextureColorSpace : MulticastDelegate
	{

		public _SetOverlayTextureColorSpace(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, EColorSpace eTextureColorSpace, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, EColorSpace eTextureColorSpace) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTransformAbsolute : MulticastDelegate
	{

		public _SetOverlayTransformAbsolute(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTransformOverlayRelative : MulticastDelegate
	{

		public _SetOverlayTransformOverlayRelative(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdMatrix34_t pmatParentOverlayToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTransformTrackedDeviceComponent : MulticastDelegate
	{

		public _SetOverlayTransformTrackedDeviceComponent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayTransformTrackedDeviceRelative : MulticastDelegate
	{

		public _SetOverlayTransformTrackedDeviceRelative(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform, IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _SetOverlayWidthInMeters : MulticastDelegate
	{

		public _SetOverlayWidthInMeters(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, float fWidthInMeters, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, float fWidthInMeters) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowDashboard : MulticastDelegate
	{

		public _ShowDashboard(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchOverlayToShow, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string pchOverlayToShow) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowKeyboard : MulticastDelegate
	{

		public _ShowKeyboard(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowKeyboardForOverlay : MulticastDelegate
	{

		public _ShowKeyboardForOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowMessageOverlay : MulticastDelegate
	{

		public _ShowMessageOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text, AsyncCallback callback, object object) { }

		public override VRMessageOverlayResponse EndInvoke(IAsyncResult result) { }

		public override VRMessageOverlayResponse Invoke(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _ShowOverlay : MulticastDelegate
	{

		public _ShowOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, AsyncCallback callback, object object) { }

		public override EVROverlayError EndInvoke(IAsyncResult result) { }

		public override EVROverlayError Invoke(ulong ulOverlayHandle) { }

	}

	internal _FindOverlay FindOverlay; //Field offset: 0x0
	internal _CreateOverlay CreateOverlay; //Field offset: 0x8
	internal _DestroyOverlay DestroyOverlay; //Field offset: 0x10
	internal _SetHighQualityOverlay SetHighQualityOverlay; //Field offset: 0x18
	internal _GetHighQualityOverlay GetHighQualityOverlay; //Field offset: 0x20
	internal _GetOverlayKey GetOverlayKey; //Field offset: 0x28
	internal _GetOverlayName GetOverlayName; //Field offset: 0x30
	internal _SetOverlayName SetOverlayName; //Field offset: 0x38
	internal _GetOverlayImageData GetOverlayImageData; //Field offset: 0x40
	internal _GetOverlayErrorNameFromEnum GetOverlayErrorNameFromEnum; //Field offset: 0x48
	internal _SetOverlayRenderingPid SetOverlayRenderingPid; //Field offset: 0x50
	internal _GetOverlayRenderingPid GetOverlayRenderingPid; //Field offset: 0x58
	internal _SetOverlayFlag SetOverlayFlag; //Field offset: 0x60
	internal _GetOverlayFlag GetOverlayFlag; //Field offset: 0x68
	internal _SetOverlayColor SetOverlayColor; //Field offset: 0x70
	internal _GetOverlayColor GetOverlayColor; //Field offset: 0x78
	internal _SetOverlayAlpha SetOverlayAlpha; //Field offset: 0x80
	internal _GetOverlayAlpha GetOverlayAlpha; //Field offset: 0x88
	internal _SetOverlayTexelAspect SetOverlayTexelAspect; //Field offset: 0x90
	internal _GetOverlayTexelAspect GetOverlayTexelAspect; //Field offset: 0x98
	internal _SetOverlaySortOrder SetOverlaySortOrder; //Field offset: 0xA0
	internal _GetOverlaySortOrder GetOverlaySortOrder; //Field offset: 0xA8
	internal _SetOverlayWidthInMeters SetOverlayWidthInMeters; //Field offset: 0xB0
	internal _GetOverlayWidthInMeters GetOverlayWidthInMeters; //Field offset: 0xB8
	internal _SetOverlayAutoCurveDistanceRangeInMeters SetOverlayAutoCurveDistanceRangeInMeters; //Field offset: 0xC0
	internal _GetOverlayAutoCurveDistanceRangeInMeters GetOverlayAutoCurveDistanceRangeInMeters; //Field offset: 0xC8
	internal _SetOverlayTextureColorSpace SetOverlayTextureColorSpace; //Field offset: 0xD0
	internal _GetOverlayTextureColorSpace GetOverlayTextureColorSpace; //Field offset: 0xD8
	internal _SetOverlayTextureBounds SetOverlayTextureBounds; //Field offset: 0xE0
	internal _GetOverlayTextureBounds GetOverlayTextureBounds; //Field offset: 0xE8
	internal _GetOverlayRenderModel GetOverlayRenderModel; //Field offset: 0xF0
	internal _SetOverlayRenderModel SetOverlayRenderModel; //Field offset: 0xF8
	internal _GetOverlayTransformType GetOverlayTransformType; //Field offset: 0x100
	internal _SetOverlayTransformAbsolute SetOverlayTransformAbsolute; //Field offset: 0x108
	internal _GetOverlayTransformAbsolute GetOverlayTransformAbsolute; //Field offset: 0x110
	internal _SetOverlayTransformTrackedDeviceRelative SetOverlayTransformTrackedDeviceRelative; //Field offset: 0x118
	internal _GetOverlayTransformTrackedDeviceRelative GetOverlayTransformTrackedDeviceRelative; //Field offset: 0x120
	internal _SetOverlayTransformTrackedDeviceComponent SetOverlayTransformTrackedDeviceComponent; //Field offset: 0x128
	internal _GetOverlayTransformTrackedDeviceComponent GetOverlayTransformTrackedDeviceComponent; //Field offset: 0x130
	internal _GetOverlayTransformOverlayRelative GetOverlayTransformOverlayRelative; //Field offset: 0x138
	internal _SetOverlayTransformOverlayRelative SetOverlayTransformOverlayRelative; //Field offset: 0x140
	internal _ShowOverlay ShowOverlay; //Field offset: 0x148
	internal _HideOverlay HideOverlay; //Field offset: 0x150
	internal _IsOverlayVisible IsOverlayVisible; //Field offset: 0x158
	internal _GetTransformForOverlayCoordinates GetTransformForOverlayCoordinates; //Field offset: 0x160
	internal _PollNextOverlayEvent PollNextOverlayEvent; //Field offset: 0x168
	internal _GetOverlayInputMethod GetOverlayInputMethod; //Field offset: 0x170
	internal _SetOverlayInputMethod SetOverlayInputMethod; //Field offset: 0x178
	internal _GetOverlayMouseScale GetOverlayMouseScale; //Field offset: 0x180
	internal _SetOverlayMouseScale SetOverlayMouseScale; //Field offset: 0x188
	internal _ComputeOverlayIntersection ComputeOverlayIntersection; //Field offset: 0x190
	internal _IsHoverTargetOverlay IsHoverTargetOverlay; //Field offset: 0x198
	internal _GetGamepadFocusOverlay GetGamepadFocusOverlay; //Field offset: 0x1A0
	internal _SetGamepadFocusOverlay SetGamepadFocusOverlay; //Field offset: 0x1A8
	internal _SetOverlayNeighbor SetOverlayNeighbor; //Field offset: 0x1B0
	internal _MoveGamepadFocusToNeighbor MoveGamepadFocusToNeighbor; //Field offset: 0x1B8
	internal _SetOverlayDualAnalogTransform SetOverlayDualAnalogTransform; //Field offset: 0x1C0
	internal _GetOverlayDualAnalogTransform GetOverlayDualAnalogTransform; //Field offset: 0x1C8
	internal _SetOverlayTexture SetOverlayTexture; //Field offset: 0x1D0
	internal _ClearOverlayTexture ClearOverlayTexture; //Field offset: 0x1D8
	internal _SetOverlayRaw SetOverlayRaw; //Field offset: 0x1E0
	internal _SetOverlayFromFile SetOverlayFromFile; //Field offset: 0x1E8
	internal _GetOverlayTexture GetOverlayTexture; //Field offset: 0x1F0
	internal _ReleaseNativeOverlayHandle ReleaseNativeOverlayHandle; //Field offset: 0x1F8
	internal _GetOverlayTextureSize GetOverlayTextureSize; //Field offset: 0x200
	internal _CreateDashboardOverlay CreateDashboardOverlay; //Field offset: 0x208
	internal _IsDashboardVisible IsDashboardVisible; //Field offset: 0x210
	internal _IsActiveDashboardOverlay IsActiveDashboardOverlay; //Field offset: 0x218
	internal _SetDashboardOverlaySceneProcess SetDashboardOverlaySceneProcess; //Field offset: 0x220
	internal _GetDashboardOverlaySceneProcess GetDashboardOverlaySceneProcess; //Field offset: 0x228
	internal _ShowDashboard ShowDashboard; //Field offset: 0x230
	internal _GetPrimaryDashboardDevice GetPrimaryDashboardDevice; //Field offset: 0x238
	internal _ShowKeyboard ShowKeyboard; //Field offset: 0x240
	internal _ShowKeyboardForOverlay ShowKeyboardForOverlay; //Field offset: 0x248
	internal _GetKeyboardText GetKeyboardText; //Field offset: 0x250
	internal _HideKeyboard HideKeyboard; //Field offset: 0x258
	internal _SetKeyboardTransformAbsolute SetKeyboardTransformAbsolute; //Field offset: 0x260
	internal _SetKeyboardPositionForOverlay SetKeyboardPositionForOverlay; //Field offset: 0x268
	internal _SetOverlayIntersectionMask SetOverlayIntersectionMask; //Field offset: 0x270
	internal _GetOverlayFlags GetOverlayFlags; //Field offset: 0x278
	internal _ShowMessageOverlay ShowMessageOverlay; //Field offset: 0x280
	internal _CloseMessageOverlay CloseMessageOverlay; //Field offset: 0x288

}

