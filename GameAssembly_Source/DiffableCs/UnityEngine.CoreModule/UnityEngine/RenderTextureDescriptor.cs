namespace UnityEngine;

public struct RenderTextureDescriptor
{
	private static Int32[] depthFormatBits; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <width>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <height>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <msaaSamples>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <volumeDepth>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int <mipCount>k__BackingField; //Field offset: 0x10
	private GraphicsFormat _graphicsFormat; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private GraphicsFormat <stencilFormat>k__BackingField; //Field offset: 0x18
	private int _depthBufferBits; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private TextureDimension <dimension>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private VRTextureUsage <vrUsage>k__BackingField; //Field offset: 0x28
	private RenderTextureCreationFlags _flags; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private RenderTextureMemoryless <memoryless>k__BackingField; //Field offset: 0x30

	internal bool createdFromScript
	{
		internal set { } //Length: 25
	}

	public int depthBufferBits
	{
		 get { } //Length: 131
		 set { } //Length: 20
	}

	public TextureDimension dimension
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 6
		 set { } //Length: 54
	}

	public int height
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RenderTextureMemoryless memoryless
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int mipCount
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int msaaSamples
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ShadowSamplingMode shadowSamplingMode
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool useDynamicScale
	{
		 set { } //Length: 27
	}

	public int volumeDepth
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public VRTextureUsage vrUsage
	{
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int width
	{
		[CompilerGenerated]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	private static RenderTextureDescriptor() { }

	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits, int mipCount) { }

	public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, int depthBufferBits) { }

	public RenderTextureDescriptor(int width, int height) { }

	public int get_depthBufferBits() { }

	[CompilerGenerated]
	public TextureDimension get_dimension() { }

	public GraphicsFormat get_graphicsFormat() { }

	[CompilerGenerated]
	public int get_height() { }

	[CompilerGenerated]
	public int get_msaaSamples() { }

	[CompilerGenerated]
	public int get_volumeDepth() { }

	[CompilerGenerated]
	public int get_width() { }

	internal void set_createdFromScript(bool value) { }

	public void set_depthBufferBits(int value) { }

	[CompilerGenerated]
	public void set_dimension(TextureDimension value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	[CompilerGenerated]
	public void set_height(int value) { }

	[CompilerGenerated]
	public void set_memoryless(RenderTextureMemoryless value) { }

	[CompilerGenerated]
	public void set_mipCount(int value) { }

	[CompilerGenerated]
	public void set_msaaSamples(int value) { }

	[CompilerGenerated]
	public void set_shadowSamplingMode(ShadowSamplingMode value) { }

	public void set_useDynamicScale(bool value) { }

	[CompilerGenerated]
	public void set_volumeDepth(int value) { }

	[CompilerGenerated]
	public void set_vrUsage(VRTextureUsage value) { }

	[CompilerGenerated]
	public void set_width(int value) { }

	private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag) { }

}

