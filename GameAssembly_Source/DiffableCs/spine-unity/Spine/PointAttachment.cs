namespace Spine;

public class PointAttachment : Attachment
{
	internal float x; //Field offset: 0x18
	internal float y; //Field offset: 0x1C
	internal float rotation; //Field offset: 0x20

	public float Rotation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float X
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Y
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public PointAttachment(string name) { }

	public void ComputeWorldPosition(Bone bone, out float ox, out float oy) { }

	public float ComputeWorldRotation(Bone bone) { }

	public virtual Attachment Copy() { }

	public float get_Rotation() { }

	public float get_X() { }

	public float get_Y() { }

	public void set_Rotation(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

}

