namespace Spine;

public class TransformConstraint : IUpdatable
{
	internal TransformConstraintData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal Bone target; //Field offset: 0x20
	internal float rotateMix; //Field offset: 0x28
	internal float translateMix; //Field offset: 0x2C
	internal float scaleMix; //Field offset: 0x30
	internal float shearMix; //Field offset: 0x34
	internal bool active; //Field offset: 0x38

	public override bool Active
	{
		 get { } //Length: 5
	}

	public ExposedList<Bone> Bones
	{
		 get { } //Length: 5
	}

	public TransformConstraintData Data
	{
		 get { } //Length: 5
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

	public Bone Target
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float TranslateMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public TransformConstraint(TransformConstraintData data, Skeleton skeleton) { }

	public TransformConstraint(TransformConstraint constraint, Skeleton skeleton) { }

	public void Apply() { }

	private void ApplyAbsoluteLocal() { }

	private void ApplyAbsoluteWorld() { }

	private void ApplyRelativeLocal() { }

	private void ApplyRelativeWorld() { }

	public override bool get_Active() { }

	public ExposedList<Bone> get_Bones() { }

	public TransformConstraintData get_Data() { }

	public float get_RotateMix() { }

	public float get_ScaleMix() { }

	public float get_ShearMix() { }

	public Bone get_Target() { }

	public float get_TranslateMix() { }

	public void set_RotateMix(float value) { }

	public void set_ScaleMix(float value) { }

	public void set_ShearMix(float value) { }

	public void set_Target(Bone value) { }

	public void set_TranslateMix(float value) { }

	public virtual string ToString() { }

	public override void Update() { }

}

