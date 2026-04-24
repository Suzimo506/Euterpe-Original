using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x200000E")]
public struct StageTimeEvent
{
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x0")]
	public bool flod;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x4")]
	public float time;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x8")]
	public StageTimeEventItem[] eventItems;
}
