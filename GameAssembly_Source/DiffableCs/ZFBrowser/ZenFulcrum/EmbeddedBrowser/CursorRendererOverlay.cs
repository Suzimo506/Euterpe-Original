namespace ZenFulcrum.EmbeddedBrowser;

public class CursorRendererOverlay : CursorRendererBase
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float scale; //Field offset: 0x20

	public CursorRendererOverlay() { }

	protected virtual void CursorChange() { }

	public void OnGUI() { }

}

