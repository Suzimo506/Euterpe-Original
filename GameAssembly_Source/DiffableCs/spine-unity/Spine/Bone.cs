namespace Spine;

public class Bone : IUpdatable
{
	public static bool yDown; //Field offset: 0x0
	internal BoneData data; //Field offset: 0x10
	internal Skeleton skeleton; //Field offset: 0x18
	internal Bone parent; //Field offset: 0x20
	internal ExposedList<Bone> children; //Field offset: 0x28
	internal float x; //Field offset: 0x30
	internal float y; //Field offset: 0x34
	internal float rotation; //Field offset: 0x38
	internal float scaleX; //Field offset: 0x3C
	internal float scaleY; //Field offset: 0x40
	internal float shearX; //Field offset: 0x44
	internal float shearY; //Field offset: 0x48
	internal float ax; //Field offset: 0x4C
	internal float ay; //Field offset: 0x50
	internal float arotation; //Field offset: 0x54
	internal float ascaleX; //Field offset: 0x58
	internal float ascaleY; //Field offset: 0x5C
	internal float ashearX; //Field offset: 0x60
	internal float ashearY; //Field offset: 0x64
	internal bool appliedValid; //Field offset: 0x68
	internal float a; //Field offset: 0x6C
	internal float b; //Field offset: 0x70
	internal float worldX; //Field offset: 0x74
	internal float c; //Field offset: 0x78
	internal float d; //Field offset: 0x7C
	internal float worldY; //Field offset: 0x80
	internal bool sorted; //Field offset: 0x84
	internal bool active; //Field offset: 0x85

	public float A
	{
		 get { } //Length: 6
	}

	public override bool Active
	{
		 get { } //Length: 8
	}

	public float AppliedRotation
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AScaleX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AScaleY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AShearX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AShearY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AX
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float AY
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float B
	{
		 get { } //Length: 6
	}

	public float C
	{
		 get { } //Length: 6
	}

	public ExposedList<Bone> Children
	{
		 get { } //Length: 5
	}

	public float D
	{
		 get { } //Length: 6
	}

	public BoneData Data
	{
		 get { } //Length: 5
	}

	public Bone Parent
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

	public Skeleton Skeleton
	{
		 get { } //Length: 5
	}

	public float WorldRotationX
	{
		 get { } //Length: 124
	}

	public float WorldRotationY
	{
		 get { } //Length: 124
	}

	public float WorldScaleX
	{
		 get { } //Length: 162
	}

	public float WorldScaleY
	{
		 get { } //Length: 162
	}

	public float WorldToLocalRotationX
	{
		 get { } //Length: 259
	}

	public float WorldToLocalRotationY
	{
		 get { } //Length: 259
	}

	public float WorldX
	{
		 get { } //Length: 6
	}

	public float WorldY
	{
		 get { } //Length: 9
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

	public Bone(BoneData data, Skeleton skeleton, Bone parent) { }

	public float get_A() { }

	public override bool get_Active() { }

	public float get_AppliedRotation() { }

	public float get_AScaleX() { }

	public float get_AScaleY() { }

	public float get_AShearX() { }

	public float get_AShearY() { }

	public float get_AX() { }

	public float get_AY() { }

	public float get_B() { }

	public float get_C() { }

	public ExposedList<Bone> get_Children() { }

	public float get_D() { }

	public BoneData get_Data() { }

	public Bone get_Parent() { }

	public float get_Rotation() { }

	public float get_ScaleX() { }

	public float get_ScaleY() { }

	public float get_ShearX() { }

	public float get_ShearY() { }

	public Skeleton get_Skeleton() { }

	public float get_WorldRotationX() { }

	public float get_WorldRotationY() { }

	public float get_WorldScaleX() { }

	public float get_WorldScaleY() { }

	public float get_WorldToLocalRotationX() { }

	public float get_WorldToLocalRotationY() { }

	public float get_WorldX() { }

	public float get_WorldY() { }

	public float get_X() { }

	public float get_Y() { }

	public void LocalToWorld(float localX, float localY, out float worldX, out float worldY) { }

	public float LocalToWorldRotation(float localRotation) { }

	public void RotateWorld(float degrees) { }

	public void set_AppliedRotation(float value) { }

	public void set_AScaleX(float value) { }

	public void set_AScaleY(float value) { }

	public void set_AShearX(float value) { }

	public void set_AShearY(float value) { }

	public void set_AX(float value) { }

	public void set_AY(float value) { }

	public void set_Rotation(float value) { }

	public void set_ScaleX(float value) { }

	public void set_ScaleY(float value) { }

	public void set_ShearX(float value) { }

	public void set_ShearY(float value) { }

	public void set_X(float value) { }

	public void set_Y(float value) { }

	public void SetToSetupPose() { }

	public virtual string ToString() { }

	public override void Update() { }

	internal void UpdateAppliedTransform() { }

	public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY) { }

	public void UpdateWorldTransform() { }

	public void WorldToLocal(float worldX, float worldY, out float localX, out float localY) { }

	public float WorldToLocalRotation(float worldRotation) { }

}

