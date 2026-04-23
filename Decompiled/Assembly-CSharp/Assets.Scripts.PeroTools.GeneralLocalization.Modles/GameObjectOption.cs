using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x2000669")]
public class GameObjectOption : OptionGeneric<GameObjectSource, bool>
{
	[Token(Token = "0x6003D5E")]
	[Address(RVA = "0x75BC20", Offset = "0x75A420", Length = "0x2A")]
	protected override void OnApply(GameObjectSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D5F")]
	[Address(RVA = "0x75BC50", Offset = "0x75A450", Length = "0x38")]
	public GameObjectOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
