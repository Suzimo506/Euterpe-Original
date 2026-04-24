using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000262")]
public interface IRailComponent
{
	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x0", Length = "0x0")]
	ulong GetComponentVersion();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60029FA")]
	void Release();
}
