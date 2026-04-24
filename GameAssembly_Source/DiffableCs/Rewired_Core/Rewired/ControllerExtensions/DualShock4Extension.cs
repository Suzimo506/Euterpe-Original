namespace Rewired.ControllerExtensions;

public sealed class DualShock4Extension : Extension, IControllerVibrator, IDualShock4Extension
{
	private class eMlmDkUUBIAgrYCwXGHdAeuGGMfXA : IControllerExtensionSource
	{
		public readonly IDriver_DualShock4 BBvPnuLWoVezqQINlvehaRRJWXJO; //Field offset: 0x10
		public readonly bool ITUEJZQJRyurwfHKRVXnGxDVjMXL; //Field offset: 0x18
		public readonly int JcUCuhniTdAktXFrndNdqFzifrmfA; //Field offset: 0x1C

		public eMlmDkUUBIAgrYCwXGHdAeuGGMfXA(IDriver_DualShock4 unnamed_param_0, bool unnamed_param_1, int unnamed_param_2) { }

	}

	private eMlmDkUUBIAgrYCwXGHdAeuGGMfXA vpevKeWdykXSHmPHPhxFSttJDJbC; //Field offset: 0x28
	private bool VKwRepjcXbZlaUJhobOIhRFxnQuDb; //Field offset: 0x30
	private TimerAbs[] ZwZmaVraNvSfccEnkyjfiuwHtOLI; //Field offset: 0x38

	public float batteryLevel
	{
		 get { } //Length: 194
	}

	private Joystick doaStyJAKnGYRbLwOlPQGhDGoklic
	{
		private get { } //Length: 56
	}

	public float lightColorBlue
	{
		 get { } //Length: 211
		 set { } //Length: 104
	}

	public float lightColorGreen
	{
		 get { } //Length: 211
		 set { } //Length: 104
	}

	public float lightColorRed
	{
		 get { } //Length: 211
		 set { } //Length: 104
	}

	public override int maxTouches
	{
		 get { } //Length: 196
	}

	public override int touchCount
	{
		 get { } //Length: 190
	}

	public override int vibrationMotorCount
	{
		 get { } //Length: 174
	}

	internal DualShock4Extension(IDriver_DualShock4 unnamed_param_0) { }

	private DualShock4Extension(DualShock4Extension unnamed_param_0) { }

	private void AtrciWIZhlxJMmweLGWlWOTwEfFab() { }

	public float get_batteryLevel() { }

	public float get_lightColorBlue() { }

	public float get_lightColorGreen() { }

	public float get_lightColorRed() { }

	public override int get_maxTouches() { }

	public override int get_touchCount() { }

	public override int get_vibrationMotorCount() { }

	public override Vector3 GetAccelerometerValue() { }

	public override Vector3 GetAccelerometerValueRaw() { }

	public Vector3 GetGyroscopeValue() { }

	public Vector3 GetGyroscopeValueRaw() { }

	public Vector3 GetLastGyroscopeValue() { }

	public Vector3 GetLastGyroscopeValueRaw() { }

	public Color GetLightColor() { }

	public override Quaternion GetOrientation() { }

	public override int GetTouchId(int index) { }

	public override bool GetTouchPosition(int index, out Vector2 position) { }

	public bool GetTouchPositionAbsolute(int index, out Vector2 position) { }

	public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position) { }

	public override bool GetTouchPositionByTouchId(int touchId, out Vector2 position) { }

	public override float GetVibration(int motorIndex) { }

	public float GetVibration(DualShock4MotorType motor) { }

	internal virtual void GpGqGMzBGeWclQczaYnvQZtUlMsn(UpdateLoopType unnamed_param_0) { }

	private Joystick IONRbDEnqkRDkSvFFLhMWbXoyTGE() { }

	public override bool IsTouching(int index) { }

	public override bool IsTouchingByTouchId(int touchId) { }

	internal virtual void LpxMOcRLGJGfNEpnCBjpiLMJwmKgb(IControllerExtensionSource unnamed_param_0) { }

	public override void ResetOrientation() { }

	private override Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValue() { }

	private override Vector3 Rewired.ControllerExtensions.IDualShock4Extension.GetGyroscopeValueRaw() { }

	public void set_lightColorBlue(float value) { }

	public void set_lightColorGreen(float value) { }

	public void set_lightColorRed(float value) { }

	public override void SetLightColor(float red, float green, float blue, float intensity) { }

	public override void SetLightColor(float red, float green, float blue) { }

	public override void SetLightColor(Color color) { }

	public void SetLightFlash(float onDuration, float offDuration) { }

	public override void SetVibration(int motorIndex, float motorLevel) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration) { }

	public override void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	public override void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	public override void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	public void StopLightFlash() { }

	public override void StopVibration() { }

	internal virtual Extension ytRHXgQAbztNqpUyjHyDXXbonFrI() { }

	private void zNFASxOTSiNTihfYWjPodjsBsrQV(DualShock4MotorType unnamed_param_0, float unnamed_param_1, float unnamed_param_2) { }

}

