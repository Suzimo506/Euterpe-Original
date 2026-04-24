//Type is in global namespace

public class CustomExecuteRenderFeature : ScriptableRendererFeature
{
	public string shaderTag; //Field offset: 0x20
	public RenderPassEvent renderPassEvent; //Field offset: 0x28
	private CustomExecuteRenderPass m_CustomExecute; //Field offset: 0x30

	public CustomExecuteRenderFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

}

