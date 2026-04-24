namespace UnityEngine.Experimental.Rendering;

public struct RendererListDesc
{
	public SortingCriteria sortingCriteria; //Field offset: 0x0
	public PerObjectData rendererConfiguration; //Field offset: 0x4
	public RenderQueueRange renderQueueRange; //Field offset: 0x8
	public Nullable<RenderStateBlock> stateBlock; //Field offset: 0x10
	public Material overrideMaterial; //Field offset: 0x80
	public bool excludeObjectMotionVectors; //Field offset: 0x88
	public int layerMask; //Field offset: 0x8C
	public int overrideMaterialPassIndex; //Field offset: 0x90
	[CompilerGenerated]
	private CullingResults <cullingResult>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private Camera <camera>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private ShaderTagId <passName>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private ShaderTagId[] <passNames>k__BackingField; //Field offset: 0xB8

	internal Camera camera
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		internal set { } //Length: 15
	}

	internal CullingResults cullingResult
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 11
	}

	internal ShaderTagId passName
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	internal ShaderTagId[] passNames
	{
		[CompilerGenerated]
		internal get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public RendererListDesc(ShaderTagId passName, CullingResults cullingResult, Camera camera) { }

	public RendererListDesc(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera) { }

	[CompilerGenerated]
	internal Camera get_camera() { }

	[CompilerGenerated]
	internal CullingResults get_cullingResult() { }

	[CompilerGenerated]
	internal ShaderTagId get_passName() { }

	[CompilerGenerated]
	internal ShaderTagId[] get_passNames() { }

	public bool IsValid() { }

	[CompilerGenerated]
	internal void set_camera(Camera value) { }

	[CompilerGenerated]
	private void set_cullingResult(CullingResults value) { }

	[CompilerGenerated]
	private void set_passName(ShaderTagId value) { }

	[CompilerGenerated]
	private void set_passNames(ShaderTagId[] value) { }

}

