using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000944")]
public enum PnlDlcToggleType
{
	[Token(Token = "0x4003248")]
	None = 0,
	[Token(Token = "0x4003249")]
	JustAsPlanned = 1,
	[Token(Token = "0x400324A")]
	Standard = 2,
	[Token(Token = "0x400324B")]
	DLC = 4
}
