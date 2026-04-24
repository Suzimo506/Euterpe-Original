namespace Rewired.Platforms.XboxOne;

public sealed class XboxOneGamepadExtension : Extension, IControllerVibrator
{
	private class uUTrqhHUdnnRuplSngyCTyfjLXiB : IControllerExtensionSource
	{
		public const int JcUCuhniTdAktXFrndNdqFzifrmfA = 4; //Field offset: 0x0
		public RxhTXRdmHUscXChCXFKlTcNXwkox dTtBLHJSRYEkahiFfzdISKWWDacNc; //Field offset: 0x10
		public readonly IXboxOneInputSource DyodyhRaONEJPkZPhevulztUCUlzA; //Field offset: 0x28
		public readonly bool ITUEJZQJRyurwfHKRVXnGxDVjMXL; //Field offset: 0x30

		public uUTrqhHUdnnRuplSngyCTyfjLXiB(bool unnamed_param_0, IXboxOneInputSource unnamed_param_1, RxhTXRdmHUscXChCXFKlTcNXwkox unnamed_param_2) { }

	}

	private uUTrqhHUdnnRuplSngyCTyfjLXiB sGQvzdoiXDPQjVYqDeByKrgVBTaQ; //Field offset: 0x28
	private TimerAbs[] ZwZmaVraNvSfccEnkyjfiuwHtOLI; //Field offset: 0x30

	private Joystick doaStyJAKnGYRbLwOlPQGhDGoklic
	{
		private get { } //Length: 56
	}

	public override int vibrationMotorCount
	{
		 get { } //Length: 142
	}

	public ulong xboxOneJoystickId
	{
		 get { } //Length: 607
	}

	public int xboxOneUserId
	{
		 get { } //Length: 521
	}

	internal XboxOneGamepadExtension(bool unnamed_param_0, IXboxOneInputSource unnamed_param_1) { }

	private XboxOneGamepadExtension(XboxOneGamepadExtension unnamed_param_0) { }

	private void AtrciWIZhlxJMmweLGWlWOTwEfFab() { }

	private void dxkKyRqKjOSkDXhkoBSojblYZuZsA() { }

	public override int get_vibrationMotorCount() { }

	public ulong get_xboxOneJoystickId() { }

	public int get_xboxOneUserId() { }

	public float GetVibration(XboxOneGamepadMotorType motor) { }

	public override float GetVibration(int motorIndex) { }

	internal virtual void GpGqGMzBGeWclQczaYnvQZtUlMsn(UpdateLoopType unnamed_param_0) { }

	private Joystick IONRbDEnqkRDkSvFFLhMWbXoyTGE() { }

	internal virtual void LpxMOcRLGJGfNEpnCBjpiLMJwmKgb(IControllerExtensionSource unnamed_param_0) { }

	public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration) { }

	public override void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration) { }

	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration) { }

	public override void SetVibration(int motorIndex, float motorLevel) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel) { }

	public override void StopVibration() { }

	internal virtual Extension ytRHXgQAbztNqpUyjHyDXXbonFrI() { }

	private void zNFASxOTSiNTihfYWjPodjsBsrQV(XboxOneGamepadMotorType unnamed_param_0, float unnamed_param_1, float unnamed_param_2) { }

}

