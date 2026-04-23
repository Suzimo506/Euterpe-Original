using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002BE")]
public class ShowNotifyWindow : EventBase
{
	[Token(Token = "0x400119D")]
	[FieldOffset(Offset = "0x30")]
	public EnumRailNotifyWindowType window_type;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400119E")]
	public string json_content;

	[Token(Token = "0x6002D41")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public ShowNotifyWindow()
	{
	}
}
