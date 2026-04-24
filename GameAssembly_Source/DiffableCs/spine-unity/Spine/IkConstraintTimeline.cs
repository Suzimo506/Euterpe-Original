namespace Spine;

public class IkConstraintTimeline : CurveTimeline
{
	public const int ENTRIES = 6; //Field offset: 0x0
	private const int PREV_TIME = -6; //Field offset: 0x0
	private const int PREV_MIX = -5; //Field offset: 0x0
	private const int PREV_SOFTNESS = -4; //Field offset: 0x0
	private const int PREV_BEND_DIRECTION = -3; //Field offset: 0x0
	private const int PREV_COMPRESS = -2; //Field offset: 0x0
	private const int PREV_STRETCH = -1; //Field offset: 0x0
	private const int MIX = 1; //Field offset: 0x0
	private const int SOFTNESS = 2; //Field offset: 0x0
	private const int BEND_DIRECTION = 3; //Field offset: 0x0
	private const int COMPRESS = 4; //Field offset: 0x0
	private const int STRETCH = 5; //Field offset: 0x0
	internal int ikConstraintIndex; //Field offset: 0x18
	internal Single[] frames; //Field offset: 0x20

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int IkConstraintIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public IkConstraintTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Single[] get_Frames() { }

	public int get_IkConstraintIndex() { }

	public virtual int get_PropertyId() { }

	public void set_Frames(Single[] value) { }

	public void set_IkConstraintIndex(int value) { }

	public void SetFrame(int frameIndex, float time, float mix, float softness, int bendDirection, bool compress, bool stretch) { }

}

