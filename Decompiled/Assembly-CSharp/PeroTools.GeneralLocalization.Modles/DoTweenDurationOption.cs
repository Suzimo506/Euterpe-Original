using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000446")]
public class DoTweenDurationOption : OptionGeneric<DoTweenDurationSource, Duration>
{
	[Token(Token = "0x6003263")]
	[Address(RVA = "0x4F39F0", Offset = "0x4F21F0", Length = "0x35")]
	protected override void OnApply(DoTweenDurationSource source, Localization localization)
	{
	}

	[Address(RVA = "0x4F39A0", Offset = "0x4F21A0", Length = "0x43")]
	[Token(Token = "0x6003264")]
	protected override Duration DefaultValue(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x4F3A30", Offset = "0x4F2230", Length = "0x38")]
	[Token(Token = "0x6003265")]
	public DoTweenDurationOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
