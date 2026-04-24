namespace ZenFulcrum.EmbeddedBrowser;

public class CursorRendererWorldSpace : CursorRendererBase
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float zOffset; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float size; //Field offset: 0x24
	private GameObject cursorHolder; //Field offset: 0x28
	private GameObject cursorImage; //Field offset: 0x30
	private PointerUIBase pointerUI; //Field offset: 0x38
	private bool cursorVisible; //Field offset: 0x40

	public CursorRendererWorldSpace() { }

	public void Awake() { }

	protected virtual void CursorChange() { }

	public void LateUpdate() { }

	public void OnDestroy() { }

}

