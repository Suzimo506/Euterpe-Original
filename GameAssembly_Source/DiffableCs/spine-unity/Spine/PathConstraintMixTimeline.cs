namespace Spine;

public class PathConstraintMixTimeline : CurveTimeline
{
	public const int ENTRIES = 3; //Field offset: 0x0
	private const int PREV_TIME = -3; //Field offset: 0x0
	private const int PREV_ROTATE = -2; //Field offset: 0x0
	private const int PREV_TRANSLATE = -1; //Field offset: 0x0
	private const int ROTATE = 1; //Field offset: 0x0
	private const int TRANSLATE = 2; //Field offset: 0x0
	internal int pathConstraintIndex; //Field offset: 0x18
	internal Single[] frames; //Field offset: 0x20

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int PathConstraintIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public PathConstraintMixTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Single[] get_Frames() { }

	public int get_PathConstraintIndex() { }

	public virtual int get_PropertyId() { }

	public void set_Frames(Single[] value) { }

	public void set_PathConstraintIndex(int value) { }

	public void SetFrame(int frameIndex, float time, float rotateMix, float translateMix) { }

}

