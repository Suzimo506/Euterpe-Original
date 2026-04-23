using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000376")]
public class NumberOfPlayerReceived : EventBase
{
	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x30")]
	public int online_number;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40014AC")]
	public int offline_number;

	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public NumberOfPlayerReceived()
	{
	}
}
