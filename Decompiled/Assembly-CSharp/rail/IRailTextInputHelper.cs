using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000393")]
public interface IRailTextInputHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EFC")]
	RailResult ShowTextInputWindow(RailTextInputWindowOption options);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EFD")]
	void GetTextInputContent(out string content);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002EFE")]
	RailResult HideTextInputWindow();
}
