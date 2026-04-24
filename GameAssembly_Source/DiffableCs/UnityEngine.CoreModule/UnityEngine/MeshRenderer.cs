namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class MeshRenderer : Renderer
{

	public Mesh additionalVertexStreams
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int subMeshStartIndex
	{
		[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 51
	}

	public MeshRenderer() { }

	[RequiredByNativeCode]
	private void DontStripMeshRenderer() { }

	public Mesh get_additionalVertexStreams() { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int get_subMeshStartIndex() { }

	public void set_additionalVertexStreams(Mesh value) { }

}

