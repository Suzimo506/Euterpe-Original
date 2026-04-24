namespace Spine;

public abstract class VertexAttachment : Attachment
{
	private static int nextID; //Field offset: 0x0
	private static readonly object nextIdLock; //Field offset: 0x8
	internal readonly int id; //Field offset: 0x18
	internal Int32[] bones; //Field offset: 0x20
	internal Single[] vertices; //Field offset: 0x28
	internal int worldVerticesLength; //Field offset: 0x30
	internal VertexAttachment deformAttachment; //Field offset: 0x38

	public Int32[] Bones
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public VertexAttachment DeformAttachment
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int Id
	{
		 get { } //Length: 4
	}

	public Single[] Vertices
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public int WorldVerticesLength
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static VertexAttachment() { }

	public VertexAttachment(string name) { }

	public void ComputeWorldVertices(Slot slot, Single[] worldVertices) { }

	public void ComputeWorldVertices(Slot slot, int start, int count, Single[] worldVertices, int offset, int stride = 2) { }

	internal void CopyTo(VertexAttachment attachment) { }

	public Int32[] get_Bones() { }

	public VertexAttachment get_DeformAttachment() { }

	public int get_Id() { }

	public Single[] get_Vertices() { }

	public int get_WorldVerticesLength() { }

	public void set_Bones(Int32[] value) { }

	public void set_DeformAttachment(VertexAttachment value) { }

	public void set_Vertices(Single[] value) { }

	public void set_WorldVerticesLength(int value) { }

}

