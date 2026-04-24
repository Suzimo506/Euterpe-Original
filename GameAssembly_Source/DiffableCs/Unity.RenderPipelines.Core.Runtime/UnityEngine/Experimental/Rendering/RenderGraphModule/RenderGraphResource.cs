namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RenderGraphResource
{
	[CompilerGenerated]
	private int <handle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; //Field offset: 0x4

	internal int handle
	{
		[CompilerGenerated]
		internal get { } //Length: 3
		[CompilerGenerated]
		private set { } //Length: 3
	}

	internal RenderGraphResourceType type
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal RenderGraphResource(RenderGraphMutableResource mutableResource) { }

	internal RenderGraphResource(int handle, RenderGraphResourceType type) { }

	[CompilerGenerated]
	internal int get_handle() { }

	[CompilerGenerated]
	internal RenderGraphResourceType get_type() { }

	public bool IsValid() { }

	[CompilerGenerated]
	private void set_handle(int value) { }

	[CompilerGenerated]
	private void set_type(RenderGraphResourceType value) { }

}

