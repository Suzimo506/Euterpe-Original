namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_LinkAtPosition_t
{
	public const int k_iCallback = 4513; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public uint x; //Field offset: 0x4
	public uint y; //Field offset: 0x8
	public string pchURL; //Field offset: 0x10
	public bool bInput; //Field offset: 0x18
	public bool bLiveLink; //Field offset: 0x19

}

