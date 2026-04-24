using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002FE")]
public class RailIMEHelperTextInputCompositionState : EventBase
{
	[Token(Token = "0x4001223")]
	[FieldOffset(Offset = "0x30")]
	public string composition_text;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001224")]
	public RailIMETextInputCompositionState composition_state;

	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x37E160", Offset = "0x37C960", Length = "0x7")]
	public RailIMEHelperTextInputCompositionState()
	{
	}
}
