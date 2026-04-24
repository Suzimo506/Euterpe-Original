namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class MeshFilter : Component
{

	public Mesh mesh
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 set { } //Length: 66
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MeshFilter() { }

	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Mesh get_mesh() { }

	public Mesh get_sharedMesh() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public void set_mesh(Mesh value) { }

	public void set_sharedMesh(Mesh value) { }

}

