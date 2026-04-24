using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000300")]
public enum RailIMETextInputCompositionState
{
	[Token(Token = "0x4001227")]
	kTextInputCompositionStateNone,
	[Token(Token = "0x4001228")]
	kTextInputCompositionStateStart,
	[Token(Token = "0x4001229")]
	kTextInputCompositionStateUpdate,
	[Token(Token = "0x400122A")]
	kTextInputCompositionStateEnd
}
