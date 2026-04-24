using System;
using Assets.Scripts.UI.GameMain;
using Cpp2ILInjected;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008D0")]
public class PnlBattleCombos
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002DFA")]
	public CountAnimator combo;

	[Token(Token = "0x4002DFB")]
	[FieldOffset(Offset = "0x18")]
	public CountAnimator comboGC;

	[Token(Token = "0x4002DFC")]
	[FieldOffset(Offset = "0x20")]
	public CountAnimator comboDjMax;

	[Token(Token = "0x4002DFD")]
	[FieldOffset(Offset = "0x28")]
	public CountAnimator comboArkNight;

	[NonSerialized]
	[Token(Token = "0x4002DFE")]
	[FieldOffset(Offset = "0x30")]
	public CountAnimator curCount;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004F61")]
	public PnlBattleCombos()
	{
	}
}
