//Type is in global namespace

public class BloomRenderFeature : ScriptableRendererFeature
{
	public BloomSettings setting; //Field offset: 0x20
	private BloomRenderPass m_Pass; //Field offset: 0x28

	public BloomRenderFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

}

