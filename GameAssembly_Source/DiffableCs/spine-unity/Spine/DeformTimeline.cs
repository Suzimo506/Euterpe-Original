namespace Spine;

public class DeformTimeline : CurveTimeline, ISlotTimeline
{
	internal int slotIndex; //Field offset: 0x18
	internal VertexAttachment attachment; //Field offset: 0x20
	internal Single[] frames; //Field offset: 0x28
	internal Single[][] frameVertices; //Field offset: 0x30

	public VertexAttachment Attachment
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Single[] Frames
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public virtual int PropertyId
	{
		 get { } //Length: 36
	}

	public override int SlotIndex
	{
		 get { } //Length: 4
		 set { } //Length: 108
	}

	public Single[][] Vertices
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public DeformTimeline(int frameCount) { }

	public virtual void Apply(Skeleton skeleton, float lastTime, float time, ExposedList<Event> firedEvents, float alpha, MixBlend blend, MixDirection direction) { }

	public VertexAttachment get_Attachment() { }

	public Single[] get_Frames() { }

	public virtual int get_PropertyId() { }

	public override int get_SlotIndex() { }

	public Single[][] get_Vertices() { }

	public void set_Attachment(VertexAttachment value) { }

	public void set_Frames(Single[] value) { }

	public void set_SlotIndex(int value) { }

	public void set_Vertices(Single[][] value) { }

	public void SetFrame(int frameIndex, float time, Single[] vertices) { }

}

