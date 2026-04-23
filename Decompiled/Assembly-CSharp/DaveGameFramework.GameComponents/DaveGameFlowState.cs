using Cpp2ILInjected;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C3")]
public enum DaveGameFlowState
{
	[Token(Token = "0x40019F1")]
	None,
	[Token(Token = "0x40019F2")]
	Loading,
	[Token(Token = "0x40019F3")]
	Preparing,
	[Token(Token = "0x40019F4")]
	Playing,
	[Token(Token = "0x40019F5")]
	Pause,
	[Token(Token = "0x40019F6")]
	Ending,
	[Token(Token = "0x40019F7")]
	Finished
}
