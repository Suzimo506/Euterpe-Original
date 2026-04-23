using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x200065F")]
public class TextGlobalOption : GlobalOptoin
{
	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0x10")]
	public Font font;

	[Token(Token = "0x6003D45")]
	[Address(RVA = "0x762DB0", Offset = "0x7615B0", Length = "0x2A9")]
	public override void Apply(Localization localization)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003D46")]
	public override void Default(Localization localization)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003D47")]
	public TextGlobalOption()
	{
	}
}
