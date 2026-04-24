namespace Unity.XR.OpenVR;

[InputControlLayout]
public class OpenVRHMD : XRHMD
{
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private Vector3Control <leftEyeVelocity>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private Vector3Control <rightEyeVelocity>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private Vector3Control <centerEyeVelocity>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; //Field offset: 0x1E0

	[InputControl]
	public private Vector3Control centerEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control centerEyeVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control deviceVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control leftEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control leftEyeVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control rightEyeAngularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control rightEyeVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public OpenVRHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyeVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyeVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyeVelocity() { }

	[CompilerGenerated]
	private void set_centerEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeVelocity(Vector3Control value) { }

}

