namespace UnityEngine.Experimental.Rendering;

public struct RendererList
{
	private static readonly ShaderTagId s_EmptyName; //Field offset: 0x0
	public static readonly RendererList nullRendererList; //Field offset: 0x8
	[CompilerGenerated]
	private bool <isValid>k__BackingField; //Field offset: 0x0
	public CullingResults cullingResult; //Field offset: 0x8
	public DrawingSettings drawSettings; //Field offset: 0x18
	public FilteringSettings filteringSettings; //Field offset: 0x150
	public Nullable<RenderStateBlock> stateBlock; //Field offset: 0x168

	public private bool isValid
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 3
	}

	private static RendererList() { }

	public static RendererList Create(in RendererListDesc desc) { }

	[CompilerGenerated]
	public bool get_isValid() { }

	[CompilerGenerated]
	private void set_isValid(bool value) { }

}

