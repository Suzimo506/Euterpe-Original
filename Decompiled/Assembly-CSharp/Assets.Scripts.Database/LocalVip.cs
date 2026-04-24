using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x20007FF")]
public struct LocalVip
{
	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x0")]
	public int index;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40029A9")]
	public string uid;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40029AA")]
	public string title;
}
