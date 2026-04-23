using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x374B0", Offset = "0x368B0")]
[Token(Token = "0x2000681")]
public class TextJsonSource : SourceGeneric<TextJsonSourceTarget>
{
	[Address(RVA = "0x7633F0", Offset = "0x761BF0", Length = "0x10B")]
	[Token(Token = "0x6003D90")]
	protected override TextJsonSourceTarget DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003D91")]
	[Address(RVA = "0x763500", Offset = "0x761D00", Length = "0x38")]
	public TextJsonSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
