using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000013")]
public struct SkeletActionData
{
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x0")]
	public bool collapsed;

	[FieldOffset(Offset = "0x1")]
	[Token(Token = "0x4000040")]
	public bool isEndLoop;

	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000041")]
	public bool isRandomSequence;

	[FieldOffset(Offset = "0x3")]
	[Token(Token = "0x4000042")]
	public bool isSelfProtect;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000043")]
	public string name;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x10")]
	public int protectLevel;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x14")]
	public int spineActionKeyIndex;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x18")]
	public string[] actionIdx;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x20")]
	public int[] actionEventIdx;
}
