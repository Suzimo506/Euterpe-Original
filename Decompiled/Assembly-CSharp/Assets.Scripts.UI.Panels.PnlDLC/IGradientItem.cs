using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000931")]
public interface IGradientItem
{
	[Token(Token = "0x6005330")]
	[Address(RVA = "0x0", Length = "0x0")]
	void Show(int jsonIndex);

	[Token(Token = "0x6005331")]
	[Address(RVA = "0x0", Length = "0x0")]
	void StopShow();
}
