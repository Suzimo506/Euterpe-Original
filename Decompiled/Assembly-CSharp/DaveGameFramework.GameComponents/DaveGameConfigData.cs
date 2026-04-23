using Cpp2ILInjected;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C5")]
public struct DaveGameConfigData
{
	[Token(Token = "0x40019FA")]
	[FieldOffset(Offset = "0x0")]
	public string mapName;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x40019FB")]
	public int level;
}
