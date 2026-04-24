using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000457")]
public class SpineAnimationStartStateOption : OptionGeneric<SpineAnimationStartStateSource, string>
{
	[Token(Token = "0x6003286")]
	[Address(RVA = "0x504B30", Offset = "0x503330", Length = "0xB1")]
	protected override void OnApply(SpineAnimationStartStateSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003287")]
	[Address(RVA = "0x504BF0", Offset = "0x5033F0", Length = "0x38")]
	public SpineAnimationStartStateOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
