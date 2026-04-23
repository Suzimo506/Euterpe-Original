using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000455")]
public class RectTramSizeOption : OptionGeneric<RectTramSizeSource, RectTramSize>
{
	[Address(RVA = "0x504890", Offset = "0x503090", Length = "0x56")]
	[Token(Token = "0x6003281")]
	protected override void OnApply(RectTramSizeSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003282")]
	[Address(RVA = "0x504840", Offset = "0x503040", Length = "0x43")]
	protected override RectTramSize DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003283")]
	[Address(RVA = "0x5048F0", Offset = "0x5030F0", Length = "0x38")]
	public RectTramSizeOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
