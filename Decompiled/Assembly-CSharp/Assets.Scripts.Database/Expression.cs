using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x200079E")]
public class Expression
{
	[Token(Token = "0x4002877")]
	[FieldOffset(Offset = "0x10")]
	public string animName;

	[Token(Token = "0x4002878")]
	[FieldOffset(Offset = "0x18")]
	public string[] audioNames;

	[NonSerialized]
	[Token(Token = "0x4002879")]
	[FieldOffset(Offset = "0x20")]
	public List<string> texts;

	[Token(Token = "0x400287A")]
	[FieldOffset(Offset = "0x28")]
	public List<List<TalkInfo>> talkInfosList;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400287B")]
	public float weight;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60046EB")]
	public Expression()
	{
	}
}
