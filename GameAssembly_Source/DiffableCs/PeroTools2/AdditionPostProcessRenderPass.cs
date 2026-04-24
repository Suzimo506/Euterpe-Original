//Type is in global namespace

public class AdditionPostProcessRenderPass : ScriptableRenderPass
{
	private const string CommandBufferTag = "MyPostProcessing Pass"; //Field offset: 0x0
	public Material material; //Field offset: 0x68
	private AdditionPostProcessSettings m_Settings; //Field offset: 0x70
	private RenderTargetIdentifier m_ColorAttachment; //Field offset: 0x78
	private RenderTargetHandle m_TemporaryColorTexture01; //Field offset: 0xA0
	private int m_VerticalRollIntensityID; //Field offset: 0xA4
	private int m_VerticalRollTimeID; //Field offset: 0xA8
	private int m_SinCycleID; //Field offset: 0xAC
	private int m_SinScaleID; //Field offset: 0xB0
	private int m_TimeLBID; //Field offset: 0xB4
	private int m_LineBlockPartID; //Field offset: 0xB8
	private int m_LineBlockBlankingID; //Field offset: 0xBC
	private int m_ColorOffsetID; //Field offset: 0xC0
	private int m_VignetteSizeID; //Field offset: 0xC4
	private int m_BlackDegreeID; //Field offset: 0xC8
	private int m_WhiteAlphaID; //Field offset: 0xCC

	public AdditionPostProcessRenderPass() { }

	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void Render(CommandBuffer cmd, ref RenderingData renderingData) { }

	public void Setup(RenderTargetIdentifier colorAttachment, Material mat, AdditionPostProcessSettings setting) { }

}

