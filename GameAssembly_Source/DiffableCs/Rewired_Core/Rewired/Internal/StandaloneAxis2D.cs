namespace Rewired.Internal;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class StandaloneAxis2D
{
	[CustomObfuscation]
	internal sealed class ValueChangedEventHandler : MulticastDelegate
	{

		public ValueChangedEventHandler(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(Vector2 value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Vector2 value) { }

	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Axis2DCalibration _calibration; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis _xAxis; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private StandaloneAxis _yAxis; //Field offset: 0x20
	private bool _allowEvents; //Field offset: 0x28
	[CompilerGenerated]
	private ValueChangedEventHandler _ValueChangedEvent; //Field offset: 0x30
	[CompilerGenerated]
	private ValueChangedEventHandler _RawValueChangedEvent; //Field offset: 0x38

	private event ValueChangedEventHandler _RawValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	private event ValueChangedEventHandler _ValueChangedEvent
	{
		[CompilerGenerated]
		private add { } //Length: 158
		[CompilerGenerated]
		private remove { } //Length: 158
	}

	public event ValueChangedEventHandler RawValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public event ValueChangedEventHandler ValueChangedEvent
	{
		 add { } //Length: 158
		 remove { } //Length: 158
	}

	public Axis2DCalibration calibration
	{
		 get { } //Length: 5
	}

	public Vector2 rawValue
	{
		 get { } //Length: 114
	}

	public Vector2 rawValueDelta
	{
		 get { } //Length: 210
	}

	public Vector2 rawValuePrev
	{
		 get { } //Length: 114
	}

	internal Vector2 rawZero
	{
		internal get { } //Length: 114
	}

	public Vector2 value
	{
		 get { } //Length: 192
	}

	public Vector2 valueDelta
	{
		 get { } //Length: 293
	}

	public Vector2 valuePrev
	{
		 get { } //Length: 192
	}

	public StandaloneAxis xAxis
	{
		 get { } //Length: 5
	}

	public StandaloneAxis yAxis
	{
		 get { } //Length: 5
	}

	internal StandaloneAxis2D(StandaloneAxis unnamed_param_0, StandaloneAxis unnamed_param_1) { }

	internal StandaloneAxis2D() { }

	[CompilerGenerated]
	private void add__RawValueChangedEvent(ValueChangedEventHandler value) { }

	[CompilerGenerated]
	private void add__ValueChangedEvent(ValueChangedEventHandler value) { }

	public void add_RawValueChangedEvent(ValueChangedEventHandler value) { }

	public void add_ValueChangedEvent(ValueChangedEventHandler value) { }

	public void Clear() { }

	internal static StandaloneAxis2D CreateRelative() { }

	internal void Deinitialize() { }

	private void EvalAndSendValueChangeEvents() { }

	public Axis2DCalibration get_calibration() { }

	public Vector2 get_rawValue() { }

	public Vector2 get_rawValueDelta() { }

	public Vector2 get_rawValuePrev() { }

	internal Vector2 get_rawZero() { }

	public Vector2 get_value() { }

	public Vector2 get_valueDelta() { }

	public Vector2 get_valuePrev() { }

	public StandaloneAxis get_xAxis() { }

	public StandaloneAxis get_yAxis() { }

	private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis) { }

	private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis) { }

	internal void Initialize() { }

	private void OnAxisRawValueChanged(float value) { }

	private void OnAxisValueChanged(float value) { }

	[CompilerGenerated]
	private void remove__RawValueChangedEvent(ValueChangedEventHandler value) { }

	[CompilerGenerated]
	private void remove__ValueChangedEvent(ValueChangedEventHandler value) { }

	public void remove_RawValueChangedEvent(ValueChangedEventHandler value) { }

	public void remove_ValueChangedEvent(ValueChangedEventHandler value) { }

	public void SetRawValue(Vector2 value) { }

	public void SetRawValue(float x, float y) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

