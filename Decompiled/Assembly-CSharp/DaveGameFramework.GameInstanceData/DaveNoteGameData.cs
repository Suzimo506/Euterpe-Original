using Cpp2ILInjected;

namespace DaveGameFramework.GameInstanceData;

[Token(Token = "0x20004BC")]
public struct DaveNoteGameData
{
	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x0")]
	public bool ignoreJudge;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40019D6")]
	public int judgeResult;
}
