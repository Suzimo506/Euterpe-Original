using Cpp2ILInjected;

namespace GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;

[Token(Token = "0x2000480")]
public struct BattleQuestionState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001849")]
	public int bindNoteId;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x400184A")]
	public bool airIsRight;

	[Token(Token = "0x400184B")]
	[FieldOffset(Offset = "0x8")]
	public DBLocalizedBattleQuestion question;
}
