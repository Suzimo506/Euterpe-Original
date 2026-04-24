using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002BD")]
public class ShowFloatingWindowResult : EventBase
{
	[Token(Token = "0x400119B")]
	[FieldOffset(Offset = "0x30")]
	public EnumRailWindowType window_type;

	[Token(Token = "0x400119C")]
	[FieldOffset(Offset = "0x34")]
	public bool is_show;

	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	[Token(Token = "0x6002D40")]
	public ShowFloatingWindowResult()
	{
	}
}
