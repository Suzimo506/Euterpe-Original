using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x2000294")]
public class RailCallBackHelper
{
	[Token(Token = "0x4001041")]
	private static RailCallBackHelper instance_;

	[Token(Token = "0x4001042")]
	private static readonly object locker_;

	[Token(Token = "0x4001043")]
	private static Dictionary<RAILEventID, RailEventCallBackHandler> eventHandlers_;

	[Token(Token = "0x4001044")]
	private static RailEventCallBackFunction delegate_;

	[Token(Token = "0x1700041B")]
	public static RailCallBackHelper Instance
	{
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x699490", Offset = "0x697C90", Length = "0x1CA")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6002CEE")]
	private RailCallBackHelper()
	{
	}

	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x698BB0", Offset = "0x6973B0", Length = "0x269")]
	public void RegisterCallback(RAILEventID event_id, RailEventCallBackHandler handler)
	{
	}

	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x699110", Offset = "0x697910", Length = "0x29B")]
	public void UnregisterCallback(RAILEventID event_id, RailEventCallBackHandler handler)
	{
	}

	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x698F50", Offset = "0x697750", Length = "0x1B6")]
	public void UnregisterCallback(RAILEventID event_id)
	{
	}

	[Address(RVA = "0x698E20", Offset = "0x697620", Length = "0x12F")]
	[Token(Token = "0x6002CF3")]
	public void UnregisterAllCallback()
	{
	}

	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x691500", Offset = "0x68FD00", Length = "0x111C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1BA90", Offset = "0x1AE90")]
	public static void OnRailCallBack(RAILEventID event_id, IntPtr data)
	{
	}
}
