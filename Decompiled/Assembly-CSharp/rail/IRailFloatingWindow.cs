using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x20002B5")]
public interface IRailFloatingWindow
{
	[Token(Token = "0x6002D37")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncShowRailFloatingWindow(EnumRailWindowType window_type, string user_data);

	[Token(Token = "0x6002D38")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncCloseRailFloatingWindow(EnumRailWindowType window_type, string user_data);

	[Token(Token = "0x6002D39")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult SetNotifyWindowPosition(EnumRailNotifyWindowType window_type, RailWindowLayout layout);

	[Token(Token = "0x6002D3A")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncShowStoreWindow(ulong id, RailStoreOptions options, string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D3B")]
	bool IsFloatingWindowAvailable();

	[Token(Token = "0x6002D3C")]
	[Address(RVA = "0x0", Length = "0x0")]
	RailResult AsyncShowDefaultGameStoreWindow(string user_data);

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6002D3D")]
	RailResult SetNotifyWindowEnable(EnumRailNotifyWindowType window_type, bool enable);
}
