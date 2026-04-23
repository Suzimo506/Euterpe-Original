using Cpp2ILInjected;

namespace Assets.Scripts.UI.Controls;

[Token(Token = "0x20008B9")]
public class AwardInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002D87")]
	public string imgName;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002D88")]
	public string localName;

	[Token(Token = "0x4002D89")]
	[FieldOffset(Offset = "0x20")]
	public string type;

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6004ED4")]
	public AwardInfo()
	{
	}
}
