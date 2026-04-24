namespace UnityEngine.InputSystem;

[InputControlLayout]
public class TrackedDevice : InputDevice
{
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; //Field offset: 0x170

	[InputControl]
	public private Vector3Control devicePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl deviceRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public TrackedDevice() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_devicePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_deviceRotation() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	private void set_devicePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_deviceRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

}

