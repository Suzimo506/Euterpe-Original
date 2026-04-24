//Type is in global namespace

public class FogRenderPass : ScriptableRenderPass
{
	private const string m_ProfilerTag = "Render Fog"; //Field offset: 0x0
	private Material m_Material; //Field offset: 0x68
	private ProfilingSampler m_ProfilingSampler; //Field offset: 0x70
	private RenderTargetIdentifier m_Source; //Field offset: 0x78
	private int m_CameraDirId; //Field offset: 0xA0
	private Vector4[] m_CameraDirs; //Field offset: 0xA8
	private int m_FogParamId; //Field offset: 0xB0
	private Vector4 m_FogParam; //Field offset: 0xB4
	private int m_HorziontalParamId; //Field offset: 0xC4
	private Vector2 m_HorizontalParam; //Field offset: 0xC8
	private int _FogGradientId; //Field offset: 0xD0
	private Vector4[] m_FogGradient; //Field offset: 0xD8
	private readonly Shader m_Shader; //Field offset: 0xE0

	public FogRenderPass() { }

	private void DoFog(CommandBuffer cmd, RenderingData renderingData) { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, FogSetting setting, ref RenderingData renderingData) { }

}

