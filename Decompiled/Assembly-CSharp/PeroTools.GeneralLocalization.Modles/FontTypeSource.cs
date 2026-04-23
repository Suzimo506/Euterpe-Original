using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using UnityEngine.UI;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200044A")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36BC0", Offset = "0x35FC0")]
public class FontTypeSource : SourceGeneric<Text>
{
	[Address(RVA = "0x4F5350", Offset = "0x4F3B50", Length = "0x42")]
	[Token(Token = "0x600326C")]
	protected override Text DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x600326D")]
	[Address(RVA = "0x4F53A0", Offset = "0x4F3BA0", Length = "0x38")]
	public FontTypeSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
