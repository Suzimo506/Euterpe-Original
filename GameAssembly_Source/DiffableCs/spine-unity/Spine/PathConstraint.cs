namespace Spine;

public class PathConstraint : IUpdatable
{
	private const int NONE = -1; //Field offset: 0x0
	private const int BEFORE = -2; //Field offset: 0x0
	private const int AFTER = -3; //Field offset: 0x0
	private const float Epsilon = 1E-05; //Field offset: 0x0
	internal PathConstraintData data; //Field offset: 0x10
	internal ExposedList<Bone> bones; //Field offset: 0x18
	internal Slot target; //Field offset: 0x20
	internal float position; //Field offset: 0x28
	internal float spacing; //Field offset: 0x2C
	internal float rotateMix; //Field offset: 0x30
	internal float translateMix; //Field offset: 0x34
	internal bool active; //Field offset: 0x38
	internal ExposedList<Single> spaces; //Field offset: 0x40
	internal ExposedList<Single> positions; //Field offset: 0x48
	internal ExposedList<Single> world; //Field offset: 0x50
	internal ExposedList<Single> curves; //Field offset: 0x58
	internal ExposedList<Single> lengths; //Field offset: 0x60
	internal Single[] segments; //Field offset: 0x68

	public override bool Active
	{
		 get { } //Length: 5
	}

	public ExposedList<Bone> Bones
	{
		 get { } //Length: 5
	}

	public PathConstraintData Data
	{
		 get { } //Length: 5
	}

	public float Position
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float RotateMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public float Spacing
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public Slot Target
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float TranslateMix
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public PathConstraint(PathConstraintData data, Skeleton skeleton) { }

	public PathConstraint(PathConstraint constraint, Skeleton skeleton) { }

	private static void AddAfterPosition(float p, Single[] temp, int i, Single[] output, int o) { }

	private static void AddBeforePosition(float p, Single[] temp, int i, Single[] output, int o) { }

	private static void AddCurvePosition(float p, float x1, float y1, float cx1, float cy1, float cx2, float cy2, float x2, float y2, Single[] output, int o, bool tangents) { }

	public void Apply() { }

	private Single[] ComputeWorldPositions(PathAttachment path, int spacesCount, bool tangents, bool percentPosition, bool percentSpacing) { }

	public override bool get_Active() { }

	public ExposedList<Bone> get_Bones() { }

	public PathConstraintData get_Data() { }

	public float get_Position() { }

	public float get_RotateMix() { }

	public float get_Spacing() { }

	public Slot get_Target() { }

	public float get_TranslateMix() { }

	public void set_Position(float value) { }

	public void set_RotateMix(float value) { }

	public void set_Spacing(float value) { }

	public void set_Target(Slot value) { }

	public void set_TranslateMix(float value) { }

	public override void Update() { }

}

