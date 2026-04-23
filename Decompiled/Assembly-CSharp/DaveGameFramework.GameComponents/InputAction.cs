using Cpp2ILInjected;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C9")]
public enum InputAction
{
	[Token(Token = "0x4001A16")]
	None = -1,
	[Token(Token = "0x4001A17")]
	AirButtonDown,
	[Token(Token = "0x4001A18")]
	AirButtonPress,
	[Token(Token = "0x4001A19")]
	AirButtonUp,
	[Token(Token = "0x4001A1A")]
	GroundButtonDown,
	[Token(Token = "0x4001A1B")]
	GroundButtonPress,
	[Token(Token = "0x4001A1C")]
	GroundButtonUp
}
