using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002FD")]
public interface IRailIMEHelper
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DE4")]
	RailResult EnableIMEHelperTextInputWindow(bool enable, RailTextInputImeWindowOption option);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002DE5")]
	RailResult UpdateIMEHelperTextInputWindowPosition(RailWindowPosition position);
}
