namespace UnityEngine.XR;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public struct MeshGenerationResult : IEquatable<MeshGenerationResult>
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly MeshId <MeshId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly Mesh <Mesh>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly MeshCollider <MeshCollider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly MeshGenerationStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private readonly MeshVertexAttributes <Attributes>k__BackingField; //Field offset: 0x24

	public MeshVertexAttributes Attributes
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public Mesh Mesh
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MeshCollider MeshCollider
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MeshId MeshId
	{
		[CompilerGenerated]
		 get { } //Length: 10
	}

	public MeshGenerationStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(MeshGenerationResult other) { }

	[CompilerGenerated]
	public MeshVertexAttributes get_Attributes() { }

	[CompilerGenerated]
	public Mesh get_Mesh() { }

	[CompilerGenerated]
	public MeshCollider get_MeshCollider() { }

	[CompilerGenerated]
	public MeshId get_MeshId() { }

	[CompilerGenerated]
	public MeshGenerationStatus get_Status() { }

	public virtual int GetHashCode() { }

}

