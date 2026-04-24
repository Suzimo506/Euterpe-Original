namespace Spine;

public class SlotData
{
	internal int index; //Field offset: 0x10
	internal string name; //Field offset: 0x18
	internal BoneData boneData; //Field offset: 0x20
	internal float r; //Field offset: 0x28
	internal float g; //Field offset: 0x2C
	internal float b; //Field offset: 0x30
	internal float a; //Field offset: 0x34
	internal float r2; //Field offset: 0x38
	internal float g2; //Field offset: 0x3C
	internal float b2; //Field offset: 0x40
	internal bool hasSecondColor; //Field offset: 0x44
	internal string attachmentName; //Field offset: 0x48
	internal BlendMode blendMode; //Field offset: 0x50

	public float A
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public string AttachmentName
	{
		 get { } //Length: 5
		 set { } //Length: 12
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

	public BlendMode BlendMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public BoneData BoneData
	{
		 get { } //Length: 5
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
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public int Index
	{
		 get { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 5
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

	public SlotData(int index, string name, BoneData boneData) { }

	public float get_A() { }

	public string get_AttachmentName() { }

	public float get_B() { }

	public float get_B2() { }

	public BlendMode get_BlendMode() { }

	public BoneData get_BoneData() { }

	public float get_G() { }

	public float get_G2() { }

	public bool get_HasSecondColor() { }

	public int get_Index() { }

	public string get_Name() { }

	public float get_R() { }

	public float get_R2() { }

	public void set_A(float value) { }

	public void set_AttachmentName(string value) { }

	public void set_B(float value) { }

	public void set_B2(float value) { }

	public void set_BlendMode(BlendMode value) { }

	public void set_G(float value) { }

	public void set_G2(float value) { }

	public void set_HasSecondColor(bool value) { }

	public void set_R(float value) { }

	public void set_R2(float value) { }

	public virtual string ToString() { }

}

