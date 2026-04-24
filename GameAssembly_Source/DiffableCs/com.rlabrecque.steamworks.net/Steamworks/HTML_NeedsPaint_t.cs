namespace Steamworks;

[CallbackIdentity(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct HTML_NeedsPaint_t
{
	public const int k_iCallback = 4502; //Field offset: 0x0
	public HHTMLBrowser unBrowserHandle; //Field offset: 0x0
	public IntPtr pBGRA; //Field offset: 0x8
	public uint unWide; //Field offset: 0x10
	public uint unTall; //Field offset: 0x14
	public uint unUpdateX; //Field offset: 0x18
	public uint unUpdateY; //Field offset: 0x1C
	public uint unUpdateWide; //Field offset: 0x20
	public uint unUpdateTall; //Field offset: 0x24
	public uint unScrollX; //Field offset: 0x28
	public uint unScrollY; //Field offset: 0x2C
	public float flPageScale; //Field offset: 0x30
	public uint unPageSerial; //Field offset: 0x34

}

