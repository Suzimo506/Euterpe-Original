namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[IsByRefLike]
[Obsolete]
public struct RenderGraphContext
{
	public ScriptableRenderContext renderContext; //Field offset: 0x0
	public CommandBuffer cmd; //Field offset: 0x8
	public RenderGraphObjectPool renderGraphPool; //Field offset: 0x10
	public RenderGraphResourceRegistry resources; //Field offset: 0x18

}

