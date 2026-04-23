using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000392")]
public class RailSystemStateChanged : EventBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40014EC")]
	public RailSystemState state;

	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailSystemStateChanged()
	{
	}
}
