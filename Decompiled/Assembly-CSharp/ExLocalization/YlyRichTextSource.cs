using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace ExLocalization;

[Attribute(Name = "SourcePathAttribute", RVA = "0x4FA30", Offset = "0x4EE30")]
[Token(Token = "0x20004B3")]
public class YlyRichTextSource : SourceGeneric<YlyRichText>
{
	[Token(Token = "0x6003549")]
	[Address(RVA = "0x45C450", Offset = "0x45AC50", Length = "0x42")]
	protected override YlyRichText DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x600354A")]
	[Address(RVA = "0x45C4A0", Offset = "0x45ACA0", Length = "0x38")]
	public YlyRichTextSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
