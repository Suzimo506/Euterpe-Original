namespace ZenFulcrum.EmbeddedBrowser;

public class BrowserFocusState
{
	public bool hasKeyboardFocus; //Field offset: 0x10
	public bool hasMouseFocus; //Field offset: 0x11
	public string focusedTagName; //Field offset: 0x18
	public bool focusedNodeEditable; //Field offset: 0x20

	public BrowserFocusState() { }

}

