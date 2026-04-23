using Cpp2ILInjected;
using DaveGameFramework.GameComponents.AnimaControl;

namespace DaveGameFramework.GameComponents;

[Token(Token = "0x20004C4")]
public struct DaveGameFishHandleState
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40019F8")]
	public FishType fishType;

	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x40019F9")]
	public DishType dishType;
}
