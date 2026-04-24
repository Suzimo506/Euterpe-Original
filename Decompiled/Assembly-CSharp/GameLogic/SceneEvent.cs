using System;
using Cpp2ILInjected;

namespace GameLogic;

[Serializable]
[Token(Token = "0x20004AE")]
public class SceneEvent
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001980")]
	public string uid;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001981")]
	public decimal time;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001982")]
	public object value;

	[Token(Token = "0x6003540")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SceneEvent()
	{
	}
}
