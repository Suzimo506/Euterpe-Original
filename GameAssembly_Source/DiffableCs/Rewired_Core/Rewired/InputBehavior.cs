namespace Rewired;

public sealed class InputBehavior
{
	[CustomObfuscation]
	[SerializeField]
	private int _id; //Field offset: 0x10
	[CustomObfuscation]
	[SerializeField]
	private string _name; //Field offset: 0x18
	[CustomObfuscation]
	[SerializeField]
	private float _joystickAxisSensitivity; //Field offset: 0x20
	[CustomObfuscation]
	[SerializeField]
	private bool _digitalAxisSimulation; //Field offset: 0x24
	[CustomObfuscation]
	[SerializeField]
	private bool _digitalAxisSnap; //Field offset: 0x25
	[CustomObfuscation]
	[SerializeField]
	private bool _digitalAxisInstantReverse; //Field offset: 0x26
	[CustomObfuscation]
	[SerializeField]
	private float _digitalAxisGravity; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	private float _digitalAxisSensitivity; //Field offset: 0x2C
	[CustomObfuscation]
	[SerializeField]
	private MouseXYAxisMode _mouseXYAxisMode; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	private MouseOtherAxisMode _mouseOtherAxisMode; //Field offset: 0x34
	[CustomObfuscation]
	[SerializeField]
	private float _mouseXYAxisSensitivity; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc; //Field offset: 0x3C
	[CustomObfuscation]
	[SerializeField]
	private float _mouseOtherAxisSensitivity; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	private float _customControllerAxisSensitivity; //Field offset: 0x44
	[CustomObfuscation]
	[SerializeField]
	private float _buttonDoublePressSpeed; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	private float _buttonShortPressTime; //Field offset: 0x4C
	[CustomObfuscation]
	[SerializeField]
	private float _buttonShortPressExpiresIn; //Field offset: 0x50
	[CustomObfuscation]
	[SerializeField]
	private float _buttonLongPressTime; //Field offset: 0x54
	[CustomObfuscation]
	[SerializeField]
	private float _buttonLongPressExpiresIn; //Field offset: 0x58
	[CustomObfuscation]
	[SerializeField]
	private float _buttonDeadZone; //Field offset: 0x5C
	[CustomObfuscation]
	[SerializeField]
	private float _buttonDownBuffer; //Field offset: 0x60
	[CustomObfuscation]
	[SerializeField]
	private float _buttonRepeatRate; //Field offset: 0x64
	[CustomObfuscation]
	[SerializeField]
	private float _buttonRepeatDelay; //Field offset: 0x68

	public float buttonDeadZone
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float buttonDoublePressSpeed
	{
		 get { } //Length: 6
		 set { } //Length: 47
	}

	public float buttonDownBuffer
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float buttonLongPressExpiresIn
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float buttonLongPressTime
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float buttonRepeatDelay
	{
		 get { } //Length: 6
		 set { } //Length: 31
	}

	public float buttonRepeatRate
	{
		 get { } //Length: 6
		 set { } //Length: 36
	}

	public float buttonShortPressExpiresIn
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float buttonShortPressTime
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float customControllerAxisSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public float digitalAxisGravity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public bool digitalAxisInstantReverse
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float digitalAxisSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public bool digitalAxisSimulation
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool digitalAxisSnap
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public internal int id
	{
		 get { } //Length: 4
		internal set { } //Length: 4
	}

	public float joystickAxisSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public MouseOtherAxisMode mouseOtherAxisMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float mouseOtherAxisSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public MouseXYAxisMode mouseXYAxisMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public float mouseXYAxisSensitivity
	{
		 get { } //Length: 6
		 set { } //Length: 42
	}

	public internal string name
	{
		 get { } //Length: 5
		internal set { } //Length: 12
	}

	public InputBehavior(InputBehavior unnamed_param_0) { }

	public InputBehavior() { }

	internal void AiNRcvlSlmllpxXTRCmcgVKhyqpA(SerializedObject unnamed_param_0) { }

	public InputBehavior Clone() { }

	internal void FMGZevJqvRRmnTSSJuVBRJiDdbHGA(string unnamed_param_0) { }

	public float get_buttonDeadZone() { }

	public float get_buttonDoublePressSpeed() { }

	public float get_buttonDownBuffer() { }

	public float get_buttonLongPressExpiresIn() { }

	public float get_buttonLongPressTime() { }

	public float get_buttonRepeatDelay() { }

	public float get_buttonRepeatRate() { }

	public float get_buttonShortPressExpiresIn() { }

	public float get_buttonShortPressTime() { }

	public float get_customControllerAxisSensitivity() { }

	public float get_digitalAxisGravity() { }

	public bool get_digitalAxisInstantReverse() { }

	public float get_digitalAxisSensitivity() { }

	public bool get_digitalAxisSimulation() { }

	public bool get_digitalAxisSnap() { }

	public int get_id() { }

	public float get_joystickAxisSensitivity() { }

	public MouseOtherAxisMode get_mouseOtherAxisMode() { }

	public float get_mouseOtherAxisSensitivity() { }

	public MouseXYAxisDeltaCalc get_mouseXYAxisDeltaCalc() { }

	public MouseXYAxisMode get_mouseXYAxisMode() { }

	public float get_mouseXYAxisSensitivity() { }

	public string get_name() { }

	public bool ImportData(InputBehavior inputBehavior) { }

	public bool ImportJsonString(string jsonString) { }

	public bool ImportXmlString(string xmlString) { }

	internal void KyvbRlfYYXPzrDbOConEVpBYBOPj(int unnamed_param_0) { }

	public void Reset() { }

	public void set_buttonDeadZone(float value) { }

	public void set_buttonDoublePressSpeed(float value) { }

	public void set_buttonDownBuffer(float value) { }

	public void set_buttonLongPressExpiresIn(float value) { }

	public void set_buttonLongPressTime(float value) { }

	public void set_buttonRepeatDelay(float value) { }

	public void set_buttonRepeatRate(float value) { }

	public void set_buttonShortPressExpiresIn(float value) { }

	public void set_buttonShortPressTime(float value) { }

	public void set_customControllerAxisSensitivity(float value) { }

	public void set_digitalAxisGravity(float value) { }

	public void set_digitalAxisInstantReverse(bool value) { }

	public void set_digitalAxisSensitivity(float value) { }

	public void set_digitalAxisSimulation(bool value) { }

	public void set_digitalAxisSnap(bool value) { }

	public void set_joystickAxisSensitivity(float value) { }

	public void set_mouseOtherAxisMode(MouseOtherAxisMode value) { }

	public void set_mouseOtherAxisSensitivity(float value) { }

	public void set_mouseXYAxisDeltaCalc(MouseXYAxisDeltaCalc value) { }

	public void set_mouseXYAxisMode(MouseXYAxisMode value) { }

	public void set_mouseXYAxisSensitivity(float value) { }

	private static void tiVefhpCTbOiCDmyxNFthIrhMflu(InputBehavior unnamed_param_0, InputBehavior unnamed_param_1, bool unnamed_param_2) { }

	public string ToJsonString() { }

	public string ToXmlString() { }

	internal SerializedObject zSSqMsjrGuBczUUPWMDhgYaQcFnu() { }

}

