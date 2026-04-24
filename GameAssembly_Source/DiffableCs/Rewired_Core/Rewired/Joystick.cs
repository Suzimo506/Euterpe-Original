namespace Rewired;

public class Joystick : ControllerWithAxes
{
	private const int PahvFdAIxQZCpfyRktSmFuTEVnAh = 0; //Field offset: 0x0
	private const int kEGfXYTJNTFOlMocXKYvLiHsKmZL = 1; //Field offset: 0x0
	private IInputManagerJoystickPublic HIbhBIeczYRperRcPMfdesPxbAdWA; //Field offset: 0x158
	private readonly JoystickType[] IhLtKylKOWypOrxPnXuNUEwOhXiI; //Field offset: 0x160
	private readonly ReadOnlyCollection<JoystickType> fQMeLiKBLGSoqChkClqFbPcaDQbG; //Field offset: 0x168
	private readonly bool VQnljTjdFWfLnCyAAWvTulfMmNRBb; //Field offset: 0x170
	private readonly bool lPyQlKRfUzEHkgFxWHRweJECGtKS; //Field offset: 0x171
	private readonly bool uUHiNgIIeSNfiCgEknPWpyyqDsBA; //Field offset: 0x172
	private readonly int WwsMJABllyjWEIannjiuPqsgEQvAA; //Field offset: 0x174
	private readonly Single[] dAQNwhuGStpQHAhFXXlwmBnyanCL; //Field offset: 0x178
	private readonly TimerAbs[] fjDILGFkswfvwssfdpVTAiXCVAnW; //Field offset: 0x180
	private readonly int cyfFVebqzmzeTUpnEODWZlOmRYhw; //Field offset: 0x188
	private readonly Hat[] mzEeEPApcuOZRApKCaiXJHTQAbyDb; //Field offset: 0x190
	private readonly ReadOnlyCollection<Hat> KULZdIBjQOjpwwynKpFCLnBGhByN; //Field offset: 0x198

	internal int cznWGDNgAvGsMsPBYzQblpOpGpYN
	{
		internal get { } //Length: 75
	}

	public virtual Guid deviceInstanceGuid
	{
		 get { } //Length: 363
	}

	internal IList<JoystickType> eiWCFZhlaNFnNacMpjuFOsECobfcA
	{
		internal get { } //Length: 170
	}

	public int hatCount
	{
		 get { } //Length: 160
	}

	public IList<Hat> Hats
	{
		 get { } //Length: 170
	}

	public bool supportsVibration
	{
		 get { } //Length: 161
	}

	public Nullable<Int64> systemId
	{
		 get { } //Length: 347
	}

	public int unityId
	{
		 get { } //Length: 190
	}

	public float vibrationLeftMotor
	{
		 get { } //Length: 320
		 set { } //Length: 337
	}

	public int vibrationMotorCount
	{
		 get { } //Length: 270
	}

	public float vibrationRightMotor
	{
		 get { } //Length: 324
		 set { } //Length: 337
	}

	internal HardwareControllerMapIdentifier WfGIznPvgNjUqIwlBbDzYFzmkufo
	{
		internal get { } //Length: 82
	}

	private Joystick(int unnamed_param_0, InputSource unnamed_param_1, string unnamed_param_2, string unnamed_param_3, string unnamed_param_4, Guid unnamed_param_5, int unnamed_param_6, int unnamed_param_7, Boolean[] unnamed_param_8, HardwareControllerMap_Game unnamed_param_9, Extension unnamed_param_10, ControllerDataUpdater unnamed_param_11) { }

	internal Joystick(BridgedController unnamed_param_0) { }

	private void AtrciWIZhlxJMmweLGWlWOTwEfFab() { }

	private void AzrQwjpLfPmdiBBXzxNCyQlnUGki() { }

	internal IList<JoystickType> cinZBCSduOsHjsNWpXuXvUTcrccH() { }

	protected virtual void Disconnected() { }

	internal bool eABKrlmGnAmIJGbkJfKJQuuTLqOq(JoystickType unnamed_param_0) { }

	public virtual Guid get_deviceInstanceGuid() { }

	public int get_hatCount() { }

	public IList<Hat> get_Hats() { }

	public bool get_supportsVibration() { }

	public Nullable<Int64> get_systemId() { }

	public int get_unityId() { }

	public float get_vibrationLeftMotor() { }

	public int get_vibrationMotorCount() { }

	public float get_vibrationRightMotor() { }

	public JoystickCalibrationMapSaveData GetCalibrationMapSaveData() { }

	public float GetVibration(int motorIndex) { }

	internal virtual void GpGqGMzBGeWclQczaYnvQZtUlMsn(UpdateLoopType unnamed_param_0) { }

	internal HardwareControllerMapIdentifier LuzoLIdSQXqrCFhvSBsOgoULEJHb() { }

	private void mGnrWMHNfdgYJfiQCrWWlZiOpRBA() { }

	internal int RaHgrqIzYNRMCrlzOEzUPTyyPrIP() { }

	public void set_vibrationLeftMotor(float value) { }

	public void set_vibrationRightMotor(float value) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel) { }

	public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors) { }

	public void SetVibration(int motorIndex, float motorLevel, float duration) { }

	public void SetVibration(int motorIndex, float motorLevel) { }

	public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration) { }

	public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors) { }

	public void StopVibration() { }

	internal virtual void TIWlPgfaGufdFBhysiChIRXnJxnP() { }

	private void uBDVMAdKHVFvOAylUAdbZPuNRDuU(int unnamed_param_0, float unnamed_param_1, float unnamed_param_2, bool unnamed_param_3, bool unnamed_param_4) { }

	internal virtual void ucJLkNjTBLqscEGgFQEZqapAeRjgA(bool unnamed_param_0) { }

	internal static int WpLfvhjFjKxfqTEXzGLabzaHXqlhA(Joystick unnamed_param_0, Joystick unnamed_param_1) { }

	internal void XwajEKelqJljLJdKUBmhBBoyKyyv(UpdateControllerInfoEventArgs unnamed_param_0) { }

	internal void XwajEKelqJljLJdKUBmhBBoyKyyv(BridgedController unnamed_param_0) { }

	private void XwajEKelqJljLJdKUBmhBBoyKyyv(IInputManagerJoystickPublic unnamed_param_0) { }

}

