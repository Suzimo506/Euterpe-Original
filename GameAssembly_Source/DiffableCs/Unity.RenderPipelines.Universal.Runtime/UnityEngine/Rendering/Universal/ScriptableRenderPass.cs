namespace UnityEngine.Rendering.Universal;

[MovedFrom(/*Cpp2IL Warning: missing at least one required parameter*/)]
public abstract class ScriptableRenderPass
{
	[CompilerGenerated]
	private RenderPassEvent <renderPassEvent>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <eyeIndex>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <overrideCameraTarget>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isBlitRenderPass>k__BackingField; //Field offset: 0x19
	private RenderTargetIdentifier[] m_ColorAttachments; //Field offset: 0x20
	private RenderTargetIdentifier m_DepthAttachment; //Field offset: 0x28
	private ClearFlag m_ClearFlag; //Field offset: 0x50
	private Color m_ClearColor; //Field offset: 0x54

	public Color clearColor
	{
		 get { } //Length: 11
	}

	public ClearFlag clearFlag
	{
		 get { } //Length: 4
	}

	internal int eyeIndex
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool isBlitRenderPass
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal bool overrideCameraTarget
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public RenderPassEvent renderPassEvent
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ScriptableRenderPass() { }

	public void Blit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material = null, int passIndex = 0) { }

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	public Color get_clearColor() { }

	public ClearFlag get_clearFlag() { }

	[CompilerGenerated]
	public RenderPassEvent get_renderPassEvent() { }

	[CompilerGenerated]
	internal void set_eyeIndex(int value) { }

	[CompilerGenerated]
	internal void set_isBlitRenderPass(bool value) { }

	[CompilerGenerated]
	internal void set_overrideCameraTarget(bool value) { }

	[CompilerGenerated]
	public void set_renderPassEvent(RenderPassEvent value) { }

}

