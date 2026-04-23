using Assets.Scripts.PeroTools.GeneralLocalization;
using Cpp2ILInjected;

namespace PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000452")]
public class RectTramPosOption : OptionGeneric<RectTramPosSource, RectTramPos>
{
	[Address(RVA = "0x504710", Offset = "0x502F10", Length = "0x56")]
	[Token(Token = "0x600327B")]
	protected override void OnApply(RectTramPosSource source, Localization localization)
	{
	}

	[Token(Token = "0x600327C")]
	[Address(RVA = "0x5046C0", Offset = "0x502EC0", Length = "0x43")]
	protected override RectTramPos DefaultValue(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x504770", Offset = "0x502F70", Length = "0x38")]
	[Token(Token = "0x600327D")]
	public RectTramPosOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
