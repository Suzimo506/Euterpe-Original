namespace Spine;

public class RotateTimeline : CurveTimeline, IBoneTimeline
{
	public const int ENTRIES = 2; //Field offset: 0x0
	internal const int PREV_TIME = -2; //Field offset: 0x0
	internal const int PREV_ROTATION = -1; //Field offset: 0x0
	internal const int ROTATION = 1; //Field offset: 0x0
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
		 get { } //Length: 4
	}

	public RotateTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public override int get_BoneIndex() { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public void set_BoneIndex(int value) { }

	public void set_Frames(Single[] value) { }

	public void SetFrame(int frameIndex, float time, float degrees) { }

}

