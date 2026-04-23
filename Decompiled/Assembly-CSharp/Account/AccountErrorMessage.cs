using Cpp2ILInjected;

namespace Account;

[Token(Token = "0x2000564")]
public struct AccountErrorMessage
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001FD3")]
	public int http_code;

	[Token(Token = "0x4001FD4")]
	[FieldOffset(Offset = "0x8")]
	public string msg;

	[Token(Token = "0x4001FD5")]
	[FieldOffset(Offset = "0x10")]
	public int biz_code;

	[Token(Token = "0x4001FD6")]
	[FieldOffset(Offset = "0x18")]
	public string data;

	[Token(Token = "0x4001FD7")]
	[FieldOffset(Offset = "0x20")]
	public string param;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001FD8")]
	public string host;

	[Address(RVA = "0x774170", Offset = "0x772970", Length = "0x80")]
	[Token(Token = "0x60037FC")]
	public override string ToString()
	{
		return null;
	}
}
