namespace UnityEngine;

[NativeClass(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Canvas : Behaviour
{
	internal sealed class WillRenderCanvases : MulticastDelegate
	{

		public WillRenderCanvases(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static WillRenderCanvases preWillRenderCanvases; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static WillRenderCanvases willRenderCanvases; //Field offset: 0x8

	public static event WillRenderCanvases preWillRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 164
		[CompilerGenerated]
		 remove { } //Length: 164
	}

	public static event WillRenderCanvases willRenderCanvases
	{
		[CompilerGenerated]
		 add { } //Length: 168
		[CompilerGenerated]
		 remove { } //Length: 168
	}

	public AdditionalCanvasShaderChannels additionalShaderChannels
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int cachedSortingLayerValue
	{
		 get { } //Length: 51
	}

	public bool isRootCanvas
	{
		 get { } //Length: 51
	}

	[NativeProperty]
	public float normalizedSortingGridSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool overridePixelPerfect
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool overrideSorting
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool pixelPerfect
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Rect pixelRect
	{
		 get { } //Length: 75
	}

	public float planeDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float referencePixelsPerUnit
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Vector2 renderingDisplaySize
	{
		 get { } //Length: 70
	}

	public RenderMode renderMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int renderOrder
	{
		 get { } //Length: 51
	}

	public Canvas rootCanvas
	{
		 get { } //Length: 51
	}

	public float scaleFactor
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty]
	[Obsolete]
	public int sortingGridNormalizedSize
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int sortingLayerID
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string sortingLayerName
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int sortingOrder
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int targetDisplay
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty]
	public Camera worldCamera
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Canvas() { }

	[CompilerGenerated]
	public static void add_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void add_willRenderCanvases(WillRenderCanvases value) { }

	public static void ForceUpdateCanvases() { }

	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	public int get_cachedSortingLayerValue() { }

	public bool get_isRootCanvas() { }

	public float get_normalizedSortingGridSize() { }

	public bool get_overridePixelPerfect() { }

	public bool get_overrideSorting() { }

	public bool get_pixelPerfect() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	public float get_planeDistance() { }

	public float get_referencePixelsPerUnit() { }

	public Vector2 get_renderingDisplaySize() { }

	private void get_renderingDisplaySize_Injected(out Vector2 ret) { }

	public RenderMode get_renderMode() { }

	public int get_renderOrder() { }

	public Canvas get_rootCanvas() { }

	public float get_scaleFactor() { }

	public int get_sortingGridNormalizedSize() { }

	public int get_sortingLayerID() { }

	public string get_sortingLayerName() { }

	public int get_sortingOrder() { }

	public int get_targetDisplay() { }

	public Camera get_worldCamera() { }

	[FreeFunction]
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction]
	[Obsolete]
	public static Material GetDefaultCanvasTextMaterial() { }

	[FreeFunction]
	public static Material GetETC1SupportedCanvasMaterial() { }

	[CompilerGenerated]
	public static void remove_preWillRenderCanvases(WillRenderCanvases value) { }

	[CompilerGenerated]
	public static void remove_willRenderCanvases(WillRenderCanvases value) { }

	[RequiredByNativeCode]
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	private static void SendWillRenderCanvases() { }

	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	public void set_normalizedSortingGridSize(float value) { }

	public void set_overridePixelPerfect(bool value) { }

	public void set_overrideSorting(bool value) { }

	public void set_pixelPerfect(bool value) { }

	public void set_planeDistance(float value) { }

	public void set_referencePixelsPerUnit(float value) { }

	public void set_renderMode(RenderMode value) { }

	public void set_scaleFactor(float value) { }

	public void set_sortingGridNormalizedSize(int value) { }

	public void set_sortingLayerID(int value) { }

	public void set_sortingLayerName(string value) { }

	public void set_sortingOrder(int value) { }

	public void set_targetDisplay(int value) { }

	public void set_worldCamera(Camera value) { }

}

