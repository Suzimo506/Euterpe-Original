namespace UnityEngine.Rendering;

public struct RenderStateBlock : IEquatable<RenderStateBlock>
{
	private BlendState m_BlendState; //Field offset: 0x0
	private RasterState m_RasterState; //Field offset: 0x44
	private DepthState m_DepthState; //Field offset: 0x54
	private StencilState m_StencilState; //Field offset: 0x56
	private int m_StencilReference; //Field offset: 0x64
	private RenderStateMask m_Mask; //Field offset: 0x68

	public DepthState depthState
	{
		 set { } //Length: 5
	}

	public StencilState stencilState
	{
		 set { } //Length: 16
	}

	public RenderStateBlock(RenderStateMask mask) { }

	public override bool Equals(RenderStateBlock other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public void set_depthState(DepthState value) { }

	public void set_stencilState(StencilState value) { }

}

