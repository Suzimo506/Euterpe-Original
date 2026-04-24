using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x200065B")]
public abstract class Option
{
	[Token(Token = "0x6003D3B")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Apply(Localization localization);

	[Token(Token = "0x6003D3C")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void Default(Localization localization);

	[Token(Token = "0x6003D3D")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected Option()
	{
	}
}
