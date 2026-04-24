namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct RenderGraphMutableResource
{
	[CompilerGenerated]
	private int <handle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private RenderGraphResourceType <type>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private int <version>k__BackingField; //Field offset: 0x8

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

	internal int version
	{
		[CompilerGenerated]
		internal get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal RenderGraphMutableResource(int handle, RenderGraphResourceType type) { }

	internal RenderGraphMutableResource(RenderGraphMutableResource other) { }

	[CompilerGenerated]
	internal int get_handle() { }

	[CompilerGenerated]
	internal RenderGraphResourceType get_type() { }

	[CompilerGenerated]
	internal int get_version() { }

	internal bool IsValid() { }

	public static RenderGraphResource op_Implicit(RenderGraphMutableResource handle) { }

	[CompilerGenerated]
	private void set_handle(int value) { }

	[CompilerGenerated]
	private void set_type(RenderGraphResourceType value) { }

	[CompilerGenerated]
	private void set_version(int value) { }

}

