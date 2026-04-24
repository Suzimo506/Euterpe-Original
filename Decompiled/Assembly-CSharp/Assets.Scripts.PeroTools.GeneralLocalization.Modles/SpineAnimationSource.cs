using Cpp2ILInjected;
using Spine.Unity;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Attribute(Name = "SourcePathAttribute", RVA = "0x36F50", Offset = "0x36350")]
[Token(Token = "0x2000676")]
public class SpineAnimationSource : SourceGeneric<SkeletonAnimation>
{
	[Address(RVA = "0x7628E0", Offset = "0x7610E0", Length = "0x42")]
	[Token(Token = "0x6003D7A")]
	protected override SkeletonAnimation DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x762930", Offset = "0x761130", Length = "0x38")]
	[Token(Token = "0x6003D7B")]
	public SpineAnimationSource()
	{
		((SourceGeneric<>)(object)this)._002Ector();
	}
}
