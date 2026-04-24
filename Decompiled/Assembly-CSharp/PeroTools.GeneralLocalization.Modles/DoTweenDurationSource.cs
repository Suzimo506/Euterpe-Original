using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using DG.Tweening;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000444")]
[Attribute(Name = "SourcePathAttribute", RVA = "0x36900", Offset = "0x35D00")]
public class DoTweenDurationSource : SourceGeneric<DOTweenAnimation>
{
	[Address(RVA = "0x4F3A70", Offset = "0x4F2270", Length = "0x42")]
	[Token(Token = "0x6003260")]
	protected override DOTweenAnimation DefaultSource(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x4F3AC0", Offset = "0x4F22C0", Length = "0x38")]
	[Token(Token = "0x6003261")]
	public DoTweenDurationSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
