using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200000F")]
public struct StageEvent
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x0")]
	public bool flodAction;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x1")]
	public bool flodTime;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000027")]
	public StageActionEvent[] actionEvents;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	public StageTimeEvent[] timeEvents;
}
