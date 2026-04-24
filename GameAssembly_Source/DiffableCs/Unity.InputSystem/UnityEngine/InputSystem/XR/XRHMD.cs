namespace UnityEngine.InputSystem.XR;

[InputControlLayout]
public class XRHMD : TrackedDevice
{
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private Vector3Control <centerEyePosition>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private QuaternionControl <centerEyeRotation>k__BackingField; //Field offset: 0x1A0

	[InputControl]
	public private Vector3Control centerEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl centerEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control leftEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl leftEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control rightEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl rightEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public XRHMD() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_centerEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_centerEyeRotation() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_rightEyeRotation() { }

	[CompilerGenerated]
	private void set_centerEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_centerEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeRotation(QuaternionControl value) { }

}

