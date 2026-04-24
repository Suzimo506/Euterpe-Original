namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_NewWindow_t
{
	public const int k_iCallback = 4521; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public string pchURL; //Field offset: 0x8
	public uint unX; //Field offset: 0x10
	public uint unY; //Field offset: 0x14
	public uint unWide; //Field offset: 0x18
	public uint unTall; //Field offset: 0x1C
	public HHTMLBrowser unNewWindow_BrowserHandle_IGNORE; //Field offset: 0x20

}

