namespace ZenFulcrum.EmbeddedBrowser;

public class CursorRendererOS : CursorRendererBase
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool cursorNormallyVisible; //Field offset: 0x20

	public CursorRendererOS() { }

	protected virtual void CursorChange() { }

}

