using Cpp2ILInjected;
using TMPro;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200067A")]
public class TMPSetting
{
	[Token(Token = "0x40023C7")]
	[FieldOffset(Offset = "0x10")]
	public string text;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023C8")]
	public TMP_FontAsset font;

	[Token(Token = "0x6003D83")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public TMPSetting()
	{
	}
}
