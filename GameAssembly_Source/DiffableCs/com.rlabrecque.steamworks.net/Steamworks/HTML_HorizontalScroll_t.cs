namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_HorizontalScroll_t
{
	public const int k_iCallback = 4511; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public uint unScrollMax; //Field offset: 0x4
	public uint unScrollCurrent; //Field offset: 0x8
	public float flPageScale; //Field offset: 0xC
	public bool bVisible; //Field offset: 0x10
	public uint unPageSize; //Field offset: 0x14

}

