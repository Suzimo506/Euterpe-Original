using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000291")]
public enum EnumRailMouseActionType
{
	[Token(Token = "0x4001034")]
	kRailMouseButtonActionUnknown,
	[Token(Token = "0x4001035")]
	kRailMouseButtonActionLeftButtonDown,
	[Token(Token = "0x4001036")]
	kRailMouseButtonActionLeftButtonUp,
	[Token(Token = "0x4001037")]
	kRailMouseButtonActionLeftButtonDoubleClick,
	[Token(Token = "0x4001038")]
	kRailMouseButtonActionRightButtonDown,
	[Token(Token = "0x4001039")]
	kRailMouseButtonActionRightButtonUp,
	[Token(Token = "0x400103A")]
	kRailMouseButtonActionRightButtonDoubleClick,
	[Token(Token = "0x400103B")]
	kRailMouseButtonActionMiddleButtonDown,
	[Token(Token = "0x400103C")]
	kRailMouseButtonActionMiddleButtonUp,
	[Token(Token = "0x400103D")]
	kRailMouseButtonActionMiddleButtonDoubleClick,
	[Token(Token = "0x400103E")]
	kRailMouseButtonActionMove
}
