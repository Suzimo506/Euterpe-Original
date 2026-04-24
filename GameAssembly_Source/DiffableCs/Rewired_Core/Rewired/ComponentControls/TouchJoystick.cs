namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisallowMultipleComponent]
public sealed class TouchJoystick : TouchInteractable
{
	internal enum AxisDirection
	{
		Both = 0,
		Horizontal = 1,
		Vertical = 2,
	}

	[CompilerGenerated]
	private sealed class CXZxrzjlqLqfPtVclQatNwxSdLrA : IDisposable, IEnumerator, IEnumerator<Object>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private object QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		public float LToXmXyqPMWuVwVeudDSSoZdGQIF; //Field offset: 0x20
		public TouchJoystick SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		public PositionType QhrGSiZyUSzJFNAjRzQMJPagbAdJ; //Field offset: 0x30
		public Vector2 KcKGPYBiAqqTXqJNFnRSDTtOeexlA; //Field offset: 0x34
		public EsgUKabNUhgArfpNnqEEMmUQHAzF jycuEKqiIFefTeaOzvRWfizgKoWF; //Field offset: 0x3C
		private RectTransform oWSEADSrbjNoBNzopHpICWGKybOe; //Field offset: 0x40
		private Vector2 JECEmrDhysPHNcPqToVHLwAekZOt; //Field offset: 0x48
		private float DVOMlMXKyvrFXXWkEGXJfwqGeDmP; //Field offset: 0x50
		private float dZGhekjcJBGOQivAanuWNvbrjWPU; //Field offset: 0x54

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public CXZxrzjlqLqfPtVclQatNwxSdLrA(int unnamed_param_0) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private enum EsgUKabNUhgArfpNnqEEMmUQHAzF
	{
		None = 0,
		TowardTouch = 1,
		TowardHome = 2,
	}

	private enum FUUEstlYAVOMOHxOUQtmAniyGPYaA
	{
		Local = 0,
		TouchRegion = 1,
	}

	[CompilerGenerated]
	private sealed class icdFlFOJuxjXHMdUWgYmbIDjwFhvA
	{
		public static readonly icdFlFOJuxjXHMdUWgYmbIDjwFhvA <>9; //Field offset: 0x0
		public static EventFunction<IValueChangedHandler, Vector2> <>9__277_0; //Field offset: 0x8
		public static EventFunction<IStickPositionChangedHandler, Vector2> <>9__280_0; //Field offset: 0x10

		private static icdFlFOJuxjXHMdUWgYmbIDjwFhvA() { }

		public icdFlFOJuxjXHMdUWgYmbIDjwFhvA() { }

		internal void YaLKRjuClHdISALpqxBElFdLYMAQ(IStickPositionChangedHandler unnamed_param_0, Vector2 unnamed_param_1) { }

		internal void zTIuWLmvDKdsOmDLQHGdXihRfAFE(IValueChangedHandler unnamed_param_0, Vector2 unnamed_param_1) { }

	}

	internal interface IStickPositionChangedHandler
	{

		public void OnStickPositionChanged(Vector2 value) { }

	}

	internal interface IValueChangedHandler
	{

		public void OnValueChanged(Vector2 value) { }

	}

	internal enum JoystickMode
	{
		Analog = 0,
		Digital = 1,
	}

	internal enum SnapDirections
	{
		None = 0,
		Four = 4,
		Eight = 8,
		Sixteen = 16,
		ThirtyTwo = 32,
		SixtyFour = 64,
	}

	internal enum StickBounds
	{
		Circle = 0,
		Square = 1,
	}

	internal class StickPositionChangedEventHandler : UnityEvent<Vector2>
	{

		public StickPositionChangedEventHandler() { }

	}

	internal class TapEventHandler : UnityEvent
	{

		public TapEventHandler() { }

	}

	internal class TouchEndedEventHandler : UnityEvent
	{

		public TouchEndedEventHandler() { }

	}

	internal class TouchStartedEventHandler : UnityEvent
	{

		public TouchStartedEventHandler() { }

	}

	internal class ValueChangedEventHandler : UnityEvent<Vector2>
	{

		public ValueChangedEventHandler() { }

	}

	private const float MAX_MOVE_SPEED = 20; //Field offset: 0x0
	private static EventFunction<IValueChangedHandler, Vector2> __valueChangedHandlerDelegate; //Field offset: 0x0
	private static EventFunction<IStickPositionChangedHandler, Vector2> __stickPositionChangedHandlerDelegate; //Field offset: 0x8
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
	private RectTransform _stickTransform; //Field offset: 0x140
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private JoystickMode _joystickMode; //Field offset: 0x148
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _digitalModeDeadZone; //Field offset: 0x14C
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _stickRange; //Field offset: 0x150
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _scaleStickRange; //Field offset: 0x154
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StickBounds _stickBounds; //Field offset: 0x158
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisDirection _axesToUse; //Field offset: 0x15C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private SnapDirections _snapDirections; //Field offset: 0x160
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _snapStickToTouch; //Field offset: 0x164
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _centerStickOnRelease; //Field offset: 0x165
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis2D _axis2D; //Field offset: 0x168
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _activateOnSwipeIn; //Field offset: 0x170
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _stayActiveOnSwipeOut; //Field offset: 0x171
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _allowTap; //Field offset: 0x172
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _tapTimeout; //Field offset: 0x174
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _tapDistanceLimit; //Field offset: 0x178
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TouchRegion _touchRegion; //Field offset: 0x180
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useTouchRegionOnly; //Field offset: 0x188
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _moveToTouchPosition; //Field offset: 0x189
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _returnOnRelease; //Field offset: 0x18A
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _followTouchPosition; //Field offset: 0x18B
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _animateOnMoveToTouch; //Field offset: 0x18C
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _moveToTouchSpeed; //Field offset: 0x190
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _animateOnReturn; //Field offset: 0x194
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _returnSpeed; //Field offset: 0x198
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _manageRaycasting; //Field offset: 0x19C
	private bool _useXAxis; //Field offset: 0x19D
	private bool _useYAxis; //Field offset: 0x19E
	private HierarchyEventHelper<IValueChangedHandler, Vector2> _hierarchyValueChangedHandlers; //Field offset: 0x1A0
	private HierarchyEventHelper<IStickPositionChangedHandler, Vector2> _hierarchyStickPositionChangedHandlers; //Field offset: 0x1A8
	private TouchRegion _workingTouchRegion; //Field offset: 0x1B0
	private Vector2 _origAnchoredPosition; //Field offset: 0x1B8
	private Vector2 _origStickAnchoredPosition; //Field offset: 0x1C0
	private Vector2 _lastPressAnchoredPosition; //Field offset: 0x1C8
	private bool _isMoving; //Field offset: 0x1D0
	private bool _isMovedFromDefaultPosition; //Field offset: 0x1D1
	private EsgUKabNUhgArfpNnqEEMmUQHAzF _moveDirection; //Field offset: 0x1D4
	private int _pointerId; //Field offset: 0x1D8
	private int _realMousePointerId; //Field offset: 0x1DC
	private bool DuJcSUBjODzIYmtFcaHJBSqEkpNCB; //Field offset: 0x1E0
	private bool gTLwGImOoZuPWcDofNJbHqzbgTvp; //Field offset: 0x1E1
	private bool _pointerDownIsFake; //Field offset: 0x1E2
	private Vector2 _lastPressStartingValue; //Field offset: 0x1E4
	private FUUEstlYAVOMOHxOUQtmAniyGPYaA _lastClaimSource; //Field offset: 0x1EC
	private float _touchStartTime; //Field offset: 0x1F0
	private Vector2 _touchStartPosition; //Field offset: 0x1F4
	private IEnumerator _coroutineMove; //Field offset: 0x200
	private tvOGaxCAklFNVhSLNQFXkYdybIkDb _imageRaycastHelper; //Field offset: 0x208
	private int _calculatedStickRange_lastUpdatedFrame; //Field offset: 0x210
	private int _lastTapFrame; //Field offset: 0x214
	private bool _isEligibleForTap; //Field offset: 0x218
	private float __calculatedStickRange_cachedValue; //Field offset: 0x21C
	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> __moveStartedDelegate; //Field offset: 0x220
	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> __moveEndedDelegate; //Field offset: 0x228
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ValueChangedEventHandler _onValueChanged; //Field offset: 0x230
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ValueChangedEventHandler _onStickPositionChanged; //Field offset: 0x238
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TouchStartedEventHandler _onTouchStarted; //Field offset: 0x240
	[CustomObfuscation]
	[SerializeField]
	private TouchEndedEventHandler _onTouchEnded; //Field offset: 0x248
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TapEventHandler _onTap; //Field offset: 0x250
	private Dictionary<Int32, PointerEventData> __fakePointerEventData; //Field offset: 0x258

	public event UnityAction<Vector2> StickPositionChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction TapEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction TouchDownEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction TouchUpEvent
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

	public bool allowTap
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool animateOnMoveToTouch
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool animateOnReturn
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

	internal static EventFunction<IStickPositionChangedHandler, Vector2> BHadMmJoaRNWUdCUnNEPbJHcEKRac
	{
		internal get { } //Length: 296
	}

	public bool centerStickOnRelease
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	[Obsolete]
	public Axis2DCalibration deadZoneType
	{
		 get { } //Length: 30
	}

	public float digitalModeDeadZone
	{
		 get { } //Length: 9
		 set { } //Length: 73
	}

	public bool followTouchPosition
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool hasPointer
	{
		 get { } //Length: 14
	}

	private float HfoSnEPvutYFneEeMAlOjNvoRtlB
	{
		private get { } //Length: 925
	}

	public AxisCalibration horizontalAxisCalibration
	{
		 get { } //Length: 39
	}

	public CustomControllerElementTargetSetForFloat horizontalAxisCustomControllerElement
	{
		 get { } //Length: 8
	}

	public JoystickMode joystickMode
	{
		 get { } //Length: 7
		 set { } //Length: 32
	}

	private StickBounds jyHGjJaaytKMiQmTiFqwTMFXsuYpA
	{
		private get { } //Length: 7
		private set { } //Length: 32
	}

	internal StandaloneAxis2D LlDFiyIJVUyABvwjMsCOsrYCZsvm
	{
		internal get { } //Length: 8
	}

	private RectTransform LlqYvYNlpAAUfCbVnCRVXOXFzszT
	{
		private get { } //Length: 143
	}

	public bool manageRaycasting
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	public bool moveToTouchPosition
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float moveToTouchSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 85
	}

	internal static EventFunction<IValueChangedHandler, Vector2> nyuiGuxAbYXmJztEYGvLUWCJIhFP
	{
		internal get { } //Length: 290
	}

	public int pointerId
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	private int QkYpWVrHlHxLmZbshuJOaRUncsCF
	{
		private get { } //Length: 35
	}

	public bool returnOnRelease
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public float returnSpeed
	{
		 get { } //Length: 9
		 set { } //Length: 85
	}

	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> reWRAxoaVtAuTHYFlVAFPtUgIMxeA
	{
		private get { } //Length: 138
	}

	public bool scaleStickRange
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> sGHnjwHKzOSrTWVKHqQmquIeHcBC
	{
		private get { } //Length: 138
	}

	public SnapDirections snapDirections
	{
		 get { } //Length: 7
		 set { } //Length: 32
	}

	public bool snapStickToTouch
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool stayActiveOnSwipeOut
	{
		 get { } //Length: 139
		 set { } //Length: 32
	}

	public float stickRange
	{
		 get { } //Length: 9
		 set { } //Length: 90
	}

	public RectTransform stickTransform
	{
		 get { } //Length: 8
		 set { } //Length: 170
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

	public TouchRegion touchRegion
	{
		 get { } //Length: 8
		 set { } //Length: 170
	}

	public bool useTouchRegionOnly
	{
		 get { } //Length: 8
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
	private TouchJoystick() { }

	public void add_StickPositionChangedEvent(UnityAction<Vector2> value) { }

	public void add_TapEvent(UnityAction value) { }

	public void add_TouchDownEvent(UnityAction value) { }

	public void add_TouchUpEvent(UnityAction value) { }

	public void add_ValueChangedEvent(UnityAction<Vector2> value) { }

	private void ASruzyluYYmHToLtcvJcewRBBvyJ(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	[CustomObfuscation]
	internal virtual void Awake() { }

	private void axtfWopJQiaIvJuuFCBIaWRXeMFFb(PointerEventData unnamed_param_0) { }

	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> biCvrhfLyYDpXqbjqHGmpLconklQ() { }

	private void bYgwHRgUjtLYntbMRrgSJBSzemFG() { }

	public virtual void ClearValue() { }

	private bool DFYIevuqpPTEvemBOHbyoBAORyhQ() { }

	private bool DhmyEJqjZdUXTJnYVoTYwPnNfboP() { }

	private void ECURNdbyADoePQriPprPRjmCavqGA(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	internal static EventFunction<IValueChangedHandler, Vector2> eKLeKtcpyoASsCPvFRDKMGgefezGb() { }

	private void FbQxbefVobvYkIzeduWYWOEBpScl(PointerEventData unnamed_param_0) { }

	private RectTransform fRPSPkZbRLBbJIqDsydVoMpHXujT() { }

	internal StandaloneAxis2D ftMLbfHKEsePTZnHqhpEdmLCCbbeb() { }

	public bool get_activateOnSwipeIn() { }

	public bool get_allowTap() { }

	public bool get_animateOnMoveToTouch() { }

	public bool get_animateOnReturn() { }

	public AxisDirection get_axesToUse() { }

	public Axis2DCalibration get_axis2DCalibration() { }

	public bool get_centerStickOnRelease() { }

	public Axis2DCalibration get_deadZoneType() { }

	public float get_digitalModeDeadZone() { }

	public bool get_followTouchPosition() { }

	public bool get_hasPointer() { }

	public AxisCalibration get_horizontalAxisCalibration() { }

	public CustomControllerElementTargetSetForFloat get_horizontalAxisCustomControllerElement() { }

	public JoystickMode get_joystickMode() { }

	public bool get_manageRaycasting() { }

	public bool get_moveToTouchPosition() { }

	public float get_moveToTouchSpeed() { }

	public int get_pointerId() { }

	public bool get_returnOnRelease() { }

	public float get_returnSpeed() { }

	public bool get_scaleStickRange() { }

	public SnapDirections get_snapDirections() { }

	public bool get_snapStickToTouch() { }

	public bool get_stayActiveOnSwipeOut() { }

	public float get_stickRange() { }

	public RectTransform get_stickTransform() { }

	public CustomControllerElementTargetSetForBoolean get_tapCustomControllerElement() { }

	public int get_tapDistanceLimit() { }

	public float get_tapTimeout() { }

	public TouchRegion get_touchRegion() { }

	public bool get_useTouchRegionOnly() { }

	public AxisCalibration get_verticalAxisCalibration() { }

	public CustomControllerElementTargetSetForFloat get_verticalAxisCustomControllerElement() { }

	public Vector2 GetRawValue() { }

	public Vector2 GetValue() { }

	private PointerEventData GfIcFnETEYNBQZwJfzcDCoZlNBPm(int unnamed_param_0) { }

	internal virtual void GGUFBODifwtqRTAdHQHNIcUblmBKc() { }

	internal virtual void gINqkFDkYjaogQuxYMEmrDDhBrwQ(PointerEventData unnamed_param_0) { }

	private void gMQVtxyyjkyxnvNLdXsQPAKkjYgP(PointerEventData unnamed_param_0) { }

	private void gquBuDqJXGDqnBkBWIVtmAIDgqym(TouchRegion unnamed_param_0) { }

	internal virtual void gqXZxvvVhElvIzeezXrWFzPcCqCs() { }

	internal virtual void GUjdAaFGEGMvfEpGdjYGnyEKFUbQ() { }

	private void hFwPxfrRASUUEpXZKciCylyxekwJA() { }

	internal virtual void HiAkVMufLZrQVcmoSGyqihigMplu(PointerEventData unnamed_param_0) { }

	private IEnumerator iaxtIbXaLgqEpmayKUdwnRXXBlte(Vector2 unnamed_param_0, PositionType unnamed_param_1, float unnamed_param_2, EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_3) { }

	private void INhePaNZUAGnxaRNvKwTlBYClAnI(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	private float iopniVImObtNuQmeTbUoMSRmeYwiA() { }

	private PointerEventData iqzUKzYNVodFSHSVrbXzmvVdrlEJA(int unnamed_param_0) { }

	internal virtual bool isWdyIkfRtppWEidkYkMlNEXluNI() { }

	private void JpFbqFWqOyGTUQVefsmjfbjqthoB(PointerEventData unnamed_param_0) { }

	private void JSmkdTRmtmCvHJrWvzmVUsdcftmG(Vector2 unnamed_param_0) { }

	private void JUwCqghxDRPuElvKppObbFmsKLNIA(int unnamed_param_0, Vector2 unnamed_param_1, PositionType unnamed_param_2) { }

	private void kJWauNfuKKXGGKGJzEXkSsbhvJRsA(Vector2 unnamed_param_0, bool unnamed_param_1, float unnamed_param_2, EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_3) { }

	internal virtual void KOfVOAtKECGHVHofLlQTmOHNOSzpA(PointerEventData unnamed_param_0) { }

	private PointerEventData koNUGvZiUUArGCqfOockjOXJEGhHb(int unnamed_param_0, GameObject unnamed_param_1) { }

	internal virtual bool kwMTcexkBSpageCdqoWCFCzibaIDA() { }

	private void KXRtDfXGDCRIDKxpUxTUuXOvdPxE(PointerEventData unnamed_param_0) { }

	private void lcClkIXKkliropInwshOonlpvjz(Vector2 unnamed_param_0) { }

	private int LfvdRDhzCWZeWbLdhTwRabwvVmIRA() { }

	internal virtual void LxKjvdrXOBGicmmuPDIRYDKodYgm() { }

	private void lxpmRsCazKWmQkiEFJKetJtiWVCj(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	internal virtual void lZIQgJsLNYIcAfmIyMwAMDgEQkut() { }

	private void LzqPBgHRpzbpIYjWgLvnJsZPWUtd() { }

	private void lZsrjXXDCtalovfGqzuKTfcXiGzF() { }

	internal virtual void MABaiLEfkRPRRoAmMkpEROzjULCo(PointerEventData unnamed_param_0) { }

	private void MsNOSXPoGhKUSzeVaZXxQPgbiuAB(int unnamed_param_0, Vector2 unnamed_param_1, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_2) { }

	private void nAUicPUNNBqSCNBlwWaPTNFjfPugA(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	private void NdtwwVisOUKxUKbpiyEVOEYJhbNC(EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_0) { }

	private void NoNlfIaNLEjlrHpYdLppvgzqtZuGA(AxisDirection unnamed_param_0) { }

	private void NRUMeCqLHZuQSyxzhvtxbQEvsHWl(PointerEventData unnamed_param_0) { }

	private void ODlBjeFluURrjvzGKNaXJnefodCbA(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	[CustomObfuscation]
	internal virtual void OnDisable() { }

	[CustomObfuscation]
	internal virtual void OnEnable() { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	private bool OyvfapPUQDtiCvarncOGzLVVEvSFA() { }

	private void ozyeCYCAxDTknsiZBbhuDzxTyZCn(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	private void PcJMvjbuTyEjuSlzIXvPNcCdKQnv(ref Vector2 unnamed_param_0) { }

	private void PYOhtvvKnBrSoFGfCNQqwDvAgYMiA() { }

	private void qbBTEkDnIlsNpjKgBAHMxRxQhcDF() { }

	private void qIOOUOfGJOqXvoHyKTarkiQvbqlAA() { }

	private void rDhgknGhktsbfZUbZMUYXklolMkQ(PointerEventData unnamed_param_0) { }

	public void remove_StickPositionChangedEvent(UnityAction<Vector2> value) { }

	public void remove_TapEvent(UnityAction value) { }

	public void remove_TouchDownEvent(UnityAction value) { }

	public void remove_TouchUpEvent(UnityAction value) { }

	public void remove_ValueChangedEvent(UnityAction<Vector2> value) { }

	public void ReturnToDefaultPosition() { }

	public void ReturnToDefaultPosition(bool instant) { }

	private void RFddnozLBukqYqpEFeEkFTUVixDQ() { }

	internal virtual void RxsbAbTtXxxXboMpepmVbsWbTMJF(PointerEventData unnamed_param_0) { }

	private StickBounds RxzIDHEEvxKzWUuNhGFvlWCDRzIf() { }

	public void set_activateOnSwipeIn(bool value) { }

	public void set_allowTap(bool value) { }

	public void set_animateOnMoveToTouch(bool value) { }

	public void set_animateOnReturn(bool value) { }

	public void set_axesToUse(AxisDirection value) { }

	public void set_centerStickOnRelease(bool value) { }

	public void set_digitalModeDeadZone(float value) { }

	public void set_followTouchPosition(bool value) { }

	public void set_joystickMode(JoystickMode value) { }

	public void set_manageRaycasting(bool value) { }

	public void set_moveToTouchPosition(bool value) { }

	public void set_moveToTouchSpeed(float value) { }

	public void set_pointerId(int value) { }

	public void set_returnOnRelease(bool value) { }

	public void set_returnSpeed(float value) { }

	public void set_scaleStickRange(bool value) { }

	public void set_snapDirections(SnapDirections value) { }

	public void set_snapStickToTouch(bool value) { }

	public void set_stayActiveOnSwipeOut(bool value) { }

	public void set_stickRange(float value) { }

	public void set_stickTransform(RectTransform value) { }

	public void set_tapDistanceLimit(int value) { }

	public void set_tapTimeout(float value) { }

	public void set_touchRegion(TouchRegion value) { }

	public void set_useTouchRegionOnly(bool value) { }

	public void SetDefaultPosition() { }

	public void SetRawValue(Vector2 value) { }

	private void SjstqNUwzaDctbmePxorxKGkGUcI(EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_0, Vector2 unnamed_param_1, PositionType unnamed_param_2) { }

	private void szgaAwAWKMRPZgipmAGnQkzanfvL() { }

	private void tgxqETaSOoIlRQzqXNmmoBpSPbgl(StickBounds unnamed_param_0) { }

	internal virtual void TGXRTGfcXmefyaQRAmuPLICoabcTA(PointerEventData unnamed_param_0) { }

	private void unsFtwcaeJtQbeAHydpgBSqAjmiD(Vector2 unnamed_param_0, PositionType unnamed_param_1, bool unnamed_param_2, float unnamed_param_3, EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_4) { }

	internal virtual bool vegXsJqHqSwpTTYKNnVEnmAxixoK(GameObject unnamed_param_0) { }

	private PointerEventData vmzjPOzIuVsJhCBoygKFjOQGIBzl(int unnamed_param_0, GameObject unnamed_param_1) { }

	internal static EventFunction<IStickPositionChangedHandler, Vector2> VnKrPCEuCylXOebXJUMZanHWGpEz() { }

	private void VOViliYxiSraqrSMSQfdaSXHDixEA(PointerEventData unnamed_param_0, FUUEstlYAVOMOHxOUQtmAniyGPYaA unnamed_param_1) { }

	private void wflnnruLFEkFLBegFibPtJOFmbQn(TouchRegion unnamed_param_0) { }

	internal virtual void wJGxodcvVBhPFcvjcosmWPUYkShF(PointerEventData unnamed_param_0) { }

	internal virtual void WuAJrOPQGZmohVlmObzfeXGkBzEP() { }

	private Action<EsgUKabNUhgArfpNnqEEMmUQHAzF> XUggrrVgBForlfmpCDDIzkimidgEA() { }

	internal virtual void yBUSBdYGzAGkKzdcZBafXHsIjVki() { }

	private void YVFKqzlybOZKNgpQuphyVHOyukwF(PointerEventData unnamed_param_0) { }

	private void YwOdOlISODLsoDDTkovcuspjsmQXb(EsgUKabNUhgArfpNnqEEMmUQHAzF unnamed_param_0) { }

	private bool ZhhLQWVvWRRSPklWymYqFjPDMAQQ(int unnamed_param_0) { }

}

