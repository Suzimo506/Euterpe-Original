namespace Spine;

public class Slot
{
	internal SlotData data; //Field offset: 0x10
	internal Bone bone; //Field offset: 0x18
	internal float r; //Field offset: 0x20
	internal float g; //Field offset: 0x24
	internal float b; //Field offset: 0x28
	internal float a; //Field offset: 0x2C
	internal float r2; //Field offset: 0x30
	internal float g2; //Field offset: 0x34
	internal float b2; //Field offset: 0x38
	internal bool hasSecondColor; //Field offset: 0x3C
	internal Attachment attachment; //Field offset: 0x40
	internal float attachmentTime; //Field offset: 0x48
	internal ExposedList<Single> deform; //Field offset: 0x50
	internal int attachmentState; //Field offset: 0x58

	public float A
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Attachment Attachment
	{
		 get { } //Length: 5
		 set { } //Length: 127
	}

	public float AttachmentTime
	{
		 get { } //Length: 42
		 set { } //Length: 46
	}

	public float B
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float B2
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Bone Bone
	{
		 get { } //Length: 5
	}

	public SlotData Data
	{
		 get { } //Length: 5
	}

	public ExposedList<Single> Deform
	{
		 get { } //Length: 5
		 set { } //Length: 130
	}

	public float G
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float G2
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool HasSecondColor
	{
		 get { } //Length: 27
		 set { } //Length: 26
	}

	public float R
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float R2
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Skeleton Skeleton
	{
		 get { } //Length: 27
	}

	public Slot(SlotData data, Bone bone) { }

	public Slot(Slot slot, Bone bone) { }

	public void ClampColor() { }

	public void ClampSecondColor() { }

	public float get_A() { }

	public Attachment get_Attachment() { }

	public float get_AttachmentTime() { }

	public float get_B() { }

	public float get_B2() { }

	public Bone get_Bone() { }

	public SlotData get_Data() { }

	public ExposedList<Single> get_Deform() { }

	public float get_G() { }

	public float get_G2() { }

	public bool get_HasSecondColor() { }

	public float get_R() { }

	public float get_R2() { }

	public Skeleton get_Skeleton() { }

	public void set_A(float value) { }

	public void set_Attachment(Attachment value) { }

	public void set_AttachmentTime(float value) { }

	public void set_B(float value) { }

	public void set_B2(float value) { }

	public void set_Deform(ExposedList<Single> value) { }

	public void set_G(float value) { }

	public void set_G2(float value) { }

	public void set_HasSecondColor(bool value) { }

	public void set_R(float value) { }

	public void set_R2(float value) { }

	public void SetToSetupPose() { }

	public virtual string ToString() { }

}

