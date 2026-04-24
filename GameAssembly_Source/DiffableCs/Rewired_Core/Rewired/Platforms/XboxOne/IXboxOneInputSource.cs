namespace Rewired.Platforms.XboxOne;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IXboxOneInputSource
{

	public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId) { }

	public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	public bool SetXboxOneVibration(ulong xboxOneJoystickId, RxhTXRdmHUscXChCXFKlTcNXwkox vibration) { }

}

