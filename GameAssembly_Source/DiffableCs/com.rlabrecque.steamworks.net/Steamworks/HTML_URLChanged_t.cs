namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_URLChanged_t
{
	public const int k_iCallback = 4505; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public string pchURL; //Field offset: 0x8
	public string pchPostData; //Field offset: 0x10
	public bool bIsRedirect; //Field offset: 0x18
	public string pchPageTitle; //Field offset: 0x20
	public bool bNewNavigation; //Field offset: 0x28

}

