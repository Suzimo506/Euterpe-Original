namespace Spine;

public class ColorTimeline : CurveTimeline, ISlotTimeline
{
	public const int ENTRIES = 5; //Field offset: 0x0
	protected const int PREV_TIME = -5; //Field offset: 0x0
	protected const int PREV_R = -4; //Field offset: 0x0
	protected const int PREV_G = -3; //Field offset: 0x0
	protected const int PREV_B = -2; //Field offset: 0x0
	protected const int PREV_A = -1; //Field offset: 0x0
	protected const int R = 1; //Field offset: 0x0
	protected const int G = 2; //Field offset: 0x0
	protected const int B = 3; //Field offset: 0x0
	protected const int A = 4; //Field offset: 0x0
	internal int slotIndex; //Field offset: 0x18
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

	public override int SlotIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public ColorTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public override int get_SlotIndex() { }

	public void set_Frames(Single[] value) { }

	public void set_SlotIndex(int value) { }

	public void SetFrame(int frameIndex, float time, float r, float g, float b, float a) { }

}

