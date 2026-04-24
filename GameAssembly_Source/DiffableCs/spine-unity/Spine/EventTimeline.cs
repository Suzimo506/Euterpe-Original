namespace Spine;

public class EventTimeline : Timeline
{
	internal Single[] frames; //Field offset: 0x10
	private Event[] events; //Field offset: 0x18

	public Event[] Events
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

	public EventTimeline(int frameCount) { }

	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public Event[] get_Events() { }

	public int get_FrameCount() { }

	public Single[] get_Frames() { }

	public override int get_PropertyId() { }

	public void set_Events(Event[] value) { }

	public void set_Frames(Single[] value) { }

	public void SetFrame(int frameIndex, Event e) { }

}

