using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x2000659")]
public abstract class SourceGeneric<T> : Source where T : class
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40023B7")]
	public T target;

	[Token(Token = "0x6003D36")]
	[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
	public override object GetSourceTarget()
	{
		return null;
	}

	[Token(Token = "0x6003D37")]
	[Address(RVA = "0x1362D60", Offset = "0x1361560", Length = "0x37")]
	public sealed override void Default(Localization localiation)
	{
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x6003D38")]
	protected virtual T DefaultSource(Localization localiation)
	{
		return null;
	}

	[Address(RVA = "0x1361470", Offset = "0x135FC70", Length = "0x19")]
	[Token(Token = "0x6003D39")]
	protected SourceGeneric()
	{
	}
}
