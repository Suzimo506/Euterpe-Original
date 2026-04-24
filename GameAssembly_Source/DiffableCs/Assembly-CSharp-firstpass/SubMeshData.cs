//Type is in global namespace

public class SubMeshData
{
	public List<Int32> tris; //Field offset: 0x10
	public Material refMat; //Field offset: 0x18
	public Font refFont; //Field offset: 0x20
	public Texture refTex; //Field offset: 0x28
	public Texture refMask; //Field offset: 0x30
	public Vector2 maskTiling; //Field offset: 0x38
	public FilterMode refFilter; //Field offset: 0x40

	public Material AsMaterial
	{
		 get { } //Length: 305
	}

	public SubMeshData(SuperTextMesh stm) { }

	public SubMeshData(SuperTextMesh stm, STMTextInfo info) { }

	public Material get_AsMaterial() { }

}

