using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000683")]
public class TextJsonOption : OptionGeneric<TextJsonSource, SetText>
{
	[Token(Token = "0x6003D95")]
	[Address(RVA = "0x7631C0", Offset = "0x7619C0", Length = "0x9F")]
	protected override void OnApply(TextJsonSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D96")]
	[Address(RVA = "0x763060", Offset = "0x761860", Length = "0x15C")]
	protected override SetText DefaultValue(Localization localization)
	{
		return null;
	}

	[Token(Token = "0x6003D97")]
	[Address(RVA = "0x763260", Offset = "0x761A60", Length = "0x38")]
	public TextJsonOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
