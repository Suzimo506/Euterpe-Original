namespace ZenFulcrum.EmbeddedBrowser;

[Obsolete]
public class FPSCursorRenderer : MonoBehaviour
{
	private static FPSCursorRenderer _instance; //Field offset: 0x0
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float scale; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float maxDistance; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Transform pointer; //Field offset: 0x20
	[CompilerGenerated]
	private bool <EnableInput>k__BackingField; //Field offset: 0x28
	protected BrowserCursor baseCursor; //Field offset: 0x30
	protected BrowserCursor currentCursor; //Field offset: 0x38

	public bool EnableInput
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public static FPSCursorRenderer Instance
	{
		 get { } //Length: 299
	}

	public FPSCursorRenderer() { }

	[CompilerGenerated]
	public bool get_EnableInput() { }

	public static FPSCursorRenderer get_Instance() { }

	public void OnGUI() { }

	[CompilerGenerated]
	public void set_EnableInput(bool value) { }

	public void SetCursor(BrowserCursor newCursor, FPSBrowserUI ui) { }

	public static void SetUpBrowserInput(Browser browser, MeshCollider mesh) { }

	public void Start() { }

}

