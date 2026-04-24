namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private VertexAttribute <attribute>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private VertexAttributeFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <dimension>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <stream>k__BackingField; //Field offset: 0xC

	public VertexAttribute attribute
	{
		[CompilerGenerated]
		 get { } //Length: 3
	}

	public int dimension
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public VertexAttributeFormat format
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public int stream
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual bool Equals(object other) { }

	public override bool Equals(VertexAttributeDescriptor other) { }

	[CompilerGenerated]
	public VertexAttribute get_attribute() { }

	[CompilerGenerated]
	public int get_dimension() { }

	[CompilerGenerated]
	public VertexAttributeFormat get_format() { }

	[CompilerGenerated]
	public int get_stream() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

