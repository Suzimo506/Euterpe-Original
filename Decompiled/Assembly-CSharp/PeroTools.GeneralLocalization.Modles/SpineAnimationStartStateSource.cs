using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using Spine.Unity;

namespace PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x37000", Offset = "0x36400")]
[Token(Token = "0x2000456")]
public class SpineAnimationStartStateSource : SourceGeneric<SkeletonGraphic>
{
	[Address(RVA = "0x504C30", Offset = "0x503430", Length = "0x42")]
	[Token(Token = "0x6003284")]
	protected override SkeletonGraphic DefaultSource(Localization localiation)
	{
		return null;
	}

	[Token(Token = "0x6003285")]
	[Address(RVA = "0x504C80", Offset = "0x503480", Length = "0x38")]
	public SpineAnimationStartStateSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
