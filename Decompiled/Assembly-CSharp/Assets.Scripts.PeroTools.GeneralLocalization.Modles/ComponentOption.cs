using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000667")]
public class ComponentOption : OptionGeneric<ComponentSource, bool>
{
	[Address(RVA = "0x755190", Offset = "0x753990", Length = "0x2A")]
	[Token(Token = "0x6003D5A")]
	protected override void OnApply(ComponentSource source, Localization localization)
	{
	}

	[Address(RVA = "0x7551C0", Offset = "0x7539C0", Length = "0x38")]
	[Token(Token = "0x6003D5B")]
	public ComponentOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
