namespace ZenFulcrum.VR.OpenVRBinding;

public struct RenderModel_t_Packed
{
	public IntPtr rVertexData; //Field offset: 0x0
	public uint unVertexCount; //Field offset: 0x8
	public IntPtr rIndexData; //Field offset: 0xC
	public uint unTriangleCount; //Field offset: 0x14
	public int diffuseTextureId; //Field offset: 0x18

	public RenderModel_t_Packed(RenderModel_t unpacked) { }

	public void Unpack(ref RenderModel_t unpacked) { }

}

