using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;
using Spine.Unity;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000459")]
public class SpineSkeletonGraphicOption : OptionGeneric<SpineSkeletonGraphicSource, SkeletonDataAsset>
{
	[Token(Token = "0x600328A")]
	[Address(RVA = "0x505110", Offset = "0x503910", Length = "0xE3")]
	protected override void OnApply(SpineSkeletonGraphicSource source, Localization localization)
	{
	}

	[Token(Token = "0x600328B")]
	[Address(RVA = "0x505200", Offset = "0x503A00", Length = "0x38")]
	public SpineSkeletonGraphicOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
