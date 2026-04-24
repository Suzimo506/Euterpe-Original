namespace Rewired.Internal;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class StandaloneAxis
{
	[CustomObfuscation]
	internal sealed class AxisValueChangedEventHandler : MulticastDelegate
	{

		public AxisValueChangedEventHandler(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(float value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(float value) { }

	}

	[CustomObfuscation]
	internal sealed class ButtonDownEventHandler : MulticastDelegate
	{

		public ButtonDownEventHandler(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CustomObfuscation]
	internal sealed class ButtonUpEventHandler : MulticastDelegate
	{

		public ButtonUpEventHandler(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CustomObfuscation]
	internal sealed class ButtonValueChangedEventHandler : MulticastDelegate
	{

		public ButtonValueChangedEventHandler(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(bool value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool value) { }

	}

	[CustomObfuscation]
	[Range(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _buttonActivationThreshold; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisCalibration _calibration; //Field offset: 0x18
	[CustomObfuscation]
	private float _valueRaw; //Field offset: 0x20
	[CustomObfuscation]
	private float _valueRawPrev; //Field offset: 0x24
	[CompilerGenerated]
	private AxisValueChangedEventHandler NRxDQEfgedSPfoczVacNBreVEAocb; //Field offset: 0x28
	[CompilerGenerated]
	private AxisValueChangedEventHandler ltCBmSqNCYZGvVzjbMZCjpmsyBt; //Field offset: 0x30
	[CompilerGenerated]
	private ButtonDownEventHandler aBDrkffBMTXsHlvJIBCCwYyWBBqo; //Field offset: 0x38
	[CompilerGenerated]
	private ButtonUpEventHandler GjuRoeAEyXNBBrXHndCiqcguljUX; //Field offset: 0x40
	[CompilerGenerated]
	private ButtonValueChangedEventHandler MQRGdTORrnDbRFDomILZmEZrzQLC; //Field offset: 0x48
	[CompilerGenerated]
	private ButtonDownEventHandler AFAGLGWeDlEygQuZMpbPDDsJtvS; //Field offset: 0x50
	[CompilerGenerated]
	private ButtonUpEventHandler LFYeKVkxTeZemdlvfZQUoSgkCqtx; //Field offset: 0x58
	[CompilerGenerated]
	private ButtonValueChangedEventHandler ZXvAAnoGRWHEhDfHkJHRUpXUybrC; //Field offset: 0x60

	private event AxisValueChangedEventHandler _AxisValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonDownEventHandler _ButtonDownEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonUpEventHandler _ButtonUpEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonValueChangedEventHandler _ButtonValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event AxisValueChangedEventHandler _RawAxisValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonDownEventHandler _RawButtonDownEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonUpEventHandler _RawButtonUpEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ButtonValueChangedEventHandler _RawButtonValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public event AxisValueChangedEventHandler AxisValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonDownEventHandler ButtonDownEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonUpEventHandler ButtonUpEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonValueChangedEventHandler ButtonValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event AxisValueChangedEventHandler RawAxisValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonDownEventHandler RawButtonDownEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonUpEventHandler RawButtonUpEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ButtonValueChangedEventHandler RawButtonValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public float buttonActivationThreshold
	{
		 get { } //Length: 6
		 set { } //Length: 38
	}

	public bool buttonValue
	{
		 get { } //Length: 90
	}

	public bool buttonValuePrev
	{
		 get { } //Length: 90
	}

	public private AxisCalibration calibration
	{
		 get { } //Length: 5
		private set { } //Length: 18
	}

	public bool rawButtonValue
	{
		 get { } //Length: 13
	}

	public bool rawButtonValuePrev
	{
		 get { } //Length: 13
	}

	internal float rawMax
	{
		internal get { } //Length: 39
	}

	internal float rawMin
	{
		internal get { } //Length: 39
	}

	internal float rawZero
	{
		internal get { } //Length: 25
	}

	public float value
	{
		 get { } //Length: 29
	}

	public float valueDelta
	{
		 get { } //Length: 98
	}

	public float valuePrev
	{
		 get { } //Length: 29
	}

	public private float valueRaw
	{
		 get { } //Length: 6
		private set { } //Length: 14
	}

	public float valueRawDelta
	{
		 get { } //Length: 11
	}

	public private float valueRawPrev
	{
		 get { } //Length: 6
		private set { } //Length: 14
	}

	internal StandaloneAxis() { }

	public void add_AxisValueChangedEvent(AxisValueChangedEventHandler value) { }

	public void add_ButtonDownEvent(ButtonDownEventHandler value) { }

	public void add_ButtonUpEvent(ButtonUpEventHandler value) { }

	public void add_ButtonValueChangedEvent(ButtonValueChangedEventHandler value) { }

	public void add_RawAxisValueChangedEvent(AxisValueChangedEventHandler value) { }

	public void add_RawButtonDownEvent(ButtonDownEventHandler value) { }

	public void add_RawButtonUpEvent(ButtonUpEventHandler value) { }

	public void add_RawButtonValueChangedEvent(ButtonValueChangedEventHandler value) { }

	[CompilerGenerated]
	private void aefPyleJYMLzZOGaTYoiiaWdGIin(ButtonValueChangedEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void aMxNifwYliwXXyZzffeSFgFjGIlU(ButtonDownEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void BxSVnIHeLuBPMrBisugRWASFmSXe(AxisValueChangedEventHandler unnamed_param_0) { }

	public void Clear() { }

	[CustomObfuscation]
	internal static StandaloneAxis CreateRelative() { }

	private void eIuAYYzcrESPvyTfRgkoVkCOIxrW(AxisCalibration unnamed_param_0) { }

	[CompilerGenerated]
	private void EUQhxXdlCAxnQKqVfNIlOEAPcHyS(AxisValueChangedEventHandler unnamed_param_0) { }

	public float get_buttonActivationThreshold() { }

	public bool get_buttonValue() { }

	public bool get_buttonValuePrev() { }

	public AxisCalibration get_calibration() { }

	public bool get_rawButtonValue() { }

	public bool get_rawButtonValuePrev() { }

	internal float get_rawMax() { }

	internal float get_rawMin() { }

	internal float get_rawZero() { }

	public float get_value() { }

	public float get_valueDelta() { }

	public float get_valuePrev() { }

	public float get_valueRaw() { }

	public float get_valueRawDelta() { }

	public float get_valueRawPrev() { }

	[CompilerGenerated]
	private void gROhFZOBmlPySrOcMtjVEonVIlRAA(ButtonValueChangedEventHandler unnamed_param_0) { }

	private void GYxWicDpapGoqZhnuHSIFvlzghssA(float unnamed_param_0) { }

	[CompilerGenerated]
	private void IdSfErKlcIAzEueMyLsBlHVweTiLA(ButtonValueChangedEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void iZnBJVVfcBimcBTggdIIiIfnlStm(ButtonUpEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void kGsSPzebuURDwrAHlTdmUDKbtAPK(ButtonValueChangedEventHandler unnamed_param_0) { }

	private void LiNdJMCcDCllOIZyGLtwlmGVEnmwB(float unnamed_param_0) { }

	[CompilerGenerated]
	private void LRddoGiGAPbuEmwzYTVDoqIjhrwL(ButtonUpEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void NiBFYlrrnokudMPeInShPnJhQeDx(ButtonUpEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void PKDyNjFiEcYftiTaCBXRFHYhFQOc(ButtonDownEventHandler unnamed_param_0) { }

	public void remove_AxisValueChangedEvent(AxisValueChangedEventHandler value) { }

	public void remove_ButtonDownEvent(ButtonDownEventHandler value) { }

	public void remove_ButtonUpEvent(ButtonUpEventHandler value) { }

	public void remove_ButtonValueChangedEvent(ButtonValueChangedEventHandler value) { }

	public void remove_RawAxisValueChangedEvent(AxisValueChangedEventHandler value) { }

	public void remove_RawButtonDownEvent(ButtonDownEventHandler value) { }

	public void remove_RawButtonUpEvent(ButtonUpEventHandler value) { }

	public void remove_RawButtonValueChangedEvent(ButtonValueChangedEventHandler value) { }

	[CompilerGenerated]
	private void ScHilFeRgnPvvHKZnGmNozSXdjYvA(ButtonUpEventHandler unnamed_param_0) { }

	public void set_buttonActivationThreshold(float value) { }

	public void SetRawValue(float value) { }

	[CompilerGenerated]
	private void tnAkXjoXAHdLnQbSQFZzrZrdBcUF(AxisValueChangedEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void TwhesttMPZfRInlgPoKGZrRrQmVl(ButtonDownEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void uoLSwYpAXfWtimDBVigHgaeOERSmA(ButtonDownEventHandler unnamed_param_0) { }

	[CompilerGenerated]
	private void wIviLALOQmBJEABtuItKBbwRlFkxA(AxisValueChangedEventHandler unnamed_param_0) { }

}

