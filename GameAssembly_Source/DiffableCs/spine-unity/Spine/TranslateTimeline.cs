namespace Spine;

public class TranslateTimeline : CurveTimeline, IBoneTimeline
{
	public const int ENTRIES = 3; //Field offset: 0x0
	protected const int PREV_TIME = -3; //Field offset: 0x0
	protected const int PREV_X = -2; //Field offset: 0x0
	protected const int PREV_Y = -1; //Field offset: 0x0
	protected const int X = 1; //Field offset: 0x0
	protected const int Y = 2; //Field offset: 0x0
	internal int boneIndex; //Field offset: 0x18
	internal Single[] frames; //Field offset: 0x20

	public override int BoneIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public virtual int PropertyId
	{
		 get { } //Length: 9
	}

	public TranslateTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public override int get_BoneIndex() { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public void set_BoneIndex(int value) { }

	public void set_Frames(Single[] value) { }

	public void SetFrame(int frameIndex, float time, float x, float y) { }

}

