namespace ZenFulcrum.EmbeddedBrowser;

[Obsolete]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FPSBrowserUI : ClickMeshBrowserUI
{
	protected Transform worldPointer; //Field offset: 0x68
	protected FPSCursorRenderer cursorRenderer; //Field offset: 0x70

	protected virtual Ray LookRay
	{
		 get { } //Length: 172
	}

	public FPSBrowserUI() { }

	public static FPSBrowserUI Create(MeshCollider meshCollider, Transform worldPointer, FPSCursorRenderer cursorRenderer) { }

	protected virtual Ray get_LookRay() { }

	public virtual void InputUpdate() { }

	protected virtual void SetCursor(BrowserCursor newCursor) { }

	public void Start() { }

}

