namespace Spine;

public class TransformConstraintTimeline : CurveTimeline
{
	public const int ENTRIES = 5; //Field offset: 0x0
	private const int PREV_TIME = -5; //Field offset: 0x0
	private const int PREV_ROTATE = -4; //Field offset: 0x0
	private const int PREV_TRANSLATE = -3; //Field offset: 0x0
	private const int PREV_SCALE = -2; //Field offset: 0x0
	private const int PREV_SHEAR = -1; //Field offset: 0x0
	private const int ROTATE = 1; //Field offset: 0x0
	private const int TRANSLATE = 2; //Field offset: 0x0
	private const int SCALE = 3; //Field offset: 0x0
	private const int SHEAR = 4; //Field offset: 0x0
	internal int transformConstraintIndex; //Field offset: 0x18
	internal Single[] frames; //Field offset: 0x20

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public int TransformConstraintIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public TransformConstraintTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public int get_TransformConstraintIndex() { }

	public void set_Frames(Single[] value) { }

	public void set_TransformConstraintIndex(int value) { }

	public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix, float scaleMix, float shearMix) { }

}

