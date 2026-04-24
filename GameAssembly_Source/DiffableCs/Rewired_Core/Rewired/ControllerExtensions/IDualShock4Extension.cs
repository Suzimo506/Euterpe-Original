namespace Rewired.ControllerExtensions;

public interface IDualShock4Extension : IControllerVibrator
{

	public int maxTouches
	{
		 get { } //Length: 0
	}

	public int touchCount
	{
		 get { } //Length: 0
	}

	public int get_maxTouches() { }

	public int get_touchCount() { }

	public Vector3 GetAccelerometerValue() { }

	public Vector3 GetAccelerometerValueRaw() { }

	public Vector3 GetGyroscopeValue() { }

	public Vector3 GetGyroscopeValueRaw() { }

	public Quaternion GetOrientation() { }

	public int GetTouchId(int index) { }

	public bool GetTouchPosition(int index, out Vector2 position) { }

	public bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	public bool IsTouching(int index) { }

	public bool IsTouchingByTouchId(int touchId) { }

	public void ResetOrientation() { }

	public void SetLightColor(float red, float green, float blue, float intensity) { }

	public void SetLightColor(float red, float green, float blue) { }

	public void SetLightColor(Color color) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

}

