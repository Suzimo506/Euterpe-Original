namespace Spine;

public class Skin
{
	internal struct SkinEntry
	{
		private readonly int slotIndex; //Field offset: 0x0
		private readonly string name; //Field offset: 0x8
		private readonly Attachment attachment; //Field offset: 0x10
		internal readonly int hashCode; //Field offset: 0x18

		public Attachment Attachment
		{
			 get { } //Length: 5
		}

		public string Name
		{
			 get { } //Length: 5
		}

		public int SlotIndex
		{
			 get { } //Length: 3
		}

		public SkinEntry(int slotIndex, string name, Attachment attachment) { }

		public Attachment get_Attachment() { }

		public string get_Name() { }

		public int get_SlotIndex() { }

	}

	private class SkinEntryComparer : IEqualityComparer<SkinEntry>
	{
		internal static readonly SkinEntryComparer Instance; //Field offset: 0x2C927B4

		private static SkinEntryComparer() { }

		public SkinEntryComparer() { }

		private override bool System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinEntry>.Equals(SkinEntry e1, SkinEntry e2) { }

		private override int System.Collections.Generic.IEqualityComparer<Spine.Skin.SkinEntry>.GetHashCode(SkinEntry e) { }

	}

	internal string name; //Field offset: 0x10
	private OrderedDictionary<SkinEntry, Attachment> attachments; //Field offset: 0x18
	internal readonly ExposedList<BoneData> bones; //Field offset: 0x20
	internal readonly ExposedList<ConstraintData> constraints; //Field offset: 0x28

	public OrderedDictionary<SkinEntry, Attachment> Attachments
	{
		 get { } //Length: 5
	}

	public ExposedList<BoneData> Bones
	{
		 get { } //Length: 5
	}

	public ExposedList<ConstraintData> Constraints
	{
		 get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public Skin(string name) { }

	public void AddSkin(Skin skin) { }

	internal void AttachAll(Skeleton skeleton, Skin oldSkin) { }

	public void Clear() { }

	public void CopySkin(Skin skin) { }

	public OrderedDictionary<SkinEntry, Attachment> get_Attachments() { }

	public ExposedList<BoneData> get_Bones() { }

	public ExposedList<ConstraintData> get_Constraints() { }

	public string get_Name() { }

	public Attachment GetAttachment(int slotIndex, string name) { }

	public ICollection<SkinEntry> GetAttachments() { }

	public void GetAttachments(int slotIndex, List<SkinEntry> attachments) { }

	public void RemoveAttachment(int slotIndex, string name) { }

	public void SetAttachment(int slotIndex, string name, Attachment attachment) { }

	public virtual string ToString() { }

}

