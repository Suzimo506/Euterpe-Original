namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_FinishedRequest_t
{
	public const int k_iCallback = 4506; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public string pchURL; //Field offset: 0x8
	public string pchPageTitle; //Field offset: 0x10

}

