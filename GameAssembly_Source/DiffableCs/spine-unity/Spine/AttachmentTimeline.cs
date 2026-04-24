namespace Spine;

public class AttachmentTimeline : Timeline, ISlotTimeline
{
	internal int slotIndex; //Field offset: 0x10
	internal Single[] frames; //Field offset: 0x18
	internal String[] attachmentNames; //Field offset: 0x20

	public String[] AttachmentNames
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
		 get { } //Length: 9
	}

	public override int SlotIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public AttachmentTimeline(int frameCount) { }

	public override void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public String[] get_AttachmentNames() { }

	public int get_FrameCount() { }

	public Single[] get_Frames() { }

	public override int get_PropertyId() { }

	public override int get_SlotIndex() { }

	public void set_AttachmentNames(String[] value) { }

	public void set_Frames(Single[] value) { }

	public void set_SlotIndex(int value) { }

	private void SetAttachment(Skeleton skeleton, Slot slot, string attachmentName) { }

	public void SetFrame(int frameIndex, float time, string attachmentName) { }

}

