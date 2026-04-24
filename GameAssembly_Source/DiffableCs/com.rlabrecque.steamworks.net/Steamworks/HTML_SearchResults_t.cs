namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_SearchResults_t
{
	public const int k_iCallback = 4509; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public uint unResults; //Field offset: 0x4
	public uint unCurrentMatch; //Field offset: 0x8

}

