namespace UnityEngine.Rendering;

public struct RenderTargetIdentifier : IEquatable<RenderTargetIdentifier>
{
	private BuiltinRenderTextureType m_Type; //Field offset: 0x0
	private int m_NameID; //Field offset: 0x4
	private int m_InstanceID; //Field offset: 0x8
	private IntPtr m_BufferPointer; //Field offset: 0x10
	private int m_MipLevel; //Field offset: 0x18
	private CubemapFace m_CubeFace; //Field offset: 0x1C
	private int m_DepthSlice; //Field offset: 0x20

	public RenderTargetIdentifier(BuiltinRenderTextureType type) { }

	public RenderTargetIdentifier(int nameID) { }

	public RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = -1, int depthSlice = 0) { }

	public RenderTargetIdentifier(Texture tex) { }

	public override bool Equals(RenderTargetIdentifier rhs) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs) { }

	public static RenderTargetIdentifier op_Implicit(BuiltinRenderTextureType type) { }

	public static RenderTargetIdentifier op_Implicit(int nameID) { }

	public static RenderTargetIdentifier op_Implicit(Texture tex) { }

	public virtual string ToString() { }

}

