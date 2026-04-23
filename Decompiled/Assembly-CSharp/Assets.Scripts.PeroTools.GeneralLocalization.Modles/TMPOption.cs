using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000679")]
public class TMPOption : OptionGeneric<TMPSource, TMPSetting>
{
	[Address(RVA = "0x762BC0", Offset = "0x7613C0", Length = "0x11D")]
	[Token(Token = "0x6003D80")]
	protected override void OnApply(TMPSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D81")]
	[Address(RVA = "0x762B70", Offset = "0x761370", Length = "0x43")]
	protected override TMPSetting DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003D82")]
	[Address(RVA = "0x762CE0", Offset = "0x7614E0", Length = "0x38")]
	public TMPOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
