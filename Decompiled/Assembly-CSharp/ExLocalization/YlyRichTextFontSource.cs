using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace ExLocalization;

[Attribute(Name = "SourcePathAttribute", RVA = "0x4F8F0", Offset = "0x4ECF0")]
[Token(Token = "0x20004B1")]
public class YlyRichTextFontSource : SourceGeneric<YlyRichText>
{
	[Address(RVA = "0x45C330", Offset = "0x45AB30", Length = "0x42")]
	[Token(Token = "0x6003545")]
	protected override YlyRichText DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x45C380", Offset = "0x45AB80", Length = "0x38")]
	[Token(Token = "0x6003546")]
	public YlyRichTextFontSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
