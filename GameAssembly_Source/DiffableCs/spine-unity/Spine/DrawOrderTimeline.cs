namespace Spine;

public class DrawOrderTimeline : Timeline
{
	internal Single[] frames; //Field offset: 0x10
	private Int32[][] drawOrders; //Field offset: 0x18

	public Int32[][] DrawOrders
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int FrameCount
	{
		 get { } //Length: 26
	}

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public override int PropertyId
	{
		 get { } //Length: 6
	}

	public DrawOrderTimeline(int frameCount) { }

	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Int32[][] get_DrawOrders() { }

	public int get_FrameCount() { }

	public Single[] get_Frames() { }

	public override int get_PropertyId() { }

	public void set_DrawOrders(Int32[][] value) { }

	public void set_Frames(Single[] value) { }

	public void SetFrame(int frameIndex, float time, Int32[] drawOrder) { }

}

