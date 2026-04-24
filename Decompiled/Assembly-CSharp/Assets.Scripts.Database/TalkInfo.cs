using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Token(Token = "0x20007A0")]
public class TalkInfo
{
	[Token(Token = "0x4002880")]
	[FieldOffset(Offset = "0x10")]
	public float duration;

	[Token(Token = "0x4002881")]
	[FieldOffset(Offset = "0x14")]
	public float interval;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002882")]
	public TalkType talkType;

	[Token(Token = "0x60046EC")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public TalkInfo()
	{
	}
}
