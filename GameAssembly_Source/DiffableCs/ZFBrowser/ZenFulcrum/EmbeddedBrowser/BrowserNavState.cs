namespace ZenFulcrum.EmbeddedBrowser;

public class BrowserNavState
{
	public bool canGoForward; //Field offset: 0x10
	public bool canGoBack; //Field offset: 0x11
	public bool loading; //Field offset: 0x12
	public string url; //Field offset: 0x18

	public BrowserNavState() { }

}

