namespace Spine;

public class TransformConstraintData : ConstraintData
{
	internal ExposedList<BoneData> bones; //Field offset: 0x20
	internal BoneData target; //Field offset: 0x28
	internal float rotateMix; //Field offset: 0x30
	internal float translateMix; //Field offset: 0x34
	internal float scaleMix; //Field offset: 0x38
	internal float shearMix; //Field offset: 0x3C
	internal float offsetRotation; //Field offset: 0x40
	internal float offsetX; //Field offset: 0x44
	internal float offsetY; //Field offset: 0x48
	internal float offsetScaleX; //Field offset: 0x4C
	internal float offsetScaleY; //Field offset: 0x50
	internal float offsetShearY; //Field offset: 0x54
	internal bool relative; //Field offset: 0x58
	internal bool local; //Field offset: 0x59

	public ExposedList<BoneData> Bones
	{
		 get { } //Length: 5
	}

	public bool Local
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float OffsetRotation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float OffsetScaleX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float OffsetScaleY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float OffsetShearY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float OffsetX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float OffsetY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public bool Relative
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float RotateMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ScaleMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float ShearMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public BoneData Target
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float TranslateMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public TransformConstraintData(string name) { }

	public ExposedList<BoneData> get_Bones() { }

	public bool get_Local() { }

	public float get_OffsetRotation() { }

	public float get_OffsetScaleX() { }

	public float get_OffsetScaleY() { }

	public float get_OffsetShearY() { }

	public float get_OffsetX() { }

	public float get_OffsetY() { }

	public bool get_Relative() { }

	public float get_RotateMix() { }

	public float get_ScaleMix() { }

	public float get_ShearMix() { }

	public BoneData get_Target() { }

	public float get_TranslateMix() { }

	public void set_Local(bool value) { }

	public void set_OffsetRotation(float value) { }

	public void set_OffsetScaleX(float value) { }

	public void set_OffsetScaleY(float value) { }

	public void set_OffsetShearY(float value) { }

	public void set_OffsetX(float value) { }

	public void set_OffsetY(float value) { }

	public void set_Relative(bool value) { }

	public void set_RotateMix(float value) { }

	public void set_ScaleMix(float value) { }

	public void set_ShearMix(float value) { }

	public void set_Target(BoneData value) { }

	public void set_TranslateMix(float value) { }

}

