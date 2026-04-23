using Cpp2ILInjected;

namespace GameLogic;

[Token(Token = "0x20004AD")]
public class MusicConfigReader : BaseConfigReader
{
	[Token(Token = "0x400197F")]
	private const int tickLimit = 0;

	[Address(RVA = "0x5D4410", Offset = "0x5D2C10", Length = "0x43")]
	[Token(Token = "0x600353E")]
	protected override void Init()
	{
	}

	[Token(Token = "0x600353F")]
	[Address(RVA = "0x5D4460", Offset = "0x5D2C60", Length = "0x7")]
	public MusicConfigReader()
	{
	}
}
