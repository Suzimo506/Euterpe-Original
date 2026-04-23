using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000301")]
public class RailTextInputImeWindowOption
{
	[Token(Token = "0x400122B")]
	[FieldOffset(Offset = "0x10")]
	public RailWindowPosition position;

	[Token(Token = "0x400122C")]
	[FieldOffset(Offset = "0x18")]
	public bool show_rail_ime_window;

	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x2721500", Offset = "0x271FD00", Length = "0x64")]
	public RailTextInputImeWindowOption()
	{
	}
}
