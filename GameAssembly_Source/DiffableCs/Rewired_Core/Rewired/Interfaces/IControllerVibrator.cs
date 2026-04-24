namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
public interface IControllerVibrator
{

	public int vibrationMotorCount
	{
		 get { } //Length: 0
	}

	public int get_vibrationMotorCount() { }

	public float GetVibration(int motorIndex) { }

	public void SetVibration(int motorIndex, float motorLevel) { }

	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	public void StopVibration() { }

}

