namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public int antiAliasing
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool autoGenerateMips
	{
		 set { } //Length: 66
	}

	public bool bindTextureMS
	{
		 set { } //Length: 66
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 90
	}

	public int depth
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 64
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 90
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 142
		 set { } //Length: 146
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool enableRandomWrite
	{
		 set { } //Length: 66
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 59
	}

	[NativeProperty]
	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public virtual int height
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public RenderTextureMemoryless memorylessMode
	{
		 set { } //Length: 64
	}

	[NativeProperty]
	public bool sRGB
	{
		 get { } //Length: 51
	}

	public GraphicsFormat stencilFormat
	{
		 set { } //Length: 64
	}

	public bool useDynamicScale
	{
		 set { } //Length: 66
	}

	[NativeProperty]
	public bool useMipMap
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int volumeDepth
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public virtual int width
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	public bool Create() { }

	public static RenderTexture get_active() { }

	public int get_antiAliasing() { }

	public RenderBuffer get_colorBuffer() { }

	[FreeFunction]
	public int get_depth() { }

	public RenderBuffer get_depthBuffer() { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual TextureDimension get_dimension() { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public virtual int get_height() { }

	public bool get_sRGB() { }

	public bool get_useMipMap() { }

	public int get_volumeDepth() { }

	public virtual int get_width() { }

	[FreeFunction]
	private static RenderTexture GetActive() { }

	[FreeFunction]
	private RenderBuffer GetColorBuffer() { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	[FreeFunction]
	private RenderBuffer GetDepthBuffer() { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[FreeFunction]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false) { }

	[FreeFunction]
	private static void Internal_Create(RenderTexture rt) { }

	public bool IsCreated() { }

	public void Release() { }

	[FreeFunction]
	public static void ReleaseTemporary(RenderTexture temp) { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	public void set_autoGenerateMips(bool value) { }

	public void set_bindTextureMS(bool value) { }

	[FreeFunction]
	public void set_depth(int value) { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	public virtual void set_dimension(TextureDimension value) { }

	public void set_enableRandomWrite(bool value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	public void set_memorylessMode(RenderTextureMemoryless value) { }

	public void set_stencilFormat(GraphicsFormat value) { }

	public void set_useDynamicScale(bool value) { }

	public void set_useMipMap(bool value) { }

	public void set_volumeDepth(int value) { }

	public virtual void set_width(int value) { }

	[FreeFunction]
	private static void SetActive(RenderTexture rt) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

