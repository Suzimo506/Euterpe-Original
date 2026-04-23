using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000673")]
public class RectTramAnchorsOption : OptionGeneric<RectTramAnchorsSource, RectTramAnchors>
{
	[Address(RVA = "0x7617E0", Offset = "0x75FFE0", Length = "0x7C")]
	[Token(Token = "0x6003D72")]
	protected override void OnApply(RectTramAnchorsSource source, Localization localization)
	{
	}

	[Address(RVA = "0x761790", Offset = "0x75FF90", Length = "0x43")]
	[Token(Token = "0x6003D73")]
	protected override RectTramAnchors DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003D74")]
	[Address(RVA = "0x761860", Offset = "0x760060", Length = "0x38")]
	public RectTramAnchorsOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
