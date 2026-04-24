namespace UnityEngine.InputSystem.XR;

[InputControlLayout]
[Preserve]
public class PoseControl : InputControl<PoseState>
{
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private Vector3Control <velocity>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Vector3Control <angularVelocity>k__BackingField; //Field offset: 0x118

	public private Vector3Control angularVelocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private ButtonControl isTracked
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Vector3Control position
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private QuaternionControl rotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private IntegerControl trackingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public private Vector3Control velocity
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public PoseControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_angularVelocity() { }

	[CompilerGenerated]
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	public Vector3Control get_position() { }

	[CompilerGenerated]
	public QuaternionControl get_rotation() { }

	[CompilerGenerated]
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	public Vector3Control get_velocity() { }

	public virtual PoseState ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	private void set_angularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	private void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	private void set_position(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	private void set_velocity(Vector3Control value) { }

	public virtual void WriteValueIntoState(PoseState value, Void* statePtr) { }

}

