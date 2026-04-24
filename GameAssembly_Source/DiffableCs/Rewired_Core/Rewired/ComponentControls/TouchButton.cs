namespace Rewired.ComponentControls;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[CustomClassObfuscation]
[DisallowMultipleComponent]
public sealed class TouchButton : TouchInteractable
{
	internal class AxisValueChangedEventHandler : UnityEvent<Single>
	{

		public AxisValueChangedEventHandler() { }

	}

	internal class ButtonDownEventHandler : UnityEvent
	{

		public ButtonDownEventHandler() { }

	}

	internal enum ButtonType
	{
		Standard = 0,
		ToggleSwitch = 1,
	}

	internal class ButtonUpEventHandler : UnityEvent
	{

		public ButtonUpEventHandler() { }

	}

	internal class ButtonValueChangedEventHandler : UnityEvent<Boolean>
	{

		public ButtonValueChangedEventHandler() { }

	}

	private enum PiszOEuCeFlcBlHcXAOHQCuISYcm
	{
		None = 0,
		TowardTouch = 1,
		TowardHome = 2,
	}

	[CompilerGenerated]
	private sealed class PukcLYFJHYuWqUOqYWRIOHFrgVMr : IDisposable, IEnumerator, IEnumerator<Object>
	{
		private int KRIXAUBzIZuSrXQvmmRDIdDLNMDy; //Field offset: 0x10
		private object QmYCltCPirqKPuQbDoJgJIveCuAbb; //Field offset: 0x18
		public float LToXmXyqPMWuVwVeudDSSoZdGQIF; //Field offset: 0x20
		public TouchButton SaeLVRDNeiYZcQaAHxKpLrbuIKoJ; //Field offset: 0x28
		public PositionType QhrGSiZyUSzJFNAjRzQMJPagbAdJ; //Field offset: 0x30
		public Vector2 KcKGPYBiAqqTXqJNFnRSDTtOeexlA; //Field offset: 0x34
		public PiszOEuCeFlcBlHcXAOHQCuISYcm jycuEKqiIFefTeaOzvRWfizgKoWF; //Field offset: 0x3C
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
		public PukcLYFJHYuWqUOqYWRIOHFrgVMr(int unnamed_param_0) { }

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

	private enum RteOYEvbbSJXZykoCfzmCbZRbawaA
	{
		Local = 0,
		TouchRegion = 1,
	}

	private const float RiGsMODyKhguHfanxULZFmjgGJBw = 20; //Field offset: 0x0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; //Field offset: 0x128
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ButtonType _buttonType; //Field offset: 0x130
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _activateOnSwipeIn; //Field offset: 0x134
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _stayActiveOnSwipeOut; //Field offset: 0x135
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useDigitalAxisSimulation; //Field offset: 0x136
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _digitalAxisGravity; //Field offset: 0x138
	[CustomObfuscation]
	[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _digitalAxisSensitivity; //Field offset: 0x13C
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis _axis; //Field offset: 0x140
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TouchRegion _touchRegion; //Field offset: 0x148
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useTouchRegionOnly; //Field offset: 0x150
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _moveToTouchPosition; //Field offset: 0x151
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _returnOnRelease; //Field offset: 0x152
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _followTouchPosition; //Field offset: 0x153
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _animateOnMoveToTouch; //Field offset: 0x154
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _moveToTouchSpeed; //Field offset: 0x158
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _animateOnReturn; //Field offset: 0x15C
	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _returnSpeed; //Field offset: 0x160
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _manageRaycasting; //Field offset: 0x164
	private float DeqAEItuXluhYhdsVBlJAwoehJyC; //Field offset: 0x168
	private float AgYFHAcUxUUadBmfAnYMXclgjUlrA; //Field offset: 0x16C
	private TouchRegion ELEEhFEZgUgDPxgUIFAPzkOznlYS; //Field offset: 0x170
	private Vector2 mPugJMMaYxaWQhXDfBjQjFXmLYNo; //Field offset: 0x178
	private bool iJAxmaBfkSftLXaWzBwyFcFMECHpA; //Field offset: 0x180
	private bool bbsYpZaOTBwrJRCjoiucGxFpCDwFb; //Field offset: 0x181
	private PiszOEuCeFlcBlHcXAOHQCuISYcm teaUsytLAnBeBQpiMfnIyLcRdxoi; //Field offset: 0x184
	private int zCARCBQlJUOGhasxukKWneMhxeDT; //Field offset: 0x188
	private int MbEIzhKZOIrLwRKPSsioTjrRKtKI; //Field offset: 0x18C
	private bool DuJcSUBjODzIYmtFcaHJBSqEkpNCB; //Field offset: 0x190
	private bool gTLwGImOoZuPWcDofNJbHqzbgTvp; //Field offset: 0x191
	private IEnumerator UtajvvzKfwgOHuweclVucmXqvIzO; //Field offset: 0x198
	private tvOGaxCAklFNVhSLNQFXkYdybIkDb OSsFBdADOvYoRkyqDeIwSjbtzkyE; //Field offset: 0x1A0
	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> eiOiFNFNjOSUJZjjtdRVKsUEimtN; //Field offset: 0x1A8
	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> RjXChYYXpBEWmFfVRLBeaexvTSYAA; //Field offset: 0x1B0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisValueChangedEventHandler _onAxisValueChanged; //Field offset: 0x1B8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ButtonValueChangedEventHandler _onButtonValueChanged; //Field offset: 0x1C0
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ButtonDownEventHandler _onButtonDown; //Field offset: 0x1C8
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ButtonUpEventHandler _onButtonUp; //Field offset: 0x1D0
	private Dictionary<Int32, PointerEventData> ZyNksDewgtndAZTuANrZCEzUhIsy; //Field offset: 0x1D8

	public event UnityAction<Single> AxisValueChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public event UnityAction ButtonDownEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction ButtonUpEvent
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction<Boolean> ButtonValueChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public bool activateOnSwipeIn
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

	internal StandaloneAxis axis
	{
		internal get { } //Length: 8
	}

	private float axisValue
	{
		private get { } //Length: 54
	}

	private float axisValuePrev
	{
		private get { } //Length: 54
	}

	public ButtonType buttonType
	{
		 get { } //Length: 7
		 set { } //Length: 32
	}

	private bool buttonValue
	{
		private get { } //Length: 32
	}

	private bool buttonValuePrev
	{
		private get { } //Length: 32
	}

	public float digitalAxisGravity
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	public float digitalAxisSensitivity
	{
		 get { } //Length: 9
		 set { } //Length: 41
	}

	private int effectivePointerId
	{
		private get { } //Length: 35
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

	public bool manageRaycasting
	{
		 get { } //Length: 8
		 set { } //Length: 148
	}

	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> moveEndedDelegate
	{
		private get { } //Length: 138
	}

	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> moveStartedDelegate
	{
		private get { } //Length: 138
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

	public int pointerId
	{
		 get { } //Length: 7
		 set { } //Length: 7
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

	public bool stayActiveOnSwipeOut
	{
		 get { } //Length: 139
		 set { } //Length: 32
	}

	public CustomControllerElementTargetSetForFloat targetCustomControllerElement
	{
		 get { } //Length: 8
	}

	public TouchRegion touchRegion
	{
		 get { } //Length: 8
		 set { } //Length: 170
	}

	public bool useDigitalAxisSimulation
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	public bool useTouchRegionOnly
	{
		 get { } //Length: 8
		 set { } //Length: 32
	}

	[CustomObfuscation]
	private TouchButton() { }

	public void add_AxisValueChangedEvent(UnityAction<Single> value) { }

	public void add_ButtonDownEvent(UnityAction value) { }

	public void add_ButtonUpEvent(UnityAction value) { }

	public void add_ButtonValueChangedEvent(UnityAction<Boolean> value) { }

	[CustomObfuscation]
	internal virtual void Awake() { }

	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> biCvrhfLyYDpXqbjqHGmpLconklQ() { }

	private void bYgwHRgUjtLYntbMRrgSJBSzemFG() { }

	public virtual void ClearValue() { }

	private bool DhmyEJqjZdUXTJnYVoTYwPnNfboP() { }

	private void DYaShGCXeYtAQWVdLWMUduHHndSC() { }

	private void ECURNdbyADoePQriPprPRjmCavqGA(PointerEventData unnamed_param_0, RteOYEvbbSJXZykoCfzmCbZRbawaA unnamed_param_1) { }

	private void FbQxbefVobvYkIzeduWYWOEBpScl(PointerEventData unnamed_param_0) { }

	private void fLuCFevAvOPYnsFPcntbVMcKazqN() { }

	public bool get_activateOnSwipeIn() { }

	public bool get_animateOnMoveToTouch() { }

	public bool get_animateOnReturn() { }

	internal StandaloneAxis get_axis() { }

	public ButtonType get_buttonType() { }

	public float get_digitalAxisGravity() { }

	public float get_digitalAxisSensitivity() { }

	public bool get_followTouchPosition() { }

	public bool get_hasPointer() { }

	public bool get_manageRaycasting() { }

	public bool get_moveToTouchPosition() { }

	public float get_moveToTouchSpeed() { }

	public int get_pointerId() { }

	public bool get_returnOnRelease() { }

	public float get_returnSpeed() { }

	public bool get_stayActiveOnSwipeOut() { }

	public CustomControllerElementTargetSetForFloat get_targetCustomControllerElement() { }

	public TouchRegion get_touchRegion() { }

	public bool get_useDigitalAxisSimulation() { }

	public bool get_useTouchRegionOnly() { }

	private PointerEventData GfIcFnETEYNBQZwJfzcDCoZlNBPm(int unnamed_param_0) { }

	private void gGswgCTRpYyKFqfimZvuVdwHMbQn() { }

	private void gMQVtxyyjkyxnvNLdXsQPAKkjYgP(PointerEventData unnamed_param_0) { }

	private void gquBuDqJXGDqnBkBWIVtmAIDgqym(TouchRegion unnamed_param_0) { }

	private void hFwPxfrRASUUEpXZKciCylyxekwJA() { }

	private IEnumerator iaxtIbXaLgqEpmayKUdwnRXXBlte(Vector2 unnamed_param_0, PositionType unnamed_param_1, float unnamed_param_2, PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_3) { }

	private void INhePaNZUAGnxaRNvKwTlBYClAnI(PointerEventData unnamed_param_0, RteOYEvbbSJXZykoCfzmCbZRbawaA unnamed_param_1) { }

	private PointerEventData iqzUKzYNVodFSHSVrbXzmvVdrlEJA(int unnamed_param_0) { }

	private bool irKWTeUTBkdIeyNYyiFwvoKoQNTN() { }

	internal virtual bool IsPressed() { }

	internal virtual bool IsThisOrTouchRegionGameObject(GameObject gameObject) { }

	private void jPzixhoOmTQGZkslHUtEVnRMZDKl() { }

	private void JSmkdTRmtmCvHJrWvzmVUsdcftmG(Vector2 unnamed_param_0) { }

	private void JUwCqghxDRPuElvKppObbFmsKLNIA(int unnamed_param_0) { }

	private bool jwMnZiCnVWQZJdhvnteddSjELQwV() { }

	private void kanrSKRZAkkcwtYCkwpmmBOZsbux() { }

	private float KiTeTxIvUQenEPEobbraWYSsuDvbA() { }

	private void kJWauNfuKKXGGKGJzEXkSsbhvJRsA(Vector2 unnamed_param_0, bool unnamed_param_1, float unnamed_param_2, PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_3) { }

	private void KXRtDfXGDCRIDKxpUxTUuXOvdPxE(PointerEventData unnamed_param_0) { }

	private void lcClkIXKkliropInwshOonlpvjz(float unnamed_param_0) { }

	private int LfvdRDhzCWZeWbLdhTwRabwvVmIRA() { }

	private void LXElcWcHNtHhBJFLyniKDgDioWCBb(float unnamed_param_0, bool unnamed_param_1) { }

	private void lxpmRsCazKWmQkiEFJKetJtiWVCj(PointerEventData unnamed_param_0, RteOYEvbbSJXZykoCfzmCbZRbawaA unnamed_param_1) { }

	private void LzqPBgHRpzbpIYjWgLvnJsZPWUtd() { }

	private void MsNOSXPoGhKUSzeVaZXxQPgbiuAB(int unnamed_param_0, Vector2 unnamed_param_1, RteOYEvbbSJXZykoCfzmCbZRbawaA unnamed_param_2) { }

	private void nbQehsiXglrcldDcqrnYbKaTNsYBb(bool unnamed_param_0) { }

	private void NdtwwVisOUKxUKbpiyEVOEYJhbNC(PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_0) { }

	private void NRUMeCqLHZuQSyxzhvtxbQEvsHWl(PointerEventData unnamed_param_0) { }

	private float nUheDWJGmGrKyHmTLfKXaVtYaTco() { }

	internal virtual void OnClear() { }

	internal virtual void OnCustomControllerUpdate() { }

	[CustomObfuscation]
	internal virtual void OnDisable() { }

	[CustomObfuscation]
	internal virtual void OnEnable() { }

	internal virtual bool OnInitialize() { }

	internal virtual void OnPointerDown(PointerEventData eventData) { }

	internal virtual void OnPointerEnter(PointerEventData eventData) { }

	internal virtual void OnPointerExit(PointerEventData eventData) { }

	internal virtual void OnPointerUp(PointerEventData eventData) { }

	internal virtual void OnSetProperty() { }

	internal virtual void OnSubscribeEvents() { }

	internal virtual void OnUnsubscribeEvents() { }

	internal virtual void OnUpdate() { }

	[CustomObfuscation]
	internal virtual void OnValidate() { }

	private bool OyvfapPUQDtiCvarncOGzLVVEvSFA() { }

	private void ozyeCYCAxDTknsiZBbhuDzxTyZCn(PointerEventData unnamed_param_0, RteOYEvbbSJXZykoCfzmCbZRbawaA unnamed_param_1) { }

	private void PDVYVljbdzmSOEfSaDqGlEcccEyIA() { }

	private void PYOhtvvKnBrSoFGfCNQqwDvAgYMiA() { }

	private void qbBTEkDnIlsNpjKgBAHMxRxQhcDF() { }

	private void qIOOUOfGJOqXvoHyKTarkiQvbqlAA() { }

	public void remove_AxisValueChangedEvent(UnityAction<Single> value) { }

	public void remove_ButtonDownEvent(UnityAction value) { }

	public void remove_ButtonUpEvent(UnityAction value) { }

	public void remove_ButtonValueChangedEvent(UnityAction<Boolean> value) { }

	[CustomObfuscation]
	internal virtual void Reset() { }

	public void ReturnToDefaultPosition() { }

	public void ReturnToDefaultPosition(bool instant) { }

	public void set_activateOnSwipeIn(bool value) { }

	public void set_animateOnMoveToTouch(bool value) { }

	public void set_animateOnReturn(bool value) { }

	public void set_buttonType(ButtonType value) { }

	public void set_digitalAxisGravity(float value) { }

	public void set_digitalAxisSensitivity(float value) { }

	public void set_followTouchPosition(bool value) { }

	public void set_manageRaycasting(bool value) { }

	public void set_moveToTouchPosition(bool value) { }

	public void set_moveToTouchSpeed(float value) { }

	public void set_pointerId(int value) { }

	public void set_returnOnRelease(bool value) { }

	public void set_returnSpeed(float value) { }

	public void set_stayActiveOnSwipeOut(bool value) { }

	public void set_touchRegion(TouchRegion value) { }

	public void set_useDigitalAxisSimulation(bool value) { }

	public void set_useTouchRegionOnly(bool value) { }

	public void SetDefaultPosition() { }

	public void SetRawValue(float value) { }

	private void SjstqNUwzaDctbmePxorxKGkGUcI(PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_0, Vector2 unnamed_param_1, PositionType unnamed_param_2) { }

	private void szgaAwAWKMRPZgipmAGnQkzanfvL() { }

	private void unsFtwcaeJtQbeAHydpgBSqAjmiD(Vector2 unnamed_param_0, PositionType unnamed_param_1, bool unnamed_param_2, float unnamed_param_3, PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_4) { }

	private PointerEventData vmzjPOzIuVsJhCBoygKFjOQGIBzl(int unnamed_param_0, GameObject unnamed_param_1) { }

	private void wflnnruLFEkFLBegFibPtJOFmbQn(TouchRegion unnamed_param_0) { }

	private Action<PiszOEuCeFlcBlHcXAOHQCuISYcm> XUggrrVgBForlfmpCDDIzkimidgEA() { }

	private void ymyBNKbIbEMSbZVeHFRnSHgqHMnPA() { }

	private void YVFKqzlybOZKNgpQuphyVHOyukwF(PointerEventData unnamed_param_0) { }

	private void YwOdOlISODLsoDDTkovcuspjsmQXb(PiszOEuCeFlcBlHcXAOHQCuISYcm unnamed_param_0) { }

	private bool ZhhLQWVvWRRSPklWymYqFjPDMAQQ(int unnamed_param_0) { }

}

