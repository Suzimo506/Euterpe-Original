namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class TouchPad : TouchInteractable, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	internal enum AxisDirection
	{
		Both = 0,
		Horizontal = 1,
		Vertical = 2,
	}

	private class DgneQQpExoFGgkVpteUasngENwdfb
	{
		private class BjcfCKuCffHIudLKkJVrcJWVsdpHA
		{
			public float HIPtAczcuNcbxvkHmQXCOQmWpWUm; //Field offset: 0x10
			public float hwMxKcVMjjDkAJKRPQfyPGtevlAeA; //Field offset: 0x14
			public uint GqSJwGMCXcDYtHAShCDWFjbLLvccA; //Field offset: 0x18

			public BjcfCKuCffHIudLKkJVrcJWVsdpHA() { }

		}

		private int CPvvhmvBkxiZDQiaHMcuHOKrbnSY; //Field offset: 0x10
		private BjcfCKuCffHIudLKkJVrcJWVsdpHA[] teNgrSjZfXOZlxPpuVLdsJhziZEcA; //Field offset: 0x18
		private int vPYvvPOazUAHulSrTgeIfZwoxIEM; //Field offset: 0x20

		public DgneQQpExoFGgkVpteUasngENwdfb(int unnamed_param_0) { }

		private static int AajtnoJxsWeidijQFzPsoEWSRmfL(int unnamed_param_0, int unnamed_param_1) { }

		private void abjguxrVCxiDcwIKgAyptmVIaUpf() { }

		public void qEbsTdbNteKHDiXUjdSoKhYMFWtJ(float unnamed_param_0, float unnamed_param_1) { }

		public Vector2 uMMBjnnLGfKCOzsWFNHinPUilGSL() { }

		private static bool xXGppvQJPrntBgsRfdQcSUZigRYGA(uint unnamed_param_0, uint unnamed_param_1) { }

		private int zEcNlDxtXZBlxNfCgUuQIMORirHS(int unnamed_param_0, int unnamed_param_1) { }

	}

	internal class PressDownEventHandler : UnityEvent
	{

		public PressDownEventHandler() { }

	}

	internal class PressUpEventHandler : UnityEvent
	{

		public PressUpEventHandler() { }

	}

	internal class TapEventHandler : UnityEvent
	{

		public TapEventHandler() { }

	}

	internal enum TouchPadMode
	{
		Delta = 0,
		ScreenPosition = 1,
		VectorFromCenter = 2,
		VectorFromInitialTouch = 3,
	}

	internal class ValueChangedEventHandler : UnityEvent<Vector2>
	{

		public ValueChangedEventHandler() { }

	}

	internal enum ValueFormat
	{
		Pixels = 0,
		Screen = 1,
		Physical = 2,
		Direction = 3,
	}

	private const int SMOOTH_DELTA_FRAME_COUNT = 3; //Field offset: 0x0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForFloat _horizontalAxisCustomControllerElement; //Field offset: 0x128
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForFloat _verticalAxisCustomControllerElement; //Field offset: 0x130
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForBoolean _tapCustomControllerElement; //Field offset: 0x138
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForBoolean _pressCustomControllerElement; //Field offset: 0x140
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisDirection _axesToUse; //Field offset: 0x148
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TouchPadMode _touchPadMode; //Field offset: 0x14C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ValueFormat _valueFormat; //Field offset: 0x150
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useInertia; //Field offset: 0x154
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _inertiaFriction; //Field offset: 0x158
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _activateOnSwipeIn; //Field offset: 0x15C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _stayActiveOnSwipeOut; //Field offset: 0x15D
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _allowTap; //Field offset: 0x15E
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _tapTimeout; //Field offset: 0x160
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _tapDistanceLimit; //Field offset: 0x164
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _allowPress; //Field offset: 0x168
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _pressStartDelay; //Field offset: 0x16C
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _pressDistanceLimit; //Field offset: 0x170
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _hideAtRuntime; //Field offset: 0x174
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis2D _axis2D; //Field offset: 0x178
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ValueChangedEventHandler _onValueChanged; //Field offset: 0x180
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TapEventHandler _onTap; //Field offset: 0x188
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private PressDownEventHandler _onPressDown; //Field offset: 0x190
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private PressUpEventHandler _onPressUp; //Field offset: 0x198
	private bool _useXAxis; //Field offset: 0x1A0
	private bool _useYAxis; //Field offset: 0x1A1
	private int _pointerId; //Field offset: 0x1A4
	private int _realMousePointerId; //Field offset: 0x1A8
	private bool DuJcSUBjODzIYmtFcaHJBSqEkpNCB; //Field offset: 0x1AC
	private bool gTLwGImOoZuPWcDofNJbHqzbgTvp; //Field offset: 0x1AD
	private bool _pointerDownIsFake; //Field offset: 0x1AE
	private Vector2 _touchStartPosition; //Field offset: 0x1B0
	private float _touchStartTime; //Field offset: 0x1B8
	private Vector3 _currentCenter; //Field offset: 0x1BC
	private Vector2 _previousTouchPosition; //Field offset: 0x1C8
	private int _lastTapFrame; //Field offset: 0x1D0
	private bool _isEligibleForTap; //Field offset: 0x1D4
	private bool _isEligibleForPress; //Field offset: 0x1D5
	private bool _pressValue; //Field offset: 0x1D6
	private DgneQQpExoFGgkVpteUasngENwdfb _smoothDelta; //Field offset: 0x1D8
	private Dictionary<Int32, PointerEventData> __fakePointerEventData; //Field offset: 0x1E0

	public event UnityAction PressDownEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction PressUpEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction TapEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction<Vector2> ValueChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public bool activateOnSwipeIn
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool allowPress
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool allowTap
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public AxisDirection axesToUse
	{
		 get { } //Length: 7
		 set { } //Length: 56
	}

	public Axis2DCalibration axis2DCalibration
	{
		 get { } //Length: 30
	}

	public bool hasPointer
	{
		 get { } //Length: 14
	}

	public bool hideAtRuntime
	{
		 get { } //Length: 8
		 set { } //Length: 35
	}

	public AxisCalibration horizontalAxisCalibration
	{
		 get { } //Length: 39
	}

	public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
	{
		 get { } //Length: 8
	}

	public float inertiaFriction
	{
		 get { } //Length: 9
		 set { } //Length: 74
	}

	internal StandaloneAxis2D LlDFiyIJVUyABvwjMsCOsrYCZsvm
	{
		internal get { } //Length: 8
	}

	public int pointerId
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public CustomControllerElementTargetSetForBoolean pressCustomControllerElement
	{
		 get { } //Length: 8
	}

	public int pressDistanceLimit
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public float pressStartDelay
	{
		 get { } //Length: 9
		 set { } //Length: 141
	}

	private int QkYpWVrHlHxLmZbshuJOaRUncsCF
	{
		private get { } //Length: 35
	}

	public bool stayActiveOnSwipeOut
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public CustomControllerElementTargetSetForBoolean tapCustomControllerElement
	{
		 get { } //Length: 8
	}

	public int tapDistanceLimit
	{
		 get { } //Length: 7
		 set { } //Length: 66
	}

	public float tapTimeout
	{
		 get { } //Length: 9
		 set { } //Length: 74
	}

	public TouchPadMode touchPadMode
	{
		 get { } //Length: 7
		 set { } //Length: 32
	}

	public Vector2 touchPosition
	{
		 get { } //Length: 325
	}

	public Vector2 touchStartPosition
	{
		 get { } //Length: 120
	}

	public bool useInertia
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public ValueFormat valueFormat
	{
		 get { } //Length: 7
		 set { } //Length: 32
	}

	public AxisCalibration verticalAxisCalibration
	{
		 get { } //Length: 39
	}

	public CustomControllerElementTargetSetForFloat verticalAxisCustomControllerElement
	{
		 get { } //Length: 8
	}

	private bool vfkjJJCSDXLNbESqsqpdKxeSmxUgA
	{
		private get { } //Length: 30
	}

	[CustomObfuscation]
	private TouchPad() { }

	public void add_PressDownEvent(UnityAction value) { }

	public void add_PressUpEvent(UnityAction value) { }

	public void add_TapEvent(UnityAction value) { }

	public void add_ValueChangedEvent(UnityAction<Vector2> value) { }

	[CustomObfuscation]
	internal virtual void Awake() { }

	private void bYgwHRgUjtLYntbMRrgSJBSzemFG() { }

	public virtual void ClearValue() { }

	private bool DFYIevuqpPTEvemBOHbyoBAORyhQ() { }

	private void ECURNdbyADoePQriPprPRjmCavqGA(PointerEventData unnamed_param_0) { }

	private void fMezSpQUaBnmfRYGrkSrwjOCORb() { }

	internal StandaloneAxis2D ftMLbfHKEsePTZnHqhpEdmLCCbbeb() { }

	public bool get_activateOnSwipeIn() { }

	public bool get_allowPress() { }

	public bool get_allowTap() { }

	public AxisDirection get_axesToUse() { }

	public Axis2DCalibration get_axis2DCalibration() { }

	public bool get_hasPointer() { }

	public bool get_hideAtRuntime() { }

	public AxisCalibration get_horizontalAxisCalibration() { }

	public CustomControllerElementTargetSetForFloat get_horizontalAxisCustomControllerElement() { }

	public float get_inertiaFriction() { }

	public int get_pointerId() { }

	public CustomControllerElementTargetSetForBoolean get_pressCustomControllerElement() { }

	public int get_pressDistanceLimit() { }

	public float get_pressStartDelay() { }

	public bool get_stayActiveOnSwipeOut() { }

	public CustomControllerElementTargetSetForBoolean get_tapCustomControllerElement() { }

	public int get_tapDistanceLimit() { }

	public float get_tapTimeout() { }

	public TouchPadMode get_touchPadMode() { }

	public Vector2 get_touchPosition() { }

	public Vector2 get_touchStartPosition() { }

	public bool get_useInertia() { }

	public ValueFormat get_valueFormat() { }

	public AxisCalibration get_verticalAxisCalibration() { }

	public CustomControllerElementTargetSetForFloat get_verticalAxisCustomControllerElement() { }

	private PointerEventData GfIcFnETEYNBQZwJfzcDCoZlNBPm(int unnamed_param_0) { }

	internal virtual void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	internal virtual void gqXZxvvVhElvIzeezXrWFzPcCqCs() { }

	private void HQXxlyIGwuByDUAIoDSNAoHlwzkT(bool unnamed_param_0) { }

	private void hWaoRsauAviXgtxPVwToxGAqHhrKA() { }

	private void INhePaNZUAGnxaRNvKwTlBYClAnI(PointerEventData unnamed_param_0) { }

	private PointerEventData iqzUKzYNVodFSHSVrbXzmvVdrlEJA(int unnamed_param_0) { }

	private PointerEventData koNUGvZiUUArGCqfOockjOXJEGhHb(int unnamed_param_0, GameObject unnamed_param_1) { }

	internal virtual bool kwMTcexkBSpageCdqoWCFCzibaIDA() { }

	private void KXRtDfXGDCRIDKxpUxTUuXOvdPxE(PointerEventData unnamed_param_0) { }

	private Vector2 lcUzeOULcosDodipUmeCFepVcdn(Vector2 unnamed_param_0) { }

	private int LfvdRDhzCWZeWbLdhTwRabwvVmIRA() { }

	private void lxpmRsCazKWmQkiEFJKetJtiWVCj(PointerEventData unnamed_param_0) { }

	private void LzqPBgHRpzbpIYjWgLvnJsZPWUtd() { }

	private void lZsrjXXDCtalovfGqzuKTfcXiGzF() { }

	private void MsNOSXPoGhKUSzeVaZXxQPgbiuAB(int unnamed_param_0, Vector2 unnamed_param_1) { }

	private void NoNlfIaNLEjlrHpYdLppvgzqtZuGA(AxisDirection unnamed_param_0) { }

	private void olDXhLkEuFCBZuobYxlvFHDyLHmF(ref Vector2 unnamed_param_0) { }

	internal virtual void OnPointerDown(PointerEventData eventData) { }

	internal virtual void OnPointerEnter(PointerEventData eventData) { }

	internal virtual void OnPointerExit(PointerEventData eventData) { }

	internal virtual void OnPointerUp(PointerEventData eventData) { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	private void ozyeCYCAxDTknsiZBbhuDzxTyZCn(PointerEventData unnamed_param_0) { }

	private void PcJMvjbuTyEjuSlzIXvPNcCdKQnv(ref Vector2 unnamed_param_0) { }

	private void qbBTEkDnIlsNpjKgBAHMxRxQhcDF() { }

	public void remove_PressDownEvent(UnityAction value) { }

	public void remove_PressUpEvent(UnityAction value) { }

	public void remove_TapEvent(UnityAction value) { }

	public void remove_ValueChangedEvent(UnityAction<Vector2> value) { }

	private void RFddnozLBukqYqpEFeEkFTUVixDQ() { }

	public void set_activateOnSwipeIn(bool value) { }

	public void set_allowPress(bool value) { }

	public void set_allowTap(bool value) { }

	public void set_axesToUse(AxisDirection value) { }

	public void set_hideAtRuntime(bool value) { }

	public void set_inertiaFriction(float value) { }

	public void set_pointerId(int value) { }

	public void set_pressDistanceLimit(int value) { }

	public void set_pressStartDelay(float value) { }

	public void set_stayActiveOnSwipeOut(bool value) { }

	public void set_tapDistanceLimit(int value) { }

	public void set_tapTimeout(float value) { }

	public void set_touchPadMode(TouchPadMode value) { }

	public void set_useInertia(bool value) { }

	public void set_valueFormat(ValueFormat value) { }

	private void szgaAwAWKMRPZgipmAGnQkzanfvL() { }

	private PointerEventData vmzjPOzIuVsJhCBoygKFjOQGIBzl(int unnamed_param_0, GameObject unnamed_param_1) { }

	internal virtual void WuAJrOPQGZmohVlmObzfeXGkBzEP() { }

	internal virtual void yBUSBdYGzAGkKzdcZBafXHsIjVki() { }

	private void yTenCBIKteadDsFxrdauhDYXxiTHA() { }

	private bool ZhhLQWVvWRRSPklWymYqFjPDMAQQ(int unnamed_param_0) { }

}

