using Cpp2ILInjected;
using Spine.Unity;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000677")]
public class SpineAnimationOption : OptionGeneric<SpineAnimationSource, SkeletonDataAsset>
{
	[Address(RVA = "0x7627B0", Offset = "0x760FB0", Length = "0xE8")]
	[Token(Token = "0x6003D7C")]
	protected override void OnApply(SpineAnimationSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D7D")]
	[Address(RVA = "0x7628A0", Offset = "0x7610A0", Length = "0x38")]
	public SpineAnimationOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
