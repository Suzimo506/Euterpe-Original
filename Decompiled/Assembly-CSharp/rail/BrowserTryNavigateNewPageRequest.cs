using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200028C")]
public class BrowserTryNavigateNewPageRequest : EventBase
{
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x30")]
	public string url;

	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x38")]
	public string target_type;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001026")]
	public bool is_redirect_request;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002CE7")]
	public BrowserTryNavigateNewPageRequest()
	{
	}
}
