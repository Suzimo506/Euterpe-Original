using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization.Modles;

[Token(Token = "0x200066C")]
public class GridLayoutGroupOption : OptionGeneric<GridLayoutGroupSource, Property>
{
	[Token(Token = "0x6003D63")]
	[Address(RVA = "0x75BE20", Offset = "0x75A620", Length = "0x7C")]
	protected override void OnApply(GridLayoutGroupSource source, Localization localization)
	{
	}

	[Token(Token = "0x6003D64")]
	[Address(RVA = "0x75BD40", Offset = "0x75A540", Length = "0xD0")]
	protected override Property DefaultValue(Localization localization)
	{
		return null;
	}

	[Address(RVA = "0x75BEA0", Offset = "0x75A6A0", Length = "0x38")]
	[Token(Token = "0x6003D65")]
	public GridLayoutGroupOption()
	{
		((OptionGeneric<, >)(object)this)._002Ector();
	}
}
