namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_CanGoBackAndForward_t
{
	public const int k_iCallback = 4510; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public bool bCanGoBack; //Field offset: 0x4
	public bool bCanGoForward; //Field offset: 0x5

}

