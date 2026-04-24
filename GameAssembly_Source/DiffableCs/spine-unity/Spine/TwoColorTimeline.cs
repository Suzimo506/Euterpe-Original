namespace Spine;

public class TwoColorTimeline : CurveTimeline, ISlotTimeline
{
	public const int ENTRIES = 8; //Field offset: 0x0
	protected const int B2 = 7; //Field offset: 0x0
	protected const int G2 = 6; //Field offset: 0x0
	protected const int R2 = 5; //Field offset: 0x0
	protected const int A = 4; //Field offset: 0x0
	protected const int B = 3; //Field offset: 0x0
	protected const int G = 2; //Field offset: 0x0
	protected const int R = 1; //Field offset: 0x0
	protected const int PREV_B2 = -1; //Field offset: 0x0
	protected const int PREV_G2 = -2; //Field offset: 0x0
	protected const int PREV_R2 = -3; //Field offset: 0x0
	protected const int PREV_A = -4; //Field offset: 0x0
	protected const int PREV_B = -5; //Field offset: 0x0
	protected const int PREV_G = -6; //Field offset: 0x0
	protected const int PREV_R = -7; //Field offset: 0x0
	protected const int PREV_TIME = -8; //Field offset: 0x0
	internal int slotIndex; //Field offset: 0x18
	internal Single[] frames; //Field offset: 0x20

	public Single[] Frames
	{
		 get { } //Length: 5
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

	public TwoColorTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public override int get_SlotIndex() { }

	public void set_SlotIndex(int value) { }

	public void SetFrame(int frameIndex, float time, float r, float g, float b, float a, float r2, float g2, float b2) { }

}

