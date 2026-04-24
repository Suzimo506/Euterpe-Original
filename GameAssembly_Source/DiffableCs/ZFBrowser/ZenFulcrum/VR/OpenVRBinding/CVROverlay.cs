namespace ZenFulcrum.VR.OpenVRBinding;

public class CVROverlay
{
	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public sealed class _PollNextOverlayEventPacked : MulticastDelegate
	{

		public _PollNextOverlayEventPacked(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent, AsyncCallback callback, object object) { }

		public override bool EndInvoke(ref VREvent_t_Packed pEvent, IAsyncResult result) { }

		public override bool Invoke(ulong ulOverlayHandle, ref VREvent_t_Packed pEvent, uint uncbVREvent) { }

	}

	private struct PollNextOverlayEventUnion
	{
		public _PollNextOverlayEvent pPollNextOverlayEvent; //Field offset: 0x0
		public _PollNextOverlayEventPacked pPollNextOverlayEventPacked; //Field offset: 0x0

	}

	private IVROverlay FnTable; //Field offset: 0x10

	internal CVROverlay(IntPtr pInterface) { }

	public EVROverlayError ClearOverlayTexture(ulong ulOverlayHandle) { }

	public void CloseMessageOverlay() { }

	public bool ComputeOverlayIntersection(ulong ulOverlayHandle, ref VROverlayIntersectionParams_t pParams, ref VROverlayIntersectionResults_t pResults) { }

	public EVROverlayError CreateDashboardOverlay(string pchOverlayKey, string pchOverlayFriendlyName, ref ulong pMainHandle, ref ulong pThumbnailHandle) { }

	public EVROverlayError CreateOverlay(string pchOverlayKey, string pchOverlayName, ref ulong pOverlayHandle) { }

	public EVROverlayError DestroyOverlay(ulong ulOverlayHandle) { }

	public EVROverlayError FindOverlay(string pchOverlayKey, ref ulong pOverlayHandle) { }

	public EVROverlayError GetDashboardOverlaySceneProcess(ulong ulOverlayHandle, ref uint punProcessId) { }

	public ulong GetGamepadFocusOverlay() { }

	public ulong GetHighQualityOverlay() { }

	public uint GetKeyboardText(StringBuilder pchText, uint cchText) { }

	public EVROverlayError GetOverlayAlpha(ulong ulOverlayHandle, ref float pfAlpha) { }

	public EVROverlayError GetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, ref float pfMinDistanceInMeters, ref float pfMaxDistanceInMeters) { }

	public EVROverlayError GetOverlayColor(ulong ulOverlayHandle, ref float pfRed, ref float pfGreen, ref float pfBlue) { }

	public EVROverlayError GetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, ref float pfRadius) { }

	public string GetOverlayErrorNameFromEnum(EVROverlayError error) { }

	public EVROverlayError GetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, ref bool pbEnabled) { }

	public EVROverlayError GetOverlayFlags(ulong ulOverlayHandle, ref uint pFlags) { }

	public EVROverlayError GetOverlayImageData(ulong ulOverlayHandle, IntPtr pvBuffer, uint unBufferSize, ref uint punWidth, ref uint punHeight) { }

	public EVROverlayError GetOverlayInputMethod(ulong ulOverlayHandle, ref VROverlayInputMethod peInputMethod) { }

	public uint GetOverlayKey(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) { }

	public EVROverlayError GetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) { }

	public uint GetOverlayName(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref EVROverlayError pError) { }

	public uint GetOverlayRenderingPid(ulong ulOverlayHandle) { }

	public uint GetOverlayRenderModel(ulong ulOverlayHandle, StringBuilder pchValue, uint unBufferSize, ref HmdColor_t pColor, ref EVROverlayError pError) { }

	public EVROverlayError GetOverlaySortOrder(ulong ulOverlayHandle, ref uint punSortOrder) { }

	public EVROverlayError GetOverlayTexelAspect(ulong ulOverlayHandle, ref float pfTexelAspect) { }

	public EVROverlayError GetOverlayTexture(ulong ulOverlayHandle, ref IntPtr pNativeTextureHandle, IntPtr pNativeTextureRef, ref uint pWidth, ref uint pHeight, ref uint pNativeFormat, ref ETextureType pAPIType, ref EColorSpace pColorSpace, ref VRTextureBounds_t pTextureBounds) { }

	public EVROverlayError GetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) { }

	public EVROverlayError GetOverlayTextureColorSpace(ulong ulOverlayHandle, ref EColorSpace peTextureColorSpace) { }

	public EVROverlayError GetOverlayTextureSize(ulong ulOverlayHandle, ref uint pWidth, ref uint pHeight) { }

	public EVROverlayError GetOverlayTransformAbsolute(ulong ulOverlayHandle, ref ETrackingUniverseOrigin peTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) { }

	public EVROverlayError GetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ref ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) { }

	public EVROverlayError GetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, ref uint punDeviceIndex, StringBuilder pchComponentName, uint unComponentNameSize) { }

	public EVROverlayError GetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, ref uint punTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) { }

	public EVROverlayError GetOverlayTransformType(ulong ulOverlayHandle, ref VROverlayTransformType peTransformType) { }

	public EVROverlayError GetOverlayWidthInMeters(ulong ulOverlayHandle, ref float pfWidthInMeters) { }

	public uint GetPrimaryDashboardDevice() { }

	public EVROverlayError GetTransformForOverlayCoordinates(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, HmdVector2_t coordinatesInOverlay, ref HmdMatrix34_t pmatTransform) { }

	public void HideKeyboard() { }

	public EVROverlayError HideOverlay(ulong ulOverlayHandle) { }

	public bool IsActiveDashboardOverlay(ulong ulOverlayHandle) { }

	public bool IsDashboardVisible() { }

	public bool IsHoverTargetOverlay(ulong ulOverlayHandle) { }

	public bool IsOverlayVisible(ulong ulOverlayHandle) { }

	public EVROverlayError MoveGamepadFocusToNeighbor(EOverlayDirection eDirection, ulong ulFrom) { }

	public bool PollNextOverlayEvent(ulong ulOverlayHandle, ref VREvent_t pEvent, uint uncbVREvent) { }

	public EVROverlayError ReleaseNativeOverlayHandle(ulong ulOverlayHandle, IntPtr pNativeTextureHandle) { }

	public EVROverlayError SetDashboardOverlaySceneProcess(ulong ulOverlayHandle, uint unProcessId) { }

	public EVROverlayError SetGamepadFocusOverlay(ulong ulNewFocusOverlay) { }

	public EVROverlayError SetHighQualityOverlay(ulong ulOverlayHandle) { }

	public void SetKeyboardPositionForOverlay(ulong ulOverlayHandle, HmdRect2_t avoidRect) { }

	public void SetKeyboardTransformAbsolute(ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToKeyboardTransform) { }

	public EVROverlayError SetOverlayAlpha(ulong ulOverlayHandle, float fAlpha) { }

	public EVROverlayError SetOverlayAutoCurveDistanceRangeInMeters(ulong ulOverlayHandle, float fMinDistanceInMeters, float fMaxDistanceInMeters) { }

	public EVROverlayError SetOverlayColor(ulong ulOverlayHandle, float fRed, float fGreen, float fBlue) { }

	public EVROverlayError SetOverlayDualAnalogTransform(ulong ulOverlay, EDualAnalogWhich eWhich, ref HmdVector2_t pvCenter, float fRadius) { }

	public EVROverlayError SetOverlayFlag(ulong ulOverlayHandle, VROverlayFlags eOverlayFlag, bool bEnabled) { }

	public EVROverlayError SetOverlayFromFile(ulong ulOverlayHandle, string pchFilePath) { }

	public EVROverlayError SetOverlayInputMethod(ulong ulOverlayHandle, VROverlayInputMethod eInputMethod) { }

	public EVROverlayError SetOverlayIntersectionMask(ulong ulOverlayHandle, ref VROverlayIntersectionMaskPrimitive_t pMaskPrimitives, uint unNumMaskPrimitives, uint unPrimitiveSize) { }

	public EVROverlayError SetOverlayMouseScale(ulong ulOverlayHandle, ref HmdVector2_t pvecMouseScale) { }

	public EVROverlayError SetOverlayName(ulong ulOverlayHandle, string pchName) { }

	public EVROverlayError SetOverlayNeighbor(EOverlayDirection eDirection, ulong ulFrom, ulong ulTo) { }

	public EVROverlayError SetOverlayRaw(ulong ulOverlayHandle, IntPtr pvBuffer, uint unWidth, uint unHeight, uint unDepth) { }

	public EVROverlayError SetOverlayRenderingPid(ulong ulOverlayHandle, uint unPID) { }

	public EVROverlayError SetOverlayRenderModel(ulong ulOverlayHandle, string pchRenderModel, ref HmdColor_t pColor) { }

	public EVROverlayError SetOverlaySortOrder(ulong ulOverlayHandle, uint unSortOrder) { }

	public EVROverlayError SetOverlayTexelAspect(ulong ulOverlayHandle, float fTexelAspect) { }

	public EVROverlayError SetOverlayTexture(ulong ulOverlayHandle, ref Texture_t pTexture) { }

	public EVROverlayError SetOverlayTextureBounds(ulong ulOverlayHandle, ref VRTextureBounds_t pOverlayTextureBounds) { }

	public EVROverlayError SetOverlayTextureColorSpace(ulong ulOverlayHandle, EColorSpace eTextureColorSpace) { }

	public EVROverlayError SetOverlayTransformAbsolute(ulong ulOverlayHandle, ETrackingUniverseOrigin eTrackingOrigin, ref HmdMatrix34_t pmatTrackingOriginToOverlayTransform) { }

	public EVROverlayError SetOverlayTransformOverlayRelative(ulong ulOverlayHandle, ulong ulOverlayHandleParent, ref HmdMatrix34_t pmatParentOverlayToOverlayTransform) { }

	public EVROverlayError SetOverlayTransformTrackedDeviceComponent(ulong ulOverlayHandle, uint unDeviceIndex, string pchComponentName) { }

	public EVROverlayError SetOverlayTransformTrackedDeviceRelative(ulong ulOverlayHandle, uint unTrackedDevice, ref HmdMatrix34_t pmatTrackedDeviceToOverlayTransform) { }

	public EVROverlayError SetOverlayWidthInMeters(ulong ulOverlayHandle, float fWidthInMeters) { }

	public void ShowDashboard(string pchOverlayToShow) { }

	public EVROverlayError ShowKeyboard(int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) { }

	public EVROverlayError ShowKeyboardForOverlay(ulong ulOverlayHandle, int eInputMode, int eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText, bool bUseMinimalMode, ulong uUserValue) { }

	public VRMessageOverlayResponse ShowMessageOverlay(string pchText, string pchCaption, string pchButton0Text, string pchButton1Text, string pchButton2Text, string pchButton3Text) { }

	public EVROverlayError ShowOverlay(ulong ulOverlayHandle) { }

}

