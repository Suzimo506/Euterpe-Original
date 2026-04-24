using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x2000658")]
public abstract class Source
{
	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003D33")]
	public abstract object GetSourceTarget();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6003D34")]
	public abstract void Default(Localization localiation);

	[Token(Token = "0x6003D35")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	protected Source()
	{
	}
}
