namespace UnityEngine.InputSystem.XR;

public struct Bone
{
	[CompilerGenerated]
	private uint <parentBoneIndex>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3 <position>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private Quaternion <rotation>k__BackingField; //Field offset: 0x10

	public uint parentBoneIndex
	{
		[CompilerGenerated]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public Vector3 position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Quaternion rotation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	[CompilerGenerated]
	public uint get_parentBoneIndex() { }

	[CompilerGenerated]
	public Vector3 get_position() { }

	[CompilerGenerated]
	public Quaternion get_rotation() { }

	[CompilerGenerated]
	public void set_parentBoneIndex(uint value) { }

	[CompilerGenerated]
	public void set_position(Vector3 value) { }

	[CompilerGenerated]
	public void set_rotation(Quaternion value) { }

}

