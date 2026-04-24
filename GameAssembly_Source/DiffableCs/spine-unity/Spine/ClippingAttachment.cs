namespace Spine;

public class ClippingAttachment : VertexAttachment
{
	internal SlotData endSlot; //Field offset: 0x40

	public SlotData EndSlot
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public ClippingAttachment(string name) { }

	public virtual Attachment Copy() { }

	public SlotData get_EndSlot() { }

	public void set_EndSlot(SlotData value) { }

}

