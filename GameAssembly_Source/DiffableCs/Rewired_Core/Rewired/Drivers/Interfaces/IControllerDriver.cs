namespace Rewired.Drivers.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IControllerDriver
{

	public int AccelerometerCount
	{
		 get { } //Length: 0
	}

	public int AxisCount
	{
		 get { } //Length: 0
	}

	public int ButtonCount
	{
		 get { } //Length: 0
	}

	public int GyroscopeCount
	{
		 get { } //Length: 0
	}

	public int HatCount
	{
		 get { } //Length: 0
	}

	public int LightCount
	{
		 get { } //Length: 0
	}

	public int TouchpadCount
	{
		 get { } //Length: 0
	}

	public int VibrationMotorCount
	{
		 get { } //Length: 0
	}

	public int get_AccelerometerCount() { }

	public int get_AxisCount() { }

	public int get_ButtonCount() { }

	public int get_GyroscopeCount() { }

	public int get_HatCount() { }

	public int get_LightCount() { }

	public int get_TouchpadCount() { }

	public int get_VibrationMotorCount() { }

}

