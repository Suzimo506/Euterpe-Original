namespace Rewired.ControllerExtensions;

public sealed class DualSenseExtension : Extension, IControllerVibrator, IDualShock4Extension
{
	private class adDHoNueCJlTNyHucikXAjbNSOOr : IControllerExtensionSource
	{
		public readonly IDriver_DualSense BBvPnuLWoVezqQINlvehaRRJWXJO; //Field offset: 0x10
		public readonly bool ITUEJZQJRyurwfHKRVXnGxDVjMXL; //Field offset: 0x18
		public readonly int JcUCuhniTdAktXFrndNdqFzifrmfA; //Field offset: 0x1C

		public adDHoNueCJlTNyHucikXAjbNSOOr(IDriver_DualSense unnamed_param_0, bool unnamed_param_1, int unnamed_param_2) { }

	}

	private adDHoNueCJlTNyHucikXAjbNSOOr vpevKeWdykXSHmPHPhxFSttJDJbC; //Field offset: 0x28
	private bool VKwRepjcXbZlaUJhobOIhRFxnQuDb; //Field offset: 0x30
	private TimerAbs[] ZwZmaVraNvSfccEnkyjfiuwHtOLI; //Field offset: 0x38

	public bool batteryCharging
	{
		 get { } //Length: 196
	}

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

	public DualSenseMicrophoneLightMode microphoneLightMode
	{
		 get { } //Length: 210
		 set { } //Length: 230
	}

	public DualSenseOtherLightBrightness otherLightBrightness
	{
		 get { } //Length: 210
		 set { } //Length: 230
	}

	public DualSensePlayerLightFlags playerLights
	{
		 get { } //Length: 210
		 set { } //Length: 230
	}

	public override int touchCount
	{
		 get { } //Length: 190
	}

	public override int vibrationMotorCount
	{
		 get { } //Length: 174
	}

	internal DualSenseExtension(IDriver_DualSense unnamed_param_0) { }

	private DualSenseExtension(DualSenseExtension unnamed_param_0) { }

	private void AtrciWIZhlxJMmweLGWlWOTwEfFab() { }

	public bool get_batteryCharging() { }

	public float get_batteryLevel() { }

	public float get_lightColorBlue() { }

	public float get_lightColorGreen() { }

	public float get_lightColorRed() { }

	public override int get_maxTouches() { }

	public DualSenseMicrophoneLightMode get_microphoneLightMode() { }

	public DualSenseOtherLightBrightness get_otherLightBrightness() { }

	public DualSensePlayerLightFlags get_playerLights() { }

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

	public float GetVibration(DualShock4MotorType motor) { }

	public override float GetVibration(int motorIndex) { }

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

	public void set_microphoneLightMode(DualSenseMicrophoneLightMode value) { }

	public void set_otherLightBrightness(DualSenseOtherLightBrightness value) { }

	public void set_playerLights(DualSensePlayerLightFlags value) { }

	public override void SetLightColor(float red, float green, float blue) { }

	public override void SetLightColor(Color color) { }

	public override void SetLightColor(float red, float green, float blue, float intensity) { }

	public override void SetVibration(int motorIndex, float motorLevel) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration) { }

	public override void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors) { }

	public override void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	public override void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	public override void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	public override void StopVibration() { }

	internal virtual Extension ytRHXgQAbztNqpUyjHyDXXbonFrI() { }

	private void zNFASxOTSiNTihfYWjPodjsBsrQV(DualShock4MotorType unnamed_param_0, float unnamed_param_1, float unnamed_param_2) { }

}

