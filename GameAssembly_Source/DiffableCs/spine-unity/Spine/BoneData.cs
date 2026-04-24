namespace Spine;

public class BoneData
{
	internal int index; //Field offset: 0x10
	internal string name; //Field offset: 0x18
	internal BoneData parent; //Field offset: 0x20
	internal float length; //Field offset: 0x28
	internal float x; //Field offset: 0x2C
	internal float y; //Field offset: 0x30
	internal float rotation; //Field offset: 0x34
	internal float scaleX; //Field offset: 0x38
	internal float scaleY; //Field offset: 0x3C
	internal float shearX; //Field offset: 0x40
	internal float shearY; //Field offset: 0x44
	internal TransformMode transformMode; //Field offset: 0x48
	internal bool skinRequired; //Field offset: 0x4C

	public int Index
	{
		 get { } //Length: 4
	}

	public float Length
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public BoneData Parent
	{
		 get { } //Length: 5
	}

	public float Rotation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ScaleX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ScaleY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ShearX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ShearY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool SkinRequired
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public TransformMode TransformMode
	{
		 get { } //Length: 4
		 set { } //Length: 4
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

	public BoneData(int index, string name, BoneData parent) { }

	public int get_Index() { }

	public float get_Length() { }

	public string get_Name() { }

	public BoneData get_Parent() { }

	public float get_Rotation() { }

	public float get_ScaleX() { }

	public float get_ScaleY() { }

	public float get_ShearX() { }

	public float get_ShearY() { }

	public bool get_SkinRequired() { }

	public TransformMode get_TransformMode() { }

	public float get_X() { }

	public float get_Y() { }

	public void set_Length(float value) { }

	public void set_Rotation(float value) { }

	public void set_ScaleX(float value) { }

	public void set_ScaleY(float value) { }

	public void set_ShearX(float value) { }

	public void set_ShearY(float value) { }

	public void set_SkinRequired(bool value) { }

	public void set_TransformMode(TransformMode value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public virtual string ToString() { }

}

