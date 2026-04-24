//Type is in global namespace

public class AdditionPostProcessRenderFeature : ScriptableRendererFeature
{
	public AdditionPostProcessSettings setting; //Field offset: 0x20
	private Shader shader; //Field offset: 0x28
	private AdditionPostProcessRenderPass m_Pass; //Field offset: 0x30
	private Material m_Material; //Field offset: 0x38

	public AdditionPostProcessRenderFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public virtual void Create() { }

}

