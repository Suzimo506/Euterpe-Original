namespace Rewired.Drivers.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IDriver_DualShock4 : IControllerDriver
{

	public Vector3 AccelerometerValue
	{
		 get { } //Length: 0
	}

	public Vector3 AccelerometerValueRaw
	{
		 get { } //Length: 0
	}

	public float BatteryLevel
	{
		 get { } //Length: 0
	}

	public Vector3 GyroscopeValue
	{
		 get { } //Length: 0
	}

	public Vector3 GyroscopeValueRaw
	{
		 get { } //Length: 0
	}

	public Vector3 LastGyroscopeValue
	{
		 get { } //Length: 0
	}

	public Vector3 LastGyroscopeValueRaw
	{
		 get { } //Length: 0
	}

	public float LeftMotor
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LightColorB
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LightColorG
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LightColorR
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LightFlashOffDuration
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float LightFlashOnDuration
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int MaxTouches
	{
		 get { } //Length: 0
	}

	public Quaternion Orientation
	{
		 get { } //Length: 0
	}

	public float RightMotor
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3 get_AccelerometerValue() { }

	public Vector3 get_AccelerometerValueRaw() { }

	public float get_BatteryLevel() { }

	public Vector3 get_GyroscopeValue() { }

	public Vector3 get_GyroscopeValueRaw() { }

	public Vector3 get_LastGyroscopeValue() { }

	public Vector3 get_LastGyroscopeValueRaw() { }

	public float get_LeftMotor() { }

	public float get_LightColorB() { }

	public float get_LightColorG() { }

	public float get_LightColorR() { }

	public float get_LightFlashOffDuration() { }

	public float get_LightFlashOnDuration() { }

	public int get_MaxTouches() { }

	public Quaternion get_Orientation() { }

	public float get_RightMotor() { }

	public int GetTouchCount() { }

	public int GetTouchIdAtIndex(int index) { }

	public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY) { }

	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY) { }

	public bool GetTouchPositionByIndex(int index, out Vector2 position) { }

	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	public bool IsTouchingAtIndex(int index) { }

	public bool IsTouchingAtTouchId(int touchId) { }

	public void ResetOrientation() { }

	public void set_LeftMotor(float value) { }

	public void set_LightColorB(float value) { }

	public void set_LightColorG(float value) { }

	public void set_LightColorR(float value) { }

	public void set_LightFlashOffDuration(float value) { }

	public void set_LightFlashOnDuration(float value) { }

	public void set_RightMotor(float value) { }

	public void StopLightFlash() { }

	public void StopVibration() { }

}

