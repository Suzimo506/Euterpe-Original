namespace UnityEngine.InputSystem.XR;

public class BoneControl : InputControl<Bone>
{
	[CompilerGenerated]
	private IntegerControl <parentBoneIndex>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; //Field offset: 0x100

	[InputControl]
	public private IntegerControl parentBoneIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control position
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl rotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public BoneControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public IntegerControl get_parentBoneIndex() { }

	[CompilerGenerated]
	public Vector3Control get_position() { }

	[CompilerGenerated]
	public QuaternionControl get_rotation() { }

	public virtual Bone ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	private void set_parentBoneIndex(IntegerControl value) { }

	[CompilerGenerated]
	private void set_position(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rotation(QuaternionControl value) { }

	public virtual void WriteValueIntoState(Bone value, Void* statePtr) { }

}

