using System;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000236")]
public class IRailFloatingWindowImpl : RailObject, IRailFloatingWindow
{
	[Token(Token = "0x60027B7")]
	[Address(RVA = "0x3682B0", Offset = "0x366AB0", Length = "0x26")]
	internal IRailFloatingWindowImpl(IntPtr cPtr)
	{
	}

	[Address(RVA = "0x367A50", Offset = "0x366250", Length = "0x53")]
	[Token(Token = "0x60027B8")]
	~IRailFloatingWindowImpl()
	{
	}

	[Address(RVA = "0xD25BD0", Offset = "0xD243D0", Length = "0x73")]
	[Token(Token = "0x60027B9")]
	public virtual RailResult AsyncShowRailFloatingWindow(EnumRailWindowType window_type, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD25AE0", Offset = "0xD242E0", Length = "0x73")]
	[Token(Token = "0x60027BA")]
	public virtual RailResult AsyncCloseRailFloatingWindow(EnumRailWindowType window_type, string user_data)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD25E70", Offset = "0xD24670", Length = "0x128")]
	[Token(Token = "0x60027BB")]
	public virtual RailResult SetNotifyWindowPosition(EnumRailNotifyWindowType window_type, RailWindowLayout layout)
	{
		return default(RailResult);
	}

	[Address(RVA = "0xD25C50", Offset = "0xD24450", Length = "0x13A")]
	[Token(Token = "0x60027BC")]
	public virtual RailResult AsyncShowStoreWindow(ulong id, RailStoreOptions options, string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027BD")]
	[Address(RVA = "0xD25D90", Offset = "0xD24590", Length = "0x55")]
	public virtual bool IsFloatingWindowAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60027BE")]
	[Address(RVA = "0xD25B60", Offset = "0xD24360", Length = "0x65")]
	public virtual RailResult AsyncShowDefaultGameStoreWindow(string user_data)
	{
		return default(RailResult);
	}

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0xD25DF0", Offset = "0xD245F0", Length = "0x75")]
	public virtual RailResult SetNotifyWindowEnable(EnumRailNotifyWindowType window_type, bool enable)
	{
		return default(RailResult);
	}
}
