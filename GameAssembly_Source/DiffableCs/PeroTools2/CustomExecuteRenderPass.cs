//Type is in global namespace

public class CustomExecuteRenderPass : ScriptableRenderPass
{
	private ShaderTagId m_ShaderTagId; //Field offset: 0x68
	private string m_ProfilerTag; //Field offset: 0x70
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x78
	private FilteringSettings m_FilteringSettings; //Field offset: 0x80
	private RenderStateBlock m_RenderStateBlock; //Field offset: 0x98

	public CustomExecuteRenderPass() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public void Setup(string shaderTag, RenderPassEvent rpEvent) { }

}

