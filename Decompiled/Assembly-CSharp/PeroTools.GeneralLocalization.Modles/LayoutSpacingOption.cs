using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200044F")]
public class LayoutSpacingOption : OptionGeneric<LayoutSpacingSource, LayoutSpacing>
{
	[Token(Token = "0x6003275")]
	[Address(RVA = "0x4F58E0", Offset = "0x4F40E0", Length = "0x31")]
	protected override void OnApply(LayoutSpacingSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x4F5890", Offset = "0x4F4090", Length = "0x43")]
	protected override LayoutSpacing DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x4F5920", Offset = "0x4F4120", Length = "0x38")]
	public LayoutSpacingOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
