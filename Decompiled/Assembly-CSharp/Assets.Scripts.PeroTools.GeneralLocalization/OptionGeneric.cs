using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x200065C")]
public abstract class OptionGeneric<TSource, TValue> : Option where TSource : Source
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40023BA")]
	public TValue value;

	[Token(Token = "0x6003D3E")]
	[Address(RVA = "0x1360E30", Offset = "0x135F630", Length = "0x1C3")]
	public override void Apply(Localization localization)
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003D3F")]
	protected abstract void OnApply(TSource source, Localization localization);

	[Address(RVA = "0x13613D0", Offset = "0x135FBD0", Length = "0x37")]
	[Token(Token = "0x6003D40")]
	public sealed override void Default(Localization localization)
	{
	}

	[Token(Token = "0x6003D41")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	protected virtual TValue DefaultValue(Localization localization)
	{
		return (TValue)null;
	}

	[Token(Token = "0x6003D42")]
	[Address(RVA = "0x1361470", Offset = "0x135FC70", Length = "0x19")]
	protected OptionGeneric()
	{
	}
}
