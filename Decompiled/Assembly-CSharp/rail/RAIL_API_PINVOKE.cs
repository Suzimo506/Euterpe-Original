using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace rail;

[Token(Token = "0x200022A")]
internal class RAIL_API_PINVOKE
{
	[Token(Token = "0x2000AC4")]
	protected class SWIGExceptionHelper
	{
		[Token(Token = "0x2000E08")]
		public delegate void ExceptionDelegate(string message);

		[Token(Token = "0x2000E09")]
		public delegate void ExceptionArgumentDelegate(string message, string paramName);

		[Token(Token = "0x4003873")]
		private static ExceptionDelegate applicationDelegate;

		[Token(Token = "0x4003874")]
		private static ExceptionDelegate arithmeticDelegate;

		[Token(Token = "0x4003875")]
		private static ExceptionDelegate divideByZeroDelegate;

		[Token(Token = "0x4003876")]
		private static ExceptionDelegate indexOutOfRangeDelegate;

		[Token(Token = "0x4003877")]
		private static ExceptionDelegate invalidCastDelegate;

		[Token(Token = "0x4003878")]
		private static ExceptionDelegate invalidOperationDelegate;

		[Token(Token = "0x4003879")]
		private static ExceptionDelegate ioDelegate;

		[Token(Token = "0x400387A")]
		private static ExceptionDelegate nullReferenceDelegate;

		[Token(Token = "0x400387B")]
		private static ExceptionDelegate outOfMemoryDelegate;

		[Token(Token = "0x400387C")]
		private static ExceptionDelegate overflowDelegate;

		[Token(Token = "0x400387D")]
		private static ExceptionDelegate systemDelegate;

		[Token(Token = "0x400387E")]
		private static ExceptionArgumentDelegate argumentDelegate;

		[Token(Token = "0x400387F")]
		private static ExceptionArgumentDelegate argumentNullDelegate;

		[Token(Token = "0x4003880")]
		private static ExceptionArgumentDelegate argumentOutOfRangeDelegate;

		[PreserveSig]
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x6BC2F0", Offset = "0x6BAAF0", Length = "0x194")]
		public static extern void SWIGRegisterExceptionCallbacks_rail_api(ExceptionDelegate applicationDelegate, ExceptionDelegate arithmeticDelegate, ExceptionDelegate divideByZeroDelegate, ExceptionDelegate indexOutOfRangeDelegate, ExceptionDelegate invalidCastDelegate, ExceptionDelegate invalidOperationDelegate, ExceptionDelegate ioDelegate, ExceptionDelegate nullReferenceDelegate, ExceptionDelegate outOfMemoryDelegate, ExceptionDelegate overflowDelegate, ExceptionDelegate systemExceptionDelegate);

		[PreserveSig]
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x6BC230", Offset = "0x6BAA30", Length = "0xB3")]
		public static extern void SWIGRegisterExceptionCallbacksArgument_rail_api(ExceptionArgumentDelegate argumentDelegate, ExceptionArgumentDelegate argumentNullDelegate, ExceptionArgumentDelegate argumentOutOfRangeDelegate);

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x174B0", Offset = "0x168B0")]
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x6BC490", Offset = "0x6BAC90", Length = "0x8E")]
		private static void SetPendingApplicationException(string message)
		{
		}

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18CC0", Offset = "0x180C0")]
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x6BC790", Offset = "0x6BAF90", Length = "0x8E")]
		private static void SetPendingArithmeticException(string message)
		{
		}

		[Address(RVA = "0x6BC820", Offset = "0x6BB020", Length = "0x8E")]
		[Token(Token = "0x6005C0D")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x18DE0", Offset = "0x181E0")]
		private static void SetPendingDivideByZeroException(string message)
		{
		}

		[Address(RVA = "0x6BC940", Offset = "0x6BB140", Length = "0x8E")]
		[Token(Token = "0x6005C0E")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19320", Offset = "0x18720")]
		private static void SetPendingIndexOutOfRangeException(string message)
		{
		}

		[Token(Token = "0x6005C0F")]
		[Address(RVA = "0x6BC9D0", Offset = "0x6BB1D0", Length = "0x8E")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x194B0", Offset = "0x188B0")]
		private static void SetPendingInvalidCastException(string message)
		{
		}

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x195B0", Offset = "0x189B0")]
		[Token(Token = "0x6005C10")]
		[Address(RVA = "0x6BCA60", Offset = "0x6BB260", Length = "0x8E")]
		private static void SetPendingInvalidOperationException(string message)
		{
		}

		[Address(RVA = "0x6BC8B0", Offset = "0x6BB0B0", Length = "0x8E")]
		[Token(Token = "0x6005C11")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19780", Offset = "0x18B80")]
		private static void SetPendingIOException(string message)
		{
		}

		[Token(Token = "0x6005C12")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19900", Offset = "0x18D00")]
		[Address(RVA = "0x6BCAF0", Offset = "0x6BB2F0", Length = "0x8E")]
		private static void SetPendingNullReferenceException(string message)
		{
		}

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19A30", Offset = "0x18E30")]
		[Address(RVA = "0x6BCB80", Offset = "0x6BB380", Length = "0x8E")]
		[Token(Token = "0x6005C13")]
		private static void SetPendingOutOfMemoryException(string message)
		{
		}

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19AE0", Offset = "0x18EE0")]
		[Address(RVA = "0x6BCC10", Offset = "0x6BB410", Length = "0x8E")]
		[Token(Token = "0x6005C14")]
		private static void SetPendingOverflowException(string message)
		{
		}

		[Address(RVA = "0x6BCCA0", Offset = "0x6BB4A0", Length = "0x8E")]
		[Token(Token = "0x6005C15")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19C90", Offset = "0x19090")]
		private static void SetPendingSystemException(string message)
		{
		}

		[Address(RVA = "0x6BC520", Offset = "0x6BAD20", Length = "0xA4")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x19E00", Offset = "0x19200")]
		[Token(Token = "0x6005C16")]
		private static void SetPendingArgumentException(string message, string paramName)
		{
		}

		[Token(Token = "0x6005C17")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B530", Offset = "0x1A930")]
		[Address(RVA = "0x6BC5D0", Offset = "0x6BADD0", Length = "0xDD")]
		private static void SetPendingArgumentNullException(string message, string paramName)
		{
		}

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B640", Offset = "0x1AA40")]
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x6BC6B0", Offset = "0x6BAEB0", Length = "0xDD")]
		private static void SetPendingArgumentOutOfRangeException(string message, string paramName)
		{
		}

		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x6BCD30", Offset = "0x6BB530", Length = "0x6C4")]
		static SWIGExceptionHelper()
		{
		}

		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public SWIGExceptionHelper()
		{
		}
	}

	[Token(Token = "0x2000AC5")]
	public class SWIGPendingException
	{
		[Token(Token = "0x4003881")]
		[ThreadStatic]
		private static Exception pendingException;

		[Token(Token = "0x4003882")]
		private static int numExceptionsPending;

		[Token(Token = "0x17000A58")]
		public static bool Pending
		{
			[Token(Token = "0x6005C1B")]
			[Address(RVA = "0x6BD7A0", Offset = "0x6BBFA0", Length = "0x98")]
			get
			{
				return default(bool);
			}
		}

		[Address(RVA = "0x6BD5A0", Offset = "0x6BBDA0", Length = "0x1F3")]
		[Token(Token = "0x6005C1C")]
		public static void Set(Exception e)
		{
		}

		[Address(RVA = "0x6BD400", Offset = "0x6BBC00", Length = "0x19D")]
		[Token(Token = "0x6005C1D")]
		public static Exception Retrieve()
		{
			return null;
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005C1E")]
		public SWIGPendingException()
		{
		}
	}

	[Token(Token = "0x2000AC6")]
	protected class SWIGStringHelper
	{
		[Token(Token = "0x2000E0A")]
		public delegate string SWIGStringDelegate(string message);

		[Token(Token = "0x4003883")]
		private static SWIGStringDelegate stringDelegate;

		[PreserveSig]
		[Address(RVA = "0x6BDC70", Offset = "0x6BC470", Length = "0x82")]
		[Token(Token = "0x6005C20")]
		public static extern void SWIGRegisterStringCallback_rail_api(SWIGStringDelegate stringDelegate);

		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x1B990", Offset = "0x1AD90")]
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0x475C50", Offset = "0x474450", Length = "0x4")]
		private static string CreateString(string cString)
		{
			return null;
		}

		[Token(Token = "0x6005C22")]
		[Address(RVA = "0x6BDD00", Offset = "0x6BC500", Length = "0xF7")]
		static SWIGStringHelper()
		{
		}

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x6005C23")]
		public SWIGStringHelper()
		{
		}
	}

	[Token(Token = "0x4000FC8")]
	public const string dll_path = "rail_api64";

	[Token(Token = "0x4000FC9")]
	protected static SWIGExceptionHelper swigExceptionHelper;

	[Token(Token = "0x4000FCA")]
	protected static SWIGStringHelper swigStringHelper;

	[Address(RVA = "0x3E75A0", Offset = "0x3E5DA0", Length = "0x8E")]
	[Token(Token = "0x60014A0")]
	static RAIL_API_PINVOKE()
	{
	}

	[PreserveSig]
	[Token(Token = "0x60014A1")]
	[Address(RVA = "0x3E5370", Offset = "0x3E3B70", Length = "0x65")]
	public static extern int USE_MANUAL_ALLOC_get();

	[PreserveSig]
	[Token(Token = "0x60014A2")]
	[Address(RVA = "0x3AAA10", Offset = "0x3A9210", Length = "0x65")]
	public static extern int RAIL_SDK_PACKING_get();

	[PreserveSig]
	[Token(Token = "0x60014A3")]
	[Address(RVA = "0x4157D0", Offset = "0x413FD0", Length = "0x65")]
	public static extern IntPtr new_RailString__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014A4")]
	[Address(RVA = "0x415840", Offset = "0x414040", Length = "0x9C")]
	public static extern IntPtr new_RailString__SWIG_1(string jarg1);

	[PreserveSig]
	[Token(Token = "0x60014A5")]
	[Address(RVA = "0x3DB5B0", Offset = "0x3D9DB0", Length = "0xA8")]
	public static extern IntPtr RailString_SetValue(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DB660", Offset = "0x3D9E60", Length = "0xA7")]
	[Token(Token = "0x60014A6")]
	public static extern void RailString_assign(IntPtr jarg1, string jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x3DB710", Offset = "0x3D9F10", Length = "0x78")]
	public static extern IntPtr RailString_c_str(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DB810", Offset = "0x3DA010", Length = "0x78")]
	[Token(Token = "0x60014A8")]
	public static extern IntPtr RailString_data(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x3DB790", Offset = "0x3D9F90", Length = "0x78")]
	public static extern void RailString_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x3DB890", Offset = "0x3DA090", Length = "0x78")]
	public static extern uint RailString_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x3F6A30", Offset = "0x3F5230", Length = "0x78")]
	public static extern void delete_RailString(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x412CC0", Offset = "0x4114C0", Length = "0x65")]
	public static extern IntPtr new_RailID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x412D30", Offset = "0x411530", Length = "0x78")]
	public static extern IntPtr new_RailID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x3D1EA0", Offset = "0x3D06A0", Length = "0x87")]
	public static extern void RailID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x3D1E20", Offset = "0x3D0620", Length = "0x78")]
	public static extern ulong RailID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D1DA0", Offset = "0x3D05A0", Length = "0x7D")]
	[Token(Token = "0x60014B0")]
	public static extern bool RailID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D1D20", Offset = "0x3D0520", Length = "0x78")]
	[Token(Token = "0x60014B1")]
	public static extern int RailID_GetDomain(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F52B0", Offset = "0x3F3AB0", Length = "0x78")]
	[Token(Token = "0x60014B2")]
	public static extern void delete_RailID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014B3")]
	[Address(RVA = "0x412360", Offset = "0x410B60", Length = "0x65")]
	public static extern IntPtr new_RailGameID__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4123D0", Offset = "0x410BD0", Length = "0x78")]
	[Token(Token = "0x60014B4")]
	public static extern IntPtr new_RailGameID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D05F0", Offset = "0x3CEDF0", Length = "0x87")]
	[Token(Token = "0x60014B5")]
	public static extern void RailGameID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60014B6")]
	[Address(RVA = "0x3D0570", Offset = "0x3CED70", Length = "0x78")]
	public static extern ulong RailGameID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014B7")]
	[Address(RVA = "0x3D04F0", Offset = "0x3CECF0", Length = "0x7D")]
	public static extern bool RailGameID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4DB0", Offset = "0x3F35B0", Length = "0x78")]
	[Token(Token = "0x60014B8")]
	public static extern void delete_RailGameID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014B9")]
	[Address(RVA = "0x406240", Offset = "0x404A40", Length = "0x65")]
	public static extern IntPtr new_RailDlcID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014BA")]
	[Address(RVA = "0x4062B0", Offset = "0x404AB0", Length = "0x78")]
	public static extern IntPtr new_RailDlcID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x60014BB")]
	[Address(RVA = "0x3BC860", Offset = "0x3BB060", Length = "0x87")]
	public static extern void RailDlcID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60014BC")]
	[Address(RVA = "0x3BC7E0", Offset = "0x3BAFE0", Length = "0x78")]
	public static extern ulong RailDlcID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BC760", Offset = "0x3BAF60", Length = "0x7D")]
	[Token(Token = "0x60014BD")]
	public static extern bool RailDlcID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EE6B0", Offset = "0x3ECEB0", Length = "0x78")]
	[Token(Token = "0x60014BE")]
	public static extern void delete_RailDlcID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416AB0", Offset = "0x4152B0", Length = "0x65")]
	[Token(Token = "0x60014BF")]
	public static extern IntPtr new_RailVoiceChannelID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014C0")]
	[Address(RVA = "0x416B20", Offset = "0x415320", Length = "0x78")]
	public static extern IntPtr new_RailVoiceChannelID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x3DF300", Offset = "0x3DDB00", Length = "0x87")]
	public static extern void RailVoiceChannelID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DF280", Offset = "0x3DDA80", Length = "0x78")]
	[Token(Token = "0x60014C2")]
	public static extern ulong RailVoiceChannelID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x3DF200", Offset = "0x3DDA00", Length = "0x7D")]
	public static extern bool RailVoiceChannelID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7430", Offset = "0x3F5C30", Length = "0x78")]
	[Token(Token = "0x60014C4")]
	public static extern void delete_RailVoiceChannelID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x416E70", Offset = "0x415670", Length = "0x65")]
	public static extern IntPtr new_RailZoneID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x416EE0", Offset = "0x4156E0", Length = "0x78")]
	public static extern IntPtr new_RailZoneID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DFC00", Offset = "0x3DE400", Length = "0x87")]
	[Token(Token = "0x60014C7")]
	public static extern void RailZoneID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x3DFB80", Offset = "0x3DE380", Length = "0x78")]
	public static extern ulong RailZoneID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DFB00", Offset = "0x3DE300", Length = "0x7D")]
	[Token(Token = "0x60014C9")]
	public static extern bool RailZoneID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7630", Offset = "0x3F5E30", Length = "0x78")]
	[Token(Token = "0x60014CA")]
	public static extern void delete_RailZoneID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D4270", Offset = "0x3D2A70", Length = "0x9B")]
	[Token(Token = "0x60014CB")]
	public static extern void RailKeyValue_key_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D41F0", Offset = "0x3D29F0", Length = "0x78")]
	[Token(Token = "0x60014CC")]
	public static extern IntPtr RailKeyValue_key_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D4390", Offset = "0x3D2B90", Length = "0x9B")]
	[Token(Token = "0x60014CD")]
	public static extern void RailKeyValue_value_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D4310", Offset = "0x3D2B10", Length = "0x78")]
	[Token(Token = "0x60014CE")]
	public static extern IntPtr RailKeyValue_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x413BC0", Offset = "0x4123C0", Length = "0x65")]
	public static extern IntPtr new_RailKeyValue();

	[PreserveSig]
	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x3F5AB0", Offset = "0x3F42B0", Length = "0x78")]
	public static extern void delete_RailKeyValue(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x414950", Offset = "0x413150", Length = "0x65")]
	public static extern IntPtr new_RailSessionTicket();

	[PreserveSig]
	[Address(RVA = "0x3D7E80", Offset = "0x3D6680", Length = "0x9B")]
	[Token(Token = "0x60014D2")]
	public static extern void RailSessionTicket_ticket_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x3D7E00", Offset = "0x3D6600", Length = "0x78")]
	public static extern IntPtr RailSessionTicket_ticket_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x3F6230", Offset = "0x3F4A30", Length = "0x78")]
	public static extern void delete_RailSessionTicket(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390530", Offset = "0x38ED30", Length = "0x78")]
	[Token(Token = "0x60014D5")]
	public static extern ulong IRailComponent_GetComponentVersion(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014D6")]
	[Address(RVA = "0x3905B0", Offset = "0x38EDB0", Length = "0x78")]
	public static extern void IRailComponent_Release(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x3E9030", Offset = "0x3E7830", Length = "0x78")]
	public static extern void delete_EventBase(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3880B0", Offset = "0x3868B0", Length = "0x78")]
	[Token(Token = "0x60014D8")]
	public static extern int EventBase_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x3881B0", Offset = "0x3869B0", Length = "0x87")]
	public static extern void EventBase_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x388130", Offset = "0x386930", Length = "0x78")]
	[Token(Token = "0x60014DA")]
	public static extern IntPtr EventBase_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x388020", Offset = "0x386820", Length = "0x87")]
	public static extern void EventBase_game_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x387FA0", Offset = "0x3867A0", Length = "0x78")]
	public static extern IntPtr EventBase_game_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x3883D0", Offset = "0x386BD0", Length = "0x9B")]
	public static extern void EventBase_user_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x388350", Offset = "0x386B50", Length = "0x78")]
	public static extern IntPtr EventBase_user_data_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3882C0", Offset = "0x386AC0", Length = "0x85")]
	[Token(Token = "0x60014DF")]
	public static extern void EventBase_result_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x388240", Offset = "0x386A40", Length = "0x78")]
	[Token(Token = "0x60014E0")]
	public static extern int EventBase_result_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390C00", Offset = "0x38F400", Length = "0x91")]
	[Token(Token = "0x60014E1")]
	public static extern void IRailEvent_OnRailEvent(IntPtr jarg1, int jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60014E2")]
	[Address(RVA = "0x3E9FB0", Offset = "0x3E87B0", Length = "0x78")]
	public static extern void delete_IRailEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x402B70", Offset = "0x401370", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailProductItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x402BE0", Offset = "0x4013E0", Length = "0x76")]
	[Token(Token = "0x60014E4")]
	public static extern IntPtr new_RailArrayRailProductItem__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x402C60", Offset = "0x401460", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailProductItem__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60014E6")]
	[Address(RVA = "0x402CF0", Offset = "0x4014F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailProductItem__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2D00", Offset = "0x3B1500", Length = "0x87")]
	[Token(Token = "0x60014E7")]
	public static extern IntPtr RailArrayRailProductItem_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED5B0", Offset = "0x3EBDB0", Length = "0x78")]
	[Token(Token = "0x60014E8")]
	public static extern void delete_RailArrayRailProductItem(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2D90", Offset = "0x3B1590", Length = "0x93")]
	[Token(Token = "0x60014E9")]
	public static extern void RailArrayRailProductItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60014EA")]
	[Address(RVA = "0x3B2E30", Offset = "0x3B1630", Length = "0x78")]
	public static extern IntPtr RailArrayRailProductItem_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014EB")]
	[Address(RVA = "0x3B30E0", Offset = "0x3B18E0", Length = "0x78")]
	public static extern uint RailArrayRailProductItem_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2C70", Offset = "0x3B1470", Length = "0x85")]
	[Token(Token = "0x60014EC")]
	public static extern IntPtr RailArrayRailProductItem_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60014ED")]
	[Address(RVA = "0x3B3050", Offset = "0x3B1850", Length = "0x85")]
	public static extern void RailArrayRailProductItem_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B17C0", Length = "0x87")]
	[Token(Token = "0x60014EE")]
	public static extern void RailArrayRailProductItem_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B2EB0", Offset = "0x3B16B0", Length = "0x78")]
	[Token(Token = "0x60014EF")]
	public static extern void RailArrayRailProductItem_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2F30", Offset = "0x3B1730", Length = "0x85")]
	[Token(Token = "0x60014F0")]
	public static extern void RailArrayRailProductItem_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x400770", Offset = "0x3FEF70", Length = "0x65")]
	[Token(Token = "0x60014F1")]
	public static extern IntPtr new_RailArrayPlayerPersonalInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x4007E0", Offset = "0x3FEFE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayPlayerPersonalInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x400860", Offset = "0x3FF060", Length = "0x85")]
	[Token(Token = "0x60014F3")]
	public static extern IntPtr new_RailArrayPlayerPersonalInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4008F0", Offset = "0x3FF0F0", Length = "0x78")]
	[Token(Token = "0x60014F4")]
	public static extern IntPtr new_RailArrayPlayerPersonalInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AD420", Offset = "0x3ABC20", Length = "0x87")]
	[Token(Token = "0x60014F5")]
	public static extern IntPtr RailArrayPlayerPersonalInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECCB0", Offset = "0x3EB4B0", Length = "0x78")]
	[Token(Token = "0x60014F6")]
	public static extern void delete_RailArrayPlayerPersonalInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014F7")]
	[Address(RVA = "0x3AD4B0", Offset = "0x3ABCB0", Length = "0x93")]
	public static extern void RailArrayPlayerPersonalInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60014F8")]
	[Address(RVA = "0x3AD550", Offset = "0x3ABD50", Length = "0x78")]
	public static extern IntPtr RailArrayPlayerPersonalInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014F9")]
	[Address(RVA = "0x3AD800", Offset = "0x3AC000", Length = "0x78")]
	public static extern uint RailArrayPlayerPersonalInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014FA")]
	[Address(RVA = "0x3AD390", Offset = "0x3ABB90", Length = "0x85")]
	public static extern IntPtr RailArrayPlayerPersonalInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x3AD770", Offset = "0x3ABF70", Length = "0x85")]
	public static extern void RailArrayPlayerPersonalInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AD6E0", Offset = "0x3ABEE0", Length = "0x87")]
	[Token(Token = "0x60014FC")]
	public static extern void RailArrayPlayerPersonalInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60014FD")]
	[Address(RVA = "0x3AD5D0", Offset = "0x3ABDD0", Length = "0x78")]
	public static extern void RailArrayPlayerPersonalInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60014FE")]
	[Address(RVA = "0x3AD650", Offset = "0x3ABE50", Length = "0x85")]
	public static extern void RailArrayPlayerPersonalInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60014FF")]
	[Address(RVA = "0x4053F0", Offset = "0x403BF0", Length = "0x65")]
	public static extern IntPtr new_RailArrayuint64_t__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001500")]
	[Address(RVA = "0x405460", Offset = "0x403C60", Length = "0x76")]
	public static extern IntPtr new_RailArrayuint64_t__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001501")]
	[Address(RVA = "0x4054E0", Offset = "0x403CE0", Length = "0x85")]
	public static extern IntPtr new_RailArrayuint64_t__SWIG_2(out ulong jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x405570", Offset = "0x403D70", Length = "0x78")]
	[Token(Token = "0x6001502")]
	public static extern IntPtr new_RailArrayuint64_t__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8FC0", Offset = "0x3B77C0", Length = "0x87")]
	[Token(Token = "0x6001503")]
	public static extern IntPtr RailArrayuint64_t_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001504")]
	[Address(RVA = "0x3EDFB0", Offset = "0x3EC7B0", Length = "0x78")]
	public static extern void delete_RailArrayuint64_t(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001505")]
	[Address(RVA = "0x3B9050", Offset = "0x3B7850", Length = "0x93")]
	public static extern void RailArrayuint64_t_assign(IntPtr jarg1, out ulong jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001506")]
	[Address(RVA = "0x3B90F0", Offset = "0x3B78F0", Length = "0x78")]
	public static extern IntPtr RailArrayuint64_t_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B93A0", Offset = "0x3B7BA0", Length = "0x78")]
	[Token(Token = "0x6001507")]
	public static extern uint RailArrayuint64_t_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8F30", Offset = "0x3B7730", Length = "0x85")]
	[Token(Token = "0x6001508")]
	public static extern IntPtr RailArrayuint64_t_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9310", Offset = "0x3B7B10", Length = "0x85")]
	[Token(Token = "0x6001509")]
	public static extern void RailArrayuint64_t_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9280", Offset = "0x3B7A80", Length = "0x87")]
	[Token(Token = "0x600150A")]
	public static extern void RailArrayuint64_t_push_back(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9170", Offset = "0x3B7970", Length = "0x78")]
	[Token(Token = "0x600150B")]
	public static extern void RailArrayuint64_t_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B91F0", Offset = "0x3B79F0", Length = "0x85")]
	[Token(Token = "0x600150C")]
	public static extern void RailArrayuint64_t_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600150D")]
	[Address(RVA = "0x4051F0", Offset = "0x4039F0", Length = "0x65")]
	public static extern IntPtr new_RailArrayuint32_t__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x405260", Offset = "0x403A60", Length = "0x76")]
	[Token(Token = "0x600150E")]
	public static extern IntPtr new_RailArrayuint32_t__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600150F")]
	[Address(RVA = "0x4052E0", Offset = "0x403AE0", Length = "0x85")]
	public static extern IntPtr new_RailArrayuint32_t__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001510")]
	[Address(RVA = "0x405370", Offset = "0x403B70", Length = "0x78")]
	public static extern IntPtr new_RailArrayuint32_t__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001511")]
	[Address(RVA = "0x3B8AD0", Offset = "0x3B72D0", Length = "0x87")]
	public static extern IntPtr RailArrayuint32_t_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001512")]
	[Address(RVA = "0x3EDF30", Offset = "0x3EC730", Length = "0x78")]
	public static extern void delete_RailArrayuint32_t(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001513")]
	[Address(RVA = "0x3B8B60", Offset = "0x3B7360", Length = "0x93")]
	public static extern void RailArrayuint32_t_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B8C00", Offset = "0x3B7400", Length = "0x78")]
	[Token(Token = "0x6001514")]
	public static extern IntPtr RailArrayuint32_t_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8EB0", Offset = "0x3B76B0", Length = "0x78")]
	[Token(Token = "0x6001515")]
	public static extern uint RailArrayuint32_t_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8A40", Offset = "0x3B7240", Length = "0x85")]
	[Token(Token = "0x6001516")]
	public static extern IntPtr RailArrayuint32_t_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x3B8E20", Offset = "0x3B7620", Length = "0x85")]
	public static extern void RailArrayuint32_t_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x3B8D90", Offset = "0x3B7590", Length = "0x85")]
	public static extern void RailArrayuint32_t_push_back(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x3B8C80", Offset = "0x3B7480", Length = "0x78")]
	public static extern void RailArrayuint32_t_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8D00", Offset = "0x3B7500", Length = "0x85")]
	[Token(Token = "0x600151A")]
	public static extern void RailArrayuint32_t_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x400970", Offset = "0x3FF170", Length = "0x65")]
	[Token(Token = "0x600151B")]
	public static extern IntPtr new_RailArrayRailAssetInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4009E0", Offset = "0x3FF1E0", Length = "0x76")]
	[Token(Token = "0x600151C")]
	public static extern IntPtr new_RailArrayRailAssetInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x400A60", Offset = "0x3FF260", Length = "0x85")]
	[Token(Token = "0x600151D")]
	public static extern IntPtr new_RailArrayRailAssetInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x400AF0", Offset = "0x3FF2F0", Length = "0x78")]
	[Token(Token = "0x600151E")]
	public static extern IntPtr new_RailArrayRailAssetInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AD910", Offset = "0x3AC110", Length = "0x87")]
	[Token(Token = "0x600151F")]
	public static extern IntPtr RailArrayRailAssetInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECD30", Offset = "0x3EB530", Length = "0x78")]
	[Token(Token = "0x6001520")]
	public static extern void delete_RailArrayRailAssetInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001521")]
	[Address(RVA = "0x3AD9A0", Offset = "0x3AC1A0", Length = "0x93")]
	public static extern void RailArrayRailAssetInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001522")]
	[Address(RVA = "0x3ADA40", Offset = "0x3AC240", Length = "0x78")]
	public static extern IntPtr RailArrayRailAssetInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ADCF0", Offset = "0x3AC4F0", Length = "0x78")]
	[Token(Token = "0x6001523")]
	public static extern uint RailArrayRailAssetInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AD880", Offset = "0x3AC080", Length = "0x85")]
	[Token(Token = "0x6001524")]
	public static extern IntPtr RailArrayRailAssetInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ADC60", Offset = "0x3AC460", Length = "0x85")]
	[Token(Token = "0x6001525")]
	public static extern void RailArrayRailAssetInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ADBD0", Offset = "0x3AC3D0", Length = "0x87")]
	[Token(Token = "0x6001526")]
	public static extern void RailArrayRailAssetInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001527")]
	[Address(RVA = "0x3ADAC0", Offset = "0x3AC2C0", Length = "0x78")]
	public static extern void RailArrayRailAssetInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001528")]
	[Address(RVA = "0x3ADB40", Offset = "0x3AC340", Length = "0x85")]
	public static extern void RailArrayRailAssetInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001529")]
	[Address(RVA = "0x400B70", Offset = "0x3FF370", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailAssetItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x400BE0", Offset = "0x3FF3E0", Length = "0x76")]
	[Token(Token = "0x600152A")]
	public static extern IntPtr new_RailArrayRailAssetItem__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600152B")]
	[Address(RVA = "0x400C60", Offset = "0x3FF460", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailAssetItem__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600152C")]
	[Address(RVA = "0x400CF0", Offset = "0x3FF4F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailAssetItem__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600152D")]
	[Address(RVA = "0x3ADE00", Offset = "0x3AC600", Length = "0x87")]
	public static extern IntPtr RailArrayRailAssetItem_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECDB0", Offset = "0x3EB5B0", Length = "0x78")]
	[Token(Token = "0x600152E")]
	public static extern void delete_RailArrayRailAssetItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600152F")]
	[Address(RVA = "0x3ADE90", Offset = "0x3AC690", Length = "0x93")]
	public static extern void RailArrayRailAssetItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3ADF30", Offset = "0x3AC730", Length = "0x78")]
	[Token(Token = "0x6001530")]
	public static extern IntPtr RailArrayRailAssetItem_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE1E0", Offset = "0x3AC9E0", Length = "0x78")]
	[Token(Token = "0x6001531")]
	public static extern uint RailArrayRailAssetItem_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001532")]
	[Address(RVA = "0x3ADD70", Offset = "0x3AC570", Length = "0x85")]
	public static extern IntPtr RailArrayRailAssetItem_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AE150", Offset = "0x3AC950", Length = "0x85")]
	[Token(Token = "0x6001533")]
	public static extern void RailArrayRailAssetItem_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001534")]
	[Address(RVA = "0x3AE0C0", Offset = "0x3AC8C0", Length = "0x87")]
	public static extern void RailArrayRailAssetItem_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ADFB0", Offset = "0x3AC7B0", Length = "0x78")]
	[Token(Token = "0x6001535")]
	public static extern void RailArrayRailAssetItem_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE030", Offset = "0x3AC830", Length = "0x85")]
	[Token(Token = "0x6001536")]
	public static extern void RailArrayRailAssetItem_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404DF0", Offset = "0x4035F0", Length = "0x65")]
	[Token(Token = "0x6001537")]
	public static extern IntPtr new_RailArrayRoomMemberInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x404E60", Offset = "0x403660", Length = "0x76")]
	[Token(Token = "0x6001538")]
	public static extern IntPtr new_RailArrayRoomMemberInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x404EE0", Offset = "0x4036E0", Length = "0x85")]
	[Token(Token = "0x6001539")]
	public static extern IntPtr new_RailArrayRoomMemberInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600153A")]
	[Address(RVA = "0x404F70", Offset = "0x403770", Length = "0x78")]
	public static extern IntPtr new_RailArrayRoomMemberInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B80F0", Offset = "0x3B68F0", Length = "0x87")]
	[Token(Token = "0x600153B")]
	public static extern IntPtr RailArrayRoomMemberInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600153C")]
	[Address(RVA = "0x3EDE30", Offset = "0x3EC630", Length = "0x78")]
	public static extern void delete_RailArrayRoomMemberInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600153D")]
	[Address(RVA = "0x3B8180", Offset = "0x3B6980", Length = "0x93")]
	public static extern void RailArrayRoomMemberInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x600153E")]
	[Address(RVA = "0x3B8220", Offset = "0x3B6A20", Length = "0x78")]
	public static extern IntPtr RailArrayRoomMemberInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B84D0", Offset = "0x3B6CD0", Length = "0x78")]
	[Token(Token = "0x600153F")]
	public static extern uint RailArrayRoomMemberInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8060", Offset = "0x3B6860", Length = "0x85")]
	[Token(Token = "0x6001540")]
	public static extern IntPtr RailArrayRoomMemberInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001541")]
	[Address(RVA = "0x3B8440", Offset = "0x3B6C40", Length = "0x85")]
	public static extern void RailArrayRoomMemberInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B83B0", Offset = "0x3B6BB0", Length = "0x87")]
	[Token(Token = "0x6001542")]
	public static extern void RailArrayRoomMemberInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001543")]
	[Address(RVA = "0x3B82A0", Offset = "0x3B6AA0", Length = "0x78")]
	public static extern void RailArrayRoomMemberInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8320", Offset = "0x3B6B20", Length = "0x85")]
	[Token(Token = "0x6001544")]
	public static extern void RailArrayRoomMemberInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001545")]
	[Address(RVA = "0x400F70", Offset = "0x3FF770", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailCoinInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x400FE0", Offset = "0x3FF7E0", Length = "0x76")]
	[Token(Token = "0x6001546")]
	public static extern IntPtr new_RailArrayRailCoinInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x401060", Offset = "0x3FF860", Length = "0x85")]
	[Token(Token = "0x6001547")]
	public static extern IntPtr new_RailArrayRailCoinInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001548")]
	[Address(RVA = "0x4010F0", Offset = "0x3FF8F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailCoinInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE7E0", Offset = "0x3ACFE0", Length = "0x87")]
	[Token(Token = "0x6001549")]
	public static extern IntPtr RailArrayRailCoinInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600154A")]
	[Address(RVA = "0x3ECEB0", Offset = "0x3EB6B0", Length = "0x78")]
	public static extern void delete_RailArrayRailCoinInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600154B")]
	[Address(RVA = "0x3AE870", Offset = "0x3AD070", Length = "0x93")]
	public static extern void RailArrayRailCoinInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3AE910", Offset = "0x3AD110", Length = "0x78")]
	[Token(Token = "0x600154C")]
	public static extern IntPtr RailArrayRailCoinInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600154D")]
	[Address(RVA = "0x3AEBC0", Offset = "0x3AD3C0", Length = "0x78")]
	public static extern uint RailArrayRailCoinInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE750", Offset = "0x3ACF50", Length = "0x85")]
	[Token(Token = "0x600154E")]
	public static extern IntPtr RailArrayRailCoinInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AEB30", Offset = "0x3AD330", Length = "0x85")]
	[Token(Token = "0x600154F")]
	public static extern void RailArrayRailCoinInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AEAA0", Offset = "0x3AD2A0", Length = "0x87")]
	[Token(Token = "0x6001550")]
	public static extern void RailArrayRailCoinInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AE990", Offset = "0x3AD190", Length = "0x78")]
	[Token(Token = "0x6001551")]
	public static extern void RailArrayRailCoinInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AEA10", Offset = "0x3AD210", Length = "0x85")]
	[Token(Token = "0x6001552")]
	public static extern void RailArrayRailCoinInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001553")]
	[Address(RVA = "0x400D70", Offset = "0x3FF570", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailAssetProperty__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001554")]
	[Address(RVA = "0x400DE0", Offset = "0x3FF5E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailAssetProperty__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001555")]
	[Address(RVA = "0x400E60", Offset = "0x3FF660", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailAssetProperty__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001556")]
	[Address(RVA = "0x400EF0", Offset = "0x3FF6F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailAssetProperty__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001557")]
	[Address(RVA = "0x3AE2F0", Offset = "0x3ACAF0", Length = "0x87")]
	public static extern IntPtr RailArrayRailAssetProperty_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECE30", Offset = "0x3EB630", Length = "0x78")]
	[Token(Token = "0x6001558")]
	public static extern void delete_RailArrayRailAssetProperty(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE380", Offset = "0x3ACB80", Length = "0x93")]
	[Token(Token = "0x6001559")]
	public static extern void RailArrayRailAssetProperty_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3AE420", Offset = "0x3ACC20", Length = "0x78")]
	[Token(Token = "0x600155A")]
	public static extern IntPtr RailArrayRailAssetProperty_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE6D0", Offset = "0x3ACED0", Length = "0x78")]
	[Token(Token = "0x600155B")]
	public static extern uint RailArrayRailAssetProperty_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600155C")]
	[Address(RVA = "0x3AE260", Offset = "0x3ACA60", Length = "0x85")]
	public static extern IntPtr RailArrayRailAssetProperty_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600155D")]
	[Address(RVA = "0x3AE640", Offset = "0x3ACE40", Length = "0x85")]
	public static extern void RailArrayRailAssetProperty_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600155E")]
	[Address(RVA = "0x3AE5B0", Offset = "0x3ACDB0", Length = "0x87")]
	public static extern void RailArrayRailAssetProperty_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AE4A0", Offset = "0x3ACCA0", Length = "0x78")]
	[Token(Token = "0x600155F")]
	public static extern void RailArrayRailAssetProperty_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AE520", Offset = "0x3ACD20", Length = "0x85")]
	[Token(Token = "0x6001560")]
	public static extern void RailArrayRailAssetProperty_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FFF70", Offset = "0x3FE770", Length = "0x65")]
	[Token(Token = "0x6001561")]
	public static extern IntPtr new_RailArrayGameServerListFilterKey__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001562")]
	[Address(RVA = "0x3FFFE0", Offset = "0x3FE7E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayGameServerListFilterKey__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001563")]
	[Address(RVA = "0x400060", Offset = "0x3FE860", Length = "0x85")]
	public static extern IntPtr new_RailArrayGameServerListFilterKey__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4000F0", Offset = "0x3FE8F0", Length = "0x78")]
	[Token(Token = "0x6001564")]
	public static extern IntPtr new_RailArrayGameServerListFilterKey__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC060", Offset = "0x3AA860", Length = "0x87")]
	[Token(Token = "0x6001565")]
	public static extern IntPtr RailArrayGameServerListFilterKey_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001566")]
	[Address(RVA = "0x3ECAB0", Offset = "0x3EB2B0", Length = "0x78")]
	public static extern void delete_RailArrayGameServerListFilterKey(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001567")]
	[Address(RVA = "0x3AC0F0", Offset = "0x3AA8F0", Length = "0x93")]
	public static extern void RailArrayGameServerListFilterKey_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3AC190", Offset = "0x3AA990", Length = "0x78")]
	[Token(Token = "0x6001568")]
	public static extern IntPtr RailArrayGameServerListFilterKey_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC440", Offset = "0x3AAC40", Length = "0x78")]
	[Token(Token = "0x6001569")]
	public static extern uint RailArrayGameServerListFilterKey_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ABFD0", Offset = "0x3AA7D0", Length = "0x85")]
	[Token(Token = "0x600156A")]
	public static extern IntPtr RailArrayGameServerListFilterKey_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AC3B0", Offset = "0x3AABB0", Length = "0x85")]
	[Token(Token = "0x600156B")]
	public static extern void RailArrayGameServerListFilterKey_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600156C")]
	[Address(RVA = "0x3AC320", Offset = "0x3AAB20", Length = "0x87")]
	public static extern void RailArrayGameServerListFilterKey_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AC210", Offset = "0x3AAA10", Length = "0x78")]
	[Token(Token = "0x600156D")]
	public static extern void RailArrayGameServerListFilterKey_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC290", Offset = "0x3AAA90", Length = "0x85")]
	[Token(Token = "0x600156E")]
	public static extern void RailArrayGameServerListFilterKey_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403770", Offset = "0x401F70", Length = "0x65")]
	[Token(Token = "0x600156F")]
	public static extern IntPtr new_RailArrayRailStreamFileInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4037E0", Offset = "0x401FE0", Length = "0x76")]
	[Token(Token = "0x6001570")]
	public static extern IntPtr new_RailArrayRailStreamFileInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001571")]
	[Address(RVA = "0x403860", Offset = "0x402060", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailStreamFileInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4038F0", Offset = "0x4020F0", Length = "0x78")]
	[Token(Token = "0x6001572")]
	public static extern IntPtr new_RailArrayRailStreamFileInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4AA0", Offset = "0x3B32A0", Length = "0x87")]
	[Token(Token = "0x6001573")]
	public static extern IntPtr RailArrayRailStreamFileInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED8B0", Offset = "0x3EC0B0", Length = "0x78")]
	[Token(Token = "0x6001574")]
	public static extern void delete_RailArrayRailStreamFileInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4B30", Offset = "0x3B3330", Length = "0x93")]
	[Token(Token = "0x6001575")]
	public static extern void RailArrayRailStreamFileInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B4BD0", Offset = "0x3B33D0", Length = "0x78")]
	[Token(Token = "0x6001576")]
	public static extern IntPtr RailArrayRailStreamFileInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4E80", Offset = "0x3B3680", Length = "0x78")]
	[Token(Token = "0x6001577")]
	public static extern uint RailArrayRailStreamFileInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001578")]
	[Address(RVA = "0x3B4A10", Offset = "0x3B3210", Length = "0x85")]
	public static extern IntPtr RailArrayRailStreamFileInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001579")]
	[Address(RVA = "0x3B4DF0", Offset = "0x3B35F0", Length = "0x85")]
	public static extern void RailArrayRailStreamFileInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B4D60", Offset = "0x3B3560", Length = "0x87")]
	[Token(Token = "0x600157A")]
	public static extern void RailArrayRailStreamFileInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600157B")]
	[Address(RVA = "0x3B4C50", Offset = "0x3B3450", Length = "0x78")]
	public static extern void RailArrayRailStreamFileInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4CD0", Offset = "0x3B34D0", Length = "0x85")]
	[Token(Token = "0x600157C")]
	public static extern void RailArrayRailStreamFileInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600157D")]
	[Address(RVA = "0x4047F0", Offset = "0x402FF0", Length = "0x65")]
	public static extern IntPtr new_RailArrayRoomInfoListFilter__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x404860", Offset = "0x403060", Length = "0x76")]
	[Token(Token = "0x600157E")]
	public static extern IntPtr new_RailArrayRoomInfoListFilter__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x4048E0", Offset = "0x4030E0", Length = "0x85")]
	[Token(Token = "0x600157F")]
	public static extern IntPtr new_RailArrayRoomInfoListFilter__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404970", Offset = "0x403170", Length = "0x78")]
	[Token(Token = "0x6001580")]
	public static extern IntPtr new_RailArrayRoomInfoListFilter__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7220", Offset = "0x3B5A20", Length = "0x87")]
	[Token(Token = "0x6001581")]
	public static extern IntPtr RailArrayRoomInfoListFilter_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EDCB0", Offset = "0x3EC4B0", Length = "0x78")]
	[Token(Token = "0x6001582")]
	public static extern void delete_RailArrayRoomInfoListFilter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001583")]
	[Address(RVA = "0x3B72B0", Offset = "0x3B5AB0", Length = "0x93")]
	public static extern void RailArrayRoomInfoListFilter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B7350", Offset = "0x3B5B50", Length = "0x78")]
	[Token(Token = "0x6001584")]
	public static extern IntPtr RailArrayRoomInfoListFilter_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7600", Offset = "0x3B5E00", Length = "0x78")]
	[Token(Token = "0x6001585")]
	public static extern uint RailArrayRoomInfoListFilter_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001586")]
	[Address(RVA = "0x3B7190", Offset = "0x3B5990", Length = "0x85")]
	public static extern IntPtr RailArrayRoomInfoListFilter_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B7570", Offset = "0x3B5D70", Length = "0x85")]
	[Token(Token = "0x6001587")]
	public static extern void RailArrayRoomInfoListFilter_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B74E0", Offset = "0x3B5CE0", Length = "0x87")]
	[Token(Token = "0x6001588")]
	public static extern void RailArrayRoomInfoListFilter_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B73D0", Offset = "0x3B5BD0", Length = "0x78")]
	[Token(Token = "0x6001589")]
	public static extern void RailArrayRoomInfoListFilter_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7450", Offset = "0x3B5C50", Length = "0x85")]
	[Token(Token = "0x600158A")]
	public static extern void RailArrayRoomInfoListFilter_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x400170", Offset = "0x3FE970", Length = "0x65")]
	[Token(Token = "0x600158B")]
	public static extern IntPtr new_RailArrayGameServerListFilter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600158C")]
	[Address(RVA = "0x4001E0", Offset = "0x3FE9E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayGameServerListFilter__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600158D")]
	[Address(RVA = "0x400260", Offset = "0x3FEA60", Length = "0x85")]
	public static extern IntPtr new_RailArrayGameServerListFilter__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600158E")]
	[Address(RVA = "0x4002F0", Offset = "0x3FEAF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayGameServerListFilter__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600158F")]
	[Address(RVA = "0x3AC550", Offset = "0x3AAD50", Length = "0x87")]
	public static extern IntPtr RailArrayGameServerListFilter_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECB30", Offset = "0x3EB330", Length = "0x78")]
	[Token(Token = "0x6001590")]
	public static extern void delete_RailArrayGameServerListFilter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC5E0", Offset = "0x3AADE0", Length = "0x93")]
	[Token(Token = "0x6001591")]
	public static extern void RailArrayGameServerListFilter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3AC680", Offset = "0x3AAE80", Length = "0x78")]
	[Token(Token = "0x6001592")]
	public static extern IntPtr RailArrayGameServerListFilter_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC930", Offset = "0x3AB130", Length = "0x78")]
	[Token(Token = "0x6001593")]
	public static extern uint RailArrayGameServerListFilter_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC4C0", Offset = "0x3AACC0", Length = "0x85")]
	[Token(Token = "0x6001594")]
	public static extern IntPtr RailArrayGameServerListFilter_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001595")]
	[Address(RVA = "0x3AC8A0", Offset = "0x3AB0A0", Length = "0x85")]
	public static extern void RailArrayGameServerListFilter_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001596")]
	[Address(RVA = "0x3AC810", Offset = "0x3AB010", Length = "0x87")]
	public static extern void RailArrayGameServerListFilter_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001597")]
	[Address(RVA = "0x3AC700", Offset = "0x3AAF00", Length = "0x78")]
	public static extern void RailArrayGameServerListFilter_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AC780", Offset = "0x3AAF80", Length = "0x85")]
	[Token(Token = "0x6001598")]
	public static extern void RailArrayGameServerListFilter_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FF5F0", Offset = "0x3FDDF0", Length = "0x65")]
	[Token(Token = "0x6001599")]
	public static extern IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600159A")]
	[Address(RVA = "0x3FF660", Offset = "0x3FDE60", Length = "0x76")]
	public static extern IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF6E0", Offset = "0x3FDEE0", Length = "0x85")]
	[Token(Token = "0x600159B")]
	public static extern IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600159C")]
	[Address(RVA = "0x3FF770", Offset = "0x3FDF70", Length = "0x78")]
	public static extern IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600159D")]
	[Address(RVA = "0x3AACA0", Offset = "0x3A94A0", Length = "0x87")]
	public static extern IntPtr RailArrayEnumRailSpaceWorkType_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600159E")]
	[Address(RVA = "0x3EC8B0", Offset = "0x3EB0B0", Length = "0x78")]
	public static extern void delete_RailArrayEnumRailSpaceWorkType(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AAD30", Offset = "0x3A9530", Length = "0x93")]
	[Token(Token = "0x600159F")]
	public static extern void RailArrayEnumRailSpaceWorkType_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3AADD0", Offset = "0x3A95D0", Length = "0x78")]
	[Token(Token = "0x60015A0")]
	public static extern IntPtr RailArrayEnumRailSpaceWorkType_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB080", Offset = "0x3A9880", Length = "0x78")]
	[Token(Token = "0x60015A1")]
	public static extern uint RailArrayEnumRailSpaceWorkType_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015A2")]
	[Address(RVA = "0x3AAC10", Offset = "0x3A9410", Length = "0x85")]
	public static extern IntPtr RailArrayEnumRailSpaceWorkType_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AAFF0", Offset = "0x3A97F0", Length = "0x85")]
	[Token(Token = "0x60015A3")]
	public static extern void RailArrayEnumRailSpaceWorkType_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015A4")]
	[Address(RVA = "0x3AAF60", Offset = "0x3A9760", Length = "0x87")]
	public static extern void RailArrayEnumRailSpaceWorkType_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015A5")]
	[Address(RVA = "0x3AAE50", Offset = "0x3A9650", Length = "0x78")]
	public static extern void RailArrayEnumRailSpaceWorkType_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AAED0", Offset = "0x3A96D0", Length = "0x85")]
	[Token(Token = "0x60015A6")]
	public static extern void RailArrayEnumRailSpaceWorkType_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015A7")]
	[Address(RVA = "0x3FF7F0", Offset = "0x3FDFF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayEnumRailSpaceWorkType__SWIG_4(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF870", Offset = "0x3FE070", Length = "0x65")]
	[Token(Token = "0x60015A8")]
	public static extern IntPtr new_RailArrayEnumRailUsersLimits__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60015A9")]
	[Address(RVA = "0x3FF8E0", Offset = "0x3FE0E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayEnumRailUsersLimits__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF960", Offset = "0x3FE160", Length = "0x85")]
	[Token(Token = "0x60015AA")]
	public static extern IntPtr new_RailArrayEnumRailUsersLimits__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FF9F0", Offset = "0x3FE1F0", Length = "0x78")]
	[Token(Token = "0x60015AB")]
	public static extern IntPtr new_RailArrayEnumRailUsersLimits__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015AC")]
	[Address(RVA = "0x3AB190", Offset = "0x3A9990", Length = "0x87")]
	public static extern IntPtr RailArrayEnumRailUsersLimits_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015AD")]
	[Address(RVA = "0x3EC930", Offset = "0x3EB130", Length = "0x78")]
	public static extern void delete_RailArrayEnumRailUsersLimits(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015AE")]
	[Address(RVA = "0x3AB220", Offset = "0x3A9A20", Length = "0x93")]
	public static extern void RailArrayEnumRailUsersLimits_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60015AF")]
	[Address(RVA = "0x3AB2C0", Offset = "0x3A9AC0", Length = "0x78")]
	public static extern IntPtr RailArrayEnumRailUsersLimits_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB570", Offset = "0x3A9D70", Length = "0x78")]
	[Token(Token = "0x60015B0")]
	public static extern uint RailArrayEnumRailUsersLimits_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015B1")]
	[Address(RVA = "0x3AB100", Offset = "0x3A9900", Length = "0x85")]
	public static extern IntPtr RailArrayEnumRailUsersLimits_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AB4E0", Offset = "0x3A9CE0", Length = "0x85")]
	[Token(Token = "0x60015B2")]
	public static extern void RailArrayEnumRailUsersLimits_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AB450", Offset = "0x3A9C50", Length = "0x87")]
	[Token(Token = "0x60015B3")]
	public static extern void RailArrayEnumRailUsersLimits_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AB340", Offset = "0x3A9B40", Length = "0x78")]
	[Token(Token = "0x60015B4")]
	public static extern void RailArrayEnumRailUsersLimits_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB3C0", Offset = "0x3A9BC0", Length = "0x85")]
	[Token(Token = "0x60015B5")]
	public static extern void RailArrayEnumRailUsersLimits_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FFA70", Offset = "0x3FE270", Length = "0x78")]
	[Token(Token = "0x60015B6")]
	public static extern IntPtr new_RailArrayEnumRailUsersLimits__SWIG_4(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015B7")]
	[Address(RVA = "0x403DF0", Offset = "0x4025F0", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x403E60", Offset = "0x402660", Length = "0x76")]
	[Token(Token = "0x60015B8")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60015B9")]
	[Address(RVA = "0x403EE0", Offset = "0x4026E0", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403F70", Offset = "0x402770", Length = "0x78")]
	[Token(Token = "0x60015BA")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadProgress__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015BB")]
	[Address(RVA = "0x3B5970", Offset = "0x3B4170", Length = "0x87")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadProgress_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015BC")]
	[Address(RVA = "0x3EDA30", Offset = "0x3EC230", Length = "0x78")]
	public static extern void delete_RailArrayRailUserSpaceDownloadProgress(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015BD")]
	[Address(RVA = "0x3B5A00", Offset = "0x3B4200", Length = "0x93")]
	public static extern void RailArrayRailUserSpaceDownloadProgress_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B5AA0", Offset = "0x3B42A0", Length = "0x78")]
	[Token(Token = "0x60015BE")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadProgress_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5D50", Offset = "0x3B4550", Length = "0x78")]
	[Token(Token = "0x60015BF")]
	public static extern uint RailArrayRailUserSpaceDownloadProgress_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015C0")]
	[Address(RVA = "0x3B58E0", Offset = "0x3B40E0", Length = "0x85")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadProgress_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015C1")]
	[Address(RVA = "0x3B5CC0", Offset = "0x3B44C0", Length = "0x85")]
	public static extern void RailArrayRailUserSpaceDownloadProgress_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B5C30", Offset = "0x3B4430", Length = "0x87")]
	[Token(Token = "0x60015C2")]
	public static extern void RailArrayRailUserSpaceDownloadProgress_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015C3")]
	[Address(RVA = "0x3B5B20", Offset = "0x3B4320", Length = "0x78")]
	public static extern void RailArrayRailUserSpaceDownloadProgress_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5BA0", Offset = "0x3B43A0", Length = "0x85")]
	[Token(Token = "0x60015C4")]
	public static extern void RailArrayRailUserSpaceDownloadProgress_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x402770", Offset = "0x400F70", Length = "0x65")]
	[Token(Token = "0x60015C5")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x4027E0", Offset = "0x400FE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x402860", Offset = "0x401060", Length = "0x85")]
	[Token(Token = "0x60015C7")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4028F0", Offset = "0x4010F0", Length = "0x78")]
	[Token(Token = "0x60015C8")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsGameItem__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2320", Offset = "0x3B0B20", Length = "0x87")]
	[Token(Token = "0x60015C9")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsGameItem_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED4B0", Offset = "0x3EBCB0", Length = "0x78")]
	[Token(Token = "0x60015CA")]
	public static extern void delete_RailArrayRailPlayedWithFriendsGameItem(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B23B0", Offset = "0x3B0BB0", Length = "0x93")]
	[Token(Token = "0x60015CB")]
	public static extern void RailArrayRailPlayedWithFriendsGameItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60015CC")]
	[Address(RVA = "0x3B2450", Offset = "0x3B0C50", Length = "0x78")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsGameItem_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2700", Offset = "0x3B0F00", Length = "0x78")]
	[Token(Token = "0x60015CD")]
	public static extern uint RailArrayRailPlayedWithFriendsGameItem_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015CE")]
	[Address(RVA = "0x3B2290", Offset = "0x3B0A90", Length = "0x85")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsGameItem_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015CF")]
	[Address(RVA = "0x3B2670", Offset = "0x3B0E70", Length = "0x85")]
	public static extern void RailArrayRailPlayedWithFriendsGameItem_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B25E0", Offset = "0x3B0DE0", Length = "0x87")]
	[Token(Token = "0x60015D0")]
	public static extern void RailArrayRailPlayedWithFriendsGameItem_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015D1")]
	[Address(RVA = "0x3B24D0", Offset = "0x3B0CD0", Length = "0x78")]
	public static extern void RailArrayRailPlayedWithFriendsGameItem_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2550", Offset = "0x3B0D50", Length = "0x85")]
	[Token(Token = "0x60015D2")]
	public static extern void RailArrayRailPlayedWithFriendsGameItem_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404FF0", Offset = "0x4037F0", Length = "0x65")]
	[Token(Token = "0x60015D3")]
	public static extern IntPtr new_RailArraySpaceWorkID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60015D4")]
	[Address(RVA = "0x405060", Offset = "0x403860", Length = "0x76")]
	public static extern IntPtr new_RailArraySpaceWorkID__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x4050E0", Offset = "0x4038E0", Length = "0x85")]
	[Token(Token = "0x60015D5")]
	public static extern IntPtr new_RailArraySpaceWorkID__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015D6")]
	[Address(RVA = "0x405170", Offset = "0x403970", Length = "0x78")]
	public static extern IntPtr new_RailArraySpaceWorkID__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B85E0", Offset = "0x3B6DE0", Length = "0x87")]
	[Token(Token = "0x60015D7")]
	public static extern IntPtr RailArraySpaceWorkID_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EDEB0", Offset = "0x3EC6B0", Length = "0x78")]
	[Token(Token = "0x60015D8")]
	public static extern void delete_RailArraySpaceWorkID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B8670", Offset = "0x3B6E70", Length = "0x93")]
	[Token(Token = "0x60015D9")]
	public static extern void RailArraySpaceWorkID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60015DA")]
	[Address(RVA = "0x3B8710", Offset = "0x3B6F10", Length = "0x78")]
	public static extern IntPtr RailArraySpaceWorkID_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x3B89C0", Offset = "0x3B71C0", Length = "0x78")]
	public static extern uint RailArraySpaceWorkID_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015DC")]
	[Address(RVA = "0x3B8550", Offset = "0x3B6D50", Length = "0x85")]
	public static extern IntPtr RailArraySpaceWorkID_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015DD")]
	[Address(RVA = "0x3B8930", Offset = "0x3B7130", Length = "0x85")]
	public static extern void RailArraySpaceWorkID_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015DE")]
	[Address(RVA = "0x3B88A0", Offset = "0x3B70A0", Length = "0x87")]
	public static extern void RailArraySpaceWorkID_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015DF")]
	[Address(RVA = "0x3B8790", Offset = "0x3B6F90", Length = "0x78")]
	public static extern void RailArraySpaceWorkID_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015E0")]
	[Address(RVA = "0x3B8810", Offset = "0x3B7010", Length = "0x85")]
	public static extern void RailArraySpaceWorkID_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015E1")]
	[Address(RVA = "0x4049F0", Offset = "0x4031F0", Length = "0x65")]
	public static extern IntPtr new_RailArrayRoomInfoListSorter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60015E2")]
	[Address(RVA = "0x404A60", Offset = "0x403260", Length = "0x76")]
	public static extern IntPtr new_RailArrayRoomInfoListSorter__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60015E3")]
	[Address(RVA = "0x404AE0", Offset = "0x4032E0", Length = "0x85")]
	public static extern IntPtr new_RailArrayRoomInfoListSorter__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404B70", Offset = "0x403370", Length = "0x78")]
	[Token(Token = "0x60015E4")]
	public static extern IntPtr new_RailArrayRoomInfoListSorter__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7710", Offset = "0x3B5F10", Length = "0x87")]
	[Token(Token = "0x60015E5")]
	public static extern IntPtr RailArrayRoomInfoListSorter_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EDD30", Offset = "0x3EC530", Length = "0x78")]
	[Token(Token = "0x60015E6")]
	public static extern void delete_RailArrayRoomInfoListSorter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015E7")]
	[Address(RVA = "0x3B77A0", Offset = "0x3B5FA0", Length = "0x93")]
	public static extern void RailArrayRoomInfoListSorter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B7840", Offset = "0x3B6040", Length = "0x78")]
	[Token(Token = "0x60015E8")]
	public static extern IntPtr RailArrayRoomInfoListSorter_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015E9")]
	[Address(RVA = "0x3B7AF0", Offset = "0x3B62F0", Length = "0x78")]
	public static extern uint RailArrayRoomInfoListSorter_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7680", Offset = "0x3B5E80", Length = "0x85")]
	[Token(Token = "0x60015EA")]
	public static extern IntPtr RailArrayRoomInfoListSorter_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015EB")]
	[Address(RVA = "0x3B7A60", Offset = "0x3B6260", Length = "0x85")]
	public static extern void RailArrayRoomInfoListSorter_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60015EC")]
	[Address(RVA = "0x3B79D0", Offset = "0x3B61D0", Length = "0x87")]
	public static extern void RailArrayRoomInfoListSorter_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60015ED")]
	[Address(RVA = "0x3B78C0", Offset = "0x3B60C0", Length = "0x78")]
	public static extern void RailArrayRoomInfoListSorter_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015EE")]
	[Address(RVA = "0x3B7940", Offset = "0x3B6140", Length = "0x85")]
	public static extern void RailArrayRoomInfoListSorter_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x402370", Offset = "0x400B70", Length = "0x65")]
	[Token(Token = "0x60015EF")]
	public static extern IntPtr new_RailArrayRailKeyValueResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60015F0")]
	[Address(RVA = "0x4023E0", Offset = "0x400BE0", Length = "0x44")]
	public static extern IntPtr new_RailArrayRailKeyValueResult__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x402460", Offset = "0x400C60", Length = "0x85")]
	[Token(Token = "0x60015F1")]
	public static extern IntPtr new_RailArrayRailKeyValueResult__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4024F0", Offset = "0x400CF0", Length = "0x78")]
	[Token(Token = "0x60015F2")]
	public static extern IntPtr new_RailArrayRailKeyValueResult__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1940", Offset = "0x3B0140", Length = "0x87")]
	[Token(Token = "0x60015F3")]
	public static extern IntPtr RailArrayRailKeyValueResult_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED3B0", Offset = "0x3EBBB0", Length = "0x78")]
	[Token(Token = "0x60015F4")]
	public static extern void delete_RailArrayRailKeyValueResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B19D0", Offset = "0x3B01D0", Length = "0x93")]
	[Token(Token = "0x60015F5")]
	public static extern void RailArrayRailKeyValueResult_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B1A70", Offset = "0x3B0270", Length = "0x78")]
	[Token(Token = "0x60015F6")]
	public static extern IntPtr RailArrayRailKeyValueResult_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1D20", Offset = "0x3B0520", Length = "0x78")]
	[Token(Token = "0x60015F7")]
	public static extern uint RailArrayRailKeyValueResult_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B18B0", Offset = "0x3B00B0", Length = "0x85")]
	[Token(Token = "0x60015F8")]
	public static extern IntPtr RailArrayRailKeyValueResult_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1C90", Offset = "0x3B0490", Length = "0x85")]
	[Token(Token = "0x60015F9")]
	public static extern void RailArrayRailKeyValueResult_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1C00", Offset = "0x3B0400", Length = "0x87")]
	[Token(Token = "0x60015FA")]
	public static extern void RailArrayRailKeyValueResult_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1AF0", Offset = "0x3B02F0", Length = "0x78")]
	[Token(Token = "0x60015FB")]
	public static extern void RailArrayRailKeyValueResult_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60015FC")]
	[Address(RVA = "0x3B1B70", Offset = "0x3B0370", Length = "0x85")]
	public static extern void RailArrayRailKeyValueResult_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403970", Offset = "0x402170", Length = "0x65")]
	[Token(Token = "0x60015FD")]
	public static extern IntPtr new_RailArrayRailString__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4039E0", Offset = "0x4021E0", Length = "0x76")]
	[Token(Token = "0x60015FE")]
	public static extern IntPtr new_RailArrayRailString__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60015FF")]
	[Address(RVA = "0x403A60", Offset = "0x402260", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailString__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403AF0", Offset = "0x4022F0", Length = "0x78")]
	[Token(Token = "0x6001600")]
	public static extern IntPtr new_RailArrayRailString__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4F90", Offset = "0x3B3790", Length = "0x87")]
	[Token(Token = "0x6001601")]
	public static extern IntPtr RailArrayRailString_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001602")]
	[Address(RVA = "0x3ED930", Offset = "0x3EC130", Length = "0x78")]
	public static extern void delete_RailArrayRailString(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5020", Offset = "0x3B3820", Length = "0x93")]
	[Token(Token = "0x6001603")]
	public static extern void RailArrayRailString_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001604")]
	[Address(RVA = "0x3B50C0", Offset = "0x3B38C0", Length = "0x78")]
	public static extern IntPtr RailArrayRailString_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5370", Offset = "0x3B3B70", Length = "0x78")]
	[Token(Token = "0x6001605")]
	public static extern uint RailArrayRailString_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4F00", Offset = "0x3B3700", Length = "0x85")]
	[Token(Token = "0x6001606")]
	public static extern IntPtr RailArrayRailString_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B52E0", Offset = "0x3B3AE0", Length = "0x85")]
	[Token(Token = "0x6001607")]
	public static extern void RailArrayRailString_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B5250", Offset = "0x3B3A50", Length = "0x87")]
	[Token(Token = "0x6001608")]
	public static extern void RailArrayRailString_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001609")]
	[Address(RVA = "0x3B5140", Offset = "0x3B3940", Length = "0x78")]
	public static extern void RailArrayRailString_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B51C0", Offset = "0x3B39C0", Length = "0x85")]
	[Token(Token = "0x600160A")]
	public static extern void RailArrayRailString_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600160B")]
	[Address(RVA = "0x403B70", Offset = "0x402370", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailString__SWIG_4(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600160C")]
	[Address(RVA = "0x403FF0", Offset = "0x4027F0", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600160D")]
	[Address(RVA = "0x404060", Offset = "0x402860", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x4040E0", Offset = "0x4028E0", Length = "0x85")]
	[Token(Token = "0x600160E")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404170", Offset = "0x402970", Length = "0x78")]
	[Token(Token = "0x600160F")]
	public static extern IntPtr new_RailArrayRailUserSpaceDownloadResult__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5E60", Offset = "0x3B4660", Length = "0x87")]
	[Token(Token = "0x6001610")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadResult_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EDAB0", Offset = "0x3EC2B0", Length = "0x78")]
	[Token(Token = "0x6001611")]
	public static extern void delete_RailArrayRailUserSpaceDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5EF0", Offset = "0x3B46F0", Length = "0x93")]
	[Token(Token = "0x6001612")]
	public static extern void RailArrayRailUserSpaceDownloadResult_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B5F90", Offset = "0x3B4790", Length = "0x78")]
	[Token(Token = "0x6001613")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadResult_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001614")]
	[Address(RVA = "0x3B6240", Offset = "0x3B4A40", Length = "0x78")]
	public static extern uint RailArrayRailUserSpaceDownloadResult_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5DD0", Offset = "0x3B45D0", Length = "0x85")]
	[Token(Token = "0x6001615")]
	public static extern IntPtr RailArrayRailUserSpaceDownloadResult_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B61B0", Offset = "0x3B49B0", Length = "0x85")]
	[Token(Token = "0x6001616")]
	public static extern void RailArrayRailUserSpaceDownloadResult_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001617")]
	[Address(RVA = "0x3B6120", Offset = "0x3B4920", Length = "0x87")]
	public static extern void RailArrayRailUserSpaceDownloadResult_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001618")]
	[Address(RVA = "0x3B6010", Offset = "0x3B4810", Length = "0x78")]
	public static extern void RailArrayRailUserSpaceDownloadResult_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6090", Offset = "0x3B4890", Length = "0x85")]
	[Token(Token = "0x6001619")]
	public static extern void RailArrayRailUserSpaceDownloadResult_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x401570", Offset = "0x3FFD70", Length = "0x65")]
	[Token(Token = "0x600161A")]
	public static extern IntPtr new_RailArrayRailFriendInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4015E0", Offset = "0x3FFDE0", Length = "0x76")]
	[Token(Token = "0x600161B")]
	public static extern IntPtr new_RailArrayRailFriendInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600161C")]
	[Address(RVA = "0x401660", Offset = "0x3FFE60", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailFriendInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600161D")]
	[Address(RVA = "0x4016F0", Offset = "0x3FFEF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailFriendInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AF6B0", Offset = "0x3ADEB0", Length = "0x87")]
	[Token(Token = "0x600161E")]
	public static extern IntPtr RailArrayRailFriendInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600161F")]
	[Address(RVA = "0x3ED030", Offset = "0x3EB830", Length = "0x78")]
	public static extern void delete_RailArrayRailFriendInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001620")]
	[Address(RVA = "0x3AF740", Offset = "0x3ADF40", Length = "0x93")]
	public static extern void RailArrayRailFriendInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001621")]
	[Address(RVA = "0x3AF7E0", Offset = "0x3ADFE0", Length = "0x78")]
	public static extern IntPtr RailArrayRailFriendInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AFA90", Offset = "0x3AE290", Length = "0x78")]
	[Token(Token = "0x6001622")]
	public static extern uint RailArrayRailFriendInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AF620", Offset = "0x3ADE20", Length = "0x85")]
	[Token(Token = "0x6001623")]
	public static extern IntPtr RailArrayRailFriendInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001624")]
	[Address(RVA = "0x3AFA00", Offset = "0x3AE200", Length = "0x85")]
	public static extern void RailArrayRailFriendInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AF970", Offset = "0x3AE170", Length = "0x87")]
	[Token(Token = "0x6001625")]
	public static extern void RailArrayRailFriendInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AF860", Offset = "0x3AE060", Length = "0x78")]
	[Token(Token = "0x6001626")]
	public static extern void RailArrayRailFriendInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AF8E0", Offset = "0x3AE0E0", Length = "0x85")]
	[Token(Token = "0x6001627")]
	public static extern void RailArrayRailFriendInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4043F0", Offset = "0x402BF0", Length = "0x65")]
	[Token(Token = "0x6001628")]
	public static extern IntPtr new_RailArrayRailZoneID__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x404460", Offset = "0x402C60", Length = "0x76")]
	[Token(Token = "0x6001629")]
	public static extern IntPtr new_RailArrayRailZoneID__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x4044E0", Offset = "0x402CE0", Length = "0x85")]
	[Token(Token = "0x600162A")]
	public static extern IntPtr new_RailArrayRailZoneID__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600162B")]
	[Address(RVA = "0x404570", Offset = "0x402D70", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailZoneID__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600162C")]
	[Address(RVA = "0x3B6840", Offset = "0x3B5040", Length = "0x87")]
	public static extern IntPtr RailArrayRailZoneID_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600162D")]
	[Address(RVA = "0x3EDBB0", Offset = "0x3EC3B0", Length = "0x78")]
	public static extern void delete_RailArrayRailZoneID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600162E")]
	[Address(RVA = "0x3B68D0", Offset = "0x3B50D0", Length = "0x93")]
	public static extern void RailArrayRailZoneID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B6970", Offset = "0x3B5170", Length = "0x78")]
	[Token(Token = "0x600162F")]
	public static extern IntPtr RailArrayRailZoneID_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6C20", Offset = "0x3B5420", Length = "0x78")]
	[Token(Token = "0x6001630")]
	public static extern uint RailArrayRailZoneID_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B67B0", Offset = "0x3B4FB0", Length = "0x85")]
	[Token(Token = "0x6001631")]
	public static extern IntPtr RailArrayRailZoneID_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B6B90", Offset = "0x3B5390", Length = "0x85")]
	[Token(Token = "0x6001632")]
	public static extern void RailArrayRailZoneID_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001633")]
	[Address(RVA = "0x3B6B00", Offset = "0x3B5300", Length = "0x87")]
	public static extern void RailArrayRailZoneID_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B69F0", Offset = "0x3B51F0", Length = "0x78")]
	[Token(Token = "0x6001634")]
	public static extern void RailArrayRailZoneID_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001635")]
	[Address(RVA = "0x3B6A70", Offset = "0x3B5270", Length = "0x85")]
	public static extern void RailArrayRailZoneID_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001636")]
	[Address(RVA = "0x402570", Offset = "0x400D70", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailKeyValue__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001637")]
	[Address(RVA = "0x4025E0", Offset = "0x400DE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailKeyValue__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001638")]
	[Address(RVA = "0x402660", Offset = "0x400E60", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailKeyValue__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001639")]
	[Address(RVA = "0x4026F0", Offset = "0x400EF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailKeyValue__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600163A")]
	[Address(RVA = "0x3B1E30", Offset = "0x3B0630", Length = "0x87")]
	public static extern IntPtr RailArrayRailKeyValue_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED430", Offset = "0x3EBC30", Length = "0x78")]
	[Token(Token = "0x600163B")]
	public static extern void delete_RailArrayRailKeyValue(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600163C")]
	[Address(RVA = "0x3B1EC0", Offset = "0x3B06C0", Length = "0x93")]
	public static extern void RailArrayRailKeyValue_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B1F60", Offset = "0x3B0760", Length = "0x78")]
	[Token(Token = "0x600163D")]
	public static extern IntPtr RailArrayRailKeyValue_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600163E")]
	[Address(RVA = "0x3B2210", Offset = "0x3B0A10", Length = "0x78")]
	public static extern uint RailArrayRailKeyValue_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1DA0", Offset = "0x3B05A0", Length = "0x85")]
	[Token(Token = "0x600163F")]
	public static extern IntPtr RailArrayRailKeyValue_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B2180", Offset = "0x3B0980", Length = "0x85")]
	[Token(Token = "0x6001640")]
	public static extern void RailArrayRailKeyValue_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B20F0", Offset = "0x3B08F0", Length = "0x87")]
	[Token(Token = "0x6001641")]
	public static extern void RailArrayRailKeyValue_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001642")]
	[Address(RVA = "0x3B1FE0", Offset = "0x3B07E0", Length = "0x78")]
	public static extern void RailArrayRailKeyValue_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001643")]
	[Address(RVA = "0x3B2060", Offset = "0x3B0860", Length = "0x85")]
	public static extern void RailArrayRailKeyValue_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001644")]
	[Address(RVA = "0x403570", Offset = "0x401D70", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4035E0", Offset = "0x401DE0", Length = "0x76")]
	[Token(Token = "0x6001645")]
	public static extern IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x403660", Offset = "0x401E60", Length = "0x85")]
	[Token(Token = "0x6001646")]
	public static extern IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001647")]
	[Address(RVA = "0x4036F0", Offset = "0x401EF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailSpaceWorkVoteDetail__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001648")]
	[Address(RVA = "0x3B45B0", Offset = "0x3B2DB0", Length = "0x87")]
	public static extern IntPtr RailArrayRailSpaceWorkVoteDetail_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001649")]
	[Address(RVA = "0x3ED830", Offset = "0x3EC030", Length = "0x78")]
	public static extern void delete_RailArrayRailSpaceWorkVoteDetail(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600164A")]
	[Address(RVA = "0x3B4640", Offset = "0x3B2E40", Length = "0x93")]
	public static extern void RailArrayRailSpaceWorkVoteDetail_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B46E0", Offset = "0x3B2EE0", Length = "0x78")]
	[Token(Token = "0x600164B")]
	public static extern IntPtr RailArrayRailSpaceWorkVoteDetail_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4990", Offset = "0x3B3190", Length = "0x78")]
	[Token(Token = "0x600164C")]
	public static extern uint RailArrayRailSpaceWorkVoteDetail_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4520", Offset = "0x3B2D20", Length = "0x85")]
	[Token(Token = "0x600164D")]
	public static extern IntPtr RailArrayRailSpaceWorkVoteDetail_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B4900", Offset = "0x3B3100", Length = "0x85")]
	[Token(Token = "0x600164E")]
	public static extern void RailArrayRailSpaceWorkVoteDetail_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600164F")]
	[Address(RVA = "0x3B4870", Offset = "0x3B3070", Length = "0x87")]
	public static extern void RailArrayRailSpaceWorkVoteDetail_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B4760", Offset = "0x3B2F60", Length = "0x78")]
	[Token(Token = "0x6001650")]
	public static extern void RailArrayRailSpaceWorkVoteDetail_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B47E0", Offset = "0x3B2FE0", Length = "0x85")]
	[Token(Token = "0x6001651")]
	public static extern void RailArrayRailSpaceWorkVoteDetail_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403170", Offset = "0x401970", Length = "0x65")]
	[Token(Token = "0x6001652")]
	public static extern IntPtr new_RailArrayRailSmallObjectState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4031E0", Offset = "0x4019E0", Length = "0x76")]
	[Token(Token = "0x6001653")]
	public static extern IntPtr new_RailArrayRailSmallObjectState__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001654")]
	[Address(RVA = "0x403260", Offset = "0x401A60", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailSmallObjectState__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4032F0", Offset = "0x401AF0", Length = "0x78")]
	[Token(Token = "0x6001655")]
	public static extern IntPtr new_RailArrayRailSmallObjectState__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001656")]
	[Address(RVA = "0x3B3BD0", Offset = "0x3B23D0", Length = "0x87")]
	public static extern IntPtr RailArrayRailSmallObjectState_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001657")]
	[Address(RVA = "0x3ED730", Offset = "0x3EBF30", Length = "0x78")]
	public static extern void delete_RailArrayRailSmallObjectState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001658")]
	[Address(RVA = "0x3B3C60", Offset = "0x3B2460", Length = "0x93")]
	public static extern void RailArrayRailSmallObjectState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B3D00", Offset = "0x3B2500", Length = "0x78")]
	[Token(Token = "0x6001659")]
	public static extern IntPtr RailArrayRailSmallObjectState_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3FB0", Offset = "0x3B27B0", Length = "0x78")]
	[Token(Token = "0x600165A")]
	public static extern uint RailArrayRailSmallObjectState_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x3B3B40", Offset = "0x3B2340", Length = "0x85")]
	public static extern IntPtr RailArrayRailSmallObjectState_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B3F20", Offset = "0x3B2720", Length = "0x85")]
	[Token(Token = "0x600165C")]
	public static extern void RailArrayRailSmallObjectState_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600165D")]
	[Address(RVA = "0x3B3E90", Offset = "0x3B2690", Length = "0x87")]
	public static extern void RailArrayRailSmallObjectState_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B3D80", Offset = "0x3B2580", Length = "0x78")]
	[Token(Token = "0x600165E")]
	public static extern void RailArrayRailSmallObjectState_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3E00", Offset = "0x3B2600", Length = "0x85")]
	[Token(Token = "0x600165F")]
	public static extern void RailArrayRailSmallObjectState_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x401970", Offset = "0x400170", Length = "0x65")]
	[Token(Token = "0x6001660")]
	public static extern IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001661")]
	[Address(RVA = "0x4019E0", Offset = "0x4001E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001662")]
	[Address(RVA = "0x401A60", Offset = "0x400260", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001663")]
	[Address(RVA = "0x401AF0", Offset = "0x4002F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailFriendPlayedGameInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001664")]
	[Address(RVA = "0x3B0090", Offset = "0x3AE890", Length = "0x87")]
	public static extern IntPtr RailArrayRailFriendPlayedGameInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001665")]
	[Address(RVA = "0x3ED130", Offset = "0x3EB930", Length = "0x78")]
	public static extern void delete_RailArrayRailFriendPlayedGameInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001666")]
	[Address(RVA = "0x3B0120", Offset = "0x3AE920", Length = "0x93")]
	public static extern void RailArrayRailFriendPlayedGameInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B01C0", Offset = "0x3AE9C0", Length = "0x78")]
	[Token(Token = "0x6001667")]
	public static extern IntPtr RailArrayRailFriendPlayedGameInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0470", Offset = "0x3AEC70", Length = "0x78")]
	[Token(Token = "0x6001668")]
	public static extern uint RailArrayRailFriendPlayedGameInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0000", Offset = "0x3AE800", Length = "0x85")]
	[Token(Token = "0x6001669")]
	public static extern IntPtr RailArrayRailFriendPlayedGameInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B03E0", Offset = "0x3AEBE0", Length = "0x85")]
	[Token(Token = "0x600166A")]
	public static extern void RailArrayRailFriendPlayedGameInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600166B")]
	[Address(RVA = "0x3B0350", Offset = "0x3AEB50", Length = "0x87")]
	public static extern void RailArrayRailFriendPlayedGameInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600166C")]
	[Address(RVA = "0x3B0240", Offset = "0x3AEA40", Length = "0x78")]
	public static extern void RailArrayRailFriendPlayedGameInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B02C0", Offset = "0x3AEAC0", Length = "0x85")]
	[Token(Token = "0x600166D")]
	public static extern void RailArrayRailFriendPlayedGameInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4041F0", Offset = "0x4029F0", Length = "0x65")]
	[Token(Token = "0x600166E")]
	public static extern IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x404260", Offset = "0x402A60", Length = "0x76")]
	[Token(Token = "0x600166F")]
	public static extern IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x4042E0", Offset = "0x402AE0", Length = "0x85")]
	[Token(Token = "0x6001670")]
	public static extern IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404370", Offset = "0x402B70", Length = "0x78")]
	[Token(Token = "0x6001671")]
	public static extern IntPtr new_RailArrayRailVoiceChannelUserSpeakingState__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001672")]
	[Address(RVA = "0x3B6350", Offset = "0x3B4B50", Length = "0x87")]
	public static extern IntPtr RailArrayRailVoiceChannelUserSpeakingState_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001673")]
	[Address(RVA = "0x3EDB30", Offset = "0x3EC330", Length = "0x78")]
	public static extern void delete_RailArrayRailVoiceChannelUserSpeakingState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B63E0", Offset = "0x3B4BE0", Length = "0x93")]
	[Token(Token = "0x6001674")]
	public static extern void RailArrayRailVoiceChannelUserSpeakingState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001675")]
	[Address(RVA = "0x3B6480", Offset = "0x3B4C80", Length = "0x78")]
	public static extern IntPtr RailArrayRailVoiceChannelUserSpeakingState_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6730", Offset = "0x3B4F30", Length = "0x78")]
	[Token(Token = "0x6001676")]
	public static extern uint RailArrayRailVoiceChannelUserSpeakingState_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B62C0", Offset = "0x3B4AC0", Length = "0x85")]
	[Token(Token = "0x6001677")]
	public static extern IntPtr RailArrayRailVoiceChannelUserSpeakingState_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B66A0", Offset = "0x3B4EA0", Length = "0x85")]
	[Token(Token = "0x6001678")]
	public static extern void RailArrayRailVoiceChannelUserSpeakingState_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B6610", Offset = "0x3B4E10", Length = "0x87")]
	[Token(Token = "0x6001679")]
	public static extern void RailArrayRailVoiceChannelUserSpeakingState_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600167A")]
	[Address(RVA = "0x3B6500", Offset = "0x3B4D00", Length = "0x78")]
	public static extern void RailArrayRailVoiceChannelUserSpeakingState_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600167B")]
	[Address(RVA = "0x3B6580", Offset = "0x3B4D80", Length = "0x85")]
	public static extern void RailArrayRailVoiceChannelUserSpeakingState_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600167C")]
	[Address(RVA = "0x401D70", Offset = "0x400570", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailGameID__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x401DE0", Offset = "0x4005E0", Length = "0x76")]
	[Token(Token = "0x600167D")]
	public static extern IntPtr new_RailArrayRailGameID__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600167E")]
	[Address(RVA = "0x401E60", Offset = "0x400660", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailGameID__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600167F")]
	[Address(RVA = "0x401EF0", Offset = "0x4006F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailGameID__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001680")]
	[Address(RVA = "0x3B0A70", Offset = "0x3AF270", Length = "0x87")]
	public static extern IntPtr RailArrayRailGameID_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED230", Offset = "0x3EBA30", Length = "0x78")]
	[Token(Token = "0x6001681")]
	public static extern void delete_RailArrayRailGameID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0B00", Offset = "0x3AF300", Length = "0x93")]
	[Token(Token = "0x6001682")]
	public static extern void RailArrayRailGameID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001683")]
	[Address(RVA = "0x3B0BA0", Offset = "0x3AF3A0", Length = "0x78")]
	public static extern IntPtr RailArrayRailGameID_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0E50", Offset = "0x3AF650", Length = "0x78")]
	[Token(Token = "0x6001684")]
	public static extern uint RailArrayRailGameID_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001685")]
	[Address(RVA = "0x3B09E0", Offset = "0x3AF1E0", Length = "0x85")]
	public static extern IntPtr RailArrayRailGameID_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001686")]
	[Address(RVA = "0x3B0DC0", Offset = "0x3AF5C0", Length = "0x85")]
	public static extern void RailArrayRailGameID_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001687")]
	[Address(RVA = "0x3B0D30", Offset = "0x3AF530", Length = "0x87")]
	public static extern void RailArrayRailGameID_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B0C20", Offset = "0x3AF420", Length = "0x78")]
	[Token(Token = "0x6001688")]
	public static extern void RailArrayRailGameID_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0CA0", Offset = "0x3AF4A0", Length = "0x85")]
	[Token(Token = "0x6001689")]
	public static extern void RailArrayRailGameID_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600168A")]
	[Address(RVA = "0x4055F0", Offset = "0x403DF0", Length = "0x65")]
	public static extern IntPtr new_RailArrayuint8_t__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600168B")]
	[Address(RVA = "0x405660", Offset = "0x403E60", Length = "0x76")]
	public static extern IntPtr new_RailArrayuint8_t__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600168C")]
	[Address(RVA = "0x4056E0", Offset = "0x403EE0", Length = "0x85")]
	public static extern IntPtr new_RailArrayuint8_t__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600168D")]
	[Address(RVA = "0x405770", Offset = "0x403F70", Length = "0x78")]
	public static extern IntPtr new_RailArrayuint8_t__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600168E")]
	[Address(RVA = "0x3B94B0", Offset = "0x3B7CB0", Length = "0x87")]
	public static extern IntPtr RailArrayuint8_t_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EE030", Offset = "0x3EC830", Length = "0x78")]
	[Token(Token = "0x600168F")]
	public static extern void delete_RailArrayuint8_t(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B9540", Offset = "0x3B7D40", Length = "0x93")]
	[Token(Token = "0x6001690")]
	public static extern void RailArrayuint8_t_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B95E0", Offset = "0x3B7DE0", Length = "0x78")]
	[Token(Token = "0x6001691")]
	public static extern IntPtr RailArrayuint8_t_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001692")]
	[Address(RVA = "0x3B9890", Offset = "0x3B8090", Length = "0x78")]
	public static extern uint RailArrayuint8_t_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B9420", Offset = "0x3B7C20", Length = "0x85")]
	[Token(Token = "0x6001693")]
	public static extern IntPtr RailArrayuint8_t_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001694")]
	[Address(RVA = "0x3B9800", Offset = "0x3B8000", Length = "0x85")]
	public static extern void RailArrayuint8_t_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001695")]
	[Address(RVA = "0x3B9770", Offset = "0x3B7F70", Length = "0x87")]
	public static extern void RailArrayuint8_t_push_back(IntPtr jarg1, byte jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9660", Offset = "0x3B7E60", Length = "0x78")]
	[Token(Token = "0x6001696")]
	public static extern void RailArrayuint8_t_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B96E0", Offset = "0x3B7EE0", Length = "0x85")]
	[Token(Token = "0x6001697")]
	public static extern void RailArrayuint8_t_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001698")]
	[Address(RVA = "0x3FFAF0", Offset = "0x3FE2F0", Length = "0x65")]
	public static extern IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001699")]
	[Address(RVA = "0x3FFB60", Offset = "0x3FE360", Length = "0x76")]
	public static extern IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FFBE0", Offset = "0x3FE3E0", Length = "0x85")]
	[Token(Token = "0x600169A")]
	public static extern IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FFC70", Offset = "0x3FE470", Length = "0x78")]
	[Token(Token = "0x600169B")]
	public static extern IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB680", Offset = "0x3A9E80", Length = "0x87")]
	[Token(Token = "0x600169C")]
	public static extern IntPtr RailArrayEnumRailWorkFileClass_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EC9B0", Offset = "0x3EB1B0", Length = "0x78")]
	[Token(Token = "0x600169D")]
	public static extern void delete_RailArrayEnumRailWorkFileClass(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB710", Offset = "0x3A9F10", Length = "0x93")]
	[Token(Token = "0x600169E")]
	public static extern void RailArrayEnumRailWorkFileClass_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x600169F")]
	[Address(RVA = "0x3AB7B0", Offset = "0x3A9FB0", Length = "0x78")]
	public static extern IntPtr RailArrayEnumRailWorkFileClass_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ABA60", Offset = "0x3AA260", Length = "0x78")]
	[Token(Token = "0x60016A0")]
	public static extern uint RailArrayEnumRailWorkFileClass_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x3AB5F0", Offset = "0x3A9DF0", Length = "0x85")]
	public static extern IntPtr RailArrayEnumRailWorkFileClass_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x3AB9D0", Offset = "0x3AA1D0", Length = "0x85")]
	public static extern void RailArrayEnumRailWorkFileClass_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x3AB940", Offset = "0x3AA140", Length = "0x87")]
	public static extern void RailArrayEnumRailWorkFileClass_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x3AB830", Offset = "0x3AA030", Length = "0x78")]
	public static extern void RailArrayEnumRailWorkFileClass_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AB8B0", Offset = "0x3AA0B0", Length = "0x85")]
	[Token(Token = "0x60016A5")]
	public static extern void RailArrayEnumRailWorkFileClass_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x3FFCF0", Offset = "0x3FE4F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayEnumRailWorkFileClass__SWIG_4(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x402D70", Offset = "0x401570", Length = "0x65")]
	[Token(Token = "0x60016A7")]
	public static extern IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x402DE0", Offset = "0x4015E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x402E60", Offset = "0x401660", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x402EF0", Offset = "0x4016F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailPurchaseProductInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x3B31F0", Offset = "0x3B19F0", Length = "0x87")]
	public static extern IntPtr RailArrayRailPurchaseProductInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED630", Offset = "0x3EBE30", Length = "0x78")]
	[Token(Token = "0x60016AC")]
	public static extern void delete_RailArrayRailPurchaseProductInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3280", Offset = "0x3B1A80", Length = "0x93")]
	[Token(Token = "0x60016AD")]
	public static extern void RailArrayRailPurchaseProductInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B3320", Offset = "0x3B1B20", Length = "0x78")]
	[Token(Token = "0x60016AE")]
	public static extern IntPtr RailArrayRailPurchaseProductInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B35D0", Offset = "0x3B1DD0", Length = "0x78")]
	[Token(Token = "0x60016AF")]
	public static extern uint RailArrayRailPurchaseProductInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3160", Offset = "0x3B1960", Length = "0x85")]
	[Token(Token = "0x60016B0")]
	public static extern IntPtr RailArrayRailPurchaseProductInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B3540", Offset = "0x3B1D40", Length = "0x85")]
	[Token(Token = "0x60016B1")]
	public static extern void RailArrayRailPurchaseProductInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B34B0", Offset = "0x3B1CB0", Length = "0x87")]
	[Token(Token = "0x60016B2")]
	public static extern void RailArrayRailPurchaseProductInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x3B33A0", Offset = "0x3B1BA0", Length = "0x78")]
	public static extern void RailArrayRailPurchaseProductInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x3B3420", Offset = "0x3B1C20", Length = "0x85")]
	public static extern void RailArrayRailPurchaseProductInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x4045F0", Offset = "0x402DF0", Length = "0x65")]
	public static extern IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x404660", Offset = "0x402E60", Length = "0x76")]
	public static extern IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x4046E0", Offset = "0x402EE0", Length = "0x85")]
	public static extern IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404770", Offset = "0x402F70", Length = "0x78")]
	[Token(Token = "0x60016B8")]
	public static extern IntPtr new_RailArrayRoomInfoListFilterKey__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6D30", Offset = "0x3B5530", Length = "0x87")]
	[Token(Token = "0x60016B9")]
	public static extern IntPtr RailArrayRoomInfoListFilterKey_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x3EDC30", Offset = "0x3EC430", Length = "0x78")]
	public static extern void delete_RailArrayRoomInfoListFilterKey(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6DC0", Offset = "0x3B55C0", Length = "0x93")]
	[Token(Token = "0x60016BB")]
	public static extern void RailArrayRoomInfoListFilterKey_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B6E60", Offset = "0x3B5660", Length = "0x78")]
	[Token(Token = "0x60016BC")]
	public static extern IntPtr RailArrayRoomInfoListFilterKey_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7110", Offset = "0x3B5910", Length = "0x78")]
	[Token(Token = "0x60016BD")]
	public static extern uint RailArrayRoomInfoListFilterKey_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6CA0", Offset = "0x3B54A0", Length = "0x85")]
	[Token(Token = "0x60016BE")]
	public static extern IntPtr RailArrayRoomInfoListFilterKey_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x3B7080", Offset = "0x3B5880", Length = "0x85")]
	public static extern void RailArrayRoomInfoListFilterKey_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x3B6FF0", Offset = "0x3B57F0", Length = "0x87")]
	public static extern void RailArrayRoomInfoListFilterKey_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x3B6EE0", Offset = "0x3B56E0", Length = "0x78")]
	public static extern void RailArrayRoomInfoListFilterKey_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B6F60", Offset = "0x3B5760", Length = "0x85")]
	[Token(Token = "0x60016C2")]
	public static extern void RailArrayRoomInfoListFilterKey_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x400370", Offset = "0x3FEB70", Length = "0x65")]
	public static extern IntPtr new_RailArrayGameServerListSorter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x4003E0", Offset = "0x3FEBE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayGameServerListSorter__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x400460", Offset = "0x3FEC60", Length = "0x85")]
	public static extern IntPtr new_RailArrayGameServerListSorter__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4004F0", Offset = "0x3FECF0", Length = "0x78")]
	[Token(Token = "0x60016C6")]
	public static extern IntPtr new_RailArrayGameServerListSorter__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ACA40", Offset = "0x3AB240", Length = "0x87")]
	[Token(Token = "0x60016C7")]
	public static extern IntPtr RailArrayGameServerListSorter_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECBB0", Offset = "0x3EB3B0", Length = "0x78")]
	[Token(Token = "0x60016C8")]
	public static extern void delete_RailArrayGameServerListSorter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ACAD0", Offset = "0x3AB2D0", Length = "0x93")]
	[Token(Token = "0x60016C9")]
	public static extern void RailArrayGameServerListSorter_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3ACB70", Offset = "0x3AB370", Length = "0x78")]
	[Token(Token = "0x60016CA")]
	public static extern IntPtr RailArrayGameServerListSorter_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x3ACE20", Offset = "0x3AB620", Length = "0x78")]
	public static extern uint RailArrayGameServerListSorter_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x3AC9B0", Offset = "0x3AB1B0", Length = "0x85")]
	public static extern IntPtr RailArrayGameServerListSorter_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x3ACD90", Offset = "0x3AB590", Length = "0x85")]
	public static extern void RailArrayGameServerListSorter_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016CE")]
	[Address(RVA = "0x3ACD00", Offset = "0x3AB500", Length = "0x87")]
	public static extern void RailArrayGameServerListSorter_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ACBF0", Offset = "0x3AB3F0", Length = "0x78")]
	[Token(Token = "0x60016CF")]
	public static extern void RailArrayGameServerListSorter_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x3ACC70", Offset = "0x3AB470", Length = "0x85")]
	public static extern void RailArrayGameServerListSorter_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x401170", Offset = "0x3FF970", Length = "0x65")]
	[Token(Token = "0x60016D1")]
	public static extern IntPtr new_RailArrayRailDlcID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x4011E0", Offset = "0x3FF9E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailDlcID__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x401260", Offset = "0x3FFA60", Length = "0x85")]
	[Token(Token = "0x60016D3")]
	public static extern IntPtr new_RailArrayRailDlcID__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x4012F0", Offset = "0x3FFAF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailDlcID__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AECD0", Offset = "0x3AD4D0", Length = "0x87")]
	[Token(Token = "0x60016D5")]
	public static extern IntPtr RailArrayRailDlcID_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x3ECF30", Offset = "0x3EB730", Length = "0x78")]
	public static extern void delete_RailArrayRailDlcID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x3AED60", Offset = "0x3AD560", Length = "0x93")]
	public static extern void RailArrayRailDlcID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x3AEE00", Offset = "0x3AD600", Length = "0x78")]
	public static extern IntPtr RailArrayRailDlcID_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x3AF0B0", Offset = "0x3AD8B0", Length = "0x78")]
	public static extern uint RailArrayRailDlcID_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x3AEC40", Offset = "0x3AD440", Length = "0x85")]
	public static extern IntPtr RailArrayRailDlcID_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AF020", Offset = "0x3AD820", Length = "0x85")]
	[Token(Token = "0x60016DB")]
	public static extern void RailArrayRailDlcID_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AEF90", Offset = "0x3AD790", Length = "0x87")]
	[Token(Token = "0x60016DC")]
	public static extern void RailArrayRailDlcID_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AEE80", Offset = "0x3AD680", Length = "0x78")]
	[Token(Token = "0x60016DD")]
	public static extern void RailArrayRailDlcID_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x3AEF00", Offset = "0x3AD700", Length = "0x85")]
	public static extern void RailArrayRailDlcID_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x402170", Offset = "0x400970", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailID__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4021E0", Offset = "0x4009E0", Length = "0x76")]
	[Token(Token = "0x60016E0")]
	public static extern IntPtr new_RailArrayRailID__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x402260", Offset = "0x400A60", Length = "0x85")]
	[Token(Token = "0x60016E1")]
	public static extern IntPtr new_RailArrayRailID__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x4022F0", Offset = "0x400AF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailID__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x3B1450", Offset = "0x3AFC50", Length = "0x87")]
	public static extern IntPtr RailArrayRailID_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x3ED330", Offset = "0x3EBB30", Length = "0x78")]
	public static extern void delete_RailArrayRailID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B14E0", Offset = "0x3AFCE0", Length = "0x93")]
	[Token(Token = "0x60016E5")]
	public static extern void RailArrayRailID_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B1580", Offset = "0x3AFD80", Length = "0x78")]
	[Token(Token = "0x60016E6")]
	public static extern IntPtr RailArrayRailID_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1830", Offset = "0x3B0030", Length = "0x78")]
	[Token(Token = "0x60016E7")]
	public static extern uint RailArrayRailID_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B13C0", Offset = "0x3AFBC0", Length = "0x85")]
	[Token(Token = "0x60016E8")]
	public static extern IntPtr RailArrayRailID_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B17A0", Offset = "0x3AFFA0", Length = "0x85")]
	[Token(Token = "0x60016E9")]
	public static extern void RailArrayRailID_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x3B1710", Offset = "0x3AFF10", Length = "0x87")]
	public static extern void RailArrayRailID_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1600", Offset = "0x3AFE00", Length = "0x78")]
	[Token(Token = "0x60016EB")]
	public static extern void RailArrayRailID_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x3B1680", Offset = "0x3AFE80", Length = "0x85")]
	public static extern void RailArrayRailID_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403BF0", Offset = "0x4023F0", Length = "0x65")]
	[Token(Token = "0x60016ED")]
	public static extern IntPtr new_RailArrayRailUserPlayedWith__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x403C60", Offset = "0x402460", Length = "0x76")]
	[Token(Token = "0x60016EE")]
	public static extern IntPtr new_RailArrayRailUserPlayedWith__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x403CE0", Offset = "0x4024E0", Length = "0x85")]
	[Token(Token = "0x60016EF")]
	public static extern IntPtr new_RailArrayRailUserPlayedWith__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403D70", Offset = "0x402570", Length = "0x78")]
	[Token(Token = "0x60016F0")]
	public static extern IntPtr new_RailArrayRailUserPlayedWith__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B5480", Offset = "0x3B3C80", Length = "0x87")]
	[Token(Token = "0x60016F1")]
	public static extern IntPtr RailArrayRailUserPlayedWith_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED9B0", Offset = "0x3EC1B0", Length = "0x78")]
	[Token(Token = "0x60016F2")]
	public static extern void delete_RailArrayRailUserPlayedWith(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x3B5510", Offset = "0x3B3D10", Length = "0x93")]
	public static extern void RailArrayRailUserPlayedWith_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x3B55B0", Offset = "0x3B3DB0", Length = "0x78")]
	public static extern IntPtr RailArrayRailUserPlayedWith_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x3B5860", Offset = "0x3B4060", Length = "0x78")]
	public static extern uint RailArrayRailUserPlayedWith_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x3B53F0", Offset = "0x3B3BF0", Length = "0x85")]
	public static extern IntPtr RailArrayRailUserPlayedWith_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x3B57D0", Offset = "0x3B3FD0", Length = "0x85")]
	public static extern void RailArrayRailUserPlayedWith_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B5740", Offset = "0x3B3F40", Length = "0x87")]
	[Token(Token = "0x60016F8")]
	public static extern void RailArrayRailUserPlayedWith_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B5630", Offset = "0x3B3E30", Length = "0x78")]
	[Token(Token = "0x60016F9")]
	public static extern void RailArrayRailUserPlayedWith_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x3B56B0", Offset = "0x3B3EB0", Length = "0x85")]
	public static extern void RailArrayRailUserPlayedWith_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x401B70", Offset = "0x400370", Length = "0x65")]
	[Token(Token = "0x60016FB")]
	public static extern IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x401BE0", Offset = "0x4003E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x401C60", Offset = "0x400460", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x401CF0", Offset = "0x4004F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailGameDefineGamePlayingState__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0580", Offset = "0x3AED80", Length = "0x87")]
	[Token(Token = "0x60016FF")]
	public static extern IntPtr RailArrayRailGameDefineGamePlayingState_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001700")]
	[Address(RVA = "0x3ED1B0", Offset = "0x3EB9B0", Length = "0x78")]
	public static extern void delete_RailArrayRailGameDefineGamePlayingState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001701")]
	[Address(RVA = "0x3B0610", Offset = "0x3AEE10", Length = "0x93")]
	public static extern void RailArrayRailGameDefineGamePlayingState_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001702")]
	[Address(RVA = "0x3B06B0", Offset = "0x3AEEB0", Length = "0x78")]
	public static extern IntPtr RailArrayRailGameDefineGamePlayingState_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001703")]
	[Address(RVA = "0x3B0960", Offset = "0x3AF160", Length = "0x78")]
	public static extern uint RailArrayRailGameDefineGamePlayingState_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001704")]
	[Address(RVA = "0x3B04F0", Offset = "0x3AECF0", Length = "0x85")]
	public static extern IntPtr RailArrayRailGameDefineGamePlayingState_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001705")]
	[Address(RVA = "0x3B08D0", Offset = "0x3AF0D0", Length = "0x85")]
	public static extern void RailArrayRailGameDefineGamePlayingState_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001706")]
	[Address(RVA = "0x3B0840", Offset = "0x3AF040", Length = "0x87")]
	public static extern void RailArrayRailGameDefineGamePlayingState_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001707")]
	[Address(RVA = "0x3B0730", Offset = "0x3AEF30", Length = "0x78")]
	public static extern void RailArrayRailGameDefineGamePlayingState_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B07B0", Offset = "0x3AEFB0", Length = "0x85")]
	[Token(Token = "0x6001708")]
	public static extern void RailArrayRailGameDefineGamePlayingState_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FFD70", Offset = "0x3FE570", Length = "0x65")]
	[Token(Token = "0x6001709")]
	public static extern IntPtr new_RailArrayGameServerInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FFDE0", Offset = "0x3FE5E0", Length = "0x76")]
	[Token(Token = "0x600170A")]
	public static extern IntPtr new_RailArrayGameServerInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FFE60", Offset = "0x3FE660", Length = "0x85")]
	[Token(Token = "0x600170B")]
	public static extern IntPtr new_RailArrayGameServerInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3FFEF0", Offset = "0x3FE6F0", Length = "0x78")]
	[Token(Token = "0x600170C")]
	public static extern IntPtr new_RailArrayGameServerInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600170D")]
	[Address(RVA = "0x3ABB70", Offset = "0x3AA370", Length = "0x87")]
	public static extern IntPtr RailArrayGameServerInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECA30", Offset = "0x3EB230", Length = "0x78")]
	[Token(Token = "0x600170E")]
	public static extern void delete_RailArrayGameServerInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ABC00", Offset = "0x3AA400", Length = "0x93")]
	[Token(Token = "0x600170F")]
	public static extern void RailArrayGameServerInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001710")]
	[Address(RVA = "0x3ABCA0", Offset = "0x3AA4A0", Length = "0x78")]
	public static extern IntPtr RailArrayGameServerInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001711")]
	[Address(RVA = "0x3ABF50", Offset = "0x3AA750", Length = "0x78")]
	public static extern uint RailArrayGameServerInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ABAE0", Offset = "0x3AA2E0", Length = "0x85")]
	[Token(Token = "0x6001712")]
	public static extern IntPtr RailArrayGameServerInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ABEC0", Offset = "0x3AA6C0", Length = "0x85")]
	[Token(Token = "0x6001713")]
	public static extern void RailArrayGameServerInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ABE30", Offset = "0x3AA630", Length = "0x87")]
	[Token(Token = "0x6001714")]
	public static extern void RailArrayGameServerInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001715")]
	[Address(RVA = "0x3ABD20", Offset = "0x3AA520", Length = "0x78")]
	public static extern void RailArrayGameServerInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001716")]
	[Address(RVA = "0x3ABDA0", Offset = "0x3AA5A0", Length = "0x85")]
	public static extern void RailArrayGameServerInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404BF0", Offset = "0x4033F0", Length = "0x65")]
	[Token(Token = "0x6001717")]
	public static extern IntPtr new_RailArrayRoomInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x404C60", Offset = "0x403460", Length = "0x76")]
	[Token(Token = "0x6001718")]
	public static extern IntPtr new_RailArrayRoomInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001719")]
	[Address(RVA = "0x404CE0", Offset = "0x4034E0", Length = "0x85")]
	public static extern IntPtr new_RailArrayRoomInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x404D70", Offset = "0x403570", Length = "0x78")]
	[Token(Token = "0x600171A")]
	public static extern IntPtr new_RailArrayRoomInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7C00", Offset = "0x3B6400", Length = "0x87")]
	[Token(Token = "0x600171B")]
	public static extern IntPtr RailArrayRoomInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EDDB0", Offset = "0x3EC5B0", Length = "0x78")]
	[Token(Token = "0x600171C")]
	public static extern void delete_RailArrayRoomInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7C90", Offset = "0x3B6490", Length = "0x93")]
	[Token(Token = "0x600171D")]
	public static extern void RailArrayRoomInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B7D30", Offset = "0x3B6530", Length = "0x78")]
	[Token(Token = "0x600171E")]
	public static extern IntPtr RailArrayRoomInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7FE0", Offset = "0x3B67E0", Length = "0x78")]
	[Token(Token = "0x600171F")]
	public static extern uint RailArrayRoomInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B7B70", Offset = "0x3B6370", Length = "0x85")]
	[Token(Token = "0x6001720")]
	public static extern IntPtr RailArrayRoomInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B7F50", Offset = "0x3B6750", Length = "0x85")]
	[Token(Token = "0x6001721")]
	public static extern void RailArrayRoomInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B7EC0", Offset = "0x3B66C0", Length = "0x87")]
	[Token(Token = "0x6001722")]
	public static extern void RailArrayRoomInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001723")]
	[Address(RVA = "0x3B7DB0", Offset = "0x3B65B0", Length = "0x78")]
	public static extern void RailArrayRoomInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001724")]
	[Address(RVA = "0x3B7E30", Offset = "0x3B6630", Length = "0x85")]
	public static extern void RailArrayRoomInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x402970", Offset = "0x401170", Length = "0x65")]
	[Token(Token = "0x6001725")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4029E0", Offset = "0x4011E0", Length = "0x76")]
	[Token(Token = "0x6001726")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001727")]
	[Address(RVA = "0x402A60", Offset = "0x401260", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001728")]
	[Address(RVA = "0x402AF0", Offset = "0x4012F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailPlayedWithFriendsTimeItem__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001729")]
	[Address(RVA = "0x3B2810", Offset = "0x3B1010", Length = "0x87")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsTimeItem_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600172A")]
	[Address(RVA = "0x3ED530", Offset = "0x3EBD30", Length = "0x78")]
	public static extern void delete_RailArrayRailPlayedWithFriendsTimeItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600172B")]
	[Address(RVA = "0x3B28A0", Offset = "0x3B10A0", Length = "0x93")]
	public static extern void RailArrayRailPlayedWithFriendsTimeItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B2940", Offset = "0x3B1140", Length = "0x78")]
	[Token(Token = "0x600172C")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsTimeItem_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2BF0", Offset = "0x3B13F0", Length = "0x78")]
	[Token(Token = "0x600172D")]
	public static extern uint RailArrayRailPlayedWithFriendsTimeItem_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2780", Offset = "0x3B0F80", Length = "0x85")]
	[Token(Token = "0x600172E")]
	public static extern IntPtr RailArrayRailPlayedWithFriendsTimeItem_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B2B60", Offset = "0x3B1360", Length = "0x85")]
	[Token(Token = "0x600172F")]
	public static extern void RailArrayRailPlayedWithFriendsTimeItem_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B2AD0", Offset = "0x3B12D0", Length = "0x87")]
	[Token(Token = "0x6001730")]
	public static extern void RailArrayRailPlayedWithFriendsTimeItem_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B29C0", Offset = "0x3B11C0", Length = "0x78")]
	[Token(Token = "0x6001731")]
	public static extern void RailArrayRailPlayedWithFriendsTimeItem_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B2A40", Offset = "0x3B1240", Length = "0x85")]
	[Token(Token = "0x6001732")]
	public static extern void RailArrayRailPlayedWithFriendsTimeItem_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001733")]
	[Address(RVA = "0x401F70", Offset = "0x400770", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001734")]
	[Address(RVA = "0x401FE0", Offset = "0x4007E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x6001735")]
	[Address(RVA = "0x402060", Offset = "0x400860", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001736")]
	[Address(RVA = "0x4020F0", Offset = "0x4008F0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailGeneratedAssetItem__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0F60", Offset = "0x3AF760", Length = "0x87")]
	[Token(Token = "0x6001737")]
	public static extern IntPtr RailArrayRailGeneratedAssetItem_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED2B0", Offset = "0x3EBAB0", Length = "0x78")]
	[Token(Token = "0x6001738")]
	public static extern void delete_RailArrayRailGeneratedAssetItem(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B0FF0", Offset = "0x3AF7F0", Length = "0x93")]
	[Token(Token = "0x6001739")]
	public static extern void RailArrayRailGeneratedAssetItem_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x600173A")]
	[Address(RVA = "0x3B1090", Offset = "0x3AF890", Length = "0x78")]
	public static extern IntPtr RailArrayRailGeneratedAssetItem_buf(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1340", Offset = "0x3AFB40", Length = "0x78")]
	[Token(Token = "0x600173B")]
	public static extern uint RailArrayRailGeneratedAssetItem_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600173C")]
	[Address(RVA = "0x3B0ED0", Offset = "0x3AF6D0", Length = "0x85")]
	public static extern IntPtr RailArrayRailGeneratedAssetItem_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B12B0", Offset = "0x3AFAB0", Length = "0x85")]
	[Token(Token = "0x600173D")]
	public static extern void RailArrayRailGeneratedAssetItem_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1220", Offset = "0x3AFA20", Length = "0x87")]
	[Token(Token = "0x600173E")]
	public static extern void RailArrayRailGeneratedAssetItem_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B1110", Offset = "0x3AF910", Length = "0x78")]
	[Token(Token = "0x600173F")]
	public static extern void RailArrayRailGeneratedAssetItem_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B1190", Offset = "0x3AF990", Length = "0x85")]
	[Token(Token = "0x6001740")]
	public static extern void RailArrayRailGeneratedAssetItem_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x401770", Offset = "0x3FFF70", Length = "0x65")]
	[Token(Token = "0x6001741")]
	public static extern IntPtr new_RailArrayRailFriendMetadata__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001742")]
	[Address(RVA = "0x4017E0", Offset = "0x3FFFE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailFriendMetadata__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x401860", Offset = "0x400060", Length = "0x85")]
	[Token(Token = "0x6001743")]
	public static extern IntPtr new_RailArrayRailFriendMetadata__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4018F0", Offset = "0x4000F0", Length = "0x78")]
	[Token(Token = "0x6001744")]
	public static extern IntPtr new_RailArrayRailFriendMetadata__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AFBA0", Offset = "0x3AE3A0", Length = "0x87")]
	[Token(Token = "0x6001745")]
	public static extern IntPtr RailArrayRailFriendMetadata_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001746")]
	[Address(RVA = "0x3ED0B0", Offset = "0x3EB8B0", Length = "0x78")]
	public static extern void delete_RailArrayRailFriendMetadata(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001747")]
	[Address(RVA = "0x3AFC30", Offset = "0x3AE430", Length = "0x93")]
	public static extern void RailArrayRailFriendMetadata_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001748")]
	[Address(RVA = "0x3AFCD0", Offset = "0x3AE4D0", Length = "0x78")]
	public static extern IntPtr RailArrayRailFriendMetadata_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001749")]
	[Address(RVA = "0x3AFF80", Offset = "0x3AE780", Length = "0x78")]
	public static extern uint RailArrayRailFriendMetadata_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600174A")]
	[Address(RVA = "0x3AFB10", Offset = "0x3AE310", Length = "0x85")]
	public static extern IntPtr RailArrayRailFriendMetadata_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AFEF0", Offset = "0x3AE6F0", Length = "0x85")]
	[Token(Token = "0x600174B")]
	public static extern void RailArrayRailFriendMetadata_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600174C")]
	[Address(RVA = "0x3AFE60", Offset = "0x3AE660", Length = "0x87")]
	public static extern void RailArrayRailFriendMetadata_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AFD50", Offset = "0x3AE550", Length = "0x78")]
	[Token(Token = "0x600174D")]
	public static extern void RailArrayRailFriendMetadata_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AFDD0", Offset = "0x3AE5D0", Length = "0x85")]
	[Token(Token = "0x600174E")]
	public static extern void RailArrayRailFriendMetadata_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x402F70", Offset = "0x401770", Length = "0x65")]
	[Token(Token = "0x600174F")]
	public static extern IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001750")]
	[Address(RVA = "0x402FE0", Offset = "0x4017E0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Address(RVA = "0x403060", Offset = "0x401860", Length = "0x85")]
	[Token(Token = "0x6001751")]
	public static extern IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x4030F0", Offset = "0x4018F0", Length = "0x78")]
	[Token(Token = "0x6001752")]
	public static extern IntPtr new_RailArrayRailSmallObjectDownloadInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B36E0", Offset = "0x3B1EE0", Length = "0x87")]
	[Token(Token = "0x6001753")]
	public static extern IntPtr RailArrayRailSmallObjectDownloadInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ED6B0", Offset = "0x3EBEB0", Length = "0x78")]
	[Token(Token = "0x6001754")]
	public static extern void delete_RailArrayRailSmallObjectDownloadInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3770", Offset = "0x3B1F70", Length = "0x93")]
	[Token(Token = "0x6001755")]
	public static extern void RailArrayRailSmallObjectDownloadInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B3810", Offset = "0x3B2010", Length = "0x78")]
	[Token(Token = "0x6001756")]
	public static extern IntPtr RailArrayRailSmallObjectDownloadInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001757")]
	[Address(RVA = "0x3B3AC0", Offset = "0x3B22C0", Length = "0x78")]
	public static extern uint RailArrayRailSmallObjectDownloadInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B3650", Offset = "0x3B1E50", Length = "0x85")]
	[Token(Token = "0x6001758")]
	public static extern IntPtr RailArrayRailSmallObjectDownloadInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001759")]
	[Address(RVA = "0x3B3A30", Offset = "0x3B2230", Length = "0x85")]
	public static extern void RailArrayRailSmallObjectDownloadInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600175A")]
	[Address(RVA = "0x3B39A0", Offset = "0x3B21A0", Length = "0x87")]
	public static extern void RailArrayRailSmallObjectDownloadInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600175B")]
	[Address(RVA = "0x3B3890", Offset = "0x3B2090", Length = "0x78")]
	public static extern void RailArrayRailSmallObjectDownloadInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600175C")]
	[Address(RVA = "0x3B3910", Offset = "0x3B2110", Length = "0x85")]
	public static extern void RailArrayRailSmallObjectDownloadInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600175D")]
	[Address(RVA = "0x401370", Offset = "0x3FFB70", Length = "0x65")]
	public static extern IntPtr new_RailArrayRailDlcOwned__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600175E")]
	[Address(RVA = "0x4013E0", Offset = "0x3FFBE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailDlcOwned__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600175F")]
	[Address(RVA = "0x401460", Offset = "0x3FFC60", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailDlcOwned__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001760")]
	[Address(RVA = "0x4014F0", Offset = "0x3FFCF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailDlcOwned__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AF1C0", Offset = "0x3AD9C0", Length = "0x87")]
	[Token(Token = "0x6001761")]
	public static extern IntPtr RailArrayRailDlcOwned_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECFB0", Offset = "0x3EB7B0", Length = "0x78")]
	[Token(Token = "0x6001762")]
	public static extern void delete_RailArrayRailDlcOwned(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AF250", Offset = "0x3ADA50", Length = "0x93")]
	[Token(Token = "0x6001763")]
	public static extern void RailArrayRailDlcOwned_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001764")]
	[Address(RVA = "0x3AF2F0", Offset = "0x3ADAF0", Length = "0x78")]
	public static extern IntPtr RailArrayRailDlcOwned_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001765")]
	[Address(RVA = "0x3AF5A0", Offset = "0x3ADDA0", Length = "0x78")]
	public static extern uint RailArrayRailDlcOwned_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001766")]
	[Address(RVA = "0x3AF130", Offset = "0x3AD930", Length = "0x85")]
	public static extern IntPtr RailArrayRailDlcOwned_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001767")]
	[Address(RVA = "0x3AF510", Offset = "0x3ADD10", Length = "0x85")]
	public static extern void RailArrayRailDlcOwned_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AF480", Offset = "0x3ADC80", Length = "0x87")]
	[Token(Token = "0x6001768")]
	public static extern void RailArrayRailDlcOwned_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001769")]
	[Address(RVA = "0x3AF370", Offset = "0x3ADB70", Length = "0x78")]
	public static extern void RailArrayRailDlcOwned_clear(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600176A")]
	[Address(RVA = "0x3AF3F0", Offset = "0x3ADBF0", Length = "0x85")]
	public static extern void RailArrayRailDlcOwned_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x403370", Offset = "0x401B70", Length = "0x65")]
	[Token(Token = "0x600176B")]
	public static extern IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600176C")]
	[Address(RVA = "0x4033E0", Offset = "0x401BE0", Length = "0x76")]
	public static extern IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600176D")]
	[Address(RVA = "0x403460", Offset = "0x401C60", Length = "0x85")]
	public static extern IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x4034F0", Offset = "0x401CF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayRailSpaceWorkDescriptor__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x3B40C0", Offset = "0x3B28C0", Length = "0x87")]
	public static extern IntPtr RailArrayRailSpaceWorkDescriptor_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x3ED7B0", Offset = "0x3EBFB0", Length = "0x78")]
	public static extern void delete_RailArrayRailSpaceWorkDescriptor(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4150", Offset = "0x3B2950", Length = "0x93")]
	[Token(Token = "0x6001771")]
	public static extern void RailArrayRailSpaceWorkDescriptor_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3B41F0", Offset = "0x3B29F0", Length = "0x78")]
	[Token(Token = "0x6001772")]
	public static extern IntPtr RailArrayRailSpaceWorkDescriptor_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001773")]
	[Address(RVA = "0x3B44A0", Offset = "0x3B2CA0", Length = "0x78")]
	public static extern uint RailArrayRailSpaceWorkDescriptor_size(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B4030", Offset = "0x3B2830", Length = "0x85")]
	[Token(Token = "0x6001774")]
	public static extern IntPtr RailArrayRailSpaceWorkDescriptor_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001775")]
	[Address(RVA = "0x3B4410", Offset = "0x3B2C10", Length = "0x85")]
	public static extern void RailArrayRailSpaceWorkDescriptor_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001776")]
	[Address(RVA = "0x3B4380", Offset = "0x3B2B80", Length = "0x87")]
	public static extern void RailArrayRailSpaceWorkDescriptor_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001777")]
	[Address(RVA = "0x3B4270", Offset = "0x3B2A70", Length = "0x78")]
	public static extern void RailArrayRailSpaceWorkDescriptor_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B42F0", Offset = "0x3B2AF0", Length = "0x85")]
	[Token(Token = "0x6001778")]
	public static extern void RailArrayRailSpaceWorkDescriptor_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x400570", Offset = "0x3FED70", Length = "0x65")]
	[Token(Token = "0x6001779")]
	public static extern IntPtr new_RailArrayGameServerPlayerInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4005E0", Offset = "0x3FEDE0", Length = "0x76")]
	[Token(Token = "0x600177A")]
	public static extern IntPtr new_RailArrayGameServerPlayerInfo__SWIG_1(uint jarg1);

	[PreserveSig]
	[Token(Token = "0x600177B")]
	[Address(RVA = "0x400660", Offset = "0x3FEE60", Length = "0x85")]
	public static extern IntPtr new_RailArrayGameServerPlayerInfo__SWIG_2(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600177C")]
	[Address(RVA = "0x4006F0", Offset = "0x3FEEF0", Length = "0x78")]
	public static extern IntPtr new_RailArrayGameServerPlayerInfo__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3ACF30", Offset = "0x3AB730", Length = "0x87")]
	[Token(Token = "0x600177D")]
	public static extern IntPtr RailArrayGameServerPlayerInfo_SetValue(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3ECC30", Offset = "0x3EB430", Length = "0x78")]
	[Token(Token = "0x600177E")]
	public static extern void delete_RailArrayGameServerPlayerInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600177F")]
	[Address(RVA = "0x3ACFC0", Offset = "0x3AB7C0", Length = "0x93")]
	public static extern void RailArrayGameServerPlayerInfo_assign(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001780")]
	[Address(RVA = "0x3AD060", Offset = "0x3AB860", Length = "0x78")]
	public static extern IntPtr RailArrayGameServerPlayerInfo_buf(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001781")]
	[Address(RVA = "0x3AD310", Offset = "0x3ABB10", Length = "0x78")]
	public static extern uint RailArrayGameServerPlayerInfo_size(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001782")]
	[Address(RVA = "0x3ACEA0", Offset = "0x3AB6A0", Length = "0x85")]
	public static extern IntPtr RailArrayGameServerPlayerInfo_Item(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001783")]
	[Address(RVA = "0x3AD280", Offset = "0x3ABA80", Length = "0x85")]
	public static extern void RailArrayGameServerPlayerInfo_resize(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AD1F0", Offset = "0x3AB9F0", Length = "0x87")]
	[Token(Token = "0x6001784")]
	public static extern void RailArrayGameServerPlayerInfo_push_back(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001785")]
	[Address(RVA = "0x3AD0E0", Offset = "0x3AB8E0", Length = "0x78")]
	public static extern void RailArrayGameServerPlayerInfo_clear(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AD160", Offset = "0x3AB960", Length = "0x85")]
	[Token(Token = "0x6001786")]
	public static extern void RailArrayGameServerPlayerInfo_erase(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001787")]
	[Address(RVA = "0x407140", Offset = "0x405940", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsRequestAllAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001788")]
	[Address(RVA = "0x3EEEB0", Offset = "0x3ED6B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsRequestAllAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001789")]
	[Address(RVA = "0x3BE930", Offset = "0x3BD130", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsRequestAllAssetsFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600178A")]
	[Address(RVA = "0x3BE8B0", Offset = "0x3BD0B0", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsRequestAllAssetsFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600178B")]
	[Address(RVA = "0x4071B0", Offset = "0x4059B0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsRequestAllAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D3B0", Offset = "0x40BBB0", Length = "0x65")]
	[Token(Token = "0x600178C")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomTypeResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2330", Offset = "0x3F0B30", Length = "0x78")]
	[Token(Token = "0x600178D")]
	public static extern void delete_RailEventkRailEventRoomSetRoomTypeResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8020", Offset = "0x3C6820", Length = "0x65")]
	[Token(Token = "0x600178E")]
	public static extern int RailEventkRailEventRoomSetRoomTypeResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C7FA0", Offset = "0x3C67A0", Length = "0x78")]
	[Token(Token = "0x600178F")]
	public static extern int RailEventkRailEventRoomSetRoomTypeResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D420", Offset = "0x40BC20", Length = "0x78")]
	[Token(Token = "0x6001790")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomTypeResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407050", Offset = "0x405850", Length = "0x65")]
	[Token(Token = "0x6001791")]
	public static extern IntPtr new_RailEventkRailEventAssetsMergeToFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001792")]
	[Address(RVA = "0x3EEE30", Offset = "0x3ED630", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsMergeToFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001793")]
	[Address(RVA = "0x3BE7C0", Offset = "0x3BCFC0", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsMergeToFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001794")]
	[Address(RVA = "0x3BE740", Offset = "0x3BCF40", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsMergeToFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001795")]
	[Address(RVA = "0x4070C0", Offset = "0x4058C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsMergeToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001796")]
	[Address(RVA = "0x40F390", Offset = "0x40DB90", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSubscribeResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3430", Offset = "0x3F1C30", Length = "0x78")]
	[Token(Token = "0x6001797")]
	public static extern void delete_RailEventkRailEventUserSpaceSubscribeResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB100", Offset = "0x3C9900", Length = "0x65")]
	[Token(Token = "0x6001798")]
	public static extern int RailEventkRailEventUserSpaceSubscribeResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB080", Offset = "0x3C9880", Length = "0x78")]
	[Token(Token = "0x6001799")]
	public static extern int RailEventkRailEventUserSpaceSubscribeResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600179A")]
	[Address(RVA = "0x40F400", Offset = "0x40DC00", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSubscribeResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600179B")]
	[Address(RVA = "0x40C780", Offset = "0x40AF80", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMemberChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600179C")]
	[Address(RVA = "0x3F1CB0", Offset = "0x3F04B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomNotifyMemberChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600179D")]
	[Address(RVA = "0x3C6D70", Offset = "0x3C5570", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyMemberChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600179E")]
	[Address(RVA = "0x3C6CF0", Offset = "0x3C54F0", Length = "0x78")]
	public static extern int RailEventkRailEventRoomNotifyMemberChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600179F")]
	[Address(RVA = "0x40C7F0", Offset = "0x40AFF0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMemberChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x40A980", Offset = "0x409180", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0CB0", Offset = "0x3EF4B0", Length = "0x78")]
	[Token(Token = "0x60017A1")]
	public static extern void delete_RailEventkRailEventInGamePurchasePurchaseProductsResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3F70", Offset = "0x3C2770", Length = "0x65")]
	[Token(Token = "0x60017A2")]
	public static extern int RailEventkRailEventInGamePurchasePurchaseProductsResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x3C3EF0", Offset = "0x3C26F0", Length = "0x78")]
	public static extern int RailEventkRailEventInGamePurchasePurchaseProductsResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x40A9F0", Offset = "0x4091F0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B880", Offset = "0x40A080", Length = "0x65")]
	[Token(Token = "0x60017A5")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetEncryptedGameTicketResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x3F14B0", Offset = "0x3EFCB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventPlayerGetEncryptedGameTicketResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x3C5670", Offset = "0x3C3E70", Length = "0x65")]
	public static extern int RailEventkRailEventPlayerGetEncryptedGameTicketResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x3C55F0", Offset = "0x3C3DF0", Length = "0x78")]
	public static extern int RailEventkRailEventPlayerGetEncryptedGameTicketResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x40B8F0", Offset = "0x40A0F0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetEncryptedGameTicketResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x409B70", Offset = "0x408370", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x3F0530", Offset = "0x3EED30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGameServerListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x3C29E0", Offset = "0x3C11E0", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x3C2960", Offset = "0x3C1160", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409BE0", Offset = "0x4083E0", Length = "0x78")]
	[Token(Token = "0x60017AE")]
	public static extern IntPtr new_RailEventkRailEventGameServerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D1D0", Offset = "0x40B9D0", Length = "0x65")]
	[Token(Token = "0x60017AF")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2230", Offset = "0x3F0A30", Length = "0x78")]
	[Token(Token = "0x60017B0")]
	public static extern void delete_RailEventkRailEventRoomSetRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7D40", Offset = "0x3C6540", Length = "0x65")]
	[Token(Token = "0x60017B1")]
	public static extern int RailEventkRailEventRoomSetRoomMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C7CC0", Offset = "0x3C64C0", Length = "0x78")]
	[Token(Token = "0x60017B2")]
	public static extern int RailEventkRailEventRoomSetRoomMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x40D240", Offset = "0x40BA40", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x40B3D0", Offset = "0x409BD0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateRawSessionRequest__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1230", Offset = "0x3EFA30", Length = "0x78")]
	[Token(Token = "0x60017B5")]
	public static extern void delete_RailEventkRailEventNetworkCreateRawSessionRequest(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x3C4F40", Offset = "0x3C3740", Length = "0x65")]
	public static extern int RailEventkRailEventNetworkCreateRawSessionRequest_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x3C4EC0", Offset = "0x3C36C0", Length = "0x78")]
	public static extern int RailEventkRailEventNetworkCreateRawSessionRequest_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B440", Offset = "0x409C40", Length = "0x78")]
	[Token(Token = "0x60017B8")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateRawSessionRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B5B0", Offset = "0x409DB0", Length = "0x65")]
	[Token(Token = "0x60017B9")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateSessionRequest__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1330", Offset = "0x3EFB30", Length = "0x78")]
	[Token(Token = "0x60017BA")]
	public static extern void delete_RailEventkRailEventNetworkCreateSessionRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5220", Offset = "0x3C3A20", Length = "0x65")]
	[Token(Token = "0x60017BB")]
	public static extern int RailEventkRailEventNetworkCreateSessionRequest_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C51A0", Offset = "0x3C39A0", Length = "0x78")]
	[Token(Token = "0x60017BC")]
	public static extern int RailEventkRailEventNetworkCreateSessionRequest_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x40B620", Offset = "0x409E20", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateSessionRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406E70", Offset = "0x405670", Length = "0x65")]
	[Token(Token = "0x60017BE")]
	public static extern IntPtr new_RailEventkRailEventAssetsExchangeAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EED30", Offset = "0x3ED530", Length = "0x78")]
	[Token(Token = "0x60017BF")]
	public static extern void delete_RailEventkRailEventAssetsExchangeAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE4E0", Offset = "0x3BCCE0", Length = "0x65")]
	[Token(Token = "0x60017C0")]
	public static extern int RailEventkRailEventAssetsExchangeAssetsToFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BE460", Offset = "0x3BCC60", Length = "0x78")]
	[Token(Token = "0x60017C1")]
	public static extern int RailEventkRailEventAssetsExchangeAssetsToFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x406EE0", Offset = "0x4056E0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsExchangeAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410FB0", Offset = "0x40F7B0", Length = "0x65")]
	[Token(Token = "0x60017C3")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByUser__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x3F4330", Offset = "0x3F2B30", Length = "0x78")]
	public static extern void delete_RailEventkRailPlatformNotifyEventJoinGameByUser(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CDC20", Offset = "0x3CC420", Length = "0x65")]
	[Token(Token = "0x60017C5")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByUser_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CDBA0", Offset = "0x3CC3A0", Length = "0x78")]
	[Token(Token = "0x60017C6")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByUser_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411020", Offset = "0x40F820", Length = "0x78")]
	[Token(Token = "0x60017C7")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByUser__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408220", Offset = "0x406A20", Length = "0x65")]
	[Token(Token = "0x60017C8")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallProgress__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF7B0", Offset = "0x3EDFB0", Length = "0x78")]
	[Token(Token = "0x60017C9")]
	public static extern void delete_RailEventkRailEventDlcInstallProgress(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017CA")]
	[Address(RVA = "0x3C0310", Offset = "0x3BEB10", Length = "0x65")]
	public static extern int RailEventkRailEventDlcInstallProgress_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x3C0290", Offset = "0x3BEA90", Length = "0x78")]
	public static extern int RailEventkRailEventDlcInstallProgress_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408290", Offset = "0x406A90", Length = "0x78")]
	[Token(Token = "0x60017CC")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x40FCF0", Offset = "0x40E4F0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersNotifyInviter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x3F3930", Offset = "0x3F2130", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersNotifyInviter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x3CBF60", Offset = "0x3CA760", Length = "0x65")]
	public static extern int RailEventkRailEventUsersNotifyInviter_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CBEE0", Offset = "0x3CA6E0", Length = "0x78")]
	[Token(Token = "0x60017D0")]
	public static extern int RailEventkRailEventUsersNotifyInviter_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40FD60", Offset = "0x40E560", Length = "0x78")]
	[Token(Token = "0x60017D1")]
	public static extern IntPtr new_RailEventkRailEventUsersNotifyInviter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x409210", Offset = "0x407A10", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x3F0030", Offset = "0x3EE830", Length = "0x78")]
	public static extern void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1B80", Offset = "0x3C0380", Length = "0x65")]
	[Token(Token = "0x60017D4")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C1B00", Offset = "0x3C0300", Length = "0x78")]
	[Token(Token = "0x60017D5")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x409280", Offset = "0x407A80", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x40AE30", Offset = "0x409630", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardAsyncCreated__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x3F0F30", Offset = "0x3EF730", Length = "0x78")]
	public static extern void delete_RailEventkRailEventLeaderboardAsyncCreated(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C46A0", Offset = "0x3C2EA0", Length = "0x65")]
	[Token(Token = "0x60017D9")]
	public static extern int RailEventkRailEventLeaderboardAsyncCreated_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C4620", Offset = "0x3C2E20", Length = "0x78")]
	[Token(Token = "0x60017DA")]
	public static extern int RailEventkRailEventLeaderboardAsyncCreated_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x40AEA0", Offset = "0x4096A0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardAsyncCreated__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x40AF20", Offset = "0x409720", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardAttachSpaceWork__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x3F0FB0", Offset = "0x3EF7B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventLeaderboardAttachSpaceWork(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x3C4810", Offset = "0x3C3010", Length = "0x65")]
	public static extern int RailEventkRailEventLeaderboardAttachSpaceWork_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C4790", Offset = "0x3C2F90", Length = "0x78")]
	[Token(Token = "0x60017DF")]
	public static extern int RailEventkRailEventLeaderboardAttachSpaceWork_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x40AF90", Offset = "0x409790", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardAttachSpaceWork__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408F40", Offset = "0x407740", Length = "0x65")]
	[Token(Token = "0x60017E1")]
	public static extern IntPtr new_RailEventkRailEventFriendsMetadataChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x3EFEB0", Offset = "0x3EE6B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventFriendsMetadataChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x3C1730", Offset = "0x3BFF30", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsMetadataChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x3C16B0", Offset = "0x3BFEB0", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsMetadataChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408FB0", Offset = "0x4077B0", Length = "0x78")]
	[Token(Token = "0x60017E5")]
	public static extern IntPtr new_RailEventkRailEventFriendsMetadataChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x40C3C0", Offset = "0x40ABC0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomGetUserRoomListResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1AB0", Offset = "0x3F02B0", Length = "0x78")]
	[Token(Token = "0x60017E7")]
	public static extern void delete_RailEventkRailEventRoomGetUserRoomListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C67B0", Offset = "0x3C4FB0", Length = "0x65")]
	[Token(Token = "0x60017E8")]
	public static extern int RailEventkRailEventRoomGetUserRoomListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C6730", Offset = "0x3C4F30", Length = "0x78")]
	[Token(Token = "0x60017E9")]
	public static extern int RailEventkRailEventRoomGetUserRoomListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x40C430", Offset = "0x40AC30", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomGetUserRoomListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x407F50", Offset = "0x406750", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserTryNavigateNewPageRequest__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x3EF630", Offset = "0x3EDE30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserTryNavigateNewPageRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BFEC0", Offset = "0x3BE6C0", Length = "0x65")]
	[Token(Token = "0x60017ED")]
	public static extern int RailEventkRailEventBrowserTryNavigateNewPageRequest_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BFE40", Offset = "0x3BE640", Length = "0x78")]
	[Token(Token = "0x60017EE")]
	public static extern int RailEventkRailEventBrowserTryNavigateNewPageRequest_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407FC0", Offset = "0x4067C0", Length = "0x78")]
	[Token(Token = "0x60017EF")]
	public static extern IntPtr new_RailEventkRailEventBrowserTryNavigateNewPageRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4087C0", Offset = "0x406FC0", Length = "0x65")]
	[Token(Token = "0x60017F0")]
	public static extern IntPtr new_RailEventkRailEventDlcUninstallFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFAB0", Offset = "0x3EE2B0", Length = "0x78")]
	[Token(Token = "0x60017F1")]
	public static extern void delete_RailEventkRailEventDlcUninstallFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x3C0BB0", Offset = "0x3BF3B0", Length = "0x65")]
	public static extern int RailEventkRailEventDlcUninstallFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0B30", Offset = "0x3BF330", Length = "0x78")]
	[Token(Token = "0x60017F3")]
	public static extern int RailEventkRailEventDlcUninstallFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408830", Offset = "0x407030", Length = "0x78")]
	[Token(Token = "0x60017F4")]
	public static extern IntPtr new_RailEventkRailEventDlcUninstallFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407230", Offset = "0x405A30", Length = "0x65")]
	[Token(Token = "0x60017F5")]
	public static extern IntPtr new_RailEventkRailEventAssetsSplitFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEF30", Offset = "0x3ED730", Length = "0x78")]
	[Token(Token = "0x60017F6")]
	public static extern void delete_RailEventkRailEventAssetsSplitFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BEAA0", Offset = "0x3BD2A0", Length = "0x65")]
	[Token(Token = "0x60017F7")]
	public static extern int RailEventkRailEventAssetsSplitFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x3BEA20", Offset = "0x3BD220", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsSplitFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x4072A0", Offset = "0x405AA0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsSplitFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x409120", Offset = "0x407920", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFFB0", Offset = "0x3EE7B0", Length = "0x78")]
	[Token(Token = "0x60017FB")]
	public static extern void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x3C1A10", Offset = "0x3C0210", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C1990", Offset = "0x3C0190", Length = "0x78")]
	[Token(Token = "0x60017FD")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409190", Offset = "0x407990", Length = "0x78")]
	[Token(Token = "0x60017FE")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x40B1F0", Offset = "0x4099F0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardUploaded__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1130", Offset = "0x3EF930", Length = "0x78")]
	[Token(Token = "0x6001800")]
	public static extern void delete_RailEventkRailEventLeaderboardUploaded(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4C60", Offset = "0x3C3460", Length = "0x65")]
	[Token(Token = "0x6001801")]
	public static extern int RailEventkRailEventLeaderboardUploaded_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001802")]
	[Address(RVA = "0x3C4BE0", Offset = "0x3C33E0", Length = "0x78")]
	public static extern int RailEventkRailEventLeaderboardUploaded_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B260", Offset = "0x409A60", Length = "0x78")]
	[Token(Token = "0x6001803")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardUploaded__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001804")]
	[Address(RVA = "0x410A10", Offset = "0x40F210", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelRemoveUsersResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F4030", Offset = "0x3F2830", Length = "0x78")]
	[Token(Token = "0x6001805")]
	public static extern void delete_RailEventkRailEventVoiceChannelRemoveUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001806")]
	[Address(RVA = "0x3CD380", Offset = "0x3CBB80", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelRemoveUsersResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001807")]
	[Address(RVA = "0x3CD300", Offset = "0x3CBB00", Length = "0x78")]
	public static extern int RailEventkRailEventVoiceChannelRemoveUsersResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001808")]
	[Address(RVA = "0x410A80", Offset = "0x40F280", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelRemoveUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001809")]
	[Address(RVA = "0x40DC20", Offset = "0x40C420", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventSmallObjectServiceQueryObjectStateResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F27B0", Offset = "0x3F0FB0", Length = "0x78")]
	[Token(Token = "0x600180A")]
	public static extern void delete_RailEventkRailEventSmallObjectServiceQueryObjectStateResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600180B")]
	[Address(RVA = "0x3C8D10", Offset = "0x3C7510", Length = "0x65")]
	public static extern int RailEventkRailEventSmallObjectServiceQueryObjectStateResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600180C")]
	[Address(RVA = "0x3C8C90", Offset = "0x3C7490", Length = "0x78")]
	public static extern int RailEventkRailEventSmallObjectServiceQueryObjectStateResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600180D")]
	[Address(RVA = "0x40DC90", Offset = "0x40C490", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventSmallObjectServiceQueryObjectStateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4100B0", Offset = "0x40E8B0", Length = "0x65")]
	[Token(Token = "0x600180E")]
	public static extern IntPtr new_RailEventkRailEventUtilsGameSettingMetadataChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600180F")]
	[Address(RVA = "0x3F3B30", Offset = "0x3F2330", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUtilsGameSettingMetadataChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001810")]
	[Address(RVA = "0x3CC520", Offset = "0x3CAD20", Length = "0x65")]
	public static extern int RailEventkRailEventUtilsGameSettingMetadataChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001811")]
	[Address(RVA = "0x3CC4A0", Offset = "0x3CACA0", Length = "0x78")]
	public static extern int RailEventkRailEventUtilsGameSettingMetadataChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001812")]
	[Address(RVA = "0x410120", Offset = "0x40E920", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUtilsGameSettingMetadataChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4097B0", Offset = "0x407FB0", Length = "0x65")]
	[Token(Token = "0x6001813")]
	public static extern IntPtr new_RailEventkRailEventGameServerCreated__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001814")]
	[Address(RVA = "0x3F0330", Offset = "0x3EEB30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGameServerCreated(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2420", Offset = "0x3C0C20", Length = "0x65")]
	[Token(Token = "0x6001815")]
	public static extern int RailEventkRailEventGameServerCreated_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001816")]
	[Address(RVA = "0x3C23A0", Offset = "0x3C0BA0", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerCreated_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409820", Offset = "0x408020", Length = "0x78")]
	[Token(Token = "0x6001817")]
	public static extern IntPtr new_RailEventkRailEventGameServerCreated__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408400", Offset = "0x406C00", Length = "0x65")]
	[Token(Token = "0x6001818")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallStart__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF8B0", Offset = "0x3EE0B0", Length = "0x78")]
	[Token(Token = "0x6001819")]
	public static extern void delete_RailEventkRailEventDlcInstallStart(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C05F0", Offset = "0x3BEDF0", Length = "0x65")]
	[Token(Token = "0x600181A")]
	public static extern int RailEventkRailEventDlcInstallStart_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0570", Offset = "0x3BED70", Length = "0x78")]
	[Token(Token = "0x600181B")]
	public static extern int RailEventkRailEventDlcInstallStart_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600181C")]
	[Address(RVA = "0x408470", Offset = "0x406C70", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallStart__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600181D")]
	[Address(RVA = "0x40F840", Offset = "0x40E040", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersGetInviteDetailResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600181E")]
	[Address(RVA = "0x3F36B0", Offset = "0x3F1EB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersGetInviteDetailResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600181F")]
	[Address(RVA = "0x3CB830", Offset = "0x3CA030", Length = "0x65")]
	public static extern int RailEventkRailEventUsersGetInviteDetailResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB7B0", Offset = "0x3C9FB0", Length = "0x78")]
	[Token(Token = "0x6001820")]
	public static extern int RailEventkRailEventUsersGetInviteDetailResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F8B0", Offset = "0x40E0B0", Length = "0x78")]
	[Token(Token = "0x6001821")]
	public static extern IntPtr new_RailEventkRailEventUsersGetInviteDetailResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40EFD0", Offset = "0x40D7D0", Length = "0x65")]
	[Token(Token = "0x6001822")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceQuerySpaceWorksResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3230", Offset = "0x3F1A30", Length = "0x78")]
	[Token(Token = "0x6001823")]
	public static extern void delete_RailEventkRailEventUserSpaceQuerySpaceWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CAB40", Offset = "0x3C9340", Length = "0x65")]
	[Token(Token = "0x6001824")]
	public static extern int RailEventkRailEventUserSpaceQuerySpaceWorksResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001825")]
	[Address(RVA = "0x3CAAC0", Offset = "0x3C92C0", Length = "0x78")]
	public static extern int RailEventkRailEventUserSpaceQuerySpaceWorksResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001826")]
	[Address(RVA = "0x40F040", Offset = "0x40D840", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceQuerySpaceWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001827")]
	[Address(RVA = "0x406600", Offset = "0x404E00", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAchievementGlobalAchievementReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001828")]
	[Address(RVA = "0x3EE8B0", Offset = "0x3ED0B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAchievementGlobalAchievementReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BD7F0", Offset = "0x3BBFF0", Length = "0x65")]
	[Token(Token = "0x6001829")]
	public static extern int RailEventkRailEventAchievementGlobalAchievementReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600182A")]
	[Address(RVA = "0x3BD770", Offset = "0x3BBF70", Length = "0x78")]
	public static extern int RailEventkRailEventAchievementGlobalAchievementReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406670", Offset = "0x404E70", Length = "0x78")]
	[Token(Token = "0x600182B")]
	public static extern IntPtr new_RailEventkRailEventAchievementGlobalAchievementReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E490", Offset = "0x40CC90", Length = "0x65")]
	[Token(Token = "0x600182C")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncRenameStreamFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600182D")]
	[Address(RVA = "0x3F2C30", Offset = "0x3F1430", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncRenameStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9A00", Offset = "0x3C8200", Length = "0x65")]
	[Token(Token = "0x600182E")]
	public static extern int RailEventkRailEventStorageAsyncRenameStreamFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C9980", Offset = "0x3C8180", Length = "0x78")]
	[Token(Token = "0x600182F")]
	public static extern int RailEventkRailEventStorageAsyncRenameStreamFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E500", Offset = "0x40CD00", Length = "0x78")]
	[Token(Token = "0x6001830")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncRenameStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4093F0", Offset = "0x407BF0", Length = "0x65")]
	[Token(Token = "0x6001831")]
	public static extern IntPtr new_RailEventkRailEventFriendsReportPlayedWithUserListResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0130", Offset = "0x3EE930", Length = "0x78")]
	[Token(Token = "0x6001832")]
	public static extern void delete_RailEventkRailEventFriendsReportPlayedWithUserListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001833")]
	[Address(RVA = "0x3C1E60", Offset = "0x3C0660", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsReportPlayedWithUserListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001834")]
	[Address(RVA = "0x3C1DE0", Offset = "0x3C05E0", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsReportPlayedWithUserListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409460", Offset = "0x407C60", Length = "0x78")]
	[Token(Token = "0x6001835")]
	public static extern IntPtr new_RailEventkRailEventFriendsReportPlayedWithUserListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410560", Offset = "0x40ED60", Length = "0x65")]
	[Token(Token = "0x6001836")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelInviteEvent__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3DB0", Offset = "0x3F25B0", Length = "0x78")]
	[Token(Token = "0x6001837")]
	public static extern void delete_RailEventkRailEventVoiceChannelInviteEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001838")]
	[Address(RVA = "0x3CCC50", Offset = "0x3CB450", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelInviteEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001839")]
	[Address(RVA = "0x3CCBD0", Offset = "0x3CB3D0", Length = "0x78")]
	public static extern int RailEventkRailEventVoiceChannelInviteEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600183A")]
	[Address(RVA = "0x4105D0", Offset = "0x40EDD0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelInviteEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E670", Offset = "0x40CE70", Length = "0x65")]
	[Token(Token = "0x600183B")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncWriteStreamFileResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2D30", Offset = "0x3F1530", Length = "0x78")]
	[Token(Token = "0x600183C")]
	public static extern void delete_RailEventkRailEventStorageAsyncWriteStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9CE0", Offset = "0x3C84E0", Length = "0x65")]
	[Token(Token = "0x600183D")]
	public static extern int RailEventkRailEventStorageAsyncWriteStreamFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600183E")]
	[Address(RVA = "0x3C9C60", Offset = "0x3C8460", Length = "0x78")]
	public static extern int RailEventkRailEventStorageAsyncWriteStreamFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600183F")]
	[Address(RVA = "0x40E6E0", Offset = "0x40CEE0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncWriteStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001840")]
	[Address(RVA = "0x40C5A0", Offset = "0x40ADA0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomKickOffMemberResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001841")]
	[Address(RVA = "0x3F1BB0", Offset = "0x3F03B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomKickOffMemberResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001842")]
	[Address(RVA = "0x3C6A90", Offset = "0x3C5290", Length = "0x65")]
	public static extern int RailEventkRailEventRoomKickOffMemberResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001843")]
	[Address(RVA = "0x3C6A10", Offset = "0x3C5210", Length = "0x78")]
	public static extern int RailEventkRailEventRoomKickOffMemberResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001844")]
	[Address(RVA = "0x40C610", Offset = "0x40AE10", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomKickOffMemberResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001845")]
	[Address(RVA = "0x40DA40", Offset = "0x40C240", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventShowFloatingWindow__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F26B0", Offset = "0x3F0EB0", Length = "0x78")]
	[Token(Token = "0x6001846")]
	public static extern void delete_RailEventkRailEventShowFloatingWindow(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8A30", Offset = "0x3C7230", Length = "0x65")]
	[Token(Token = "0x6001847")]
	public static extern int RailEventkRailEventShowFloatingWindow_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C89B0", Offset = "0x3C71B0", Length = "0x78")]
	[Token(Token = "0x6001848")]
	public static extern int RailEventkRailEventShowFloatingWindow_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001849")]
	[Address(RVA = "0x40DAB0", Offset = "0x40C2B0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventShowFloatingWindow__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40CD20", Offset = "0x40B520", Length = "0x65")]
	[Token(Token = "0x600184A")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomOwnerChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1FB0", Offset = "0x3F07B0", Length = "0x78")]
	[Token(Token = "0x600184B")]
	public static extern void delete_RailEventkRailEventRoomNotifyRoomOwnerChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600184C")]
	[Address(RVA = "0x3C7610", Offset = "0x3C5E10", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyRoomOwnerChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600184D")]
	[Address(RVA = "0x3C7590", Offset = "0x3C5D90", Length = "0x78")]
	public static extern int RailEventkRailEventRoomNotifyRoomOwnerChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40CD90", Offset = "0x40B590", Length = "0x78")]
	[Token(Token = "0x600184E")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomOwnerChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4088B0", Offset = "0x4070B0", Length = "0x65")]
	[Token(Token = "0x600184F")]
	public static extern IntPtr new_RailEventkRailEventFinalize__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFB30", Offset = "0x3EE330", Length = "0x78")]
	[Token(Token = "0x6001850")]
	public static extern void delete_RailEventkRailEventFinalize(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001851")]
	[Address(RVA = "0x3C0D20", Offset = "0x3BF520", Length = "0x65")]
	public static extern int RailEventkRailEventFinalize_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001852")]
	[Address(RVA = "0x3C0CA0", Offset = "0x3BF4A0", Length = "0x78")]
	public static extern int RailEventkRailEventFinalize_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408920", Offset = "0x407120", Length = "0x78")]
	[Token(Token = "0x6001853")]
	public static extern IntPtr new_RailEventkRailEventFinalize__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001854")]
	[Address(RVA = "0x40F750", Offset = "0x40DF50", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersCancelInviteResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001855")]
	[Address(RVA = "0x3F3630", Offset = "0x3F1E30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersCancelInviteResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB6C0", Offset = "0x3C9EC0", Length = "0x65")]
	[Token(Token = "0x6001856")]
	public static extern int RailEventkRailEventUsersCancelInviteResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001857")]
	[Address(RVA = "0x3CB640", Offset = "0x3C9E40", Length = "0x78")]
	public static extern int RailEventkRailEventUsersCancelInviteResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001858")]
	[Address(RVA = "0x40F7C0", Offset = "0x40DFC0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUsersCancelInviteResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001859")]
	[Address(RVA = "0x408310", Offset = "0x406B10", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallStartResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600185A")]
	[Address(RVA = "0x3EF830", Offset = "0x3EE030", Length = "0x78")]
	public static extern void delete_RailEventkRailEventDlcInstallStartResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600185B")]
	[Address(RVA = "0x3C0480", Offset = "0x3BEC80", Length = "0x65")]
	public static extern int RailEventkRailEventDlcInstallStartResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0400", Offset = "0x3BEC00", Length = "0x78")]
	[Token(Token = "0x600185C")]
	public static extern int RailEventkRailEventDlcInstallStartResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408380", Offset = "0x406B80", Length = "0x78")]
	[Token(Token = "0x600185D")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallStartResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4078C0", Offset = "0x4060C0", Length = "0x65")]
	[Token(Token = "0x600185E")]
	public static extern IntPtr new_RailEventkRailEventBrowserDamageRectPaint__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600185F")]
	[Address(RVA = "0x3EF2B0", Offset = "0x3EDAB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserDamageRectPaint(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF4B0", Offset = "0x3BDCB0", Length = "0x65")]
	[Token(Token = "0x6001860")]
	public static extern int RailEventkRailEventBrowserDamageRectPaint_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF430", Offset = "0x3BDC30", Length = "0x78")]
	[Token(Token = "0x6001861")]
	public static extern int RailEventkRailEventBrowserDamageRectPaint_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407930", Offset = "0x406130", Length = "0x78")]
	[Token(Token = "0x6001862")]
	public static extern IntPtr new_RailEventkRailEventBrowserDamageRectPaint__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001863")]
	[Address(RVA = "0x407500", Offset = "0x405D00", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsUpdateAssetPropertyFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001864")]
	[Address(RVA = "0x3EF0B0", Offset = "0x3ED8B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsUpdateAssetPropertyFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001865")]
	[Address(RVA = "0x3BEEF0", Offset = "0x3BD6F0", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsUpdateAssetPropertyFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001866")]
	[Address(RVA = "0x3BEE70", Offset = "0x3BD670", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsUpdateAssetPropertyFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407570", Offset = "0x405D70", Length = "0x78")]
	[Token(Token = "0x6001867")]
	public static extern IntPtr new_RailEventkRailEventAssetsUpdateAssetPropertyFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C1E0", Offset = "0x40A9E0", Length = "0x65")]
	[Token(Token = "0x6001868")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001869")]
	[Address(RVA = "0x3F19B0", Offset = "0x3F01B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomGetRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600186A")]
	[Address(RVA = "0x3C64D0", Offset = "0x3C4CD0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomGetRoomMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600186B")]
	[Address(RVA = "0x3C6450", Offset = "0x3C4C50", Length = "0x78")]
	public static extern int RailEventkRailEventRoomGetRoomMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C250", Offset = "0x40AA50", Length = "0x78")]
	[Token(Token = "0x600186C")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410CE0", Offset = "0x40F4E0", Length = "0x65")]
	[Token(Token = "0x600186D")]
	public static extern IntPtr new_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F41B0", Offset = "0x3F29B0", Length = "0x78")]
	[Token(Token = "0x600186E")]
	public static extern void delete_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CD7D0", Offset = "0x3CBFD0", Length = "0x65")]
	[Token(Token = "0x600186F")]
	public static extern int RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001870")]
	[Address(RVA = "0x3CD750", Offset = "0x3CBF50", Length = "0x78")]
	public static extern int RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410D50", Offset = "0x40F550", Length = "0x78")]
	[Token(Token = "0x6001871")]
	public static extern IntPtr new_RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B970", Offset = "0x40A170", Length = "0x65")]
	[Token(Token = "0x6001872")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetGamePurchaseKey__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001873")]
	[Address(RVA = "0x3F1530", Offset = "0x3EFD30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventPlayerGetGamePurchaseKey(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001874")]
	[Address(RVA = "0x3C57E0", Offset = "0x3C3FE0", Length = "0x65")]
	public static extern int RailEventkRailEventPlayerGetGamePurchaseKey_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C5760", Offset = "0x3C3F60", Length = "0x78")]
	[Token(Token = "0x6001875")]
	public static extern int RailEventkRailEventPlayerGetGamePurchaseKey_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B9E0", Offset = "0x40A1E0", Length = "0x78")]
	[Token(Token = "0x6001876")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetGamePurchaseKey__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001877")]
	[Address(RVA = "0x410EC0", Offset = "0x40F6C0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByRoom__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001878")]
	[Address(RVA = "0x3F42B0", Offset = "0x3F2AB0", Length = "0x78")]
	public static extern void delete_RailEventkRailPlatformNotifyEventJoinGameByRoom(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001879")]
	[Address(RVA = "0x3CDAB0", Offset = "0x3CC2B0", Length = "0x65")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByRoom_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600187A")]
	[Address(RVA = "0x3CDA30", Offset = "0x3CC230", Length = "0x78")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByRoom_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600187B")]
	[Address(RVA = "0x410F30", Offset = "0x40F730", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByRoom__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40CF00", Offset = "0x40B700", Length = "0x65")]
	[Token(Token = "0x600187C")]
	public static extern IntPtr new_RailEventkRailEventRoomSetMemberMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F20B0", Offset = "0x3F08B0", Length = "0x78")]
	[Token(Token = "0x600187D")]
	public static extern void delete_RailEventkRailEventRoomSetMemberMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C78F0", Offset = "0x3C60F0", Length = "0x65")]
	[Token(Token = "0x600187E")]
	public static extern int RailEventkRailEventRoomSetMemberMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600187F")]
	[Address(RVA = "0x3C7870", Offset = "0x3C6070", Length = "0x78")]
	public static extern int RailEventkRailEventRoomSetMemberMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001880")]
	[Address(RVA = "0x40CF70", Offset = "0x40B770", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomSetMemberMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001881")]
	[Address(RVA = "0x40EEE0", Offset = "0x40D6E0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceModifyFavoritesWorksResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F31B0", Offset = "0x3F19B0", Length = "0x78")]
	[Token(Token = "0x6001882")]
	public static extern void delete_RailEventkRailEventUserSpaceModifyFavoritesWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001883")]
	[Address(RVA = "0x3CA9D0", Offset = "0x3C91D0", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceModifyFavoritesWorksResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001884")]
	[Address(RVA = "0x3CA950", Offset = "0x3C9150", Length = "0x78")]
	public static extern int RailEventkRailEventUserSpaceModifyFavoritesWorksResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001885")]
	[Address(RVA = "0x40EF50", Offset = "0x40D750", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceModifyFavoritesWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001886")]
	[Address(RVA = "0x410B00", Offset = "0x40F300", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001887")]
	[Address(RVA = "0x3F40B0", Offset = "0x3F28B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001888")]
	[Address(RVA = "0x3CD4F0", Offset = "0x3CBCF0", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001889")]
	[Address(RVA = "0x3CD470", Offset = "0x3CBC70", Length = "0x78")]
	public static extern int RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600188A")]
	[Address(RVA = "0x410B70", Offset = "0x40F370", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600188B")]
	[Address(RVA = "0x40FDE0", Offset = "0x40E5E0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersRespondInvitation__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600188C")]
	[Address(RVA = "0x3F39B0", Offset = "0x3F21B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersRespondInvitation(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC0D0", Offset = "0x3CA8D0", Length = "0x65")]
	[Token(Token = "0x600188D")]
	public static extern int RailEventkRailEventUsersRespondInvitation_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600188E")]
	[Address(RVA = "0x3CC050", Offset = "0x3CA850", Length = "0x78")]
	public static extern int RailEventkRailEventUsersRespondInvitation_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40FE50", Offset = "0x40E650", Length = "0x78")]
	[Token(Token = "0x600188F")]
	public static extern IntPtr new_RailEventkRailEventUsersRespondInvitation__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406C90", Offset = "0x405490", Length = "0x65")]
	[Token(Token = "0x6001890")]
	public static extern IntPtr new_RailEventkRailEventAssetsDirectConsumeFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEC30", Offset = "0x3ED430", Length = "0x78")]
	[Token(Token = "0x6001891")]
	public static extern void delete_RailEventkRailEventAssetsDirectConsumeFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE200", Offset = "0x3BCA00", Length = "0x65")]
	[Token(Token = "0x6001892")]
	public static extern int RailEventkRailEventAssetsDirectConsumeFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001893")]
	[Address(RVA = "0x3BE180", Offset = "0x3BC980", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsDirectConsumeFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001894")]
	[Address(RVA = "0x406D00", Offset = "0x405500", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsDirectConsumeFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001895")]
	[Address(RVA = "0x40E580", Offset = "0x40CD80", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncWriteFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001896")]
	[Address(RVA = "0x3F2CB0", Offset = "0x3F14B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncWriteFileResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001897")]
	[Address(RVA = "0x3C9B70", Offset = "0x3C8370", Length = "0x65")]
	public static extern int RailEventkRailEventStorageAsyncWriteFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C9AF0", Offset = "0x3C82F0", Length = "0x78")]
	[Token(Token = "0x6001898")]
	public static extern int RailEventkRailEventStorageAsyncWriteFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001899")]
	[Address(RVA = "0x40E5F0", Offset = "0x40CDF0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncWriteFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600189A")]
	[Address(RVA = "0x40ED00", Offset = "0x40D500", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600189B")]
	[Address(RVA = "0x3F30B0", Offset = "0x3F18B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600189C")]
	[Address(RVA = "0x3CA6F0", Offset = "0x3C8EF0", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CA670", Offset = "0x3C8E70", Length = "0x78")]
	[Token(Token = "0x600189D")]
	public static extern int RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40ED70", Offset = "0x40D570", Length = "0x78")]
	[Token(Token = "0x600189E")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceGetMyFavoritesWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600189F")]
	[Address(RVA = "0x40CB40", Offset = "0x40B340", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomDestroyed__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018A0")]
	[Address(RVA = "0x3F1EB0", Offset = "0x3F06B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomNotifyRoomDestroyed(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018A1")]
	[Address(RVA = "0x3C7330", Offset = "0x3C5B30", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyRoomDestroyed_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C72B0", Offset = "0x3C5AB0", Length = "0x78")]
	[Token(Token = "0x60018A2")]
	public static extern int RailEventkRailEventRoomNotifyRoomDestroyed_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40CBB0", Offset = "0x40B3B0", Length = "0x78")]
	[Token(Token = "0x60018A3")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomDestroyed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018A4")]
	[Address(RVA = "0x407B90", Offset = "0x406390", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserPaint__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018A5")]
	[Address(RVA = "0x3EF430", Offset = "0x3EDC30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserPaint(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF900", Offset = "0x3BE100", Length = "0x65")]
	[Token(Token = "0x60018A6")]
	public static extern int RailEventkRailEventBrowserPaint_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018A7")]
	[Address(RVA = "0x3BF880", Offset = "0x3BE080", Length = "0x78")]
	public static extern int RailEventkRailEventBrowserPaint_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407C00", Offset = "0x406400", Length = "0x78")]
	[Token(Token = "0x60018A8")]
	public static extern IntPtr new_RailEventkRailEventBrowserPaint__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406D80", Offset = "0x405580", Length = "0x65")]
	[Token(Token = "0x60018A9")]
	public static extern IntPtr new_RailEventkRailEventAssetsExchangeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018AA")]
	[Address(RVA = "0x3EECB0", Offset = "0x3ED4B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsExchangeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018AB")]
	[Address(RVA = "0x3BE370", Offset = "0x3BCB70", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsExchangeAssetsFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018AC")]
	[Address(RVA = "0x3BE2F0", Offset = "0x3BCAF0", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsExchangeAssetsFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018AD")]
	[Address(RVA = "0x406DF0", Offset = "0x4055F0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsExchangeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018AE")]
	[Address(RVA = "0x40A7A0", Offset = "0x408FA0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018AF")]
	[Address(RVA = "0x3F0BB0", Offset = "0x3EF3B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018B0")]
	[Address(RVA = "0x3C3C90", Offset = "0x3C2490", Length = "0x65")]
	public static extern int RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018B1")]
	[Address(RVA = "0x3C3C10", Offset = "0x3C2410", Length = "0x78")]
	public static extern int RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018B2")]
	[Address(RVA = "0x40A810", Offset = "0x409010", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408C70", Offset = "0x407470", Length = "0x65")]
	[Token(Token = "0x60018B3")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetFriendPlayedGamesResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFD30", Offset = "0x3EE530", Length = "0x78")]
	[Token(Token = "0x60018B4")]
	public static extern void delete_RailEventkRailEventFriendsGetFriendPlayedGamesResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C12E0", Offset = "0x3BFAE0", Length = "0x65")]
	[Token(Token = "0x60018B5")]
	public static extern int RailEventkRailEventFriendsGetFriendPlayedGamesResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018B6")]
	[Address(RVA = "0x3C1260", Offset = "0x3BFA60", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsGetFriendPlayedGamesResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408CE0", Offset = "0x4074E0", Length = "0x78")]
	[Token(Token = "0x60018B7")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetFriendPlayedGamesResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408A90", Offset = "0x407290", Length = "0x65")]
	[Token(Token = "0x60018B8")]
	public static extern IntPtr new_RailEventkRailEventFriendsClearMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFC30", Offset = "0x3EE430", Length = "0x78")]
	[Token(Token = "0x60018B9")]
	public static extern void delete_RailEventkRailEventFriendsClearMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x3C1000", Offset = "0x3BF800", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsClearMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0F80", Offset = "0x3BF780", Length = "0x78")]
	[Token(Token = "0x60018BB")]
	public static extern int RailEventkRailEventFriendsClearMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408B00", Offset = "0x407300", Length = "0x78")]
	[Token(Token = "0x60018BC")]
	public static extern IntPtr new_RailEventkRailEventFriendsClearMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410830", Offset = "0x40F030", Length = "0x65")]
	[Token(Token = "0x60018BD")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelMemberChangedEvent__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3F30", Offset = "0x3F2730", Length = "0x78")]
	[Token(Token = "0x60018BE")]
	public static extern void delete_RailEventkRailEventVoiceChannelMemberChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x3CD0A0", Offset = "0x3CB8A0", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelMemberChangedEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CD020", Offset = "0x3CB820", Length = "0x78")]
	[Token(Token = "0x60018C0")]
	public static extern int RailEventkRailEventVoiceChannelMemberChangedEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4108A0", Offset = "0x40F0A0", Length = "0x78")]
	[Token(Token = "0x60018C1")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelMemberChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4089A0", Offset = "0x4071A0", Length = "0x65")]
	[Token(Token = "0x60018C2")]
	public static extern IntPtr new_RailEventkRailEventFriendsAddFriendResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x3EFBB0", Offset = "0x3EE3B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventFriendsAddFriendResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C0E90", Offset = "0x3BF690", Length = "0x65")]
	[Token(Token = "0x60018C4")]
	public static extern int RailEventkRailEventFriendsAddFriendResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0E10", Offset = "0x3BF610", Length = "0x78")]
	[Token(Token = "0x60018C5")]
	public static extern int RailEventkRailEventFriendsAddFriendResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408A10", Offset = "0x407210", Length = "0x78")]
	[Token(Token = "0x60018C6")]
	public static extern IntPtr new_RailEventkRailEventFriendsAddFriendResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A6B0", Offset = "0x408EB0", Length = "0x65")]
	[Token(Token = "0x60018C7")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseAllProductsInfoReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0B30", Offset = "0x3EF330", Length = "0x78")]
	[Token(Token = "0x60018C8")]
	public static extern void delete_RailEventkRailEventInGamePurchaseAllProductsInfoReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x3C3B20", Offset = "0x3C2320", Length = "0x65")]
	public static extern int RailEventkRailEventInGamePurchaseAllProductsInfoReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x3C3AA0", Offset = "0x3C22A0", Length = "0x78")]
	public static extern int RailEventkRailEventInGamePurchaseAllProductsInfoReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A720", Offset = "0x408F20", Length = "0x78")]
	[Token(Token = "0x60018CB")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseAllProductsInfoReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406F60", Offset = "0x405760", Length = "0x65")]
	[Token(Token = "0x60018CC")]
	public static extern IntPtr new_RailEventkRailEventAssetsMergeFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEDB0", Offset = "0x3ED5B0", Length = "0x78")]
	[Token(Token = "0x60018CD")]
	public static extern void delete_RailEventkRailEventAssetsMergeFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE650", Offset = "0x3BCE50", Length = "0x65")]
	[Token(Token = "0x60018CE")]
	public static extern int RailEventkRailEventAssetsMergeFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x3BE5D0", Offset = "0x3BCDD0", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsMergeFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406FD0", Offset = "0x4057D0", Length = "0x78")]
	[Token(Token = "0x60018D0")]
	public static extern IntPtr new_RailEventkRailEventAssetsMergeFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C870", Offset = "0x40B070", Length = "0x65")]
	[Token(Token = "0x60018D1")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMemberkicked__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1D30", Offset = "0x3F0530", Length = "0x78")]
	[Token(Token = "0x60018D2")]
	public static extern void delete_RailEventkRailEventRoomNotifyMemberkicked(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x3C6EE0", Offset = "0x3C56E0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyMemberkicked_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x3C6E60", Offset = "0x3C5660", Length = "0x78")]
	public static extern int RailEventkRailEventRoomNotifyMemberkicked_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x40C8E0", Offset = "0x40B0E0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMemberkicked__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C4B0", Offset = "0x40ACB0", Length = "0x65")]
	[Token(Token = "0x60018D6")]
	public static extern IntPtr new_RailEventkRailEventRoomJoinRoomResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1B30", Offset = "0x3F0330", Length = "0x78")]
	[Token(Token = "0x60018D7")]
	public static extern void delete_RailEventkRailEventRoomJoinRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6920", Offset = "0x3C5120", Length = "0x65")]
	[Token(Token = "0x60018D8")]
	public static extern int RailEventkRailEventRoomJoinRoomResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C68A0", Offset = "0x3C50A0", Length = "0x78")]
	[Token(Token = "0x60018D9")]
	public static extern int RailEventkRailEventRoomJoinRoomResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x40C520", Offset = "0x40AD20", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomJoinRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x4096C0", Offset = "0x407EC0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerAuthSessionTicket__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x3F02B0", Offset = "0x3EEAB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGameServerAuthSessionTicket(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x3C22B0", Offset = "0x3C0AB0", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerAuthSessionTicket_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C2230", Offset = "0x3C0A30", Length = "0x78")]
	[Token(Token = "0x60018DE")]
	public static extern int RailEventkRailEventGameServerAuthSessionTicket_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018DF")]
	[Address(RVA = "0x409730", Offset = "0x407F30", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerAuthSessionTicket__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018E0")]
	[Address(RVA = "0x409300", Offset = "0x407B00", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F00B0", Offset = "0x3EE8B0", Length = "0x78")]
	[Token(Token = "0x60018E1")]
	public static extern void delete_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1CF0", Offset = "0x3C04F0", Length = "0x65")]
	[Token(Token = "0x60018E2")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018E3")]
	[Address(RVA = "0x3C1C70", Offset = "0x3C0470", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409370", Offset = "0x407B70", Length = "0x78")]
	[Token(Token = "0x60018E4")]
	public static extern IntPtr new_RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018E5")]
	[Address(RVA = "0x409D50", Offset = "0x408550", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerRegisterToServerListResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0630", Offset = "0x3EEE30", Length = "0x78")]
	[Token(Token = "0x60018E6")]
	public static extern void delete_RailEventkRailEventGameServerRegisterToServerListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2CC0", Offset = "0x3C14C0", Length = "0x65")]
	[Token(Token = "0x60018E7")]
	public static extern int RailEventkRailEventGameServerRegisterToServerListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018E8")]
	[Address(RVA = "0x3C2C40", Offset = "0x3C1440", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerRegisterToServerListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018E9")]
	[Address(RVA = "0x409DC0", Offset = "0x4085C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerRegisterToServerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018EA")]
	[Address(RVA = "0x40AD40", Offset = "0x409540", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePaymentResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018EB")]
	[Address(RVA = "0x3F0EB0", Offset = "0x3EF6B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventInGameStorePurchasePaymentResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018EC")]
	[Address(RVA = "0x3C4530", Offset = "0x3C2D30", Length = "0x65")]
	public static extern int RailEventkRailEventInGameStorePurchasePaymentResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60018ED")]
	[Address(RVA = "0x3C44B0", Offset = "0x3C2CB0", Length = "0x78")]
	public static extern int RailEventkRailEventInGameStorePurchasePaymentResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018EE")]
	[Address(RVA = "0x40ADB0", Offset = "0x4095B0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePaymentResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018EF")]
	[Address(RVA = "0x408040", Offset = "0x406840", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventDlcCheckAllDlcsStateReadyResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF6B0", Offset = "0x3EDEB0", Length = "0x78")]
	[Token(Token = "0x60018F0")]
	public static extern void delete_RailEventkRailEventDlcCheckAllDlcsStateReadyResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018F1")]
	[Address(RVA = "0x3C0030", Offset = "0x3BE830", Length = "0x65")]
	public static extern int RailEventkRailEventDlcCheckAllDlcsStateReadyResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BFFB0", Offset = "0x3BE7B0", Length = "0x78")]
	[Token(Token = "0x60018F2")]
	public static extern int RailEventkRailEventDlcCheckAllDlcsStateReadyResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4080B0", Offset = "0x4068B0", Length = "0x78")]
	[Token(Token = "0x60018F3")]
	public static extern IntPtr new_RailEventkRailEventDlcCheckAllDlcsStateReadyResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D590", Offset = "0x40BD90", Length = "0x65")]
	[Token(Token = "0x60018F4")]
	public static extern IntPtr new_RailEventkRailEventScreenshotTakeScreenshotFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x3F2430", Offset = "0x3F0C30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventScreenshotTakeScreenshotFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8300", Offset = "0x3C6B00", Length = "0x65")]
	[Token(Token = "0x60018F6")]
	public static extern int RailEventkRailEventScreenshotTakeScreenshotFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C8280", Offset = "0x3C6A80", Length = "0x78")]
	[Token(Token = "0x60018F7")]
	public static extern int RailEventkRailEventScreenshotTakeScreenshotFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x40D600", Offset = "0x40BE00", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventScreenshotTakeScreenshotFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018F9")]
	[Address(RVA = "0x407C80", Offset = "0x406480", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserReloadResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF4B0", Offset = "0x3EDCB0", Length = "0x78")]
	[Token(Token = "0x60018FA")]
	public static extern void delete_RailEventkRailEventBrowserReloadResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60018FB")]
	[Address(RVA = "0x3BFA70", Offset = "0x3BE270", Length = "0x65")]
	public static extern int RailEventkRailEventBrowserReloadResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF9F0", Offset = "0x3BE1F0", Length = "0x78")]
	[Token(Token = "0x60018FC")]
	public static extern int RailEventkRailEventBrowserReloadResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407CF0", Offset = "0x4064F0", Length = "0x78")]
	[Token(Token = "0x60018FD")]
	public static extern IntPtr new_RailEventkRailEventBrowserReloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D950", Offset = "0x40C150", Length = "0x65")]
	[Token(Token = "0x60018FE")]
	public static extern IntPtr new_RailEventkRailEventShowFloatingNotifyWindow__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60018FF")]
	[Address(RVA = "0x3F2630", Offset = "0x3F0E30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventShowFloatingNotifyWindow(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001900")]
	[Address(RVA = "0x3C88C0", Offset = "0x3C70C0", Length = "0x65")]
	public static extern int RailEventkRailEventShowFloatingNotifyWindow_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C8840", Offset = "0x3C7040", Length = "0x78")]
	[Token(Token = "0x6001901")]
	public static extern int RailEventkRailEventShowFloatingNotifyWindow_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001902")]
	[Address(RVA = "0x40D9C0", Offset = "0x40C1C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventShowFloatingNotifyWindow__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40AA70", Offset = "0x409270", Length = "0x65")]
	[Token(Token = "0x6001903")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0D30", Offset = "0x3EF530", Length = "0x78")]
	[Token(Token = "0x6001904")]
	public static extern void delete_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C40E0", Offset = "0x3C28E0", Length = "0x65")]
	[Token(Token = "0x6001905")]
	public static extern int RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001906")]
	[Address(RVA = "0x3C4060", Offset = "0x3C2860", Length = "0x78")]
	public static extern int RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001907")]
	[Address(RVA = "0x40AAE0", Offset = "0x4092E0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A5C0", Offset = "0x408DC0", Length = "0x65")]
	[Token(Token = "0x6001908")]
	public static extern IntPtr new_RailEventkRailEventInGameCoinRequestCoinInfoResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001909")]
	[Address(RVA = "0x3F0AB0", Offset = "0x3EF2B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventInGameCoinRequestCoinInfoResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600190A")]
	[Address(RVA = "0x3C39B0", Offset = "0x3C21B0", Length = "0x65")]
	public static extern int RailEventkRailEventInGameCoinRequestCoinInfoResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C3930", Offset = "0x3C2130", Length = "0x78")]
	[Token(Token = "0x600190B")]
	public static extern int RailEventkRailEventInGameCoinRequestCoinInfoResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A630", Offset = "0x408E30", Length = "0x78")]
	[Token(Token = "0x600190C")]
	public static extern IntPtr new_RailEventkRailEventInGameCoinRequestCoinInfoResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D0E0", Offset = "0x40B8E0", Length = "0x65")]
	[Token(Token = "0x600190D")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomMaxMemberResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F21B0", Offset = "0x3F09B0", Length = "0x78")]
	[Token(Token = "0x600190E")]
	public static extern void delete_RailEventkRailEventRoomSetRoomMaxMemberResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600190F")]
	[Address(RVA = "0x3C7BD0", Offset = "0x3C63D0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomSetRoomMaxMemberResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C7B50", Offset = "0x3C6350", Length = "0x78")]
	[Token(Token = "0x6001910")]
	public static extern int RailEventkRailEventRoomSetRoomMaxMemberResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D150", Offset = "0x40B950", Length = "0x78")]
	[Token(Token = "0x6001911")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomMaxMemberResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40FFC0", Offset = "0x40E7C0", Length = "0x65")]
	[Token(Token = "0x6001912")]
	public static extern IntPtr new_RailEventkRailEventUsersShowUserHomepageWindowResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001913")]
	[Address(RVA = "0x3F3AB0", Offset = "0x3F22B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersShowUserHomepageWindowResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC3B0", Offset = "0x3CABB0", Length = "0x65")]
	[Token(Token = "0x6001914")]
	public static extern int RailEventkRailEventUsersShowUserHomepageWindowResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CC330", Offset = "0x3CAB30", Length = "0x78")]
	[Token(Token = "0x6001915")]
	public static extern int RailEventkRailEventUsersShowUserHomepageWindowResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001916")]
	[Address(RVA = "0x410030", Offset = "0x40E830", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUsersShowUserHomepageWindowResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40AC50", Offset = "0x409450", Length = "0x65")]
	[Token(Token = "0x6001917")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowDisplayed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0E30", Offset = "0x3EF630", Length = "0x78")]
	[Token(Token = "0x6001918")]
	public static extern void delete_RailEventkRailEventInGameStorePurchasePayWindowDisplayed(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001919")]
	[Address(RVA = "0x3C43C0", Offset = "0x3C2BC0", Length = "0x65")]
	public static extern int RailEventkRailEventInGameStorePurchasePayWindowDisplayed_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600191A")]
	[Address(RVA = "0x3C4340", Offset = "0x3C2B40", Length = "0x78")]
	public static extern int RailEventkRailEventInGameStorePurchasePayWindowDisplayed_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600191B")]
	[Address(RVA = "0x40ACC0", Offset = "0x4094C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowDisplayed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600191C")]
	[Address(RVA = "0x4076E0", Offset = "0x405EE0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserCloseResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600191D")]
	[Address(RVA = "0x3EF1B0", Offset = "0x3ED9B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserCloseResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600191E")]
	[Address(RVA = "0x3BF1D0", Offset = "0x3BD9D0", Length = "0x65")]
	public static extern int RailEventkRailEventBrowserCloseResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF150", Offset = "0x3BD950", Length = "0x78")]
	[Token(Token = "0x600191F")]
	public static extern int RailEventkRailEventBrowserCloseResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001920")]
	[Address(RVA = "0x407750", Offset = "0x405F50", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventBrowserCloseResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001921")]
	[Address(RVA = "0x40A3E0", Offset = "0x408BE0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventIMEHelperTextInputSelectedResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001922")]
	[Address(RVA = "0x3F09B0", Offset = "0x3EF1B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventIMEHelperTextInputSelectedResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001923")]
	[Address(RVA = "0x3C36D0", Offset = "0x3C1ED0", Length = "0x65")]
	public static extern int RailEventkRailEventIMEHelperTextInputSelectedResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001924")]
	[Address(RVA = "0x3C3650", Offset = "0x3C1E50", Length = "0x78")]
	public static extern int RailEventkRailEventIMEHelperTextInputSelectedResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001925")]
	[Address(RVA = "0x40A450", Offset = "0x408C50", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventIMEHelperTextInputSelectedResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A110", Offset = "0x408910", Length = "0x65")]
	[Token(Token = "0x6001926")]
	public static extern IntPtr new_RailEventkRailEventGroupChatQueryGroupsInfoResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0830", Offset = "0x3EF030", Length = "0x78")]
	[Token(Token = "0x6001927")]
	public static extern void delete_RailEventkRailEventGroupChatQueryGroupsInfoResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3280", Offset = "0x3C1A80", Length = "0x65")]
	[Token(Token = "0x6001928")]
	public static extern int RailEventkRailEventGroupChatQueryGroupsInfoResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C3200", Offset = "0x3C1A00", Length = "0x78")]
	[Token(Token = "0x6001929")]
	public static extern int RailEventkRailEventGroupChatQueryGroupsInfoResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A180", Offset = "0x408980", Length = "0x78")]
	[Token(Token = "0x600192A")]
	public static extern IntPtr new_RailEventkRailEventGroupChatQueryGroupsInfoResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600192B")]
	[Address(RVA = "0x40EA30", Offset = "0x40D230", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventTextInputShowTextInputWindowResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2F30", Offset = "0x3F1730", Length = "0x78")]
	[Token(Token = "0x600192C")]
	public static extern void delete_RailEventkRailEventTextInputShowTextInputWindowResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CA2A0", Offset = "0x3C8AA0", Length = "0x65")]
	[Token(Token = "0x600192D")]
	public static extern int RailEventkRailEventTextInputShowTextInputWindowResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600192E")]
	[Address(RVA = "0x3CA220", Offset = "0x3C8A20", Length = "0x78")]
	public static extern int RailEventkRailEventTextInputShowTextInputWindowResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40EAA0", Offset = "0x40D2A0", Length = "0x78")]
	[Token(Token = "0x600192F")]
	public static extern IntPtr new_RailEventkRailEventTextInputShowTextInputWindowResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409F30", Offset = "0x408730", Length = "0x65")]
	[Token(Token = "0x6001930")]
	public static extern IntPtr new_RailEventkRailEventGameServerSetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0730", Offset = "0x3EEF30", Length = "0x78")]
	[Token(Token = "0x6001931")]
	public static extern void delete_RailEventkRailEventGameServerSetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001932")]
	[Address(RVA = "0x3C2FA0", Offset = "0x3C17A0", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerSetMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001933")]
	[Address(RVA = "0x3C2F20", Offset = "0x3C1720", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerSetMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409FA0", Offset = "0x4087A0", Length = "0x78")]
	[Token(Token = "0x6001934")]
	public static extern IntPtr new_RailEventkRailEventGameServerSetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001935")]
	[Address(RVA = "0x40EB20", Offset = "0x40D320", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceDownloadProgress__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001936")]
	[Address(RVA = "0x3F2FB0", Offset = "0x3F17B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceDownloadProgress(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CA410", Offset = "0x3C8C10", Length = "0x65")]
	[Token(Token = "0x6001937")]
	public static extern int RailEventkRailEventUserSpaceDownloadProgress_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CA390", Offset = "0x3C8B90", Length = "0x78")]
	[Token(Token = "0x6001938")]
	public static extern int RailEventkRailEventUserSpaceDownloadProgress_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001939")]
	[Address(RVA = "0x40EB90", Offset = "0x40D390", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceDownloadProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40FC00", Offset = "0x40E400", Length = "0x65")]
	[Token(Token = "0x600193A")]
	public static extern IntPtr new_RailEventkRailEventUsersInviteUsersResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600193B")]
	[Address(RVA = "0x3F38B0", Offset = "0x3F20B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersInviteUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600193C")]
	[Address(RVA = "0x3CBDF0", Offset = "0x3CA5F0", Length = "0x65")]
	public static extern int RailEventkRailEventUsersInviteUsersResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600193D")]
	[Address(RVA = "0x3CBD70", Offset = "0x3CA570", Length = "0x78")]
	public static extern int RailEventkRailEventUsersInviteUsersResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600193E")]
	[Address(RVA = "0x40FC70", Offset = "0x40E470", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUsersInviteUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600193F")]
	[Address(RVA = "0x409030", Offset = "0x407830", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsOnlineStateChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFF30", Offset = "0x3EE730", Length = "0x78")]
	[Token(Token = "0x6001940")]
	public static extern void delete_RailEventkRailEventFriendsOnlineStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C18A0", Offset = "0x3C00A0", Length = "0x65")]
	[Token(Token = "0x6001941")]
	public static extern int RailEventkRailEventFriendsOnlineStateChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001942")]
	[Address(RVA = "0x3C1820", Offset = "0x3C0020", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsOnlineStateChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4090A0", Offset = "0x4078A0", Length = "0x78")]
	[Token(Token = "0x6001943")]
	public static extern IntPtr new_RailEventkRailEventFriendsOnlineStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F570", Offset = "0x40DD70", Length = "0x65")]
	[Token(Token = "0x6001944")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceUpdateMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001945")]
	[Address(RVA = "0x3F3530", Offset = "0x3F1D30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceUpdateMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB3E0", Offset = "0x3C9BE0", Length = "0x65")]
	[Token(Token = "0x6001946")]
	public static extern int RailEventkRailEventUserSpaceUpdateMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB360", Offset = "0x3C9B60", Length = "0x78")]
	[Token(Token = "0x6001947")]
	public static extern int RailEventkRailEventUserSpaceUpdateMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F5E0", Offset = "0x40DDE0", Length = "0x78")]
	[Token(Token = "0x6001948")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceUpdateMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001949")]
	[Address(RVA = "0x4075F0", Offset = "0x405DF0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsUpdateConsumeFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600194A")]
	[Address(RVA = "0x3EF130", Offset = "0x3ED930", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsUpdateConsumeFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF060", Offset = "0x3BD860", Length = "0x65")]
	[Token(Token = "0x600194B")]
	public static extern int RailEventkRailEventAssetsUpdateConsumeFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600194C")]
	[Address(RVA = "0x3BEFE0", Offset = "0x3BD7E0", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsUpdateConsumeFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407660", Offset = "0x405E60", Length = "0x78")]
	[Token(Token = "0x600194D")]
	public static extern IntPtr new_RailEventkRailEventAssetsUpdateConsumeFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600194E")]
	[Address(RVA = "0x40C0F0", Offset = "0x40A8F0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomMembersResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600194F")]
	[Address(RVA = "0x3F1930", Offset = "0x3F0130", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomGetRoomMembersResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6360", Offset = "0x3C4B60", Length = "0x65")]
	[Token(Token = "0x6001950")]
	public static extern int RailEventkRailEventRoomGetRoomMembersResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001951")]
	[Address(RVA = "0x3C62E0", Offset = "0x3C4AE0", Length = "0x78")]
	public static extern int RailEventkRailEventRoomGetRoomMembersResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C160", Offset = "0x40A960", Length = "0x78")]
	[Token(Token = "0x6001952")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomMembersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BA60", Offset = "0x40A260", Length = "0x65")]
	[Token(Token = "0x6001953")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetPlayerMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001954")]
	[Address(RVA = "0x3F15B0", Offset = "0x3EFDB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventPlayerGetPlayerMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001955")]
	[Address(RVA = "0x3C5950", Offset = "0x3C4150", Length = "0x65")]
	public static extern int RailEventkRailEventPlayerGetPlayerMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C58D0", Offset = "0x3C40D0", Length = "0x78")]
	[Token(Token = "0x6001956")]
	public static extern int RailEventkRailEventPlayerGetPlayerMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001957")]
	[Address(RVA = "0x40BAD0", Offset = "0x40A2D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetPlayerMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410650", Offset = "0x40EE50", Length = "0x65")]
	[Token(Token = "0x6001958")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelJoinedResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3E30", Offset = "0x3F2630", Length = "0x78")]
	[Token(Token = "0x6001959")]
	public static extern void delete_RailEventkRailEventVoiceChannelJoinedResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CCDC0", Offset = "0x3CB5C0", Length = "0x65")]
	[Token(Token = "0x600195A")]
	public static extern int RailEventkRailEventVoiceChannelJoinedResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CCD40", Offset = "0x3CB540", Length = "0x78")]
	[Token(Token = "0x600195B")]
	public static extern int RailEventkRailEventVoiceChannelJoinedResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600195C")]
	[Address(RVA = "0x4106C0", Offset = "0x40EEC0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelJoinedResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600195D")]
	[Address(RVA = "0x40A890", Offset = "0x409090", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseFinishOrderResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600195E")]
	[Address(RVA = "0x3F0C30", Offset = "0x3EF430", Length = "0x78")]
	public static extern void delete_RailEventkRailEventInGamePurchaseFinishOrderResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600195F")]
	[Address(RVA = "0x3C3E00", Offset = "0x3C2600", Length = "0x65")]
	public static extern int RailEventkRailEventInGamePurchaseFinishOrderResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C3D80", Offset = "0x3C2580", Length = "0x78")]
	[Token(Token = "0x6001960")]
	public static extern int RailEventkRailEventInGamePurchaseFinishOrderResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001961")]
	[Address(RVA = "0x40A900", Offset = "0x409100", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGamePurchaseFinishOrderResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001962")]
	[Address(RVA = "0x407410", Offset = "0x405C10", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsStartConsumeFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001963")]
	[Address(RVA = "0x3EF030", Offset = "0x3ED830", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsStartConsumeFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001964")]
	[Address(RVA = "0x3BED80", Offset = "0x3BD580", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsStartConsumeFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001965")]
	[Address(RVA = "0x3BED00", Offset = "0x3BD500", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsStartConsumeFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407480", Offset = "0x405C80", Length = "0x78")]
	[Token(Token = "0x6001966")]
	public static extern IntPtr new_RailEventkRailEventAssetsStartConsumeFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001967")]
	[Address(RVA = "0x4098A0", Offset = "0x4080A0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerFavoriteGameServers__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F03B0", Offset = "0x3EEBB0", Length = "0x78")]
	[Token(Token = "0x6001968")]
	public static extern void delete_RailEventkRailEventGameServerFavoriteGameServers(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001969")]
	[Address(RVA = "0x3C2590", Offset = "0x3C0D90", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerFavoriteGameServers_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C2510", Offset = "0x3C0D10", Length = "0x78")]
	[Token(Token = "0x600196A")]
	public static extern int RailEventkRailEventGameServerFavoriteGameServers_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600196B")]
	[Address(RVA = "0x409910", Offset = "0x408110", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerFavoriteGameServers__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600196C")]
	[Address(RVA = "0x4079B0", Offset = "0x4061B0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserJavascriptEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600196D")]
	[Address(RVA = "0x3EF330", Offset = "0x3EDB30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserJavascriptEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF620", Offset = "0x3BDE20", Length = "0x65")]
	[Token(Token = "0x600196E")]
	public static extern int RailEventkRailEventBrowserJavascriptEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF5A0", Offset = "0x3BDDA0", Length = "0x78")]
	[Token(Token = "0x600196F")]
	public static extern int RailEventkRailEventBrowserJavascriptEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001970")]
	[Address(RVA = "0x407A20", Offset = "0x406220", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventBrowserJavascriptEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001971")]
	[Address(RVA = "0x4066F0", Offset = "0x404EF0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAchievementPlayerAchievementReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001972")]
	[Address(RVA = "0x3EE930", Offset = "0x3ED130", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAchievementPlayerAchievementReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BD960", Offset = "0x3BC160", Length = "0x65")]
	[Token(Token = "0x6001973")]
	public static extern int RailEventkRailEventAchievementPlayerAchievementReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BD8E0", Offset = "0x3BC0E0", Length = "0x78")]
	[Token(Token = "0x6001974")]
	public static extern int RailEventkRailEventAchievementPlayerAchievementReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406760", Offset = "0x404F60", Length = "0x78")]
	[Token(Token = "0x6001975")]
	public static extern IntPtr new_RailEventkRailEventAchievementPlayerAchievementReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C690", Offset = "0x40AE90", Length = "0x65")]
	[Token(Token = "0x6001976")]
	public static extern IntPtr new_RailEventkRailEventRoomLeaveRoomResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001977")]
	[Address(RVA = "0x3F1C30", Offset = "0x3F0430", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomLeaveRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6C00", Offset = "0x3C5400", Length = "0x65")]
	[Token(Token = "0x6001978")]
	public static extern int RailEventkRailEventRoomLeaveRoomResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C6B80", Offset = "0x3C5380", Length = "0x78")]
	[Token(Token = "0x6001979")]
	public static extern int RailEventkRailEventRoomLeaveRoomResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C700", Offset = "0x40AF00", Length = "0x78")]
	[Token(Token = "0x600197A")]
	public static extern IntPtr new_RailEventkRailEventRoomLeaveRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BD30", Offset = "0x40A530", Length = "0x65")]
	[Token(Token = "0x600197B")]
	public static extern IntPtr new_RailEventkRailEventRoomCreated__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600197C")]
	[Address(RVA = "0x3F1730", Offset = "0x3EFF30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomCreated(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600197D")]
	[Address(RVA = "0x3C5DA0", Offset = "0x3C45A0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomCreated_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600197E")]
	[Address(RVA = "0x3C5D20", Offset = "0x3C4520", Length = "0x78")]
	public static extern int RailEventkRailEventRoomCreated_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BDA0", Offset = "0x40A5A0", Length = "0x78")]
	[Token(Token = "0x600197F")]
	public static extern IntPtr new_RailEventkRailEventRoomCreated__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001980")]
	[Address(RVA = "0x40E760", Offset = "0x40CF60", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageQueryQuotaResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001981")]
	[Address(RVA = "0x3F2DB0", Offset = "0x3F15B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageQueryQuotaResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001982")]
	[Address(RVA = "0x3C9E50", Offset = "0x3C8650", Length = "0x65")]
	public static extern int RailEventkRailEventStorageQueryQuotaResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C9DD0", Offset = "0x3C85D0", Length = "0x78")]
	[Token(Token = "0x6001983")]
	public static extern int RailEventkRailEventStorageQueryQuotaResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E7D0", Offset = "0x40CFD0", Length = "0x78")]
	[Token(Token = "0x6001984")]
	public static extern IntPtr new_RailEventkRailEventStorageQueryQuotaResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4084F0", Offset = "0x406CF0", Length = "0x65")]
	[Token(Token = "0x6001985")]
	public static extern IntPtr new_RailEventkRailEventDlcOwnershipChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF930", Offset = "0x3EE130", Length = "0x78")]
	[Token(Token = "0x6001986")]
	public static extern void delete_RailEventkRailEventDlcOwnershipChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001987")]
	[Address(RVA = "0x3C0760", Offset = "0x3BEF60", Length = "0x65")]
	public static extern int RailEventkRailEventDlcOwnershipChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C06E0", Offset = "0x3BEEE0", Length = "0x78")]
	[Token(Token = "0x6001988")]
	public static extern int RailEventkRailEventDlcOwnershipChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001989")]
	[Address(RVA = "0x408560", Offset = "0x406D60", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventDlcOwnershipChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600198A")]
	[Address(RVA = "0x407AA0", Offset = "0x4062A0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserNavigeteResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600198B")]
	[Address(RVA = "0x3EF3B0", Offset = "0x3EDBB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserNavigeteResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF790", Offset = "0x3BDF90", Length = "0x65")]
	[Token(Token = "0x600198C")]
	public static extern int RailEventkRailEventBrowserNavigeteResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF710", Offset = "0x3BDF10", Length = "0x78")]
	[Token(Token = "0x600198D")]
	public static extern int RailEventkRailEventBrowserNavigeteResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407B10", Offset = "0x406310", Length = "0x78")]
	[Token(Token = "0x600198E")]
	public static extern IntPtr new_RailEventkRailEventBrowserNavigeteResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600198F")]
	[Address(RVA = "0x408D60", Offset = "0x407560", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetInviteCommandLine__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFDB0", Offset = "0x3EE5B0", Length = "0x78")]
	[Token(Token = "0x6001990")]
	public static extern void delete_RailEventkRailEventFriendsGetInviteCommandLine(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1450", Offset = "0x3BFC50", Length = "0x65")]
	[Token(Token = "0x6001991")]
	public static extern int RailEventkRailEventFriendsGetInviteCommandLine_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C13D0", Offset = "0x3BFBD0", Length = "0x78")]
	[Token(Token = "0x6001992")]
	public static extern int RailEventkRailEventFriendsGetInviteCommandLine_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001993")]
	[Address(RVA = "0x408DD0", Offset = "0x4075D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetInviteCommandLine__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001994")]
	[Address(RVA = "0x410BF0", Offset = "0x40F3F0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001995")]
	[Address(RVA = "0x3F4130", Offset = "0x3F2930", Length = "0x78")]
	public static extern void delete_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CD660", Offset = "0x3CBE60", Length = "0x65")]
	[Token(Token = "0x6001996")]
	public static extern int RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CD5E0", Offset = "0x3CBDE0", Length = "0x78")]
	[Token(Token = "0x6001997")]
	public static extern int RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410C60", Offset = "0x40F460", Length = "0x78")]
	[Token(Token = "0x6001998")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001999")]
	[Address(RVA = "0x40DE00", Offset = "0x40C600", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStatsNumOfPlayerReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600199A")]
	[Address(RVA = "0x3F28B0", Offset = "0x3F10B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStatsNumOfPlayerReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600199B")]
	[Address(RVA = "0x3C8FF0", Offset = "0x3C77F0", Length = "0x65")]
	public static extern int RailEventkRailEventStatsNumOfPlayerReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x600199C")]
	[Address(RVA = "0x3C8F70", Offset = "0x3C7770", Length = "0x78")]
	public static extern int RailEventkRailEventStatsNumOfPlayerReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40DE70", Offset = "0x40C670", Length = "0x78")]
	[Token(Token = "0x600199D")]
	public static extern IntPtr new_RailEventkRailEventStatsNumOfPlayerReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F660", Offset = "0x40DE60", Length = "0x65")]
	[Token(Token = "0x600199E")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceVoteSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F35B0", Offset = "0x3F1DB0", Length = "0x78")]
	[Token(Token = "0x600199F")]
	public static extern void delete_RailEventkRailEventUserSpaceVoteSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB550", Offset = "0x3C9D50", Length = "0x65")]
	[Token(Token = "0x60019A0")]
	public static extern int RailEventkRailEventUserSpaceVoteSpaceWorkResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB4D0", Offset = "0x3C9CD0", Length = "0x78")]
	[Token(Token = "0x60019A1")]
	public static extern int RailEventkRailEventUserSpaceVoteSpaceWorkResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F6D0", Offset = "0x40DED0", Length = "0x78")]
	[Token(Token = "0x60019A2")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceVoteSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408130", Offset = "0x406930", Length = "0x65")]
	[Token(Token = "0x60019A3")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF730", Offset = "0x3EDF30", Length = "0x78")]
	[Token(Token = "0x60019A4")]
	public static extern void delete_RailEventkRailEventDlcInstallFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x3C01A0", Offset = "0x3BE9A0", Length = "0x65")]
	public static extern int RailEventkRailEventDlcInstallFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0120", Offset = "0x3BE920", Length = "0x78")]
	[Token(Token = "0x60019A6")]
	public static extern int RailEventkRailEventDlcInstallFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4081A0", Offset = "0x4069A0", Length = "0x78")]
	[Token(Token = "0x60019A7")]
	public static extern IntPtr new_RailEventkRailEventDlcInstallFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40DD10", Offset = "0x40C510", Length = "0x65")]
	[Token(Token = "0x60019A8")]
	public static extern IntPtr new_RailEventkRailEventStatsGlobalStatsReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2830", Offset = "0x3F1030", Length = "0x78")]
	[Token(Token = "0x60019A9")]
	public static extern void delete_RailEventkRailEventStatsGlobalStatsReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8E80", Offset = "0x3C7680", Length = "0x65")]
	[Token(Token = "0x60019AA")]
	public static extern int RailEventkRailEventStatsGlobalStatsReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x3C8E00", Offset = "0x3C7600", Length = "0x78")]
	public static extern int RailEventkRailEventStatsGlobalStatsReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x40DD80", Offset = "0x40C580", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStatsGlobalStatsReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019AD")]
	[Address(RVA = "0x40F2A0", Offset = "0x40DAA0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSearchSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019AE")]
	[Address(RVA = "0x3F33B0", Offset = "0x3F1BB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceSearchSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019AF")]
	[Address(RVA = "0x3CAF90", Offset = "0x3C9790", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceSearchSpaceWorkResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CAF10", Offset = "0x3C9710", Length = "0x78")]
	[Token(Token = "0x60019B0")]
	public static extern int RailEventkRailEventUserSpaceSearchSpaceWorkResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F310", Offset = "0x40DB10", Length = "0x78")]
	[Token(Token = "0x60019B1")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSearchSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410380", Offset = "0x40EB80", Length = "0x65")]
	[Token(Token = "0x60019B2")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelCreateResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019B3")]
	[Address(RVA = "0x3F3CB0", Offset = "0x3F24B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventVoiceChannelCreateResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019B4")]
	[Address(RVA = "0x3CC970", Offset = "0x3CB170", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelCreateResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CC8F0", Offset = "0x3CB0F0", Length = "0x78")]
	[Token(Token = "0x60019B5")]
	public static extern int RailEventkRailEventVoiceChannelCreateResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019B6")]
	[Address(RVA = "0x4103F0", Offset = "0x40EBF0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelCreateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019B7")]
	[Address(RVA = "0x406AB0", Offset = "0x4052B0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019B8")]
	[Address(RVA = "0x3EEB30", Offset = "0x3ED330", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019B9")]
	[Address(RVA = "0x3BDF20", Offset = "0x3BC720", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60019BA")]
	[Address(RVA = "0x3BDEA0", Offset = "0x3BC6A0", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019BB")]
	[Address(RVA = "0x406B20", Offset = "0x405320", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019BC")]
	[Address(RVA = "0x40F0C0", Offset = "0x40D8C0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceRateSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x3F32B0", Offset = "0x3F1AB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceRateSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x3CACB0", Offset = "0x3C94B0", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceRateSpaceWorkResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60019BF")]
	[Address(RVA = "0x3CAC30", Offset = "0x3C9430", Length = "0x78")]
	public static extern int RailEventkRailEventUserSpaceRateSpaceWorkResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F130", Offset = "0x40D930", Length = "0x78")]
	[Token(Token = "0x60019C0")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceRateSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019C1")]
	[Address(RVA = "0x40BF10", Offset = "0x40A710", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomGetMemberMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019C2")]
	[Address(RVA = "0x3F1830", Offset = "0x3F0030", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomGetMemberMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019C3")]
	[Address(RVA = "0x3C6080", Offset = "0x3C4880", Length = "0x65")]
	public static extern int RailEventkRailEventRoomGetMemberMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C6000", Offset = "0x3C4800", Length = "0x78")]
	[Token(Token = "0x60019C4")]
	public static extern int RailEventkRailEventRoomGetMemberMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BF80", Offset = "0x40A780", Length = "0x78")]
	[Token(Token = "0x60019C5")]
	public static extern IntPtr new_RailEventkRailEventRoomGetMemberMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408E50", Offset = "0x407650", Length = "0x65")]
	[Token(Token = "0x60019C6")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFE30", Offset = "0x3EE630", Length = "0x78")]
	[Token(Token = "0x60019C7")]
	public static extern void delete_RailEventkRailEventFriendsGetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C15C0", Offset = "0x3BFDC0", Length = "0x65")]
	[Token(Token = "0x60019C8")]
	public static extern int RailEventkRailEventFriendsGetMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C1540", Offset = "0x3BFD40", Length = "0x78")]
	[Token(Token = "0x60019C9")]
	public static extern int RailEventkRailEventFriendsGetMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408EC0", Offset = "0x4076C0", Length = "0x78")]
	[Token(Token = "0x60019CA")]
	public static extern IntPtr new_RailEventkRailEventFriendsGetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019CB")]
	[Address(RVA = "0x410920", Offset = "0x40F120", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3FB0", Offset = "0x3F27B0", Length = "0x78")]
	[Token(Token = "0x60019CC")]
	public static extern void delete_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019CD")]
	[Address(RVA = "0x3CD210", Offset = "0x3CBA10", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CD190", Offset = "0x3CB990", Length = "0x78")]
	[Token(Token = "0x60019CE")]
	public static extern int RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410990", Offset = "0x40F190", Length = "0x78")]
	[Token(Token = "0x60019CF")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40DEF0", Offset = "0x40C6F0", Length = "0x65")]
	[Token(Token = "0x60019D0")]
	public static extern IntPtr new_RailEventkRailEventStatsPlayerStatsReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019D1")]
	[Address(RVA = "0x3F2930", Offset = "0x3F1130", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStatsPlayerStatsReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9160", Offset = "0x3C7960", Length = "0x65")]
	[Token(Token = "0x60019D2")]
	public static extern int RailEventkRailEventStatsPlayerStatsReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C90E0", Offset = "0x3C78E0", Length = "0x78")]
	[Token(Token = "0x60019D3")]
	public static extern int RailEventkRailEventStatsPlayerStatsReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019D4")]
	[Address(RVA = "0x40DF60", Offset = "0x40C760", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStatsPlayerStatsReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019D5")]
	[Address(RVA = "0x406BA0", Offset = "0x4053A0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAssetsCompleteConsumeFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEBB0", Offset = "0x3ED3B0", Length = "0x78")]
	[Token(Token = "0x60019D6")]
	public static extern void delete_RailEventkRailEventAssetsCompleteConsumeFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE090", Offset = "0x3BC890", Length = "0x65")]
	[Token(Token = "0x60019D7")]
	public static extern int RailEventkRailEventAssetsCompleteConsumeFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60019D8")]
	[Address(RVA = "0x3BE010", Offset = "0x3BC810", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsCompleteConsumeFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019D9")]
	[Address(RVA = "0x406C10", Offset = "0x405410", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsCompleteConsumeFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019DA")]
	[Address(RVA = "0x409990", Offset = "0x408190", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerGetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0430", Offset = "0x3EEC30", Length = "0x78")]
	[Token(Token = "0x60019DB")]
	public static extern void delete_RailEventkRailEventGameServerGetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019DC")]
	[Address(RVA = "0x3C2700", Offset = "0x3C0F00", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerGetMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C2680", Offset = "0x3C0E80", Length = "0x78")]
	[Token(Token = "0x60019DD")]
	public static extern int RailEventkRailEventGameServerGetMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019DE")]
	[Address(RVA = "0x409A00", Offset = "0x408200", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerGetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B790", Offset = "0x409F90", Length = "0x65")]
	[Token(Token = "0x60019DF")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetAuthenticateURL__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1430", Offset = "0x3EFC30", Length = "0x78")]
	[Token(Token = "0x60019E0")]
	public static extern void delete_RailEventkRailEventPlayerGetAuthenticateURL(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5500", Offset = "0x3C3D00", Length = "0x65")]
	[Token(Token = "0x60019E1")]
	public static extern int RailEventkRailEventPlayerGetAuthenticateURL_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x60019E2")]
	[Address(RVA = "0x3C5480", Offset = "0x3C3C80", Length = "0x78")]
	public static extern int RailEventkRailEventPlayerGetAuthenticateURL_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B800", Offset = "0x40A000", Length = "0x78")]
	[Token(Token = "0x60019E3")]
	public static extern IntPtr new_RailEventkRailEventPlayerGetAuthenticateURL__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019E4")]
	[Address(RVA = "0x410740", Offset = "0x40EF40", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelLeaveResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019E5")]
	[Address(RVA = "0x3F3EB0", Offset = "0x3F26B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventVoiceChannelLeaveResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019E6")]
	[Address(RVA = "0x3CCF30", Offset = "0x3CB730", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelLeaveResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CCEB0", Offset = "0x3CB6B0", Length = "0x78")]
	[Token(Token = "0x60019E7")]
	public static extern int RailEventkRailEventVoiceChannelLeaveResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4107B0", Offset = "0x40EFB0", Length = "0x78")]
	[Token(Token = "0x60019E8")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelLeaveResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C960", Offset = "0x40B160", Length = "0x65")]
	[Token(Token = "0x60019E9")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMetadataChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019EA")]
	[Address(RVA = "0x3F1DB0", Offset = "0x3F05B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomNotifyMetadataChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019EB")]
	[Address(RVA = "0x3C7050", Offset = "0x3C5850", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyMetadataChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C6FD0", Offset = "0x3C57D0", Length = "0x78")]
	[Token(Token = "0x60019EC")]
	public static extern int RailEventkRailEventRoomNotifyMetadataChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C9D0", Offset = "0x40B1D0", Length = "0x78")]
	[Token(Token = "0x60019ED")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyMetadataChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4067E0", Offset = "0x404FE0", Length = "0x65")]
	[Token(Token = "0x60019EE")]
	public static extern IntPtr new_RailEventkRailEventAchievementPlayerAchievementStored__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EE9B0", Offset = "0x3ED1B0", Length = "0x78")]
	[Token(Token = "0x60019EF")]
	public static extern void delete_RailEventkRailEventAchievementPlayerAchievementStored(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDAD0", Offset = "0x3BC2D0", Length = "0x65")]
	[Token(Token = "0x60019F0")]
	public static extern int RailEventkRailEventAchievementPlayerAchievementStored_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BDA50", Offset = "0x3BC250", Length = "0x78")]
	[Token(Token = "0x60019F1")]
	public static extern int RailEventkRailEventAchievementPlayerAchievementStored_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406850", Offset = "0x405050", Length = "0x78")]
	[Token(Token = "0x60019F2")]
	public static extern IntPtr new_RailEventkRailEventAchievementPlayerAchievementStored__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40AB60", Offset = "0x409360", Length = "0x65")]
	[Token(Token = "0x60019F3")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowClosed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0DB0", Offset = "0x3EF5B0", Length = "0x78")]
	[Token(Token = "0x60019F4")]
	public static extern void delete_RailEventkRailEventInGameStorePurchasePayWindowClosed(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4250", Offset = "0x3C2A50", Length = "0x65")]
	[Token(Token = "0x60019F5")]
	public static extern int RailEventkRailEventInGameStorePurchasePayWindowClosed_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C41D0", Offset = "0x3C29D0", Length = "0x78")]
	[Token(Token = "0x60019F6")]
	public static extern int RailEventkRailEventInGameStorePurchasePayWindowClosed_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019F7")]
	[Address(RVA = "0x40ABD0", Offset = "0x4093D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGameStorePurchasePayWindowClosed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019F8")]
	[Address(RVA = "0x40CE10", Offset = "0x40B610", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomOpenRoomResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60019F9")]
	[Address(RVA = "0x3F2030", Offset = "0x3F0830", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomOpenRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7780", Offset = "0x3C5F80", Length = "0x65")]
	[Token(Token = "0x60019FA")]
	public static extern int RailEventkRailEventRoomOpenRoomResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C7700", Offset = "0x3C5F00", Length = "0x78")]
	[Token(Token = "0x60019FB")]
	public static extern int RailEventkRailEventRoomOpenRoomResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019FC")]
	[Address(RVA = "0x40CE80", Offset = "0x40B680", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomOpenRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410470", Offset = "0x40EC70", Length = "0x65")]
	[Token(Token = "0x60019FD")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelDataCaptured__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3D30", Offset = "0x3F2530", Length = "0x78")]
	[Token(Token = "0x60019FE")]
	public static extern void delete_RailEventkRailEventVoiceChannelDataCaptured(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60019FF")]
	[Address(RVA = "0x3CCAE0", Offset = "0x3CB2E0", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelDataCaptured_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A00")]
	[Address(RVA = "0x3CCA60", Offset = "0x3CB260", Length = "0x78")]
	public static extern int RailEventkRailEventVoiceChannelDataCaptured_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4104E0", Offset = "0x40ECE0", Length = "0x78")]
	[Token(Token = "0x6001A01")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelDataCaptured__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B6A0", Offset = "0x409EA0", Length = "0x65")]
	[Token(Token = "0x6001A02")]
	public static extern IntPtr new_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x3F13B0", Offset = "0x3EFBB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x3C5390", Offset = "0x3C3B90", Length = "0x65")]
	public static extern int RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C5310", Offset = "0x3C3B10", Length = "0x78")]
	[Token(Token = "0x6001A05")]
	public static extern int RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x40B710", Offset = "0x409F10", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x40D2C0", Offset = "0x40BAC0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomTagResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x3F22B0", Offset = "0x3F0AB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomSetRoomTagResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7EB0", Offset = "0x3C66B0", Length = "0x65")]
	[Token(Token = "0x6001A09")]
	public static extern int RailEventkRailEventRoomSetRoomTagResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A0A")]
	[Address(RVA = "0x3C7E30", Offset = "0x3C6630", Length = "0x78")]
	public static extern int RailEventkRailEventRoomSetRoomTagResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A0B")]
	[Address(RVA = "0x40D330", Offset = "0x40BB30", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomSetRoomTagResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A0C")]
	[Address(RVA = "0x40C000", Offset = "0x40A800", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A0D")]
	[Address(RVA = "0x3F18B0", Offset = "0x3F00B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomGetRoomListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A0E")]
	[Address(RVA = "0x3C61F0", Offset = "0x3C49F0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomGetRoomListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C6170", Offset = "0x3C4970", Length = "0x78")]
	[Token(Token = "0x6001A0F")]
	public static extern int RailEventkRailEventRoomGetRoomListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A10")]
	[Address(RVA = "0x40C070", Offset = "0x40A870", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A11")]
	[Address(RVA = "0x40CFF0", Offset = "0x40B7F0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomSetNewRoomOwnerResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A12")]
	[Address(RVA = "0x3F2130", Offset = "0x3F0930", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomSetNewRoomOwnerResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6260", Length = "0x65")]
	[Token(Token = "0x6001A13")]
	public static extern int RailEventkRailEventRoomSetNewRoomOwnerResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C79E0", Offset = "0x3C61E0", Length = "0x78")]
	[Token(Token = "0x6001A14")]
	public static extern int RailEventkRailEventRoomSetNewRoomOwnerResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A15")]
	[Address(RVA = "0x40D060", Offset = "0x40B860", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomSetNewRoomOwnerResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E3A0", Offset = "0x40CBA0", Length = "0x65")]
	[Token(Token = "0x6001A16")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncReadStreamFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A17")]
	[Address(RVA = "0x3F2BB0", Offset = "0x3F13B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncReadStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x3C9890", Offset = "0x3C8090", Length = "0x65")]
	public static extern int RailEventkRailEventStorageAsyncReadStreamFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x3C9810", Offset = "0x3C8010", Length = "0x78")]
	public static extern int RailEventkRailEventStorageAsyncReadStreamFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x40E410", Offset = "0x40CC10", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncReadStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x407E60", Offset = "0x406660", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserTitleChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF5B0", Offset = "0x3EDDB0", Length = "0x78")]
	[Token(Token = "0x6001A1C")]
	public static extern void delete_RailEventkRailEventBrowserTitleChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x3BFD50", Offset = "0x3BE550", Length = "0x65")]
	public static extern int RailEventkRailEventBrowserTitleChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x3BFCD0", Offset = "0x3BE4D0", Length = "0x78")]
	public static extern int RailEventkRailEventBrowserTitleChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A1F")]
	[Address(RVA = "0x407ED0", Offset = "0x4066D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventBrowserTitleChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A20")]
	[Address(RVA = "0x40FED0", Offset = "0x40E6D0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersShowChatWindowWithFriendResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3A30", Offset = "0x3F2230", Length = "0x78")]
	[Token(Token = "0x6001A21")]
	public static extern void delete_RailEventkRailEventUsersShowChatWindowWithFriendResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC240", Offset = "0x3CAA40", Length = "0x65")]
	[Token(Token = "0x6001A22")]
	public static extern int RailEventkRailEventUsersShowChatWindowWithFriendResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CC1C0", Offset = "0x3CA9C0", Length = "0x78")]
	[Token(Token = "0x6001A23")]
	public static extern int RailEventkRailEventUsersShowChatWindowWithFriendResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40FF40", Offset = "0x40E740", Length = "0x78")]
	[Token(Token = "0x6001A24")]
	public static extern IntPtr new_RailEventkRailEventUsersShowChatWindowWithFriendResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40EDF0", Offset = "0x40D5F0", Length = "0x65")]
	[Token(Token = "0x6001A25")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceGetMySubscribedWorksResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3130", Offset = "0x3F1930", Length = "0x78")]
	[Token(Token = "0x6001A26")]
	public static extern void delete_RailEventkRailEventUserSpaceGetMySubscribedWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A27")]
	[Address(RVA = "0x3CA860", Offset = "0x3C9060", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceGetMySubscribedWorksResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A28")]
	[Address(RVA = "0x3CA7E0", Offset = "0x3C8FE0", Length = "0x78")]
	public static extern int RailEventkRailEventUserSpaceGetMySubscribedWorksResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A29")]
	[Address(RVA = "0x40EE60", Offset = "0x40D660", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceGetMySubscribedWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x40E850", Offset = "0x40D050", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageShareToSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x3F2E30", Offset = "0x3F1630", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageShareToSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x3C9FC0", Offset = "0x3C87C0", Length = "0x65")]
	public static extern int RailEventkRailEventStorageShareToSpaceWorkResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x3C9F40", Offset = "0x3C8740", Length = "0x78")]
	public static extern int RailEventkRailEventStorageShareToSpaceWorkResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x40E8C0", Offset = "0x40D0C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageShareToSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x408B80", Offset = "0x407380", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsFriendsListChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFCB0", Offset = "0x3EE4B0", Length = "0x78")]
	[Token(Token = "0x6001A30")]
	public static extern void delete_RailEventkRailEventFriendsFriendsListChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x3C1170", Offset = "0x3BF970", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsFriendsListChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x3C10F0", Offset = "0x3BF8F0", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsFriendsListChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408BF0", Offset = "0x4073F0", Length = "0x78")]
	[Token(Token = "0x6001A33")]
	public static extern IntPtr new_RailEventkRailEventFriendsFriendsListChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4101A0", Offset = "0x40E9A0", Length = "0x65")]
	[Token(Token = "0x6001A34")]
	public static extern IntPtr new_RailEventkRailEventUtilsGetImageDataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3BB0", Offset = "0x3F23B0", Length = "0x78")]
	[Token(Token = "0x6001A35")]
	public static extern void delete_RailEventkRailEventUtilsGetImageDataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC690", Offset = "0x3CAE90", Length = "0x65")]
	[Token(Token = "0x6001A36")]
	public static extern int RailEventkRailEventUtilsGetImageDataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CC610", Offset = "0x3CAE10", Length = "0x78")]
	[Token(Token = "0x6001A37")]
	public static extern int RailEventkRailEventUtilsGetImageDataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410210", Offset = "0x40EA10", Length = "0x78")]
	[Token(Token = "0x6001A38")]
	public static extern IntPtr new_RailEventkRailEventUtilsGetImageDataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F930", Offset = "0x40E130", Length = "0x65")]
	[Token(Token = "0x6001A39")]
	public static extern IntPtr new_RailEventkRailEventUsersGetUserLimitsResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3730", Offset = "0x3F1F30", Length = "0x78")]
	[Token(Token = "0x6001A3A")]
	public static extern void delete_RailEventkRailEventUsersGetUserLimitsResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB9A0", Offset = "0x3CA1A0", Length = "0x65")]
	[Token(Token = "0x6001A3B")]
	public static extern int RailEventkRailEventUsersGetUserLimitsResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB920", Offset = "0x3CA120", Length = "0x78")]
	[Token(Token = "0x6001A3C")]
	public static extern int RailEventkRailEventUsersGetUserLimitsResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F9A0", Offset = "0x40E1A0", Length = "0x78")]
	[Token(Token = "0x6001A3D")]
	public static extern IntPtr new_RailEventkRailEventUsersGetUserLimitsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x40E940", Offset = "0x40D140", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventSystemStateChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2EB0", Offset = "0x3F16B0", Length = "0x78")]
	[Token(Token = "0x6001A3F")]
	public static extern void delete_RailEventkRailEventSystemStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x3CA130", Offset = "0x3C8930", Length = "0x65")]
	public static extern int RailEventkRailEventSystemStateChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x3CA0B0", Offset = "0x3C88B0", Length = "0x78")]
	public static extern int RailEventkRailEventSystemStateChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E9B0", Offset = "0x40D1B0", Length = "0x78")]
	[Token(Token = "0x6001A42")]
	public static extern IntPtr new_RailEventkRailEventSystemStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x40B100", Offset = "0x409900", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F10B0", Offset = "0x3EF8B0", Length = "0x78")]
	[Token(Token = "0x6001A44")]
	public static extern void delete_RailEventkRailEventLeaderboardReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4AF0", Offset = "0x3C32F0", Length = "0x65")]
	[Token(Token = "0x6001A45")]
	public static extern int RailEventkRailEventLeaderboardReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C4A70", Offset = "0x3C3270", Length = "0x78")]
	[Token(Token = "0x6001A46")]
	public static extern int RailEventkRailEventLeaderboardReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B170", Offset = "0x409970", Length = "0x78")]
	[Token(Token = "0x6001A47")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A200", Offset = "0x408A00", Length = "0x65")]
	[Token(Token = "0x6001A48")]
	public static extern IntPtr new_RailEventkRailEventHttpSessionResponseResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x3F08B0", Offset = "0x3EF0B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventHttpSessionResponseResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C33F0", Offset = "0x3C1BF0", Length = "0x65")]
	[Token(Token = "0x6001A4A")]
	public static extern int RailEventkRailEventHttpSessionResponseResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C3370", Offset = "0x3C1B70", Length = "0x78")]
	[Token(Token = "0x6001A4B")]
	public static extern int RailEventkRailEventHttpSessionResponseResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A270", Offset = "0x408A70", Length = "0x78")]
	[Token(Token = "0x6001A4C")]
	public static extern IntPtr new_RailEventkRailEventHttpSessionResponseResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x40EC10", Offset = "0x40D410", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceDownloadResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x3F3030", Offset = "0x3F1830", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x3CA580", Offset = "0x3C8D80", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceDownloadResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x3CA500", Offset = "0x3C8D00", Length = "0x78")]
	public static extern int RailEventkRailEventUserSpaceDownloadResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40EC80", Offset = "0x40D480", Length = "0x78")]
	[Token(Token = "0x6001A51")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceDownloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x40BC40", Offset = "0x40A440", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomClearRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F16B0", Offset = "0x3EFEB0", Length = "0x78")]
	[Token(Token = "0x6001A53")]
	public static extern void delete_RailEventkRailEventRoomClearRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5C30", Offset = "0x3C4430", Length = "0x65")]
	[Token(Token = "0x6001A54")]
	public static extern int RailEventkRailEventRoomClearRoomMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C5BB0", Offset = "0x3C43B0", Length = "0x78")]
	[Token(Token = "0x6001A55")]
	public static extern int RailEventkRailEventRoomClearRoomMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BCB0", Offset = "0x40A4B0", Length = "0x78")]
	[Token(Token = "0x6001A56")]
	public static extern IntPtr new_RailEventkRailEventRoomClearRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x40DB30", Offset = "0x40C330", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventSmallObjectServiceDownloadResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2730", Offset = "0x3F0F30", Length = "0x78")]
	[Token(Token = "0x6001A58")]
	public static extern void delete_RailEventkRailEventSmallObjectServiceDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8BA0", Offset = "0x3C73A0", Length = "0x65")]
	[Token(Token = "0x6001A59")]
	public static extern int RailEventkRailEventSmallObjectServiceDownloadResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C8B20", Offset = "0x3C7320", Length = "0x78")]
	[Token(Token = "0x6001A5A")]
	public static extern int RailEventkRailEventSmallObjectServiceDownloadResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40DBA0", Offset = "0x40C3A0", Length = "0x78")]
	[Token(Token = "0x6001A5B")]
	public static extern IntPtr new_RailEventkRailEventSmallObjectServiceDownloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BE20", Offset = "0x40A620", Length = "0x65")]
	[Token(Token = "0x6001A5C")]
	public static extern IntPtr new_RailEventkRailEventRoomGetAllDataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F17B0", Offset = "0x3EFFB0", Length = "0x78")]
	[Token(Token = "0x6001A5D")]
	public static extern void delete_RailEventkRailEventRoomGetAllDataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5F10", Offset = "0x3C4710", Length = "0x65")]
	[Token(Token = "0x6001A5E")]
	public static extern int RailEventkRailEventRoomGetAllDataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A5F")]
	[Address(RVA = "0x3C5E90", Offset = "0x3C4690", Length = "0x78")]
	public static extern int RailEventkRailEventRoomGetAllDataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BE90", Offset = "0x40A690", Length = "0x78")]
	[Token(Token = "0x6001A60")]
	public static extern IntPtr new_RailEventkRailEventRoomGetAllDataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A61")]
	[Address(RVA = "0x40E1C0", Offset = "0x40C9C0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncListStreamFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A62")]
	[Address(RVA = "0x3F2AB0", Offset = "0x3F12B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncListStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C95B0", Offset = "0x3C7DB0", Length = "0x65")]
	[Token(Token = "0x6001A63")]
	public static extern int RailEventkRailEventStorageAsyncListStreamFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C9530", Offset = "0x3C7D30", Length = "0x78")]
	[Token(Token = "0x6001A64")]
	public static extern int RailEventkRailEventStorageAsyncListStreamFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x40E230", Offset = "0x40CA30", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncListStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A020", Offset = "0x408820", Length = "0x65")]
	[Token(Token = "0x6001A66")]
	public static extern IntPtr new_RailEventkRailEventGroupChatOpenGroupChatResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x3F07B0", Offset = "0x3EEFB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGroupChatOpenGroupChatResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x3C3110", Offset = "0x3C1910", Length = "0x65")]
	public static extern int RailEventkRailEventGroupChatOpenGroupChatResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x3C3090", Offset = "0x3C1890", Length = "0x78")]
	public static extern int RailEventkRailEventGroupChatOpenGroupChatResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x40A090", Offset = "0x408890", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGroupChatOpenGroupChatResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x40B010", Offset = "0x409810", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardEntryReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x3F1030", Offset = "0x3EF830", Length = "0x78")]
	public static extern void delete_RailEventkRailEventLeaderboardEntryReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x3C4980", Offset = "0x3C3180", Length = "0x65")]
	public static extern int RailEventkRailEventLeaderboardEntryReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x3C4900", Offset = "0x3C3100", Length = "0x78")]
	public static extern int RailEventkRailEventLeaderboardEntryReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x40B080", Offset = "0x409880", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventLeaderboardEntryReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40CC30", Offset = "0x40B430", Length = "0x65")]
	[Token(Token = "0x6001A70")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomGameServerChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1F30", Offset = "0x3F0730", Length = "0x78")]
	[Token(Token = "0x6001A71")]
	public static extern void delete_RailEventkRailEventRoomNotifyRoomGameServerChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x3C74A0", Offset = "0x3C5CA0", Length = "0x65")]
	public static extern int RailEventkRailEventRoomNotifyRoomGameServerChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C7420", Offset = "0x3C5C20", Length = "0x78")]
	[Token(Token = "0x6001A73")]
	public static extern int RailEventkRailEventRoomNotifyRoomGameServerChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x40CCA0", Offset = "0x40B4A0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomGameServerChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x40CA50", Offset = "0x40B250", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomDataReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x3F1E30", Offset = "0x3F0630", Length = "0x78")]
	public static extern void delete_RailEventkRailEventRoomNotifyRoomDataReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C71C0", Offset = "0x3C59C0", Length = "0x65")]
	[Token(Token = "0x6001A77")]
	public static extern int RailEventkRailEventRoomNotifyRoomDataReceived_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A78")]
	[Address(RVA = "0x3C7140", Offset = "0x3C5940", Length = "0x78")]
	public static extern int RailEventkRailEventRoomNotifyRoomDataReceived_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A79")]
	[Address(RVA = "0x40CAC0", Offset = "0x40B2C0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventRoomNotifyRoomDataReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A7A")]
	[Address(RVA = "0x4085E0", Offset = "0x406DE0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventDlcQueryIsOwnedDlcsResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A7B")]
	[Address(RVA = "0x3EF9B0", Offset = "0x3EE1B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventDlcQueryIsOwnedDlcsResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C08D0", Offset = "0x3BF0D0", Length = "0x65")]
	[Token(Token = "0x6001A7C")]
	public static extern int RailEventkRailEventDlcQueryIsOwnedDlcsResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C0850", Offset = "0x3BF050", Length = "0x78")]
	[Token(Token = "0x6001A7D")]
	public static extern int RailEventkRailEventDlcQueryIsOwnedDlcsResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x408650", Offset = "0x406E50", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventDlcQueryIsOwnedDlcsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A7F")]
	[Address(RVA = "0x40F480", Offset = "0x40DC80", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSyncResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A80")]
	[Address(RVA = "0x3F34B0", Offset = "0x3F1CB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUserSpaceSyncResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A81")]
	[Address(RVA = "0x3CB270", Offset = "0x3C9A70", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceSyncResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CB1F0", Offset = "0x3C99F0", Length = "0x78")]
	[Token(Token = "0x6001A82")]
	public static extern int RailEventkRailEventUserSpaceSyncResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A83")]
	[Address(RVA = "0x40F4F0", Offset = "0x40DCF0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceSyncResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4069C0", Offset = "0x4051C0", Length = "0x65")]
	[Token(Token = "0x6001A84")]
	public static extern IntPtr new_RailEventkRailEventAssetsAssetsChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEAB0", Offset = "0x3ED2B0", Length = "0x78")]
	[Token(Token = "0x6001A85")]
	public static extern void delete_RailEventkRailEventAssetsAssetsChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A86")]
	[Address(RVA = "0x3BDDB0", Offset = "0x3BC5B0", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsAssetsChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BDD30", Offset = "0x3BC530", Length = "0x78")]
	[Token(Token = "0x6001A87")]
	public static extern int RailEventkRailEventAssetsAssetsChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406A30", Offset = "0x405230", Length = "0x78")]
	[Token(Token = "0x6001A88")]
	public static extern IntPtr new_RailEventkRailEventAssetsAssetsChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A89")]
	[Address(RVA = "0x40A2F0", Offset = "0x408AF0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventIMEHelperTextInputCompositionStateChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A8A")]
	[Address(RVA = "0x3F0930", Offset = "0x3EF130", Length = "0x78")]
	public static extern void delete_RailEventkRailEventIMEHelperTextInputCompositionStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A8B")]
	[Address(RVA = "0x3C3560", Offset = "0x3C1D60", Length = "0x65")]
	public static extern int RailEventkRailEventIMEHelperTextInputCompositionStateChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C34E0", Offset = "0x3C1CE0", Length = "0x78")]
	[Token(Token = "0x6001A8C")]
	public static extern int RailEventkRailEventIMEHelperTextInputCompositionStateChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A360", Offset = "0x408B60", Length = "0x78")]
	[Token(Token = "0x6001A8D")]
	public static extern IntPtr new_RailEventkRailEventIMEHelperTextInputCompositionStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4086D0", Offset = "0x406ED0", Length = "0x65")]
	[Token(Token = "0x6001A8E")]
	public static extern IntPtr new_RailEventkRailEventDlcRefundChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EFA30", Offset = "0x3EE230", Length = "0x78")]
	[Token(Token = "0x6001A8F")]
	public static extern void delete_RailEventkRailEventDlcRefundChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A90")]
	[Address(RVA = "0x3C0A40", Offset = "0x3BF240", Length = "0x65")]
	public static extern int RailEventkRailEventDlcRefundChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C09C0", Offset = "0x3BF1C0", Length = "0x78")]
	[Token(Token = "0x6001A91")]
	public static extern int RailEventkRailEventDlcRefundChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x408740", Offset = "0x406F40", Length = "0x78")]
	[Token(Token = "0x6001A92")]
	public static extern IntPtr new_RailEventkRailEventDlcRefundChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A93")]
	[Address(RVA = "0x409C60", Offset = "0x408460", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerPlayerListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A94")]
	[Address(RVA = "0x3F05B0", Offset = "0x3EEDB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGameServerPlayerListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A95")]
	[Address(RVA = "0x3C2B50", Offset = "0x3C1350", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerPlayerListResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001A96")]
	[Address(RVA = "0x3C2AD0", Offset = "0x3C12D0", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerPlayerListResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A97")]
	[Address(RVA = "0x409CD0", Offset = "0x4084D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerPlayerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A98")]
	[Address(RVA = "0x40FA20", Offset = "0x40E220", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersGetUsersInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A99")]
	[Address(RVA = "0x3F37B0", Offset = "0x3F1FB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventUsersGetUsersInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBB10", Offset = "0x3CA310", Length = "0x65")]
	[Token(Token = "0x6001A9A")]
	public static extern int RailEventkRailEventUsersGetUsersInfo_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CBA90", Offset = "0x3CA290", Length = "0x78")]
	[Token(Token = "0x6001A9B")]
	public static extern int RailEventkRailEventUsersGetUsersInfo_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A9C")]
	[Address(RVA = "0x40FA90", Offset = "0x40E290", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUsersGetUsersInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001A9D")]
	[Address(RVA = "0x40E0D0", Offset = "0x40C8D0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncDeleteStreamFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001A9E")]
	[Address(RVA = "0x3F2A30", Offset = "0x3F1230", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncDeleteStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9440", Offset = "0x3C7C40", Length = "0x65")]
	[Token(Token = "0x6001A9F")]
	public static extern int RailEventkRailEventStorageAsyncDeleteStreamFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AA0")]
	[Address(RVA = "0x3C93C0", Offset = "0x3C7BC0", Length = "0x78")]
	public static extern int RailEventkRailEventStorageAsyncDeleteStreamFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA1")]
	[Address(RVA = "0x40E140", Offset = "0x40C940", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncDeleteStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA2")]
	[Address(RVA = "0x4094E0", Offset = "0x407CE0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventFriendsSetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F01B0", Offset = "0x3EE9B0", Length = "0x78")]
	[Token(Token = "0x6001AA3")]
	public static extern void delete_RailEventkRailEventFriendsSetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA4")]
	[Address(RVA = "0x3C1FD0", Offset = "0x3C07D0", Length = "0x65")]
	public static extern int RailEventkRailEventFriendsSetMetadataResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AA5")]
	[Address(RVA = "0x3C1F50", Offset = "0x3C0750", Length = "0x78")]
	public static extern int RailEventkRailEventFriendsSetMetadataResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA6")]
	[Address(RVA = "0x409550", Offset = "0x407D50", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventFriendsSetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x4077D0", Offset = "0x405FD0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserCreateResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EF230", Offset = "0x3EDA30", Length = "0x78")]
	[Token(Token = "0x6001AA8")]
	public static extern void delete_RailEventkRailEventBrowserCreateResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x3BF340", Offset = "0x3BDB40", Length = "0x65")]
	public static extern int RailEventkRailEventBrowserCreateResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BF2C0", Offset = "0x3BDAC0", Length = "0x78")]
	[Token(Token = "0x6001AAA")]
	public static extern int RailEventkRailEventBrowserCreateResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x407840", Offset = "0x406040", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventBrowserCreateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407320", Offset = "0x405B20", Length = "0x65")]
	[Token(Token = "0x6001AAC")]
	public static extern IntPtr new_RailEventkRailEventAssetsSplitToFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3EEFB0", Offset = "0x3ED7B0", Length = "0x78")]
	[Token(Token = "0x6001AAD")]
	public static extern void delete_RailEventkRailEventAssetsSplitToFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x3BEC10", Offset = "0x3BD410", Length = "0x65")]
	public static extern int RailEventkRailEventAssetsSplitToFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x3BEB90", Offset = "0x3BD390", Length = "0x78")]
	public static extern int RailEventkRailEventAssetsSplitToFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x407390", Offset = "0x405B90", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAssetsSplitToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x40D4A0", Offset = "0x40BCA0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventScreenshotPublishScreenshotFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x3F23B0", Offset = "0x3F0BB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventScreenshotPublishScreenshotFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x3C8190", Offset = "0x3C6990", Length = "0x65")]
	public static extern int RailEventkRailEventScreenshotPublishScreenshotFinished_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C8110", Offset = "0x3C6910", Length = "0x78")]
	[Token(Token = "0x6001AB4")]
	public static extern int RailEventkRailEventScreenshotPublishScreenshotFinished_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AB5")]
	[Address(RVA = "0x40D510", Offset = "0x40BD10", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventScreenshotPublishScreenshotFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410290", Offset = "0x40EA90", Length = "0x65")]
	[Token(Token = "0x6001AB6")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelAddUsersResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3C30", Offset = "0x3F2430", Length = "0x78")]
	[Token(Token = "0x6001AB7")]
	public static extern void delete_RailEventkRailEventVoiceChannelAddUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AB8")]
	[Address(RVA = "0x3CC800", Offset = "0x3CB000", Length = "0x65")]
	public static extern int RailEventkRailEventVoiceChannelAddUsersResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AB9")]
	[Address(RVA = "0x3CC780", Offset = "0x3CAF80", Length = "0x78")]
	public static extern int RailEventkRailEventVoiceChannelAddUsersResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410300", Offset = "0x40EB00", Length = "0x78")]
	[Token(Token = "0x6001ABA")]
	public static extern IntPtr new_RailEventkRailEventVoiceChannelAddUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ABB")]
	[Address(RVA = "0x4095D0", Offset = "0x407DD0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerAddFavoriteGameServer__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001ABC")]
	[Address(RVA = "0x3F0230", Offset = "0x3EEA30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventGameServerAddFavoriteGameServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2140", Offset = "0x3C0940", Length = "0x65")]
	[Token(Token = "0x6001ABD")]
	public static extern int RailEventkRailEventGameServerAddFavoriteGameServer_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x3C20C0", Offset = "0x3C08C0", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerAddFavoriteGameServer_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x409640", Offset = "0x407E40", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventGameServerAddFavoriteGameServer__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x40D860", Offset = "0x40C060", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventSessionTicketGetSessionTicket__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x3F25B0", Offset = "0x3F0DB0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventSessionTicketGetSessionTicket(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AC2")]
	[Address(RVA = "0x3C8750", Offset = "0x3C6F50", Length = "0x65")]
	public static extern int RailEventkRailEventSessionTicketGetSessionTicket_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C86D0", Offset = "0x3C6ED0", Length = "0x78")]
	[Token(Token = "0x6001AC3")]
	public static extern int RailEventkRailEventSessionTicketGetSessionTicket_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x40D8D0", Offset = "0x40C0D0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventSessionTicketGetSessionTicket__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x409E40", Offset = "0x408640", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventGameServerRemoveFavoriteGameServer__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F06B0", Offset = "0x3EEEB0", Length = "0x78")]
	[Token(Token = "0x6001AC6")]
	public static extern void delete_RailEventkRailEventGameServerRemoveFavoriteGameServer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x3C2E30", Offset = "0x3C1630", Length = "0x65")]
	public static extern int RailEventkRailEventGameServerRemoveFavoriteGameServer_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x3C2DB0", Offset = "0x3C15B0", Length = "0x78")]
	public static extern int RailEventkRailEventGameServerRemoveFavoriteGameServer_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409EB0", Offset = "0x4086B0", Length = "0x78")]
	[Token(Token = "0x6001AC9")]
	public static extern IntPtr new_RailEventkRailEventGameServerRemoveFavoriteGameServer__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x40C2D0", Offset = "0x40AAD0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomTagResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F1A30", Offset = "0x3F0230", Length = "0x78")]
	[Token(Token = "0x6001ACB")]
	public static extern void delete_RailEventkRailEventRoomGetRoomTagResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6640", Offset = "0x3C4E40", Length = "0x65")]
	[Token(Token = "0x6001ACC")]
	public static extern int RailEventkRailEventRoomGetRoomTagResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C65C0", Offset = "0x3C4DC0", Length = "0x78")]
	[Token(Token = "0x6001ACD")]
	public static extern int RailEventkRailEventRoomGetRoomTagResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40C340", Offset = "0x40AB40", Length = "0x78")]
	[Token(Token = "0x6001ACE")]
	public static extern IntPtr new_RailEventkRailEventRoomGetRoomTagResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ACF")]
	[Address(RVA = "0x40DFE0", Offset = "0x40C7E0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStatsPlayerStatsStored__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001AD0")]
	[Address(RVA = "0x3F29B0", Offset = "0x3F11B0", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStatsPlayerStatsStored(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C92D0", Offset = "0x3C7AD0", Length = "0x65")]
	[Token(Token = "0x6001AD1")]
	public static extern int RailEventkRailEventStatsPlayerStatsStored_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AD2")]
	[Address(RVA = "0x3C9250", Offset = "0x3C7A50", Length = "0x78")]
	public static extern int RailEventkRailEventStatsPlayerStatsStored_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40E050", Offset = "0x40C850", Length = "0x78")]
	[Token(Token = "0x6001AD3")]
	public static extern IntPtr new_RailEventkRailEventStatsPlayerStatsStored__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AD4")]
	[Address(RVA = "0x40E2B0", Offset = "0x40CAB0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncReadFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001AD5")]
	[Address(RVA = "0x3F2B30", Offset = "0x3F1330", Length = "0x78")]
	public static extern void delete_RailEventkRailEventStorageAsyncReadFileResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AD6")]
	[Address(RVA = "0x3C9720", Offset = "0x3C7F20", Length = "0x65")]
	public static extern int RailEventkRailEventStorageAsyncReadFileResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C96A0", Offset = "0x3C7EA0", Length = "0x78")]
	[Token(Token = "0x6001AD7")]
	public static extern int RailEventkRailEventStorageAsyncReadFileResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AD8")]
	[Address(RVA = "0x40E320", Offset = "0x40CB20", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventStorageAsyncReadFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40D770", Offset = "0x40BF70", Length = "0x65")]
	[Token(Token = "0x6001AD9")]
	public static extern IntPtr new_RailEventkRailEventSessionTicketAuthSessionTicket__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F2530", Offset = "0x3F0D30", Length = "0x78")]
	[Token(Token = "0x6001ADA")]
	public static extern void delete_RailEventkRailEventSessionTicketAuthSessionTicket(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C85E0", Offset = "0x3C6DE0", Length = "0x65")]
	[Token(Token = "0x6001ADB")]
	public static extern int RailEventkRailEventSessionTicketAuthSessionTicket_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C8560", Offset = "0x3C6D60", Length = "0x78")]
	[Token(Token = "0x6001ADC")]
	public static extern int RailEventkRailEventSessionTicketAuthSessionTicket_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ADD")]
	[Address(RVA = "0x40D7E0", Offset = "0x40BFE0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventSessionTicketAuthSessionTicket__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ADE")]
	[Address(RVA = "0x40D680", Offset = "0x40BE80", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventScreenshotTakeScreenshotRequest__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F24B0", Offset = "0x3F0CB0", Length = "0x78")]
	[Token(Token = "0x6001ADF")]
	public static extern void delete_RailEventkRailEventScreenshotTakeScreenshotRequest(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AE0")]
	[Address(RVA = "0x3C8470", Offset = "0x3C6C70", Length = "0x65")]
	public static extern int RailEventkRailEventScreenshotTakeScreenshotRequest_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AE1")]
	[Address(RVA = "0x3C83F0", Offset = "0x3C6BF0", Length = "0x78")]
	public static extern int RailEventkRailEventScreenshotTakeScreenshotRequest_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AE2")]
	[Address(RVA = "0x40D6F0", Offset = "0x40BEF0", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventScreenshotTakeScreenshotRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40F1B0", Offset = "0x40D9B0", Length = "0x65")]
	[Token(Token = "0x6001AE3")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceRemoveSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3330", Offset = "0x3F1B30", Length = "0x78")]
	[Token(Token = "0x6001AE4")]
	public static extern void delete_RailEventkRailEventUserSpaceRemoveSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x3CAE20", Offset = "0x3C9620", Length = "0x65")]
	public static extern int RailEventkRailEventUserSpaceRemoveSpaceWorkResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CADA0", Offset = "0x3C95A0", Length = "0x78")]
	[Token(Token = "0x6001AE6")]
	public static extern int RailEventkRailEventUserSpaceRemoveSpaceWorkResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x40F220", Offset = "0x40DA20", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUserSpaceRemoveSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x407D70", Offset = "0x406570", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventBrowserStateChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x3EF530", Offset = "0x3EDD30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventBrowserStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x3BFBE0", Offset = "0x3BE3E0", Length = "0x65")]
	public static extern int RailEventkRailEventBrowserStateChanged_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x3BFB60", Offset = "0x3BE360", Length = "0x78")]
	public static extern int RailEventkRailEventBrowserStateChanged_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x407DE0", Offset = "0x4065E0", Length = "0x78")]
	[Token(Token = "0x6001AEC")]
	public static extern IntPtr new_RailEventkRailEventBrowserStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409A80", Offset = "0x408280", Length = "0x65")]
	[Token(Token = "0x6001AED")]
	public static extern IntPtr new_RailEventkRailEventGameServerGetSessionTicket__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F04B0", Offset = "0x3EECB0", Length = "0x78")]
	[Token(Token = "0x6001AEE")]
	public static extern void delete_RailEventkRailEventGameServerGetSessionTicket(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2870", Offset = "0x3C1070", Length = "0x65")]
	[Token(Token = "0x6001AEF")]
	public static extern int RailEventkRailEventGameServerGetSessionTicket_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C27F0", Offset = "0x3C0FF0", Length = "0x78")]
	[Token(Token = "0x6001AF0")]
	public static extern int RailEventkRailEventGameServerGetSessionTicket_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x409AF0", Offset = "0x4082F0", Length = "0x78")]
	[Token(Token = "0x6001AF1")]
	public static extern IntPtr new_RailEventkRailEventGameServerGetSessionTicket__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x40FB10", Offset = "0x40E310", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventUsersInviteJoinGameResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F3830", Offset = "0x3F2030", Length = "0x78")]
	[Token(Token = "0x6001AF3")]
	public static extern void delete_RailEventkRailEventUsersInviteJoinGameResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBC80", Offset = "0x3CA480", Length = "0x65")]
	[Token(Token = "0x6001AF4")]
	public static extern int RailEventkRailEventUsersInviteJoinGameResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CBC00", Offset = "0x3CA400", Length = "0x78")]
	[Token(Token = "0x6001AF5")]
	public static extern int RailEventkRailEventUsersInviteJoinGameResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AF6")]
	[Address(RVA = "0x40FB80", Offset = "0x40E380", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventUsersInviteJoinGameResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AF7")]
	[Address(RVA = "0x40B2E0", Offset = "0x409AE0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateRawSessionFailed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F11B0", Offset = "0x3EF9B0", Length = "0x78")]
	[Token(Token = "0x6001AF8")]
	public static extern void delete_RailEventkRailEventNetworkCreateRawSessionFailed(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001AF9")]
	[Address(RVA = "0x3C4DD0", Offset = "0x3C35D0", Length = "0x65")]
	public static extern int RailEventkRailEventNetworkCreateRawSessionFailed_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3C4D50", Offset = "0x3C3550", Length = "0x78")]
	[Token(Token = "0x6001AFA")]
	public static extern int RailEventkRailEventNetworkCreateRawSessionFailed_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B350", Offset = "0x409B50", Length = "0x78")]
	[Token(Token = "0x6001AFB")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateRawSessionFailed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40A4D0", Offset = "0x408CD0", Length = "0x65")]
	[Token(Token = "0x6001AFC")]
	public static extern IntPtr new_RailEventkRailEventInGameCoinPurchaseCoinsResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F0A30", Offset = "0x3EF230", Length = "0x78")]
	[Token(Token = "0x6001AFD")]
	public static extern void delete_RailEventkRailEventInGameCoinPurchaseCoinsResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3840", Offset = "0x3C2040", Length = "0x65")]
	[Token(Token = "0x6001AFE")]
	public static extern int RailEventkRailEventInGameCoinPurchaseCoinsResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001AFF")]
	[Address(RVA = "0x3C37C0", Offset = "0x3C1FC0", Length = "0x78")]
	public static extern int RailEventkRailEventInGameCoinPurchaseCoinsResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B00")]
	[Address(RVA = "0x40A540", Offset = "0x408D40", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventInGameCoinPurchaseCoinsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B01")]
	[Address(RVA = "0x4068D0", Offset = "0x4050D0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventAppQuerySubscribeWishPlayStateResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B02")]
	[Address(RVA = "0x3EEA30", Offset = "0x3ED230", Length = "0x78")]
	public static extern void delete_RailEventkRailEventAppQuerySubscribeWishPlayStateResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDC40", Offset = "0x3BC440", Length = "0x65")]
	[Token(Token = "0x6001B03")]
	public static extern int RailEventkRailEventAppQuerySubscribeWishPlayStateResult_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3BDBC0", Offset = "0x3BC3C0", Length = "0x78")]
	[Token(Token = "0x6001B04")]
	public static extern int RailEventkRailEventAppQuerySubscribeWishPlayStateResult_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B05")]
	[Address(RVA = "0x406940", Offset = "0x405140", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailEventAppQuerySubscribeWishPlayStateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B06")]
	[Address(RVA = "0x40B4C0", Offset = "0x409CC0", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateSessionFailed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F12B0", Offset = "0x3EFAB0", Length = "0x78")]
	[Token(Token = "0x6001B07")]
	public static extern void delete_RailEventkRailEventNetworkCreateSessionFailed(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C50B0", Offset = "0x3C38B0", Length = "0x65")]
	[Token(Token = "0x6001B08")]
	public static extern int RailEventkRailEventNetworkCreateSessionFailed_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001B09")]
	[Address(RVA = "0x3C5030", Offset = "0x3C3830", Length = "0x78")]
	public static extern int RailEventkRailEventNetworkCreateSessionFailed_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40B530", Offset = "0x409D30", Length = "0x78")]
	[Token(Token = "0x6001B0A")]
	public static extern IntPtr new_RailEventkRailEventNetworkCreateSessionFailed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B0B")]
	[Address(RVA = "0x40BB50", Offset = "0x40A350", Length = "0x65")]
	public static extern IntPtr new_RailEventkRailEventQueryPlayerBannedStatus__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B0C")]
	[Address(RVA = "0x3F1630", Offset = "0x3EFE30", Length = "0x78")]
	public static extern void delete_RailEventkRailEventQueryPlayerBannedStatus(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B0D")]
	[Address(RVA = "0x3C5AC0", Offset = "0x3C42C0", Length = "0x65")]
	public static extern int RailEventkRailEventQueryPlayerBannedStatus_kInternalRailEventEventId_get();

	[PreserveSig]
	[Token(Token = "0x6001B0E")]
	[Address(RVA = "0x3C5A40", Offset = "0x3C4240", Length = "0x78")]
	public static extern int RailEventkRailEventQueryPlayerBannedStatus_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x40BBC0", Offset = "0x40A3C0", Length = "0x78")]
	[Token(Token = "0x6001B0F")]
	public static extern IntPtr new_RailEventkRailEventQueryPlayerBannedStatus__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x410DD0", Offset = "0x40F5D0", Length = "0x65")]
	[Token(Token = "0x6001B10")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByGameServer__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F4230", Offset = "0x3F2A30", Length = "0x78")]
	[Token(Token = "0x6001B11")]
	public static extern void delete_RailEventkRailPlatformNotifyEventJoinGameByGameServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CD940", Offset = "0x3CC140", Length = "0x65")]
	[Token(Token = "0x6001B12")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByGameServer_kInternalRailEventEventId_get();

	[PreserveSig]
	[Address(RVA = "0x3CD8C0", Offset = "0x3CC0C0", Length = "0x78")]
	[Token(Token = "0x6001B13")]
	public static extern int RailEventkRailPlatformNotifyEventJoinGameByGameServer_get_event_id(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B14")]
	[Address(RVA = "0x410E40", Offset = "0x40F640", Length = "0x78")]
	public static extern IntPtr new_RailEventkRailPlatformNotifyEventJoinGameByGameServer__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B15")]
	[Address(RVA = "0x418310", Offset = "0x416B10", Length = "0x65")]
	public static extern IntPtr new_SpaceWorkID__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B16")]
	[Address(RVA = "0x418380", Offset = "0x416B80", Length = "0x78")]
	public static extern IntPtr new_SpaceWorkID__SWIG_1(ulong jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E41F0", Offset = "0x3E29F0", Length = "0x87")]
	[Token(Token = "0x6001B17")]
	public static extern void SpaceWorkID_set_id(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E4170", Offset = "0x3E2970", Length = "0x78")]
	[Token(Token = "0x6001B18")]
	public static extern ulong SpaceWorkID_get_id(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E40F0", Offset = "0x3E28F0", Length = "0x7D")]
	[Token(Token = "0x6001B19")]
	public static extern bool SpaceWorkID_IsValid(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418400", Offset = "0x416C00", Length = "0x78")]
	[Token(Token = "0x6001B1A")]
	public static extern IntPtr new_SpaceWorkID__SWIG_2(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8130", Offset = "0x3F6930", Length = "0x78")]
	[Token(Token = "0x6001B1B")]
	public static extern void delete_SpaceWorkID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B1C")]
	[Address(RVA = "0x3D9850", Offset = "0x3D8050", Length = "0x87")]
	public static extern void RailSpaceWorkFilter_subscriber_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B1D")]
	[Address(RVA = "0x3D97D0", Offset = "0x3D7FD0", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkFilter_subscriber_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B1E")]
	[Address(RVA = "0x3D9740", Offset = "0x3D7F40", Length = "0x87")]
	public static extern void RailSpaceWorkFilter_creator_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B1F")]
	[Address(RVA = "0x3D96C0", Offset = "0x3D7EC0", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkFilter_creator_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B20")]
	[Address(RVA = "0x3D9960", Offset = "0x3D8160", Length = "0x87")]
	public static extern void RailSpaceWorkFilter_type_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D98E0", Offset = "0x3D80E0", Length = "0x78")]
	[Token(Token = "0x6001B21")]
	public static extern IntPtr RailSpaceWorkFilter_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B22")]
	[Address(RVA = "0x3D9630", Offset = "0x3D7E30", Length = "0x87")]
	public static extern void RailSpaceWorkFilter_collector_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B23")]
	[Address(RVA = "0x3D95B0", Offset = "0x3D7DB0", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkFilter_collector_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B24")]
	[Address(RVA = "0x3D9520", Offset = "0x3D7D20", Length = "0x87")]
	public static extern void RailSpaceWorkFilter_classes_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D94A0", Offset = "0x3D7CA0", Length = "0x78")]
	[Token(Token = "0x6001B25")]
	public static extern IntPtr RailSpaceWorkFilter_classes_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415050", Offset = "0x413850", Length = "0x65")]
	[Token(Token = "0x6001B26")]
	public static extern IntPtr new_RailSpaceWorkFilter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x4150C0", Offset = "0x4138C0", Length = "0x78")]
	public static extern IntPtr new_RailSpaceWorkFilter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x3F6630", Offset = "0x3F4E30", Length = "0x78")]
	public static extern void delete_RailSpaceWorkFilter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x3D7C60", Offset = "0x3D6460", Length = "0x86")]
	public static extern void RailQueryWorkFileOptions_with_url_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D7BE0", Offset = "0x3D63E0", Length = "0x7D")]
	[Token(Token = "0x6001B2A")]
	public static extern bool RailQueryWorkFileOptions_with_url_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B2B")]
	[Address(RVA = "0x3D7930", Offset = "0x3D6130", Length = "0x86")]
	public static extern void RailQueryWorkFileOptions_with_description_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D78B0", Offset = "0x3D60B0", Length = "0x7D")]
	[Token(Token = "0x6001B2C")]
	public static extern bool RailQueryWorkFileOptions_with_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x3D7820", Offset = "0x3D6020", Length = "0x86")]
	public static extern void RailQueryWorkFileOptions_query_total_only_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D77A0", Offset = "0x3D5FA0", Length = "0x7D")]
	[Token(Token = "0x6001B2E")]
	public static extern bool RailQueryWorkFileOptions_query_total_only_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7B50", Offset = "0x3D6350", Length = "0x86")]
	[Token(Token = "0x6001B2F")]
	public static extern void RailQueryWorkFileOptions_with_uploader_ids_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D7AD0", Offset = "0x3D62D0", Length = "0x7D")]
	[Token(Token = "0x6001B30")]
	public static extern bool RailQueryWorkFileOptions_with_uploader_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7A40", Offset = "0x3D6240", Length = "0x86")]
	[Token(Token = "0x6001B31")]
	public static extern void RailQueryWorkFileOptions_with_preview_url_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B32")]
	[Address(RVA = "0x3D79C0", Offset = "0x3D61C0", Length = "0x7D")]
	public static extern bool RailQueryWorkFileOptions_with_preview_url_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B33")]
	[Address(RVA = "0x3D7D70", Offset = "0x3D6570", Length = "0x86")]
	public static extern void RailQueryWorkFileOptions_with_vote_detail_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B34")]
	[Address(RVA = "0x3D7CF0", Offset = "0x3D64F0", Length = "0x7D")]
	public static extern bool RailQueryWorkFileOptions_with_vote_detail_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x3D7710", Offset = "0x3D5F10", Length = "0x85")]
	public static extern void RailQueryWorkFileOptions_preview_scaling_rate_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D7690", Offset = "0x3D5E90", Length = "0x78")]
	[Token(Token = "0x6001B36")]
	public static extern uint RailQueryWorkFileOptions_preview_scaling_rate_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414860", Offset = "0x413060", Length = "0x65")]
	[Token(Token = "0x6001B37")]
	public static extern IntPtr new_RailQueryWorkFileOptions__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x4148D0", Offset = "0x4130D0", Length = "0x78")]
	public static extern IntPtr new_RailQueryWorkFileOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F61B0", Offset = "0x3F49B0", Length = "0x78")]
	[Token(Token = "0x6001B39")]
	public static extern void delete_RailQueryWorkFileOptions(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DA300", Offset = "0x3D8B00", Length = "0x87")]
	[Token(Token = "0x6001B3A")]
	public static extern void RailSpaceWorkSyncProgress_finished_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA280", Offset = "0x3D8A80", Length = "0x78")]
	[Token(Token = "0x6001B3B")]
	public static extern ulong RailSpaceWorkSyncProgress_finished_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DA520", Offset = "0x3D8D20", Length = "0x87")]
	[Token(Token = "0x6001B3C")]
	public static extern void RailSpaceWorkSyncProgress_total_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x3DA4A0", Offset = "0x3D8CA0", Length = "0x78")]
	public static extern ulong RailSpaceWorkSyncProgress_total_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x3DA410", Offset = "0x3D8C10", Length = "0x88")]
	public static extern void RailSpaceWorkSyncProgress_progress_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA390", Offset = "0x3D8B90", Length = "0x78")]
	[Token(Token = "0x6001B3F")]
	public static extern float RailSpaceWorkSyncProgress_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DA1F0", Offset = "0x3D89F0", Length = "0x85")]
	[Token(Token = "0x6001B40")]
	public static extern void RailSpaceWorkSyncProgress_current_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x3DA170", Offset = "0x3D8970", Length = "0x78")]
	public static extern int RailSpaceWorkSyncProgress_current_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x415230", Offset = "0x413A30", Length = "0x65")]
	public static extern IntPtr new_RailSpaceWorkSyncProgress__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4152A0", Offset = "0x413AA0", Length = "0x78")]
	[Token(Token = "0x6001B43")]
	public static extern IntPtr new_RailSpaceWorkSyncProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6730", Offset = "0x3F4F30", Length = "0x78")]
	[Token(Token = "0x6001B44")]
	public static extern void delete_RailSpaceWorkSyncProgress(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B45")]
	[Address(RVA = "0x3DAC90", Offset = "0x3D9490", Length = "0x85")]
	public static extern void RailSpaceWorkVoteDetail_vote_value_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B46")]
	[Address(RVA = "0x3DAC10", Offset = "0x3D9410", Length = "0x78")]
	public static extern int RailSpaceWorkVoteDetail_vote_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B47")]
	[Address(RVA = "0x3DADA0", Offset = "0x3D95A0", Length = "0x85")]
	public static extern void RailSpaceWorkVoteDetail_voted_players_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B48")]
	[Address(RVA = "0x3DAD20", Offset = "0x3D9520", Length = "0x78")]
	public static extern uint RailSpaceWorkVoteDetail_voted_players_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415410", Offset = "0x413C10", Length = "0x65")]
	[Token(Token = "0x6001B49")]
	public static extern IntPtr new_RailSpaceWorkVoteDetail__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B4A")]
	[Address(RVA = "0x415480", Offset = "0x413C80", Length = "0x78")]
	public static extern IntPtr new_RailSpaceWorkVoteDetail__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B4B")]
	[Address(RVA = "0x3F6830", Offset = "0x3F5030", Length = "0x78")]
	public static extern void delete_RailSpaceWorkVoteDetail(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B4C")]
	[Address(RVA = "0x3D8D70", Offset = "0x3D7570", Length = "0x87")]
	public static extern void RailSpaceWorkDescriptor_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B4D")]
	[Address(RVA = "0x3D8CF0", Offset = "0x3D74F0", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkDescriptor_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B4E")]
	[Address(RVA = "0x3D8E80", Offset = "0x3D7680", Length = "0x9B")]
	public static extern void RailSpaceWorkDescriptor_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B4F")]
	[Address(RVA = "0x3D8E00", Offset = "0x3D7600", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkDescriptor_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B50")]
	[Address(RVA = "0x3D8B30", Offset = "0x3D7330", Length = "0x9B")]
	public static extern void RailSpaceWorkDescriptor_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D8AB0", Offset = "0x3D72B0", Length = "0x78")]
	[Token(Token = "0x6001B51")]
	public static extern IntPtr RailSpaceWorkDescriptor_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x3D8C50", Offset = "0x3D7450", Length = "0x9B")]
	public static extern void RailSpaceWorkDescriptor_detail_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x3D8BD0", Offset = "0x3D73D0", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkDescriptor_detail_url_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x3D8A20", Offset = "0x3D7220", Length = "0x85")]
	public static extern void RailSpaceWorkDescriptor_create_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x3D89A0", Offset = "0x3D71A0", Length = "0x78")]
	public static extern uint RailSpaceWorkDescriptor_create_time_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9300", Offset = "0x3D7B00", Length = "0x87")]
	[Token(Token = "0x6001B56")]
	public static extern void RailSpaceWorkDescriptor_uploader_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x3D9280", Offset = "0x3D7A80", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkDescriptor_uploader_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D90C0", Offset = "0x3D78C0", Length = "0x9B")]
	[Token(Token = "0x6001B58")]
	public static extern void RailSpaceWorkDescriptor_preview_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9040", Offset = "0x3D7840", Length = "0x78")]
	[Token(Token = "0x6001B59")]
	public static extern IntPtr RailSpaceWorkDescriptor_preview_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D8FA0", Offset = "0x3D77A0", Length = "0x9B")]
	[Token(Token = "0x6001B5A")]
	public static extern void RailSpaceWorkDescriptor_preview_scaling_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x3D8F20", Offset = "0x3D7720", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkDescriptor_preview_scaling_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9410", Offset = "0x3D7C10", Length = "0x87")]
	[Token(Token = "0x6001B5C")]
	public static extern void RailSpaceWorkDescriptor_vote_details_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9390", Offset = "0x3D7B90", Length = "0x78")]
	[Token(Token = "0x6001B5D")]
	public static extern IntPtr RailSpaceWorkDescriptor_vote_details_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D91E0", Offset = "0x3D79E0", Length = "0x9B")]
	[Token(Token = "0x6001B5E")]
	public static extern void RailSpaceWorkDescriptor_recommendation_rate_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9160", Offset = "0x3D7960", Length = "0x78")]
	[Token(Token = "0x6001B5F")]
	public static extern IntPtr RailSpaceWorkDescriptor_recommendation_rate_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B60")]
	[Address(RVA = "0x414F60", Offset = "0x413760", Length = "0x65")]
	public static extern IntPtr new_RailSpaceWorkDescriptor__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B61")]
	[Address(RVA = "0x414FD0", Offset = "0x4137D0", Length = "0x78")]
	public static extern IntPtr new_RailSpaceWorkDescriptor__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B62")]
	[Address(RVA = "0x3F65B0", Offset = "0x3F4DB0", Length = "0x78")]
	public static extern void delete_RailSpaceWorkDescriptor(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DCD70", Offset = "0x3DB570", Length = "0x87")]
	[Token(Token = "0x6001B63")]
	public static extern void RailUserSpaceDownloadProgress_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DCCF0", Offset = "0x3DB4F0", Length = "0x78")]
	[Token(Token = "0x6001B64")]
	public static extern IntPtr RailUserSpaceDownloadProgress_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B65")]
	[Address(RVA = "0x3DCE80", Offset = "0x3DB680", Length = "0x85")]
	public static extern void RailUserSpaceDownloadProgress_progress_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DCE00", Offset = "0x3DB600", Length = "0x78")]
	[Token(Token = "0x6001B66")]
	public static extern uint RailUserSpaceDownloadProgress_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x3DD0A0", Offset = "0x3DB8A0", Length = "0x87")]
	public static extern void RailUserSpaceDownloadProgress_total_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x3DD020", Offset = "0x3DB820", Length = "0x78")]
	public static extern ulong RailUserSpaceDownloadProgress_total_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DCC60", Offset = "0x3DB460", Length = "0x87")]
	[Token(Token = "0x6001B69")]
	public static extern void RailUserSpaceDownloadProgress_finidshed_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DCBE0", Offset = "0x3DB3E0", Length = "0x78")]
	[Token(Token = "0x6001B6A")]
	public static extern ulong RailUserSpaceDownloadProgress_finidshed_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DCF90", Offset = "0x3DB790", Length = "0x85")]
	[Token(Token = "0x6001B6B")]
	public static extern void RailUserSpaceDownloadProgress_speed_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DCF10", Offset = "0x3DB710", Length = "0x78")]
	[Token(Token = "0x6001B6C")]
	public static extern uint RailUserSpaceDownloadProgress_speed_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415F70", Offset = "0x414770", Length = "0x65")]
	[Token(Token = "0x6001B6D")]
	public static extern IntPtr new_RailUserSpaceDownloadProgress__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x415FE0", Offset = "0x4147E0", Length = "0x78")]
	public static extern IntPtr new_RailUserSpaceDownloadProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x3F6E30", Offset = "0x3F5630", Length = "0x78")]
	public static extern void delete_RailUserSpaceDownloadProgress(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x3DD600", Offset = "0x3DBE00", Length = "0x87")]
	public static extern void RailUserSpaceDownloadResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x3DD580", Offset = "0x3DBD80", Length = "0x78")]
	public static extern IntPtr RailUserSpaceDownloadResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x3DD1B0", Offset = "0x3DB9B0", Length = "0x85")]
	public static extern void RailUserSpaceDownloadResult_err_code_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DD130", Offset = "0x3DB930", Length = "0x78")]
	[Token(Token = "0x6001B73")]
	public static extern uint RailUserSpaceDownloadResult_err_code_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DD710", Offset = "0x3DBF10", Length = "0x87")]
	[Token(Token = "0x6001B74")]
	public static extern void RailUserSpaceDownloadResult_total_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x3DD690", Offset = "0x3DBE90", Length = "0x78")]
	public static extern ulong RailUserSpaceDownloadResult_total_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DD3E0", Offset = "0x3DBBE0", Length = "0x87")]
	[Token(Token = "0x6001B76")]
	public static extern void RailUserSpaceDownloadResult_finished_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DD360", Offset = "0x3DBB60", Length = "0x78")]
	[Token(Token = "0x6001B77")]
	public static extern ulong RailUserSpaceDownloadResult_finished_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x3DD820", Offset = "0x3DC020", Length = "0x85")]
	public static extern void RailUserSpaceDownloadResult_total_files_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x3DD7A0", Offset = "0x3DBFA0", Length = "0x78")]
	public static extern uint RailUserSpaceDownloadResult_total_files_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x3DD4F0", Offset = "0x3DBCF0", Length = "0x85")]
	public static extern void RailUserSpaceDownloadResult_finished_files_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DD470", Offset = "0x3DBC70", Length = "0x78")]
	[Token(Token = "0x6001B7B")]
	public static extern uint RailUserSpaceDownloadResult_finished_files_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DD2C0", Offset = "0x3DBAC0", Length = "0x9B")]
	[Token(Token = "0x6001B7C")]
	public static extern void RailUserSpaceDownloadResult_err_msg_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B7D")]
	[Address(RVA = "0x3DD240", Offset = "0x3DBA40", Length = "0x78")]
	public static extern IntPtr RailUserSpaceDownloadResult_err_msg_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B7E")]
	[Address(RVA = "0x416060", Offset = "0x414860", Length = "0x65")]
	public static extern IntPtr new_RailUserSpaceDownloadResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B7F")]
	[Address(RVA = "0x4160D0", Offset = "0x4148D0", Length = "0x78")]
	public static extern IntPtr new_RailUserSpaceDownloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6EB0", Offset = "0x3F56B0", Length = "0x78")]
	[Token(Token = "0x6001B80")]
	public static extern void delete_RailUserSpaceDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37F680", Offset = "0x37DE80", Length = "0x87")]
	[Token(Token = "0x6001B81")]
	public static extern void AsyncGetMySubscribedWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x37F600", Offset = "0x37DE00", Length = "0x78")]
	public static extern IntPtr AsyncGetMySubscribedWorksResult_spacework_descriptors_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37F790", Offset = "0x37DF90", Length = "0x85")]
	[Token(Token = "0x6001B83")]
	public static extern void AsyncGetMySubscribedWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x37F710", Offset = "0x37DF10", Length = "0x78")]
	[Token(Token = "0x6001B84")]
	public static extern uint AsyncGetMySubscribedWorksResult_total_available_works_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B85")]
	[Address(RVA = "0x3F9290", Offset = "0x3F7A90", Length = "0x65")]
	public static extern IntPtr new_AsyncGetMySubscribedWorksResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F9300", Offset = "0x3F7B00", Length = "0x78")]
	[Token(Token = "0x6001B86")]
	public static extern IntPtr new_AsyncGetMySubscribedWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B87")]
	[Address(RVA = "0x3E7930", Offset = "0x3E6130", Length = "0x78")]
	public static extern void delete_AsyncGetMySubscribedWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B88")]
	[Address(RVA = "0x37F3E0", Offset = "0x37DBE0", Length = "0x87")]
	public static extern void AsyncGetMyFavoritesWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37F360", Offset = "0x37DB60", Length = "0x78")]
	[Token(Token = "0x6001B89")]
	public static extern IntPtr AsyncGetMyFavoritesWorksResult_spacework_descriptors_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x37F4F0", Offset = "0x37DCF0", Length = "0x85")]
	public static extern void AsyncGetMyFavoritesWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x37F470", Offset = "0x37DC70", Length = "0x78")]
	[Token(Token = "0x6001B8B")]
	public static extern uint AsyncGetMyFavoritesWorksResult_total_available_works_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F91A0", Offset = "0x3F79A0", Length = "0x65")]
	[Token(Token = "0x6001B8C")]
	public static extern IntPtr new_AsyncGetMyFavoritesWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x3F9210", Offset = "0x3F7A10", Length = "0x78")]
	public static extern IntPtr new_AsyncGetMyFavoritesWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x3E78B0", Offset = "0x3E60B0", Length = "0x78")]
	public static extern void delete_AsyncGetMyFavoritesWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x380430", Offset = "0x37EC30", Length = "0x87")]
	public static extern void AsyncQuerySpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x3803B0", Offset = "0x37EBB0", Length = "0x78")]
	public static extern IntPtr AsyncQuerySpaceWorksResult_spacework_descriptors_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x380540", Offset = "0x37ED40", Length = "0x85")]
	public static extern void AsyncQuerySpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B92")]
	[Address(RVA = "0x3804C0", Offset = "0x37ECC0", Length = "0x78")]
	public static extern uint AsyncQuerySpaceWorksResult_total_available_works_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B93")]
	[Address(RVA = "0x3F9650", Offset = "0x3F7E50", Length = "0x65")]
	public static extern IntPtr new_AsyncQuerySpaceWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B94")]
	[Address(RVA = "0x3F96C0", Offset = "0x3F7EC0", Length = "0x78")]
	public static extern IntPtr new_AsyncQuerySpaceWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7B30", Offset = "0x3E6330", Length = "0x78")]
	[Token(Token = "0x6001B95")]
	public static extern void delete_AsyncQuerySpaceWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381E50", Offset = "0x380650", Length = "0x87")]
	[Token(Token = "0x6001B96")]
	public static extern void AsyncUpdateMetadataResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B97")]
	[Address(RVA = "0x381DD0", Offset = "0x3805D0", Length = "0x78")]
	public static extern IntPtr AsyncUpdateMetadataResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B98")]
	[Address(RVA = "0x381F60", Offset = "0x380760", Length = "0x85")]
	public static extern void AsyncUpdateMetadataResult_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B99")]
	[Address(RVA = "0x381EE0", Offset = "0x3806E0", Length = "0x78")]
	public static extern int AsyncUpdateMetadataResult_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x3F9EC0", Offset = "0x3F86C0", Length = "0x65")]
	public static extern IntPtr new_AsyncUpdateMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x3F9F30", Offset = "0x3F8730", Length = "0x78")]
	public static extern IntPtr new_AsyncUpdateMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7FB0", Offset = "0x3E67B0", Length = "0x78")]
	[Token(Token = "0x6001B9C")]
	public static extern void delete_AsyncUpdateMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B9D")]
	[Address(RVA = "0x3E4E00", Offset = "0x3E3600", Length = "0x87")]
	public static extern void SyncSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x3E4D80", Offset = "0x3E3580", Length = "0x78")]
	public static extern IntPtr SyncSpaceWorkResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x418840", Offset = "0x417040", Length = "0x65")]
	public static extern IntPtr new_SyncSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4188B0", Offset = "0x4170B0", Length = "0x78")]
	[Token(Token = "0x6001BA0")]
	public static extern IntPtr new_SyncSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x3F83B0", Offset = "0x3F6BB0", Length = "0x78")]
	public static extern void delete_SyncSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BA2")]
	[Address(RVA = "0x381CC0", Offset = "0x3804C0", Length = "0x87")]
	public static extern void AsyncSubscribeSpaceWorksResult_success_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BA3")]
	[Address(RVA = "0x381C40", Offset = "0x380440", Length = "0x78")]
	public static extern IntPtr AsyncSubscribeSpaceWorksResult_success_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381AA0", Offset = "0x3802A0", Length = "0x87")]
	[Token(Token = "0x6001BA4")]
	public static extern void AsyncSubscribeSpaceWorksResult_failure_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x381A20", Offset = "0x380220", Length = "0x78")]
	[Token(Token = "0x6001BA5")]
	public static extern IntPtr AsyncSubscribeSpaceWorksResult_failure_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381BB0", Offset = "0x3803B0", Length = "0x86")]
	[Token(Token = "0x6001BA6")]
	public static extern void AsyncSubscribeSpaceWorksResult_subscribe_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x381B30", Offset = "0x380330", Length = "0x7D")]
	[Token(Token = "0x6001BA7")]
	public static extern bool AsyncSubscribeSpaceWorksResult_subscribe_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BA8")]
	[Address(RVA = "0x3F9DD0", Offset = "0x3F85D0", Length = "0x65")]
	public static extern IntPtr new_AsyncSubscribeSpaceWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BA9")]
	[Address(RVA = "0x3F9E40", Offset = "0x3F8640", Length = "0x78")]
	public static extern IntPtr new_AsyncSubscribeSpaceWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x3E7F30", Offset = "0x3E6730", Length = "0x78")]
	public static extern void delete_AsyncSubscribeSpaceWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x380000", Offset = "0x37E800", Length = "0x87")]
	public static extern void AsyncModifyFavoritesWorksResult_success_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37FF80", Offset = "0x37E780", Length = "0x78")]
	[Token(Token = "0x6001BAC")]
	public static extern IntPtr AsyncModifyFavoritesWorksResult_success_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37FDE0", Offset = "0x37E5E0", Length = "0x87")]
	[Token(Token = "0x6001BAD")]
	public static extern void AsyncModifyFavoritesWorksResult_failure_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37FD60", Offset = "0x37E560", Length = "0x78")]
	[Token(Token = "0x6001BAE")]
	public static extern IntPtr AsyncModifyFavoritesWorksResult_failure_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x37FEF0", Offset = "0x37E6F0", Length = "0x85")]
	public static extern void AsyncModifyFavoritesWorksResult_modify_flag_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x37FE70", Offset = "0x37E670", Length = "0x78")]
	[Token(Token = "0x6001BB0")]
	public static extern int AsyncModifyFavoritesWorksResult_modify_flag_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x3F9470", Offset = "0x3F7C70", Length = "0x65")]
	public static extern IntPtr new_AsyncModifyFavoritesWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x3F94E0", Offset = "0x3F7CE0", Length = "0x78")]
	public static extern IntPtr new_AsyncModifyFavoritesWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x3E7A30", Offset = "0x3E6230", Length = "0x78")]
	public static extern void delete_AsyncModifyFavoritesWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x3813B0", Offset = "0x37FBB0", Length = "0x87")]
	public static extern void AsyncRemoveSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x381330", Offset = "0x37FB30", Length = "0x78")]
	[Token(Token = "0x6001BB5")]
	public static extern IntPtr AsyncRemoveSpaceWorkResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9B00", Offset = "0x3F8300", Length = "0x65")]
	[Token(Token = "0x6001BB6")]
	public static extern IntPtr new_AsyncRemoveSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F9B70", Offset = "0x3F8370", Length = "0x78")]
	[Token(Token = "0x6001BB7")]
	public static extern IntPtr new_AsyncRemoveSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BB8")]
	[Address(RVA = "0x3E7DB0", Offset = "0x3E65B0", Length = "0x78")]
	public static extern void delete_AsyncRemoveSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3820F0", Offset = "0x3808F0", Length = "0x87")]
	[Token(Token = "0x6001BB9")]
	public static extern void AsyncVoteSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BBA")]
	[Address(RVA = "0x382070", Offset = "0x380870", Length = "0x78")]
	public static extern IntPtr AsyncVoteSpaceWorkResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BBB")]
	[Address(RVA = "0x3F9FB0", Offset = "0x3F87B0", Length = "0x65")]
	public static extern IntPtr new_AsyncVoteSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BBC")]
	[Address(RVA = "0x3FA020", Offset = "0x3F8820", Length = "0x78")]
	public static extern IntPtr new_AsyncVoteSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BBD")]
	[Address(RVA = "0x3E8030", Offset = "0x3E6830", Length = "0x78")]
	public static extern void delete_AsyncVoteSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BBE")]
	[Address(RVA = "0x3806D0", Offset = "0x37EED0", Length = "0x87")]
	public static extern void AsyncRateSpaceWorkResult_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x380650", Offset = "0x37EE50", Length = "0x78")]
	[Token(Token = "0x6001BBF")]
	public static extern IntPtr AsyncRateSpaceWorkResult_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9740", Offset = "0x3F7F40", Length = "0x65")]
	[Token(Token = "0x6001BC0")]
	public static extern IntPtr new_AsyncRateSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3F97B0", Offset = "0x3F7FB0", Length = "0x78")]
	[Token(Token = "0x6001BC1")]
	public static extern IntPtr new_AsyncRateSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BC2")]
	[Address(RVA = "0x3E7BB0", Offset = "0x3E63B0", Length = "0x78")]
	public static extern void delete_AsyncRateSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381800", Offset = "0x380000", Length = "0x87")]
	[Token(Token = "0x6001BC3")]
	public static extern void AsyncSearchSpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x381780", Offset = "0x37FF80", Length = "0x78")]
	public static extern IntPtr AsyncSearchSpaceWorksResult_spacework_descriptors_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x381910", Offset = "0x380110", Length = "0x85")]
	public static extern void AsyncSearchSpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x381890", Offset = "0x380090", Length = "0x78")]
	public static extern uint AsyncSearchSpaceWorksResult_total_available_works_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9CE0", Offset = "0x3F84E0", Length = "0x65")]
	[Token(Token = "0x6001BC7")]
	public static extern IntPtr new_AsyncSearchSpaceWorksResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x3F9D50", Offset = "0x3F8550", Length = "0x78")]
	public static extern IntPtr new_AsyncSearchSpaceWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7EB0", Offset = "0x3E66B0", Length = "0x78")]
	[Token(Token = "0x6001BC9")]
	public static extern void delete_AsyncSearchSpaceWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x3E5A20", Offset = "0x3E4220", Length = "0x87")]
	public static extern void UserSpaceDownloadProgress_progress_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E59A0", Offset = "0x3E41A0", Length = "0x78")]
	[Token(Token = "0x6001BCB")]
	public static extern IntPtr UserSpaceDownloadProgress_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5B30", Offset = "0x3E4330", Length = "0x85")]
	[Token(Token = "0x6001BCC")]
	public static extern void UserSpaceDownloadProgress_total_progress_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x3E5AB0", Offset = "0x3E42B0", Length = "0x78")]
	public static extern uint UserSpaceDownloadProgress_total_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x418CF0", Offset = "0x4174F0", Length = "0x65")]
	public static extern IntPtr new_UserSpaceDownloadProgress__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BCF")]
	[Address(RVA = "0x418D60", Offset = "0x417560", Length = "0x78")]
	public static extern IntPtr new_UserSpaceDownloadProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8630", Offset = "0x3F6E30", Length = "0x78")]
	[Token(Token = "0x6001BD0")]
	public static extern void delete_UserSpaceDownloadProgress(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5CC0", Offset = "0x3E44C0", Length = "0x87")]
	[Token(Token = "0x6001BD1")]
	public static extern void UserSpaceDownloadResult_results_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E5C40", Offset = "0x3E4440", Length = "0x78")]
	[Token(Token = "0x6001BD2")]
	public static extern IntPtr UserSpaceDownloadResult_results_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5DD0", Offset = "0x3E45D0", Length = "0x85")]
	[Token(Token = "0x6001BD3")]
	public static extern void UserSpaceDownloadResult_total_results_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E5D50", Offset = "0x3E4550", Length = "0x78")]
	[Token(Token = "0x6001BD4")]
	public static extern uint UserSpaceDownloadResult_total_results_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x418DE0", Offset = "0x4175E0", Length = "0x65")]
	public static extern IntPtr new_UserSpaceDownloadResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x418E50", Offset = "0x417650", Length = "0x78")]
	[Token(Token = "0x6001BD6")]
	public static extern IntPtr new_UserSpaceDownloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x3F86B0", Offset = "0x3F6EB0", Length = "0x78")]
	public static extern void delete_UserSpaceDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA440", Offset = "0x3A8C40", Length = "0x87")]
	[Token(Token = "0x6001BD8")]
	public static extern void QueryMySubscribedSpaceWorksResult_spacework_descriptors_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x3AA3C0", Offset = "0x3A8BC0", Length = "0x78")]
	public static extern IntPtr QueryMySubscribedSpaceWorksResult_spacework_descriptors_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x3AA550", Offset = "0x3A8D50", Length = "0x85")]
	public static extern void QueryMySubscribedSpaceWorksResult_spacework_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AA4D0", Offset = "0x3A8CD0", Length = "0x78")]
	[Token(Token = "0x6001BDB")]
	public static extern int QueryMySubscribedSpaceWorksResult_spacework_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA660", Offset = "0x3A8E60", Length = "0x85")]
	[Token(Token = "0x6001BDC")]
	public static extern void QueryMySubscribedSpaceWorksResult_total_available_works_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AA5E0", Offset = "0x3A8DE0", Length = "0x78")]
	[Token(Token = "0x6001BDD")]
	public static extern uint QueryMySubscribedSpaceWorksResult_total_available_works_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x3FF230", Offset = "0x3FDA30", Length = "0x65")]
	public static extern IntPtr new_QueryMySubscribedSpaceWorksResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FF2A0", Offset = "0x3FDAA0", Length = "0x78")]
	[Token(Token = "0x6001BDF")]
	public static extern IntPtr new_QueryMySubscribedSpaceWorksResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC6B0", Offset = "0x3EAEB0", Length = "0x78")]
	[Token(Token = "0x6001BE0")]
	public static extern void delete_QueryMySubscribedSpaceWorksResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DA850", Offset = "0x3D9050", Length = "0x86")]
	[Token(Token = "0x6001BE1")]
	public static extern void RailSpaceWorkUpdateOptions_with_detail_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA7D0", Offset = "0x3D8FD0", Length = "0x7D")]
	[Token(Token = "0x6001BE2")]
	public static extern bool RailSpaceWorkUpdateOptions_with_detail_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x3DA960", Offset = "0x3D9160", Length = "0x86")]
	public static extern void RailSpaceWorkUpdateOptions_with_metadata_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA8E0", Offset = "0x3D90E0", Length = "0x7D")]
	[Token(Token = "0x6001BE4")]
	public static extern bool RailSpaceWorkUpdateOptions_with_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DA740", Offset = "0x3D8F40", Length = "0x86")]
	[Token(Token = "0x6001BE5")]
	public static extern void RailSpaceWorkUpdateOptions_check_has_subscribed_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x3DA6C0", Offset = "0x3D8EC0", Length = "0x7D")]
	public static extern bool RailSpaceWorkUpdateOptions_check_has_subscribed_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x3DA630", Offset = "0x3D8E30", Length = "0x86")]
	public static extern void RailSpaceWorkUpdateOptions_check_has_favorited_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x3DA5B0", Offset = "0x3D8DB0", Length = "0x7D")]
	public static extern bool RailSpaceWorkUpdateOptions_check_has_favorited_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x3DAA70", Offset = "0x3D9270", Length = "0x86")]
	public static extern void RailSpaceWorkUpdateOptions_with_my_vote_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA9F0", Offset = "0x3D91F0", Length = "0x7D")]
	[Token(Token = "0x6001BEA")]
	public static extern bool RailSpaceWorkUpdateOptions_with_my_vote_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DAB80", Offset = "0x3D9380", Length = "0x86")]
	[Token(Token = "0x6001BEB")]
	public static extern void RailSpaceWorkUpdateOptions_with_vote_detail_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0x3DAB00", Offset = "0x3D9300", Length = "0x7D")]
	public static extern bool RailSpaceWorkUpdateOptions_with_vote_detail_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x415320", Offset = "0x413B20", Length = "0x65")]
	public static extern IntPtr new_RailSpaceWorkUpdateOptions__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x415390", Offset = "0x413B90", Length = "0x78")]
	public static extern IntPtr new_RailSpaceWorkUpdateOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x3F67B0", Offset = "0x3F4FB0", Length = "0x78")]
	public static extern void delete_RailSpaceWorkUpdateOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x415140", Offset = "0x413940", Length = "0x65")]
	public static extern IntPtr new_RailSpaceWorkSearchFilter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x3DA0D0", Offset = "0x3D88D0", Length = "0x9B")]
	public static extern void RailSpaceWorkSearchFilter_search_text_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DA050", Offset = "0x3D8850", Length = "0x78")]
	[Token(Token = "0x6001BF2")]
	public static extern IntPtr RailSpaceWorkSearchFilter_search_text_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9FC0", Offset = "0x3D87C0", Length = "0x87")]
	[Token(Token = "0x6001BF3")]
	public static extern void RailSpaceWorkSearchFilter_required_tags_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9F40", Offset = "0x3D8740", Length = "0x78")]
	[Token(Token = "0x6001BF4")]
	public static extern IntPtr RailSpaceWorkSearchFilter_required_tags_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9B80", Offset = "0x3D8380", Length = "0x87")]
	[Token(Token = "0x6001BF5")]
	public static extern void RailSpaceWorkSearchFilter_excluded_tags_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x3D9B00", Offset = "0x3D8300", Length = "0x78")]
	public static extern IntPtr RailSpaceWorkSearchFilter_excluded_tags_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9EB0", Offset = "0x3D86B0", Length = "0x87")]
	[Token(Token = "0x6001BF7")]
	public static extern void RailSpaceWorkSearchFilter_required_metadata_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9E30", Offset = "0x3D8630", Length = "0x78")]
	[Token(Token = "0x6001BF8")]
	public static extern IntPtr RailSpaceWorkSearchFilter_required_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x3D9A70", Offset = "0x3D8270", Length = "0x87")]
	public static extern void RailSpaceWorkSearchFilter_excluded_metadata_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D99F0", Offset = "0x3D81F0", Length = "0x78")]
	[Token(Token = "0x6001BFA")]
	public static extern IntPtr RailSpaceWorkSearchFilter_excluded_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9C90", Offset = "0x3D8490", Length = "0x86")]
	[Token(Token = "0x6001BFB")]
	public static extern void RailSpaceWorkSearchFilter_match_all_required_metadata_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9C10", Offset = "0x3D8410", Length = "0x7D")]
	[Token(Token = "0x6001BFC")]
	public static extern bool RailSpaceWorkSearchFilter_match_all_required_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D9DA0", Offset = "0x3D85A0", Length = "0x86")]
	[Token(Token = "0x6001BFD")]
	public static extern void RailSpaceWorkSearchFilter_match_all_required_tags_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D9D20", Offset = "0x3D8520", Length = "0x7D")]
	[Token(Token = "0x6001BFE")]
	public static extern bool RailSpaceWorkSearchFilter_match_all_required_tags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x4151B0", Offset = "0x4139B0", Length = "0x78")]
	public static extern IntPtr new_RailSpaceWorkSearchFilter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F66B0", Offset = "0x3F4EB0", Length = "0x78")]
	[Token(Token = "0x6001C00")]
	public static extern void delete_RailSpaceWorkSearchFilter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3D00", Offset = "0x3D2500", Length = "0x85")]
	[Token(Token = "0x6001C01")]
	public static extern void RailInviteOptions_invite_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x3D3C80", Offset = "0x3D2480", Length = "0x78")]
	public static extern int RailInviteOptions_invite_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3E10", Offset = "0x3D2610", Length = "0x86")]
	[Token(Token = "0x6001C03")]
	public static extern void RailInviteOptions_need_respond_in_game_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x3D3D90", Offset = "0x3D2590", Length = "0x7D")]
	public static extern bool RailInviteOptions_need_respond_in_game_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3AD0", Offset = "0x3D22D0", Length = "0x9B")]
	[Token(Token = "0x6001C05")]
	public static extern void RailInviteOptions_additional_message_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D3A50", Offset = "0x3D2250", Length = "0x78")]
	[Token(Token = "0x6001C06")]
	public static extern IntPtr RailInviteOptions_additional_message_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3BF0", Offset = "0x3D23F0", Length = "0x85")]
	[Token(Token = "0x6001C07")]
	public static extern void RailInviteOptions_expire_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C08")]
	[Address(RVA = "0x3D3B70", Offset = "0x3D2370", Length = "0x78")]
	public static extern uint RailInviteOptions_expire_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C09")]
	[Address(RVA = "0x4139E0", Offset = "0x4121E0", Length = "0x65")]
	public static extern IntPtr new_RailInviteOptions__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x413A50", Offset = "0x412250", Length = "0x78")]
	[Token(Token = "0x6001C0A")]
	public static extern IntPtr new_RailInviteOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C0B")]
	[Address(RVA = "0x3F59B0", Offset = "0x3F41B0", Length = "0x78")]
	public static extern void delete_RailInviteOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C0C")]
	[Address(RVA = "0x416420", Offset = "0x414C20", Length = "0x65")]
	public static extern IntPtr new_RailUsersInfoData__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C0D")]
	[Address(RVA = "0x3DE1A0", Offset = "0x3DC9A0", Length = "0x87")]
	public static extern void RailUsersInfoData_user_info_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DE120", Offset = "0x3DC920", Length = "0x78")]
	[Token(Token = "0x6001C0E")]
	public static extern IntPtr RailUsersInfoData_user_info_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416490", Offset = "0x414C90", Length = "0x78")]
	[Token(Token = "0x6001C0F")]
	public static extern IntPtr new_RailUsersInfoData__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F70B0", Offset = "0x3F58B0", Length = "0x78")]
	[Token(Token = "0x6001C10")]
	public static extern void delete_RailUsersInfoData(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C11")]
	[Address(RVA = "0x4166F0", Offset = "0x414EF0", Length = "0x65")]
	public static extern IntPtr new_RailUsersNotifyInviter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C12")]
	[Address(RVA = "0x3DE870", Offset = "0x3DD070", Length = "0x87")]
	public static extern void RailUsersNotifyInviter_invitee_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C13")]
	[Address(RVA = "0x3DE7F0", Offset = "0x3DCFF0", Length = "0x78")]
	public static extern IntPtr RailUsersNotifyInviter_invitee_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416760", Offset = "0x414F60", Length = "0x78")]
	[Token(Token = "0x6001C14")]
	public static extern IntPtr new_RailUsersNotifyInviter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x3F7230", Offset = "0x3F5A30", Length = "0x78")]
	public static extern void delete_RailUsersNotifyInviter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x4167E0", Offset = "0x414FE0", Length = "0x65")]
	public static extern IntPtr new_RailUsersRespondInvitation__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DEA00", Offset = "0x3DD200", Length = "0x87")]
	[Token(Token = "0x6001C17")]
	public static extern void RailUsersRespondInvitation_inviter_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x3DE980", Offset = "0x3DD180", Length = "0x78")]
	public static extern IntPtr RailUsersRespondInvitation_inviter_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x3DEC20", Offset = "0x3DD420", Length = "0x85")]
	public static extern void RailUsersRespondInvitation_response_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DEBA0", Offset = "0x3DD3A0", Length = "0x78")]
	[Token(Token = "0x6001C1A")]
	public static extern int RailUsersRespondInvitation_response_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DEB10", Offset = "0x3DD310", Length = "0x87")]
	[Token(Token = "0x6001C1B")]
	public static extern void RailUsersRespondInvitation_original_invite_option_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C1C")]
	[Address(RVA = "0x3DEA90", Offset = "0x3DD290", Length = "0x78")]
	public static extern IntPtr RailUsersRespondInvitation_original_invite_option_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C1D")]
	[Address(RVA = "0x416850", Offset = "0x415050", Length = "0x78")]
	public static extern IntPtr new_RailUsersRespondInvitation__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C1E")]
	[Address(RVA = "0x3F72B0", Offset = "0x3F5AB0", Length = "0x78")]
	public static extern void delete_RailUsersRespondInvitation(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416510", Offset = "0x414D10", Length = "0x65")]
	[Token(Token = "0x6001C1F")]
	public static extern IntPtr new_RailUsersInviteJoinGameResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DE440", Offset = "0x3DCC40", Length = "0x87")]
	[Token(Token = "0x6001C20")]
	public static extern void RailUsersInviteJoinGameResult_invitee_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DE3C0", Offset = "0x3DCBC0", Length = "0x78")]
	[Token(Token = "0x6001C21")]
	public static extern IntPtr RailUsersInviteJoinGameResult_invitee_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C22")]
	[Address(RVA = "0x3DE550", Offset = "0x3DCD50", Length = "0x85")]
	public static extern void RailUsersInviteJoinGameResult_response_value_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C23")]
	[Address(RVA = "0x3DE4D0", Offset = "0x3DCCD0", Length = "0x78")]
	public static extern int RailUsersInviteJoinGameResult_response_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C24")]
	[Address(RVA = "0x3DE330", Offset = "0x3DCB30", Length = "0x85")]
	public static extern void RailUsersInviteJoinGameResult_invite_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C25")]
	[Address(RVA = "0x3DE2B0", Offset = "0x3DCAB0", Length = "0x78")]
	public static extern int RailUsersInviteJoinGameResult_invite_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C26")]
	[Address(RVA = "0x416580", Offset = "0x414D80", Length = "0x78")]
	public static extern IntPtr new_RailUsersInviteJoinGameResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C27")]
	[Address(RVA = "0x3F7130", Offset = "0x3F5930", Length = "0x78")]
	public static extern void delete_RailUsersInviteJoinGameResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416240", Offset = "0x414A40", Length = "0x65")]
	[Token(Token = "0x6001C28")]
	public static extern IntPtr new_RailUsersGetInviteDetailResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DDD70", Offset = "0x3DC570", Length = "0x87")]
	[Token(Token = "0x6001C29")]
	public static extern void RailUsersGetInviteDetailResult_inviter_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DDCF0", Offset = "0x3DC4F0", Length = "0x78")]
	[Token(Token = "0x6001C2A")]
	public static extern IntPtr RailUsersGetInviteDetailResult_inviter_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x3DDB40", Offset = "0x3DC340", Length = "0x9B")]
	public static extern void RailUsersGetInviteDetailResult_command_line_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DDAC0", Offset = "0x3DC2C0", Length = "0x78")]
	[Token(Token = "0x6001C2C")]
	public static extern IntPtr RailUsersGetInviteDetailResult_command_line_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DDC60", Offset = "0x3DC460", Length = "0x85")]
	[Token(Token = "0x6001C2D")]
	public static extern void RailUsersGetInviteDetailResult_invite_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DDBE0", Offset = "0x3DC3E0", Length = "0x78")]
	[Token(Token = "0x6001C2E")]
	public static extern int RailUsersGetInviteDetailResult_invite_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4162B0", Offset = "0x414AB0", Length = "0x78")]
	[Token(Token = "0x6001C2F")]
	public static extern IntPtr new_RailUsersGetInviteDetailResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6FB0", Offset = "0x3F57B0", Length = "0x78")]
	[Token(Token = "0x6001C30")]
	public static extern void delete_RailUsersGetInviteDetailResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416150", Offset = "0x414950", Length = "0x65")]
	[Token(Token = "0x6001C31")]
	public static extern IntPtr new_RailUsersCancelInviteResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DD9B0", Offset = "0x3DC1B0", Length = "0x85")]
	[Token(Token = "0x6001C32")]
	public static extern void RailUsersCancelInviteResult_invite_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C33")]
	[Address(RVA = "0x3DD930", Offset = "0x3DC130", Length = "0x78")]
	public static extern int RailUsersCancelInviteResult_invite_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4161C0", Offset = "0x4149C0", Length = "0x78")]
	[Token(Token = "0x6001C34")]
	public static extern IntPtr new_RailUsersCancelInviteResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6F30", Offset = "0x3F5730", Length = "0x78")]
	[Token(Token = "0x6001C35")]
	public static extern void delete_RailUsersCancelInviteResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C36")]
	[Address(RVA = "0x416600", Offset = "0x414E00", Length = "0x65")]
	public static extern IntPtr new_RailUsersInviteUsersResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DE6E0", Offset = "0x3DCEE0", Length = "0x85")]
	[Token(Token = "0x6001C37")]
	public static extern void RailUsersInviteUsersResult_invite_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DE660", Offset = "0x3DCE60", Length = "0x78")]
	[Token(Token = "0x6001C38")]
	public static extern int RailUsersInviteUsersResult_invite_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C39")]
	[Address(RVA = "0x416670", Offset = "0x414E70", Length = "0x78")]
	public static extern IntPtr new_RailUsersInviteUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C3A")]
	[Address(RVA = "0x3F71B0", Offset = "0x3F59B0", Length = "0x78")]
	public static extern void delete_RailUsersInviteUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416330", Offset = "0x414B30", Length = "0x65")]
	[Token(Token = "0x6001C3B")]
	public static extern IntPtr new_RailUsersGetUserLimitsResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DDF00", Offset = "0x3DC700", Length = "0x87")]
	[Token(Token = "0x6001C3C")]
	public static extern void RailUsersGetUserLimitsResult_user_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DDE80", Offset = "0x3DC680", Length = "0x78")]
	[Token(Token = "0x6001C3D")]
	public static extern IntPtr RailUsersGetUserLimitsResult_user_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DE010", Offset = "0x3DC810", Length = "0x87")]
	[Token(Token = "0x6001C3E")]
	public static extern void RailUsersGetUserLimitsResult_user_limits_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DDF90", Offset = "0x3DC790", Length = "0x78")]
	[Token(Token = "0x6001C3F")]
	public static extern IntPtr RailUsersGetUserLimitsResult_user_limits_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C40")]
	[Address(RVA = "0x4163A0", Offset = "0x414BA0", Length = "0x78")]
	public static extern IntPtr new_RailUsersGetUserLimitsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x3F7030", Offset = "0x3F5830", Length = "0x78")]
	public static extern void delete_RailUsersGetUserLimitsResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x4149C0", Offset = "0x4131C0", Length = "0x65")]
	public static extern IntPtr new_RailShowChatWindowWithFriendResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D8020", Offset = "0x3D6820", Length = "0x86")]
	[Token(Token = "0x6001C43")]
	public static extern void RailShowChatWindowWithFriendResult_is_show_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D7FA0", Offset = "0x3D67A0", Length = "0x7D")]
	[Token(Token = "0x6001C44")]
	public static extern bool RailShowChatWindowWithFriendResult_is_show_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x414A30", Offset = "0x413230", Length = "0x78")]
	public static extern IntPtr new_RailShowChatWindowWithFriendResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x3F62B0", Offset = "0x3F4AB0", Length = "0x78")]
	public static extern void delete_RailShowChatWindowWithFriendResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x414AB0", Offset = "0x4132B0", Length = "0x65")]
	public static extern IntPtr new_RailShowUserHomepageWindowResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x3D81B0", Offset = "0x3D69B0", Length = "0x86")]
	public static extern void RailShowUserHomepageWindowResult_is_show_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D8130", Offset = "0x3D6930", Length = "0x7D")]
	[Token(Token = "0x6001C49")]
	public static extern bool RailShowUserHomepageWindowResult_is_show_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x414B20", Offset = "0x413320", Length = "0x78")]
	public static extern IntPtr new_RailShowUserHomepageWindowResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6330", Offset = "0x3F4B30", Length = "0x78")]
	[Token(Token = "0x6001C4B")]
	public static extern void delete_RailShowUserHomepageWindowResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412F90", Offset = "0x411790", Length = "0x65")]
	[Token(Token = "0x6001C4C")]
	public static extern IntPtr new_RailImageDataDescriptor__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x3D2620", Offset = "0x3D0E20", Length = "0x85")]
	public static extern void RailImageDataDescriptor_image_width_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x3D25A0", Offset = "0x3D0DA0", Length = "0x78")]
	public static extern uint RailImageDataDescriptor_image_width_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x3D2510", Offset = "0x3D0D10", Length = "0x85")]
	public static extern void RailImageDataDescriptor_image_height_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C50")]
	[Address(RVA = "0x3D2490", Offset = "0x3D0C90", Length = "0x78")]
	public static extern uint RailImageDataDescriptor_image_height_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C51")]
	[Address(RVA = "0x3D2840", Offset = "0x3D1040", Length = "0x85")]
	public static extern void RailImageDataDescriptor_stride_in_bytes_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x3D27C0", Offset = "0x3D0FC0", Length = "0x78")]
	public static extern uint RailImageDataDescriptor_stride_in_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D2400", Offset = "0x3D0C00", Length = "0x85")]
	[Token(Token = "0x6001C53")]
	public static extern void RailImageDataDescriptor_bits_per_pixel_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D2380", Offset = "0x3D0B80", Length = "0x78")]
	[Token(Token = "0x6001C54")]
	public static extern uint RailImageDataDescriptor_bits_per_pixel_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D2730", Offset = "0x3D0F30", Length = "0x85")]
	[Token(Token = "0x6001C55")]
	public static extern void RailImageDataDescriptor_pixel_format_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C56")]
	[Address(RVA = "0x3D26B0", Offset = "0x3D0EB0", Length = "0x78")]
	public static extern int RailImageDataDescriptor_pixel_format_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x413000", Offset = "0x411800", Length = "0x78")]
	public static extern IntPtr new_RailImageDataDescriptor__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x3F5430", Offset = "0x3F3C30", Length = "0x78")]
	public static extern void delete_RailImageDataDescriptor(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x406060", Offset = "0x404860", Length = "0x65")]
	public static extern IntPtr new_RailDirtyWordsCheckResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3BC170", Offset = "0x3BA970", Length = "0x9B")]
	[Token(Token = "0x6001C5A")]
	public static extern void RailDirtyWordsCheckResult_replace_string_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x3BC0F0", Offset = "0x3BA8F0", Length = "0x78")]
	public static extern IntPtr RailDirtyWordsCheckResult_replace_string_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x3BC060", Offset = "0x3BA860", Length = "0x85")]
	public static extern void RailDirtyWordsCheckResult_dirty_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C5D")]
	[Address(RVA = "0x3BBFE0", Offset = "0x3BA7E0", Length = "0x78")]
	public static extern int RailDirtyWordsCheckResult_dirty_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C5E")]
	[Address(RVA = "0x4060D0", Offset = "0x4048D0", Length = "0x78")]
	public static extern IntPtr new_RailDirtyWordsCheckResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C5F")]
	[Address(RVA = "0x3EE5B0", Offset = "0x3ECDB0", Length = "0x78")]
	public static extern void delete_RailDirtyWordsCheckResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BBC10", Offset = "0x3BA410", Length = "0x85")]
	[Token(Token = "0x6001C60")]
	public static extern void RailCrashInfo_exception_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BBB90", Offset = "0x3BA390", Length = "0x78")]
	[Token(Token = "0x6001C61")]
	public static extern int RailCrashInfo_exception_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405E80", Offset = "0x404680", Length = "0x65")]
	[Token(Token = "0x6001C62")]
	public static extern IntPtr new_RailCrashInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x405EF0", Offset = "0x4046F0", Length = "0x78")]
	public static extern IntPtr new_RailCrashInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EE4B0", Offset = "0x3ECCB0", Length = "0x78")]
	[Token(Token = "0x6001C64")]
	public static extern void delete_RailCrashInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x3BB920", Offset = "0x3BA120", Length = "0x78")]
	public static extern IntPtr RailCrashBuffer_GetData(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BB8A0", Offset = "0x3BA0A0", Length = "0x78")]
	[Token(Token = "0x6001C66")]
	public static extern uint RailCrashBuffer_GetBufferLength(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BB9A0", Offset = "0x3BA1A0", Length = "0x78")]
	[Token(Token = "0x6001C67")]
	public static extern uint RailCrashBuffer_GetValidLength(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BBA20", Offset = "0x3BA220", Length = "0xBB")]
	[Token(Token = "0x6001C68")]
	public static extern uint RailCrashBuffer_SetData__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Address(RVA = "0x3BBAE0", Offset = "0x3BA2E0", Length = "0xAC")]
	[Token(Token = "0x6001C69")]
	public static extern uint RailCrashBuffer_SetData__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3BB7F0", Offset = "0x3B9FF0", Length = "0xAC")]
	[Token(Token = "0x6001C6A")]
	public static extern uint RailCrashBuffer_AppendData(IntPtr jarg1, string jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x6001C6B")]
	[Address(RVA = "0x3EE430", Offset = "0x3ECC30", Length = "0x78")]
	public static extern void delete_RailCrashBuffer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C6C")]
	[Address(RVA = "0x412900", Offset = "0x411100", Length = "0x65")]
	public static extern IntPtr new_RailGetImageDataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C6D")]
	[Address(RVA = "0x3D1570", Offset = "0x3CFD70", Length = "0x87")]
	public static extern void RailGetImageDataResult_image_data_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C6E")]
	[Address(RVA = "0x3D14F0", Offset = "0x3CFCF0", Length = "0x78")]
	public static extern IntPtr RailGetImageDataResult_image_data_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C6F")]
	[Address(RVA = "0x3D1460", Offset = "0x3CFC60", Length = "0x87")]
	public static extern void RailGetImageDataResult_image_data_descriptor_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C70")]
	[Address(RVA = "0x3D13E0", Offset = "0x3CFBE0", Length = "0x78")]
	public static extern IntPtr RailGetImageDataResult_image_data_descriptor_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C71")]
	[Address(RVA = "0x412970", Offset = "0x411170", Length = "0x78")]
	public static extern IntPtr new_RailGetImageDataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C72")]
	[Address(RVA = "0x3F50B0", Offset = "0x3F38B0", Length = "0x78")]
	public static extern void delete_RailGetImageDataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C73")]
	[Address(RVA = "0x412540", Offset = "0x410D40", Length = "0x65")]
	public static extern IntPtr new_RailGameSettingMetadataChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x3D0AB0", Offset = "0x3CF2B0", Length = "0x85")]
	public static extern void RailGameSettingMetadataChanged_source_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C75")]
	[Address(RVA = "0x3D0A30", Offset = "0x3CF230", Length = "0x78")]
	public static extern int RailGameSettingMetadataChanged_source_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C76")]
	[Address(RVA = "0x3D09A0", Offset = "0x3CF1A0", Length = "0x87")]
	public static extern void RailGameSettingMetadataChanged_key_values_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x3D0920", Offset = "0x3CF120", Length = "0x78")]
	public static extern IntPtr RailGameSettingMetadataChanged_key_values_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x4125B0", Offset = "0x410DB0", Length = "0x78")]
	public static extern IntPtr new_RailGameSettingMetadataChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4EB0", Offset = "0x3F36B0", Length = "0x78")]
	[Token(Token = "0x6001C79")]
	public static extern void delete_RailGameSettingMetadataChanged(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418930", Offset = "0x417130", Length = "0x65")]
	[Token(Token = "0x6001C7A")]
	public static extern IntPtr new_TakeScreenshotResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E4F90", Offset = "0x3E3790", Length = "0x9B")]
	[Token(Token = "0x6001C7B")]
	public static extern void TakeScreenshotResult_image_file_path_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x3E4F10", Offset = "0x3E3710", Length = "0x78")]
	public static extern IntPtr TakeScreenshotResult_image_file_path_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x3E50B0", Offset = "0x3E38B0", Length = "0x85")]
	public static extern void TakeScreenshotResult_image_file_size_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x3E5030", Offset = "0x3E3830", Length = "0x78")]
	public static extern uint TakeScreenshotResult_image_file_size_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x3E52D0", Offset = "0x3E3AD0", Length = "0x9B")]
	public static extern void TakeScreenshotResult_thumbnail_filepath_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x3E5250", Offset = "0x3E3A50", Length = "0x78")]
	public static extern IntPtr TakeScreenshotResult_thumbnail_filepath_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x3E51C0", Offset = "0x3E39C0", Length = "0x85")]
	public static extern void TakeScreenshotResult_thumbnail_file_size_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x3E5140", Offset = "0x3E3940", Length = "0x78")]
	public static extern uint TakeScreenshotResult_thumbnail_file_size_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x4189A0", Offset = "0x4171A0", Length = "0x78")]
	public static extern IntPtr new_TakeScreenshotResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8430", Offset = "0x3F6C30", Length = "0x78")]
	[Token(Token = "0x6001C84")]
	public static extern void delete_TakeScreenshotResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4178C0", Offset = "0x4160C0", Length = "0x65")]
	[Token(Token = "0x6001C85")]
	public static extern IntPtr new_ScreenshotRequestInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x417930", Offset = "0x416130", Length = "0x78")]
	[Token(Token = "0x6001C86")]
	public static extern IntPtr new_ScreenshotRequestInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x3F7BB0", Offset = "0x3F63B0", Length = "0x78")]
	public static extern void delete_ScreenshotRequestInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF050", Offset = "0x3FD850", Length = "0x65")]
	[Token(Token = "0x6001C88")]
	public static extern IntPtr new_PublishScreenshotResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3AA1A0", Offset = "0x3A89A0", Length = "0x87")]
	[Token(Token = "0x6001C89")]
	public static extern void PublishScreenshotResult_work_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AA120", Offset = "0x3A8920", Length = "0x78")]
	[Token(Token = "0x6001C8A")]
	public static extern IntPtr PublishScreenshotResult_work_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF0C0", Offset = "0x3FD8C0", Length = "0x78")]
	[Token(Token = "0x6001C8B")]
	public static extern IntPtr new_PublishScreenshotResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x3EC5B0", Offset = "0x3EADB0", Length = "0x78")]
	public static extern void delete_PublishScreenshotResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415AC0", Offset = "0x4142C0", Length = "0x65")]
	[Token(Token = "0x6001C8D")]
	public static extern IntPtr new_RailSystemStateChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x3DBBA0", Offset = "0x3DA3A0", Length = "0x85")]
	public static extern void RailSystemStateChanged_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DBB20", Offset = "0x3DA320", Length = "0x78")]
	[Token(Token = "0x6001C8F")]
	public static extern int RailSystemStateChanged_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415B30", Offset = "0x414330", Length = "0x78")]
	[Token(Token = "0x6001C90")]
	public static extern IntPtr new_RailSystemStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6BB0", Offset = "0x3F53B0", Length = "0x78")]
	[Token(Token = "0x6001C91")]
	public static extern void delete_RailSystemStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413F00", Offset = "0x412700", Length = "0x65")]
	[Token(Token = "0x6001C92")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByGameServer__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D52C0", Offset = "0x3D3AC0", Length = "0x87")]
	[Token(Token = "0x6001C93")]
	public static extern void RailPlatformNotifyEventJoinGameByGameServer_gameserver_railid_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D5240", Offset = "0x3D3A40", Length = "0x78")]
	[Token(Token = "0x6001C94")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByGameServer_gameserver_railid_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x3D51A0", Offset = "0x3D39A0", Length = "0x9B")]
	public static extern void RailPlatformNotifyEventJoinGameByGameServer_commandline_info_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D5120", Offset = "0x3D3920", Length = "0x78")]
	[Token(Token = "0x6001C96")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByGameServer_commandline_info_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413F70", Offset = "0x412770", Length = "0x78")]
	[Token(Token = "0x6001C97")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByGameServer__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x3F5CB0", Offset = "0x3F44B0", Length = "0x78")]
	public static extern void delete_RailPlatformNotifyEventJoinGameByGameServer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x413FF0", Offset = "0x4127F0", Length = "0x65")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByRoom__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D5570", Offset = "0x3D3D70", Length = "0x87")]
	[Token(Token = "0x6001C9A")]
	public static extern void RailPlatformNotifyEventJoinGameByRoom_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001C9B")]
	[Address(RVA = "0x3D54F0", Offset = "0x3D3CF0", Length = "0x78")]
	public static extern ulong RailPlatformNotifyEventJoinGameByRoom_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C9C")]
	[Address(RVA = "0x3D5450", Offset = "0x3D3C50", Length = "0x9B")]
	public static extern void RailPlatformNotifyEventJoinGameByRoom_commandline_info_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D53D0", Offset = "0x3D3BD0", Length = "0x78")]
	[Token(Token = "0x6001C9D")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByRoom_commandline_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C9E")]
	[Address(RVA = "0x414060", Offset = "0x412860", Length = "0x78")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByRoom__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001C9F")]
	[Address(RVA = "0x3F5D30", Offset = "0x3F4530", Length = "0x78")]
	public static extern void delete_RailPlatformNotifyEventJoinGameByRoom(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4140E0", Offset = "0x4128E0", Length = "0x65")]
	[Token(Token = "0x6001CA0")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByUser__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D5820", Offset = "0x3D4020", Length = "0x87")]
	[Token(Token = "0x6001CA1")]
	public static extern void RailPlatformNotifyEventJoinGameByUser_rail_id_to_join_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CA2")]
	[Address(RVA = "0x3D57A0", Offset = "0x3D3FA0", Length = "0x78")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByUser_rail_id_to_join_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CA3")]
	[Address(RVA = "0x3D5700", Offset = "0x3D3F00", Length = "0x9B")]
	public static extern void RailPlatformNotifyEventJoinGameByUser_commandline_info_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CA4")]
	[Address(RVA = "0x3D5680", Offset = "0x3D3E80", Length = "0x78")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByUser_commandline_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CA5")]
	[Address(RVA = "0x414150", Offset = "0x412950", Length = "0x78")]
	public static extern IntPtr new_RailPlatformNotifyEventJoinGameByUser__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5DB0", Offset = "0x3F45B0", Length = "0x78")]
	[Token(Token = "0x6001CA6")]
	public static extern void delete_RailPlatformNotifyEventJoinGameByUser(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4110A0", Offset = "0x40F8A0", Length = "0x65")]
	[Token(Token = "0x6001CA7")]
	public static extern IntPtr new_RailFinalize__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CA8")]
	[Address(RVA = "0x411110", Offset = "0x40F910", Length = "0x78")]
	public static extern IntPtr new_RailFinalize__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F43B0", Offset = "0x3F2BB0", Length = "0x78")]
	[Token(Token = "0x6001CA9")]
	public static extern void delete_RailFinalize(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4058E0", Offset = "0x4040E0", Length = "0x65")]
	[Token(Token = "0x6001CAA")]
	public static extern IntPtr new_RailAssetItem__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CAB")]
	[Address(RVA = "0x3BA560", Offset = "0x3B8D60", Length = "0x87")]
	public static extern void RailAssetItem_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x3BA4E0", Offset = "0x3B8CE0", Length = "0x78")]
	public static extern ulong RailAssetItem_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x3BA670", Offset = "0x3B8E70", Length = "0x85")]
	public static extern void RailAssetItem_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BA5F0", Offset = "0x3B8DF0", Length = "0x78")]
	[Token(Token = "0x6001CAE")]
	public static extern uint RailAssetItem_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405950", Offset = "0x404150", Length = "0x78")]
	[Token(Token = "0x6001CAF")]
	public static extern IntPtr new_RailAssetItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x3EE130", Offset = "0x3EC930", Length = "0x78")]
	public static extern void delete_RailAssetItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x412630", Offset = "0x410E30", Length = "0x65")]
	public static extern IntPtr new_RailGeneratedAssetItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D0DE0", Offset = "0x3CF5E0", Length = "0x85")]
	[Token(Token = "0x6001CB2")]
	public static extern void RailGeneratedAssetItem_product_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0D60", Offset = "0x3CF560", Length = "0x78")]
	[Token(Token = "0x6001CB3")]
	public static extern uint RailGeneratedAssetItem_product_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D0BC0", Offset = "0x3CF3C0", Length = "0x87")]
	[Token(Token = "0x6001CB4")]
	public static extern void RailGeneratedAssetItem_asset_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0B40", Offset = "0x3CF340", Length = "0x78")]
	[Token(Token = "0x6001CB5")]
	public static extern IntPtr RailGeneratedAssetItem_asset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x3D0CD0", Offset = "0x3CF4D0", Length = "0x87")]
	public static extern void RailGeneratedAssetItem_container_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0C50", Offset = "0x3CF450", Length = "0x78")]
	[Token(Token = "0x6001CB7")]
	public static extern ulong RailGeneratedAssetItem_container_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4126A0", Offset = "0x410EA0", Length = "0x78")]
	[Token(Token = "0x6001CB8")]
	public static extern IntPtr new_RailGeneratedAssetItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x3F4F30", Offset = "0x3F3730", Length = "0x78")]
	public static extern void delete_RailGeneratedAssetItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x4057F0", Offset = "0x403FF0", Length = "0x65")]
	public static extern IntPtr new_RailAssetInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3B9990", Offset = "0x3B8190", Length = "0x87")]
	[Token(Token = "0x6001CBB")]
	public static extern void RailAssetInfo_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x3B9910", Offset = "0x3B8110", Length = "0x78")]
	public static extern ulong RailAssetInfo_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x3B9FF0", Offset = "0x3B87F0", Length = "0x85")]
	public static extern void RailAssetInfo_product_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9F70", Offset = "0x3B8770", Length = "0x78")]
	[Token(Token = "0x6001CBE")]
	public static extern uint RailAssetInfo_product_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BA100", Offset = "0x3B8900", Length = "0x9B")]
	[Token(Token = "0x6001CBF")]
	public static extern void RailAssetInfo_product_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x3BA080", Offset = "0x3B8880", Length = "0x78")]
	public static extern IntPtr RailAssetInfo_product_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B9EE0", Offset = "0x3B86E0", Length = "0x85")]
	[Token(Token = "0x6001CC1")]
	public static extern void RailAssetInfo_position_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x3B9E60", Offset = "0x3B8660", Length = "0x78")]
	public static extern int RailAssetInfo_position_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BA220", Offset = "0x3B8A20", Length = "0x9B")]
	[Token(Token = "0x6001CC3")]
	public static extern void RailAssetInfo_progress_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CC4")]
	[Address(RVA = "0x3BA1A0", Offset = "0x3B89A0", Length = "0x78")]
	public static extern IntPtr RailAssetInfo_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CC5")]
	[Address(RVA = "0x3BA340", Offset = "0x3B8B40", Length = "0x85")]
	public static extern void RailAssetInfo_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CC6")]
	[Address(RVA = "0x3BA2C0", Offset = "0x3B8AC0", Length = "0x78")]
	public static extern uint RailAssetInfo_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BA450", Offset = "0x3B8C50", Length = "0x85")]
	[Token(Token = "0x6001CC7")]
	public static extern void RailAssetInfo_state_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BA3D0", Offset = "0x3B8BD0", Length = "0x78")]
	[Token(Token = "0x6001CC8")]
	public static extern uint RailAssetInfo_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CC9")]
	[Address(RVA = "0x3B9CC0", Offset = "0x3B84C0", Length = "0x85")]
	public static extern void RailAssetInfo_flag_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CCA")]
	[Address(RVA = "0x3B9C40", Offset = "0x3B8440", Length = "0x78")]
	public static extern uint RailAssetInfo_flag_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B9DD0", Offset = "0x3B85D0", Length = "0x85")]
	[Token(Token = "0x6001CCB")]
	public static extern void RailAssetInfo_origin_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9D50", Offset = "0x3B8550", Length = "0x78")]
	[Token(Token = "0x6001CCC")]
	public static extern uint RailAssetInfo_origin_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3B9BB0", Offset = "0x3B83B0", Length = "0x85")]
	[Token(Token = "0x6001CCD")]
	public static extern void RailAssetInfo_expire_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CCE")]
	[Address(RVA = "0x3B9B30", Offset = "0x3B8330", Length = "0x78")]
	public static extern uint RailAssetInfo_expire_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CCF")]
	[Address(RVA = "0x3B9AA0", Offset = "0x3B82A0", Length = "0x87")]
	public static extern void RailAssetInfo_container_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3B9A20", Offset = "0x3B8220", Length = "0x78")]
	[Token(Token = "0x6001CD0")]
	public static extern ulong RailAssetInfo_container_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CD1")]
	[Address(RVA = "0x405860", Offset = "0x404060", Length = "0x78")]
	public static extern IntPtr new_RailAssetInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EE0B0", Offset = "0x3EC8B0", Length = "0x78")]
	[Token(Token = "0x6001CD2")]
	public static extern void delete_RailAssetInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CD3")]
	[Address(RVA = "0x4143B0", Offset = "0x412BB0", Length = "0x65")]
	public static extern IntPtr new_RailProductItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D5D70", Offset = "0x3D4570", Length = "0x85")]
	[Token(Token = "0x6001CD4")]
	public static extern void RailProductItem_product_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D5CF0", Offset = "0x3D44F0", Length = "0x78")]
	[Token(Token = "0x6001CD5")]
	public static extern uint RailProductItem_product_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D5E80", Offset = "0x3D4680", Length = "0x85")]
	[Token(Token = "0x6001CD6")]
	public static extern void RailProductItem_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D5E00", Offset = "0x3D4600", Length = "0x78")]
	[Token(Token = "0x6001CD7")]
	public static extern uint RailProductItem_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414420", Offset = "0x412C20", Length = "0x78")]
	[Token(Token = "0x6001CD8")]
	public static extern IntPtr new_RailProductItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5F30", Offset = "0x3F4730", Length = "0x78")]
	[Token(Token = "0x6001CD9")]
	public static extern void delete_RailProductItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CDA")]
	[Address(RVA = "0x4059D0", Offset = "0x4041D0", Length = "0x65")]
	public static extern IntPtr new_RailAssetProperty__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CDB")]
	[Address(RVA = "0x3BA780", Offset = "0x3B8F80", Length = "0x87")]
	public static extern void RailAssetProperty_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BA700", Offset = "0x3B8F00", Length = "0x78")]
	[Token(Token = "0x6001CDC")]
	public static extern ulong RailAssetProperty_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BA890", Offset = "0x3B9090", Length = "0x85")]
	[Token(Token = "0x6001CDD")]
	public static extern void RailAssetProperty_position_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BA810", Offset = "0x3B9010", Length = "0x78")]
	[Token(Token = "0x6001CDE")]
	public static extern uint RailAssetProperty_position_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CDF")]
	[Address(RVA = "0x405A40", Offset = "0x404240", Length = "0x78")]
	public static extern IntPtr new_RailAssetProperty__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CE0")]
	[Address(RVA = "0x3EE1B0", Offset = "0x3EC9B0", Length = "0x78")]
	public static extern void delete_RailAssetProperty(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CE1")]
	[Address(RVA = "0x417050", Offset = "0x415850", Length = "0x65")]
	public static extern IntPtr new_RequestAllAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CE2")]
	[Address(RVA = "0x3DFE10", Offset = "0x3DE610", Length = "0x87")]
	public static extern void RequestAllAssetsFinished_assetinfo_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DFD90", Offset = "0x3DE590", Length = "0x78")]
	[Token(Token = "0x6001CE3")]
	public static extern IntPtr RequestAllAssetsFinished_assetinfo_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4170C0", Offset = "0x4158C0", Length = "0x78")]
	[Token(Token = "0x6001CE4")]
	public static extern IntPtr new_RequestAllAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CE5")]
	[Address(RVA = "0x3F7730", Offset = "0x3F5F30", Length = "0x78")]
	public static extern void delete_RequestAllAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x418A20", Offset = "0x417220", Length = "0x65")]
	public static extern IntPtr new_UpdateAssetsPropertyFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x3E54E0", Offset = "0x3E3CE0", Length = "0x87")]
	public static extern void UpdateAssetsPropertyFinished_asset_property_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x3E5460", Offset = "0x3E3C60", Length = "0x78")]
	public static extern IntPtr UpdateAssetsPropertyFinished_asset_property_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418A90", Offset = "0x417290", Length = "0x78")]
	[Token(Token = "0x6001CE9")]
	public static extern IntPtr new_UpdateAssetsPropertyFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x3F84B0", Offset = "0x3F6CB0", Length = "0x78")]
	public static extern void delete_UpdateAssetsPropertyFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CEB")]
	[Address(RVA = "0x3FB630", Offset = "0x3F9E30", Length = "0x65")]
	public static extern IntPtr new_DirectConsumeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x386DC0", Offset = "0x3855C0", Length = "0x87")]
	[Token(Token = "0x6001CEC")]
	public static extern void DirectConsumeAssetsFinished_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x386D40", Offset = "0x385540", Length = "0x78")]
	[Token(Token = "0x6001CED")]
	public static extern IntPtr DirectConsumeAssetsFinished_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x3FB6A0", Offset = "0x3F9EA0", Length = "0x78")]
	public static extern IntPtr new_DirectConsumeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x3E8C30", Offset = "0x3E7430", Length = "0x78")]
	public static extern void delete_DirectConsumeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418660", Offset = "0x416E60", Length = "0x65")]
	[Token(Token = "0x6001CF0")]
	public static extern IntPtr new_StartConsumeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CF1")]
	[Address(RVA = "0x3E4AE0", Offset = "0x3E32E0", Length = "0x87")]
	public static extern void StartConsumeAssetsFinished_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001CF2")]
	[Address(RVA = "0x3E4A60", Offset = "0x3E3260", Length = "0x78")]
	public static extern ulong StartConsumeAssetsFinished_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CF3")]
	[Address(RVA = "0x4186D0", Offset = "0x416ED0", Length = "0x78")]
	public static extern IntPtr new_StartConsumeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F82B0", Offset = "0x3F6AB0", Length = "0x78")]
	[Token(Token = "0x6001CF4")]
	public static extern void delete_StartConsumeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CF5")]
	[Address(RVA = "0x418B10", Offset = "0x417310", Length = "0x65")]
	public static extern IntPtr new_UpdateConsumeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CF6")]
	[Address(RVA = "0x3E5670", Offset = "0x3E3E70", Length = "0x87")]
	public static extern void UpdateConsumeAssetsFinished_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E55F0", Offset = "0x3E3DF0", Length = "0x78")]
	[Token(Token = "0x6001CF7")]
	public static extern ulong UpdateConsumeAssetsFinished_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418B80", Offset = "0x417380", Length = "0x78")]
	[Token(Token = "0x6001CF8")]
	public static extern IntPtr new_UpdateConsumeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CF9")]
	[Address(RVA = "0x3F8530", Offset = "0x3F6D30", Length = "0x78")]
	public static extern void delete_UpdateConsumeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x3FAAF0", Offset = "0x3F92F0", Length = "0x65")]
	public static extern IntPtr new_CompleteConsumeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x385050", Offset = "0x383850", Length = "0x87")]
	public static extern void CompleteConsumeAssetsFinished_asset_item_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x384FD0", Offset = "0x3837D0", Length = "0x78")]
	[Token(Token = "0x6001CFC")]
	public static extern IntPtr CompleteConsumeAssetsFinished_asset_item_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FAB60", Offset = "0x3F9360", Length = "0x78")]
	[Token(Token = "0x6001CFD")]
	public static extern IntPtr new_CompleteConsumeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CFE")]
	[Address(RVA = "0x3E8630", Offset = "0x3E6E30", Length = "0x78")]
	public static extern void delete_CompleteConsumeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001CFF")]
	[Address(RVA = "0x418480", Offset = "0x416C80", Length = "0x65")]
	public static extern IntPtr new_SplitAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D00")]
	[Address(RVA = "0x3E4490", Offset = "0x3E2C90", Length = "0x87")]
	public static extern void SplitAssetsFinished_source_asset_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D01")]
	[Address(RVA = "0x3E4410", Offset = "0x3E2C10", Length = "0x78")]
	public static extern ulong SplitAssetsFinished_source_asset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D02")]
	[Address(RVA = "0x3E45A0", Offset = "0x3E2DA0", Length = "0x85")]
	public static extern void SplitAssetsFinished_to_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D03")]
	[Address(RVA = "0x3E4520", Offset = "0x3E2D20", Length = "0x78")]
	public static extern uint SplitAssetsFinished_to_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D04")]
	[Address(RVA = "0x3E4380", Offset = "0x3E2B80", Length = "0x87")]
	public static extern void SplitAssetsFinished_new_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E4300", Offset = "0x3E2B00", Length = "0x78")]
	[Token(Token = "0x6001D05")]
	public static extern ulong SplitAssetsFinished_new_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4184F0", Offset = "0x416CF0", Length = "0x78")]
	[Token(Token = "0x6001D06")]
	public static extern IntPtr new_SplitAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F81B0", Offset = "0x3F69B0", Length = "0x78")]
	[Token(Token = "0x6001D07")]
	public static extern void delete_SplitAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418570", Offset = "0x416D70", Length = "0x65")]
	[Token(Token = "0x6001D08")]
	public static extern IntPtr new_SplitAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E4730", Offset = "0x3E2F30", Length = "0x87")]
	[Token(Token = "0x6001D09")]
	public static extern void SplitAssetsToFinished_source_asset_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E46B0", Offset = "0x3E2EB0", Length = "0x78")]
	[Token(Token = "0x6001D0A")]
	public static extern ulong SplitAssetsToFinished_source_asset_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E4950", Offset = "0x3E3150", Length = "0x85")]
	[Token(Token = "0x6001D0B")]
	public static extern void SplitAssetsToFinished_to_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x3E48D0", Offset = "0x3E30D0", Length = "0x78")]
	public static extern uint SplitAssetsToFinished_to_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D0D")]
	[Address(RVA = "0x3E4840", Offset = "0x3E3040", Length = "0x87")]
	public static extern void SplitAssetsToFinished_split_to_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E47C0", Offset = "0x3E2FC0", Length = "0x78")]
	[Token(Token = "0x6001D0E")]
	public static extern ulong SplitAssetsToFinished_split_to_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D0F")]
	[Address(RVA = "0x4185E0", Offset = "0x416DE0", Length = "0x78")]
	public static extern IntPtr new_SplitAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8230", Offset = "0x3F6A30", Length = "0x78")]
	[Token(Token = "0x6001D10")]
	public static extern void delete_SplitAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D11")]
	[Address(RVA = "0x3FDF70", Offset = "0x3FC770", Length = "0x65")]
	public static extern IntPtr new_MergeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D12")]
	[Address(RVA = "0x3A6E80", Offset = "0x3A5680", Length = "0x87")]
	public static extern void MergeAssetsFinished_source_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D13")]
	[Address(RVA = "0x3A6E00", Offset = "0x3A5600", Length = "0x78")]
	public static extern IntPtr MergeAssetsFinished_source_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D14")]
	[Address(RVA = "0x3A6D70", Offset = "0x3A5570", Length = "0x87")]
	public static extern void MergeAssetsFinished_new_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A6CF0", Offset = "0x3A54F0", Length = "0x78")]
	[Token(Token = "0x6001D15")]
	public static extern ulong MergeAssetsFinished_new_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FDFE0", Offset = "0x3FC7E0", Length = "0x78")]
	[Token(Token = "0x6001D16")]
	public static extern IntPtr new_MergeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBCB0", Offset = "0x3EA4B0", Length = "0x78")]
	[Token(Token = "0x6001D17")]
	public static extern void delete_MergeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE060", Offset = "0x3FC860", Length = "0x65")]
	[Token(Token = "0x6001D18")]
	public static extern IntPtr new_MergeAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A7120", Offset = "0x3A5920", Length = "0x87")]
	[Token(Token = "0x6001D19")]
	public static extern void MergeAssetsToFinished_source_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A70A0", Offset = "0x3A58A0", Length = "0x78")]
	[Token(Token = "0x6001D1A")]
	public static extern IntPtr MergeAssetsToFinished_source_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A7010", Offset = "0x3A5810", Length = "0x87")]
	[Token(Token = "0x6001D1B")]
	public static extern void MergeAssetsToFinished_merge_to_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A6F90", Offset = "0x3A5790", Length = "0x78")]
	[Token(Token = "0x6001D1C")]
	public static extern ulong MergeAssetsToFinished_merge_to_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D1D")]
	[Address(RVA = "0x3FE0D0", Offset = "0x3FC8D0", Length = "0x78")]
	public static extern IntPtr new_MergeAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBD30", Offset = "0x3EA530", Length = "0x78")]
	[Token(Token = "0x6001D1E")]
	public static extern void delete_MergeAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FABE0", Offset = "0x3F93E0", Length = "0x65")]
	[Token(Token = "0x6001D1F")]
	public static extern IntPtr new_CompleteConsumeByExchangeAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FAC50", Offset = "0x3F9450", Length = "0x78")]
	[Token(Token = "0x6001D20")]
	public static extern IntPtr new_CompleteConsumeByExchangeAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D21")]
	[Address(RVA = "0x3E86B0", Offset = "0x3E6EB0", Length = "0x78")]
	public static extern void delete_CompleteConsumeByExchangeAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D22")]
	[Address(RVA = "0x3FBDB0", Offset = "0x3FA5B0", Length = "0x65")]
	public static extern IntPtr new_ExchangeAssetsFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x388680", Offset = "0x386E80", Length = "0x87")]
	[Token(Token = "0x6001D23")]
	public static extern void ExchangeAssetsFinished_old_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x388600", Offset = "0x386E00", Length = "0x78")]
	[Token(Token = "0x6001D24")]
	public static extern IntPtr ExchangeAssetsFinished_old_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D25")]
	[Address(RVA = "0x388570", Offset = "0x386D70", Length = "0x87")]
	public static extern void ExchangeAssetsFinished_new_asset_item_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x3884F0", Offset = "0x386CF0", Length = "0x78")]
	public static extern IntPtr ExchangeAssetsFinished_new_asset_item_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FBE20", Offset = "0x3FA620", Length = "0x78")]
	[Token(Token = "0x6001D27")]
	public static extern IntPtr new_ExchangeAssetsFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x3E90B0", Offset = "0x3E78B0", Length = "0x78")]
	public static extern void delete_ExchangeAssetsFinished(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D29")]
	[Address(RVA = "0x3FBEA0", Offset = "0x3FA6A0", Length = "0x65")]
	public static extern IntPtr new_ExchangeAssetsToFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x388920", Offset = "0x387120", Length = "0x87")]
	public static extern void ExchangeAssetsToFinished_old_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x3888A0", Offset = "0x3870A0", Length = "0x78")]
	public static extern IntPtr ExchangeAssetsToFinished_old_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x388A30", Offset = "0x387230", Length = "0x87")]
	[Token(Token = "0x6001D2C")]
	public static extern void ExchangeAssetsToFinished_to_product_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3889B0", Offset = "0x3871B0", Length = "0x78")]
	[Token(Token = "0x6001D2D")]
	public static extern IntPtr ExchangeAssetsToFinished_to_product_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D2E")]
	[Address(RVA = "0x388810", Offset = "0x387010", Length = "0x87")]
	public static extern void ExchangeAssetsToFinished_exchange_to_asset_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x388790", Offset = "0x386F90", Length = "0x78")]
	[Token(Token = "0x6001D2F")]
	public static extern ulong ExchangeAssetsToFinished_exchange_to_asset_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D30")]
	[Address(RVA = "0x3FBF10", Offset = "0x3FA710", Length = "0x78")]
	public static extern IntPtr new_ExchangeAssetsToFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D31")]
	[Address(RVA = "0x3E9130", Offset = "0x3E7930", Length = "0x78")]
	public static extern void delete_ExchangeAssetsToFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405AC0", Offset = "0x4042C0", Length = "0x65")]
	[Token(Token = "0x6001D32")]
	public static extern IntPtr new_RailAssetsChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D33")]
	[Address(RVA = "0x405B30", Offset = "0x404330", Length = "0x78")]
	public static extern IntPtr new_RailAssetsChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D34")]
	[Address(RVA = "0x3EE230", Offset = "0x3ECA30", Length = "0x78")]
	public static extern void delete_RailAssetsChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D35")]
	[Address(RVA = "0x3FACD0", Offset = "0x3F94D0", Length = "0x65")]
	public static extern IntPtr new_CreateBrowserOptions__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D36")]
	[Address(RVA = "0x385400", Offset = "0x383C00", Length = "0x86")]
	public static extern void CreateBrowserOptions_has_maximum_button_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x385380", Offset = "0x383B80", Length = "0x7D")]
	[Token(Token = "0x6001D37")]
	public static extern bool CreateBrowserOptions_has_maximum_button_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D38")]
	[Address(RVA = "0x385510", Offset = "0x383D10", Length = "0x86")]
	public static extern void CreateBrowserOptions_has_minimum_button_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D39")]
	[Address(RVA = "0x385490", Offset = "0x383C90", Length = "0x7D")]
	public static extern bool CreateBrowserOptions_has_minimum_button_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D3A")]
	[Address(RVA = "0x3852F0", Offset = "0x383AF0", Length = "0x86")]
	public static extern void CreateBrowserOptions_has_border_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D3B")]
	[Address(RVA = "0x385270", Offset = "0x383A70", Length = "0x7D")]
	public static extern bool CreateBrowserOptions_has_border_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D3C")]
	[Address(RVA = "0x385620", Offset = "0x383E20", Length = "0x86")]
	public static extern void CreateBrowserOptions_is_movable_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3855A0", Offset = "0x383DA0", Length = "0x7D")]
	[Token(Token = "0x6001D3D")]
	public static extern bool CreateBrowserOptions_is_movable_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x385840", Offset = "0x384040", Length = "0x85")]
	public static extern void CreateBrowserOptions_margin_top_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x3857C0", Offset = "0x383FC0", Length = "0x78")]
	public static extern int CreateBrowserOptions_margin_top_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x385730", Offset = "0x383F30", Length = "0x85")]
	[Token(Token = "0x6001D40")]
	public static extern void CreateBrowserOptions_margin_left_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3856B0", Offset = "0x383EB0", Length = "0x78")]
	[Token(Token = "0x6001D41")]
	public static extern int CreateBrowserOptions_margin_left_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3851E0", Offset = "0x3839E0", Length = "0x86")]
	[Token(Token = "0x6001D42")]
	public static extern void CreateBrowserOptions_allow_alternate_external_browser_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x385160", Offset = "0x383960", Length = "0x7D")]
	public static extern bool CreateBrowserOptions_allow_alternate_external_browser_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x3FAD40", Offset = "0x3F9540", Length = "0x78")]
	public static extern IntPtr new_CreateBrowserOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x3E8730", Offset = "0x3E6F30", Length = "0x78")]
	public static extern void delete_CreateBrowserOptions(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FAEB0", Offset = "0x3F96B0", Length = "0x65")]
	[Token(Token = "0x6001D46")]
	public static extern IntPtr new_CreateCustomerDrawBrowserOptions__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3859D0", Offset = "0x3841D0", Length = "0x85")]
	[Token(Token = "0x6001D47")]
	public static extern void CreateCustomerDrawBrowserOptions_content_offset_x_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x385950", Offset = "0x384150", Length = "0x78")]
	[Token(Token = "0x6001D48")]
	public static extern int CreateCustomerDrawBrowserOptions_content_offset_x_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x385AE0", Offset = "0x3842E0", Length = "0x85")]
	[Token(Token = "0x6001D49")]
	public static extern void CreateCustomerDrawBrowserOptions_content_offset_y_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x385A60", Offset = "0x384260", Length = "0x78")]
	[Token(Token = "0x6001D4A")]
	public static extern int CreateCustomerDrawBrowserOptions_content_offset_y_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x385D00", Offset = "0x384500", Length = "0x85")]
	public static extern void CreateCustomerDrawBrowserOptions_content_window_width_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x385C80", Offset = "0x384480", Length = "0x78")]
	public static extern uint CreateCustomerDrawBrowserOptions_content_window_width_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x385BF0", Offset = "0x3843F0", Length = "0x85")]
	[Token(Token = "0x6001D4D")]
	public static extern void CreateCustomerDrawBrowserOptions_content_window_height_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x385B70", Offset = "0x384370", Length = "0x78")]
	[Token(Token = "0x6001D4E")]
	public static extern uint CreateCustomerDrawBrowserOptions_content_window_height_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x385E10", Offset = "0x384610", Length = "0x86")]
	[Token(Token = "0x6001D4F")]
	public static extern void CreateCustomerDrawBrowserOptions_has_scroll_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x385D90", Offset = "0x384590", Length = "0x7D")]
	[Token(Token = "0x6001D50")]
	public static extern bool CreateCustomerDrawBrowserOptions_has_scroll_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D51")]
	[Address(RVA = "0x3FAF20", Offset = "0x3F9720", Length = "0x78")]
	public static extern IntPtr new_CreateCustomerDrawBrowserOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D52")]
	[Address(RVA = "0x3E8830", Offset = "0x3E7030", Length = "0x78")]
	public static extern void delete_CreateCustomerDrawBrowserOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D53")]
	[Address(RVA = "0x3FADC0", Offset = "0x3F95C0", Length = "0x65")]
	public static extern IntPtr new_CreateBrowserResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FAE30", Offset = "0x3F9630", Length = "0x78")]
	[Token(Token = "0x6001D54")]
	public static extern IntPtr new_CreateBrowserResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D55")]
	[Address(RVA = "0x3E87B0", Offset = "0x3E6FB0", Length = "0x78")]
	public static extern void delete_CreateBrowserResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D56")]
	[Address(RVA = "0x416F60", Offset = "0x415760", Length = "0x65")]
	public static extern IntPtr new_ReloadBrowserResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D57")]
	[Address(RVA = "0x416FD0", Offset = "0x4157D0", Length = "0x78")]
	public static extern IntPtr new_ReloadBrowserResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F76B0", Offset = "0x3F5EB0", Length = "0x78")]
	[Token(Token = "0x6001D58")]
	public static extern void delete_ReloadBrowserResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FAA00", Offset = "0x3F9200", Length = "0x65")]
	[Token(Token = "0x6001D59")]
	public static extern IntPtr new_CloseBrowserResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D5A")]
	[Address(RVA = "0x3FAA70", Offset = "0x3F9270", Length = "0x78")]
	public static extern IntPtr new_CloseBrowserResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D5B")]
	[Address(RVA = "0x3E85B0", Offset = "0x3E6DB0", Length = "0x78")]
	public static extern void delete_CloseBrowserResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D5C")]
	[Address(RVA = "0x3FD250", Offset = "0x3FBA50", Length = "0x65")]
	public static extern IntPtr new_JavascriptEventResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A4890", Offset = "0x3A3090", Length = "0x9B")]
	[Token(Token = "0x6001D5D")]
	public static extern void JavascriptEventResult_event_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A4810", Offset = "0x3A3010", Length = "0x78")]
	[Token(Token = "0x6001D5E")]
	public static extern IntPtr JavascriptEventResult_event_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A49B0", Offset = "0x3A31B0", Length = "0x9B")]
	[Token(Token = "0x6001D5F")]
	public static extern void JavascriptEventResult_event_value_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D60")]
	[Address(RVA = "0x3A4930", Offset = "0x3A3130", Length = "0x78")]
	public static extern IntPtr JavascriptEventResult_event_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D61")]
	[Address(RVA = "0x3FD2C0", Offset = "0x3FBAC0", Length = "0x78")]
	public static extern IntPtr new_JavascriptEventResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D62")]
	[Address(RVA = "0x3EB5B0", Offset = "0x3E9DB0", Length = "0x78")]
	public static extern void delete_JavascriptEventResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA370", Offset = "0x3F8B70", Length = "0x65")]
	[Token(Token = "0x6001D63")]
	public static extern IntPtr new_BrowserNeedsPaintRequest__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D64")]
	[Address(RVA = "0x383970", Offset = "0x382170", Length = "0x9B")]
	public static extern void BrowserNeedsPaintRequest_bgra_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D65")]
	[Address(RVA = "0x3838F0", Offset = "0x3820F0", Length = "0x78")]
	public static extern IntPtr BrowserNeedsPaintRequest_bgra_data_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D66")]
	[Address(RVA = "0x383CB0", Offset = "0x3824B0", Length = "0x85")]
	public static extern void BrowserNeedsPaintRequest_offset_x_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x383C30", Offset = "0x382430", Length = "0x78")]
	[Token(Token = "0x6001D67")]
	public static extern int BrowserNeedsPaintRequest_offset_x_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D68")]
	[Address(RVA = "0x383DC0", Offset = "0x3825C0", Length = "0x85")]
	public static extern void BrowserNeedsPaintRequest_offset_y_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D69")]
	[Address(RVA = "0x383D40", Offset = "0x382540", Length = "0x78")]
	public static extern int BrowserNeedsPaintRequest_offset_y_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383BA0", Offset = "0x3823A0", Length = "0x85")]
	[Token(Token = "0x6001D6A")]
	public static extern void BrowserNeedsPaintRequest_bgra_width_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D6B")]
	[Address(RVA = "0x383B20", Offset = "0x382320", Length = "0x78")]
	public static extern uint BrowserNeedsPaintRequest_bgra_width_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D6C")]
	[Address(RVA = "0x383A90", Offset = "0x382290", Length = "0x85")]
	public static extern void BrowserNeedsPaintRequest_bgra_height_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0x383A10", Offset = "0x382210", Length = "0x78")]
	public static extern uint BrowserNeedsPaintRequest_bgra_height_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383FE0", Offset = "0x3827E0", Length = "0x85")]
	[Token(Token = "0x6001D6E")]
	public static extern void BrowserNeedsPaintRequest_scroll_x_pos_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x383F60", Offset = "0x382760", Length = "0x78")]
	[Token(Token = "0x6001D6F")]
	public static extern uint BrowserNeedsPaintRequest_scroll_x_pos_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3840F0", Offset = "0x3828F0", Length = "0x85")]
	[Token(Token = "0x6001D70")]
	public static extern void BrowserNeedsPaintRequest_scroll_y_pos_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x384070", Offset = "0x382870", Length = "0x78")]
	[Token(Token = "0x6001D71")]
	public static extern uint BrowserNeedsPaintRequest_scroll_y_pos_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383ED0", Offset = "0x3826D0", Length = "0x88")]
	[Token(Token = "0x6001D72")]
	public static extern void BrowserNeedsPaintRequest_page_scale_factor_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D73")]
	[Address(RVA = "0x383E50", Offset = "0x382650", Length = "0x78")]
	public static extern float BrowserNeedsPaintRequest_page_scale_factor_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D74")]
	[Address(RVA = "0x3FA3E0", Offset = "0x3F8BE0", Length = "0x78")]
	public static extern IntPtr new_BrowserNeedsPaintRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E8230", Offset = "0x3E6A30", Length = "0x78")]
	[Token(Token = "0x6001D75")]
	public static extern void delete_BrowserNeedsPaintRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA280", Offset = "0x3F8A80", Length = "0x65")]
	[Token(Token = "0x6001D76")]
	public static extern IntPtr new_BrowserDamageRectNeedsPaintRequest__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D77")]
	[Address(RVA = "0x382C20", Offset = "0x381420", Length = "0x9B")]
	public static extern void BrowserDamageRectNeedsPaintRequest_bgra_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x382BA0", Offset = "0x3813A0", Length = "0x78")]
	[Token(Token = "0x6001D78")]
	public static extern IntPtr BrowserDamageRectNeedsPaintRequest_bgra_data_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D79")]
	[Address(RVA = "0x382F60", Offset = "0x381760", Length = "0x85")]
	public static extern void BrowserDamageRectNeedsPaintRequest_offset_x_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D7A")]
	[Address(RVA = "0x382EE0", Offset = "0x3816E0", Length = "0x78")]
	public static extern int BrowserDamageRectNeedsPaintRequest_offset_x_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383070", Offset = "0x381870", Length = "0x85")]
	[Token(Token = "0x6001D7B")]
	public static extern void BrowserDamageRectNeedsPaintRequest_offset_y_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x382FF0", Offset = "0x3817F0", Length = "0x78")]
	[Token(Token = "0x6001D7C")]
	public static extern int BrowserDamageRectNeedsPaintRequest_offset_y_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D7D")]
	[Address(RVA = "0x382E50", Offset = "0x381650", Length = "0x85")]
	public static extern void BrowserDamageRectNeedsPaintRequest_bgra_width_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x382DD0", Offset = "0x3815D0", Length = "0x78")]
	[Token(Token = "0x6001D7E")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_bgra_width_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x382D40", Offset = "0x381540", Length = "0x85")]
	[Token(Token = "0x6001D7F")]
	public static extern void BrowserDamageRectNeedsPaintRequest_bgra_height_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x382CC0", Offset = "0x3814C0", Length = "0x78")]
	[Token(Token = "0x6001D80")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_bgra_height_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3836D0", Offset = "0x381ED0", Length = "0x85")]
	[Token(Token = "0x6001D81")]
	public static extern void BrowserDamageRectNeedsPaintRequest_update_offset_x_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x383650", Offset = "0x381E50", Length = "0x78")]
	public static extern int BrowserDamageRectNeedsPaintRequest_update_offset_x_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3837E0", Offset = "0x381FE0", Length = "0x85")]
	[Token(Token = "0x6001D83")]
	public static extern void BrowserDamageRectNeedsPaintRequest_update_offset_y_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x383760", Offset = "0x381F60", Length = "0x78")]
	[Token(Token = "0x6001D84")]
	public static extern int BrowserDamageRectNeedsPaintRequest_update_offset_y_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x3835C0", Offset = "0x381DC0", Length = "0x85")]
	public static extern void BrowserDamageRectNeedsPaintRequest_update_bgra_width_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x383540", Offset = "0x381D40", Length = "0x78")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_update_bgra_width_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3834B0", Offset = "0x381CB0", Length = "0x85")]
	[Token(Token = "0x6001D87")]
	public static extern void BrowserDamageRectNeedsPaintRequest_update_bgra_height_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D88")]
	[Address(RVA = "0x383430", Offset = "0x381C30", Length = "0x78")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_update_bgra_height_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383290", Offset = "0x381A90", Length = "0x85")]
	[Token(Token = "0x6001D89")]
	public static extern void BrowserDamageRectNeedsPaintRequest_scroll_x_pos_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x383210", Offset = "0x381A10", Length = "0x78")]
	[Token(Token = "0x6001D8A")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_scroll_x_pos_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3833A0", Offset = "0x381BA0", Length = "0x85")]
	[Token(Token = "0x6001D8B")]
	public static extern void BrowserDamageRectNeedsPaintRequest_scroll_y_pos_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x383320", Offset = "0x381B20", Length = "0x78")]
	public static extern uint BrowserDamageRectNeedsPaintRequest_scroll_y_pos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x383180", Offset = "0x381980", Length = "0x88")]
	public static extern void BrowserDamageRectNeedsPaintRequest_page_scale_factor_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Address(RVA = "0x383100", Offset = "0x381900", Length = "0x78")]
	[Token(Token = "0x6001D8E")]
	public static extern float BrowserDamageRectNeedsPaintRequest_page_scale_factor_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA2F0", Offset = "0x3F8AF0", Length = "0x78")]
	[Token(Token = "0x6001D8F")]
	public static extern IntPtr new_BrowserDamageRectNeedsPaintRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x3E81B0", Offset = "0x3E69B0", Length = "0x78")]
	public static extern void delete_BrowserDamageRectNeedsPaintRequest(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D91")]
	[Address(RVA = "0x3FA460", Offset = "0x3F8C60", Length = "0x65")]
	public static extern IntPtr new_BrowserRenderNavigateResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x384280", Offset = "0x382A80", Length = "0x9B")]
	[Token(Token = "0x6001D92")]
	public static extern void BrowserRenderNavigateResult_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D93")]
	[Address(RVA = "0x384200", Offset = "0x382A00", Length = "0x78")]
	public static extern IntPtr BrowserRenderNavigateResult_url_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x3FA4D0", Offset = "0x3F8CD0", Length = "0x78")]
	public static extern IntPtr new_BrowserRenderNavigateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x3E82B0", Offset = "0x3E6AB0", Length = "0x78")]
	public static extern void delete_BrowserRenderNavigateResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x3FA550", Offset = "0x3F8D50", Length = "0x65")]
	public static extern IntPtr new_BrowserRenderStateChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x384420", Offset = "0x382C20", Length = "0x86")]
	[Token(Token = "0x6001D97")]
	public static extern void BrowserRenderStateChanged_can_go_back_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x3843A0", Offset = "0x382BA0", Length = "0x7D")]
	public static extern bool BrowserRenderStateChanged_can_go_back_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x384530", Offset = "0x382D30", Length = "0x86")]
	public static extern void BrowserRenderStateChanged_can_go_forward_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x3844B0", Offset = "0x382CB0", Length = "0x7D")]
	public static extern bool BrowserRenderStateChanged_can_go_forward_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA5C0", Offset = "0x3F8DC0", Length = "0x78")]
	[Token(Token = "0x6001D9B")]
	public static extern IntPtr new_BrowserRenderStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0x3E8330", Offset = "0x3E6B30", Length = "0x78")]
	public static extern void delete_BrowserRenderStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001D9D")]
	[Address(RVA = "0x3FA640", Offset = "0x3F8E40", Length = "0x65")]
	public static extern IntPtr new_BrowserRenderTitleChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001D9E")]
	[Address(RVA = "0x3846C0", Offset = "0x382EC0", Length = "0x9B")]
	public static extern void BrowserRenderTitleChanged_new_title_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001D9F")]
	[Address(RVA = "0x384640", Offset = "0x382E40", Length = "0x78")]
	public static extern IntPtr BrowserRenderTitleChanged_new_title_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DA0")]
	[Address(RVA = "0x3FA6B0", Offset = "0x3F8EB0", Length = "0x78")]
	public static extern IntPtr new_BrowserRenderTitleChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DA1")]
	[Address(RVA = "0x3E83B0", Offset = "0x3E6BB0", Length = "0x78")]
	public static extern void delete_BrowserRenderTitleChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DA2")]
	[Address(RVA = "0x3FA730", Offset = "0x3F8F30", Length = "0x65")]
	public static extern IntPtr new_BrowserTryNavigateNewPageRequest__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DA3")]
	[Address(RVA = "0x384A90", Offset = "0x383290", Length = "0x9B")]
	public static extern void BrowserTryNavigateNewPageRequest_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x384A10", Offset = "0x383210", Length = "0x78")]
	[Token(Token = "0x6001DA4")]
	public static extern IntPtr BrowserTryNavigateNewPageRequest_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x384970", Offset = "0x383170", Length = "0x9B")]
	[Token(Token = "0x6001DA5")]
	public static extern void BrowserTryNavigateNewPageRequest_target_type_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3848F0", Offset = "0x3830F0", Length = "0x78")]
	[Token(Token = "0x6001DA6")]
	public static extern IntPtr BrowserTryNavigateNewPageRequest_target_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x384860", Offset = "0x383060", Length = "0x86")]
	[Token(Token = "0x6001DA7")]
	public static extern void BrowserTryNavigateNewPageRequest_is_redirect_request_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3847E0", Offset = "0x382FE0", Length = "0x7D")]
	[Token(Token = "0x6001DA8")]
	public static extern bool BrowserTryNavigateNewPageRequest_is_redirect_request_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DA9")]
	[Address(RVA = "0x3FA7A0", Offset = "0x3F8FA0", Length = "0x78")]
	public static extern IntPtr new_BrowserTryNavigateNewPageRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E8430", Offset = "0x3E6C30", Length = "0x78")]
	[Token(Token = "0x6001DAA")]
	public static extern void delete_BrowserTryNavigateNewPageRequest(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DAB")]
	[Address(RVA = "0x3BCBA0", Offset = "0x3BB3A0", Length = "0x87")]
	public static extern void RailDlcInfo_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BCB20", Offset = "0x3BB320", Length = "0x78")]
	[Token(Token = "0x6001DAC")]
	public static extern IntPtr RailDlcInfo_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x3BCCB0", Offset = "0x3BB4B0", Length = "0x87")]
	public static extern void RailDlcInfo_game_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BCC30", Offset = "0x3BB430", Length = "0x78")]
	[Token(Token = "0x6001DAE")]
	public static extern IntPtr RailDlcInfo_game_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x3BCFF0", Offset = "0x3BB7F0", Length = "0x9B")]
	public static extern void RailDlcInfo_version_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x3BCF70", Offset = "0x3BB770", Length = "0x78")]
	public static extern IntPtr RailDlcInfo_version_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x3BCDC0", Offset = "0x3BB5C0", Length = "0x9B")]
	public static extern void RailDlcInfo_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x3BCD40", Offset = "0x3BB540", Length = "0x78")]
	public static extern IntPtr RailDlcInfo_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x3BC970", Offset = "0x3BB170", Length = "0x9B")]
	public static extern void RailDlcInfo_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x3BC8F0", Offset = "0x3BB0F0", Length = "0x78")]
	public static extern IntPtr RailDlcInfo_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x3BCEE0", Offset = "0x3BB6E0", Length = "0x88")]
	public static extern void RailDlcInfo_original_price_set(IntPtr jarg1, double jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x3BCE60", Offset = "0x3BB660", Length = "0x78")]
	public static extern double RailDlcInfo_original_price_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x3BCA90", Offset = "0x3BB290", Length = "0x88")]
	public static extern void RailDlcInfo_discount_price_set(IntPtr jarg1, double jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BCA10", Offset = "0x3BB210", Length = "0x78")]
	[Token(Token = "0x6001DB8")]
	public static extern double RailDlcInfo_discount_price_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x406330", Offset = "0x404B30", Length = "0x65")]
	[Token(Token = "0x6001DB9")]
	public static extern IntPtr new_RailDlcInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4063A0", Offset = "0x404BA0", Length = "0x78")]
	[Token(Token = "0x6001DBA")]
	public static extern IntPtr new_RailDlcInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x3EE730", Offset = "0x3ECF30", Length = "0x78")]
	public static extern void delete_RailDlcInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x3BD220", Offset = "0x3BBA20", Length = "0x85")]
	public static extern void RailDlcInstallProgress_progress_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x3BD1A0", Offset = "0x3BB9A0", Length = "0x78")]
	public static extern uint RailDlcInstallProgress_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x3BD110", Offset = "0x3BB910", Length = "0x87")]
	public static extern void RailDlcInstallProgress_finished_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x3BD090", Offset = "0x3BB890", Length = "0x78")]
	public static extern ulong RailDlcInstallProgress_finished_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x3BD440", Offset = "0x3BBC40", Length = "0x87")]
	public static extern void RailDlcInstallProgress_total_bytes_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x3BD3C0", Offset = "0x3BBBC0", Length = "0x78")]
	public static extern ulong RailDlcInstallProgress_total_bytes_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BD330", Offset = "0x3BBB30", Length = "0x85")]
	[Token(Token = "0x6001DC2")]
	public static extern void RailDlcInstallProgress_speed_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x3BD2B0", Offset = "0x3BBAB0", Length = "0x78")]
	public static extern uint RailDlcInstallProgress_speed_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x406420", Offset = "0x404C20", Length = "0x65")]
	public static extern IntPtr new_RailDlcInstallProgress__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x406490", Offset = "0x404C90", Length = "0x78")]
	public static extern IntPtr new_RailDlcInstallProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x3EE7B0", Offset = "0x3ECFB0", Length = "0x78")]
	public static extern void delete_RailDlcInstallProgress(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x3BD660", Offset = "0x3BBE60", Length = "0x86")]
	public static extern void RailDlcOwned_is_owned_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x3BD5E0", Offset = "0x3BBDE0", Length = "0x7D")]
	public static extern bool RailDlcOwned_is_owned_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BD550", Offset = "0x3BBD50", Length = "0x87")]
	[Token(Token = "0x6001DC9")]
	public static extern void RailDlcOwned_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x3BD4D0", Offset = "0x3BBCD0", Length = "0x78")]
	public static extern IntPtr RailDlcOwned_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x406510", Offset = "0x404D10", Length = "0x65")]
	public static extern IntPtr new_RailDlcOwned__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x406580", Offset = "0x404D80", Length = "0x78")]
	public static extern IntPtr new_RailDlcOwned__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x3EE830", Offset = "0x3ED030", Length = "0x78")]
	public static extern void delete_RailDlcOwned(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x387730", Offset = "0x385F30", Length = "0x87")]
	public static extern void DlcInstallStart_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3876B0", Offset = "0x385EB0", Length = "0x78")]
	[Token(Token = "0x6001DCF")]
	public static extern IntPtr DlcInstallStart_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB9F0", Offset = "0x3FA1F0", Length = "0x65")]
	[Token(Token = "0x6001DD0")]
	public static extern IntPtr new_DlcInstallStart__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x3FBA60", Offset = "0x3FA260", Length = "0x78")]
	public static extern IntPtr new_DlcInstallStart__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DD2")]
	[Address(RVA = "0x3E8E30", Offset = "0x3E7630", Length = "0x78")]
	public static extern void delete_DlcInstallStart(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DD3")]
	[Address(RVA = "0x387490", Offset = "0x385C90", Length = "0x87")]
	public static extern void DlcInstallStartResult_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DD4")]
	[Address(RVA = "0x387410", Offset = "0x385C10", Length = "0x78")]
	public static extern IntPtr DlcInstallStartResult_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3875A0", Offset = "0x385DA0", Length = "0x85")]
	[Token(Token = "0x6001DD5")]
	public static extern void DlcInstallStartResult_result_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x387520", Offset = "0x385D20", Length = "0x78")]
	[Token(Token = "0x6001DD6")]
	public static extern int DlcInstallStartResult_result_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB900", Offset = "0x3FA100", Length = "0x65")]
	[Token(Token = "0x6001DD7")]
	public static extern IntPtr new_DlcInstallStartResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DD8")]
	[Address(RVA = "0x3FB970", Offset = "0x3FA170", Length = "0x78")]
	public static extern IntPtr new_DlcInstallStartResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DD9")]
	[Address(RVA = "0x3E8DB0", Offset = "0x3E75B0", Length = "0x78")]
	public static extern void delete_DlcInstallStartResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3871F0", Offset = "0x3859F0", Length = "0x87")]
	[Token(Token = "0x6001DDA")]
	public static extern void DlcInstallProgress_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x387170", Offset = "0x385970", Length = "0x78")]
	[Token(Token = "0x6001DDB")]
	public static extern IntPtr DlcInstallProgress_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x387300", Offset = "0x385B00", Length = "0x87")]
	[Token(Token = "0x6001DDC")]
	public static extern void DlcInstallProgress_progress_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DDD")]
	[Address(RVA = "0x387280", Offset = "0x385A80", Length = "0x78")]
	public static extern IntPtr DlcInstallProgress_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DDE")]
	[Address(RVA = "0x3FB810", Offset = "0x3FA010", Length = "0x65")]
	public static extern IntPtr new_DlcInstallProgress__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FB880", Offset = "0x3FA080", Length = "0x78")]
	[Token(Token = "0x6001DDF")]
	public static extern IntPtr new_DlcInstallProgress__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DE0")]
	[Address(RVA = "0x3E8D30", Offset = "0x3E7530", Length = "0x78")]
	public static extern void delete_DlcInstallProgress(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x386F50", Offset = "0x385750", Length = "0x87")]
	[Token(Token = "0x6001DE1")]
	public static extern void DlcInstallFinished_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x386ED0", Offset = "0x3856D0", Length = "0x78")]
	[Token(Token = "0x6001DE2")]
	public static extern IntPtr DlcInstallFinished_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x387060", Offset = "0x385860", Length = "0x85")]
	[Token(Token = "0x6001DE3")]
	public static extern void DlcInstallFinished_result_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x386FE0", Offset = "0x3857E0", Length = "0x78")]
	[Token(Token = "0x6001DE4")]
	public static extern int DlcInstallFinished_result_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB720", Offset = "0x3F9F20", Length = "0x65")]
	[Token(Token = "0x6001DE5")]
	public static extern IntPtr new_DlcInstallFinished__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FB790", Offset = "0x3F9F90", Length = "0x78")]
	[Token(Token = "0x6001DE6")]
	public static extern IntPtr new_DlcInstallFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E8CB0", Offset = "0x3E74B0", Length = "0x78")]
	[Token(Token = "0x6001DE7")]
	public static extern void delete_DlcInstallFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x387E00", Offset = "0x386600", Length = "0x87")]
	[Token(Token = "0x6001DE8")]
	public static extern void DlcUninstallFinished_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x387D80", Offset = "0x386580", Length = "0x78")]
	[Token(Token = "0x6001DE9")]
	public static extern IntPtr DlcUninstallFinished_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x387F10", Offset = "0x386710", Length = "0x85")]
	public static extern void DlcUninstallFinished_result_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x387E90", Offset = "0x386690", Length = "0x78")]
	public static extern int DlcUninstallFinished_result_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x3FBCC0", Offset = "0x3FA4C0", Length = "0x65")]
	public static extern IntPtr new_DlcUninstallFinished__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x3FBD30", Offset = "0x3FA530", Length = "0x78")]
	public static extern IntPtr new_DlcUninstallFinished__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x3E8FB0", Offset = "0x3E77B0", Length = "0x78")]
	public static extern void delete_DlcUninstallFinished(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA820", Offset = "0x3F9020", Length = "0x65")]
	[Token(Token = "0x6001DEF")]
	public static extern IntPtr new_CheckAllDlcsStateReadyResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FA890", Offset = "0x3F9090", Length = "0x78")]
	[Token(Token = "0x6001DF0")]
	public static extern IntPtr new_CheckAllDlcsStateReadyResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E84B0", Offset = "0x3E6CB0", Length = "0x78")]
	[Token(Token = "0x6001DF1")]
	public static extern void delete_CheckAllDlcsStateReadyResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x3AA330", Offset = "0x3A8B30", Length = "0x87")]
	public static extern void QueryIsOwnedDlcsResult_dlc_owned_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x3AA2B0", Offset = "0x3A8AB0", Length = "0x78")]
	public static extern IntPtr QueryIsOwnedDlcsResult_dlc_owned_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x3FF140", Offset = "0x3FD940", Length = "0x65")]
	public static extern IntPtr new_QueryIsOwnedDlcsResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x3FF1B0", Offset = "0x3FD9B0", Length = "0x78")]
	public static extern IntPtr new_QueryIsOwnedDlcsResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC630", Offset = "0x3EAE30", Length = "0x78")]
	[Token(Token = "0x6001DF6")]
	public static extern void delete_QueryIsOwnedDlcsResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x3FBAE0", Offset = "0x3FA2E0", Length = "0x65")]
	public static extern IntPtr new_DlcOwnershipChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x3878C0", Offset = "0x3860C0", Length = "0x87")]
	public static extern void DlcOwnershipChanged_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x387840", Offset = "0x386040", Length = "0x78")]
	public static extern IntPtr DlcOwnershipChanged_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3879D0", Offset = "0x3861D0", Length = "0x86")]
	[Token(Token = "0x6001DFA")]
	public static extern void DlcOwnershipChanged_is_active_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x387950", Offset = "0x386150", Length = "0x7D")]
	public static extern bool DlcOwnershipChanged_is_active_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0x3FBB50", Offset = "0x3FA350", Length = "0x78")]
	public static extern IntPtr new_DlcOwnershipChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x3E8EB0", Offset = "0x3E76B0", Length = "0x78")]
	public static extern void delete_DlcOwnershipChanged(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FBBD0", Offset = "0x3FA3D0", Length = "0x65")]
	[Token(Token = "0x6001DFE")]
	public static extern IntPtr new_DlcRefundChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x387B60", Offset = "0x386360", Length = "0x87")]
	[Token(Token = "0x6001DFF")]
	public static extern void DlcRefundChanged_dlc_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x387AE0", Offset = "0x3862E0", Length = "0x78")]
	public static extern IntPtr DlcRefundChanged_dlc_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x387C70", Offset = "0x386470", Length = "0x85")]
	public static extern void DlcRefundChanged_refund_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x387BF0", Offset = "0x3863F0", Length = "0x78")]
	[Token(Token = "0x6001E02")]
	public static extern int DlcRefundChanged_refund_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FBC40", Offset = "0x3FA440", Length = "0x78")]
	[Token(Token = "0x6001E03")]
	public static extern IntPtr new_DlcRefundChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E04")]
	[Address(RVA = "0x3E8F30", Offset = "0x3E7730", Length = "0x78")]
	public static extern void delete_DlcRefundChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E05")]
	[Address(RVA = "0x416C90", Offset = "0x415490", Length = "0x65")]
	public static extern IntPtr new_RailWindowLayout__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E06")]
	[Address(RVA = "0x3DF740", Offset = "0x3DDF40", Length = "0x85")]
	public static extern void RailWindowLayout_x_margin_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E07")]
	[Address(RVA = "0x3DF6C0", Offset = "0x3DDEC0", Length = "0x78")]
	public static extern uint RailWindowLayout_x_margin_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DF850", Offset = "0x3DE050", Length = "0x85")]
	[Token(Token = "0x6001E08")]
	public static extern void RailWindowLayout_y_margin_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DF7D0", Offset = "0x3DDFD0", Length = "0x78")]
	[Token(Token = "0x6001E09")]
	public static extern uint RailWindowLayout_y_margin_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E0A")]
	[Address(RVA = "0x3DF630", Offset = "0x3DDE30", Length = "0x85")]
	public static extern void RailWindowLayout_position_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E0B")]
	[Address(RVA = "0x3DF5B0", Offset = "0x3DDDB0", Length = "0x78")]
	public static extern int RailWindowLayout_position_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E0C")]
	[Address(RVA = "0x416D00", Offset = "0x415500", Length = "0x78")]
	public static extern IntPtr new_RailWindowLayout__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E0D")]
	[Address(RVA = "0x3F7530", Offset = "0x3F5D30", Length = "0x78")]
	public static extern void delete_RailWindowLayout(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E0E")]
	[Address(RVA = "0x415500", Offset = "0x413D00", Length = "0x65")]
	public static extern IntPtr new_RailStoreOptions__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E0F")]
	[Address(RVA = "0x3DAEB0", Offset = "0x3D96B0", Length = "0x85")]
	public static extern void RailStoreOptions_store_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DAE30", Offset = "0x3D9630", Length = "0x78")]
	[Token(Token = "0x6001E10")]
	public static extern int RailStoreOptions_store_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DB0D0", Offset = "0x3D98D0", Length = "0x85")]
	[Token(Token = "0x6001E11")]
	public static extern void RailStoreOptions_window_margin_top_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E12")]
	[Address(RVA = "0x3DB050", Offset = "0x3D9850", Length = "0x78")]
	public static extern int RailStoreOptions_window_margin_top_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DAFC0", Offset = "0x3D97C0", Length = "0x85")]
	[Token(Token = "0x6001E13")]
	public static extern void RailStoreOptions_window_margin_left_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DAF40", Offset = "0x3D9740", Length = "0x78")]
	[Token(Token = "0x6001E14")]
	public static extern int RailStoreOptions_window_margin_left_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415570", Offset = "0x413D70", Length = "0x78")]
	[Token(Token = "0x6001E15")]
	public static extern IntPtr new_RailStoreOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F68B0", Offset = "0x3F50B0", Length = "0x78")]
	[Token(Token = "0x6001E16")]
	public static extern void delete_RailStoreOptions(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418130", Offset = "0x416930", Length = "0x65")]
	[Token(Token = "0x6001E17")]
	public static extern IntPtr new_ShowFloatingWindowResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E3CA0", Offset = "0x3E24A0", Length = "0x86")]
	[Token(Token = "0x6001E18")]
	public static extern void ShowFloatingWindowResult_is_show_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E3C20", Offset = "0x3E2420", Length = "0x7D")]
	[Token(Token = "0x6001E19")]
	public static extern bool ShowFloatingWindowResult_is_show_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E3DB0", Offset = "0x3E25B0", Length = "0x85")]
	[Token(Token = "0x6001E1A")]
	public static extern void ShowFloatingWindowResult_window_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E1B")]
	[Address(RVA = "0x3E3D30", Offset = "0x3E2530", Length = "0x78")]
	public static extern int ShowFloatingWindowResult_window_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E1C")]
	[Address(RVA = "0x4181A0", Offset = "0x4169A0", Length = "0x78")]
	public static extern IntPtr new_ShowFloatingWindowResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8030", Offset = "0x3F6830", Length = "0x78")]
	[Token(Token = "0x6001E1D")]
	public static extern void delete_ShowFloatingWindowResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E1E")]
	[Address(RVA = "0x418220", Offset = "0x416A20", Length = "0x65")]
	public static extern IntPtr new_ShowNotifyWindow__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E4060", Offset = "0x3E2860", Length = "0x85")]
	[Token(Token = "0x6001E1F")]
	public static extern void ShowNotifyWindow_window_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E3FE0", Offset = "0x3E27E0", Length = "0x78")]
	[Token(Token = "0x6001E20")]
	public static extern int ShowNotifyWindow_window_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E21")]
	[Address(RVA = "0x3E3F40", Offset = "0x3E2740", Length = "0x9B")]
	public static extern void ShowNotifyWindow_json_content_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E22")]
	[Address(RVA = "0x3E3EC0", Offset = "0x3E26C0", Length = "0x78")]
	public static extern IntPtr ShowNotifyWindow_json_content_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418290", Offset = "0x416A90", Length = "0x78")]
	[Token(Token = "0x6001E23")]
	public static extern IntPtr new_ShowNotifyWindow__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F80B0", Offset = "0x3F68B0", Length = "0x78")]
	[Token(Token = "0x6001E24")]
	public static extern void delete_ShowNotifyWindow(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FBF90", Offset = "0x3FA790", Length = "0x65")]
	[Token(Token = "0x6001E25")]
	public static extern IntPtr new_GameServerInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x388AC0", Offset = "0x3872C0", Length = "0x78")]
	[Token(Token = "0x6001E26")]
	public static extern void GameServerInfo_Reset(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389020", Offset = "0x387820", Length = "0x87")]
	[Token(Token = "0x6001E27")]
	public static extern void GameServerInfo_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E28")]
	[Address(RVA = "0x388FA0", Offset = "0x3877A0", Length = "0x78")]
	public static extern IntPtr GameServerInfo_game_server_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389570", Offset = "0x387D70", Length = "0x87")]
	[Token(Token = "0x6001E29")]
	public static extern void GameServerInfo_owner_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3894F0", Offset = "0x387CF0", Length = "0x78")]
	[Token(Token = "0x6001E2A")]
	public static extern IntPtr GameServerInfo_owner_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389240", Offset = "0x387A40", Length = "0x86")]
	[Token(Token = "0x6001E2B")]
	public static extern void GameServerInfo_is_dedicated_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E2C")]
	[Address(RVA = "0x3891C0", Offset = "0x3879C0", Length = "0x7D")]
	public static extern bool GameServerInfo_is_dedicated_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E2D")]
	[Address(RVA = "0x388F00", Offset = "0x387700", Length = "0x9B")]
	public static extern void GameServerInfo_game_server_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E2E")]
	[Address(RVA = "0x388E80", Offset = "0x387680", Length = "0x78")]
	public static extern IntPtr GameServerInfo_game_server_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x388DE0", Offset = "0x3875E0", Length = "0x9B")]
	[Token(Token = "0x6001E2F")]
	public static extern void GameServerInfo_game_server_map_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E30")]
	[Address(RVA = "0x388D60", Offset = "0x387560", Length = "0x78")]
	public static extern IntPtr GameServerInfo_game_server_map_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389130", Offset = "0x387930", Length = "0x86")]
	[Token(Token = "0x6001E31")]
	public static extern void GameServerInfo_has_password_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E32")]
	[Address(RVA = "0x3890B0", Offset = "0x3878B0", Length = "0x7D")]
	public static extern bool GameServerInfo_has_password_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389350", Offset = "0x387B50", Length = "0x86")]
	[Token(Token = "0x6001E33")]
	public static extern void GameServerInfo_is_friend_only_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3892D0", Offset = "0x387AD0", Length = "0x7D")]
	[Token(Token = "0x6001E34")]
	public static extern bool GameServerInfo_is_friend_only_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x389460", Offset = "0x387C60", Length = "0x85")]
	public static extern void GameServerInfo_max_players_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x3893E0", Offset = "0x387BE0", Length = "0x78")]
	public static extern uint GameServerInfo_max_players_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E37")]
	[Address(RVA = "0x388CD0", Offset = "0x3874D0", Length = "0x85")]
	public static extern void GameServerInfo_current_players_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E38")]
	[Address(RVA = "0x388C50", Offset = "0x387450", Length = "0x78")]
	public static extern uint GameServerInfo_current_players_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x388BC0", Offset = "0x3873C0", Length = "0x85")]
	[Token(Token = "0x6001E39")]
	public static extern void GameServerInfo_bot_players_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x388B40", Offset = "0x387340", Length = "0x78")]
	[Token(Token = "0x6001E3A")]
	public static extern uint GameServerInfo_bot_players_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E3B")]
	[Address(RVA = "0x3898C0", Offset = "0x3880C0", Length = "0x9B")]
	public static extern void GameServerInfo_server_host_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E3C")]
	[Address(RVA = "0x389840", Offset = "0x388040", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_host_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E3D")]
	[Address(RVA = "0x3897A0", Offset = "0x387FA0", Length = "0x9B")]
	public static extern void GameServerInfo_server_fullname_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E3E")]
	[Address(RVA = "0x389720", Offset = "0x387F20", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_fullname_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389680", Offset = "0x387E80", Length = "0x9B")]
	[Token(Token = "0x6001E3F")]
	public static extern void GameServerInfo_server_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E40")]
	[Address(RVA = "0x389600", Offset = "0x387E00", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E41")]
	[Address(RVA = "0x389D20", Offset = "0x388520", Length = "0x9B")]
	public static extern void GameServerInfo_server_tags_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E42")]
	[Address(RVA = "0x389CA0", Offset = "0x3884A0", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_tags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E43")]
	[Address(RVA = "0x389E40", Offset = "0x388640", Length = "0x9B")]
	public static extern void GameServerInfo_server_version_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E44")]
	[Address(RVA = "0x389DC0", Offset = "0x3885C0", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_version_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E45")]
	[Address(RVA = "0x389F60", Offset = "0x388760", Length = "0x9B")]
	public static extern void GameServerInfo_spectator_host_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E46")]
	[Address(RVA = "0x389EE0", Offset = "0x3886E0", Length = "0x78")]
	public static extern IntPtr GameServerInfo_spectator_host_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3899E0", Offset = "0x3881E0", Length = "0x9B")]
	[Token(Token = "0x6001E47")]
	public static extern void GameServerInfo_server_info_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x389960", Offset = "0x388160", Length = "0x78")]
	[Token(Token = "0x6001E48")]
	public static extern IntPtr GameServerInfo_server_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E49")]
	[Address(RVA = "0x389C10", Offset = "0x388410", Length = "0x87")]
	public static extern void GameServerInfo_server_mods_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E4A")]
	[Address(RVA = "0x389B90", Offset = "0x388390", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_mods_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x389B00", Offset = "0x388300", Length = "0x87")]
	[Token(Token = "0x6001E4B")]
	public static extern void GameServerInfo_server_kvs_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E4C")]
	[Address(RVA = "0x389A80", Offset = "0x388280", Length = "0x78")]
	public static extern IntPtr GameServerInfo_server_kvs_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E4D")]
	[Address(RVA = "0x3FC000", Offset = "0x3FA800", Length = "0x78")]
	public static extern IntPtr new_GameServerInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x3E91B0", Offset = "0x3E79B0", Length = "0x78")]
	public static extern void delete_GameServerInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x3FAFA0", Offset = "0x3F97A0", Length = "0x65")]
	public static extern IntPtr new_CreateGameServerOptions__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x385F20", Offset = "0x384720", Length = "0x86")]
	[Token(Token = "0x6001E50")]
	public static extern void CreateGameServerOptions_enable_team_voice_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x385EA0", Offset = "0x3846A0", Length = "0x7D")]
	[Token(Token = "0x6001E51")]
	public static extern bool CreateGameServerOptions_enable_team_voice_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x386030", Offset = "0x384830", Length = "0x86")]
	[Token(Token = "0x6001E52")]
	public static extern void CreateGameServerOptions_has_password_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x385FB0", Offset = "0x3847B0", Length = "0x7D")]
	[Token(Token = "0x6001E53")]
	public static extern bool CreateGameServerOptions_has_password_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E54")]
	[Address(RVA = "0x3FB010", Offset = "0x3F9810", Length = "0x78")]
	public static extern IntPtr new_CreateGameServerOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E55")]
	[Address(RVA = "0x3E88B0", Offset = "0x3E70B0", Length = "0x78")]
	public static extern void delete_CreateGameServerOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E56")]
	[Address(RVA = "0x3FC260", Offset = "0x3FAA60", Length = "0x65")]
	public static extern IntPtr new_GameServerListSorter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E57")]
	[Address(RVA = "0x38B310", Offset = "0x389B10", Length = "0x85")]
	public static extern void GameServerListSorter_sorter_key_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E58")]
	[Address(RVA = "0x38B290", Offset = "0x389A90", Length = "0x78")]
	public static extern int GameServerListSorter_sorter_key_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38AFD0", Offset = "0x3897D0", Length = "0x9B")]
	[Token(Token = "0x6001E59")]
	public static extern void GameServerListSorter_sort_key_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38AF50", Offset = "0x389750", Length = "0x78")]
	[Token(Token = "0x6001E5A")]
	public static extern IntPtr GameServerListSorter_sort_key_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38B200", Offset = "0x389A00", Length = "0x85")]
	[Token(Token = "0x6001E5B")]
	public static extern void GameServerListSorter_sort_value_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x38B180", Offset = "0x389980", Length = "0x78")]
	[Token(Token = "0x6001E5C")]
	public static extern int GameServerListSorter_sort_value_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38B0F0", Offset = "0x3898F0", Length = "0x85")]
	[Token(Token = "0x6001E5D")]
	public static extern void GameServerListSorter_sort_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x38B070", Offset = "0x389870", Length = "0x78")]
	[Token(Token = "0x6001E5E")]
	public static extern int GameServerListSorter_sort_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC2D0", Offset = "0x3FAAD0", Length = "0x78")]
	[Token(Token = "0x6001E5F")]
	public static extern IntPtr new_GameServerListSorter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E9330", Offset = "0x3E7B30", Length = "0x78")]
	[Token(Token = "0x6001E60")]
	public static extern void delete_GameServerListSorter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC080", Offset = "0x3FA880", Length = "0x65")]
	[Token(Token = "0x6001E61")]
	public static extern IntPtr new_GameServerListFilterKey__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E62")]
	[Address(RVA = "0x38A2B0", Offset = "0x388AB0", Length = "0x9B")]
	public static extern void GameServerListFilterKey_key_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38A230", Offset = "0x388A30", Length = "0x78")]
	[Token(Token = "0x6001E63")]
	public static extern IntPtr GameServerListFilterKey_key_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E64")]
	[Address(RVA = "0x38A3D0", Offset = "0x388BD0", Length = "0x85")]
	public static extern void GameServerListFilterKey_value_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E65")]
	[Address(RVA = "0x38A350", Offset = "0x388B50", Length = "0x78")]
	public static extern int GameServerListFilterKey_value_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38A080", Offset = "0x388880", Length = "0x85")]
	[Token(Token = "0x6001E66")]
	public static extern void GameServerListFilterKey_comparison_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E67")]
	[Address(RVA = "0x38A000", Offset = "0x388800", Length = "0x78")]
	public static extern int GameServerListFilterKey_comparison_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E68")]
	[Address(RVA = "0x38A190", Offset = "0x388990", Length = "0x9B")]
	public static extern void GameServerListFilterKey_filter_value_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38A110", Offset = "0x388910", Length = "0x78")]
	[Token(Token = "0x6001E69")]
	public static extern IntPtr GameServerListFilterKey_filter_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E6A")]
	[Address(RVA = "0x3FC0F0", Offset = "0x3FA8F0", Length = "0x78")]
	public static extern IntPtr new_GameServerListFilterKey__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E9230", Offset = "0x3E7A30", Length = "0x78")]
	[Token(Token = "0x6001E6B")]
	public static extern void delete_GameServerListFilterKey(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC170", Offset = "0x3FA970", Length = "0x65")]
	[Token(Token = "0x6001E6C")]
	public static extern IntPtr new_GameServerListFilter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E6D")]
	[Address(RVA = "0x38AB70", Offset = "0x389370", Length = "0x87")]
	public static extern void GameServerListFilter_filters_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38AAF0", Offset = "0x3892F0", Length = "0x78")]
	[Token(Token = "0x6001E6E")]
	public static extern IntPtr GameServerListFilter_filters_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38AC80", Offset = "0x389480", Length = "0x87")]
	[Token(Token = "0x6001E6F")]
	public static extern void GameServerListFilter_owner_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38AC00", Offset = "0x389400", Length = "0x78")]
	[Token(Token = "0x6001E70")]
	public static extern IntPtr GameServerListFilter_owner_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38A4E0", Offset = "0x388CE0", Length = "0x85")]
	[Token(Token = "0x6001E71")]
	public static extern void GameServerListFilter_filter_dedicated_server_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x38A460", Offset = "0x388C60", Length = "0x78")]
	[Token(Token = "0x6001E72")]
	public static extern int GameServerListFilter_filter_dedicated_server_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E73")]
	[Address(RVA = "0x38A940", Offset = "0x389140", Length = "0x9B")]
	public static extern void GameServerListFilter_filter_game_server_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38A8C0", Offset = "0x3890C0", Length = "0x78")]
	[Token(Token = "0x6001E74")]
	public static extern IntPtr GameServerListFilter_filter_game_server_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x38A820", Offset = "0x389020", Length = "0x9B")]
	public static extern void GameServerListFilter_filter_game_server_map_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x38A7A0", Offset = "0x388FA0", Length = "0x78")]
	public static extern IntPtr GameServerListFilter_filter_game_server_map_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x38A700", Offset = "0x388F00", Length = "0x9B")]
	public static extern void GameServerListFilter_filter_game_server_host_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x38A680", Offset = "0x388E80", Length = "0x78")]
	public static extern IntPtr GameServerListFilter_filter_game_server_host_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38AA60", Offset = "0x389260", Length = "0x85")]
	[Token(Token = "0x6001E79")]
	public static extern void GameServerListFilter_filter_password_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x38A9E0", Offset = "0x3891E0", Length = "0x78")]
	public static extern int GameServerListFilter_filter_password_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38A5F0", Offset = "0x388DF0", Length = "0x85")]
	[Token(Token = "0x6001E7B")]
	public static extern void GameServerListFilter_filter_friends_created_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x38A570", Offset = "0x388D70", Length = "0x78")]
	[Token(Token = "0x6001E7C")]
	public static extern int GameServerListFilter_filter_friends_created_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x38AD90", Offset = "0x389590", Length = "0x9B")]
	public static extern void GameServerListFilter_tags_contained_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38AD10", Offset = "0x389510", Length = "0x78")]
	[Token(Token = "0x6001E7E")]
	public static extern IntPtr GameServerListFilter_tags_contained_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38AEB0", Offset = "0x3896B0", Length = "0x9B")]
	[Token(Token = "0x6001E7F")]
	public static extern void GameServerListFilter_tags_not_contained_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38AE30", Offset = "0x389630", Length = "0x78")]
	[Token(Token = "0x6001E80")]
	public static extern IntPtr GameServerListFilter_tags_not_contained_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x3FC1E0", Offset = "0x3FA9E0", Length = "0x78")]
	public static extern IntPtr new_GameServerListFilter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E82")]
	[Address(RVA = "0x3E92B0", Offset = "0x3E7AB0", Length = "0x78")]
	public static extern void delete_GameServerListFilter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC350", Offset = "0x3FAB50", Length = "0x65")]
	[Token(Token = "0x6001E83")]
	public static extern IntPtr new_GameServerPlayerInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38B420", Offset = "0x389C20", Length = "0x87")]
	[Token(Token = "0x6001E84")]
	public static extern void GameServerPlayerInfo_member_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38B3A0", Offset = "0x389BA0", Length = "0x78")]
	[Token(Token = "0x6001E85")]
	public static extern IntPtr GameServerPlayerInfo_member_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38B530", Offset = "0x389D30", Length = "0x9B")]
	[Token(Token = "0x6001E86")]
	public static extern void GameServerPlayerInfo_member_nickname_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x38B4B0", Offset = "0x389CB0", Length = "0x78")]
	public static extern IntPtr GameServerPlayerInfo_member_nickname_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38B650", Offset = "0x389E50", Length = "0x87")]
	[Token(Token = "0x6001E88")]
	public static extern void GameServerPlayerInfo_member_score_set(IntPtr jarg1, long jarg2);

	[PreserveSig]
	[Address(RVA = "0x38B5D0", Offset = "0x389DD0", Length = "0x78")]
	[Token(Token = "0x6001E89")]
	public static extern long GameServerPlayerInfo_member_score_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E8A")]
	[Address(RVA = "0x3FC3C0", Offset = "0x3FABC0", Length = "0x78")]
	public static extern IntPtr new_GameServerPlayerInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x3E93B0", Offset = "0x3E7BB0", Length = "0x78")]
	public static extern void delete_GameServerPlayerInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8DE0", Offset = "0x3F75E0", Length = "0x65")]
	[Token(Token = "0x6001E8C")]
	public static extern IntPtr new_AsyncAcquireGameServerSessionTicketResponse__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x37ED90", Offset = "0x37D590", Length = "0x87")]
	[Token(Token = "0x6001E8D")]
	public static extern void AsyncAcquireGameServerSessionTicketResponse_session_ticket_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x37ED10", Offset = "0x37D510", Length = "0x78")]
	public static extern IntPtr AsyncAcquireGameServerSessionTicketResponse_session_ticket_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8E50", Offset = "0x3F7650", Length = "0x78")]
	[Token(Token = "0x6001E8F")]
	public static extern IntPtr new_AsyncAcquireGameServerSessionTicketResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E76B0", Offset = "0x3E5EB0", Length = "0x78")]
	[Token(Token = "0x6001E90")]
	public static extern void delete_AsyncAcquireGameServerSessionTicketResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x3FC530", Offset = "0x3FAD30", Length = "0x65")]
	public static extern IntPtr new_GameServerStartSessionWithPlayerResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x38B860", Offset = "0x38A060", Length = "0x87")]
	public static extern void GameServerStartSessionWithPlayerResponse_remote_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x38B7E0", Offset = "0x389FE0", Length = "0x78")]
	public static extern IntPtr GameServerStartSessionWithPlayerResponse_remote_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC5A0", Offset = "0x3FADA0", Length = "0x78")]
	[Token(Token = "0x6001E94")]
	public static extern IntPtr new_GameServerStartSessionWithPlayerResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E94B0", Offset = "0x3E7CB0", Length = "0x78")]
	[Token(Token = "0x6001E95")]
	public static extern void delete_GameServerStartSessionWithPlayerResponse(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB090", Offset = "0x3F9890", Length = "0x65")]
	[Token(Token = "0x6001E96")]
	public static extern IntPtr new_CreateGameServerResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3861C0", Offset = "0x3849C0", Length = "0x87")]
	[Token(Token = "0x6001E97")]
	public static extern void CreateGameServerResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E98")]
	[Address(RVA = "0x386140", Offset = "0x384940", Length = "0x78")]
	public static extern IntPtr CreateGameServerResult_game_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E99")]
	[Address(RVA = "0x3FB100", Offset = "0x3F9900", Length = "0x78")]
	public static extern IntPtr new_CreateGameServerResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E9A")]
	[Address(RVA = "0x3E8930", Offset = "0x3E7130", Length = "0x78")]
	public static extern void delete_CreateGameServerResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4179B0", Offset = "0x4161B0", Length = "0x65")]
	[Token(Token = "0x6001E9B")]
	public static extern IntPtr new_SetGameServerMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x3E3120", Offset = "0x3E1920", Length = "0x87")]
	public static extern void SetGameServerMetadataResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001E9D")]
	[Address(RVA = "0x3E30A0", Offset = "0x3E18A0", Length = "0x78")]
	public static extern IntPtr SetGameServerMetadataResult_game_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417A20", Offset = "0x416220", Length = "0x78")]
	[Token(Token = "0x6001E9E")]
	public static extern IntPtr new_SetGameServerMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001E9F")]
	[Address(RVA = "0x3F7C30", Offset = "0x3F6430", Length = "0x78")]
	public static extern void delete_SetGameServerMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x3FC8F0", Offset = "0x3FB0F0", Length = "0x65")]
	public static extern IntPtr new_GetGameServerMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x38C410", Offset = "0x38AC10", Length = "0x87")]
	public static extern void GetGameServerMetadataResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EA2")]
	[Address(RVA = "0x38C390", Offset = "0x38AB90", Length = "0x78")]
	public static extern IntPtr GetGameServerMetadataResult_game_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38C520", Offset = "0x38AD20", Length = "0x87")]
	[Token(Token = "0x6001EA3")]
	public static extern void GetGameServerMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EA4")]
	[Address(RVA = "0x38C4A0", Offset = "0x38ACA0", Length = "0x78")]
	public static extern IntPtr GetGameServerMetadataResult_key_value_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC960", Offset = "0x3FB160", Length = "0x78")]
	[Token(Token = "0x6001EA5")]
	public static extern IntPtr new_GetGameServerMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E96B0", Offset = "0x3E7EB0", Length = "0x78")]
	[Token(Token = "0x6001EA6")]
	public static extern void delete_GetGameServerMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EA7")]
	[Address(RVA = "0x3FC440", Offset = "0x3FAC40", Length = "0x65")]
	public static extern IntPtr new_GameServerRegisterToServerListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x3FC4B0", Offset = "0x3FACB0", Length = "0x78")]
	public static extern IntPtr new_GameServerRegisterToServerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EA9")]
	[Address(RVA = "0x3E9430", Offset = "0x3E7C30", Length = "0x78")]
	public static extern void delete_GameServerRegisterToServerListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EAA")]
	[Address(RVA = "0x3FC9E0", Offset = "0x3FB1E0", Length = "0x65")]
	public static extern IntPtr new_GetGameServerPlayerListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001EAB")]
	[Address(RVA = "0x38C6B0", Offset = "0x38AEB0", Length = "0x87")]
	public static extern void GetGameServerPlayerListResult_game_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x38C630", Offset = "0x38AE30", Length = "0x78")]
	public static extern IntPtr GetGameServerPlayerListResult_game_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x38C7C0", Offset = "0x38AFC0", Length = "0x87")]
	public static extern void GetGameServerPlayerListResult_server_player_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38C740", Offset = "0x38AF40", Length = "0x78")]
	[Token(Token = "0x6001EAE")]
	public static extern IntPtr GetGameServerPlayerListResult_server_player_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EAF")]
	[Address(RVA = "0x3FCA50", Offset = "0x3FB250", Length = "0x78")]
	public static extern IntPtr new_GetGameServerPlayerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EB0")]
	[Address(RVA = "0x3E9730", Offset = "0x3E7F30", Length = "0x78")]
	public static extern void delete_GetGameServerPlayerListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x3FC800", Offset = "0x3FB000", Length = "0x65")]
	public static extern IntPtr new_GetGameServerListResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38C170", Offset = "0x38A970", Length = "0x85")]
	[Token(Token = "0x6001EB2")]
	public static extern void GetGameServerListResult_start_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x38C0F0", Offset = "0x38A8F0", Length = "0x78")]
	[Token(Token = "0x6001EB3")]
	public static extern uint GetGameServerListResult_start_index_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38BF50", Offset = "0x38A750", Length = "0x85")]
	[Token(Token = "0x6001EB4")]
	public static extern void GetGameServerListResult_end_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EB5")]
	[Address(RVA = "0x38BED0", Offset = "0x38A6D0", Length = "0x78")]
	public static extern uint GetGameServerListResult_end_index_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38C280", Offset = "0x38AA80", Length = "0x85")]
	[Token(Token = "0x6001EB6")]
	public static extern void GetGameServerListResult_total_num_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EB7")]
	[Address(RVA = "0x38C200", Offset = "0x38AA00", Length = "0x78")]
	public static extern uint GetGameServerListResult_total_num_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EB8")]
	[Address(RVA = "0x38C060", Offset = "0x38A860", Length = "0x87")]
	public static extern void GetGameServerListResult_server_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38BFE0", Offset = "0x38A7E0", Length = "0x78")]
	[Token(Token = "0x6001EB9")]
	public static extern IntPtr GetGameServerListResult_server_info_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC870", Offset = "0x3FB070", Length = "0x78")]
	[Token(Token = "0x6001EBA")]
	public static extern IntPtr new_GetGameServerListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E9630", Offset = "0x3E7E30", Length = "0x78")]
	[Token(Token = "0x6001EBB")]
	public static extern void delete_GetGameServerListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EBC")]
	[Address(RVA = "0x3F90B0", Offset = "0x3F78B0", Length = "0x65")]
	public static extern IntPtr new_AsyncGetFavoriteGameServersResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x37F250", Offset = "0x37DA50", Length = "0x87")]
	[Token(Token = "0x6001EBD")]
	public static extern void AsyncGetFavoriteGameServersResult_server_id_array_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EBE")]
	[Address(RVA = "0x37F1D0", Offset = "0x37D9D0", Length = "0x78")]
	public static extern IntPtr AsyncGetFavoriteGameServersResult_server_id_array_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EBF")]
	[Address(RVA = "0x3F9120", Offset = "0x3F7920", Length = "0x78")]
	public static extern IntPtr new_AsyncGetFavoriteGameServersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EC0")]
	[Address(RVA = "0x3E7830", Offset = "0x3E6030", Length = "0x78")]
	public static extern void delete_AsyncGetFavoriteGameServersResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8ED0", Offset = "0x3F76D0", Length = "0x65")]
	[Token(Token = "0x6001EC1")]
	public static extern IntPtr new_AsyncAddFavoriteGameServerResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x37EF20", Offset = "0x37D720", Length = "0x87")]
	[Token(Token = "0x6001EC2")]
	public static extern void AsyncAddFavoriteGameServerResult_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37EEA0", Offset = "0x37D6A0", Length = "0x78")]
	[Token(Token = "0x6001EC3")]
	public static extern IntPtr AsyncAddFavoriteGameServerResult_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x3F8F40", Offset = "0x3F7740", Length = "0x78")]
	public static extern IntPtr new_AsyncAddFavoriteGameServerResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x3E7730", Offset = "0x3E5F30", Length = "0x78")]
	public static extern void delete_AsyncAddFavoriteGameServerResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x3F9A10", Offset = "0x3F8210", Length = "0x65")]
	public static extern IntPtr new_AsyncRemoveFavoriteGameServerResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x381220", Offset = "0x37FA20", Length = "0x87")]
	[Token(Token = "0x6001EC7")]
	public static extern void AsyncRemoveFavoriteGameServerResult_server_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3811A0", Offset = "0x37F9A0", Length = "0x78")]
	[Token(Token = "0x6001EC8")]
	public static extern IntPtr AsyncRemoveFavoriteGameServerResult_server_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EC9")]
	[Address(RVA = "0x3F9A80", Offset = "0x3F8280", Length = "0x78")]
	public static extern IntPtr new_AsyncRemoveFavoriteGameServerResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x3E7D30", Offset = "0x3E6530", Length = "0x78")]
	public static extern void delete_AsyncRemoveFavoriteGameServerResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x3FED80", Offset = "0x3FD580", Length = "0x65")]
	public static extern IntPtr new_PlayerPersonalInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x3A9CE0", Offset = "0x3A84E0", Length = "0x87")]
	public static extern void PlayerPersonalInfo_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001ECD")]
	[Address(RVA = "0x3A9C60", Offset = "0x3A8460", Length = "0x78")]
	public static extern IntPtr PlayerPersonalInfo_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ECE")]
	[Address(RVA = "0x3A9BD0", Offset = "0x3A83D0", Length = "0x85")]
	public static extern void PlayerPersonalInfo_error_code_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9B50", Offset = "0x3A8350", Length = "0x78")]
	[Token(Token = "0x6001ECF")]
	public static extern int PlayerPersonalInfo_error_code_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x3A9DF0", Offset = "0x3A85F0", Length = "0x85")]
	public static extern void PlayerPersonalInfo_rail_level_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001ED1")]
	[Address(RVA = "0x3A9D70", Offset = "0x3A8570", Length = "0x78")]
	public static extern uint PlayerPersonalInfo_rail_level_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9F00", Offset = "0x3A8700", Length = "0x9B")]
	[Token(Token = "0x6001ED2")]
	public static extern void PlayerPersonalInfo_rail_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001ED3")]
	[Address(RVA = "0x3A9E80", Offset = "0x3A8680", Length = "0x78")]
	public static extern IntPtr PlayerPersonalInfo_rail_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9990", Offset = "0x3A8190", Length = "0x9B")]
	[Token(Token = "0x6001ED4")]
	public static extern void PlayerPersonalInfo_avatar_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9910", Offset = "0x3A8110", Length = "0x78")]
	[Token(Token = "0x6001ED5")]
	public static extern IntPtr PlayerPersonalInfo_avatar_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9AB0", Offset = "0x3A82B0", Length = "0x9B")]
	[Token(Token = "0x6001ED6")]
	public static extern void PlayerPersonalInfo_email_address_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9A30", Offset = "0x3A8230", Length = "0x78")]
	[Token(Token = "0x6001ED7")]
	public static extern IntPtr PlayerPersonalInfo_email_address_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001ED8")]
	[Address(RVA = "0x3FEDF0", Offset = "0x3FD5F0", Length = "0x78")]
	public static extern IntPtr new_PlayerPersonalInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC430", Offset = "0x3EAC30", Length = "0x78")]
	[Token(Token = "0x6001ED9")]
	public static extern void delete_PlayerPersonalInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412720", Offset = "0x410F20", Length = "0x65")]
	[Token(Token = "0x6001EDA")]
	public static extern IntPtr new_RailGetAuthenticateURLOptions__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D1120", Offset = "0x3CF920", Length = "0x9B")]
	[Token(Token = "0x6001EDB")]
	public static extern void RailGetAuthenticateURLOptions_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EDC")]
	[Address(RVA = "0x3D10A0", Offset = "0x3CF8A0", Length = "0x78")]
	public static extern IntPtr RailGetAuthenticateURLOptions_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D1000", Offset = "0x3CF800", Length = "0x9B")]
	[Token(Token = "0x6001EDD")]
	public static extern void RailGetAuthenticateURLOptions_oauth2_state_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0F80", Offset = "0x3CF780", Length = "0x78")]
	[Token(Token = "0x6001EDE")]
	public static extern IntPtr RailGetAuthenticateURLOptions_oauth2_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D0EF0", Offset = "0x3CF6F0", Length = "0x87")]
	[Token(Token = "0x6001EDF")]
	public static extern void RailGetAuthenticateURLOptions_client_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EE0")]
	[Address(RVA = "0x3D0E70", Offset = "0x3CF670", Length = "0x78")]
	public static extern ulong RailGetAuthenticateURLOptions_client_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412790", Offset = "0x410F90", Length = "0x78")]
	[Token(Token = "0x6001EE1")]
	public static extern IntPtr new_RailGetAuthenticateURLOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EE2")]
	[Address(RVA = "0x3F4FB0", Offset = "0x3F37B0", Length = "0x78")]
	public static extern void delete_RailGetAuthenticateURLOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EE3")]
	[Address(RVA = "0x3F8CF0", Offset = "0x3F74F0", Length = "0x65")]
	public static extern IntPtr new_AcquireSessionTicketResponse__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x37EC00", Offset = "0x37D400", Length = "0x87")]
	[Token(Token = "0x6001EE4")]
	public static extern void AcquireSessionTicketResponse_session_ticket_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37EB80", Offset = "0x37D380", Length = "0x78")]
	[Token(Token = "0x6001EE5")]
	public static extern IntPtr AcquireSessionTicketResponse_session_ticket_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8D60", Offset = "0x3F7560", Length = "0x78")]
	[Token(Token = "0x6001EE6")]
	public static extern IntPtr new_AcquireSessionTicketResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7630", Offset = "0x3E5E30", Length = "0x78")]
	[Token(Token = "0x6001EE7")]
	public static extern void delete_AcquireSessionTicketResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x418750", Offset = "0x416F50", Length = "0x65")]
	public static extern IntPtr new_StartSessionWithPlayerResponse__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E4C70", Offset = "0x3E3470", Length = "0x87")]
	[Token(Token = "0x6001EE9")]
	public static extern void StartSessionWithPlayerResponse_remote_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E4BF0", Offset = "0x3E33F0", Length = "0x78")]
	[Token(Token = "0x6001EEA")]
	public static extern IntPtr StartSessionWithPlayerResponse_remote_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x4187C0", Offset = "0x416FC0", Length = "0x78")]
	public static extern IntPtr new_StartSessionWithPlayerResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8330", Offset = "0x3F6B30", Length = "0x78")]
	[Token(Token = "0x6001EEC")]
	public static extern void delete_StartSessionWithPlayerResponse(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FEC90", Offset = "0x3FD490", Length = "0x65")]
	[Token(Token = "0x6001EED")]
	public static extern IntPtr new_PlayerGetGamePurchaseKeyResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x3A9870", Offset = "0x3A8070", Length = "0x9B")]
	public static extern void PlayerGetGamePurchaseKeyResult_purchase_key_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A97F0", Offset = "0x3A7FF0", Length = "0x78")]
	[Token(Token = "0x6001EEF")]
	public static extern IntPtr PlayerGetGamePurchaseKeyResult_purchase_key_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FED00", Offset = "0x3FD500", Length = "0x78")]
	[Token(Token = "0x6001EF0")]
	public static extern IntPtr new_PlayerGetGamePurchaseKeyResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC3B0", Offset = "0x3EABB0", Length = "0x78")]
	[Token(Token = "0x6001EF1")]
	public static extern void delete_PlayerGetGamePurchaseKeyResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FF320", Offset = "0x3FDB20", Length = "0x65")]
	[Token(Token = "0x6001EF2")]
	public static extern IntPtr new_QueryPlayerBannedStatus__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001EF3")]
	[Address(RVA = "0x3AA7F0", Offset = "0x3A8FF0", Length = "0x85")]
	public static extern void QueryPlayerBannedStatus_status_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EF4")]
	[Address(RVA = "0x3AA770", Offset = "0x3A8F70", Length = "0x78")]
	public static extern int QueryPlayerBannedStatus_status_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EF5")]
	[Address(RVA = "0x3FF390", Offset = "0x3FDB90", Length = "0x78")]
	public static extern IntPtr new_QueryPlayerBannedStatus__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EF6")]
	[Address(RVA = "0x3EC730", Offset = "0x3EAF30", Length = "0x78")]
	public static extern void delete_QueryPlayerBannedStatus(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EF7")]
	[Address(RVA = "0x3FC710", Offset = "0x3FAF10", Length = "0x65")]
	public static extern IntPtr new_GetAuthenticateURLResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38BCA0", Offset = "0x38A4A0", Length = "0x9B")]
	[Token(Token = "0x6001EF8")]
	public static extern void GetAuthenticateURLResult_source_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EF9")]
	[Address(RVA = "0x38BC20", Offset = "0x38A420", Length = "0x78")]
	public static extern IntPtr GetAuthenticateURLResult_source_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38BB80", Offset = "0x38A380", Length = "0x9B")]
	[Token(Token = "0x6001EFA")]
	public static extern void GetAuthenticateURLResult_authenticate_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38BB00", Offset = "0x38A300", Length = "0x78")]
	[Token(Token = "0x6001EFB")]
	public static extern IntPtr GetAuthenticateURLResult_authenticate_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38BDC0", Offset = "0x38A5C0", Length = "0x85")]
	[Token(Token = "0x6001EFC")]
	public static extern void GetAuthenticateURLResult_ticket_expire_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001EFD")]
	[Address(RVA = "0x38BD40", Offset = "0x38A540", Length = "0x78")]
	public static extern uint GetAuthenticateURLResult_ticket_expire_time_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC780", Offset = "0x3FAF80", Length = "0x78")]
	[Token(Token = "0x6001EFE")]
	public static extern IntPtr new_GetAuthenticateURLResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001EFF")]
	[Address(RVA = "0x3E95B0", Offset = "0x3E7DB0", Length = "0x78")]
	public static extern void delete_GetAuthenticateURLResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F00")]
	[Address(RVA = "0x3FF500", Offset = "0x3FDD00", Length = "0x65")]
	public static extern IntPtr new_RailAntiAddictionGameOnlineTimeChanged__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F01")]
	[Address(RVA = "0x3AAB80", Offset = "0x3A9380", Length = "0x85")]
	public static extern void RailAntiAddictionGameOnlineTimeChanged_game_online_time_count_minutes_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F02")]
	[Address(RVA = "0x3AAB00", Offset = "0x3A9300", Length = "0x78")]
	public static extern uint RailAntiAddictionGameOnlineTimeChanged_game_online_time_count_minutes_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F03")]
	[Address(RVA = "0x3FF570", Offset = "0x3FDD70", Length = "0x78")]
	public static extern IntPtr new_RailAntiAddictionGameOnlineTimeChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC830", Offset = "0x3EB030", Length = "0x78")]
	[Token(Token = "0x6001F04")]
	public static extern void delete_RailAntiAddictionGameOnlineTimeChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F05")]
	[Address(RVA = "0x412810", Offset = "0x411010", Length = "0x65")]
	public static extern IntPtr new_RailGetEncryptedGameTicketResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D12C0", Offset = "0x3CFAC0", Length = "0x9B")]
	[Token(Token = "0x6001F06")]
	public static extern void RailGetEncryptedGameTicketResult_encrypted_game_ticket_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D1240", Offset = "0x3CFA40", Length = "0x78")]
	[Token(Token = "0x6001F07")]
	public static extern IntPtr RailGetEncryptedGameTicketResult_encrypted_game_ticket_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F08")]
	[Address(RVA = "0x412880", Offset = "0x411080", Length = "0x78")]
	public static extern IntPtr new_RailGetEncryptedGameTicketResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F09")]
	[Address(RVA = "0x3F5030", Offset = "0x3F3830", Length = "0x78")]
	public static extern void delete_RailGetEncryptedGameTicketResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F0A")]
	[Address(RVA = "0x4129F0", Offset = "0x4111F0", Length = "0x65")]
	public static extern IntPtr new_RailGetPlayerMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D1700", Offset = "0x3CFF00", Length = "0x87")]
	[Token(Token = "0x6001F0B")]
	public static extern void RailGetPlayerMetadataResult_key_values_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F0C")]
	[Address(RVA = "0x3D1680", Offset = "0x3CFE80", Length = "0x78")]
	public static extern IntPtr RailGetPlayerMetadataResult_key_values_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F0D")]
	[Address(RVA = "0x412A60", Offset = "0x411260", Length = "0x78")]
	public static extern IntPtr new_RailGetPlayerMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F0E")]
	[Address(RVA = "0x3F5130", Offset = "0x3F3930", Length = "0x78")]
	public static extern void delete_RailGetPlayerMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8BA0", Offset = "0x3F73A0", Length = "0x65")]
	[Token(Token = "0x6001F0F")]
	public static extern uint kRailMaxQueryPlayedWithFriendsTimeLimit_get();

	[PreserveSig]
	[Token(Token = "0x6001F10")]
	[Address(RVA = "0x413AD0", Offset = "0x4122D0", Length = "0x65")]
	public static extern IntPtr new_RailKeyValueResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F11")]
	[Address(RVA = "0x3D3F20", Offset = "0x3D2720", Length = "0x85")]
	public static extern void RailKeyValueResult_error_code_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D3EA0", Offset = "0x3D26A0", Length = "0x78")]
	[Token(Token = "0x6001F12")]
	public static extern int RailKeyValueResult_error_code_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D4030", Offset = "0x3D2830", Length = "0x9B")]
	[Token(Token = "0x6001F13")]
	public static extern void RailKeyValueResult_key_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D3FB0", Offset = "0x3D27B0", Length = "0x78")]
	[Token(Token = "0x6001F14")]
	public static extern IntPtr RailKeyValueResult_key_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F15")]
	[Address(RVA = "0x3D4150", Offset = "0x3D2950", Length = "0x9B")]
	public static extern void RailKeyValueResult_value_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D40D0", Offset = "0x3D28D0", Length = "0x78")]
	[Token(Token = "0x6001F16")]
	public static extern IntPtr RailKeyValueResult_value_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413B40", Offset = "0x412340", Length = "0x78")]
	[Token(Token = "0x6001F17")]
	public static extern IntPtr new_RailKeyValueResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5A30", Offset = "0x3F4230", Length = "0x78")]
	[Token(Token = "0x6001F18")]
	public static extern void delete_RailKeyValueResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415E80", Offset = "0x414680", Length = "0x65")]
	[Token(Token = "0x6001F19")]
	public static extern IntPtr new_RailUserPlayedWith__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x3DCA30", Offset = "0x3DB230", Length = "0x87")]
	public static extern void RailUserPlayedWith_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x3DC9B0", Offset = "0x3DB1B0", Length = "0x78")]
	public static extern IntPtr RailUserPlayedWith_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x3DCB40", Offset = "0x3DB340", Length = "0x9B")]
	public static extern void RailUserPlayedWith_user_rich_content_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DCAC0", Offset = "0x3DB2C0", Length = "0x78")]
	[Token(Token = "0x6001F1D")]
	public static extern IntPtr RailUserPlayedWith_user_rich_content_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415EF0", Offset = "0x4146F0", Length = "0x78")]
	[Token(Token = "0x6001F1E")]
	public static extern IntPtr new_RailUserPlayedWith__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F1F")]
	[Address(RVA = "0x3F6DB0", Offset = "0x3F55B0", Length = "0x78")]
	public static extern void delete_RailUserPlayedWith(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F20")]
	[Address(RVA = "0x411460", Offset = "0x40FC60", Length = "0x65")]
	public static extern IntPtr new_RailFriendPlayedGameInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F21")]
	[Address(RVA = "0x3CEBA0", Offset = "0x3CD3A0", Length = "0x86")]
	public static extern void RailFriendPlayedGameInfo_in_game_server_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CEB20", Offset = "0x3CD320", Length = "0x7D")]
	[Token(Token = "0x6001F22")]
	public static extern bool RailFriendPlayedGameInfo_in_game_server_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F23")]
	[Address(RVA = "0x3CECB0", Offset = "0x3CD4B0", Length = "0x86")]
	public static extern void RailFriendPlayedGameInfo_in_room_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CEC30", Offset = "0x3CD430", Length = "0x7D")]
	[Token(Token = "0x6001F24")]
	public static extern bool RailFriendPlayedGameInfo_in_room_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CEA90", Offset = "0x3CD290", Length = "0x87")]
	[Token(Token = "0x6001F25")]
	public static extern void RailFriendPlayedGameInfo_game_server_id_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CEA10", Offset = "0x3CD210", Length = "0x78")]
	[Token(Token = "0x6001F26")]
	public static extern IntPtr RailFriendPlayedGameInfo_game_server_id_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CEDC0", Offset = "0x3CD5C0", Length = "0x87")]
	[Token(Token = "0x6001F27")]
	public static extern void RailFriendPlayedGameInfo_room_id_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CED40", Offset = "0x3CD540", Length = "0x78")]
	[Token(Token = "0x6001F28")]
	public static extern IntPtr RailFriendPlayedGameInfo_room_id_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F29")]
	[Address(RVA = "0x3CE760", Offset = "0x3CCF60", Length = "0x87")]
	public static extern void RailFriendPlayedGameInfo_friend_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F2A")]
	[Address(RVA = "0x3CE6E0", Offset = "0x3CCEE0", Length = "0x78")]
	public static extern IntPtr RailFriendPlayedGameInfo_friend_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F2B")]
	[Address(RVA = "0x3CE980", Offset = "0x3CD180", Length = "0x87")]
	public static extern void RailFriendPlayedGameInfo_game_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CE900", Offset = "0x3CD100", Length = "0x78")]
	[Token(Token = "0x6001F2C")]
	public static extern IntPtr RailFriendPlayedGameInfo_game_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F2D")]
	[Address(RVA = "0x3CE870", Offset = "0x3CD070", Length = "0x85")]
	public static extern void RailFriendPlayedGameInfo_friend_played_game_play_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F2E")]
	[Address(RVA = "0x3CE7F0", Offset = "0x3CCFF0", Length = "0x78")]
	public static extern int RailFriendPlayedGameInfo_friend_played_game_play_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F2F")]
	[Address(RVA = "0x4114D0", Offset = "0x40FCD0", Length = "0x78")]
	public static extern IntPtr new_RailFriendPlayedGameInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F30")]
	[Address(RVA = "0x3F45B0", Offset = "0x3F2DB0", Length = "0x78")]
	public static extern void delete_RailFriendPlayedGameInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4142C0", Offset = "0x412AC0", Length = "0x65")]
	[Token(Token = "0x6001F31")]
	public static extern IntPtr new_RailPlayedWithFriendsTimeItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D5B50", Offset = "0x3D4350", Length = "0x85")]
	[Token(Token = "0x6001F32")]
	public static extern void RailPlayedWithFriendsTimeItem_play_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D5AD0", Offset = "0x3D42D0", Length = "0x78")]
	[Token(Token = "0x6001F33")]
	public static extern uint RailPlayedWithFriendsTimeItem_play_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F34")]
	[Address(RVA = "0x3D5C60", Offset = "0x3D4460", Length = "0x87")]
	public static extern void RailPlayedWithFriendsTimeItem_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F35")]
	[Address(RVA = "0x3D5BE0", Offset = "0x3D43E0", Length = "0x78")]
	public static extern IntPtr RailPlayedWithFriendsTimeItem_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F36")]
	[Address(RVA = "0x414330", Offset = "0x412B30", Length = "0x78")]
	public static extern IntPtr new_RailPlayedWithFriendsTimeItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F37")]
	[Address(RVA = "0x3F5EB0", Offset = "0x3F46B0", Length = "0x78")]
	public static extern void delete_RailPlayedWithFriendsTimeItem(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4141D0", Offset = "0x4129D0", Length = "0x65")]
	[Token(Token = "0x6001F38")]
	public static extern IntPtr new_RailPlayedWithFriendsGameItem__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D5930", Offset = "0x3D4130", Length = "0x87")]
	[Token(Token = "0x6001F39")]
	public static extern void RailPlayedWithFriendsGameItem_game_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F3A")]
	[Address(RVA = "0x3D58B0", Offset = "0x3D40B0", Length = "0x78")]
	public static extern IntPtr RailPlayedWithFriendsGameItem_game_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F3B")]
	[Address(RVA = "0x3D5A40", Offset = "0x3D4240", Length = "0x87")]
	public static extern void RailPlayedWithFriendsGameItem_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F3C")]
	[Address(RVA = "0x3D59C0", Offset = "0x3D41C0", Length = "0x78")]
	public static extern IntPtr RailPlayedWithFriendsGameItem_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F3D")]
	[Address(RVA = "0x414240", Offset = "0x412A40", Length = "0x78")]
	public static extern IntPtr new_RailPlayedWithFriendsGameItem__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F3E")]
	[Address(RVA = "0x3F5E30", Offset = "0x3F4630", Length = "0x78")]
	public static extern void delete_RailPlayedWithFriendsGameItem(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x411550", Offset = "0x40FD50", Length = "0x65")]
	public static extern IntPtr new_RailFriendsAddFriendRequest__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x3CEED0", Offset = "0x3CD6D0", Length = "0x87")]
	public static extern void RailFriendsAddFriendRequest_target_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F41")]
	[Address(RVA = "0x3CEE50", Offset = "0x3CD650", Length = "0x78")]
	public static extern IntPtr RailFriendsAddFriendRequest_target_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F42")]
	[Address(RVA = "0x4115C0", Offset = "0x40FDC0", Length = "0x78")]
	public static extern IntPtr new_RailFriendsAddFriendRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F43")]
	[Address(RVA = "0x3F4630", Offset = "0x3F2E30", Length = "0x78")]
	public static extern void delete_RailFriendsAddFriendRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411370", Offset = "0x40FB70", Length = "0x65")]
	[Token(Token = "0x6001F44")]
	public static extern IntPtr new_RailFriendOnLineState__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F45")]
	[Address(RVA = "0x3CE540", Offset = "0x3CCD40", Length = "0x87")]
	public static extern void RailFriendOnLineState_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F46")]
	[Address(RVA = "0x3CE4C0", Offset = "0x3CCCC0", Length = "0x78")]
	public static extern IntPtr RailFriendOnLineState_friend_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F47")]
	[Address(RVA = "0x3CE430", Offset = "0x3CCC30", Length = "0x85")]
	public static extern void RailFriendOnLineState_friend_online_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F48")]
	[Address(RVA = "0x3CE3B0", Offset = "0x3CCBB0", Length = "0x78")]
	public static extern int RailFriendOnLineState_friend_online_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F49")]
	[Address(RVA = "0x3CE650", Offset = "0x3CCE50", Length = "0x85")]
	public static extern void RailFriendOnLineState_game_define_game_playing_state_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F4A")]
	[Address(RVA = "0x3CE5D0", Offset = "0x3CCDD0", Length = "0x78")]
	public static extern uint RailFriendOnLineState_game_define_game_playing_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4113E0", Offset = "0x40FBE0", Length = "0x78")]
	[Token(Token = "0x6001F4B")]
	public static extern IntPtr new_RailFriendOnLineState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4530", Offset = "0x3F2D30", Length = "0x78")]
	[Token(Token = "0x6001F4C")]
	public static extern void delete_RailFriendOnLineState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411190", Offset = "0x40F990", Length = "0x65")]
	[Token(Token = "0x6001F4D")]
	public static extern IntPtr new_RailFriendInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CDEE0", Offset = "0x3CC6E0", Length = "0x87")]
	[Token(Token = "0x6001F4E")]
	public static extern void RailFriendInfo_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CDE60", Offset = "0x3CC660", Length = "0x78")]
	[Token(Token = "0x6001F4F")]
	public static extern IntPtr RailFriendInfo_friend_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F50")]
	[Address(RVA = "0x3CDFF0", Offset = "0x3CC7F0", Length = "0x85")]
	public static extern void RailFriendInfo_friend_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F51")]
	[Address(RVA = "0x3CDF70", Offset = "0x3CC770", Length = "0x78")]
	public static extern int RailFriendInfo_friend_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CE100", Offset = "0x3CC900", Length = "0x87")]
	[Token(Token = "0x6001F52")]
	public static extern void RailFriendInfo_online_state_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CE080", Offset = "0x3CC880", Length = "0x78")]
	[Token(Token = "0x6001F53")]
	public static extern IntPtr RailFriendInfo_online_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411200", Offset = "0x40FA00", Length = "0x78")]
	[Token(Token = "0x6001F54")]
	public static extern IntPtr new_RailFriendInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F55")]
	[Address(RVA = "0x3F4430", Offset = "0x3F2C30", Length = "0x78")]
	public static extern void delete_RailFriendInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F56")]
	[Address(RVA = "0x411280", Offset = "0x40FA80", Length = "0x65")]
	public static extern IntPtr new_RailFriendMetadata__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CE210", Offset = "0x3CCA10", Length = "0x87")]
	[Token(Token = "0x6001F57")]
	public static extern void RailFriendMetadata_friend_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CE190", Offset = "0x3CC990", Length = "0x78")]
	[Token(Token = "0x6001F58")]
	public static extern IntPtr RailFriendMetadata_friend_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CE320", Offset = "0x3CCB20", Length = "0x87")]
	[Token(Token = "0x6001F59")]
	public static extern void RailFriendMetadata_metadatas_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F5A")]
	[Address(RVA = "0x3CE2A0", Offset = "0x3CCAA0", Length = "0x78")]
	public static extern IntPtr RailFriendMetadata_metadatas_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4112F0", Offset = "0x40FAF0", Length = "0x78")]
	[Token(Token = "0x6001F5B")]
	public static extern IntPtr new_RailFriendMetadata__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F5C")]
	[Address(RVA = "0x3F44B0", Offset = "0x3F2CB0", Length = "0x78")]
	public static extern void delete_RailFriendMetadata(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F5D")]
	[Address(RVA = "0x412180", Offset = "0x410980", Length = "0x65")]
	public static extern IntPtr new_RailFriendsSetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4121F0", Offset = "0x4109F0", Length = "0x78")]
	[Token(Token = "0x6001F5E")]
	public static extern IntPtr new_RailFriendsSetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F5F")]
	[Address(RVA = "0x3F4CB0", Offset = "0x3F34B0", Length = "0x78")]
	public static extern void delete_RailFriendsSetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411910", Offset = "0x410110", Length = "0x65")]
	[Token(Token = "0x6001F60")]
	public static extern IntPtr new_RailFriendsGetMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CF520", Offset = "0x3CDD20", Length = "0x87")]
	[Token(Token = "0x6001F61")]
	public static extern void RailFriendsGetMetadataResult_friend_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CF4A0", Offset = "0x3CDCA0", Length = "0x78")]
	[Token(Token = "0x6001F62")]
	public static extern IntPtr RailFriendsGetMetadataResult_friend_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CF630", Offset = "0x3CDE30", Length = "0x87")]
	[Token(Token = "0x6001F63")]
	public static extern void RailFriendsGetMetadataResult_friend_kvs_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CF5B0", Offset = "0x3CDDB0", Length = "0x78")]
	[Token(Token = "0x6001F64")]
	public static extern IntPtr RailFriendsGetMetadataResult_friend_kvs_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F65")]
	[Address(RVA = "0x411980", Offset = "0x410180", Length = "0x78")]
	public static extern IntPtr new_RailFriendsGetMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4830", Offset = "0x3F3030", Length = "0x78")]
	[Token(Token = "0x6001F66")]
	public static extern void delete_RailFriendsGetMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411730", Offset = "0x40FF30", Length = "0x65")]
	[Token(Token = "0x6001F67")]
	public static extern IntPtr new_RailFriendsClearMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x4117A0", Offset = "0x40FFA0", Length = "0x78")]
	[Token(Token = "0x6001F68")]
	public static extern IntPtr new_RailFriendsClearMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4730", Offset = "0x3F2F30", Length = "0x78")]
	[Token(Token = "0x6001F69")]
	public static extern void delete_RailFriendsClearMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411820", Offset = "0x410020", Length = "0x65")]
	[Token(Token = "0x6001F6A")]
	public static extern IntPtr new_RailFriendsGetInviteCommandLine__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x3CF270", Offset = "0x3CDA70", Length = "0x87")]
	public static extern void RailFriendsGetInviteCommandLine_friend_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CF1F0", Offset = "0x3CD9F0", Length = "0x78")]
	[Token(Token = "0x6001F6C")]
	public static extern IntPtr RailFriendsGetInviteCommandLine_friend_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x3CF380", Offset = "0x3CDB80", Length = "0x9B")]
	public static extern void RailFriendsGetInviteCommandLine_invite_command_line_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CF300", Offset = "0x3CDB00", Length = "0x78")]
	[Token(Token = "0x6001F6E")]
	public static extern IntPtr RailFriendsGetInviteCommandLine_invite_command_line_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x411890", Offset = "0x410090", Length = "0x78")]
	public static extern IntPtr new_RailFriendsGetInviteCommandLine__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F47B0", Offset = "0x3F2FB0", Length = "0x78")]
	[Token(Token = "0x6001F70")]
	public static extern void delete_RailFriendsGetInviteCommandLine(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412090", Offset = "0x410890", Length = "0x65")]
	[Token(Token = "0x6001F71")]
	public static extern IntPtr new_RailFriendsReportPlayedWithUserListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x412100", Offset = "0x410900", Length = "0x78")]
	public static extern IntPtr new_RailFriendsReportPlayedWithUserListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x3F4C30", Offset = "0x3F3430", Length = "0x78")]
	public static extern void delete_RailFriendsReportPlayedWithUserListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411A00", Offset = "0x410200", Length = "0x65")]
	[Token(Token = "0x6001F74")]
	public static extern IntPtr new_RailFriendsListChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x411A70", Offset = "0x410270", Length = "0x78")]
	[Token(Token = "0x6001F75")]
	public static extern IntPtr new_RailFriendsListChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F48B0", Offset = "0x3F30B0", Length = "0x78")]
	[Token(Token = "0x6001F76")]
	public static extern void delete_RailFriendsListChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x411CD0", Offset = "0x4104D0", Length = "0x65")]
	public static extern IntPtr new_RailFriendsQueryFriendPlayedGamesResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CFB60", Offset = "0x3CE360", Length = "0x87")]
	[Token(Token = "0x6001F78")]
	public static extern void RailFriendsQueryFriendPlayedGamesResult_friend_played_games_info_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x3CFAE0", Offset = "0x3CE2E0", Length = "0x78")]
	public static extern IntPtr RailFriendsQueryFriendPlayedGamesResult_friend_played_games_info_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411D40", Offset = "0x410540", Length = "0x78")]
	[Token(Token = "0x6001F7A")]
	public static extern IntPtr new_RailFriendsQueryFriendPlayedGamesResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x3F4A30", Offset = "0x3F3230", Length = "0x78")]
	public static extern void delete_RailFriendsQueryFriendPlayedGamesResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x411EB0", Offset = "0x4106B0", Length = "0x65")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F7D")]
	[Address(RVA = "0x3CFE80", Offset = "0x3CE680", Length = "0x87")]
	public static extern void RailFriendsQueryPlayedWithFriendsListResult_played_with_friends_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F7E")]
	[Address(RVA = "0x3CFE00", Offset = "0x3CE600", Length = "0x78")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsListResult_played_with_friends_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F7F")]
	[Address(RVA = "0x411F20", Offset = "0x410720", Length = "0x78")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F80")]
	[Address(RVA = "0x3F4B30", Offset = "0x3F3330", Length = "0x78")]
	public static extern void delete_RailFriendsQueryPlayedWithFriendsListResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F81")]
	[Address(RVA = "0x411FA0", Offset = "0x4107A0", Length = "0x65")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsTimeResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D0010", Offset = "0x3CE810", Length = "0x87")]
	[Token(Token = "0x6001F82")]
	public static extern void RailFriendsQueryPlayedWithFriendsTimeResult_played_with_friends_time_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CFF90", Offset = "0x3CE790", Length = "0x78")]
	[Token(Token = "0x6001F83")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsTimeResult_played_with_friends_time_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F84")]
	[Address(RVA = "0x412010", Offset = "0x410810", Length = "0x78")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsTimeResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F85")]
	[Address(RVA = "0x3F4BB0", Offset = "0x3F33B0", Length = "0x78")]
	public static extern void delete_RailFriendsQueryPlayedWithFriendsTimeResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411DC0", Offset = "0x4105C0", Length = "0x65")]
	[Token(Token = "0x6001F86")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsGamesResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CFCF0", Offset = "0x3CE4F0", Length = "0x87")]
	[Token(Token = "0x6001F87")]
	public static extern void RailFriendsQueryPlayedWithFriendsGamesResult_played_with_friends_game_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F88")]
	[Address(RVA = "0x3CFC70", Offset = "0x3CE470", Length = "0x78")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsGamesResult_played_with_friends_game_list_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411E30", Offset = "0x410630", Length = "0x78")]
	[Token(Token = "0x6001F89")]
	public static extern IntPtr new_RailFriendsQueryPlayedWithFriendsGamesResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4AB0", Offset = "0x3F32B0", Length = "0x78")]
	[Token(Token = "0x6001F8A")]
	public static extern void delete_RailFriendsQueryPlayedWithFriendsGamesResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411640", Offset = "0x40FE40", Length = "0x65")]
	[Token(Token = "0x6001F8B")]
	public static extern IntPtr new_RailFriendsAddFriendResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CF060", Offset = "0x3CD860", Length = "0x87")]
	[Token(Token = "0x6001F8C")]
	public static extern void RailFriendsAddFriendResult_target_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CEFE0", Offset = "0x3CD7E0", Length = "0x78")]
	[Token(Token = "0x6001F8D")]
	public static extern IntPtr RailFriendsAddFriendResult_target_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x4116B0", Offset = "0x40FEB0", Length = "0x78")]
	public static extern IntPtr new_RailFriendsAddFriendResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F46B0", Offset = "0x3F2EB0", Length = "0x78")]
	[Token(Token = "0x6001F8F")]
	public static extern void delete_RailFriendsAddFriendResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x411BE0", Offset = "0x4103E0", Length = "0x65")]
	[Token(Token = "0x6001F90")]
	public static extern IntPtr new_RailFriendsOnlineStateChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CF9D0", Offset = "0x3CE1D0", Length = "0x87")]
	[Token(Token = "0x6001F91")]
	public static extern void RailFriendsOnlineStateChanged_friend_online_state_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3CF950", Offset = "0x3CE150", Length = "0x78")]
	[Token(Token = "0x6001F92")]
	public static extern IntPtr RailFriendsOnlineStateChanged_friend_online_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x411C50", Offset = "0x410450", Length = "0x78")]
	public static extern IntPtr new_RailFriendsOnlineStateChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x3F49B0", Offset = "0x3F31B0", Length = "0x78")]
	public static extern void delete_RailFriendsOnlineStateChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x411AF0", Offset = "0x4102F0", Length = "0x65")]
	public static extern IntPtr new_RailFriendsMetadataChanged__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3CF840", Offset = "0x3CE040", Length = "0x87")]
	[Token(Token = "0x6001F96")]
	public static extern void RailFriendsMetadataChanged_friends_changed_metadata_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x3CF7C0", Offset = "0x3CDFC0", Length = "0x78")]
	public static extern IntPtr RailFriendsMetadataChanged_friends_changed_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x411B60", Offset = "0x410360", Length = "0x78")]
	public static extern IntPtr new_RailFriendsMetadataChanged__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4930", Offset = "0x3F3130", Length = "0x78")]
	[Token(Token = "0x6001F99")]
	public static extern void delete_RailFriendsMetadataChanged(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x405F70", Offset = "0x404770", Length = "0x65")]
	public static extern IntPtr new_RailCurrencyExchangeCoinRate__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0x3BBD20", Offset = "0x3BA520", Length = "0x9B")]
	public static extern void RailCurrencyExchangeCoinRate_currency_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x3BBCA0", Offset = "0x3BA4A0", Length = "0x78")]
	public static extern IntPtr RailCurrencyExchangeCoinRate_currency_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x3BBF50", Offset = "0x3BA750", Length = "0x85")]
	public static extern void RailCurrencyExchangeCoinRate_to_exchange_coins_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BBED0", Offset = "0x3BA6D0", Length = "0x78")]
	[Token(Token = "0x6001F9E")]
	public static extern uint RailCurrencyExchangeCoinRate_to_exchange_coins_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BBE40", Offset = "0x3BA640", Length = "0x88")]
	[Token(Token = "0x6001F9F")]
	public static extern void RailCurrencyExchangeCoinRate_pay_price_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x3BBDC0", Offset = "0x3BA5C0", Length = "0x78")]
	public static extern float RailCurrencyExchangeCoinRate_pay_price_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405FE0", Offset = "0x4047E0", Length = "0x78")]
	[Token(Token = "0x6001FA1")]
	public static extern IntPtr new_RailCurrencyExchangeCoinRate__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x3EE530", Offset = "0x3ECD30", Length = "0x78")]
	public static extern void delete_RailCurrencyExchangeCoinRate(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0x405CA0", Offset = "0x4044A0", Length = "0x65")]
	public static extern IntPtr new_RailCoinInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0x3BB420", Offset = "0x3B9C20", Length = "0x9B")]
	public static extern void RailCoinInfo_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0x3BB3A0", Offset = "0x3B9BA0", Length = "0x78")]
	public static extern IntPtr RailCoinInfo_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BAFB0", Offset = "0x3B97B0", Length = "0x9B")]
	[Token(Token = "0x6001FA6")]
	public static extern void RailCoinInfo_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x3BAF30", Offset = "0x3B9730", Length = "0x78")]
	public static extern IntPtr RailCoinInfo_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x3BB1E0", Offset = "0x3B99E0", Length = "0x9B")]
	public static extern void RailCoinInfo_icon_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x3BB160", Offset = "0x3B9960", Length = "0x78")]
	public static extern IntPtr RailCoinInfo_icon_url_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x3BB0D0", Offset = "0x3B98D0", Length = "0x87")]
	public static extern void RailCoinInfo_exchange_rate_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BB050", Offset = "0x3B9850", Length = "0x78")]
	[Token(Token = "0x6001FAB")]
	public static extern IntPtr RailCoinInfo_exchange_rate_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BAEA0", Offset = "0x3B96A0", Length = "0x85")]
	[Token(Token = "0x6001FAC")]
	public static extern void RailCoinInfo_coin_class_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x3BAE20", Offset = "0x3B9620", Length = "0x78")]
	public static extern uint RailCoinInfo_coin_class_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BB300", Offset = "0x3B9B00", Length = "0x9B")]
	[Token(Token = "0x6001FAE")]
	public static extern void RailCoinInfo_metadata_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x3BB280", Offset = "0x3B9A80", Length = "0x78")]
	public static extern IntPtr RailCoinInfo_metadata_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405D10", Offset = "0x404510", Length = "0x78")]
	[Token(Token = "0x6001FB0")]
	public static extern IntPtr new_RailCoinInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EE330", Offset = "0x3ECB30", Length = "0x78")]
	[Token(Token = "0x6001FB1")]
	public static extern void delete_RailCoinInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405D90", Offset = "0x404590", Length = "0x65")]
	[Token(Token = "0x6001FB2")]
	public static extern IntPtr new_RailCoins__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3BB760", Offset = "0x3B9F60", Length = "0x88")]
	[Token(Token = "0x6001FB3")]
	public static extern void RailCoins_total_price_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BB6E0", Offset = "0x3B9EE0", Length = "0x78")]
	[Token(Token = "0x6001FB4")]
	public static extern float RailCoins_total_price_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BB650", Offset = "0x3B9E50", Length = "0x85")]
	[Token(Token = "0x6001FB5")]
	public static extern void RailCoins_quantity_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BB5D0", Offset = "0x3B9DD0", Length = "0x78")]
	[Token(Token = "0x6001FB6")]
	public static extern uint RailCoins_quantity_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BB540", Offset = "0x3B9D40", Length = "0x85")]
	[Token(Token = "0x6001FB7")]
	public static extern void RailCoins_coin_class_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BB4C0", Offset = "0x3B9CC0", Length = "0x78")]
	[Token(Token = "0x6001FB8")]
	public static extern uint RailCoins_coin_class_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FB9")]
	[Address(RVA = "0x405E00", Offset = "0x404600", Length = "0x78")]
	public static extern IntPtr new_RailCoins__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FBA")]
	[Address(RVA = "0x3EE3B0", Offset = "0x3ECBB0", Length = "0x78")]
	public static extern void delete_RailCoins(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413170", Offset = "0x411970", Length = "0x65")]
	[Token(Token = "0x6001FBB")]
	public static extern IntPtr new_RailInGameCoinRequestCoinInfoResponse__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D2A50", Offset = "0x3D1250", Length = "0x87")]
	[Token(Token = "0x6001FBC")]
	public static extern void RailInGameCoinRequestCoinInfoResponse_coin_infos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D29D0", Offset = "0x3D11D0", Length = "0x78")]
	[Token(Token = "0x6001FBD")]
	public static extern IntPtr RailInGameCoinRequestCoinInfoResponse_coin_infos_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4131E0", Offset = "0x4119E0", Length = "0x78")]
	[Token(Token = "0x6001FBE")]
	public static extern IntPtr new_RailInGameCoinRequestCoinInfoResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x3F5530", Offset = "0x3F3D30", Length = "0x78")]
	public static extern void delete_RailInGameCoinRequestCoinInfoResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x413080", Offset = "0x411880", Length = "0x65")]
	public static extern IntPtr new_RailInGameCoinPurchaseCoinsResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x4130F0", Offset = "0x4118F0", Length = "0x78")]
	public static extern IntPtr new_RailInGameCoinPurchaseCoinsResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x3F54B0", Offset = "0x3F3CB0", Length = "0x78")]
	public static extern void delete_RailInGameCoinPurchaseCoinsResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x406150", Offset = "0x404950", Length = "0x65")]
	public static extern IntPtr new_RailDiscountInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3BC4B0", Offset = "0x3BACB0", Length = "0x88")]
	[Token(Token = "0x6001FC4")]
	public static extern void RailDiscountInfo_off_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BC430", Offset = "0x3BAC30", Length = "0x78")]
	[Token(Token = "0x6001FC5")]
	public static extern float RailDiscountInfo_off_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x3BC290", Offset = "0x3BAA90", Length = "0x88")]
	public static extern void RailDiscountInfo_discount_price_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x3BC210", Offset = "0x3BAA10", Length = "0x78")]
	public static extern float RailDiscountInfo_discount_price_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BC6D0", Offset = "0x3BAED0", Length = "0x85")]
	[Token(Token = "0x6001FC8")]
	public static extern void RailDiscountInfo_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BC650", Offset = "0x3BAE50", Length = "0x78")]
	[Token(Token = "0x6001FC9")]
	public static extern int RailDiscountInfo_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BC5C0", Offset = "0x3BADC0", Length = "0x85")]
	[Token(Token = "0x6001FCA")]
	public static extern void RailDiscountInfo_start_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BC540", Offset = "0x3BAD40", Length = "0x78")]
	[Token(Token = "0x6001FCB")]
	public static extern uint RailDiscountInfo_start_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x3BC3A0", Offset = "0x3BABA0", Length = "0x85")]
	public static extern void RailDiscountInfo_end_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x3BC320", Offset = "0x3BAB20", Length = "0x78")]
	public static extern uint RailDiscountInfo_end_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x4061C0", Offset = "0x4049C0", Length = "0x78")]
	public static extern IntPtr new_RailDiscountInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x3EE630", Offset = "0x3ECE30", Length = "0x78")]
	public static extern void delete_RailDiscountInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414590", Offset = "0x412D90", Length = "0x65")]
	[Token(Token = "0x6001FD0")]
	public static extern IntPtr new_RailPurchaseProductExtraInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x3D6970", Offset = "0x3D5170", Length = "0x9B")]
	public static extern void RailPurchaseProductExtraInfo_exchange_rule_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0x3D68F0", Offset = "0x3D50F0", Length = "0x78")]
	public static extern IntPtr RailPurchaseProductExtraInfo_exchange_rule_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0x3D6850", Offset = "0x3D5050", Length = "0x9B")]
	public static extern void RailPurchaseProductExtraInfo_bundle_rule_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D67D0", Offset = "0x3D4FD0", Length = "0x78")]
	[Token(Token = "0x6001FD4")]
	public static extern IntPtr RailPurchaseProductExtraInfo_bundle_rule_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x414600", Offset = "0x412E00", Length = "0x78")]
	public static extern IntPtr new_RailPurchaseProductExtraInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6030", Offset = "0x3F4830", Length = "0x78")]
	[Token(Token = "0x6001FD6")]
	public static extern void delete_RailPurchaseProductExtraInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414680", Offset = "0x412E80", Length = "0x65")]
	[Token(Token = "0x6001FD7")]
	public static extern IntPtr new_RailPurchaseProductInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D7350", Offset = "0x3D5B50", Length = "0x85")]
	[Token(Token = "0x6001FD8")]
	public static extern void RailPurchaseProductInfo_product_id_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x3D72D0", Offset = "0x3D5AD0", Length = "0x78")]
	public static extern uint RailPurchaseProductInfo_product_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x3D7010", Offset = "0x3D5810", Length = "0x86")]
	public static extern void RailPurchaseProductInfo_is_purchasable_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6F90", Offset = "0x3D5790", Length = "0x7D")]
	[Token(Token = "0x6001FDB")]
	public static extern bool RailPurchaseProductInfo_is_purchasable_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7120", Offset = "0x3D5920", Length = "0x9B")]
	[Token(Token = "0x6001FDC")]
	public static extern void RailPurchaseProductInfo_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x3D70A0", Offset = "0x3D58A0", Length = "0x78")]
	public static extern IntPtr RailPurchaseProductInfo_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FDE")]
	[Address(RVA = "0x3D6CD0", Offset = "0x3D54D0", Length = "0x9B")]
	public static extern void RailPurchaseProductInfo_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6C50", Offset = "0x3D5450", Length = "0x78")]
	[Token(Token = "0x6001FDF")]
	public static extern IntPtr RailPurchaseProductInfo_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FE0")]
	[Address(RVA = "0x3D6A90", Offset = "0x3D5290", Length = "0x9B")]
	public static extern void RailPurchaseProductInfo_category_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6A10", Offset = "0x3D5210", Length = "0x78")]
	[Token(Token = "0x6001FE1")]
	public static extern IntPtr RailPurchaseProductInfo_category_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7460", Offset = "0x3D5C60", Length = "0x9B")]
	[Token(Token = "0x6001FE2")]
	public static extern void RailPurchaseProductInfo_product_thumbnail_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D73E0", Offset = "0x3D5BE0", Length = "0x78")]
	[Token(Token = "0x6001FE3")]
	public static extern IntPtr RailPurchaseProductInfo_product_thumbnail_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FE4")]
	[Address(RVA = "0x3D6F00", Offset = "0x3D5700", Length = "0x87")]
	public static extern void RailPurchaseProductInfo_extra_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6E80", Offset = "0x3D5680", Length = "0x78")]
	[Token(Token = "0x6001FE5")]
	public static extern IntPtr RailPurchaseProductInfo_extra_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FE6")]
	[Address(RVA = "0x3D7240", Offset = "0x3D5A40", Length = "0x88")]
	public static extern void RailPurchaseProductInfo_original_price_set(IntPtr jarg1, float jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FE7")]
	[Address(RVA = "0x3D71C0", Offset = "0x3D59C0", Length = "0x78")]
	public static extern float RailPurchaseProductInfo_original_price_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x3D6BB0", Offset = "0x3D53B0", Length = "0x9B")]
	public static extern void RailPurchaseProductInfo_currency_type_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x3D6B30", Offset = "0x3D5330", Length = "0x78")]
	public static extern IntPtr RailPurchaseProductInfo_currency_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D6DF0", Offset = "0x3D55F0", Length = "0x87")]
	[Token(Token = "0x6001FEA")]
	public static extern void RailPurchaseProductInfo_discount_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6D70", Offset = "0x3D5570", Length = "0x78")]
	[Token(Token = "0x6001FEB")]
	public static extern IntPtr RailPurchaseProductInfo_discount_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x4146F0", Offset = "0x412EF0", Length = "0x78")]
	public static extern IntPtr new_RailPurchaseProductInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x3F60B0", Offset = "0x3F48B0", Length = "0x78")]
	public static extern void delete_RailPurchaseProductInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413620", Offset = "0x411E20", Length = "0x65")]
	[Token(Token = "0x6001FEE")]
	public static extern IntPtr new_RailInGamePurchaseRequestAllPurchasableProductsResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x3D3470", Offset = "0x3D1C70", Length = "0x87")]
	public static extern void RailInGamePurchaseRequestAllPurchasableProductsResponse_purchasable_products_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D33F0", Offset = "0x3D1BF0", Length = "0x78")]
	[Token(Token = "0x6001FF0")]
	public static extern IntPtr RailInGamePurchaseRequestAllPurchasableProductsResponse_purchasable_products_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413690", Offset = "0x411E90", Length = "0x78")]
	[Token(Token = "0x6001FF1")]
	public static extern IntPtr new_RailInGamePurchaseRequestAllPurchasableProductsResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F57B0", Offset = "0x3F3FB0", Length = "0x78")]
	[Token(Token = "0x6001FF2")]
	public static extern void delete_RailInGamePurchaseRequestAllPurchasableProductsResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x413530", Offset = "0x411D30", Length = "0x65")]
	public static extern IntPtr new_RailInGamePurchaseRequestAllProductsResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x3D32E0", Offset = "0x3D1AE0", Length = "0x87")]
	public static extern void RailInGamePurchaseRequestAllProductsResponse_all_products_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D3260", Offset = "0x3D1A60", Length = "0x78")]
	[Token(Token = "0x6001FF5")]
	public static extern IntPtr RailInGamePurchaseRequestAllProductsResponse_all_products_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4135A0", Offset = "0x411DA0", Length = "0x78")]
	[Token(Token = "0x6001FF6")]
	public static extern IntPtr new_RailInGamePurchaseRequestAllProductsResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x3F5730", Offset = "0x3F3F30", Length = "0x78")]
	public static extern void delete_RailInGamePurchaseRequestAllProductsResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x413350", Offset = "0x411B50", Length = "0x65")]
	public static extern IntPtr new_RailInGamePurchasePurchaseProductsResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x3D2E90", Offset = "0x3D1690", Length = "0x9B")]
	public static extern void RailInGamePurchasePurchaseProductsResponse_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x3D2E10", Offset = "0x3D1610", Length = "0x78")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsResponse_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D2D80", Offset = "0x3D1580", Length = "0x87")]
	[Token(Token = "0x6001FFB")]
	public static extern void RailInGamePurchasePurchaseProductsResponse_delivered_products_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D2D00", Offset = "0x3D1500", Length = "0x78")]
	[Token(Token = "0x6001FFC")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsResponse_delivered_products_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FFD")]
	[Address(RVA = "0x4133C0", Offset = "0x411BC0", Length = "0x78")]
	public static extern IntPtr new_RailInGamePurchasePurchaseProductsResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FFE")]
	[Address(RVA = "0x3F5630", Offset = "0x3F3E30", Length = "0x78")]
	public static extern void delete_RailInGamePurchasePurchaseProductsResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6001FFF")]
	[Address(RVA = "0x413440", Offset = "0x411C40", Length = "0x65")]
	public static extern IntPtr new_RailInGamePurchasePurchaseProductsToAssetsResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002000")]
	[Address(RVA = "0x3D3140", Offset = "0x3D1940", Length = "0x9B")]
	public static extern void RailInGamePurchasePurchaseProductsToAssetsResponse_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D30C0", Offset = "0x3D18C0", Length = "0x78")]
	[Token(Token = "0x6002001")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002002")]
	[Address(RVA = "0x3D3030", Offset = "0x3D1830", Length = "0x87")]
	public static extern void RailInGamePurchasePurchaseProductsToAssetsResponse_delivered_assets_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002003")]
	[Address(RVA = "0x3D2FB0", Offset = "0x3D17B0", Length = "0x78")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_delivered_assets_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002004")]
	[Address(RVA = "0x4134B0", Offset = "0x411CB0", Length = "0x78")]
	public static extern IntPtr new_RailInGamePurchasePurchaseProductsToAssetsResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002005")]
	[Address(RVA = "0x3F56B0", Offset = "0x3F3EB0", Length = "0x78")]
	public static extern void delete_RailInGamePurchasePurchaseProductsToAssetsResponse(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413260", Offset = "0x411A60", Length = "0x65")]
	[Token(Token = "0x6002006")]
	public static extern IntPtr new_RailInGamePurchaseFinishOrderResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002007")]
	[Address(RVA = "0x3D2BE0", Offset = "0x3D13E0", Length = "0x9B")]
	public static extern void RailInGamePurchaseFinishOrderResponse_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D2B60", Offset = "0x3D1360", Length = "0x78")]
	[Token(Token = "0x6002008")]
	public static extern IntPtr RailInGamePurchaseFinishOrderResponse_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002009")]
	[Address(RVA = "0x4132D0", Offset = "0x411AD0", Length = "0x78")]
	public static extern IntPtr new_RailInGamePurchaseFinishOrderResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F55B0", Offset = "0x3F3DB0", Length = "0x78")]
	[Token(Token = "0x600200A")]
	public static extern void delete_RailInGamePurchaseFinishOrderResponse(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413800", Offset = "0x412000", Length = "0x65")]
	[Token(Token = "0x600200B")]
	public static extern IntPtr new_RailInGameStorePurchasePayWindowDisplayed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D37A0", Offset = "0x3D1FA0", Length = "0x9B")]
	[Token(Token = "0x600200C")]
	public static extern void RailInGameStorePurchasePayWindowDisplayed_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600200D")]
	[Address(RVA = "0x3D3720", Offset = "0x3D1F20", Length = "0x78")]
	public static extern IntPtr RailInGameStorePurchasePayWindowDisplayed_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600200E")]
	[Address(RVA = "0x413870", Offset = "0x412070", Length = "0x78")]
	public static extern IntPtr new_RailInGameStorePurchasePayWindowDisplayed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600200F")]
	[Address(RVA = "0x3F58B0", Offset = "0x3F40B0", Length = "0x78")]
	public static extern void delete_RailInGameStorePurchasePayWindowDisplayed(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002010")]
	[Address(RVA = "0x413710", Offset = "0x411F10", Length = "0x65")]
	public static extern IntPtr new_RailInGameStorePurchasePayWindowClosed__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D3600", Offset = "0x3D1E00", Length = "0x9B")]
	[Token(Token = "0x6002011")]
	public static extern void RailInGameStorePurchasePayWindowClosed_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002012")]
	[Address(RVA = "0x3D3580", Offset = "0x3D1D80", Length = "0x78")]
	public static extern IntPtr RailInGameStorePurchasePayWindowClosed_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002013")]
	[Address(RVA = "0x413780", Offset = "0x411F80", Length = "0x78")]
	public static extern IntPtr new_RailInGameStorePurchasePayWindowClosed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5830", Offset = "0x3F4030", Length = "0x78")]
	[Token(Token = "0x6002014")]
	public static extern void delete_RailInGameStorePurchasePayWindowClosed(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4138F0", Offset = "0x4120F0", Length = "0x65")]
	[Token(Token = "0x6002015")]
	public static extern IntPtr new_RailInGameStorePurchaseResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D3940", Offset = "0x3D2140", Length = "0x9B")]
	[Token(Token = "0x6002016")]
	public static extern void RailInGameStorePurchaseResult_order_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D38C0", Offset = "0x3D20C0", Length = "0x78")]
	[Token(Token = "0x6002017")]
	public static extern IntPtr RailInGameStorePurchaseResult_order_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002018")]
	[Address(RVA = "0x413960", Offset = "0x412160", Length = "0x78")]
	public static extern IntPtr new_RailInGameStorePurchaseResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002019")]
	[Address(RVA = "0x3F5930", Offset = "0x3F4130", Length = "0x78")]
	public static extern void delete_RailInGameStorePurchaseResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600201A")]
	[Address(RVA = "0x413D20", Offset = "0x412520", Length = "0x65")]
	public static extern IntPtr new_RailNetworkSessionState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D4A40", Offset = "0x3D3240", Length = "0x86")]
	[Token(Token = "0x600201B")]
	public static extern void RailNetworkSessionState_is_connection_active_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x600201C")]
	[Address(RVA = "0x3D49C0", Offset = "0x3D31C0", Length = "0x7D")]
	public static extern bool RailNetworkSessionState_is_connection_active_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600201D")]
	[Address(RVA = "0x3D4930", Offset = "0x3D3130", Length = "0x86")]
	public static extern void RailNetworkSessionState_is_connecting_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D48B0", Offset = "0x3D30B0", Length = "0x7D")]
	[Token(Token = "0x600201E")]
	public static extern bool RailNetworkSessionState_is_connecting_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D4B50", Offset = "0x3D3350", Length = "0x86")]
	[Token(Token = "0x600201F")]
	public static extern void RailNetworkSessionState_is_using_relay_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002020")]
	[Address(RVA = "0x3D4AD0", Offset = "0x3D32D0", Length = "0x7D")]
	public static extern bool RailNetworkSessionState_is_using_relay_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002021")]
	[Address(RVA = "0x3D4F90", Offset = "0x3D3790", Length = "0x85")]
	public static extern void RailNetworkSessionState_session_error_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002022")]
	[Address(RVA = "0x3D4F10", Offset = "0x3D3710", Length = "0x78")]
	public static extern int RailNetworkSessionState_session_error_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002023")]
	[Address(RVA = "0x3D4820", Offset = "0x3D3020", Length = "0x85")]
	public static extern void RailNetworkSessionState_bytes_in_send_buffer_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D47A0", Offset = "0x3D2FA0", Length = "0x78")]
	[Token(Token = "0x6002024")]
	public static extern uint RailNetworkSessionState_bytes_in_send_buffer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002025")]
	[Address(RVA = "0x3D4C60", Offset = "0x3D3460", Length = "0x85")]
	public static extern void RailNetworkSessionState_packets_in_send_buffer_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D4BE0", Offset = "0x3D33E0", Length = "0x78")]
	[Token(Token = "0x6002026")]
	public static extern uint RailNetworkSessionState_packets_in_send_buffer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002027")]
	[Address(RVA = "0x3D4D70", Offset = "0x3D3570", Length = "0x85")]
	public static extern void RailNetworkSessionState_remote_ip_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002028")]
	[Address(RVA = "0x3D4CF0", Offset = "0x3D34F0", Length = "0x78")]
	public static extern uint RailNetworkSessionState_remote_ip_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002029")]
	[Address(RVA = "0x3D4E80", Offset = "0x3D3680", Length = "0x87")]
	public static extern void RailNetworkSessionState_remote_port_set(IntPtr jarg1, ushort jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D4E00", Offset = "0x3D3600", Length = "0x78")]
	[Token(Token = "0x600202A")]
	public static extern ushort RailNetworkSessionState_remote_port_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413D90", Offset = "0x412590", Length = "0x78")]
	[Token(Token = "0x600202B")]
	public static extern IntPtr new_RailNetworkSessionState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5BB0", Offset = "0x3F43B0", Length = "0x78")]
	[Token(Token = "0x600202C")]
	public static extern void delete_RailNetworkSessionState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600202D")]
	[Address(RVA = "0x412450", Offset = "0x410C50", Length = "0x65")]
	public static extern IntPtr new_RailGamePeer__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600202E")]
	[Address(RVA = "0x3D0810", Offset = "0x3CF010", Length = "0x87")]
	public static extern void RailGamePeer_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0790", Offset = "0x3CEF90", Length = "0x78")]
	[Token(Token = "0x600202F")]
	public static extern IntPtr RailGamePeer_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002030")]
	[Address(RVA = "0x3D0700", Offset = "0x3CEF00", Length = "0x87")]
	public static extern void RailGamePeer_game_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D0680", Offset = "0x3CEE80", Length = "0x78")]
	[Token(Token = "0x6002031")]
	public static extern IntPtr RailGamePeer_game_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4124C0", Offset = "0x410CC0", Length = "0x78")]
	[Token(Token = "0x6002032")]
	public static extern IntPtr new_RailGamePeer__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F4E30", Offset = "0x3F3630", Length = "0x78")]
	[Token(Token = "0x6002033")]
	public static extern void delete_RailGamePeer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002034")]
	[Address(RVA = "0x3FB360", Offset = "0x3F9B60", Length = "0x65")]
	public static extern IntPtr new_CreateSessionRequest__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x386780", Offset = "0x384F80", Length = "0x87")]
	[Token(Token = "0x6002035")]
	public static extern void CreateSessionRequest_local_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002036")]
	[Address(RVA = "0x386700", Offset = "0x384F00", Length = "0x78")]
	public static extern IntPtr CreateSessionRequest_local_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002037")]
	[Address(RVA = "0x386890", Offset = "0x385090", Length = "0x87")]
	public static extern void CreateSessionRequest_remote_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002038")]
	[Address(RVA = "0x386810", Offset = "0x385010", Length = "0x78")]
	public static extern IntPtr CreateSessionRequest_remote_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB3D0", Offset = "0x3F9BD0", Length = "0x78")]
	[Token(Token = "0x6002039")]
	public static extern IntPtr new_CreateSessionRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600203A")]
	[Address(RVA = "0x3E8AB0", Offset = "0x3E72B0", Length = "0x78")]
	public static extern void delete_CreateSessionRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB270", Offset = "0x3F9A70", Length = "0x65")]
	[Token(Token = "0x600203B")]
	public static extern IntPtr new_CreateSessionFailed__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600203C")]
	[Address(RVA = "0x3864E0", Offset = "0x384CE0", Length = "0x87")]
	public static extern void CreateSessionFailed_local_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x386460", Offset = "0x384C60", Length = "0x78")]
	[Token(Token = "0x600203D")]
	public static extern IntPtr CreateSessionFailed_local_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3865F0", Offset = "0x384DF0", Length = "0x87")]
	[Token(Token = "0x600203E")]
	public static extern void CreateSessionFailed_remote_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600203F")]
	[Address(RVA = "0x386570", Offset = "0x384D70", Length = "0x78")]
	public static extern IntPtr CreateSessionFailed_remote_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002040")]
	[Address(RVA = "0x3FB2E0", Offset = "0x3F9AE0", Length = "0x78")]
	public static extern IntPtr new_CreateSessionFailed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002041")]
	[Address(RVA = "0x3E8A30", Offset = "0x3E7230", Length = "0x78")]
	public static extern void delete_CreateSessionFailed(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE240", Offset = "0x3FCA40", Length = "0x65")]
	[Token(Token = "0x6002042")]
	public static extern IntPtr new_NetworkCreateRawSessionRequest__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A7550", Offset = "0x3A5D50", Length = "0x87")]
	[Token(Token = "0x6002043")]
	public static extern void NetworkCreateRawSessionRequest_local_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002044")]
	[Address(RVA = "0x3A74D0", Offset = "0x3A5CD0", Length = "0x78")]
	public static extern IntPtr NetworkCreateRawSessionRequest_local_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A7660", Offset = "0x3A5E60", Length = "0x87")]
	[Token(Token = "0x6002045")]
	public static extern void NetworkCreateRawSessionRequest_remote_game_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A75E0", Offset = "0x3A5DE0", Length = "0x78")]
	[Token(Token = "0x6002046")]
	public static extern IntPtr NetworkCreateRawSessionRequest_remote_game_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE2B0", Offset = "0x3FCAB0", Length = "0x78")]
	[Token(Token = "0x6002047")]
	public static extern IntPtr new_NetworkCreateRawSessionRequest__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002048")]
	[Address(RVA = "0x3EBE30", Offset = "0x3EA630", Length = "0x78")]
	public static extern void delete_NetworkCreateRawSessionRequest(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE150", Offset = "0x3FC950", Length = "0x65")]
	[Token(Token = "0x6002049")]
	public static extern IntPtr new_NetworkCreateRawSessionFailed__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600204A")]
	[Address(RVA = "0x3A72B0", Offset = "0x3A5AB0", Length = "0x87")]
	public static extern void NetworkCreateRawSessionFailed_local_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600204B")]
	[Address(RVA = "0x3A7230", Offset = "0x3A5A30", Length = "0x78")]
	public static extern IntPtr NetworkCreateRawSessionFailed_local_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600204C")]
	[Address(RVA = "0x3A73C0", Offset = "0x3A5BC0", Length = "0x87")]
	public static extern void NetworkCreateRawSessionFailed_remote_game_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600204D")]
	[Address(RVA = "0x3A7340", Offset = "0x3A5B40", Length = "0x78")]
	public static extern IntPtr NetworkCreateRawSessionFailed_remote_game_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE1C0", Offset = "0x3FC9C0", Length = "0x78")]
	[Token(Token = "0x600204E")]
	public static extern IntPtr new_NetworkCreateRawSessionFailed__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600204F")]
	[Address(RVA = "0x3EBDB0", Offset = "0x3EA5B0", Length = "0x78")]
	public static extern void delete_NetworkCreateRawSessionFailed(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002050")]
	[Address(RVA = "0x3F8C80", Offset = "0x3F7480", Length = "0x65")]
	public static extern uint kRailRoomDefaultMaxMemberNumber_get();

	[PreserveSig]
	[Token(Token = "0x6002051")]
	[Address(RVA = "0x3F8C10", Offset = "0x3F7410", Length = "0x65")]
	public static extern uint kRailRoomDataKeyValuePairsLimit_get();

	[PreserveSig]
	[Token(Token = "0x6002052")]
	[Address(RVA = "0x4177D0", Offset = "0x415FD0", Length = "0x65")]
	public static extern IntPtr new_RoomOptions__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E2F10", Offset = "0x3E1710", Length = "0x85")]
	[Token(Token = "0x6002053")]
	public static extern void RoomOptions_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002054")]
	[Address(RVA = "0x3E2E90", Offset = "0x3E1690", Length = "0x78")]
	public static extern int RoomOptions_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002055")]
	[Address(RVA = "0x3E2BC0", Offset = "0x3E13C0", Length = "0x85")]
	public static extern void RoomOptions_max_members_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002056")]
	[Address(RVA = "0x3E2B40", Offset = "0x3E1340", Length = "0x78")]
	public static extern uint RoomOptions_max_members_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2CD0", Offset = "0x3E14D0", Length = "0x9B")]
	[Token(Token = "0x6002057")]
	public static extern void RoomOptions_password_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E2C50", Offset = "0x3E1450", Length = "0x78")]
	[Token(Token = "0x6002058")]
	public static extern IntPtr RoomOptions_password_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2DF0", Offset = "0x3E15F0", Length = "0x9B")]
	[Token(Token = "0x6002059")]
	public static extern void RoomOptions_room_tag_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E2D70", Offset = "0x3E1570", Length = "0x78")]
	[Token(Token = "0x600205A")]
	public static extern IntPtr RoomOptions_room_tag_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2AB0", Offset = "0x3E12B0", Length = "0x86")]
	[Token(Token = "0x600205B")]
	public static extern void RoomOptions_enable_team_voice_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x600205C")]
	[Address(RVA = "0x3E2A30", Offset = "0x3E1230", Length = "0x7D")]
	public static extern bool RoomOptions_enable_team_voice_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417840", Offset = "0x416040", Length = "0x78")]
	[Token(Token = "0x600205D")]
	public static extern IntPtr new_RoomOptions__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7B30", Offset = "0x3F6330", Length = "0x78")]
	[Token(Token = "0x600205E")]
	public static extern void delete_RoomOptions(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600205F")]
	[Address(RVA = "0x417500", Offset = "0x415D00", Length = "0x65")]
	public static extern IntPtr new_RoomInfoListSorter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002060")]
	[Address(RVA = "0x3E1760", Offset = "0x3DFF60", Length = "0x85")]
	public static extern void RoomInfoListSorter_property_value_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002061")]
	[Address(RVA = "0x3E16E0", Offset = "0x3DFEE0", Length = "0x78")]
	public static extern int RoomInfoListSorter_property_value_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002062")]
	[Address(RVA = "0x3E1650", Offset = "0x3DFE50", Length = "0x85")]
	public static extern void RoomInfoListSorter_property_sort_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E15D0", Offset = "0x3DFDD0", Length = "0x78")]
	[Token(Token = "0x6002063")]
	public static extern int RoomInfoListSorter_property_sort_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002064")]
	[Address(RVA = "0x3E1530", Offset = "0x3DFD30", Length = "0x9B")]
	public static extern void RoomInfoListSorter_property_key_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E14B0", Offset = "0x3DFCB0", Length = "0x78")]
	[Token(Token = "0x6002065")]
	public static extern IntPtr RoomInfoListSorter_property_key_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002066")]
	[Address(RVA = "0x3E1420", Offset = "0x3DFC20", Length = "0x88")]
	public static extern void RoomInfoListSorter_close_to_value_set(IntPtr jarg1, double jarg2);

	[PreserveSig]
	[Token(Token = "0x6002067")]
	[Address(RVA = "0x3E13A0", Offset = "0x3DFBA0", Length = "0x78")]
	public static extern double RoomInfoListSorter_close_to_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002068")]
	[Address(RVA = "0x417570", Offset = "0x415D70", Length = "0x78")]
	public static extern IntPtr new_RoomInfoListSorter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002069")]
	[Address(RVA = "0x3F79B0", Offset = "0x3F61B0", Length = "0x78")]
	public static extern void delete_RoomInfoListSorter(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417320", Offset = "0x415B20", Length = "0x65")]
	[Token(Token = "0x600206A")]
	public static extern IntPtr new_RoomInfoListFilterKey__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E0A60", Offset = "0x3DF260", Length = "0x9B")]
	[Token(Token = "0x600206B")]
	public static extern void RoomInfoListFilterKey_key_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E09E0", Offset = "0x3DF1E0", Length = "0x78")]
	[Token(Token = "0x600206C")]
	public static extern IntPtr RoomInfoListFilterKey_key_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600206D")]
	[Address(RVA = "0x3E0B80", Offset = "0x3DF380", Length = "0x85")]
	public static extern void RoomInfoListFilterKey_value_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E0B00", Offset = "0x3DF300", Length = "0x78")]
	[Token(Token = "0x600206E")]
	public static extern int RoomInfoListFilterKey_value_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600206F")]
	[Address(RVA = "0x3E0830", Offset = "0x3DF030", Length = "0x85")]
	public static extern void RoomInfoListFilterKey_comparison_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002070")]
	[Address(RVA = "0x3E07B0", Offset = "0x3DEFB0", Length = "0x78")]
	public static extern int RoomInfoListFilterKey_comparison_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002071")]
	[Address(RVA = "0x3E0940", Offset = "0x3DF140", Length = "0x9B")]
	public static extern void RoomInfoListFilterKey_filter_value_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002072")]
	[Address(RVA = "0x3E08C0", Offset = "0x3DF0C0", Length = "0x78")]
	public static extern IntPtr RoomInfoListFilterKey_filter_value_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417390", Offset = "0x415B90", Length = "0x78")]
	[Token(Token = "0x6002073")]
	public static extern IntPtr new_RoomInfoListFilterKey__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002074")]
	[Address(RVA = "0x3F78B0", Offset = "0x3F60B0", Length = "0x78")]
	public static extern void delete_RoomInfoListFilterKey(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002075")]
	[Address(RVA = "0x417410", Offset = "0x415C10", Length = "0x65")]
	public static extern IntPtr new_RoomInfoListFilter__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002076")]
	[Address(RVA = "0x3E10D0", Offset = "0x3DF8D0", Length = "0x87")]
	public static extern void RoomInfoListFilter_key_filters_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1050", Offset = "0x3DF850", Length = "0x78")]
	[Token(Token = "0x6002077")]
	public static extern IntPtr RoomInfoListFilter_key_filters_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E11E0", Offset = "0x3DF9E0", Length = "0x9B")]
	[Token(Token = "0x6002078")]
	public static extern void RoomInfoListFilter_room_name_contained_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1160", Offset = "0x3DF960", Length = "0x78")]
	[Token(Token = "0x6002079")]
	public static extern IntPtr RoomInfoListFilter_room_name_contained_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600207A")]
	[Address(RVA = "0x3E1300", Offset = "0x3DFB00", Length = "0x9B")]
	public static extern void RoomInfoListFilter_room_tag_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1280", Offset = "0x3DFA80", Length = "0x78")]
	[Token(Token = "0x600207B")]
	public static extern IntPtr RoomInfoListFilter_room_tag_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0FC0", Offset = "0x3DF7C0", Length = "0x85")]
	[Token(Token = "0x600207C")]
	public static extern void RoomInfoListFilter_filter_password_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x600207D")]
	[Address(RVA = "0x3E0F40", Offset = "0x3DF740", Length = "0x78")]
	public static extern int RoomInfoListFilter_filter_password_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0EB0", Offset = "0x3DF6B0", Length = "0x85")]
	[Token(Token = "0x600207E")]
	public static extern void RoomInfoListFilter_filter_friends_owned_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E0E30", Offset = "0x3DF630", Length = "0x78")]
	[Token(Token = "0x600207F")]
	public static extern int RoomInfoListFilter_filter_friends_owned_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0DA0", Offset = "0x3DF5A0", Length = "0x85")]
	[Token(Token = "0x6002080")]
	public static extern void RoomInfoListFilter_filter_friends_in_room_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E0D20", Offset = "0x3DF520", Length = "0x78")]
	[Token(Token = "0x6002081")]
	public static extern int RoomInfoListFilter_filter_friends_in_room_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0C90", Offset = "0x3DF490", Length = "0x85")]
	[Token(Token = "0x6002082")]
	public static extern void RoomInfoListFilter_available_slot_at_least_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002083")]
	[Address(RVA = "0x3E0C10", Offset = "0x3DF410", Length = "0x78")]
	public static extern uint RoomInfoListFilter_available_slot_at_least_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417480", Offset = "0x415C80", Length = "0x78")]
	[Token(Token = "0x6002084")]
	public static extern IntPtr new_RoomInfoListFilter__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002085")]
	[Address(RVA = "0x3F7930", Offset = "0x3F6130", Length = "0x78")]
	public static extern void delete_RoomInfoListFilter(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002086")]
	[Address(RVA = "0x4175F0", Offset = "0x415DF0", Length = "0x65")]
	public static extern IntPtr new_RoomInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E1FE0", Offset = "0x3E07E0", Length = "0x87")]
	[Token(Token = "0x6002087")]
	public static extern void RoomInfo_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1F60", Offset = "0x3E0760", Length = "0x78")]
	[Token(Token = "0x6002088")]
	public static extern ulong RoomInfo_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002089")]
	[Address(RVA = "0x3E1ED0", Offset = "0x3E06D0", Length = "0x87")]
	public static extern void RoomInfo_owner_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1E50", Offset = "0x3E0650", Length = "0x78")]
	[Token(Token = "0x600208A")]
	public static extern IntPtr RoomInfo_owner_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600208B")]
	[Address(RVA = "0x3E1DC0", Offset = "0x3E05C0", Length = "0x85")]
	public static extern void RoomInfo_max_members_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600208C")]
	[Address(RVA = "0x3E1D40", Offset = "0x3E0540", Length = "0x78")]
	public static extern uint RoomInfo_max_members_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600208D")]
	[Address(RVA = "0x3E1980", Offset = "0x3E0180", Length = "0x85")]
	public static extern void RoomInfo_current_members_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600208E")]
	[Address(RVA = "0x3E1900", Offset = "0x3E0100", Length = "0x78")]
	public static extern uint RoomInfo_current_members_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600208F")]
	[Address(RVA = "0x3E1870", Offset = "0x3E0070", Length = "0x85")]
	public static extern void RoomInfo_create_time_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002090")]
	[Address(RVA = "0x3E17F0", Offset = "0x3DFFF0", Length = "0x78")]
	public static extern uint RoomInfo_create_time_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002091")]
	[Address(RVA = "0x3E2200", Offset = "0x3E0A00", Length = "0x9B")]
	public static extern void RoomInfo_room_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E2180", Offset = "0x3E0980", Length = "0x78")]
	[Token(Token = "0x6002092")]
	public static extern IntPtr RoomInfo_room_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002093")]
	[Address(RVA = "0x3E2320", Offset = "0x3E0B20", Length = "0x9B")]
	public static extern void RoomInfo_room_tag_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E22A0", Offset = "0x3E0AA0", Length = "0x78")]
	[Token(Token = "0x6002094")]
	public static extern IntPtr RoomInfo_room_tag_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002095")]
	[Address(RVA = "0x3E1BA0", Offset = "0x3E03A0", Length = "0x86")]
	public static extern void RoomInfo_has_password_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1B20", Offset = "0x3E0320", Length = "0x7D")]
	[Token(Token = "0x6002096")]
	public static extern bool RoomInfo_has_password_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002097")]
	[Address(RVA = "0x3E1CB0", Offset = "0x3E04B0", Length = "0x86")]
	public static extern void RoomInfo_is_joinable_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E1C30", Offset = "0x3E0430", Length = "0x7D")]
	[Token(Token = "0x6002098")]
	public static extern bool RoomInfo_is_joinable_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2440", Offset = "0x3E0C40", Length = "0x85")]
	[Token(Token = "0x6002099")]
	public static extern void RoomInfo_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E23C0", Offset = "0x3E0BC0", Length = "0x78")]
	[Token(Token = "0x600209A")]
	public static extern int RoomInfo_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E1A90", Offset = "0x3E0290", Length = "0x87")]
	[Token(Token = "0x600209B")]
	public static extern void RoomInfo_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600209C")]
	[Address(RVA = "0x3E1A10", Offset = "0x3E0210", Length = "0x78")]
	public static extern IntPtr RoomInfo_game_server_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600209D")]
	[Address(RVA = "0x3E20F0", Offset = "0x3E08F0", Length = "0x87")]
	public static extern void RoomInfo_room_kvs_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E2070", Offset = "0x3E0870", Length = "0x78")]
	[Token(Token = "0x600209E")]
	public static extern IntPtr RoomInfo_room_kvs_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417660", Offset = "0x415E60", Length = "0x78")]
	[Token(Token = "0x600209F")]
	public static extern IntPtr new_RoomInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020A0")]
	[Address(RVA = "0x3F7A30", Offset = "0x3F6230", Length = "0x78")]
	public static extern void delete_RoomInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4176E0", Offset = "0x415EE0", Length = "0x65")]
	[Token(Token = "0x60020A1")]
	public static extern IntPtr new_RoomMemberInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x3E29A0", Offset = "0x3E11A0", Length = "0x87")]
	public static extern void RoomMemberInfo_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x3E2920", Offset = "0x3E1120", Length = "0x78")]
	public static extern ulong RoomMemberInfo_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2550", Offset = "0x3E0D50", Length = "0x87")]
	[Token(Token = "0x60020A4")]
	public static extern void RoomMemberInfo_member_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E24D0", Offset = "0x3E0CD0", Length = "0x78")]
	[Token(Token = "0x60020A5")]
	public static extern IntPtr RoomMemberInfo_member_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2660", Offset = "0x3E0E60", Length = "0x85")]
	[Token(Token = "0x60020A6")]
	public static extern void RoomMemberInfo_member_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E25E0", Offset = "0x3E0DE0", Length = "0x78")]
	[Token(Token = "0x60020A7")]
	public static extern uint RoomMemberInfo_member_index_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x3E2880", Offset = "0x3E1080", Length = "0x9B")]
	public static extern void RoomMemberInfo_member_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E2800", Offset = "0x3E1000", Length = "0x78")]
	[Token(Token = "0x60020A9")]
	public static extern IntPtr RoomMemberInfo_member_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E2770", Offset = "0x3E0F70", Length = "0x87")]
	[Token(Token = "0x60020AA")]
	public static extern void RoomMemberInfo_member_kvs_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x3E26F0", Offset = "0x3E0EF0", Length = "0x78")]
	public static extern IntPtr RoomMemberInfo_member_kvs_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x417750", Offset = "0x415F50", Length = "0x78")]
	public static extern IntPtr new_RoomMemberInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7AB0", Offset = "0x3F62B0", Length = "0x78")]
	[Token(Token = "0x60020AD")]
	public static extern void delete_RoomMemberInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB180", Offset = "0x3F9980", Length = "0x65")]
	[Token(Token = "0x60020AE")]
	public static extern IntPtr new_CreateRoomResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x386350", Offset = "0x384B50", Length = "0x87")]
	[Token(Token = "0x60020AF")]
	public static extern void CreateRoomResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3862D0", Offset = "0x384AD0", Length = "0x78")]
	[Token(Token = "0x60020B0")]
	public static extern ulong CreateRoomResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB1F0", Offset = "0x3F99F0", Length = "0x78")]
	[Token(Token = "0x60020B1")]
	public static extern IntPtr new_CreateRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E89B0", Offset = "0x3E71B0", Length = "0x78")]
	[Token(Token = "0x60020B2")]
	public static extern void delete_CreateRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020B3")]
	[Address(RVA = "0x3FE9C0", Offset = "0x3FD1C0", Length = "0x65")]
	public static extern IntPtr new_OpenRoomResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A9190", Offset = "0x3A7990", Length = "0x87")]
	[Token(Token = "0x60020B4")]
	public static extern void OpenRoomResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9110", Offset = "0x3A7910", Length = "0x78")]
	[Token(Token = "0x60020B5")]
	public static extern ulong OpenRoomResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FEA30", Offset = "0x3FD230", Length = "0x78")]
	[Token(Token = "0x60020B6")]
	public static extern IntPtr new_OpenRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC230", Offset = "0x3EAA30", Length = "0x78")]
	[Token(Token = "0x60020B7")]
	public static extern void delete_OpenRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCBC0", Offset = "0x3FB3C0", Length = "0x65")]
	[Token(Token = "0x60020B8")]
	public static extern IntPtr new_GetRoomListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020B9")]
	[Address(RVA = "0x38CE80", Offset = "0x38B680", Length = "0x85")]
	public static extern void GetRoomListResult_begin_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x38CE00", Offset = "0x38B600", Length = "0x78")]
	[Token(Token = "0x60020BA")]
	public static extern uint GetRoomListResult_begin_index_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x38CF90", Offset = "0x38B790", Length = "0x85")]
	public static extern void GetRoomListResult_end_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x38CF10", Offset = "0x38B710", Length = "0x78")]
	public static extern uint GetRoomListResult_end_index_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x38D1B0", Offset = "0x38B9B0", Length = "0x85")]
	public static extern void GetRoomListResult_total_room_num_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x38D130", Offset = "0x38B930", Length = "0x78")]
	public static extern uint GetRoomListResult_total_room_num_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x38D0A0", Offset = "0x38B8A0", Length = "0x87")]
	public static extern void GetRoomListResult_room_infos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38D020", Offset = "0x38B820", Length = "0x78")]
	[Token(Token = "0x60020C0")]
	public static extern IntPtr GetRoomListResult_room_infos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x3FCC30", Offset = "0x3FB430", Length = "0x78")]
	public static extern IntPtr new_GetRoomListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x3E9830", Offset = "0x3E8030", Length = "0x78")]
	public static extern void delete_GetRoomListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCF80", Offset = "0x3FB780", Length = "0x65")]
	[Token(Token = "0x60020C3")]
	public static extern IntPtr new_GetUserRoomListResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x38DB30", Offset = "0x38C330", Length = "0x87")]
	public static extern void GetUserRoomListResult_room_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x38DAB0", Offset = "0x38C2B0", Length = "0x78")]
	public static extern IntPtr GetUserRoomListResult_room_info_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x3FCFF0", Offset = "0x3FB7F0", Length = "0x78")]
	public static extern IntPtr new_GetUserRoomListResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x3E9A30", Offset = "0x3E8230", Length = "0x78")]
	public static extern void delete_GetUserRoomListResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417B90", Offset = "0x416390", Length = "0x65")]
	[Token(Token = "0x60020C8")]
	public static extern IntPtr new_SetNewRoomOwnerResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x417C00", Offset = "0x416400", Length = "0x78")]
	public static extern IntPtr new_SetNewRoomOwnerResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7D30", Offset = "0x3F6530", Length = "0x78")]
	[Token(Token = "0x60020CA")]
	public static extern void delete_SetNewRoomOwnerResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCCB0", Offset = "0x3FB4B0", Length = "0x65")]
	[Token(Token = "0x60020CB")]
	public static extern IntPtr new_GetRoomMembersResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38D560", Offset = "0x38BD60", Length = "0x87")]
	[Token(Token = "0x60020CC")]
	public static extern void GetRoomMembersResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x38D4E0", Offset = "0x38BCE0", Length = "0x78")]
	public static extern ulong GetRoomMembersResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38D450", Offset = "0x38BC50", Length = "0x85")]
	[Token(Token = "0x60020CE")]
	public static extern void GetRoomMembersResult_member_num_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x38D3D0", Offset = "0x38BBD0", Length = "0x78")]
	public static extern uint GetRoomMembersResult_member_num_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x38D340", Offset = "0x38BB40", Length = "0x87")]
	public static extern void GetRoomMembersResult_member_infos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38D2C0", Offset = "0x38BAC0", Length = "0x78")]
	[Token(Token = "0x60020D1")]
	public static extern IntPtr GetRoomMembersResult_member_infos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020D2")]
	[Address(RVA = "0x3FCD20", Offset = "0x3FB520", Length = "0x78")]
	public static extern IntPtr new_GetRoomMembersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E98B0", Offset = "0x3E80B0", Length = "0x78")]
	[Token(Token = "0x60020D3")]
	public static extern void delete_GetRoomMembersResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FDD90", Offset = "0x3FC590", Length = "0x65")]
	[Token(Token = "0x60020D4")]
	public static extern IntPtr new_LeaveRoomResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A6940", Offset = "0x3A5140", Length = "0x87")]
	[Token(Token = "0x60020D5")]
	public static extern void LeaveRoomResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A68C0", Offset = "0x3A50C0", Length = "0x78")]
	[Token(Token = "0x60020D6")]
	public static extern ulong LeaveRoomResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A6830", Offset = "0x3A5030", Length = "0x85")]
	[Token(Token = "0x60020D7")]
	public static extern void LeaveRoomResult_reason_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A67B0", Offset = "0x3A4FB0", Length = "0x78")]
	[Token(Token = "0x60020D8")]
	public static extern int LeaveRoomResult_reason_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020D9")]
	[Address(RVA = "0x3FDE00", Offset = "0x3FC600", Length = "0x78")]
	public static extern IntPtr new_LeaveRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020DA")]
	[Address(RVA = "0x3EBBB0", Offset = "0x3EA3B0", Length = "0x78")]
	public static extern void delete_LeaveRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020DB")]
	[Address(RVA = "0x3FD340", Offset = "0x3FBB40", Length = "0x65")]
	public static extern IntPtr new_JoinRoomResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A4B50", Offset = "0x3A3350", Length = "0x87")]
	[Token(Token = "0x60020DC")]
	public static extern void JoinRoomResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x60020DD")]
	[Address(RVA = "0x3A4AD0", Offset = "0x3A32D0", Length = "0x78")]
	public static extern ulong JoinRoomResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020DE")]
	[Address(RVA = "0x3FD3B0", Offset = "0x3FBBB0", Length = "0x78")]
	public static extern IntPtr new_JoinRoomResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB630", Offset = "0x3E9E30", Length = "0x78")]
	[Token(Token = "0x60020DF")]
	public static extern void delete_JoinRoomResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC620", Offset = "0x3FAE20", Length = "0x65")]
	[Token(Token = "0x60020E0")]
	public static extern IntPtr new_GetAllRoomDataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38B9F0", Offset = "0x38A1F0", Length = "0x87")]
	[Token(Token = "0x60020E1")]
	public static extern void GetAllRoomDataResult_room_info_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60020E2")]
	[Address(RVA = "0x38B970", Offset = "0x38A170", Length = "0x78")]
	public static extern IntPtr GetAllRoomDataResult_room_info_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FC690", Offset = "0x3FAE90", Length = "0x78")]
	[Token(Token = "0x60020E3")]
	public static extern IntPtr new_GetAllRoomDataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E9530", Offset = "0x3E7D30", Length = "0x78")]
	[Token(Token = "0x60020E4")]
	public static extern void delete_GetAllRoomDataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020E5")]
	[Address(RVA = "0x3FD520", Offset = "0x3FBD20", Length = "0x65")]
	public static extern IntPtr new_KickOffMemberResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x3A5090", Offset = "0x3A3890", Length = "0x87")]
	public static extern void KickOffMemberResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5010", Offset = "0x3A3810", Length = "0x78")]
	[Token(Token = "0x60020E7")]
	public static extern ulong KickOffMemberResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A4F80", Offset = "0x3A3780", Length = "0x87")]
	[Token(Token = "0x60020E8")]
	public static extern void KickOffMemberResult_kicked_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x3A4F00", Offset = "0x3A3700", Length = "0x78")]
	public static extern IntPtr KickOffMemberResult_kicked_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020EA")]
	[Address(RVA = "0x3FD590", Offset = "0x3FBD90", Length = "0x78")]
	public static extern IntPtr new_KickOffMemberResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x3EB730", Offset = "0x3E9F30", Length = "0x78")]
	public static extern void delete_KickOffMemberResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x417E60", Offset = "0x416660", Length = "0x65")]
	public static extern IntPtr new_SetRoomTagResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x417ED0", Offset = "0x4166D0", Length = "0x78")]
	public static extern IntPtr new_SetRoomTagResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7EB0", Offset = "0x3F66B0", Length = "0x78")]
	[Token(Token = "0x60020EE")]
	public static extern void delete_SetRoomTagResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCE90", Offset = "0x3FB690", Length = "0x65")]
	[Token(Token = "0x60020EF")]
	public static extern IntPtr new_GetRoomTagResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38D990", Offset = "0x38C190", Length = "0x9B")]
	[Token(Token = "0x60020F0")]
	public static extern void GetRoomTagResult_room_tag_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38D910", Offset = "0x38C110", Length = "0x78")]
	[Token(Token = "0x60020F1")]
	public static extern IntPtr GetRoomTagResult_room_tag_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCF00", Offset = "0x3FB700", Length = "0x78")]
	[Token(Token = "0x60020F2")]
	public static extern IntPtr new_GetRoomTagResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E99B0", Offset = "0x3E81B0", Length = "0x78")]
	[Token(Token = "0x60020F3")]
	public static extern void delete_GetRoomTagResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417D70", Offset = "0x416570", Length = "0x65")]
	[Token(Token = "0x60020F4")]
	public static extern IntPtr new_SetRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3E3770", Offset = "0x3E1F70", Length = "0x87")]
	[Token(Token = "0x60020F5")]
	public static extern void SetRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E36F0", Offset = "0x3E1EF0", Length = "0x78")]
	[Token(Token = "0x60020F6")]
	public static extern ulong SetRoomMetadataResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020F7")]
	[Address(RVA = "0x417DE0", Offset = "0x4165E0", Length = "0x78")]
	public static extern IntPtr new_SetRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7E30", Offset = "0x3F6630", Length = "0x78")]
	[Token(Token = "0x60020F8")]
	public static extern void delete_SetRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FCDA0", Offset = "0x3FB5A0", Length = "0x65")]
	[Token(Token = "0x60020F9")]
	public static extern IntPtr new_GetRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38D800", Offset = "0x38C000", Length = "0x87")]
	[Token(Token = "0x60020FA")]
	public static extern void GetRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x38D780", Offset = "0x38BF80", Length = "0x78")]
	[Token(Token = "0x60020FB")]
	public static extern ulong GetRoomMetadataResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38D6F0", Offset = "0x38BEF0", Length = "0x87")]
	[Token(Token = "0x60020FC")]
	public static extern void GetRoomMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38D670", Offset = "0x38BE70", Length = "0x78")]
	[Token(Token = "0x60020FD")]
	public static extern IntPtr GetRoomMetadataResult_key_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x3FCE10", Offset = "0x3FB610", Length = "0x78")]
	public static extern IntPtr new_GetRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x3E9930", Offset = "0x3E8130", Length = "0x78")]
	public static extern void delete_GetRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002100")]
	[Address(RVA = "0x3FA910", Offset = "0x3F9110", Length = "0x65")]
	public static extern IntPtr new_ClearRoomMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002101")]
	[Address(RVA = "0x384E40", Offset = "0x383640", Length = "0x87")]
	public static extern void ClearRoomMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6002102")]
	[Address(RVA = "0x384DC0", Offset = "0x3835C0", Length = "0x78")]
	public static extern ulong ClearRoomMetadataResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002103")]
	[Address(RVA = "0x3FA980", Offset = "0x3F9180", Length = "0x78")]
	public static extern IntPtr new_ClearRoomMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E8530", Offset = "0x3E6D30", Length = "0x78")]
	[Token(Token = "0x6002104")]
	public static extern void delete_ClearRoomMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417AA0", Offset = "0x4162A0", Length = "0x65")]
	[Token(Token = "0x6002105")]
	public static extern IntPtr new_SetMemberMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002106")]
	[Address(RVA = "0x3E34E0", Offset = "0x3E1CE0", Length = "0x87")]
	public static extern void SetMemberMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E3460", Offset = "0x3E1C60", Length = "0x78")]
	[Token(Token = "0x6002107")]
	public static extern ulong SetMemberMetadataResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E33D0", Offset = "0x3E1BD0", Length = "0x87")]
	[Token(Token = "0x6002108")]
	public static extern void SetMemberMetadataResult_member_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E3350", Offset = "0x3E1B50", Length = "0x78")]
	[Token(Token = "0x6002109")]
	public static extern IntPtr SetMemberMetadataResult_member_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417B10", Offset = "0x416310", Length = "0x78")]
	[Token(Token = "0x600210A")]
	public static extern IntPtr new_SetMemberMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7CB0", Offset = "0x3F64B0", Length = "0x78")]
	[Token(Token = "0x600210B")]
	public static extern void delete_SetMemberMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600210C")]
	[Address(RVA = "0x3FCAD0", Offset = "0x3FB2D0", Length = "0x65")]
	public static extern IntPtr new_GetMemberMetadataResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600210D")]
	[Address(RVA = "0x38CCF0", Offset = "0x38B4F0", Length = "0x87")]
	public static extern void GetMemberMetadataResult_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x600210E")]
	[Address(RVA = "0x38CC70", Offset = "0x38B470", Length = "0x78")]
	public static extern ulong GetMemberMetadataResult_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600210F")]
	[Address(RVA = "0x38CBE0", Offset = "0x38B3E0", Length = "0x87")]
	public static extern void GetMemberMetadataResult_member_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002110")]
	[Address(RVA = "0x38CB60", Offset = "0x38B360", Length = "0x78")]
	public static extern IntPtr GetMemberMetadataResult_member_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38CAD0", Offset = "0x38B2D0", Length = "0x87")]
	[Token(Token = "0x6002111")]
	public static extern void GetMemberMetadataResult_key_value_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002112")]
	[Address(RVA = "0x38CA50", Offset = "0x38B250", Length = "0x78")]
	public static extern IntPtr GetMemberMetadataResult_key_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002113")]
	[Address(RVA = "0x3FCB40", Offset = "0x3FB340", Length = "0x78")]
	public static extern IntPtr new_GetMemberMetadataResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002114")]
	[Address(RVA = "0x3E97B0", Offset = "0x3E7FB0", Length = "0x78")]
	public static extern void delete_GetMemberMetadataResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002115")]
	[Address(RVA = "0x417230", Offset = "0x415A30", Length = "0x65")]
	public static extern IntPtr new_RoomDataReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002116")]
	[Address(RVA = "0x3E0720", Offset = "0x3DEF20", Length = "0x87")]
	public static extern void RoomDataReceived_remote_peer_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002117")]
	[Address(RVA = "0x3E06A0", Offset = "0x3DEEA0", Length = "0x78")]
	public static extern IntPtr RoomDataReceived_remote_peer_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0610", Offset = "0x3DEE10", Length = "0x85")]
	[Token(Token = "0x6002118")]
	public static extern void RoomDataReceived_message_type_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002119")]
	[Address(RVA = "0x3E0590", Offset = "0x3DED90", Length = "0x78")]
	public static extern uint RoomDataReceived_message_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0500", Offset = "0x3DED00", Length = "0x85")]
	[Token(Token = "0x600211A")]
	public static extern void RoomDataReceived_data_len_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E0480", Offset = "0x3DEC80", Length = "0x78")]
	[Token(Token = "0x600211B")]
	public static extern uint RoomDataReceived_data_len_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E03E0", Offset = "0x3DEBE0", Length = "0x9B")]
	[Token(Token = "0x600211C")]
	public static extern void RoomDataReceived_data_buf_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E0360", Offset = "0x3DEB60", Length = "0x78")]
	[Token(Token = "0x600211D")]
	public static extern IntPtr RoomDataReceived_data_buf_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600211E")]
	[Address(RVA = "0x4172A0", Offset = "0x415AA0", Length = "0x78")]
	public static extern IntPtr new_RoomDataReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7830", Offset = "0x3F6030", Length = "0x78")]
	[Token(Token = "0x600211F")]
	public static extern void delete_RoomDataReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002120")]
	[Address(RVA = "0x417F50", Offset = "0x416750", Length = "0x65")]
	public static extern IntPtr new_SetRoomTypeResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002121")]
	[Address(RVA = "0x3E3980", Offset = "0x3E2180", Length = "0x85")]
	public static extern void SetRoomTypeResult_room_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E3900", Offset = "0x3E2100", Length = "0x78")]
	[Token(Token = "0x6002122")]
	public static extern int SetRoomTypeResult_room_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x417FC0", Offset = "0x4167C0", Length = "0x78")]
	[Token(Token = "0x6002123")]
	public static extern IntPtr new_SetRoomTypeResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7F30", Offset = "0x3F6730", Length = "0x78")]
	[Token(Token = "0x6002124")]
	public static extern void delete_SetRoomTypeResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002125")]
	[Address(RVA = "0x417C80", Offset = "0x416480", Length = "0x65")]
	public static extern IntPtr new_SetRoomMaxMemberResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002126")]
	[Address(RVA = "0x417CF0", Offset = "0x4164F0", Length = "0x78")]
	public static extern IntPtr new_SetRoomMaxMemberResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002127")]
	[Address(RVA = "0x3F7DB0", Offset = "0x3F65B0", Length = "0x78")]
	public static extern void delete_SetRoomMaxMemberResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002128")]
	[Address(RVA = "0x3FE330", Offset = "0x3FCB30", Length = "0x65")]
	public static extern IntPtr new_NotifyMetadataChange__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002129")]
	[Address(RVA = "0x3A79E0", Offset = "0x3A61E0", Length = "0x87")]
	public static extern void NotifyMetadataChange_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x600212A")]
	[Address(RVA = "0x3A7960", Offset = "0x3A6160", Length = "0x78")]
	public static extern ulong NotifyMetadataChange_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600212B")]
	[Address(RVA = "0x3A78D0", Offset = "0x3A60D0", Length = "0x87")]
	public static extern void NotifyMetadataChange_changer_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600212C")]
	[Address(RVA = "0x3A7850", Offset = "0x3A6050", Length = "0x78")]
	public static extern IntPtr NotifyMetadataChange_changer_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600212D")]
	[Address(RVA = "0x3FE3A0", Offset = "0x3FCBA0", Length = "0x78")]
	public static extern IntPtr new_NotifyMetadataChange__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBEB0", Offset = "0x3EA6B0", Length = "0x78")]
	[Token(Token = "0x600212E")]
	public static extern void delete_NotifyMetadataChange(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE600", Offset = "0x3FCE00", Length = "0x65")]
	[Token(Token = "0x600212F")]
	public static extern IntPtr new_NotifyRoomMemberChange__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002130")]
	[Address(RVA = "0x3A82D0", Offset = "0x3A6AD0", Length = "0x87")]
	public static extern void NotifyRoomMemberChange_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6002131")]
	[Address(RVA = "0x3A8250", Offset = "0x3A6A50", Length = "0x78")]
	public static extern ulong NotifyRoomMemberChange_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002132")]
	[Address(RVA = "0x3A80B0", Offset = "0x3A68B0", Length = "0x87")]
	public static extern void NotifyRoomMemberChange_changer_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002133")]
	[Address(RVA = "0x3A8030", Offset = "0x3A6830", Length = "0x78")]
	public static extern IntPtr NotifyRoomMemberChange_changer_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002134")]
	[Address(RVA = "0x3A81C0", Offset = "0x3A69C0", Length = "0x87")]
	public static extern void NotifyRoomMemberChange_id_for_making_change_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002135")]
	[Address(RVA = "0x3A8140", Offset = "0x3A6940", Length = "0x78")]
	public static extern IntPtr NotifyRoomMemberChange_id_for_making_change_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002136")]
	[Address(RVA = "0x3A83E0", Offset = "0x3A6BE0", Length = "0x85")]
	public static extern void NotifyRoomMemberChange_state_change_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002137")]
	[Address(RVA = "0x3A8360", Offset = "0x3A6B60", Length = "0x78")]
	public static extern int NotifyRoomMemberChange_state_change_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE670", Offset = "0x3FCE70", Length = "0x78")]
	[Token(Token = "0x6002138")]
	public static extern IntPtr new_NotifyRoomMemberChange__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002139")]
	[Address(RVA = "0x3EC030", Offset = "0x3EA830", Length = "0x78")]
	public static extern void delete_NotifyRoomMemberChange(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE6F0", Offset = "0x3FCEF0", Length = "0x65")]
	[Token(Token = "0x600213A")]
	public static extern IntPtr new_NotifyRoomMemberKicked__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600213B")]
	[Address(RVA = "0x3A88A0", Offset = "0x3A70A0", Length = "0x87")]
	public static extern void NotifyRoomMemberKicked_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A8820", Offset = "0x3A7020", Length = "0x78")]
	[Token(Token = "0x600213C")]
	public static extern ulong NotifyRoomMemberKicked_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A8680", Offset = "0x3A6E80", Length = "0x87")]
	[Token(Token = "0x600213D")]
	public static extern void NotifyRoomMemberKicked_id_for_making_kick_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A8600", Offset = "0x3A6E00", Length = "0x78")]
	[Token(Token = "0x600213E")]
	public static extern IntPtr NotifyRoomMemberKicked_id_for_making_kick_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600213F")]
	[Address(RVA = "0x3A8790", Offset = "0x3A6F90", Length = "0x87")]
	public static extern void NotifyRoomMemberKicked_kicked_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A8710", Offset = "0x3A6F10", Length = "0x78")]
	[Token(Token = "0x6002140")]
	public static extern IntPtr NotifyRoomMemberKicked_kicked_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A8570", Offset = "0x3A6D70", Length = "0x85")]
	[Token(Token = "0x6002141")]
	public static extern void NotifyRoomMemberKicked_due_to_kicker_lost_connect_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A84F0", Offset = "0x3A6CF0", Length = "0x78")]
	[Token(Token = "0x6002142")]
	public static extern uint NotifyRoomMemberKicked_due_to_kicker_lost_connect_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE760", Offset = "0x3FCF60", Length = "0x78")]
	[Token(Token = "0x6002143")]
	public static extern IntPtr new_NotifyRoomMemberKicked__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC0B0", Offset = "0x3EA8B0", Length = "0x78")]
	[Token(Token = "0x6002144")]
	public static extern void delete_NotifyRoomMemberKicked(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE420", Offset = "0x3FCC20", Length = "0x65")]
	[Token(Token = "0x6002145")]
	public static extern IntPtr new_NotifyRoomDestroy__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002146")]
	[Address(RVA = "0x3A7B70", Offset = "0x3A6370", Length = "0x87")]
	public static extern void NotifyRoomDestroy_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6002147")]
	[Address(RVA = "0x3A7AF0", Offset = "0x3A62F0", Length = "0x78")]
	public static extern ulong NotifyRoomDestroy_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002148")]
	[Address(RVA = "0x3FE490", Offset = "0x3FCC90", Length = "0x78")]
	public static extern IntPtr new_NotifyRoomDestroy__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002149")]
	[Address(RVA = "0x3EBF30", Offset = "0x3EA730", Length = "0x78")]
	public static extern void delete_NotifyRoomDestroy(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FE7E0", Offset = "0x3FCFE0", Length = "0x65")]
	[Token(Token = "0x600214A")]
	public static extern IntPtr new_NotifyRoomOwnerChange__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A8D60", Offset = "0x3A7560", Length = "0x87")]
	[Token(Token = "0x600214B")]
	public static extern void NotifyRoomOwnerChange_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x600214C")]
	[Address(RVA = "0x3A8CE0", Offset = "0x3A74E0", Length = "0x78")]
	public static extern ulong NotifyRoomOwnerChange_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600214D")]
	[Address(RVA = "0x3A8B40", Offset = "0x3A7340", Length = "0x87")]
	public static extern void NotifyRoomOwnerChange_old_owner_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600214E")]
	[Address(RVA = "0x3A8AC0", Offset = "0x3A72C0", Length = "0x78")]
	public static extern IntPtr NotifyRoomOwnerChange_old_owner_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600214F")]
	[Address(RVA = "0x3A8A30", Offset = "0x3A7230", Length = "0x87")]
	public static extern void NotifyRoomOwnerChange_new_owner_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002150")]
	[Address(RVA = "0x3A89B0", Offset = "0x3A71B0", Length = "0x78")]
	public static extern IntPtr NotifyRoomOwnerChange_new_owner_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002151")]
	[Address(RVA = "0x3A8C50", Offset = "0x3A7450", Length = "0x85")]
	public static extern void NotifyRoomOwnerChange_reason_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002152")]
	[Address(RVA = "0x3A8BD0", Offset = "0x3A73D0", Length = "0x78")]
	public static extern int NotifyRoomOwnerChange_reason_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002153")]
	[Address(RVA = "0x3FE850", Offset = "0x3FD050", Length = "0x78")]
	public static extern IntPtr new_NotifyRoomOwnerChange__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002154")]
	[Address(RVA = "0x3EC130", Offset = "0x3EA930", Length = "0x78")]
	public static extern void delete_NotifyRoomOwnerChange(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002155")]
	[Address(RVA = "0x3FE510", Offset = "0x3FCD10", Length = "0x65")]
	public static extern IntPtr new_NotifyRoomGameServerChange__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002156")]
	[Address(RVA = "0x3A7F20", Offset = "0x3A6720", Length = "0x87")]
	public static extern void NotifyRoomGameServerChange_room_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A7EA0", Offset = "0x3A66A0", Length = "0x78")]
	[Token(Token = "0x6002157")]
	public static extern ulong NotifyRoomGameServerChange_room_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A7E10", Offset = "0x3A6610", Length = "0x87")]
	[Token(Token = "0x6002158")]
	public static extern void NotifyRoomGameServerChange_game_server_rail_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A7D90", Offset = "0x3A6590", Length = "0x78")]
	[Token(Token = "0x6002159")]
	public static extern IntPtr NotifyRoomGameServerChange_game_server_rail_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600215A")]
	[Address(RVA = "0x3A7D00", Offset = "0x3A6500", Length = "0x87")]
	public static extern void NotifyRoomGameServerChange_game_server_channel_id_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A7C80", Offset = "0x3A6480", Length = "0x78")]
	[Token(Token = "0x600215B")]
	public static extern ulong NotifyRoomGameServerChange_game_server_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600215C")]
	[Address(RVA = "0x3FE580", Offset = "0x3FCD80", Length = "0x78")]
	public static extern IntPtr new_NotifyRoomGameServerChange__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBFB0", Offset = "0x3EA7B0", Length = "0x78")]
	[Token(Token = "0x600215D")]
	public static extern void delete_NotifyRoomGameServerChange(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600215E")]
	[Address(RVA = "0x4159D0", Offset = "0x4141D0", Length = "0x65")]
	public static extern IntPtr new_RailSyncFileOption__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600215F")]
	[Address(RVA = "0x3DBA10", Offset = "0x3DA210", Length = "0x86")]
	public static extern void RailSyncFileOption_sync_file_not_to_remote_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002160")]
	[Address(RVA = "0x3DB990", Offset = "0x3DA190", Length = "0x7D")]
	public static extern bool RailSyncFileOption_sync_file_not_to_remote_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002161")]
	[Address(RVA = "0x415A40", Offset = "0x414240", Length = "0x78")]
	public static extern IntPtr new_RailSyncFileOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002162")]
	[Address(RVA = "0x3F6B30", Offset = "0x3F5330", Length = "0x78")]
	public static extern void delete_RailSyncFileOption(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002163")]
	[Address(RVA = "0x4156E0", Offset = "0x413EE0", Length = "0x65")]
	public static extern IntPtr new_RailStreamFileOption__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002164")]
	[Address(RVA = "0x3DB520", Offset = "0x3D9D20", Length = "0x86")]
	public static extern void RailStreamFileOption_unavaliabe_when_new_file_writing_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002165")]
	[Address(RVA = "0x3DB4A0", Offset = "0x3D9CA0", Length = "0x7D")]
	public static extern bool RailStreamFileOption_unavaliabe_when_new_file_writing_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002166")]
	[Address(RVA = "0x3DB410", Offset = "0x3D9C10", Length = "0x85")]
	public static extern void RailStreamFileOption_open_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DB390", Offset = "0x3D9B90", Length = "0x78")]
	[Token(Token = "0x6002167")]
	public static extern int RailStreamFileOption_open_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415750", Offset = "0x413F50", Length = "0x78")]
	[Token(Token = "0x6002168")]
	public static extern IntPtr new_RailStreamFileOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F69B0", Offset = "0x3F51B0", Length = "0x78")]
	[Token(Token = "0x6002169")]
	public static extern void delete_RailStreamFileOption(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413C30", Offset = "0x412430", Length = "0x65")]
	[Token(Token = "0x600216A")]
	public static extern IntPtr new_RailListStreamFileOption__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600216B")]
	[Address(RVA = "0x3D45C0", Offset = "0x3D2DC0", Length = "0x85")]
	public static extern void RailListStreamFileOption_start_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600216C")]
	[Address(RVA = "0x3D4540", Offset = "0x3D2D40", Length = "0x78")]
	public static extern uint RailListStreamFileOption_start_index_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600216D")]
	[Address(RVA = "0x3D44B0", Offset = "0x3D2CB0", Length = "0x85")]
	public static extern void RailListStreamFileOption_num_files_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600216E")]
	[Address(RVA = "0x3D4430", Offset = "0x3D2C30", Length = "0x78")]
	public static extern uint RailListStreamFileOption_num_files_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x413CA0", Offset = "0x4124A0", Length = "0x78")]
	[Token(Token = "0x600216F")]
	public static extern IntPtr new_RailListStreamFileOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5B30", Offset = "0x3F4330", Length = "0x78")]
	[Token(Token = "0x6002170")]
	public static extern void delete_RailListStreamFileOption(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002171")]
	[Address(RVA = "0x4144A0", Offset = "0x412CA0", Length = "0x65")]
	public static extern IntPtr new_RailPublishFileToUserSpaceOption__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D6620", Offset = "0x3D4E20", Length = "0x85")]
	[Token(Token = "0x6002172")]
	public static extern void RailPublishFileToUserSpaceOption_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D65A0", Offset = "0x3D4DA0", Length = "0x78")]
	[Token(Token = "0x6002173")]
	public static extern int RailPublishFileToUserSpaceOption_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D63F0", Offset = "0x3D4BF0", Length = "0x9B")]
	[Token(Token = "0x6002174")]
	public static extern void RailPublishFileToUserSpaceOption_space_work_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6370", Offset = "0x3D4B70", Length = "0x78")]
	[Token(Token = "0x6002175")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_space_work_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002176")]
	[Address(RVA = "0x3D5F90", Offset = "0x3D4790", Length = "0x9B")]
	public static extern void RailPublishFileToUserSpaceOption_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002177")]
	[Address(RVA = "0x3D5F10", Offset = "0x3D4710", Length = "0x78")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_description_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D62D0", Offset = "0x3D4AD0", Length = "0x9B")]
	[Token(Token = "0x6002178")]
	public static extern void RailPublishFileToUserSpaceOption_preview_path_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002179")]
	[Address(RVA = "0x3D6250", Offset = "0x3D4A50", Length = "0x78")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_preview_path_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D6730", Offset = "0x3D4F30", Length = "0x9B")]
	[Token(Token = "0x600217A")]
	public static extern void RailPublishFileToUserSpaceOption_version_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D66B0", Offset = "0x3D4EB0", Length = "0x78")]
	[Token(Token = "0x600217B")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_version_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600217C")]
	[Address(RVA = "0x3D6510", Offset = "0x3D4D10", Length = "0x87")]
	public static extern void RailPublishFileToUserSpaceOption_tags_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600217D")]
	[Address(RVA = "0x3D6490", Offset = "0x3D4C90", Length = "0x78")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_tags_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600217E")]
	[Address(RVA = "0x3D61C0", Offset = "0x3D49C0", Length = "0x85")]
	public static extern void RailPublishFileToUserSpaceOption_level_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D6140", Offset = "0x3D4940", Length = "0x78")]
	[Token(Token = "0x600217F")]
	public static extern int RailPublishFileToUserSpaceOption_level_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D60B0", Offset = "0x3D48B0", Length = "0x87")]
	[Token(Token = "0x6002180")]
	public static extern void RailPublishFileToUserSpaceOption_key_value_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002181")]
	[Address(RVA = "0x3D6030", Offset = "0x3D4830", Length = "0x78")]
	public static extern IntPtr RailPublishFileToUserSpaceOption_key_value_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002182")]
	[Address(RVA = "0x414510", Offset = "0x412D10", Length = "0x78")]
	public static extern IntPtr new_RailPublishFileToUserSpaceOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002183")]
	[Address(RVA = "0x3F5FB0", Offset = "0x3F47B0", Length = "0x78")]
	public static extern void delete_RailPublishFileToUserSpaceOption(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002184")]
	[Address(RVA = "0x3DB2F0", Offset = "0x3D9AF0", Length = "0x9B")]
	public static extern void RailStreamFileInfo_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002185")]
	[Address(RVA = "0x3DB270", Offset = "0x3D9A70", Length = "0x78")]
	public static extern IntPtr RailStreamFileInfo_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002186")]
	[Address(RVA = "0x3DB1E0", Offset = "0x3D99E0", Length = "0x87")]
	public static extern void RailStreamFileInfo_file_size_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Token(Token = "0x6002187")]
	[Address(RVA = "0x3DB160", Offset = "0x3D9960", Length = "0x78")]
	public static extern ulong RailStreamFileInfo_file_size_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002188")]
	[Address(RVA = "0x4155F0", Offset = "0x413DF0", Length = "0x65")]
	public static extern IntPtr new_RailStreamFileInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002189")]
	[Address(RVA = "0x415660", Offset = "0x413E60", Length = "0x78")]
	public static extern IntPtr new_RailStreamFileInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600218A")]
	[Address(RVA = "0x3F6930", Offset = "0x3F5130", Length = "0x78")]
	public static extern void delete_RailStreamFileInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600218B")]
	[Address(RVA = "0x3F9560", Offset = "0x3F7D60", Length = "0x65")]
	public static extern IntPtr new_AsyncQueryQuotaResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3802A0", Offset = "0x37EAA0", Length = "0x87")]
	[Token(Token = "0x600218C")]
	public static extern void AsyncQueryQuotaResult_total_quota_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x380220", Offset = "0x37EA20", Length = "0x78")]
	[Token(Token = "0x600218D")]
	public static extern ulong AsyncQueryQuotaResult_total_quota_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x380190", Offset = "0x37E990", Length = "0x87")]
	[Token(Token = "0x600218E")]
	public static extern void AsyncQueryQuotaResult_available_quota_set(IntPtr jarg1, ulong jarg2);

	[PreserveSig]
	[Address(RVA = "0x380110", Offset = "0x37E910", Length = "0x78")]
	[Token(Token = "0x600218F")]
	public static extern ulong AsyncQueryQuotaResult_available_quota_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F95D0", Offset = "0x3F7DD0", Length = "0x78")]
	[Token(Token = "0x6002190")]
	public static extern IntPtr new_AsyncQueryQuotaResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002191")]
	[Address(RVA = "0x3E7AB0", Offset = "0x3E62B0", Length = "0x78")]
	public static extern void delete_AsyncQueryQuotaResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002192")]
	[Address(RVA = "0x418040", Offset = "0x416840", Length = "0x65")]
	public static extern IntPtr new_ShareStorageToSpaceWorkResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002193")]
	[Address(RVA = "0x3E3B10", Offset = "0x3E2310", Length = "0x87")]
	public static extern void ShareStorageToSpaceWorkResult_space_work_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002194")]
	[Address(RVA = "0x3E3A90", Offset = "0x3E2290", Length = "0x78")]
	public static extern IntPtr ShareStorageToSpaceWorkResult_space_work_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4180B0", Offset = "0x4168B0", Length = "0x78")]
	[Token(Token = "0x6002195")]
	public static extern IntPtr new_ShareStorageToSpaceWorkResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7FB0", Offset = "0x3F67B0", Length = "0x78")]
	[Token(Token = "0x6002196")]
	public static extern void delete_ShareStorageToSpaceWorkResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9830", Offset = "0x3F8030", Length = "0x65")]
	[Token(Token = "0x6002197")]
	public static extern IntPtr new_AsyncReadFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002198")]
	[Address(RVA = "0x380980", Offset = "0x37F180", Length = "0x9B")]
	public static extern void AsyncReadFileResult_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002199")]
	[Address(RVA = "0x380900", Offset = "0x37F100", Length = "0x78")]
	public static extern IntPtr AsyncReadFileResult_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600219A")]
	[Address(RVA = "0x380860", Offset = "0x37F060", Length = "0x9B")]
	public static extern void AsyncReadFileResult_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600219B")]
	[Address(RVA = "0x3807E0", Offset = "0x37EFE0", Length = "0x78")]
	public static extern IntPtr AsyncReadFileResult_data_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x380AA0", Offset = "0x37F2A0", Length = "0x85")]
	[Token(Token = "0x600219C")]
	public static extern void AsyncReadFileResult_offset_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x380A20", Offset = "0x37F220", Length = "0x78")]
	[Token(Token = "0x600219D")]
	public static extern int AsyncReadFileResult_offset_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x380BB0", Offset = "0x37F3B0", Length = "0x85")]
	[Token(Token = "0x600219E")]
	public static extern void AsyncReadFileResult_try_read_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x380B30", Offset = "0x37F330", Length = "0x78")]
	[Token(Token = "0x600219F")]
	public static extern uint AsyncReadFileResult_try_read_length_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021A0")]
	[Address(RVA = "0x3F98A0", Offset = "0x3F80A0", Length = "0x78")]
	public static extern IntPtr new_AsyncReadFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7C30", Offset = "0x3E6430", Length = "0x78")]
	[Token(Token = "0x60021A1")]
	public static extern void delete_AsyncReadFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA0A0", Offset = "0x3F88A0", Length = "0x65")]
	[Token(Token = "0x60021A2")]
	public static extern IntPtr new_AsyncWriteFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60021A3")]
	[Address(RVA = "0x382280", Offset = "0x380A80", Length = "0x9B")]
	public static extern void AsyncWriteFileResult_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021A4")]
	[Address(RVA = "0x382200", Offset = "0x380A00", Length = "0x78")]
	public static extern IntPtr AsyncWriteFileResult_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021A5")]
	[Address(RVA = "0x3823A0", Offset = "0x380BA0", Length = "0x85")]
	public static extern void AsyncWriteFileResult_offset_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60021A6")]
	[Address(RVA = "0x382320", Offset = "0x380B20", Length = "0x78")]
	public static extern int AsyncWriteFileResult_offset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021A7")]
	[Address(RVA = "0x3824B0", Offset = "0x380CB0", Length = "0x85")]
	public static extern void AsyncWriteFileResult_try_write_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021A8")]
	[Address(RVA = "0x382430", Offset = "0x380C30", Length = "0x78")]
	public static extern uint AsyncWriteFileResult_try_write_length_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021A9")]
	[Address(RVA = "0x3825C0", Offset = "0x380DC0", Length = "0x85")]
	public static extern void AsyncWriteFileResult_written_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021AA")]
	[Address(RVA = "0x382540", Offset = "0x380D40", Length = "0x78")]
	public static extern uint AsyncWriteFileResult_written_length_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FA110", Offset = "0x3F8910", Length = "0x78")]
	[Token(Token = "0x60021AB")]
	public static extern IntPtr new_AsyncWriteFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E80B0", Offset = "0x3E68B0", Length = "0x78")]
	[Token(Token = "0x60021AC")]
	public static extern void delete_AsyncWriteFileResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021AD")]
	[Address(RVA = "0x3F9920", Offset = "0x3F8120", Length = "0x65")]
	public static extern IntPtr new_AsyncReadStreamFileResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x380E60", Offset = "0x37F660", Length = "0x9B")]
	[Token(Token = "0x60021AE")]
	public static extern void AsyncReadStreamFileResult_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021AF")]
	[Address(RVA = "0x380DE0", Offset = "0x37F5E0", Length = "0x78")]
	public static extern IntPtr AsyncReadStreamFileResult_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x380D40", Offset = "0x37F540", Length = "0x9B")]
	[Token(Token = "0x60021B0")]
	public static extern void AsyncReadStreamFileResult_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x380CC0", Offset = "0x37F4C0", Length = "0x78")]
	[Token(Token = "0x60021B1")]
	public static extern IntPtr AsyncReadStreamFileResult_data_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021B2")]
	[Address(RVA = "0x380F80", Offset = "0x37F780", Length = "0x85")]
	public static extern void AsyncReadStreamFileResult_offset_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x380F00", Offset = "0x37F700", Length = "0x78")]
	[Token(Token = "0x60021B3")]
	public static extern int AsyncReadStreamFileResult_offset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021B4")]
	[Address(RVA = "0x381090", Offset = "0x37F890", Length = "0x85")]
	public static extern void AsyncReadStreamFileResult_try_read_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021B5")]
	[Address(RVA = "0x381010", Offset = "0x37F810", Length = "0x78")]
	public static extern uint AsyncReadStreamFileResult_try_read_length_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9990", Offset = "0x3F8190", Length = "0x78")]
	[Token(Token = "0x60021B6")]
	public static extern IntPtr new_AsyncReadStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7CB0", Offset = "0x3E64B0", Length = "0x78")]
	[Token(Token = "0x60021B7")]
	public static extern void delete_AsyncReadStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021B8")]
	[Address(RVA = "0x3FA190", Offset = "0x3F8990", Length = "0x65")]
	public static extern IntPtr new_AsyncWriteStreamFileResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x382750", Offset = "0x380F50", Length = "0x9B")]
	[Token(Token = "0x60021B9")]
	public static extern void AsyncWriteStreamFileResult_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x3826D0", Offset = "0x380ED0", Length = "0x78")]
	public static extern IntPtr AsyncWriteStreamFileResult_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x382870", Offset = "0x381070", Length = "0x85")]
	[Token(Token = "0x60021BB")]
	public static extern void AsyncWriteStreamFileResult_offset_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x3827F0", Offset = "0x380FF0", Length = "0x78")]
	public static extern int AsyncWriteStreamFileResult_offset_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021BD")]
	[Address(RVA = "0x382980", Offset = "0x381180", Length = "0x85")]
	public static extern void AsyncWriteStreamFileResult_try_write_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x382900", Offset = "0x381100", Length = "0x78")]
	public static extern uint AsyncWriteStreamFileResult_try_write_length_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x382A90", Offset = "0x381290", Length = "0x85")]
	[Token(Token = "0x60021BF")]
	public static extern void AsyncWriteStreamFileResult_written_length_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x382A10", Offset = "0x381210", Length = "0x78")]
	[Token(Token = "0x60021C0")]
	public static extern uint AsyncWriteStreamFileResult_written_length_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x3FA200", Offset = "0x3F8A00", Length = "0x78")]
	public static extern IntPtr new_AsyncWriteStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x3E8130", Offset = "0x3E6930", Length = "0x78")]
	public static extern void delete_AsyncWriteStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9380", Offset = "0x3F7B80", Length = "0x65")]
	[Token(Token = "0x60021C3")]
	public static extern IntPtr new_AsyncListFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x37FA30", Offset = "0x37E230", Length = "0x87")]
	public static extern void AsyncListFileResult_file_list_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x37F9B0", Offset = "0x37E1B0", Length = "0x78")]
	[Token(Token = "0x60021C5")]
	public static extern IntPtr AsyncListFileResult_file_list_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x37FB40", Offset = "0x37E340", Length = "0x85")]
	public static extern void AsyncListFileResult_start_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x37FAC0", Offset = "0x37E2C0", Length = "0x78")]
	[Token(Token = "0x60021C7")]
	public static extern uint AsyncListFileResult_start_index_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37FC50", Offset = "0x37E450", Length = "0x85")]
	[Token(Token = "0x60021C8")]
	public static extern void AsyncListFileResult_try_list_file_num_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x37FBD0", Offset = "0x37E3D0", Length = "0x78")]
	public static extern uint AsyncListFileResult_try_list_file_num_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x37F920", Offset = "0x37E120", Length = "0x85")]
	public static extern void AsyncListFileResult_all_file_num_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x37F8A0", Offset = "0x37E0A0", Length = "0x78")]
	public static extern uint AsyncListFileResult_all_file_num_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x3F93F0", Offset = "0x3F7BF0", Length = "0x78")]
	public static extern IntPtr new_AsyncListFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x3E79B0", Offset = "0x3E61B0", Length = "0x78")]
	public static extern void delete_AsyncListFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F9BF0", Offset = "0x3F83F0", Length = "0x65")]
	[Token(Token = "0x60021CE")]
	public static extern IntPtr new_AsyncRenameStreamFileResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x381660", Offset = "0x37FE60", Length = "0x9B")]
	[Token(Token = "0x60021CF")]
	public static extern void AsyncRenameStreamFileResult_old_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x3815E0", Offset = "0x37FDE0", Length = "0x78")]
	public static extern IntPtr AsyncRenameStreamFileResult_old_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x381540", Offset = "0x37FD40", Length = "0x9B")]
	public static extern void AsyncRenameStreamFileResult_new_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x3814C0", Offset = "0x37FCC0", Length = "0x78")]
	public static extern IntPtr AsyncRenameStreamFileResult_new_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x3F9C60", Offset = "0x3F8460", Length = "0x78")]
	public static extern IntPtr new_AsyncRenameStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7E30", Offset = "0x3E6630", Length = "0x78")]
	[Token(Token = "0x60021D4")]
	public static extern void delete_AsyncRenameStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8FC0", Offset = "0x3F77C0", Length = "0x65")]
	[Token(Token = "0x60021D5")]
	public static extern IntPtr new_AsyncDeleteStreamFileResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x37F0B0", Offset = "0x37D8B0", Length = "0x9B")]
	public static extern void AsyncDeleteStreamFileResult_filename_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x37F030", Offset = "0x37D830", Length = "0x78")]
	public static extern IntPtr AsyncDeleteStreamFileResult_filename_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x3F9030", Offset = "0x3F7830", Length = "0x78")]
	public static extern IntPtr new_AsyncDeleteStreamFileResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x3E77B0", Offset = "0x3E5FB0", Length = "0x78")]
	public static extern void delete_AsyncDeleteStreamFileResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4168D0", Offset = "0x4150D0", Length = "0x65")]
	[Token(Token = "0x60021DA")]
	public static extern IntPtr new_RailVoiceCaptureOption__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DED30", Offset = "0x3DD530", Length = "0x85")]
	[Token(Token = "0x60021DB")]
	public static extern void RailVoiceCaptureOption_voice_data_format_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DECB0", Offset = "0x3DD4B0", Length = "0x78")]
	[Token(Token = "0x60021DC")]
	public static extern int RailVoiceCaptureOption_voice_data_format_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416940", Offset = "0x415140", Length = "0x78")]
	[Token(Token = "0x60021DD")]
	public static extern IntPtr new_RailVoiceCaptureOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F7330", Offset = "0x3F5B30", Length = "0x78")]
	[Token(Token = "0x60021DE")]
	public static extern void delete_RailVoiceCaptureOption(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4169C0", Offset = "0x4151C0", Length = "0x65")]
	[Token(Token = "0x60021DF")]
	public static extern IntPtr new_RailVoiceCaptureSpecification__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x3DEF50", Offset = "0x3DD750", Length = "0x85")]
	public static extern void RailVoiceCaptureSpecification_capture_format_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60021E1")]
	[Address(RVA = "0x3DEED0", Offset = "0x3DD6D0", Length = "0x78")]
	public static extern int RailVoiceCaptureSpecification_capture_format_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021E2")]
	[Address(RVA = "0x3DEE40", Offset = "0x3DD640", Length = "0x85")]
	public static extern void RailVoiceCaptureSpecification_bits_per_sample_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60021E3")]
	[Address(RVA = "0x3DEDC0", Offset = "0x3DD5C0", Length = "0x78")]
	public static extern uint RailVoiceCaptureSpecification_bits_per_sample_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DF170", Offset = "0x3DD970", Length = "0x85")]
	[Token(Token = "0x60021E4")]
	public static extern void RailVoiceCaptureSpecification_samples_per_second_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DF0F0", Offset = "0x3DD8F0", Length = "0x78")]
	[Token(Token = "0x60021E5")]
	public static extern uint RailVoiceCaptureSpecification_samples_per_second_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DF060", Offset = "0x3DD860", Length = "0x85")]
	[Token(Token = "0x60021E6")]
	public static extern void RailVoiceCaptureSpecification_channels_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DEFE0", Offset = "0x3DD7E0", Length = "0x78")]
	[Token(Token = "0x60021E7")]
	public static extern int RailVoiceCaptureSpecification_channels_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416A30", Offset = "0x415230", Length = "0x78")]
	[Token(Token = "0x60021E8")]
	public static extern IntPtr new_RailVoiceCaptureSpecification__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F73B0", Offset = "0x3F5BB0", Length = "0x78")]
	[Token(Token = "0x60021E9")]
	public static extern void delete_RailVoiceCaptureSpecification(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB450", Offset = "0x3F9C50", Length = "0x65")]
	[Token(Token = "0x60021EA")]
	public static extern IntPtr new_CreateVoiceChannelOption__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3869A0", Offset = "0x3851A0", Length = "0x86")]
	[Token(Token = "0x60021EB")]
	public static extern void CreateVoiceChannelOption_join_channel_after_created_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x386920", Offset = "0x385120", Length = "0x7D")]
	[Token(Token = "0x60021EC")]
	public static extern bool CreateVoiceChannelOption_join_channel_after_created_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9CC0", Length = "0x78")]
	[Token(Token = "0x60021ED")]
	public static extern IntPtr new_CreateVoiceChannelOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E8B30", Offset = "0x3E7330", Length = "0x78")]
	[Token(Token = "0x60021EE")]
	public static extern void delete_CreateVoiceChannelOption(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416BA0", Offset = "0x4153A0", Length = "0x65")]
	[Token(Token = "0x60021EF")]
	public static extern IntPtr new_RailVoiceChannelUserSpeakingState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DF520", Offset = "0x3DDD20", Length = "0x87")]
	[Token(Token = "0x60021F0")]
	public static extern void RailVoiceChannelUserSpeakingState_user_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60021F1")]
	[Address(RVA = "0x3DF4A0", Offset = "0x3DDCA0", Length = "0x78")]
	public static extern IntPtr RailVoiceChannelUserSpeakingState_user_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021F2")]
	[Address(RVA = "0x3DF410", Offset = "0x3DDC10", Length = "0x85")]
	public static extern void RailVoiceChannelUserSpeakingState_speaking_limit_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60021F3")]
	[Address(RVA = "0x3DF390", Offset = "0x3DDB90", Length = "0x78")]
	public static extern int RailVoiceChannelUserSpeakingState_speaking_limit_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021F4")]
	[Address(RVA = "0x416C10", Offset = "0x415410", Length = "0x78")]
	public static extern IntPtr new_RailVoiceChannelUserSpeakingState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021F5")]
	[Address(RVA = "0x3F74B0", Offset = "0x3F5CB0", Length = "0x78")]
	public static extern void delete_RailVoiceChannelUserSpeakingState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021F6")]
	[Address(RVA = "0x386B30", Offset = "0x385330", Length = "0x87")]
	public static extern void CreateVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60021F7")]
	[Address(RVA = "0x386AB0", Offset = "0x3852B0", Length = "0x78")]
	public static extern IntPtr CreateVoiceChannelResult_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FB540", Offset = "0x3F9D40", Length = "0x65")]
	[Token(Token = "0x60021F8")]
	public static extern IntPtr new_CreateVoiceChannelResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60021F9")]
	[Address(RVA = "0x3FB5B0", Offset = "0x3F9DB0", Length = "0x78")]
	public static extern IntPtr new_CreateVoiceChannelResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021FA")]
	[Address(RVA = "0x3E8BB0", Offset = "0x3E73B0", Length = "0x78")]
	public static extern void delete_CreateVoiceChannelResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60021FB")]
	[Address(RVA = "0x3A4DF0", Offset = "0x3A35F0", Length = "0x87")]
	public static extern void JoinVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A4D70", Offset = "0x3A3570", Length = "0x78")]
	[Token(Token = "0x60021FC")]
	public static extern IntPtr JoinVoiceChannelResult_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A4CE0", Offset = "0x3A34E0", Length = "0x87")]
	[Token(Token = "0x60021FD")]
	public static extern void JoinVoiceChannelResult_already_joined_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A4C60", Offset = "0x3A3460", Length = "0x78")]
	[Token(Token = "0x60021FE")]
	public static extern IntPtr JoinVoiceChannelResult_already_joined_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD430", Offset = "0x3FBC30", Length = "0x65")]
	[Token(Token = "0x60021FF")]
	public static extern IntPtr new_JoinVoiceChannelResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002200")]
	[Address(RVA = "0x3FD4A0", Offset = "0x3FBCA0", Length = "0x78")]
	public static extern IntPtr new_JoinVoiceChannelResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002201")]
	[Address(RVA = "0x3EB6B0", Offset = "0x3E9EB0", Length = "0x78")]
	public static extern void delete_JoinVoiceChannelResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002202")]
	[Address(RVA = "0x3FDE80", Offset = "0x3FC680", Length = "0x65")]
	public static extern IntPtr new_LeaveVoiceChannelResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A6BE0", Offset = "0x3A53E0", Length = "0x87")]
	[Token(Token = "0x6002203")]
	public static extern void LeaveVoiceChannelResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002204")]
	[Address(RVA = "0x3A6B60", Offset = "0x3A5360", Length = "0x78")]
	public static extern IntPtr LeaveVoiceChannelResult_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002205")]
	[Address(RVA = "0x3A6AD0", Offset = "0x3A52D0", Length = "0x85")]
	public static extern void LeaveVoiceChannelResult_reason_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002206")]
	[Address(RVA = "0x3A6A50", Offset = "0x3A5250", Length = "0x78")]
	public static extern int LeaveVoiceChannelResult_reason_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FDEF0", Offset = "0x3FC6F0", Length = "0x78")]
	[Token(Token = "0x6002207")]
	public static extern IntPtr new_LeaveVoiceChannelResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBC30", Offset = "0x3EA430", Length = "0x78")]
	[Token(Token = "0x6002208")]
	public static extern void delete_LeaveVoiceChannelResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002209")]
	[Address(RVA = "0x3E6180", Offset = "0x3E4980", Length = "0x87")]
	public static extern void VoiceChannelAddUsersResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600220A")]
	[Address(RVA = "0x3E6100", Offset = "0x3E4900", Length = "0x78")]
	public static extern IntPtr VoiceChannelAddUsersResult_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E6070", Offset = "0x3E4870", Length = "0x87")]
	[Token(Token = "0x600220B")]
	public static extern void VoiceChannelAddUsersResult_success_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600220C")]
	[Address(RVA = "0x3E5FF0", Offset = "0x3E47F0", Length = "0x78")]
	public static extern IntPtr VoiceChannelAddUsersResult_success_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600220D")]
	[Address(RVA = "0x3E5F60", Offset = "0x3E4760", Length = "0x87")]
	public static extern void VoiceChannelAddUsersResult_failed_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600220E")]
	[Address(RVA = "0x3E5EE0", Offset = "0x3E46E0", Length = "0x78")]
	public static extern IntPtr VoiceChannelAddUsersResult_failed_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418ED0", Offset = "0x4176D0", Length = "0x65")]
	[Token(Token = "0x600220F")]
	public static extern IntPtr new_VoiceChannelAddUsersResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002210")]
	[Address(RVA = "0x418F40", Offset = "0x417740", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelAddUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8730", Offset = "0x3F6F30", Length = "0x78")]
	[Token(Token = "0x6002211")]
	public static extern void delete_VoiceChannelAddUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E6D30", Offset = "0x3E5530", Length = "0x87")]
	[Token(Token = "0x6002212")]
	public static extern void VoiceChannelRemoveUsersResult_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002213")]
	[Address(RVA = "0x3E6CB0", Offset = "0x3E54B0", Length = "0x78")]
	public static extern IntPtr VoiceChannelRemoveUsersResult_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002214")]
	[Address(RVA = "0x3E6C20", Offset = "0x3E5420", Length = "0x87")]
	public static extern void VoiceChannelRemoveUsersResult_success_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002215")]
	[Address(RVA = "0x3E6BA0", Offset = "0x3E53A0", Length = "0x78")]
	public static extern IntPtr VoiceChannelRemoveUsersResult_success_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E6B10", Offset = "0x3E5310", Length = "0x87")]
	[Token(Token = "0x6002216")]
	public static extern void VoiceChannelRemoveUsersResult_failed_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E6A90", Offset = "0x3E5290", Length = "0x78")]
	[Token(Token = "0x6002217")]
	public static extern IntPtr VoiceChannelRemoveUsersResult_failed_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x419290", Offset = "0x417A90", Length = "0x65")]
	[Token(Token = "0x6002218")]
	public static extern IntPtr new_VoiceChannelRemoveUsersResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002219")]
	[Address(RVA = "0x419300", Offset = "0x417B00", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelRemoveUsersResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600221A")]
	[Address(RVA = "0x3F8930", Offset = "0x3F7130", Length = "0x78")]
	public static extern void delete_VoiceChannelRemoveUsersResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600221B")]
	[Address(RVA = "0x3E6430", Offset = "0x3E4C30", Length = "0x9B")]
	public static extern void VoiceChannelInviteEvent_inviter_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600221C")]
	[Address(RVA = "0x3E63B0", Offset = "0x3E4BB0", Length = "0x78")]
	public static extern IntPtr VoiceChannelInviteEvent_inviter_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600221D")]
	[Address(RVA = "0x3E6310", Offset = "0x3E4B10", Length = "0x9B")]
	public static extern void VoiceChannelInviteEvent_channel_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600221E")]
	[Address(RVA = "0x3E6290", Offset = "0x3E4A90", Length = "0x78")]
	public static extern IntPtr VoiceChannelInviteEvent_channel_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E6550", Offset = "0x3E4D50", Length = "0x87")]
	[Token(Token = "0x600221F")]
	public static extern void VoiceChannelInviteEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002220")]
	[Address(RVA = "0x3E64D0", Offset = "0x3E4CD0", Length = "0x78")]
	public static extern IntPtr VoiceChannelInviteEvent_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418FC0", Offset = "0x4177C0", Length = "0x65")]
	[Token(Token = "0x6002221")]
	public static extern IntPtr new_VoiceChannelInviteEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002222")]
	[Address(RVA = "0x419030", Offset = "0x417830", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelInviteEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002223")]
	[Address(RVA = "0x3F87B0", Offset = "0x3F6FB0", Length = "0x78")]
	public static extern void delete_VoiceChannelInviteEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E67F0", Offset = "0x3E4FF0", Length = "0x87")]
	[Token(Token = "0x6002224")]
	public static extern void VoiceChannelMemeberChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E6770", Offset = "0x3E4F70", Length = "0x78")]
	[Token(Token = "0x6002225")]
	public static extern IntPtr VoiceChannelMemeberChangedEvent_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E66E0", Offset = "0x3E4EE0", Length = "0x87")]
	[Token(Token = "0x6002226")]
	public static extern void VoiceChannelMemeberChangedEvent_member_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E6660", Offset = "0x3E4E60", Length = "0x78")]
	[Token(Token = "0x6002227")]
	public static extern IntPtr VoiceChannelMemeberChangedEvent_member_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002228")]
	[Address(RVA = "0x4190B0", Offset = "0x4178B0", Length = "0x65")]
	public static extern IntPtr new_VoiceChannelMemeberChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002229")]
	[Address(RVA = "0x419120", Offset = "0x417920", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelMemeberChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600222A")]
	[Address(RVA = "0x3F8830", Offset = "0x3F7030", Length = "0x78")]
	public static extern void delete_VoiceChannelMemeberChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4191A0", Offset = "0x4179A0", Length = "0x65")]
	[Token(Token = "0x600222B")]
	public static extern IntPtr new_VoiceChannelPushToTalkKeyChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600222C")]
	[Address(RVA = "0x3E6980", Offset = "0x3E5180", Length = "0x85")]
	public static extern void VoiceChannelPushToTalkKeyChangedEvent_push_to_talk_hot_key_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600222D")]
	[Address(RVA = "0x3E6900", Offset = "0x3E5100", Length = "0x78")]
	public static extern uint VoiceChannelPushToTalkKeyChangedEvent_push_to_talk_hot_key_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600222E")]
	[Address(RVA = "0x419210", Offset = "0x417A10", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelPushToTalkKeyChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F88B0", Offset = "0x3F70B0", Length = "0x78")]
	[Token(Token = "0x600222F")]
	public static extern void delete_VoiceChannelPushToTalkKeyChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7380", Offset = "0x3E5B80", Length = "0x87")]
	[Token(Token = "0x6002230")]
	public static extern void VoiceChannelUsersSpeakingStateChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E7300", Offset = "0x3E5B00", Length = "0x78")]
	[Token(Token = "0x6002231")]
	public static extern IntPtr VoiceChannelUsersSpeakingStateChangedEvent_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002232")]
	[Address(RVA = "0x3E7270", Offset = "0x3E5A70", Length = "0x87")]
	public static extern void VoiceChannelUsersSpeakingStateChangedEvent_users_speaking_state_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002233")]
	[Address(RVA = "0x3E71F0", Offset = "0x3E59F0", Length = "0x78")]
	public static extern IntPtr VoiceChannelUsersSpeakingStateChangedEvent_users_speaking_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x419470", Offset = "0x417C70", Length = "0x65")]
	[Token(Token = "0x6002234")]
	public static extern IntPtr new_VoiceChannelUsersSpeakingStateChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002235")]
	[Address(RVA = "0x4194E0", Offset = "0x417CE0", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelUsersSpeakingStateChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002236")]
	[Address(RVA = "0x3F8A30", Offset = "0x3F7230", Length = "0x78")]
	public static extern void delete_VoiceChannelUsersSpeakingStateChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E70E0", Offset = "0x3E58E0", Length = "0x87")]
	[Token(Token = "0x6002237")]
	public static extern void VoiceChannelSpeakingUsersChangedEvent_voice_channel_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002238")]
	[Address(RVA = "0x3E7060", Offset = "0x3E5860", Length = "0x78")]
	public static extern IntPtr VoiceChannelSpeakingUsersChangedEvent_voice_channel_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E6FD0", Offset = "0x3E57D0", Length = "0x87")]
	[Token(Token = "0x6002239")]
	public static extern void VoiceChannelSpeakingUsersChangedEvent_speaking_users_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600223A")]
	[Address(RVA = "0x3E6F50", Offset = "0x3E5750", Length = "0x78")]
	public static extern IntPtr VoiceChannelSpeakingUsersChangedEvent_speaking_users_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600223B")]
	[Address(RVA = "0x3E6EC0", Offset = "0x3E56C0", Length = "0x87")]
	public static extern void VoiceChannelSpeakingUsersChangedEvent_not_speaking_users_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600223C")]
	[Address(RVA = "0x3E6E40", Offset = "0x3E5640", Length = "0x78")]
	public static extern IntPtr VoiceChannelSpeakingUsersChangedEvent_not_speaking_users_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600223D")]
	[Address(RVA = "0x419380", Offset = "0x417B80", Length = "0x65")]
	public static extern IntPtr new_VoiceChannelSpeakingUsersChangedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x600223E")]
	[Address(RVA = "0x4193F0", Offset = "0x417BF0", Length = "0x78")]
	public static extern IntPtr new_VoiceChannelSpeakingUsersChangedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600223F")]
	[Address(RVA = "0x3F89B0", Offset = "0x3F71B0", Length = "0x78")]
	public static extern void delete_VoiceChannelSpeakingUsersChangedEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002240")]
	[Address(RVA = "0x419560", Offset = "0x417D60", Length = "0x65")]
	public static extern IntPtr new_VoiceDataCapturedEvent__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002241")]
	[Address(RVA = "0x3E7510", Offset = "0x3E5D10", Length = "0x86")]
	public static extern void VoiceDataCapturedEvent_is_last_package_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002242")]
	[Address(RVA = "0x3E7490", Offset = "0x3E5C90", Length = "0x7D")]
	public static extern bool VoiceDataCapturedEvent_is_last_package_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002243")]
	[Address(RVA = "0x4195D0", Offset = "0x417DD0", Length = "0x78")]
	public static extern IntPtr new_VoiceDataCapturedEvent__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F8AB0", Offset = "0x3F72B0", Length = "0x78")]
	[Token(Token = "0x6002244")]
	public static extern void delete_VoiceDataCapturedEvent(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002245")]
	[Address(RVA = "0x415D90", Offset = "0x414590", Length = "0x65")]
	public static extern IntPtr new_RailTextInputWindowOption__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002246")]
	[Address(RVA = "0x3DC920", Offset = "0x3DB120", Length = "0x86")]
	public static extern void RailTextInputWindowOption_show_password_input_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DC8A0", Offset = "0x3DB0A0", Length = "0x7D")]
	[Token(Token = "0x6002247")]
	public static extern bool RailTextInputWindowOption_show_password_input_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002248")]
	[Address(RVA = "0x3DC4E0", Offset = "0x3DACE0", Length = "0x86")]
	public static extern void RailTextInputWindowOption_enable_multi_line_edit_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002249")]
	[Address(RVA = "0x3DC460", Offset = "0x3DAC60", Length = "0x7D")]
	public static extern bool RailTextInputWindowOption_enable_multi_line_edit_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600224A")]
	[Address(RVA = "0x3DC070", Offset = "0x3DA870", Length = "0x86")]
	public static extern void RailTextInputWindowOption_auto_cancel_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DBFF0", Offset = "0x3DA7F0", Length = "0x7D")]
	[Token(Token = "0x600224B")]
	public static extern bool RailTextInputWindowOption_auto_cancel_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DC180", Offset = "0x3DA980", Length = "0x9B")]
	[Token(Token = "0x600224C")]
	public static extern void RailTextInputWindowOption_caption_text_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DC100", Offset = "0x3DA900", Length = "0x78")]
	[Token(Token = "0x600224D")]
	public static extern IntPtr RailTextInputWindowOption_caption_text_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600224E")]
	[Address(RVA = "0x3DC3C0", Offset = "0x3DABC0", Length = "0x9B")]
	public static extern void RailTextInputWindowOption_description_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600224F")]
	[Address(RVA = "0x3DC340", Offset = "0x3DAB40", Length = "0x78")]
	public static extern IntPtr RailTextInputWindowOption_description_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002250")]
	[Address(RVA = "0x3DC2A0", Offset = "0x3DAAA0", Length = "0x9B")]
	public static extern void RailTextInputWindowOption_content_placeholder_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002251")]
	[Address(RVA = "0x3DC220", Offset = "0x3DAA20", Length = "0x78")]
	public static extern IntPtr RailTextInputWindowOption_content_placeholder_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002252")]
	[Address(RVA = "0x3DC5F0", Offset = "0x3DADF0", Length = "0x86")]
	public static extern void RailTextInputWindowOption_is_min_window_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002253")]
	[Address(RVA = "0x3DC570", Offset = "0x3DAD70", Length = "0x7D")]
	public static extern bool RailTextInputWindowOption_is_min_window_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002254")]
	[Address(RVA = "0x3DC700", Offset = "0x3DAF00", Length = "0x85")]
	public static extern void RailTextInputWindowOption_position_left_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002255")]
	[Address(RVA = "0x3DC680", Offset = "0x3DAE80", Length = "0x78")]
	public static extern uint RailTextInputWindowOption_position_left_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002256")]
	[Address(RVA = "0x3DC810", Offset = "0x3DB010", Length = "0x85")]
	public static extern void RailTextInputWindowOption_position_top_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002257")]
	[Address(RVA = "0x3DC790", Offset = "0x3DAF90", Length = "0x78")]
	public static extern uint RailTextInputWindowOption_position_top_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002258")]
	[Address(RVA = "0x415E00", Offset = "0x414600", Length = "0x78")]
	public static extern IntPtr new_RailTextInputWindowOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6D30", Offset = "0x3F5530", Length = "0x78")]
	[Token(Token = "0x6002259")]
	public static extern void delete_RailTextInputWindowOption(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600225A")]
	[Address(RVA = "0x415CA0", Offset = "0x4144A0", Length = "0x65")]
	public static extern IntPtr new_RailTextInputResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DBF50", Offset = "0x3DA750", Length = "0x9B")]
	[Token(Token = "0x600225B")]
	public static extern void RailTextInputResult_content_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3DBED0", Offset = "0x3DA6D0", Length = "0x78")]
	[Token(Token = "0x600225C")]
	public static extern IntPtr RailTextInputResult_content_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600225D")]
	[Address(RVA = "0x415D10", Offset = "0x414510", Length = "0x78")]
	public static extern IntPtr new_RailTextInputResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6CB0", Offset = "0x3F54B0", Length = "0x78")]
	[Token(Token = "0x600225E")]
	public static extern void delete_RailTextInputResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600225F")]
	[Address(RVA = "0x3F8B30", Offset = "0x3F7330", Length = "0x65")]
	public static extern uint kRailMaxGameDefinePlayingStateValue_get();

	[PreserveSig]
	[Token(Token = "0x6002260")]
	[Address(RVA = "0x405BB0", Offset = "0x4043B0", Length = "0x65")]
	public static extern IntPtr new_RailBranchInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3BAB40", Offset = "0x3B9340", Length = "0x9B")]
	[Token(Token = "0x6002261")]
	public static extern void RailBranchInfo_branch_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BAAC0", Offset = "0x3B92C0", Length = "0x78")]
	[Token(Token = "0x6002262")]
	public static extern IntPtr RailBranchInfo_branch_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002263")]
	[Address(RVA = "0x3BAC60", Offset = "0x3B9460", Length = "0x9B")]
	public static extern void RailBranchInfo_branch_type_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002264")]
	[Address(RVA = "0x3BABE0", Offset = "0x3B93E0", Length = "0x78")]
	public static extern IntPtr RailBranchInfo_branch_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002265")]
	[Address(RVA = "0x3BAA20", Offset = "0x3B9220", Length = "0x9B")]
	public static extern void RailBranchInfo_branch_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002266")]
	[Address(RVA = "0x3BA9A0", Offset = "0x3B91A0", Length = "0x78")]
	public static extern IntPtr RailBranchInfo_branch_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BAD80", Offset = "0x3B9580", Length = "0x9B")]
	[Token(Token = "0x6002267")]
	public static extern void RailBranchInfo_build_number_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3BAD00", Offset = "0x3B9500", Length = "0x78")]
	[Token(Token = "0x6002268")]
	public static extern IntPtr RailBranchInfo_build_number_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x405C20", Offset = "0x404420", Length = "0x78")]
	[Token(Token = "0x6002269")]
	public static extern IntPtr new_RailBranchInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600226A")]
	[Address(RVA = "0x3EE2B0", Offset = "0x3ECAB0", Length = "0x78")]
	public static extern void delete_RailBranchInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412270", Offset = "0x410A70", Length = "0x65")]
	[Token(Token = "0x600226B")]
	public static extern IntPtr new_RailGameDefineGamePlayingState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D0220", Offset = "0x3CEA20", Length = "0x85")]
	[Token(Token = "0x600226C")]
	public static extern void RailGameDefineGamePlayingState_game_define_game_playing_state_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600226D")]
	[Address(RVA = "0x3D01A0", Offset = "0x3CE9A0", Length = "0x78")]
	public static extern uint RailGameDefineGamePlayingState_game_define_game_playing_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600226E")]
	[Address(RVA = "0x3D0450", Offset = "0x3CEC50", Length = "0x9B")]
	public static extern void RailGameDefineGamePlayingState_state_name_zh_cn_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D03D0", Offset = "0x3CEBD0", Length = "0x78")]
	[Token(Token = "0x600226F")]
	public static extern IntPtr RailGameDefineGamePlayingState_state_name_zh_cn_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002270")]
	[Address(RVA = "0x3D0330", Offset = "0x3CEB30", Length = "0x9B")]
	public static extern void RailGameDefineGamePlayingState_state_name_en_us_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002271")]
	[Address(RVA = "0x3D02B0", Offset = "0x3CEAB0", Length = "0x78")]
	public static extern IntPtr RailGameDefineGamePlayingState_state_name_en_us_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002272")]
	[Address(RVA = "0x4122E0", Offset = "0x410AE0", Length = "0x78")]
	public static extern IntPtr new_RailGameDefineGamePlayingState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002273")]
	[Address(RVA = "0x3F4D30", Offset = "0x3F3530", Length = "0x78")]
	public static extern void delete_RailGameDefineGamePlayingState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002274")]
	[Address(RVA = "0x3FF410", Offset = "0x3FDC10", Length = "0x65")]
	public static extern IntPtr new_QuerySubscribeWishPlayStateResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3AA980", Offset = "0x3A9180", Length = "0x86")]
	[Token(Token = "0x6002275")]
	public static extern void QuerySubscribeWishPlayStateResult_is_subscribed_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3AA900", Offset = "0x3A9100", Length = "0x7D")]
	[Token(Token = "0x6002276")]
	public static extern bool QuerySubscribeWishPlayStateResult_is_subscribed_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002277")]
	[Address(RVA = "0x3FF480", Offset = "0x3FDC80", Length = "0x78")]
	public static extern IntPtr new_QuerySubscribeWishPlayStateResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002278")]
	[Address(RVA = "0x3EC7B0", Offset = "0x3EAFB0", Length = "0x78")]
	public static extern void delete_QuerySubscribeWishPlayStateResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x416D80", Offset = "0x415580", Length = "0x65")]
	[Token(Token = "0x6002279")]
	public static extern IntPtr new_RailWindowPosition__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DF960", Offset = "0x3DE160", Length = "0x85")]
	[Token(Token = "0x600227A")]
	public static extern void RailWindowPosition_position_left_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600227B")]
	[Address(RVA = "0x3DF8E0", Offset = "0x3DE0E0", Length = "0x78")]
	public static extern uint RailWindowPosition_position_left_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600227C")]
	[Address(RVA = "0x3DFA70", Offset = "0x3DE270", Length = "0x85")]
	public static extern void RailWindowPosition_position_top_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600227D")]
	[Address(RVA = "0x3DF9F0", Offset = "0x3DE1F0", Length = "0x78")]
	public static extern uint RailWindowPosition_position_top_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600227E")]
	[Address(RVA = "0x416DF0", Offset = "0x4155F0", Length = "0x78")]
	public static extern IntPtr new_RailWindowPosition__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600227F")]
	[Address(RVA = "0x3F75B0", Offset = "0x3F5DB0", Length = "0x78")]
	public static extern void delete_RailWindowPosition(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x415BB0", Offset = "0x4143B0", Length = "0x65")]
	[Token(Token = "0x6002280")]
	public static extern IntPtr new_RailTextInputImeWindowOption__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3DBCB0", Offset = "0x3DA4B0", Length = "0x87")]
	[Token(Token = "0x6002281")]
	public static extern void RailTextInputImeWindowOption_position_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002282")]
	[Address(RVA = "0x3DBC30", Offset = "0x3DA430", Length = "0x78")]
	public static extern IntPtr RailTextInputImeWindowOption_position_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002283")]
	[Address(RVA = "0x3DBDC0", Offset = "0x3DA5C0", Length = "0x86")]
	public static extern void RailTextInputImeWindowOption_show_rail_ime_window_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002284")]
	[Address(RVA = "0x3DBD40", Offset = "0x3DA540", Length = "0x7D")]
	public static extern bool RailTextInputImeWindowOption_show_rail_ime_window_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002285")]
	[Address(RVA = "0x415C20", Offset = "0x414420", Length = "0x78")]
	public static extern IntPtr new_RailTextInputImeWindowOption__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002286")]
	[Address(RVA = "0x3F6C30", Offset = "0x3F5430", Length = "0x78")]
	public static extern void delete_RailTextInputImeWindowOption(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412DB0", Offset = "0x4115B0", Length = "0x65")]
	[Token(Token = "0x6002287")]
	public static extern IntPtr new_RailIMEHelperTextInputCompositionState__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002288")]
	[Address(RVA = "0x3D2140", Offset = "0x3D0940", Length = "0x9B")]
	public static extern void RailIMEHelperTextInputCompositionState_composition_text_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D20C0", Offset = "0x3D08C0", Length = "0x78")]
	[Token(Token = "0x6002289")]
	public static extern IntPtr RailIMEHelperTextInputCompositionState_composition_text_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600228A")]
	[Address(RVA = "0x3D2030", Offset = "0x3D0830", Length = "0x85")]
	public static extern void RailIMEHelperTextInputCompositionState_composition_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D1FB0", Offset = "0x3D07B0", Length = "0x78")]
	[Token(Token = "0x600228B")]
	public static extern int RailIMEHelperTextInputCompositionState_composition_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600228C")]
	[Address(RVA = "0x412E20", Offset = "0x411620", Length = "0x78")]
	public static extern IntPtr new_RailIMEHelperTextInputCompositionState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600228D")]
	[Address(RVA = "0x3F5330", Offset = "0x3F3B30", Length = "0x78")]
	public static extern void delete_RailIMEHelperTextInputCompositionState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412EA0", Offset = "0x4116A0", Length = "0x65")]
	[Token(Token = "0x600228E")]
	public static extern IntPtr new_RailIMEHelperTextInputSelectedResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D22E0", Offset = "0x3D0AE0", Length = "0x9B")]
	[Token(Token = "0x600228F")]
	public static extern void RailIMEHelperTextInputSelectedResult_content_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D2260", Offset = "0x3D0A60", Length = "0x78")]
	[Token(Token = "0x6002290")]
	public static extern IntPtr RailIMEHelperTextInputSelectedResult_content_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412F10", Offset = "0x411710", Length = "0x78")]
	[Token(Token = "0x6002291")]
	public static extern IntPtr new_RailIMEHelperTextInputSelectedResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F53B0", Offset = "0x3F3BB0", Length = "0x78")]
	[Token(Token = "0x6002292")]
	public static extern void delete_RailIMEHelperTextInputSelectedResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002293")]
	[Address(RVA = "0x412BD0", Offset = "0x4113D0", Length = "0x65")]
	public static extern IntPtr new_RailHttpSessionResponse__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002294")]
	[Address(RVA = "0x3D1C80", Offset = "0x3D0480", Length = "0x9B")]
	public static extern void RailHttpSessionResponse_http_response_data_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002295")]
	[Address(RVA = "0x3D1C00", Offset = "0x3D0400", Length = "0x78")]
	public static extern IntPtr RailHttpSessionResponse_http_response_data_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412C40", Offset = "0x411440", Length = "0x78")]
	[Token(Token = "0x6002296")]
	public static extern IntPtr new_RailHttpSessionResponse__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002297")]
	[Address(RVA = "0x3F5230", Offset = "0x3F3A30", Length = "0x78")]
	public static extern void delete_RailHttpSessionResponse(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414E70", Offset = "0x413670", Length = "0x65")]
	[Token(Token = "0x6002298")]
	public static extern IntPtr new_RailSmallObjectState__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D8910", Offset = "0x3D7110", Length = "0x85")]
	[Token(Token = "0x6002299")]
	public static extern void RailSmallObjectState_update_state_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D8890", Offset = "0x3D7090", Length = "0x78")]
	[Token(Token = "0x600229A")]
	public static extern int RailSmallObjectState_update_state_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D8800", Offset = "0x3D7000", Length = "0x85")]
	[Token(Token = "0x600229B")]
	public static extern void RailSmallObjectState_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D8780", Offset = "0x3D6F80", Length = "0x78")]
	[Token(Token = "0x600229C")]
	public static extern uint RailSmallObjectState_index_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414EE0", Offset = "0x4136E0", Length = "0x78")]
	[Token(Token = "0x600229D")]
	public static extern IntPtr new_RailSmallObjectState__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6530", Offset = "0x3F4D30", Length = "0x78")]
	[Token(Token = "0x600229E")]
	public static extern void delete_RailSmallObjectState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x414BA0", Offset = "0x4133A0", Length = "0x65")]
	[Token(Token = "0x600229F")]
	public static extern IntPtr new_RailSmallObjectDownloadInfo__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x3D82C0", Offset = "0x3D6AC0", Length = "0x85")]
	public static extern void RailSmallObjectDownloadInfo_index_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D8240", Offset = "0x3D6A40", Length = "0x78")]
	[Token(Token = "0x60022A1")]
	public static extern uint RailSmallObjectDownloadInfo_index_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x3D83D0", Offset = "0x3D6BD0", Length = "0x85")]
	public static extern void RailSmallObjectDownloadInfo_result_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x3D8350", Offset = "0x3D6B50", Length = "0x78")]
	public static extern int RailSmallObjectDownloadInfo_result_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x414C10", Offset = "0x413410", Length = "0x78")]
	public static extern IntPtr new_RailSmallObjectDownloadInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F63B0", Offset = "0x3F4BB0", Length = "0x78")]
	[Token(Token = "0x60022A5")]
	public static extern void delete_RailSmallObjectDownloadInfo(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D86F0", Offset = "0x3D6EF0", Length = "0x87")]
	[Token(Token = "0x60022A6")]
	public static extern void RailSmallObjectStateQueryResult_objects_state_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60022A7")]
	[Address(RVA = "0x3D8670", Offset = "0x3D6E70", Length = "0x78")]
	public static extern IntPtr RailSmallObjectStateQueryResult_objects_state_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022A8")]
	[Address(RVA = "0x414D80", Offset = "0x413580", Length = "0x65")]
	public static extern IntPtr new_RailSmallObjectStateQueryResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022A9")]
	[Address(RVA = "0x414DF0", Offset = "0x4135F0", Length = "0x78")]
	public static extern IntPtr new_RailSmallObjectStateQueryResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F64B0", Offset = "0x3F4CB0", Length = "0x78")]
	[Token(Token = "0x60022AA")]
	public static extern void delete_RailSmallObjectStateQueryResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D8560", Offset = "0x3D6D60", Length = "0x87")]
	[Token(Token = "0x60022AB")]
	public static extern void RailSmallObjectDownloadResult_download_infos_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x3D84E0", Offset = "0x3D6CE0", Length = "0x78")]
	public static extern IntPtr RailSmallObjectDownloadResult_download_infos_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x414C90", Offset = "0x413490", Length = "0x65")]
	public static extern IntPtr new_RailSmallObjectDownloadResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x414D00", Offset = "0x413500", Length = "0x78")]
	public static extern IntPtr new_RailSmallObjectDownloadResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022AF")]
	[Address(RVA = "0x3F6430", Offset = "0x3F4C30", Length = "0x78")]
	public static extern void delete_RailSmallObjectDownloadResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4158E0", Offset = "0x4140E0", Length = "0x65")]
	[Token(Token = "0x60022B0")]
	public static extern IntPtr new_RailSwitchPlayerSelectedZoneResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x415950", Offset = "0x414150", Length = "0x78")]
	public static extern IntPtr new_RailSwitchPlayerSelectedZoneResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6AB0", Offset = "0x3F52B0", Length = "0x78")]
	[Token(Token = "0x60022B2")]
	public static extern void delete_RailSwitchPlayerSelectedZoneResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x412AE0", Offset = "0x4112E0", Length = "0x65")]
	public static extern IntPtr new_RailGroupInfo__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3D19C0", Offset = "0x3D01C0", Length = "0x9B")]
	[Token(Token = "0x60022B4")]
	public static extern void RailGroupInfo_group_id_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D1940", Offset = "0x3D0140", Length = "0x78")]
	[Token(Token = "0x60022B5")]
	public static extern IntPtr RailGroupInfo_group_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D1AE0", Offset = "0x3D02E0", Length = "0x9B")]
	[Token(Token = "0x60022B6")]
	public static extern void RailGroupInfo_group_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D1A60", Offset = "0x3D0260", Length = "0x78")]
	[Token(Token = "0x60022B7")]
	public static extern IntPtr RailGroupInfo_group_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D18A0", Offset = "0x3D00A0", Length = "0x9B")]
	[Token(Token = "0x60022B8")]
	public static extern void RailGroupInfo_group_icon_url_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D1820", Offset = "0x3D0020", Length = "0x78")]
	[Token(Token = "0x60022B9")]
	public static extern IntPtr RailGroupInfo_group_icon_url_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x412B50", Offset = "0x411350", Length = "0x78")]
	[Token(Token = "0x60022BA")]
	public static extern IntPtr new_RailGroupInfo__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022BB")]
	[Address(RVA = "0x3F51B0", Offset = "0x3F39B0", Length = "0x78")]
	public static extern void delete_RailGroupInfo(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022BC")]
	[Address(RVA = "0x414770", Offset = "0x412F70", Length = "0x65")]
	public static extern IntPtr new_RailQueryGroupsInfoResult__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022BD")]
	[Address(RVA = "0x3D7600", Offset = "0x3D5E00", Length = "0x87")]
	public static extern void RailQueryGroupsInfoResult_group_ids_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3D7580", Offset = "0x3D5D80", Length = "0x78")]
	[Token(Token = "0x60022BE")]
	public static extern IntPtr RailQueryGroupsInfoResult_group_ids_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022BF")]
	[Address(RVA = "0x4147E0", Offset = "0x412FE0", Length = "0x78")]
	public static extern IntPtr new_RailQueryGroupsInfoResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F6130", Offset = "0x3F4930", Length = "0x78")]
	[Token(Token = "0x60022C0")]
	public static extern void delete_RailQueryGroupsInfoResult(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022C1")]
	[Address(RVA = "0x413E10", Offset = "0x412610", Length = "0x65")]
	public static extern IntPtr new_RailOpenGroupChatResult__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x413E80", Offset = "0x412680", Length = "0x78")]
	[Token(Token = "0x60022C2")]
	public static extern IntPtr new_RailOpenGroupChatResult__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F5C30", Offset = "0x3F4430", Length = "0x78")]
	[Token(Token = "0x60022C3")]
	public static extern void delete_RailOpenGroupChatResult(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38DDD0", Offset = "0x38C5D0", Length = "0x87")]
	[Token(Token = "0x60022C4")]
	public static extern IntPtr IRailAchievementHelper_CreatePlayerAchievement(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38DE60", Offset = "0x38C660", Length = "0x78")]
	[Token(Token = "0x60022C5")]
	public static extern IntPtr IRailAchievementHelper_GetGlobalAchievement(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022C6")]
	[Address(RVA = "0x3E9BB0", Offset = "0x3E83B0", Length = "0x78")]
	public static extern void delete_IRailAchievementHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022C7")]
	[Address(RVA = "0x399DF0", Offset = "0x3985F0", Length = "0x78")]
	public static extern IntPtr IRailPlayerAchievement_GetRailID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x399840", Offset = "0x398040", Length = "0xA6")]
	[Token(Token = "0x60022C8")]
	public static extern int IRailPlayerAchievement_AsyncRequestAchievement(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x399E70", Offset = "0x398670", Length = "0xC9")]
	[Token(Token = "0x60022C9")]
	public static extern int IRailPlayerAchievement_HasAchieved(IntPtr jarg1, string jarg2, out bool jarg3);

	[PreserveSig]
	[Address(RVA = "0x399CB0", Offset = "0x3984B0", Length = "0xAC")]
	[Token(Token = "0x60022CA")]
	public static extern int IRailPlayerAchievement_GetAchievementInfo(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x3999A0", Offset = "0x3981A0", Length = "0xE3")]
	[Token(Token = "0x60022CB")]
	public static extern int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5);

	[PreserveSig]
	[Address(RVA = "0x399A90", Offset = "0x398290", Length = "0xBB")]
	[Token(Token = "0x60022CC")]
	public static extern int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x60022CD")]
	[Address(RVA = "0x399B50", Offset = "0x398350", Length = "0xAC")]
	public static extern int IRailPlayerAchievement_AsyncTriggerAchievementProgress__SWIG_2(IntPtr jarg1, string jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60022CE")]
	[Address(RVA = "0x399F40", Offset = "0x398740", Length = "0xA6")]
	public static extern int IRailPlayerAchievement_MakeAchievement(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60022CF")]
	[Address(RVA = "0x399C00", Offset = "0x398400", Length = "0xA6")]
	public static extern int IRailPlayerAchievement_CancelAchievement(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3998F0", Offset = "0x3980F0", Length = "0xA6")]
	[Token(Token = "0x60022D0")]
	public static extern int IRailPlayerAchievement_AsyncStoreAchievement(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60022D1")]
	[Address(RVA = "0x399FF0", Offset = "0x3987F0", Length = "0x78")]
	public static extern int IRailPlayerAchievement_ResetAllAchievements(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x399D60", Offset = "0x398560", Length = "0x87")]
	[Token(Token = "0x60022D2")]
	public static extern int IRailPlayerAchievement_GetAllAchievementsName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EAB30", Offset = "0x3E9330", Length = "0x78")]
	[Token(Token = "0x60022D3")]
	public static extern void delete_IRailPlayerAchievement(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396160", Offset = "0x394960", Length = "0xA6")]
	[Token(Token = "0x60022D4")]
	public static extern int IRailGlobalAchievement_AsyncRequestAchievement(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x3962B0", Offset = "0x394AB0", Length = "0xAC")]
	public static extern int IRailGlobalAchievement_GetGlobalAchievedPercent(IntPtr jarg1, string jarg2, out double jarg3);

	[PreserveSig]
	[Address(RVA = "0x396210", Offset = "0x394A10", Length = "0xA0")]
	[Token(Token = "0x60022D6")]
	public static extern int IRailGlobalAchievement_GetGlobalAchievedPercentDescending(IntPtr jarg1, int jarg2, IntPtr jarg3, out double jarg4);

	[PreserveSig]
	[Address(RVA = "0x3EA3B0", Offset = "0x3E8BB0", Length = "0x78")]
	[Token(Token = "0x60022D7")]
	public static extern void delete_IRailGlobalAchievement(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x3FEAB0", Offset = "0x3FD2B0", Length = "0x65")]
	public static extern IntPtr new_PlayerAchievementReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x3FEB20", Offset = "0x3FD320", Length = "0x78")]
	public static extern IntPtr new_PlayerAchievementReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC2B0", Offset = "0x3EAAB0", Length = "0x78")]
	[Token(Token = "0x60022DA")]
	public static extern void delete_PlayerAchievementReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FEBA0", Offset = "0x3FD3A0", Length = "0x65")]
	[Token(Token = "0x60022DB")]
	public static extern IntPtr new_PlayerAchievementStored__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60022DC")]
	[Address(RVA = "0x3A95D0", Offset = "0x3A7DD0", Length = "0x86")]
	public static extern void PlayerAchievementStored_group_achievement_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9550", Offset = "0x3A7D50", Length = "0x7D")]
	[Token(Token = "0x60022DD")]
	public static extern bool PlayerAchievementStored_group_achievement_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022DE")]
	[Address(RVA = "0x3A93A0", Offset = "0x3A7BA0", Length = "0x9B")]
	public static extern void PlayerAchievementStored_achievement_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60022DF")]
	[Address(RVA = "0x3A9320", Offset = "0x3A7B20", Length = "0x78")]
	public static extern IntPtr PlayerAchievementStored_achievement_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022E0")]
	[Address(RVA = "0x3A94C0", Offset = "0x3A7CC0", Length = "0x85")]
	public static extern void PlayerAchievementStored_current_progress_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A9440", Offset = "0x3A7C40", Length = "0x78")]
	[Token(Token = "0x60022E1")]
	public static extern uint PlayerAchievementStored_current_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A96E0", Offset = "0x3A7EE0", Length = "0x85")]
	[Token(Token = "0x60022E2")]
	public static extern void PlayerAchievementStored_max_progress_set(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x60022E3")]
	[Address(RVA = "0x3A9660", Offset = "0x3A7E60", Length = "0x78")]
	public static extern uint PlayerAchievementStored_max_progress_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022E4")]
	[Address(RVA = "0x3FEC10", Offset = "0x3FD410", Length = "0x78")]
	public static extern IntPtr new_PlayerAchievementStored__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EC330", Offset = "0x3EAB30", Length = "0x78")]
	[Token(Token = "0x60022E5")]
	public static extern void delete_PlayerAchievementStored(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022E6")]
	[Address(RVA = "0x3FD070", Offset = "0x3FB870", Length = "0x65")]
	public static extern IntPtr new_GlobalAchievementReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x38DCC0", Offset = "0x38C4C0", Length = "0x85")]
	[Token(Token = "0x60022E7")]
	public static extern void GlobalAchievementReceived_count_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x38DC40", Offset = "0x38C440", Length = "0x78")]
	[Token(Token = "0x60022E8")]
	public static extern int GlobalAchievementReceived_count_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD0E0", Offset = "0x3FB8E0", Length = "0x78")]
	[Token(Token = "0x60022E9")]
	public static extern IntPtr new_GlobalAchievementReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022EA")]
	[Address(RVA = "0x3E9AB0", Offset = "0x3E82B0", Length = "0x78")]
	public static extern void delete_GlobalAchievementReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022EB")]
	[Address(RVA = "0x38E030", Offset = "0x38C830", Length = "0x78")]
	public static extern IntPtr IRailAssetsHelper_OpenAssets(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38E0B0", Offset = "0x38C8B0", Length = "0x78")]
	[Token(Token = "0x60022EC")]
	public static extern IntPtr IRailAssetsHelper_OpenGameServerAssets(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022ED")]
	[Address(RVA = "0x3E9CB0", Offset = "0x3E84B0", Length = "0x78")]
	public static extern void delete_IRailAssetsHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022EE")]
	[Address(RVA = "0x38E5F0", Offset = "0x38CDF0", Length = "0xA6")]
	public static extern int IRailAssets_AsyncRequestAllAssets(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60022EF")]
	[Address(RVA = "0x38EB60", Offset = "0x38D360", Length = "0x93")]
	public static extern int IRailAssets_QueryAssetInfo(IntPtr jarg1, ulong jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x38E900", Offset = "0x38D100", Length = "0xB5")]
	[Token(Token = "0x60022F0")]
	public static extern int IRailAssets_AsyncUpdateAssetsProperty(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x38E200", Offset = "0x38CA00", Length = "0xB5")]
	[Token(Token = "0x60022F1")]
	public static extern int IRailAssets_AsyncDirectConsumeAssets(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x38E840", Offset = "0x38D040", Length = "0xB5")]
	[Token(Token = "0x60022F2")]
	public static extern int IRailAssets_AsyncStartConsumeAsset(IntPtr jarg1, ulong jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x38E9C0", Offset = "0x38D1C0", Length = "0xD9")]
	[Token(Token = "0x60022F3")]
	public static extern int IRailAssets_AsyncUpdateConsumeProgress(IntPtr jarg1, ulong jarg2, string jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x38E130", Offset = "0x38C930", Length = "0xC6")]
	[Token(Token = "0x60022F4")]
	public static extern int IRailAssets_AsyncCompleteConsumeAsset(IntPtr jarg1, ulong jarg2, uint jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x38E390", Offset = "0x38CB90", Length = "0xC6")]
	[Token(Token = "0x60022F5")]
	public static extern int IRailAssets_AsyncExchangeAssets(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x38E2C0", Offset = "0x38CAC0", Length = "0xD0")]
	[Token(Token = "0x60022F6")]
	public static extern int IRailAssets_AsyncExchangeAssetsTo(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, ulong jarg4, string jarg5);

	[PreserveSig]
	[Token(Token = "0x60022F7")]
	[Address(RVA = "0x38E770", Offset = "0x38CF70", Length = "0xC6")]
	public static extern int IRailAssets_AsyncSplitAsset(IntPtr jarg1, ulong jarg2, uint jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x38E6A0", Offset = "0x38CEA0", Length = "0xD0")]
	[Token(Token = "0x60022F8")]
	public static extern int IRailAssets_AsyncSplitAssetTo(IntPtr jarg1, ulong jarg2, uint jarg3, ulong jarg4, string jarg5);

	[PreserveSig]
	[Token(Token = "0x60022F9")]
	[Address(RVA = "0x38E530", Offset = "0x38CD30", Length = "0xB5")]
	public static extern int IRailAssets_AsyncMergeAsset(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x38E460", Offset = "0x38CC60", Length = "0xC6")]
	[Token(Token = "0x60022FA")]
	public static extern int IRailAssets_AsyncMergeAssetTo(IntPtr jarg1, IntPtr jarg2, ulong jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x38EC80", Offset = "0x38D480", Length = "0x87")]
	[Token(Token = "0x60022FB")]
	public static extern int IRailAssets_SerializeAssetsToBuffer__SWIG_0(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38ED10", Offset = "0x38D510", Length = "0x93")]
	[Token(Token = "0x60022FC")]
	public static extern int IRailAssets_SerializeAssetsToBuffer__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60022FD")]
	[Address(RVA = "0x38EAA0", Offset = "0x38D2A0", Length = "0xBB")]
	public static extern int IRailAssets_DeserializeAssetsFromBuffer(IntPtr jarg1, IntPtr jarg2, string jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x60022FE")]
	[Address(RVA = "0x3E9D30", Offset = "0x3E8530", Length = "0x78")]
	public static extern void delete_IRailAssets(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60022FF")]
	[Address(RVA = "0x38EDB0", Offset = "0x38D5B0", Length = "0xFF")]
	public static extern IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_0(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5, IntPtr jarg6, out RailResult jarg7);

	[PreserveSig]
	[Token(Token = "0x6002300")]
	[Address(RVA = "0x38EEB0", Offset = "0x38D6B0", Length = "0xF2")]
	public static extern IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_1(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5, IntPtr jarg6);

	[PreserveSig]
	[Token(Token = "0x6002301")]
	[Address(RVA = "0x38EFB0", Offset = "0x38D7B0", Length = "0xE5")]
	public static extern IntPtr IRailBrowserHelper_AsyncCreateBrowser__SWIG_2(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5);

	[PreserveSig]
	[Token(Token = "0x6002302")]
	[Address(RVA = "0x38F0A0", Offset = "0x38D8A0", Length = "0xE0")]
	public static extern IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_0(IntPtr jarg1, string jarg2, string jarg3, IntPtr jarg4, out RailResult jarg5);

	[PreserveSig]
	[Token(Token = "0x6002303")]
	[Address(RVA = "0x38F180", Offset = "0x38D980", Length = "0xD0")]
	public static extern IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_1(IntPtr jarg1, string jarg2, string jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x6002304")]
	[Address(RVA = "0x38F250", Offset = "0x38DA50", Length = "0xCA")]
	public static extern IntPtr IRailBrowserHelper_CreateCustomerDrawBrowser__SWIG_2(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002305")]
	[Address(RVA = "0x38F320", Offset = "0x38DB20", Length = "0xAD")]
	public static extern int IRailBrowserHelper_NavigateWebPage(IntPtr jarg1, string jarg2, bool jarg3);

	[PreserveSig]
	[Token(Token = "0x6002306")]
	[Address(RVA = "0x3E9DB0", Offset = "0x3E85B0", Length = "0x78")]
	public static extern void delete_IRailBrowserHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3901F0", Offset = "0x38E9F0", Length = "0x8C")]
	[Token(Token = "0x6002307")]
	public static extern bool IRailBrowser_GetCurrentUrl(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002308")]
	[Address(RVA = "0x390280", Offset = "0x38EA80", Length = "0xA9")]
	public static extern bool IRailBrowser_ReloadWithUrl__SWIG_0(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002309")]
	[Address(RVA = "0x390330", Offset = "0x38EB30", Length = "0x7D")]
	public static extern bool IRailBrowser_ReloadWithUrl__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3904B0", Offset = "0x38ECB0", Length = "0x78")]
	[Token(Token = "0x600230A")]
	public static extern void IRailBrowser_StopLoad(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390030", Offset = "0x38E830", Length = "0xA9")]
	[Token(Token = "0x600230B")]
	public static extern bool IRailBrowser_AddJavascriptEventListener(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600230C")]
	[Address(RVA = "0x3903B0", Offset = "0x38EBB0", Length = "0x7D")]
	public static extern bool IRailBrowser_RemoveAllJavascriptEventListener(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3900E0", Offset = "0x38E8E0", Length = "0x86")]
	[Token(Token = "0x600230D")]
	public static extern void IRailBrowser_AllowNavigateNewPage(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x390170", Offset = "0x38E970", Length = "0x78")]
	[Token(Token = "0x600230E")]
	public static extern void IRailBrowser_Close(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600230F")]
	[Address(RVA = "0x3E9EB0", Offset = "0x3E86B0", Length = "0x78")]
	public static extern void delete_IRailBrowser(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38F7B0", Offset = "0x38DFB0", Length = "0x8C")]
	[Token(Token = "0x6002310")]
	public static extern bool IRailBrowserRender_GetCurrentUrl(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38FBB0", Offset = "0x38E3B0", Length = "0xA9")]
	[Token(Token = "0x6002311")]
	public static extern bool IRailBrowserRender_ReloadWithUrl__SWIG_0(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002312")]
	[Address(RVA = "0x38FC60", Offset = "0x38E460", Length = "0x7D")]
	public static extern bool IRailBrowserRender_ReloadWithUrl__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002313")]
	[Address(RVA = "0x38FF00", Offset = "0x38E700", Length = "0x78")]
	public static extern void IRailBrowserRender_StopLoad(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38F3D0", Offset = "0x38DBD0", Length = "0xA9")]
	[Token(Token = "0x6002314")]
	public static extern bool IRailBrowserRender_AddJavascriptEventListener(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x38FCE0", Offset = "0x38E4E0", Length = "0x7D")]
	[Token(Token = "0x6002315")]
	public static extern bool IRailBrowserRender_RemoveAllJavascriptEventListener(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002316")]
	[Address(RVA = "0x38F480", Offset = "0x38DC80", Length = "0x86")]
	public static extern void IRailBrowserRender_AllowNavigateNewPage(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002317")]
	[Address(RVA = "0x38F510", Offset = "0x38DD10", Length = "0x78")]
	public static extern void IRailBrowserRender_Close(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38FF80", Offset = "0x38E780", Length = "0xAE")]
	[Token(Token = "0x6002318")]
	public static extern void IRailBrowserRender_UpdateCustomDrawWindowPos(IntPtr jarg1, int jarg2, int jarg3, uint jarg4, uint jarg5);

	[PreserveSig]
	[Address(RVA = "0x38FDE0", Offset = "0x38E5E0", Length = "0x86")]
	[Token(Token = "0x6002319")]
	public static extern void IRailBrowserRender_SetBrowserActive(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x38F840", Offset = "0x38E040", Length = "0x78")]
	[Token(Token = "0x600231A")]
	public static extern void IRailBrowserRender_GoBack(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38F8C0", Offset = "0x38E0C0", Length = "0x78")]
	[Token(Token = "0x600231B")]
	public static extern void IRailBrowserRender_GoForward(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600231C")]
	[Address(RVA = "0x38F6E0", Offset = "0x38DEE0", Length = "0xCB")]
	public static extern bool IRailBrowserRender_ExecuteJavascript(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x38F640", Offset = "0x38DE40", Length = "0xA0")]
	[Token(Token = "0x600231D")]
	public static extern void IRailBrowserRender_DispatchWindowsMessage(IntPtr jarg1, uint jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Address(RVA = "0x38F590", Offset = "0x38DD90", Length = "0xAE")]
	[Token(Token = "0x600231E")]
	public static extern void IRailBrowserRender_DispatchMouseMessage(IntPtr jarg1, int jarg2, uint jarg3, uint jarg4, uint jarg5);

	[PreserveSig]
	[Address(RVA = "0x38FB00", Offset = "0x38E300", Length = "0xAE")]
	[Token(Token = "0x600231F")]
	public static extern void IRailBrowserRender_MouseWheel(IntPtr jarg1, int jarg2, uint jarg3, uint jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6002320")]
	[Address(RVA = "0x38FE70", Offset = "0x38E670", Length = "0x86")]
	public static extern void IRailBrowserRender_SetFocus(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002321")]
	[Address(RVA = "0x38F9E0", Offset = "0x38E1E0", Length = "0x85")]
	public static extern void IRailBrowserRender_KeyDown(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002322")]
	[Address(RVA = "0x38FA70", Offset = "0x38E270", Length = "0x85")]
	public static extern void IRailBrowserRender_KeyUp(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002323")]
	[Address(RVA = "0x38F940", Offset = "0x38E140", Length = "0x92")]
	public static extern void IRailBrowserRender_KeyChar(IntPtr jarg1, uint jarg2, bool jarg3);

	[PreserveSig]
	[Token(Token = "0x6002324")]
	[Address(RVA = "0x3E9E30", Offset = "0x3E8630", Length = "0x78")]
	public static extern void delete_IRailBrowserRender(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3907A0", Offset = "0x38EFA0", Length = "0xB5")]
	[Token(Token = "0x6002325")]
	public static extern int IRailDlcHelper_AsyncQueryIsOwnedDlcsOnServer(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002326")]
	[Address(RVA = "0x390630", Offset = "0x38EE30", Length = "0xA6")]
	public static extern int IRailDlcHelper_AsyncCheckAllDlcsStateReady(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x390A40", Offset = "0x38F240", Length = "0x98")]
	[Token(Token = "0x6002327")]
	public static extern bool IRailDlcHelper_IsDlcInstalled__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x390AE0", Offset = "0x38F2E0", Length = "0x8C")]
	[Token(Token = "0x6002328")]
	public static extern bool IRailDlcHelper_IsDlcInstalled__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x390B70", Offset = "0x38F370", Length = "0x8C")]
	[Token(Token = "0x6002329")]
	public static extern bool IRailDlcHelper_IsOwnedDlc(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x390920", Offset = "0x38F120", Length = "0x78")]
	[Token(Token = "0x600232A")]
	public static extern uint IRailDlcHelper_GetDlcCount(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3909A0", Offset = "0x38F1A0", Length = "0x96")]
	[Token(Token = "0x600232B")]
	public static extern bool IRailDlcHelper_GetDlcInfo(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x600232C")]
	[Address(RVA = "0x3906E0", Offset = "0x38EEE0", Length = "0xB8")]
	public static extern bool IRailDlcHelper_AsyncInstallDlc(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600232D")]
	[Address(RVA = "0x390860", Offset = "0x38F060", Length = "0xB8")]
	public static extern bool IRailDlcHelper_AsyncRemoveDlc(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3E9F30", Offset = "0x3E8730", Length = "0x78")]
	[Token(Token = "0x600232E")]
	public static extern void delete_IRailDlcHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x392380", Offset = "0x390B80", Length = "0xB3")]
	[Token(Token = "0x600232F")]
	public static extern int IRailFloatingWindow_AsyncShowRailFloatingWindow(IntPtr jarg1, int jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392210", Offset = "0x390A10", Length = "0xB3")]
	[Token(Token = "0x6002330")]
	public static extern int IRailFloatingWindow_AsyncCloseRailFloatingWindow(IntPtr jarg1, int jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002331")]
	[Address(RVA = "0x392630", Offset = "0x390E30", Length = "0x91")]
	public static extern int IRailFloatingWindow_SetNotifyWindowPosition(IntPtr jarg1, int jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x392440", Offset = "0x390C40", Length = "0xC6")]
	[Token(Token = "0x6002332")]
	public static extern int IRailFloatingWindow_AsyncShowStoreWindow(IntPtr jarg1, ulong jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x392510", Offset = "0x390D10", Length = "0x7D")]
	[Token(Token = "0x6002333")]
	public static extern bool IRailFloatingWindow_IsFloatingWindowAvailable(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002334")]
	[Address(RVA = "0x3922D0", Offset = "0x390AD0", Length = "0xA6")]
	public static extern int IRailFloatingWindow_AsyncShowDefaultGameStoreWindow(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002335")]
	[Address(RVA = "0x392590", Offset = "0x390D90", Length = "0x92")]
	public static extern int IRailFloatingWindow_SetNotifyWindowEnable(IntPtr jarg1, int jarg2, bool jarg3);

	[PreserveSig]
	[Token(Token = "0x6002336")]
	[Address(RVA = "0x3EA130", Offset = "0x3E8930", Length = "0x78")]
	public static extern void delete_IRailFloatingWindow(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002337")]
	[Address(RVA = "0x3929D0", Offset = "0x3911D0", Length = "0xB5")]
	public static extern int IRailFriends_AsyncGetPersonalInfo(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392840", Offset = "0x391040", Length = "0xC6")]
	[Token(Token = "0x6002338")]
	public static extern int IRailFriends_AsyncGetFriendMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x392F10", Offset = "0x391710", Length = "0xB5")]
	[Token(Token = "0x6002339")]
	public static extern int IRailFriends_AsyncSetMyMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392790", Offset = "0x390F90", Length = "0xA6")]
	[Token(Token = "0x600233A")]
	public static extern int IRailFriends_AsyncClearAllMyMetadata(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x392E40", Offset = "0x391640", Length = "0xC8")]
	[Token(Token = "0x600233B")]
	public static extern int IRailFriends_AsyncSetInviteCommandLine(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392910", Offset = "0x391110", Length = "0xB5")]
	[Token(Token = "0x600233C")]
	public static extern int IRailFriends_AsyncGetInviteCommandLine(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392D80", Offset = "0x391580", Length = "0xB5")]
	[Token(Token = "0x600233D")]
	public static extern int IRailFriends_AsyncReportPlayedWithUserList(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600233E")]
	[Address(RVA = "0x393080", Offset = "0x391880", Length = "0x87")]
	public static extern int IRailFriends_GetFriendsList(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600233F")]
	[Address(RVA = "0x392A90", Offset = "0x391290", Length = "0xB5")]
	public static extern int IRailFriends_AsyncQueryFriendPlayedGamesInfo(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392C10", Offset = "0x391410", Length = "0xA6")]
	[Token(Token = "0x6002340")]
	public static extern int IRailFriends_AsyncQueryPlayedWithFriendsList(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x392CC0", Offset = "0x3914C0", Length = "0xB5")]
	[Token(Token = "0x6002341")]
	public static extern int IRailFriends_AsyncQueryPlayedWithFriendsTime(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x392B50", Offset = "0x391350", Length = "0xB5")]
	[Token(Token = "0x6002342")]
	public static extern int IRailFriends_AsyncQueryPlayedWithFriendsGames(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002343")]
	[Address(RVA = "0x3926D0", Offset = "0x390ED0", Length = "0xB5")]
	public static extern int IRailFriends_AsyncAddFriend(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002344")]
	[Address(RVA = "0x392FD0", Offset = "0x3917D0", Length = "0xA6")]
	public static extern int IRailFriends_AsyncUpdateFriendsData(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EA1B0", Offset = "0x3E89B0", Length = "0x78")]
	[Token(Token = "0x6002345")]
	public static extern void delete_IRailFriends(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x393720", Offset = "0x391F20", Length = "0xB5")]
	[Token(Token = "0x6002346")]
	public static extern int IRailGameServerHelper_AsyncGetGameServerPlayerList(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x393640", Offset = "0x391E40", Length = "0xDB")]
	[Token(Token = "0x6002347")]
	public static extern int IRailGameServerHelper_AsyncGetGameServerList(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6);

	[PreserveSig]
	[Address(RVA = "0x393260", Offset = "0x391A60", Length = "0xDB")]
	[Token(Token = "0x6002348")]
	public static extern IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002349")]
	[Address(RVA = "0x393340", Offset = "0x391B40", Length = "0xB7")]
	public static extern IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x393400", Offset = "0x391C00", Length = "0x87")]
	[Token(Token = "0x600234A")]
	public static extern IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_2(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600234B")]
	[Address(RVA = "0x393490", Offset = "0x391C90", Length = "0x78")]
	public static extern IntPtr IRailGameServerHelper_AsyncCreateGameServer__SWIG_3(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600234C")]
	[Address(RVA = "0x393510", Offset = "0x391D10", Length = "0xA6")]
	public static extern int IRailGameServerHelper_AsyncGetFavoriteGameServers__SWIG_0(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600234D")]
	[Address(RVA = "0x3935C0", Offset = "0x391DC0", Length = "0x78")]
	public static extern int IRailGameServerHelper_AsyncGetFavoriteGameServers__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600234E")]
	[Address(RVA = "0x393110", Offset = "0x391910", Length = "0xB5")]
	public static extern int IRailGameServerHelper_AsyncAddFavoriteGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3931D0", Offset = "0x3919D0", Length = "0x87")]
	[Token(Token = "0x600234F")]
	public static extern int IRailGameServerHelper_AsyncAddFavoriteGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002350")]
	[Address(RVA = "0x3937E0", Offset = "0x391FE0", Length = "0xB5")]
	public static extern int IRailGameServerHelper_AsyncRemoveFavoriteGameServer__SWIG_0(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3938A0", Offset = "0x3920A0", Length = "0x87")]
	[Token(Token = "0x6002351")]
	public static extern int IRailGameServerHelper_AsyncRemoveFavoriteGameServer__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002352")]
	[Address(RVA = "0x3EA230", Offset = "0x3E8A30", Length = "0x78")]
	public static extern void delete_IRailGameServerHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x394240", Offset = "0x392A40", Length = "0x78")]
	[Token(Token = "0x6002353")]
	public static extern IntPtr IRailGameServer_GetGameServerRailID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002354")]
	[Address(RVA = "0x3941B0", Offset = "0x3929B0", Length = "0x87")]
	public static extern int IRailGameServer_GetGameServerName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x394120", Offset = "0x392920", Length = "0x87")]
	[Token(Token = "0x6002355")]
	public static extern int IRailGameServer_GetGameServerFullName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x394740", Offset = "0x392F40", Length = "0x78")]
	[Token(Token = "0x6002356")]
	public static extern IntPtr IRailGameServer_GetOwnerRailID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002357")]
	[Address(RVA = "0x394F30", Offset = "0x393730", Length = "0xA9")]
	public static extern bool IRailGameServer_SetHost(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3943E0", Offset = "0x392BE0", Length = "0x8C")]
	[Token(Token = "0x6002358")]
	public static extern bool IRailGameServer_GetHost(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395070", Offset = "0x393870", Length = "0xA9")]
	[Token(Token = "0x6002359")]
	public static extern bool IRailGameServer_SetMapName(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3944F0", Offset = "0x392CF0", Length = "0x8C")]
	[Token(Token = "0x600235A")]
	public static extern bool IRailGameServer_GetMapName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395310", Offset = "0x393B10", Length = "0x8B")]
	[Token(Token = "0x600235B")]
	public static extern bool IRailGameServer_SetPasswordProtect(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3947C0", Offset = "0x392FC0", Length = "0x7D")]
	[Token(Token = "0x600235C")]
	public static extern bool IRailGameServer_GetPasswordProtect(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600235D")]
	[Address(RVA = "0x395120", Offset = "0x393920", Length = "0x8A")]
	public static extern bool IRailGameServer_SetMaxPlayers(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x600235E")]
	[Address(RVA = "0x394580", Offset = "0x392D80", Length = "0x78")]
	public static extern uint IRailGameServer_GetMaxPlayers(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x394C90", Offset = "0x393490", Length = "0x8A")]
	[Token(Token = "0x600235F")]
	public static extern bool IRailGameServer_SetBotPlayers(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002360")]
	[Address(RVA = "0x393F00", Offset = "0x392700", Length = "0x78")]
	public static extern uint IRailGameServer_GetBotPlayers(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002361")]
	[Address(RVA = "0x394D20", Offset = "0x393520", Length = "0xA9")]
	public static extern bool IRailGameServer_SetGameServerDescription(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002362")]
	[Address(RVA = "0x394090", Offset = "0x392890", Length = "0x8C")]
	public static extern bool IRailGameServer_GetGameServerDescription(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002363")]
	[Address(RVA = "0x394DD0", Offset = "0x3935D0", Length = "0xA9")]
	public static extern bool IRailGameServer_SetGameServerTags(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002364")]
	[Address(RVA = "0x3942C0", Offset = "0x392AC0", Length = "0x8C")]
	public static extern bool IRailGameServer_GetGameServerTags(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002365")]
	[Address(RVA = "0x395280", Offset = "0x393A80", Length = "0x8C")]
	public static extern bool IRailGameServer_SetMods(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002366")]
	[Address(RVA = "0x3946B0", Offset = "0x392EB0", Length = "0x8C")]
	public static extern bool IRailGameServer_GetMods(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395450", Offset = "0x393C50", Length = "0xA9")]
	[Token(Token = "0x6002367")]
	public static extern bool IRailGameServer_SetSpectatorHost(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002368")]
	[Address(RVA = "0x3948D0", Offset = "0x3930D0", Length = "0x8C")]
	public static extern bool IRailGameServer_GetSpectatorHost(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002369")]
	[Address(RVA = "0x394E80", Offset = "0x393680", Length = "0xA9")]
	public static extern bool IRailGameServer_SetGameServerVersion(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600236A")]
	[Address(RVA = "0x394350", Offset = "0x392B50", Length = "0x8C")]
	public static extern bool IRailGameServer_GetGameServerVersion(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600236B")]
	[Address(RVA = "0x394FE0", Offset = "0x3937E0", Length = "0x8B")]
	public static extern bool IRailGameServer_SetIsFriendOnly(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x600236C")]
	[Address(RVA = "0x394470", Offset = "0x392C70", Length = "0x7D")]
	public static extern bool IRailGameServer_GetIsFriendOnly(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x393D70", Offset = "0x392570", Length = "0x7D")]
	[Token(Token = "0x600236D")]
	public static extern bool IRailGameServer_ClearAllMetadata(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600236E")]
	[Address(RVA = "0x394600", Offset = "0x392E00", Length = "0xAC")]
	public static extern int IRailGameServer_GetMetadata(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x600236F")]
	[Address(RVA = "0x3951B0", Offset = "0x3939B0", Length = "0xC8")]
	public static extern int IRailGameServer_SetMetadata(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x393BE0", Offset = "0x3923E0", Length = "0xB5")]
	[Token(Token = "0x6002370")]
	public static extern int IRailGameServer_AsyncSetMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x393B20", Offset = "0x392320", Length = "0xB5")]
	[Token(Token = "0x6002371")]
	public static extern int IRailGameServer_AsyncGetMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002372")]
	[Address(RVA = "0x393A70", Offset = "0x392270", Length = "0xA6")]
	public static extern int IRailGameServer_AsyncGetAllMetadata(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3939C0", Offset = "0x3921C0", Length = "0xA6")]
	[Token(Token = "0x6002373")]
	public static extern int IRailGameServer_AsyncAcquireGameServerSessionTicket(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x393CA0", Offset = "0x3924A0", Length = "0xC6")]
	[Token(Token = "0x6002374")]
	public static extern int IRailGameServer_AsyncStartSessionWithPlayer(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x395500", Offset = "0x393D00", Length = "0x87")]
	[Token(Token = "0x6002375")]
	public static extern void IRailGameServer_TerminateSessionOfPlayer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002376")]
	[Address(RVA = "0x393930", Offset = "0x392130", Length = "0x87")]
	public static extern void IRailGameServer_AbandonGameServerSessionTicket(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002377")]
	[Address(RVA = "0x394AF0", Offset = "0x3932F0", Length = "0x87")]
	public static extern int IRailGameServer_ReportPlayerJoinGameServer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002378")]
	[Address(RVA = "0x394B80", Offset = "0x393380", Length = "0x87")]
	public static extern int IRailGameServer_ReportPlayerQuitGameServer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002379")]
	[Address(RVA = "0x395610", Offset = "0x393E10", Length = "0x87")]
	public static extern int IRailGameServer_UpdateGameServerPlayerList(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x393F80", Offset = "0x392780", Length = "0x78")]
	[Token(Token = "0x600237A")]
	public static extern uint IRailGameServer_GetCurrentPlayers(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600237B")]
	[Address(RVA = "0x394A70", Offset = "0x393270", Length = "0x78")]
	public static extern void IRailGameServer_RemoveAllPlayers(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600237C")]
	[Address(RVA = "0x3949F0", Offset = "0x3931F0", Length = "0x78")]
	public static extern int IRailGameServer_RegisterToGameServerList(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600237D")]
	[Address(RVA = "0x395590", Offset = "0x393D90", Length = "0x78")]
	public static extern int IRailGameServer_UnregisterFromGameServerList(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x393DF0", Offset = "0x3925F0", Length = "0x78")]
	[Token(Token = "0x600237E")]
	public static extern int IRailGameServer_CloseGameServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x394000", Offset = "0x392800", Length = "0x87")]
	[Token(Token = "0x600237F")]
	public static extern int IRailGameServer_GetFriendsInGameServer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002380")]
	[Address(RVA = "0x394960", Offset = "0x393160", Length = "0x8C")]
	public static extern bool IRailGameServer_IsUserInGameServer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002381")]
	[Address(RVA = "0x3953A0", Offset = "0x393BA0", Length = "0xA9")]
	public static extern bool IRailGameServer_SetServerInfo(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002382")]
	[Address(RVA = "0x394840", Offset = "0x393040", Length = "0x8C")]
	public static extern bool IRailGameServer_GetServerInfo(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002383")]
	[Address(RVA = "0x393E70", Offset = "0x392670", Length = "0x86")]
	public static extern int IRailGameServer_EnableTeamVoice(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002384")]
	[Address(RVA = "0x3EA2B0", Offset = "0x3E8AB0", Length = "0x78")]
	public static extern void delete_IRailGameServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x397980", Offset = "0x396180", Length = "0xA6")]
	[Token(Token = "0x6002385")]
	public static extern int IRailInGameCoin_AsyncRequestCoinInfo(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002386")]
	[Address(RVA = "0x3978C0", Offset = "0x3960C0", Length = "0xB5")]
	public static extern int IRailInGameCoin_AsyncPurchaseCoins(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002387")]
	[Address(RVA = "0x3EA7B0", Offset = "0x3E8FB0", Length = "0x78")]
	public static extern void delete_IRailInGameCoin(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002388")]
	[Address(RVA = "0x397D30", Offset = "0x396530", Length = "0xA6")]
	public static extern int IRailInGamePurchase_AsyncRequestAllPurchasableProducts(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x397C80", Offset = "0x396480", Length = "0xA6")]
	[Token(Token = "0x6002389")]
	public static extern int IRailInGamePurchase_AsyncRequestAllProducts(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600238A")]
	[Address(RVA = "0x397DE0", Offset = "0x3965E0", Length = "0x91")]
	public static extern int IRailInGamePurchase_GetProductInfo(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x397BC0", Offset = "0x3963C0", Length = "0xB5")]
	[Token(Token = "0x600238B")]
	public static extern int IRailInGamePurchase_AsyncPurchaseProducts(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x397A30", Offset = "0x396230", Length = "0xC8")]
	[Token(Token = "0x600238C")]
	public static extern int IRailInGamePurchase_AsyncFinishOrder(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x397B00", Offset = "0x396300", Length = "0xB5")]
	[Token(Token = "0x600238D")]
	public static extern int IRailInGamePurchase_AsyncPurchaseProductsToAssets(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600238E")]
	[Address(RVA = "0x3EA830", Offset = "0x3E9030", Length = "0x78")]
	public static extern void delete_IRailInGamePurchase(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600238F")]
	[Address(RVA = "0x3FDAC0", Offset = "0x3FC2C0", Length = "0x65")]
	public static extern IntPtr new_LeaderboardParameters__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A5E00", Offset = "0x3A4600", Length = "0x9B")]
	[Token(Token = "0x6002390")]
	public static extern void LeaderboardParameters_param_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5D80", Offset = "0x3A4580", Length = "0x78")]
	[Token(Token = "0x6002391")]
	public static extern IntPtr LeaderboardParameters_param_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002392")]
	[Address(RVA = "0x3FDB30", Offset = "0x3FC330", Length = "0x78")]
	public static extern IntPtr new_LeaderboardParameters__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002393")]
	[Address(RVA = "0x3EBA30", Offset = "0x3EA230", Length = "0x78")]
	public static extern void delete_LeaderboardParameters(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002394")]
	[Address(RVA = "0x417140", Offset = "0x415940", Length = "0x65")]
	public static extern IntPtr new_RequestLeaderboardEntryParam__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002395")]
	[Address(RVA = "0x3E0140", Offset = "0x3DE940", Length = "0x85")]
	public static extern void RequestLeaderboardEntryParam_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3E00C0", Offset = "0x3DE8C0", Length = "0x78")]
	[Token(Token = "0x6002396")]
	public static extern int RequestLeaderboardEntryParam_type_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0030", Offset = "0x3DE830", Length = "0x85")]
	[Token(Token = "0x6002397")]
	public static extern void RequestLeaderboardEntryParam_range_start_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002398")]
	[Address(RVA = "0x3DFFB0", Offset = "0x3DE7B0", Length = "0x78")]
	public static extern int RequestLeaderboardEntryParam_range_start_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002399")]
	[Address(RVA = "0x3DFF20", Offset = "0x3DE720", Length = "0x85")]
	public static extern void RequestLeaderboardEntryParam_range_end_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x600239A")]
	[Address(RVA = "0x3DFEA0", Offset = "0x3DE6A0", Length = "0x78")]
	public static extern int RequestLeaderboardEntryParam_range_end_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E0250", Offset = "0x3DEA50", Length = "0x86")]
	[Token(Token = "0x600239B")]
	public static extern void RequestLeaderboardEntryParam_user_coordinate_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x600239C")]
	[Address(RVA = "0x3E01D0", Offset = "0x3DE9D0", Length = "0x7D")]
	public static extern bool RequestLeaderboardEntryParam_user_coordinate_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x4171B0", Offset = "0x4159B0", Length = "0x78")]
	[Token(Token = "0x600239D")]
	public static extern IntPtr new_RequestLeaderboardEntryParam__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600239E")]
	[Address(RVA = "0x3F77B0", Offset = "0x3F5FB0", Length = "0x78")]
	public static extern void delete_RequestLeaderboardEntryParam(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600239F")]
	[Address(RVA = "0x3FD7F0", Offset = "0x3FBFF0", Length = "0x65")]
	public static extern IntPtr new_LeaderboardData__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023A0")]
	[Address(RVA = "0x3A5820", Offset = "0x3A4020", Length = "0x88")]
	public static extern void LeaderboardData_score_set(IntPtr jarg1, double jarg2);

	[PreserveSig]
	[Token(Token = "0x60023A1")]
	[Address(RVA = "0x3A57A0", Offset = "0x3A3FA0", Length = "0x78")]
	public static extern double LeaderboardData_score_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A5710", Offset = "0x3A3F10", Length = "0x85")]
	[Token(Token = "0x60023A2")]
	public static extern void LeaderboardData_rank_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5690", Offset = "0x3A3E90", Length = "0x78")]
	[Token(Token = "0x60023A3")]
	public static extern int LeaderboardData_rank_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023A4")]
	[Address(RVA = "0x3A5930", Offset = "0x3A4130", Length = "0x87")]
	public static extern void LeaderboardData_spacework_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60023A5")]
	[Address(RVA = "0x3A58B0", Offset = "0x3A40B0", Length = "0x78")]
	public static extern IntPtr LeaderboardData_spacework_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A55F0", Offset = "0x3A3DF0", Length = "0x9B")]
	[Token(Token = "0x60023A6")]
	public static extern void LeaderboardData_additional_infomation_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5570", Offset = "0x3A3D70", Length = "0x78")]
	[Token(Token = "0x60023A7")]
	public static extern IntPtr LeaderboardData_additional_infomation_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD860", Offset = "0x3FC060", Length = "0x78")]
	[Token(Token = "0x60023A8")]
	public static extern IntPtr new_LeaderboardData__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB8B0", Offset = "0x3EA0B0", Length = "0x78")]
	[Token(Token = "0x60023A9")]
	public static extern void delete_LeaderboardData(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD9D0", Offset = "0x3FC1D0", Length = "0x65")]
	[Token(Token = "0x60023AA")]
	public static extern IntPtr new_LeaderboardEntry__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A5CF0", Offset = "0x3A44F0", Length = "0x87")]
	[Token(Token = "0x60023AB")]
	public static extern void LeaderboardEntry_player_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5C70", Offset = "0x3A4470", Length = "0x78")]
	[Token(Token = "0x60023AC")]
	public static extern IntPtr LeaderboardEntry_player_id_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A5BE0", Offset = "0x3A43E0", Length = "0x87")]
	[Token(Token = "0x60023AD")]
	public static extern void LeaderboardEntry_data_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60023AE")]
	[Address(RVA = "0x3A5B60", Offset = "0x3A4360", Length = "0x78")]
	public static extern IntPtr LeaderboardEntry_data_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FDA40", Offset = "0x3FC240", Length = "0x78")]
	[Token(Token = "0x60023AF")]
	public static extern IntPtr new_LeaderboardEntry__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB9B0", Offset = "0x3EA1B0", Length = "0x78")]
	[Token(Token = "0x60023B0")]
	public static extern void delete_LeaderboardEntry(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023B1")]
	[Address(RVA = "0x418C00", Offset = "0x417400", Length = "0x65")]
	public static extern IntPtr new_UploadLeaderboardParam__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023B2")]
	[Address(RVA = "0x3E5890", Offset = "0x3E4090", Length = "0x85")]
	public static extern void UploadLeaderboardParam_type_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60023B3")]
	[Address(RVA = "0x3E5810", Offset = "0x3E4010", Length = "0x78")]
	public static extern int UploadLeaderboardParam_type_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023B4")]
	[Address(RVA = "0x3E5780", Offset = "0x3E3F80", Length = "0x87")]
	public static extern void UploadLeaderboardParam_data_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60023B5")]
	[Address(RVA = "0x3E5700", Offset = "0x3E3F00", Length = "0x78")]
	public static extern IntPtr UploadLeaderboardParam_data_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x418C70", Offset = "0x417470", Length = "0x78")]
	[Token(Token = "0x60023B6")]
	public static extern IntPtr new_UploadLeaderboardParam__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3F85B0", Offset = "0x3F6DB0", Length = "0x78")]
	[Token(Token = "0x60023B7")]
	public static extern void delete_UploadLeaderboardParam(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x3EA9B0", Offset = "0x3E91B0", Length = "0x78")]
	public static extern void delete_IRailLeaderboardHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x398440", Offset = "0x396C40", Length = "0xA8")]
	[Token(Token = "0x60023B9")]
	public static extern IntPtr IRailLeaderboardHelper_OpenLeaderboard(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60023BA")]
	[Address(RVA = "0x398340", Offset = "0x396B40", Length = "0xF2")]
	public static extern IntPtr IRailLeaderboardHelper_AsyncCreateLeaderboard(IntPtr jarg1, string jarg2, int jarg3, int jarg4, string jarg5, out RailResult jarg6);

	[PreserveSig]
	[Token(Token = "0x60023BB")]
	[Address(RVA = "0x398830", Offset = "0x397030", Length = "0x78")]
	public static extern IntPtr IRailLeaderboard_GetLeaderboardName(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x3989D0", Offset = "0x3971D0", Length = "0x78")]
	public static extern int IRailLeaderboard_GetTotalEntriesCount(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3985B0", Offset = "0x396DB0", Length = "0xA6")]
	[Token(Token = "0x60023BD")]
	public static extern int IRailLeaderboard_AsyncGetLeaderboard(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3988B0", Offset = "0x3970B0", Length = "0x87")]
	[Token(Token = "0x60023BE")]
	public static extern int IRailLeaderboard_GetLeaderboardParameters(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x398720", Offset = "0x396F20", Length = "0x78")]
	[Token(Token = "0x60023BF")]
	public static extern IntPtr IRailLeaderboard_CreateLeaderboardEntries(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x398660", Offset = "0x396E60", Length = "0xB5")]
	[Token(Token = "0x60023C0")]
	public static extern int IRailLeaderboard_AsyncUploadLeaderboard(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x398940", Offset = "0x397140", Length = "0x87")]
	public static extern int IRailLeaderboard_GetLeaderboardSortType(IntPtr jarg1, out int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3987A0", Offset = "0x396FA0", Length = "0x87")]
	[Token(Token = "0x60023C2")]
	public static extern int IRailLeaderboard_GetLeaderboardDisplayType(IntPtr jarg1, out int jarg2);

	[PreserveSig]
	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x3984F0", Offset = "0x396CF0", Length = "0xB5")]
	public static extern int IRailLeaderboard_AsyncAttachSpaceWork(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x3EAA30", Offset = "0x3E9230", Length = "0x78")]
	public static extern void delete_IRailLeaderboard(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x398240", Offset = "0x396A40", Length = "0x78")]
	[Token(Token = "0x60023C5")]
	public static extern IntPtr IRailLeaderboardEntries_GetRailID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x3981C0", Offset = "0x3969C0", Length = "0x78")]
	public static extern IntPtr IRailLeaderboardEntries_GetLeaderboardName(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x397F50", Offset = "0x396750", Length = "0xC6")]
	public static extern int IRailLeaderboardEntries_AsyncRequestLeaderboardEntries(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x3980A0", Offset = "0x3968A0", Length = "0x78")]
	public static extern IntPtr IRailLeaderboardEntries_GetEntriesParam(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x398020", Offset = "0x396820", Length = "0x78")]
	public static extern int IRailLeaderboardEntries_GetEntriesCount(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x398120", Offset = "0x396920", Length = "0x91")]
	[Token(Token = "0x60023CA")]
	public static extern int IRailLeaderboardEntries_GetLeaderboardEntry(IntPtr jarg1, int jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x3EA930", Offset = "0x3E9130", Length = "0x78")]
	[Token(Token = "0x60023CB")]
	public static extern void delete_IRailLeaderboardEntries(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023CC")]
	[Address(RVA = "0x3FDBB0", Offset = "0x3FC3B0", Length = "0x65")]
	public static extern IntPtr new_LeaderboardReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023CD")]
	[Address(RVA = "0x3A60B0", Offset = "0x3A48B0", Length = "0x9B")]
	public static extern void LeaderboardReceived_leaderboard_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A6030", Offset = "0x3A4830", Length = "0x78")]
	[Token(Token = "0x60023CE")]
	public static extern IntPtr LeaderboardReceived_leaderboard_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023CF")]
	[Address(RVA = "0x3A5FA0", Offset = "0x3A47A0", Length = "0x86")]
	public static extern void LeaderboardReceived_does_exist_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A5F20", Offset = "0x3A4720", Length = "0x7D")]
	[Token(Token = "0x60023D0")]
	public static extern bool LeaderboardReceived_does_exist_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023D1")]
	[Address(RVA = "0x3FDC20", Offset = "0x3FC420", Length = "0x78")]
	public static extern IntPtr new_LeaderboardReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EBAB0", Offset = "0x3EA2B0", Length = "0x78")]
	[Token(Token = "0x60023D2")]
	public static extern void delete_LeaderboardReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023D3")]
	[Address(RVA = "0x3FD700", Offset = "0x3FBF00", Length = "0x65")]
	public static extern IntPtr new_LeaderboardCreated__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023D4")]
	[Address(RVA = "0x3A54D0", Offset = "0x3A3CD0", Length = "0x9B")]
	public static extern void LeaderboardCreated_leaderboard_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60023D5")]
	[Address(RVA = "0x3A5450", Offset = "0x3A3C50", Length = "0x78")]
	public static extern IntPtr LeaderboardCreated_leaderboard_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD770", Offset = "0x3FBF70", Length = "0x78")]
	[Token(Token = "0x60023D6")]
	public static extern IntPtr new_LeaderboardCreated__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB830", Offset = "0x3EA030", Length = "0x78")]
	[Token(Token = "0x60023D7")]
	public static extern void delete_LeaderboardCreated(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD8E0", Offset = "0x3FC0E0", Length = "0x65")]
	[Token(Token = "0x60023D8")]
	public static extern IntPtr new_LeaderboardEntryReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023D9")]
	[Address(RVA = "0x3A5AC0", Offset = "0x3A42C0", Length = "0x9B")]
	public static extern void LeaderboardEntryReceived_leaderboard_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60023DA")]
	[Address(RVA = "0x3A5A40", Offset = "0x3A4240", Length = "0x78")]
	public static extern IntPtr LeaderboardEntryReceived_leaderboard_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD950", Offset = "0x3FC150", Length = "0x78")]
	[Token(Token = "0x60023DB")]
	public static extern IntPtr new_LeaderboardEntryReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB930", Offset = "0x3EA130", Length = "0x78")]
	[Token(Token = "0x60023DC")]
	public static extern void delete_LeaderboardEntryReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023DD")]
	[Address(RVA = "0x3FDCA0", Offset = "0x3FC4A0", Length = "0x65")]
	public static extern IntPtr new_LeaderboardUploaded__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x60023DE")]
	[Address(RVA = "0x3A6360", Offset = "0x3A4B60", Length = "0x9B")]
	public static extern void LeaderboardUploaded_leaderboard_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60023DF")]
	[Address(RVA = "0x3A62E0", Offset = "0x3A4AE0", Length = "0x78")]
	public static extern IntPtr LeaderboardUploaded_leaderboard_name_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A66A0", Offset = "0x3A4EA0", Length = "0x88")]
	[Token(Token = "0x60023E0")]
	public static extern void LeaderboardUploaded_score_set(IntPtr jarg1, double jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A6620", Offset = "0x3A4E20", Length = "0x78")]
	[Token(Token = "0x60023E1")]
	public static extern double LeaderboardUploaded_score_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x3A6250", Offset = "0x3A4A50", Length = "0x86")]
	public static extern void LeaderboardUploaded_better_score_set(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A61D0", Offset = "0x3A49D0", Length = "0x7D")]
	[Token(Token = "0x60023E3")]
	public static extern bool LeaderboardUploaded_better_score_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A6480", Offset = "0x3A4C80", Length = "0x85")]
	[Token(Token = "0x60023E4")]
	public static extern void LeaderboardUploaded_new_rank_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x3A6400", Offset = "0x3A4C00", Length = "0x78")]
	public static extern int LeaderboardUploaded_new_rank_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x3A6590", Offset = "0x3A4D90", Length = "0x85")]
	public static extern void LeaderboardUploaded_old_rank_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x3A6510", Offset = "0x3A4D10", Length = "0x78")]
	public static extern int LeaderboardUploaded_old_rank_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FDD10", Offset = "0x3FC510", Length = "0x78")]
	[Token(Token = "0x60023E8")]
	public static extern IntPtr new_LeaderboardUploaded__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x3EBB30", Offset = "0x3EA330", Length = "0x78")]
	public static extern void delete_LeaderboardUploaded(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD610", Offset = "0x3FBE10", Length = "0x65")]
	[Token(Token = "0x60023EA")]
	public static extern IntPtr new_LeaderboardAttachSpaceWork__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A5220", Offset = "0x3A3A20", Length = "0x9B")]
	[Token(Token = "0x60023EB")]
	public static extern void LeaderboardAttachSpaceWork_leaderboard_name_set(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A51A0", Offset = "0x3A39A0", Length = "0x78")]
	[Token(Token = "0x60023EC")]
	public static extern IntPtr LeaderboardAttachSpaceWork_leaderboard_name_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x3A5340", Offset = "0x3A3B40", Length = "0x87")]
	public static extern void LeaderboardAttachSpaceWork_spacework_id_set(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x3A52C0", Offset = "0x3A3AC0", Length = "0x78")]
	public static extern IntPtr LeaderboardAttachSpaceWork_spacework_id_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023EF")]
	[Address(RVA = "0x3FD680", Offset = "0x3FBE80", Length = "0x78")]
	public static extern IntPtr new_LeaderboardAttachSpaceWork__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023F0")]
	[Address(RVA = "0x3EB7B0", Offset = "0x3E9FB0", Length = "0x78")]
	public static extern void delete_LeaderboardAttachSpaceWork(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x398B70", Offset = "0x397370", Length = "0x93")]
	public static extern int IRailNetwork_AcceptSessionRequest(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60023F2")]
	[Address(RVA = "0x3993A0", Offset = "0x397BA0", Length = "0xC9")]
	public static extern int IRailNetwork_SendData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5, uint jarg6);

	[PreserveSig]
	[Address(RVA = "0x399470", Offset = "0x397C70", Length = "0xBE")]
	[Token(Token = "0x60023F3")]
	public static extern int IRailNetwork_SendData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x60023F4")]
	[Address(RVA = "0x399610", Offset = "0x397E10", Length = "0xC9")]
	public static extern int IRailNetwork_SendReliableData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5, uint jarg6);

	[PreserveSig]
	[Address(RVA = "0x3996E0", Offset = "0x397EE0", Length = "0xBE")]
	[Token(Token = "0x60023F5")]
	public static extern int IRailNetwork_SendReliableData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x398E80", Offset = "0x397680", Length = "0xA7")]
	public static extern bool IRailNetwork_IsDataReady__SWIG_0(IntPtr jarg1, IntPtr jarg2, out uint jarg3, out uint jarg4);

	[PreserveSig]
	[Address(RVA = "0x398F30", Offset = "0x397730", Length = "0x98")]
	[Token(Token = "0x60023F7")]
	public static extern bool IRailNetwork_IsDataReady__SWIG_1(IntPtr jarg1, IntPtr jarg2, out uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x398FD0", Offset = "0x3977D0", Length = "0xC9")]
	public static extern int IRailNetwork_ReadData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5, uint jarg6);

	[PreserveSig]
	[Address(RVA = "0x3990A0", Offset = "0x3978A0", Length = "0xBE")]
	[Token(Token = "0x60023F9")]
	public static extern int IRailNetwork_ReadData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5);

	[PreserveSig]
	[Address(RVA = "0x398C10", Offset = "0x397410", Length = "0x93")]
	[Token(Token = "0x60023FA")]
	public static extern int IRailNetwork_BlockMessageType(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3997A0", Offset = "0x397FA0", Length = "0x93")]
	[Token(Token = "0x60023FB")]
	public static extern int IRailNetwork_UnblockMessageType(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x398CB0", Offset = "0x3974B0", Length = "0x93")]
	[Token(Token = "0x60023FC")]
	public static extern int IRailNetwork_CloseSession(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x3992F0", Offset = "0x397AF0", Length = "0xAC")]
	[Token(Token = "0x60023FD")]
	public static extern int IRailNetwork_ResolveHostname(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x398DE0", Offset = "0x3975E0", Length = "0x93")]
	[Token(Token = "0x60023FE")]
	public static extern int IRailNetwork_GetSessionState(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x398D50", Offset = "0x397550", Length = "0x86")]
	[Token(Token = "0x60023FF")]
	public static extern int IRailNetwork_ForbidSessionRelay(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x399530", Offset = "0x397D30", Length = "0xD5")]
	[Token(Token = "0x6002400")]
	public static extern int IRailNetwork_SendRawData(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5, bool jarg6, uint jarg7);

	[PreserveSig]
	[Address(RVA = "0x398AD0", Offset = "0x3972D0", Length = "0x93")]
	[Token(Token = "0x6002401")]
	public static extern int IRailNetwork_AcceptRawSessionRequest(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002402")]
	[Address(RVA = "0x399160", Offset = "0x397960", Length = "0xC9")]
	public static extern int IRailNetwork_ReadRawData__SWIG_0(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5, uint jarg6);

	[PreserveSig]
	[Address(RVA = "0x399230", Offset = "0x397A30", Length = "0xBE")]
	[Token(Token = "0x6002403")]
	public static extern int IRailNetwork_ReadRawData__SWIG_1(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, [In][Out] byte[] jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6002404")]
	[Address(RVA = "0x3EAAB0", Offset = "0x3E92B0", Length = "0x78")]
	public static extern void delete_IRailNetwork(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002405")]
	[Address(RVA = "0x39A7F0", Offset = "0x398FF0", Length = "0x7D")]
	public static extern bool IRailPlayer_AlreadyLoggedIn(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002406")]
	[Address(RVA = "0x39AF40", Offset = "0x399740", Length = "0x78")]
	public static extern IntPtr IRailPlayer_GetRailID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002407")]
	[Address(RVA = "0x39ADA0", Offset = "0x3995A0", Length = "0x87")]
	public static extern int IRailPlayer_GetPlayerDataPath(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39A870", Offset = "0x399070", Length = "0xA6")]
	[Token(Token = "0x6002408")]
	public static extern int IRailPlayer_AsyncAcquireSessionTicket(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002409")]
	[Address(RVA = "0x39ACD0", Offset = "0x3994D0", Length = "0xC6")]
	public static extern int IRailPlayer_AsyncStartSessionWithPlayer(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x39B0C0", Offset = "0x3998C0", Length = "0x87")]
	[Token(Token = "0x600240A")]
	public static extern void IRailPlayer_TerminateSessionOfPlayer(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600240B")]
	[Address(RVA = "0x39A760", Offset = "0x398F60", Length = "0x87")]
	public static extern void IRailPlayer_AbandonSessionTicket(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600240C")]
	[Address(RVA = "0x39AE30", Offset = "0x399630", Length = "0x87")]
	public static extern int IRailPlayer_GetPlayerName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600240D")]
	[Address(RVA = "0x39AEC0", Offset = "0x3996C0", Length = "0x78")]
	public static extern int IRailPlayer_GetPlayerOwnershipType(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600240E")]
	[Address(RVA = "0x39AAB0", Offset = "0x3992B0", Length = "0xA6")]
	public static extern int IRailPlayer_AsyncGetGamePurchaseKey(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600240F")]
	[Address(RVA = "0x39B040", Offset = "0x399840", Length = "0x7D")]
	public static extern bool IRailPlayer_IsGameRevenueLimited(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002410")]
	[Address(RVA = "0x39AFC0", Offset = "0x3997C0", Length = "0x78")]
	public static extern float IRailPlayer_GetRateOfGameRevenue(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002411")]
	[Address(RVA = "0x39AC20", Offset = "0x399420", Length = "0xA6")]
	public static extern int IRailPlayer_AsyncQueryPlayerBannedStatus(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002412")]
	[Address(RVA = "0x39A920", Offset = "0x399120", Length = "0xB5")]
	public static extern int IRailPlayer_AsyncGetAuthenticateURL(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39AB60", Offset = "0x399360", Length = "0xB5")]
	[Token(Token = "0x6002413")]
	public static extern int IRailPlayer_AsyncGetPlayerMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39A9E0", Offset = "0x3991E0", Length = "0xC8")]
	[Token(Token = "0x6002414")]
	public static extern int IRailPlayer_AsyncGetEncryptedGameTicket(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3EAC30", Offset = "0x3E9430", Length = "0x78")]
	[Token(Token = "0x6002415")]
	public static extern void delete_IRailPlayer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39B560", Offset = "0x399D60", Length = "0xBD")]
	[Token(Token = "0x6002416")]
	public static extern IntPtr IRailRoomHelper_CreateRoom(IntPtr jarg1, IntPtr jarg2, string jarg3, out RailResult jarg4);

	[PreserveSig]
	[Token(Token = "0x6002417")]
	[Address(RVA = "0x39B150", Offset = "0x399950", Length = "0xDB")]
	public static extern IntPtr IRailRoomHelper_AsyncCreateRoom(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002418")]
	[Address(RVA = "0x39B620", Offset = "0x399E20", Length = "0x93")]
	public static extern IntPtr IRailRoomHelper_OpenRoom(IntPtr jarg1, ulong jarg2, out RailResult jarg3);

	[PreserveSig]
	[Token(Token = "0x6002419")]
	[Address(RVA = "0x39B4A0", Offset = "0x399CA0", Length = "0xB7")]
	public static extern IntPtr IRailRoomHelper_AsyncOpenRoom(IntPtr jarg1, ulong jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600241A")]
	[Address(RVA = "0x39B310", Offset = "0x399B10", Length = "0xDB")]
	public static extern int IRailRoomHelper_AsyncGetRoomList(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6);

	[PreserveSig]
	[Token(Token = "0x600241B")]
	[Address(RVA = "0x39B230", Offset = "0x399A30", Length = "0xDB")]
	public static extern int IRailRoomHelper_AsyncGetRoomListByTags(IntPtr jarg1, uint jarg2, uint jarg3, IntPtr jarg4, IntPtr jarg5, string jarg6);

	[PreserveSig]
	[Address(RVA = "0x39B3F0", Offset = "0x399BF0", Length = "0xA6")]
	[Token(Token = "0x600241C")]
	public static extern int IRailRoomHelper_AsyncGetUserRoomList(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600241D")]
	[Address(RVA = "0x3EACB0", Offset = "0x3E94B0", Length = "0x78")]
	public static extern void delete_IRailRoomHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39BB20", Offset = "0x39A320", Length = "0xC8")]
	[Token(Token = "0x600241E")]
	public static extern int IRailRoom_AsyncJoinRoom(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39C5A0", Offset = "0x39ADA0", Length = "0x78")]
	[Token(Token = "0x600241F")]
	public static extern ulong IRailRoom_GetRoomID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002420")]
	[Address(RVA = "0x39C620", Offset = "0x39AE20", Length = "0x87")]
	public static extern int IRailRoom_GetRoomName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39C520", Offset = "0x39AD20", Length = "0x78")]
	[Token(Token = "0x6002421")]
	public static extern IntPtr IRailRoom_GetOwnerID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002422")]
	[Address(RVA = "0x39C730", Offset = "0x39AF30", Length = "0x7D")]
	public static extern bool IRailRoom_HasPassword(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002423")]
	[Address(RVA = "0x39C6B0", Offset = "0x39AEB0", Length = "0x78")]
	public static extern int IRailRoom_GetRoomType(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39C4A0", Offset = "0x39ACA0", Length = "0x78")]
	[Token(Token = "0x6002424")]
	public static extern uint IRailRoom_GetMembers(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39C370", Offset = "0x39AB70", Length = "0x85")]
	[Token(Token = "0x6002425")]
	public static extern IntPtr IRailRoom_GetMemberByIndex(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002426")]
	[Address(RVA = "0x39C400", Offset = "0x39AC00", Length = "0x91")]
	public static extern int IRailRoom_GetMemberNameByIndex(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002427")]
	[Address(RVA = "0x39C2F0", Offset = "0x39AAF0", Length = "0x78")]
	public static extern uint IRailRoom_GetMaxMembers(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39C8C0", Offset = "0x39B0C0", Length = "0x78")]
	[Token(Token = "0x6002428")]
	public static extern void IRailRoom_Leave(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39BD80", Offset = "0x39A580", Length = "0xB5")]
	[Token(Token = "0x6002429")]
	public static extern int IRailRoom_AsyncSetNewRoomOwner(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39B900", Offset = "0x39A100", Length = "0xA6")]
	[Token(Token = "0x600242A")]
	public static extern int IRailRoom_AsyncGetRoomMembers(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39B780", Offset = "0x399F80", Length = "0xA6")]
	[Token(Token = "0x600242B")]
	public static extern int IRailRoom_AsyncGetAllRoomData(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39BBF0", Offset = "0x39A3F0", Length = "0xB5")]
	[Token(Token = "0x600242C")]
	public static extern int IRailRoom_AsyncKickOffMember(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600242D")]
	[Address(RVA = "0x39BFC0", Offset = "0x39A7C0", Length = "0xC8")]
	public static extern int IRailRoom_AsyncSetRoomTag(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600242E")]
	[Address(RVA = "0x39BA70", Offset = "0x39A270", Length = "0xA6")]
	public static extern int IRailRoom_AsyncGetRoomTag(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39BF00", Offset = "0x39A700", Length = "0xB5")]
	[Token(Token = "0x600242F")]
	public static extern int IRailRoom_AsyncSetRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39B9B0", Offset = "0x39A1B0", Length = "0xB5")]
	[Token(Token = "0x6002430")]
	public static extern int IRailRoom_AsyncGetRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002431")]
	[Address(RVA = "0x39B6C0", Offset = "0x399EC0", Length = "0xB5")]
	public static extern int IRailRoom_AsyncClearRoomMetadata(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39BCB0", Offset = "0x39A4B0", Length = "0xC6")]
	[Token(Token = "0x6002432")]
	public static extern int IRailRoom_AsyncSetMemberMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x39B830", Offset = "0x39A030", Length = "0xC6")]
	[Token(Token = "0x6002433")]
	public static extern int IRailRoom_AsyncGetMemberMetadata(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x39C9C0", Offset = "0x39B1C0", Length = "0xBE")]
	[Token(Token = "0x6002434")]
	public static extern int IRailRoom_SendDataToMember__SWIG_0(IntPtr jarg1, IntPtr jarg2, [In][Out] byte[] jarg3, uint jarg4, uint jarg5);

	[PreserveSig]
	[Address(RVA = "0x39CA80", Offset = "0x39B280", Length = "0xB3")]
	[Token(Token = "0x6002435")]
	public static extern int IRailRoom_SendDataToMember__SWIG_1(IntPtr jarg1, IntPtr jarg2, [In][Out] byte[] jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x6002436")]
	[Address(RVA = "0x39CB40", Offset = "0x39B340", Length = "0x87")]
	public static extern int IRailRoom_SetGameServerID(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002437")]
	[Address(RVA = "0x39C270", Offset = "0x39AA70", Length = "0x78")]
	public static extern IntPtr IRailRoom_GetGameServerID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39CBD0", Offset = "0x39B3D0", Length = "0x86")]
	[Token(Token = "0x6002438")]
	public static extern int IRailRoom_SetRoomJoinable(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x6002439")]
	[Address(RVA = "0x39C7B0", Offset = "0x39AFB0", Length = "0x7D")]
	public static extern bool IRailRoom_IsRoomJoinable(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39C1E0", Offset = "0x39A9E0", Length = "0x87")]
	[Token(Token = "0x600243A")]
	public static extern int IRailRoom_GetFriendsInRoom(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600243B")]
	[Address(RVA = "0x39C830", Offset = "0x39B030", Length = "0x8C")]
	public static extern bool IRailRoom_IsUserInRoom(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600243C")]
	[Address(RVA = "0x39C150", Offset = "0x39A950", Length = "0x86")]
	public static extern int IRailRoom_EnableTeamVoice(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x39C090", Offset = "0x39A890", Length = "0xB3")]
	[Token(Token = "0x600243D")]
	public static extern int IRailRoom_AsyncSetRoomType(IntPtr jarg1, int jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39BE40", Offset = "0x39A640", Length = "0xB3")]
	[Token(Token = "0x600243E")]
	public static extern int IRailRoom_AsyncSetRoomMaxMember(IntPtr jarg1, uint jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3EAD30", Offset = "0x3E9530", Length = "0x78")]
	[Token(Token = "0x600243F")]
	public static extern void delete_IRailRoom(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39CDD0", Offset = "0x39B5D0", Length = "0xBE")]
	[Token(Token = "0x6002440")]
	public static extern IntPtr IRailScreenshotHelper_CreateScreenshotWithRawData(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, uint jarg4, uint jarg5);

	[PreserveSig]
	[Token(Token = "0x6002441")]
	[Address(RVA = "0x39CD00", Offset = "0x39B500", Length = "0xCA")]
	public static extern IntPtr IRailScreenshotHelper_CreateScreenshotWithLocalImage(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002442")]
	[Address(RVA = "0x39CC60", Offset = "0x39B460", Length = "0x9B")]
	public static extern void IRailScreenshotHelper_AsyncTakeScreenshot(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39CE90", Offset = "0x39B690", Length = "0x86")]
	[Token(Token = "0x6002443")]
	public static extern void IRailScreenshotHelper_HookScreenshotHotKey(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x39CF20", Offset = "0x39B720", Length = "0x7D")]
	[Token(Token = "0x6002444")]
	public static extern bool IRailScreenshotHelper_IsScreenshotHotKeyHooked(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002445")]
	[Address(RVA = "0x3EADB0", Offset = "0x3E95B0", Length = "0x78")]
	public static extern void delete_IRailScreenshotHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002446")]
	[Address(RVA = "0x39D180", Offset = "0x39B980", Length = "0xA9")]
	public static extern bool IRailScreenshot_SetLocation(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002447")]
	[Address(RVA = "0x39D230", Offset = "0x39BA30", Length = "0x8C")]
	public static extern bool IRailScreenshot_SetUsers(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002448")]
	[Address(RVA = "0x39CFA0", Offset = "0x39B7A0", Length = "0x8C")]
	public static extern bool IRailScreenshot_AssociatePublishedFiles(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002449")]
	[Address(RVA = "0x39D030", Offset = "0x39B830", Length = "0xC8")]
	public static extern int IRailScreenshot_AsyncPublishScreenshot(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3EAE30", Offset = "0x3E9630", Length = "0x78")]
	[Token(Token = "0x600244A")]
	public static extern void delete_IRailScreenshot(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39F4D0", Offset = "0x39DCD0", Length = "0x87")]
	[Token(Token = "0x600244B")]
	public static extern IntPtr IRailStatisticHelper_CreatePlayerStats(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600244C")]
	[Address(RVA = "0x39F560", Offset = "0x39DD60", Length = "0x78")]
	public static extern IntPtr IRailStatisticHelper_GetGlobalStats(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39F420", Offset = "0x39DC20", Length = "0xA6")]
	[Token(Token = "0x600244D")]
	public static extern int IRailStatisticHelper_AsyncGetNumberOfPlayer(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EAFB0", Offset = "0x3E97B0", Length = "0x78")]
	[Token(Token = "0x600244E")]
	public static extern void delete_IRailStatisticHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39A250", Offset = "0x398A50", Length = "0x78")]
	[Token(Token = "0x600244F")]
	public static extern IntPtr IRailPlayerStats_GetRailID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39A0F0", Offset = "0x3988F0", Length = "0xA6")]
	[Token(Token = "0x6002450")]
	public static extern int IRailPlayerStats_AsyncRequestStats(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002451")]
	[Address(RVA = "0x39A2D0", Offset = "0x398AD0", Length = "0xAC")]
	public static extern int IRailPlayerStats_GetStatValue__SWIG_0(IntPtr jarg1, string jarg2, out int jarg3);

	[PreserveSig]
	[Address(RVA = "0x39A380", Offset = "0x398B80", Length = "0xAC")]
	[Token(Token = "0x6002452")]
	public static extern int IRailPlayerStats_GetStatValue__SWIG_1(IntPtr jarg1, string jarg2, out double jarg3);

	[PreserveSig]
	[Address(RVA = "0x39A530", Offset = "0x398D30", Length = "0xAC")]
	[Token(Token = "0x6002453")]
	public static extern int IRailPlayerStats_SetStatValue__SWIG_0(IntPtr jarg1, string jarg2, int jarg3);

	[PreserveSig]
	[Address(RVA = "0x39A5E0", Offset = "0x398DE0", Length = "0xB6")]
	[Token(Token = "0x6002454")]
	public static extern int IRailPlayerStats_SetStatValue__SWIG_1(IntPtr jarg1, string jarg2, double jarg3);

	[PreserveSig]
	[Token(Token = "0x6002455")]
	[Address(RVA = "0x39A6A0", Offset = "0x398EA0", Length = "0xB6")]
	public static extern int IRailPlayerStats_UpdateAverageStatValue(IntPtr jarg1, string jarg2, double jarg3);

	[PreserveSig]
	[Token(Token = "0x6002456")]
	[Address(RVA = "0x39A1A0", Offset = "0x3989A0", Length = "0xA6")]
	public static extern int IRailPlayerStats_AsyncStoreStats(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39A430", Offset = "0x398C30", Length = "0x78")]
	[Token(Token = "0x6002457")]
	public static extern int IRailPlayerStats_ResetAllStats(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EABB0", Offset = "0x3E93B0", Length = "0x78")]
	[Token(Token = "0x6002458")]
	public static extern void delete_IRailPlayerStats(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3963E0", Offset = "0x394BE0", Length = "0xA6")]
	[Token(Token = "0x6002459")]
	public static extern int IRailGlobalStats_AsyncRequestGlobalStats(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x396770", Offset = "0x394F70", Length = "0xAC")]
	[Token(Token = "0x600245A")]
	public static extern int IRailGlobalStats_GetGlobalStatValue__SWIG_0(IntPtr jarg1, string jarg2, out long jarg3);

	[PreserveSig]
	[Address(RVA = "0x396820", Offset = "0x395020", Length = "0xAC")]
	[Token(Token = "0x600245B")]
	public static extern int IRailGlobalStats_GetGlobalStatValue__SWIG_1(IntPtr jarg1, string jarg2, out double jarg3);

	[PreserveSig]
	[Token(Token = "0x600245C")]
	[Address(RVA = "0x396490", Offset = "0x394C90", Length = "0x13B")]
	public static extern int IRailGlobalStats_GetGlobalStatValueHistory__SWIG_0(IntPtr jarg1, string jarg2, [Out] long[] jarg3, uint jarg4, out int jarg5);

	[PreserveSig]
	[Token(Token = "0x600245D")]
	[Address(RVA = "0x3965D0", Offset = "0x394DD0", Length = "0x19F")]
	public static extern int IRailGlobalStats_GetGlobalStatValueHistory__SWIG_1(IntPtr jarg1, string jarg2, [Out] double[] jarg3, uint jarg4, out int jarg5);

	[PreserveSig]
	[Token(Token = "0x600245E")]
	[Address(RVA = "0x3EA430", Offset = "0x3E8C30", Length = "0x78")]
	public static extern void delete_IRailGlobalStats(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FEE70", Offset = "0x3FD670", Length = "0x65")]
	[Token(Token = "0x600245F")]
	public static extern IntPtr new_PlayerStatsReceived__SWIG_0();

	[PreserveSig]
	[Token(Token = "0x6002460")]
	[Address(RVA = "0x3FEEE0", Offset = "0x3FD6E0", Length = "0x78")]
	public static extern IntPtr new_PlayerStatsReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002461")]
	[Address(RVA = "0x3EC4B0", Offset = "0x3EACB0", Length = "0x78")]
	public static extern void delete_PlayerStatsReceived(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002462")]
	[Address(RVA = "0x3FEF60", Offset = "0x3FD760", Length = "0x65")]
	public static extern IntPtr new_PlayerStatsStored__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FEFD0", Offset = "0x3FD7D0", Length = "0x78")]
	[Token(Token = "0x6002463")]
	public static extern IntPtr new_PlayerStatsStored__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002464")]
	[Address(RVA = "0x3EC530", Offset = "0x3EAD30", Length = "0x78")]
	public static extern void delete_PlayerStatsStored(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002465")]
	[Address(RVA = "0x3FE8D0", Offset = "0x3FD0D0", Length = "0x65")]
	public static extern IntPtr new_NumberOfPlayerReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3A9000", Offset = "0x3A7800", Length = "0x85")]
	[Token(Token = "0x6002466")]
	public static extern void NumberOfPlayerReceived_online_number_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002467")]
	[Address(RVA = "0x3A8F80", Offset = "0x3A7780", Length = "0x78")]
	public static extern int NumberOfPlayerReceived_online_number_get(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A8EF0", Offset = "0x3A76F0", Length = "0x85")]
	[Token(Token = "0x6002468")]
	public static extern void NumberOfPlayerReceived_offline_number_set(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002469")]
	[Address(RVA = "0x3A8E70", Offset = "0x3A7670", Length = "0x78")]
	public static extern int NumberOfPlayerReceived_offline_number_get(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600246A")]
	[Address(RVA = "0x3FE940", Offset = "0x3FD140", Length = "0x78")]
	public static extern IntPtr new_NumberOfPlayerReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600246B")]
	[Address(RVA = "0x3EC1B0", Offset = "0x3EA9B0", Length = "0x78")]
	public static extern void delete_NumberOfPlayerReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3FD160", Offset = "0x3FB960", Length = "0x65")]
	[Token(Token = "0x600246C")]
	public static extern IntPtr new_GlobalStatsRequestReceived__SWIG_0();

	[PreserveSig]
	[Address(RVA = "0x3FD1D0", Offset = "0x3FB9D0", Length = "0x78")]
	[Token(Token = "0x600246D")]
	public static extern IntPtr new_GlobalStatsRequestReceived__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600246E")]
	[Address(RVA = "0x3E9B30", Offset = "0x3E8330", Length = "0x78")]
	public static extern void delete_GlobalStatsRequestReceived(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB030", Offset = "0x3E9830", Length = "0x78")]
	[Token(Token = "0x600246F")]
	public static extern void delete_IRailStorageHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002470")]
	[Address(RVA = "0x3A0090", Offset = "0x39E890", Length = "0xAE")]
	public static extern IntPtr IRailStorageHelper_OpenFile__SWIG_0(IntPtr jarg1, string jarg2, out RailResult jarg3);

	[PreserveSig]
	[Token(Token = "0x6002471")]
	[Address(RVA = "0x3A0140", Offset = "0x39E940", Length = "0xA8")]
	public static extern IntPtr IRailStorageHelper_OpenFile__SWIG_1(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002472")]
	[Address(RVA = "0x39F9C0", Offset = "0x39E1C0", Length = "0xAE")]
	public static extern IntPtr IRailStorageHelper_CreateFile__SWIG_0(IntPtr jarg1, string jarg2, out RailResult jarg3);

	[PreserveSig]
	[Token(Token = "0x6002473")]
	[Address(RVA = "0x39FA70", Offset = "0x39E270", Length = "0xA8")]
	public static extern IntPtr IRailStorageHelper_CreateFile__SWIG_1(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002474")]
	[Address(RVA = "0x39FEA0", Offset = "0x39E6A0", Length = "0xA9")]
	public static extern bool IRailStorageHelper_IsFileExist(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002475")]
	[Address(RVA = "0x3A0000", Offset = "0x39E800", Length = "0x8C")]
	public static extern bool IRailStorageHelper_ListFiles(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A0360", Offset = "0x39EB60", Length = "0xA6")]
	[Token(Token = "0x6002476")]
	public static extern int IRailStorageHelper_RemoveFile(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002477")]
	[Address(RVA = "0x39FF50", Offset = "0x39E750", Length = "0xA9")]
	public static extern bool IRailStorageHelper_IsFileSyncedToCloud(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39FC40", Offset = "0x39E440", Length = "0xAC")]
	[Token(Token = "0x6002478")]
	public static extern int IRailStorageHelper_GetFileTimestamp(IntPtr jarg1, string jarg2, out ulong jarg3);

	[PreserveSig]
	[Token(Token = "0x6002479")]
	[Address(RVA = "0x39FB20", Offset = "0x39E320", Length = "0x78")]
	public static extern uint IRailStorageHelper_GetFileCount(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600247A")]
	[Address(RVA = "0x39FBA0", Offset = "0x39E3A0", Length = "0xA0")]
	public static extern int IRailStorageHelper_GetFileNameAndSize(IntPtr jarg1, uint jarg2, IntPtr jarg3, out ulong jarg4);

	[PreserveSig]
	[Address(RVA = "0x39F850", Offset = "0x39E050", Length = "0x78")]
	[Token(Token = "0x600247B")]
	public static extern int IRailStorageHelper_AsyncQueryQuota(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600247C")]
	[Address(RVA = "0x3A04C0", Offset = "0x39ECC0", Length = "0xAC")]
	public static extern int IRailStorageHelper_SetSyncFileOption(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x600247D")]
	[Address(RVA = "0x39FDA0", Offset = "0x39E5A0", Length = "0x7D")]
	public static extern bool IRailStorageHelper_IsCloudStorageEnabledForApp(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39FE20", Offset = "0x39E620", Length = "0x7D")]
	[Token(Token = "0x600247E")]
	public static extern bool IRailStorageHelper_IsCloudStorageEnabledForPlayer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39F790", Offset = "0x39DF90", Length = "0xB5")]
	[Token(Token = "0x600247F")]
	public static extern int IRailStorageHelper_AsyncPublishFileToUserSpace(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A01F0", Offset = "0x39E9F0", Length = "0xBD")]
	[Token(Token = "0x6002480")]
	public static extern IntPtr IRailStorageHelper_OpenStreamFile__SWIG_0(IntPtr jarg1, string jarg2, IntPtr jarg3, out RailResult jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A02B0", Offset = "0x39EAB0", Length = "0xAE")]
	[Token(Token = "0x6002481")]
	public static extern IntPtr IRailStorageHelper_OpenStreamFile__SWIG_1(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002482")]
	[Address(RVA = "0x39F6B0", Offset = "0x39DEB0", Length = "0xD9")]
	public static extern int IRailStorageHelper_AsyncListStreamFiles(IntPtr jarg1, string jarg2, IntPtr jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002483")]
	[Address(RVA = "0x39F8D0", Offset = "0x39E0D0", Length = "0xEC")]
	public static extern int IRailStorageHelper_AsyncRenameStreamFile(IntPtr jarg1, string jarg2, string jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002484")]
	[Address(RVA = "0x39F5E0", Offset = "0x39DDE0", Length = "0xC8")]
	public static extern int IRailStorageHelper_AsyncDeleteStreamFile(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39FCF0", Offset = "0x39E4F0", Length = "0xA6")]
	[Token(Token = "0x6002485")]
	public static extern uint IRailStorageHelper_GetRailFileEnabledOS(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A0410", Offset = "0x39EC10", Length = "0xAC")]
	[Token(Token = "0x6002486")]
	public static extern int IRailStorageHelper_SetRailFileEnabledOS(IntPtr jarg1, string jarg2, int jarg3);

	[PreserveSig]
	[Token(Token = "0x6002487")]
	[Address(RVA = "0x3EA0B0", Offset = "0x3E88B0", Length = "0x78")]
	public static extern void delete_IRailFile(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002488")]
	[Address(RVA = "0x391DB0", Offset = "0x3905B0", Length = "0x78")]
	public static extern IntPtr IRailFile_GetFilename(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002489")]
	[Address(RVA = "0x391EB0", Offset = "0x3906B0", Length = "0xB3")]
	public static extern uint IRailFile_Read__SWIG_0(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, out RailResult jarg4);

	[PreserveSig]
	[Address(RVA = "0x391F70", Offset = "0x390770", Length = "0xA2")]
	[Token(Token = "0x600248A")]
	public static extern uint IRailFile_Read__SWIG_1(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3);

	[PreserveSig]
	[Address(RVA = "0x3920A0", Offset = "0x3908A0", Length = "0xB3")]
	[Token(Token = "0x600248B")]
	public static extern uint IRailFile_Write__SWIG_0(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, out RailResult jarg4);

	[PreserveSig]
	[Token(Token = "0x600248C")]
	[Address(RVA = "0x392160", Offset = "0x390960", Length = "0xA2")]
	public static extern uint IRailFile_Write__SWIG_1(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x600248D")]
	[Address(RVA = "0x391BA0", Offset = "0x3903A0", Length = "0xB3")]
	public static extern int IRailFile_AsyncRead(IntPtr jarg1, uint jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x391C60", Offset = "0x390460", Length = "0xCB")]
	[Token(Token = "0x600248E")]
	public static extern int IRailFile_AsyncWrite(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x600248F")]
	[Address(RVA = "0x391E30", Offset = "0x390630", Length = "0x78")]
	public static extern uint IRailFile_GetSize(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002490")]
	[Address(RVA = "0x391D30", Offset = "0x390530", Length = "0x78")]
	public static extern void IRailFile_Close(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB0B0", Offset = "0x3E98B0", Length = "0x78")]
	[Token(Token = "0x6002491")]
	public static extern void delete_IRailStreamFile(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002492")]
	[Address(RVA = "0x3A0810", Offset = "0x39F010", Length = "0x78")]
	public static extern IntPtr IRailStreamFile_GetFilename(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002493")]
	[Address(RVA = "0x3A0570", Offset = "0x39ED70", Length = "0xC4")]
	public static extern int IRailStreamFile_AsyncRead(IntPtr jarg1, int jarg2, uint jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002494")]
	[Address(RVA = "0x3A0640", Offset = "0x39EE40", Length = "0xCB")]
	public static extern int IRailStreamFile_AsyncWrite(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x6002495")]
	[Address(RVA = "0x3A0890", Offset = "0x39F090", Length = "0x78")]
	public static extern ulong IRailStreamFile_GetSize(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A0790", Offset = "0x39EF90", Length = "0x78")]
	[Token(Token = "0x6002496")]
	public static extern int IRailStreamFile_Close(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002497")]
	[Address(RVA = "0x3A0710", Offset = "0x39EF10", Length = "0x78")]
	public static extern void IRailStreamFile_Cancel(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A1E20", Offset = "0x3A0620", Length = "0xB5")]
	[Token(Token = "0x6002498")]
	public static extern int IRailUsersHelper_AsyncGetUsersInfo(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A1EE0", Offset = "0x3A06E0", Length = "0xE3")]
	[Token(Token = "0x6002499")]
	public static extern int IRailUsersHelper_AsyncInviteUsers(IntPtr jarg1, string jarg2, IntPtr jarg3, IntPtr jarg4, string jarg5);

	[PreserveSig]
	[Address(RVA = "0x3A1C90", Offset = "0x3A0490", Length = "0xC6")]
	[Token(Token = "0x600249A")]
	public static extern int IRailUsersHelper_AsyncGetInviteDetail(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x600249B")]
	[Address(RVA = "0x3A1BD0", Offset = "0x3A03D0", Length = "0xB3")]
	public static extern int IRailUsersHelper_AsyncCancelInvite(IntPtr jarg1, int jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A1B20", Offset = "0x3A0320", Length = "0xA6")]
	[Token(Token = "0x600249C")]
	public static extern int IRailUsersHelper_AsyncCancelAllInvites(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A1D60", Offset = "0x3A0560", Length = "0xB5")]
	[Token(Token = "0x600249D")]
	public static extern int IRailUsersHelper_AsyncGetUserLimits(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A1FD0", Offset = "0x3A07D0", Length = "0xB5")]
	[Token(Token = "0x600249E")]
	public static extern int IRailUsersHelper_AsyncShowChatWindowWithFriend(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A2090", Offset = "0x3A0890", Length = "0xB5")]
	[Token(Token = "0x600249F")]
	public static extern int IRailUsersHelper_AsyncShowUserHomepageWindow(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x3EB2B0", Offset = "0x3E9AB0", Length = "0x78")]
	public static extern void delete_IRailUsersHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x3A0E70", Offset = "0x39F670", Length = "0xDB")]
	public static extern int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_0(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5, string jarg6);

	[PreserveSig]
	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x3A0F50", Offset = "0x39F750", Length = "0xB0")]
	public static extern int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x3A1000", Offset = "0x39F800", Length = "0xA0")]
	public static extern int IRailUserSpaceHelper_AsyncGetMySubscribedWorks__SWIG_2(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A0C40", Offset = "0x39F440", Length = "0xDB")]
	[Token(Token = "0x60024A4")]
	public static extern int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_0(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5, string jarg6);

	[PreserveSig]
	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x3A0D20", Offset = "0x39F520", Length = "0xB0")]
	public static extern int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_1(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5);

	[PreserveSig]
	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x3A0DD0", Offset = "0x39F5D0", Length = "0xA0")]
	public static extern int IRailUserSpaceHelper_AsyncGetMyFavoritesWorks__SWIG_2(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4);

	[PreserveSig]
	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x3A1170", Offset = "0x39F970", Length = "0xE8")]
	public static extern int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_0(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5, IntPtr jarg6, string jarg7);

	[PreserveSig]
	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x3A1260", Offset = "0x39FA60", Length = "0xBD")]
	public static extern int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_1(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5, IntPtr jarg6);

	[PreserveSig]
	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x3A1320", Offset = "0x39FB20", Length = "0xB0")]
	public static extern int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_2(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4, int jarg5);

	[PreserveSig]
	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x3A13D0", Offset = "0x39FBD0", Length = "0xA2")]
	public static extern int IRailUserSpaceHelper_AsyncQuerySpaceWorks__SWIG_3(IntPtr jarg1, IntPtr jarg2, uint jarg3, uint jarg4);

	[PreserveSig]
	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x3A1710", Offset = "0x39FF10", Length = "0xC7")]
	public static extern int IRailUserSpaceHelper_AsyncSubscribeSpaceWorks(IntPtr jarg1, IntPtr jarg2, bool jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A1A90", Offset = "0x3A0290", Length = "0x87")]
	[Token(Token = "0x60024AC")]
	public static extern IntPtr IRailUserSpaceHelper_OpenSpaceWork(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x3A18B0", Offset = "0x3A00B0", Length = "0x85")]
	public static extern IntPtr IRailUserSpaceHelper_CreateSpaceWork(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A19E0", Offset = "0x3A01E0", Length = "0xB0")]
	[Token(Token = "0x60024AE")]
	public static extern int IRailUserSpaceHelper_GetMySubscribedWorks(IntPtr jarg1, uint jarg2, uint jarg3, int jarg4, IntPtr jarg5);

	[PreserveSig]
	[Address(RVA = "0x3A1940", Offset = "0x3A0140", Length = "0x91")]
	[Token(Token = "0x60024AF")]
	public static extern uint IRailUserSpaceHelper_GetMySubscribedWorksCount(IntPtr jarg1, int jarg2, out RailResult jarg3);

	[PreserveSig]
	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x3A1550", Offset = "0x39FD50", Length = "0xB5")]
	public static extern int IRailUserSpaceHelper_AsyncRemoveSpaceWork(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x3A10A0", Offset = "0x39F8A0", Length = "0xC6")]
	public static extern int IRailUserSpaceHelper_AsyncModifyFavoritesWorks(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A17E0", Offset = "0x39FFE0", Length = "0xC6")]
	[Token(Token = "0x60024B2")]
	public static extern int IRailUserSpaceHelper_AsyncVoteSpaceWork(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4);

	[PreserveSig]
	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x3A1610", Offset = "0x39FE10", Length = "0xF1")]
	public static extern int IRailUserSpaceHelper_AsyncSearchSpaceWork(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3, IntPtr jarg4, uint jarg5, uint jarg6, int jarg7, string jarg8);

	[PreserveSig]
	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x3A1480", Offset = "0x39FC80", Length = "0xC6")]
	public static extern int IRailUserSpaceHelper_AsyncRateSpaceWork(IntPtr jarg1, IntPtr jarg2, int jarg3, string jarg4);

	[PreserveSig]
	[Address(RVA = "0x3EB230", Offset = "0x3E9A30", Length = "0x78")]
	[Token(Token = "0x60024B5")]
	public static extern void delete_IRailUserSpaceHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024B6")]
	[Address(RVA = "0x39D690", Offset = "0x39BE90", Length = "0x78")]
	public static extern void IRailSpaceWork_Close(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024B7")]
	[Address(RVA = "0x39E180", Offset = "0x39C980", Length = "0x78")]
	public static extern IntPtr IRailSpaceWork_GetSpaceWorkID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024B8")]
	[Address(RVA = "0x39D710", Offset = "0x39BF10", Length = "0x7D")]
	public static extern bool IRailSpaceWork_Editable(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024B9")]
	[Address(RVA = "0x39F370", Offset = "0x39DB70", Length = "0xA6")]
	public static extern int IRailSpaceWork_StartSync(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39E3A0", Offset = "0x39CBA0", Length = "0x87")]
	[Token(Token = "0x60024BA")]
	public static extern int IRailSpaceWork_GetSyncProgress(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024BB")]
	[Address(RVA = "0x39D610", Offset = "0x39BE10", Length = "0x78")]
	public static extern int IRailSpaceWork_CancelSync(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E780", Offset = "0x39CF80", Length = "0x87")]
	[Token(Token = "0x60024BC")]
	public static extern int IRailSpaceWork_GetWorkLocalFolder(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024BD")]
	[Address(RVA = "0x39D560", Offset = "0x39BD60", Length = "0xA6")]
	public static extern int IRailSpaceWork_AsyncUpdateMetadata(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60024BE")]
	[Address(RVA = "0x39DE30", Offset = "0x39C630", Length = "0x87")]
	public static extern int IRailSpaceWork_GetName(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024BF")]
	[Address(RVA = "0x39DA50", Offset = "0x39C250", Length = "0x87")]
	public static extern int IRailSpaceWork_GetDescription(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024C0")]
	[Address(RVA = "0x39E550", Offset = "0x39CD50", Length = "0x87")]
	public static extern int IRailSpaceWork_GetUrl(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024C1")]
	[Address(RVA = "0x39D9D0", Offset = "0x39C1D0", Length = "0x78")]
	public static extern uint IRailSpaceWork_GetCreateTime(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39DBF0", Offset = "0x39C3F0", Length = "0x78")]
	[Token(Token = "0x60024C2")]
	public static extern uint IRailSpaceWork_GetLastUpdateTime(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024C3")]
	[Address(RVA = "0x39E700", Offset = "0x39CF00", Length = "0x78")]
	public static extern ulong IRailSpaceWork_GetWorkFileSize(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024C4")]
	[Address(RVA = "0x39E430", Offset = "0x39CC30", Length = "0x87")]
	public static extern int IRailSpaceWork_GetTags(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x39DEC0", Offset = "0x39C6C0", Length = "0x87")]
	public static extern int IRailSpaceWork_GetPreviewImage(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x39E5E0", Offset = "0x39CDE0", Length = "0x87")]
	public static extern int IRailSpaceWork_GetVersion(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x39DAE0", Offset = "0x39C2E0", Length = "0x78")]
	public static extern ulong IRailSpaceWork_GetDownloadCount(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E320", Offset = "0x39CB20", Length = "0x78")]
	[Token(Token = "0x60024C8")]
	public static extern ulong IRailSpaceWork_GetSubscribedCount(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E100", Offset = "0x39C900", Length = "0x78")]
	[Token(Token = "0x60024C9")]
	public static extern int IRailSpaceWork_GetShareLevel(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E080", Offset = "0x39C880", Length = "0x78")]
	[Token(Token = "0x60024CA")]
	public static extern ulong IRailSpaceWork_GetScore(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39DD00", Offset = "0x39C500", Length = "0xAC")]
	[Token(Token = "0x60024CB")]
	public static extern int IRailSpaceWork_GetMetadata(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60024CC")]
	[Address(RVA = "0x39DDB0", Offset = "0x39C5B0", Length = "0x78")]
	public static extern int IRailSpaceWork_GetMyVote(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024CD")]
	[Address(RVA = "0x39E810", Offset = "0x39D010", Length = "0x7D")]
	public static extern bool IRailSpaceWork_IsFavorite(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E890", Offset = "0x39D090", Length = "0x7D")]
	[Token(Token = "0x60024CE")]
	public static extern bool IRailSpaceWork_IsSubscribed(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39EF30", Offset = "0x39D730", Length = "0xA6")]
	[Token(Token = "0x60024CF")]
	public static extern int IRailSpaceWork_SetName(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39ED20", Offset = "0x39D520", Length = "0xA6")]
	[Token(Token = "0x60024D0")]
	public static extern int IRailSpaceWork_SetDescription(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39F1A0", Offset = "0x39D9A0", Length = "0x87")]
	[Token(Token = "0x60024D1")]
	public static extern int IRailSpaceWork_SetTags(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024D2")]
	[Address(RVA = "0x39EFE0", Offset = "0x39D7E0", Length = "0xA6")]
	public static extern int IRailSpaceWork_SetPreviewImage(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39F2C0", Offset = "0x39DAC0", Length = "0xA6")]
	[Token(Token = "0x60024D3")]
	public static extern int IRailSpaceWork_SetVersion(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39F090", Offset = "0x39D890", Length = "0x85")]
	[Token(Token = "0x60024D4")]
	public static extern int IRailSpaceWork_SetShareLevel__SWIG_0(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x60024D5")]
	[Address(RVA = "0x39F120", Offset = "0x39D920", Length = "0x78")]
	public static extern int IRailSpaceWork_SetShareLevel__SWIG_1(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024D6")]
	[Address(RVA = "0x39EE60", Offset = "0x39D660", Length = "0xC8")]
	public static extern int IRailSpaceWork_SetMetadata(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x39EC70", Offset = "0x39D470", Length = "0xA6")]
	[Token(Token = "0x60024D7")]
	public static extern int IRailSpaceWork_SetContentFromFolder(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x39D820", Offset = "0x39C020", Length = "0x87")]
	[Token(Token = "0x60024D8")]
	public static extern int IRailSpaceWork_GetAllMetadata(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39D790", Offset = "0x39BF90", Length = "0x87")]
	[Token(Token = "0x60024D9")]
	public static extern int IRailSpaceWork_GetAdditionalPreviewUrls(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39D940", Offset = "0x39C140", Length = "0x87")]
	[Token(Token = "0x60024DA")]
	public static extern int IRailSpaceWork_GetAssociatedSpaceWorks(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024DB")]
	[Address(RVA = "0x39DB60", Offset = "0x39C360", Length = "0x87")]
	public static extern int IRailSpaceWork_GetLanguages(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024DC")]
	[Address(RVA = "0x39E9A0", Offset = "0x39D1A0", Length = "0xA6")]
	public static extern int IRailSpaceWork_RemoveMetadata(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x60024DD")]
	[Address(RVA = "0x39EB50", Offset = "0x39D350", Length = "0x87")]
	public static extern int IRailSpaceWork_SetAdditionalPreviews(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024DE")]
	[Address(RVA = "0x39EBE0", Offset = "0x39D3E0", Length = "0x87")]
	public static extern int IRailSpaceWork_SetAssociatedSpaceWorks(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x39EDD0", Offset = "0x39D5D0", Length = "0x87")]
	public static extern int IRailSpaceWork_SetLanguages(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x39DF50", Offset = "0x39C750", Length = "0x93")]
	public static extern int IRailSpaceWork_GetPreviewUrl__SWIG_0(IntPtr jarg1, IntPtr jarg2, uint jarg3);

	[PreserveSig]
	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x39DFF0", Offset = "0x39C7F0", Length = "0x87")]
	public static extern int IRailSpaceWork_GetPreviewUrl__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39E670", Offset = "0x39CE70", Length = "0x87")]
	[Token(Token = "0x60024E2")]
	public static extern int IRailSpaceWork_GetVoteDetail(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39E4C0", Offset = "0x39CCC0", Length = "0x87")]
	[Token(Token = "0x60024E3")]
	public static extern int IRailSpaceWork_GetUploaderIDs(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39F230", Offset = "0x39DA30", Length = "0x87")]
	[Token(Token = "0x60024E4")]
	public static extern int IRailSpaceWork_SetUpdateOptions(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x39E280", Offset = "0x39CA80", Length = "0x91")]
	[Token(Token = "0x60024E5")]
	public static extern int IRailSpaceWork_GetStatistic(IntPtr jarg1, int jarg2, out ulong jarg3);

	[PreserveSig]
	[Address(RVA = "0x39EA50", Offset = "0x39D250", Length = "0x78")]
	[Token(Token = "0x60024E6")]
	public static extern int IRailSpaceWork_RemovePreviewImage(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39E200", Offset = "0x39CA00", Length = "0x78")]
	[Token(Token = "0x60024E7")]
	public static extern uint IRailSpaceWork_GetState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39D4D0", Offset = "0x39BCD0", Length = "0x87")]
	[Token(Token = "0x60024E8")]
	public static extern int IRailSpaceWork_AddAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x39E910", Offset = "0x39D110", Length = "0x87")]
	public static extern int IRailSpaceWork_RemoveAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x39D8B0", Offset = "0x39C0B0", Length = "0x87")]
	public static extern int IRailSpaceWork_GetAssociatedGameIDs(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x39DC70", Offset = "0x39C470", Length = "0x87")]
	public static extern int IRailSpaceWork_GetLocalVersion(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x3EAF30", Offset = "0x3E9730", Length = "0x78")]
	public static extern void delete_IRailSpaceWork(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x3A2660", Offset = "0x3A0E60", Length = "0x78")]
	public static extern uint IRailUtils_GetTimeCountSinceGameLaunch(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x3A25E0", Offset = "0x3A0DE0", Length = "0x78")]
	public static extern uint IRailUtils_GetTimeCountSinceComputerLaunch(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x3A26E0", Offset = "0x3A0EE0", Length = "0x78")]
	public static extern uint IRailUtils_GetTimeFromServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A2150", Offset = "0x3A0950", Length = "0xE3")]
	[Token(Token = "0x60024F0")]
	public static extern int IRailUtils_AsyncGetImageData(IntPtr jarg1, string jarg2, uint jarg3, uint jarg4, string jarg5);

	[PreserveSig]
	[Address(RVA = "0x3A2390", Offset = "0x3A0B90", Length = "0x91")]
	[Token(Token = "0x60024F1")]
	public static extern void IRailUtils_GetErrorString(IntPtr jarg1, int jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A2240", Offset = "0x3A0A40", Length = "0xBC")]
	[Token(Token = "0x60024F2")]
	public static extern int IRailUtils_DirtyWordsFilter(IntPtr jarg1, string jarg2, bool jarg3, IntPtr jarg4);

	[PreserveSig]
	[Token(Token = "0x60024F3")]
	[Address(RVA = "0x3A2560", Offset = "0x3A0D60", Length = "0x78")]
	public static extern int IRailUtils_GetRailPlatformType(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024F4")]
	[Address(RVA = "0x3A2430", Offset = "0x3A0C30", Length = "0x91")]
	public static extern int IRailUtils_GetLaunchAppParameters(IntPtr jarg1, int jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x60024F5")]
	[Address(RVA = "0x3A24D0", Offset = "0x3A0CD0", Length = "0x87")]
	public static extern int IRailUtils_GetPlatformLanguageCode(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x60024F6")]
	[Address(RVA = "0x3A2760", Offset = "0x3A0F60", Length = "0x91")]
	public static extern int IRailUtils_SetWarningMessageCallback(IntPtr jarg1, RailWarningMessageCallbackFunction jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A2300", Offset = "0x3A0B00", Length = "0x87")]
	[Token(Token = "0x60024F7")]
	public static extern int IRailUtils_GetCountryCodeOfCurrentLoggedInIP(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EB330", Offset = "0x3E9B30", Length = "0x78")]
	[Token(Token = "0x60024F8")]
	public static extern void delete_IRailUtils(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38DFA0", Offset = "0x38C7A0", Length = "0x8C")]
	[Token(Token = "0x60024F9")]
	public static extern bool IRailApps_IsGameInstalled(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x38DEE0", Offset = "0x38C6E0", Length = "0xB5")]
	[Token(Token = "0x60024FA")]
	public static extern int IRailApps_AsyncQuerySubscribeWishPlayState(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Address(RVA = "0x3E9C30", Offset = "0x3E8430", Length = "0x78")]
	[Token(Token = "0x60024FB")]
	public static extern void delete_IRailApps(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x3EB430", Offset = "0x3E9C30", Length = "0x78")]
	public static extern void delete_IRailVoiceHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x3A3170", Offset = "0x3A1970", Length = "0xE8")]
	public static extern IntPtr IRailVoiceHelper_AsyncCreateVoiceChannel(IntPtr jarg1, IntPtr jarg2, string jarg3, string jarg4, out RailResult jarg5);

	[PreserveSig]
	[Address(RVA = "0x3A36A0", Offset = "0x3A1EA0", Length = "0xBD")]
	[Token(Token = "0x60024FE")]
	public static extern IntPtr IRailVoiceHelper_OpenVoiceChannel(IntPtr jarg1, IntPtr jarg2, string jarg3, out RailResult jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A3510", Offset = "0x3A1D10", Length = "0x78")]
	[Token(Token = "0x60024FF")]
	public static extern int IRailVoiceHelper_GetSpeakerState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002500")]
	[Address(RVA = "0x3A3620", Offset = "0x3A1E20", Length = "0x78")]
	public static extern int IRailVoiceHelper_MuteSpeaker(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002501")]
	[Address(RVA = "0x3A3760", Offset = "0x3A1F60", Length = "0x78")]
	public static extern int IRailVoiceHelper_ResumeSpeaker(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002502")]
	[Address(RVA = "0x3A3A40", Offset = "0x3A2240", Length = "0x9D")]
	public static extern int IRailVoiceHelper_SetupVoiceCapture__SWIG_0(IntPtr jarg1, IntPtr jarg2, RailCaptureVoiceCallback jarg3);

	[PreserveSig]
	[Token(Token = "0x6002503")]
	[Address(RVA = "0x3A3AE0", Offset = "0x3A22E0", Length = "0x87")]
	public static extern int IRailVoiceHelper_SetupVoiceCapture__SWIG_1(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002504")]
	[Address(RVA = "0x3A3C00", Offset = "0x3A2400", Length = "0x92")]
	public static extern int IRailVoiceHelper_StartVoiceCapturing__SWIG_0(IntPtr jarg1, uint jarg2, bool jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A3CA0", Offset = "0x3A24A0", Length = "0x85")]
	[Token(Token = "0x6002505")]
	public static extern int IRailVoiceHelper_StartVoiceCapturing__SWIG_1(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002506")]
	[Address(RVA = "0x3A3D30", Offset = "0x3A2530", Length = "0x78")]
	public static extern int IRailVoiceHelper_StartVoiceCapturing__SWIG_2(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002507")]
	[Address(RVA = "0x3A3DB0", Offset = "0x3A25B0", Length = "0x78")]
	public static extern int IRailVoiceHelper_StopVoiceCapturing(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002508")]
	[Address(RVA = "0x3A33D0", Offset = "0x3A1BD0", Length = "0xB3")]
	public static extern int IRailVoiceHelper_GetCapturedVoiceData(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, out uint jarg4);

	[PreserveSig]
	[Address(RVA = "0x3A3260", Offset = "0x3A1A60", Length = "0xD7")]
	[Token(Token = "0x6002509")]
	public static extern int IRailVoiceHelper_DecodeVoice(IntPtr jarg1, [In][Out] byte[] jarg2, uint jarg3, [In][Out] byte[] jarg4, uint jarg5, out uint jarg6);

	[PreserveSig]
	[Address(RVA = "0x3A3590", Offset = "0x3A1D90", Length = "0x87")]
	[Token(Token = "0x600250A")]
	public static extern int IRailVoiceHelper_GetVoiceCaptureSpecification(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A3340", Offset = "0x3A1B40", Length = "0x86")]
	[Token(Token = "0x600250B")]
	public static extern int IRailVoiceHelper_EnableInGameVoiceSpeaking(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Token(Token = "0x600250C")]
	[Address(RVA = "0x3A3870", Offset = "0x3A2070", Length = "0xA6")]
	public static extern int IRailVoiceHelper_SetPlayerNicknameInVoiceChannel(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A3920", Offset = "0x3A2120", Length = "0x85")]
	[Token(Token = "0x600250D")]
	public static extern int IRailVoiceHelper_SetPushToTalkKeyInVoiceChannel(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A3490", Offset = "0x3A1C90", Length = "0x78")]
	[Token(Token = "0x600250E")]
	public static extern uint IRailVoiceHelper_GetPushToTalkKeyInVoiceChannel(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A3B70", Offset = "0x3A2370", Length = "0x86")]
	[Token(Token = "0x600250F")]
	public static extern int IRailVoiceHelper_ShowOverlayUI(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A37E0", Offset = "0x3A1FE0", Length = "0x85")]
	[Token(Token = "0x6002510")]
	public static extern int IRailVoiceHelper_SetMicroVolume(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A39B0", Offset = "0x3A21B0", Length = "0x85")]
	[Token(Token = "0x6002511")]
	public static extern int IRailVoiceHelper_SetSpeakerVolume(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EB3B0", Offset = "0x3E9BB0", Length = "0x78")]
	[Token(Token = "0x6002512")]
	public static extern void delete_IRailVoiceChannel(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A2E60", Offset = "0x3A1660", Length = "0x78")]
	[Token(Token = "0x6002513")]
	public static extern IntPtr IRailVoiceChannel_GetVoiceChannelID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002514")]
	[Address(RVA = "0x3A2EE0", Offset = "0x3A16E0", Length = "0x78")]
	public static extern IntPtr IRailVoiceChannel_GetVoiceChannelName(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002515")]
	[Address(RVA = "0x3A2C20", Offset = "0x3A1420", Length = "0x78")]
	public static extern int IRailVoiceChannel_GetJoinState(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002516")]
	[Address(RVA = "0x3A28C0", Offset = "0x3A10C0", Length = "0xA6")]
	public static extern int IRailVoiceChannel_AsyncJoinVoiceChannel(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002517")]
	[Address(RVA = "0x3A2970", Offset = "0x3A1170", Length = "0xA6")]
	public static extern int IRailVoiceChannel_AsyncLeaveVoiceChannel(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002518")]
	[Address(RVA = "0x3A2DD0", Offset = "0x3A15D0", Length = "0x87")]
	public static extern int IRailVoiceChannel_GetUsers(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002519")]
	[Address(RVA = "0x3A2800", Offset = "0x3A1000", Length = "0xB5")]
	public static extern int IRailVoiceChannel_AsyncAddUsers(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600251A")]
	[Address(RVA = "0x3A2A20", Offset = "0x3A1220", Length = "0xB5")]
	public static extern int IRailVoiceChannel_AsyncRemoveUsers(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600251B")]
	[Address(RVA = "0x3A2BA0", Offset = "0x3A13A0", Length = "0x78")]
	public static extern int IRailVoiceChannel_CloseChannel(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A30E0", Offset = "0x3A18E0", Length = "0x86")]
	[Token(Token = "0x600251C")]
	public static extern int IRailVoiceChannel_SetSelfSpeaking(IntPtr jarg1, bool jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A2FE0", Offset = "0x3A17E0", Length = "0x7D")]
	[Token(Token = "0x600251D")]
	public static extern bool IRailVoiceChannel_IsSelfSpeaking(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600251E")]
	[Address(RVA = "0x3A2AE0", Offset = "0x3A12E0", Length = "0xB5")]
	public static extern int IRailVoiceChannel_AsyncSetUsersSpeakingState(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600251F")]
	[Address(RVA = "0x3A2D40", Offset = "0x3A1540", Length = "0x87")]
	public static extern int IRailVoiceChannel_GetUsersSpeakingState(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A2CA0", Offset = "0x3A14A0", Length = "0x93")]
	[Token(Token = "0x6002520")]
	public static extern int IRailVoiceChannel_GetSpeakingUsers(IntPtr jarg1, IntPtr jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002521")]
	[Address(RVA = "0x3A2F60", Offset = "0x3A1760", Length = "0x7D")]
	public static extern bool IRailVoiceChannel_IsOwner(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002522")]
	[Address(RVA = "0x3A0BB0", Offset = "0x39F3B0", Length = "0x87")]
	public static extern int IRailTextInputHelper_ShowTextInputWindow(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002523")]
	[Address(RVA = "0x3A0AA0", Offset = "0x39F2A0", Length = "0x87")]
	public static extern void IRailTextInputHelper_GetTextInputContent(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002524")]
	[Address(RVA = "0x3A0B30", Offset = "0x39F330", Length = "0x78")]
	public static extern int IRailTextInputHelper_HideTextInputWindow(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB1B0", Offset = "0x3E99B0", Length = "0x78")]
	[Token(Token = "0x6002525")]
	public static extern void delete_IRailTextInputHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002526")]
	[Address(RVA = "0x395A30", Offset = "0x394230", Length = "0x78")]
	public static extern IntPtr IRailGame_GetGameID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002527")]
	[Address(RVA = "0x395F00", Offset = "0x394700", Length = "0x85")]
	public static extern int IRailGame_ReportGameContentDamaged(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002528")]
	[Address(RVA = "0x395AB0", Offset = "0x3942B0", Length = "0x87")]
	public static extern int IRailGame_GetGameInstallPath(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002529")]
	[Address(RVA = "0x3956A0", Offset = "0x393EA0", Length = "0xA6")]
	public static extern int IRailGame_AsyncQuerySubscribeWishPlayState(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600252A")]
	[Address(RVA = "0x395CE0", Offset = "0x3944E0", Length = "0x87")]
	public static extern int IRailGame_GetPlayerSelectedLanguageCode(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600252B")]
	[Address(RVA = "0x395C50", Offset = "0x394450", Length = "0x87")]
	public static extern int IRailGame_GetGameSupportedLanguageCodes(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x396020", Offset = "0x394820", Length = "0x85")]
	[Token(Token = "0x600252C")]
	public static extern int IRailGame_SetGameState(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x600252D")]
	[Address(RVA = "0x395BC0", Offset = "0x3943C0", Length = "0x87")]
	public static extern int IRailGame_GetGameState(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395E70", Offset = "0x394670", Length = "0x87")]
	[Token(Token = "0x600252E")]
	public static extern int IRailGame_RegisterGameDefineGamePlayingState(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395F90", Offset = "0x394790", Length = "0x85")]
	[Token(Token = "0x600252F")]
	public static extern int IRailGame_SetGameDefineGamePlayingState(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002530")]
	[Address(RVA = "0x395920", Offset = "0x394120", Length = "0x87")]
	public static extern int IRailGame_GetGameDefineGamePlayingState(IntPtr jarg1, out uint jarg2);

	[PreserveSig]
	[Token(Token = "0x6002531")]
	[Address(RVA = "0x395800", Offset = "0x394000", Length = "0x87")]
	public static extern int IRailGame_GetBranchBuildNumber(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x395890", Offset = "0x394090", Length = "0x87")]
	[Token(Token = "0x6002532")]
	public static extern int IRailGame_GetCurrentBranchInfo(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3960B0", Offset = "0x3948B0", Length = "0xA6")]
	[Token(Token = "0x6002533")]
	public static extern int IRailGame_StartGameTimeCounting(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x395750", Offset = "0x393F50", Length = "0xA6")]
	[Token(Token = "0x6002534")]
	public static extern int IRailGame_EndGameTimeCounting(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x395B40", Offset = "0x394340", Length = "0x78")]
	[Token(Token = "0x6002535")]
	public static extern IntPtr IRailGame_GetGamePurchasePlayerRailID(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3959B0", Offset = "0x3941B0", Length = "0x78")]
	[Token(Token = "0x6002536")]
	public static extern uint IRailGame_GetGameEarliestPurchaseTime(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002537")]
	[Address(RVA = "0x395D70", Offset = "0x394570", Length = "0x78")]
	public static extern uint IRailGame_GetTimeCountSinceGameActivated(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x395DF0", Offset = "0x3945F0", Length = "0x78")]
	[Token(Token = "0x6002538")]
	public static extern uint IRailGame_GetTimeCountSinceLastMouseMoved(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EA330", Offset = "0x3E8B30", Length = "0x78")]
	[Token(Token = "0x6002539")]
	public static extern void delete_IRailGame(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x397790", Offset = "0x395F90", Length = "0x92")]
	[Token(Token = "0x600253A")]
	public static extern int IRailIMEHelper_EnableIMEHelperTextInputWindow(IntPtr jarg1, bool jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x600253B")]
	[Address(RVA = "0x397830", Offset = "0x396030", Length = "0x87")]
	public static extern int IRailIMEHelper_UpdateIMEHelperTextInputWindowPosition(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x600253C")]
	[Address(RVA = "0x3EA730", Offset = "0x3E8F30", Length = "0x78")]
	public static extern void delete_IRailIMEHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EAEB0", Offset = "0x3E96B0", Length = "0x78")]
	[Token(Token = "0x600253D")]
	public static extern void delete_IRailSmallObjectServiceHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39D2C0", Offset = "0x39BAC0", Length = "0xB5")]
	[Token(Token = "0x600253E")]
	public static extern int IRailSmallObjectServiceHelper_AsyncDownloadObjects(IntPtr jarg1, IntPtr jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600253F")]
	[Address(RVA = "0x39D430", Offset = "0x39BC30", Length = "0x91")]
	public static extern int IRailSmallObjectServiceHelper_GetObjectContent(IntPtr jarg1, uint jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002540")]
	[Address(RVA = "0x39D380", Offset = "0x39BB80", Length = "0xA6")]
	public static extern int IRailSmallObjectServiceHelper_AsyncQueryObjectState(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x3A0A10", Offset = "0x39F210", Length = "0x85")]
	public static extern int IRailSystemHelper_SetTerminationTimeoutOwnershipExpired(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Token(Token = "0x6002542")]
	[Address(RVA = "0x3A0990", Offset = "0x39F190", Length = "0x78")]
	public static extern int IRailSystemHelper_GetPlatformSystemState(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB130", Offset = "0x3E9930", Length = "0x78")]
	[Token(Token = "0x6002543")]
	public static extern void delete_IRailSystemHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3972D0", Offset = "0x395AD0", Length = "0x78")]
	[Token(Token = "0x6002544")]
	public static extern IntPtr IRailHttpSessionHelper_CreateHttpSession(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x397220", Offset = "0x395A20", Length = "0xA8")]
	[Token(Token = "0x6002545")]
	public static extern IntPtr IRailHttpSessionHelper_CreateHttpResponse(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x6002546")]
	[Address(RVA = "0x3EA630", Offset = "0x3E8E30", Length = "0x78")]
	public static extern void delete_IRailHttpSessionHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002547")]
	[Address(RVA = "0x397670", Offset = "0x395E70", Length = "0x85")]
	public static extern int IRailHttpSession_SetRequestMethod(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3974A0", Offset = "0x395CA0", Length = "0x87")]
	[Token(Token = "0x6002548")]
	public static extern int IRailHttpSession_SetParameters(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002549")]
	[Address(RVA = "0x397530", Offset = "0x395D30", Length = "0xA6")]
	public static extern int IRailHttpSession_SetPostBodyContent(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Token(Token = "0x600254A")]
	[Address(RVA = "0x397700", Offset = "0x395F00", Length = "0x85")]
	public static extern int IRailHttpSession_SetRequestTimeOut(IntPtr jarg1, uint jarg2);

	[PreserveSig]
	[Address(RVA = "0x3975E0", Offset = "0x395DE0", Length = "0x87")]
	[Token(Token = "0x600254B")]
	public static extern int IRailHttpSession_SetRequestHeaders(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x397350", Offset = "0x395B50", Length = "0xC8")]
	[Token(Token = "0x600254C")]
	public static extern int IRailHttpSession_AsyncSendRequest(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600254D")]
	[Address(RVA = "0x3EA6B0", Offset = "0x3E8EB0", Length = "0x78")]
	public static extern void delete_IRailHttpSession(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396EE0", Offset = "0x3956E0", Length = "0x78")]
	[Token(Token = "0x600254E")]
	public static extern int IRailHttpResponse_GetHttpResponseCode(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600254F")]
	[Address(RVA = "0x397060", Offset = "0x395860", Length = "0x87")]
	public static extern int IRailHttpResponse_GetResponseHeaderKeys(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002550")]
	[Address(RVA = "0x3970F0", Offset = "0x3958F0", Length = "0xA8")]
	public static extern IntPtr IRailHttpResponse_GetResponseHeaderValue(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x396FE0", Offset = "0x3957E0", Length = "0x78")]
	[Token(Token = "0x6002551")]
	public static extern IntPtr IRailHttpResponse_GetResponseBodyData(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396D60", Offset = "0x395560", Length = "0x78")]
	[Token(Token = "0x6002552")]
	public static extern uint IRailHttpResponse_GetContentLength(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396E60", Offset = "0x395660", Length = "0x78")]
	[Token(Token = "0x6002553")]
	public static extern IntPtr IRailHttpResponse_GetContentType(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396DE0", Offset = "0x3955E0", Length = "0x78")]
	[Token(Token = "0x6002554")]
	public static extern IntPtr IRailHttpResponse_GetContentRange(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396CE0", Offset = "0x3954E0", Length = "0x78")]
	[Token(Token = "0x6002555")]
	public static extern IntPtr IRailHttpResponse_GetContentLanguage(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396C60", Offset = "0x395460", Length = "0x78")]
	[Token(Token = "0x6002556")]
	public static extern IntPtr IRailHttpResponse_GetContentEncoding(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396F60", Offset = "0x395760", Length = "0x78")]
	[Token(Token = "0x6002557")]
	public static extern IntPtr IRailHttpResponse_GetLastModified(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002558")]
	[Address(RVA = "0x3EA5B0", Offset = "0x3E8DB0", Length = "0x78")]
	public static extern void delete_IRailHttpResponse(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002559")]
	[Address(RVA = "0x3A3EC0", Offset = "0x3A26C0", Length = "0x78")]
	public static extern IntPtr IRailZoneServerHelper_GetPlayerSelectedZoneID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600255A")]
	[Address(RVA = "0x3A3F40", Offset = "0x3A2740", Length = "0x78")]
	public static extern IntPtr IRailZoneServerHelper_GetRootZoneID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600255B")]
	[Address(RVA = "0x3A3FC0", Offset = "0x3A27C0", Length = "0x93")]
	public static extern IntPtr IRailZoneServerHelper_OpenZoneServer(IntPtr jarg1, IntPtr jarg2, out RailResult jarg3);

	[PreserveSig]
	[Token(Token = "0x600255C")]
	[Address(RVA = "0x3A3E30", Offset = "0x3A2630", Length = "0x87")]
	public static extern int IRailZoneServerHelper_AsyncSwitchPlayerSelectedZone(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3EB4B0", Offset = "0x3E9CB0", Length = "0x78")]
	[Token(Token = "0x600255D")]
	public static extern void delete_IRailZoneServerHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A43C0", Offset = "0x3A2BC0", Length = "0x78")]
	[Token(Token = "0x600255E")]
	public static extern IntPtr IRailZoneServer_GetZoneID(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600255F")]
	[Address(RVA = "0x3A44D0", Offset = "0x3A2CD0", Length = "0x87")]
	public static extern int IRailZoneServer_GetZoneNameLanguages(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A4560", Offset = "0x3A2D60", Length = "0xAC")]
	[Token(Token = "0x6002560")]
	public static extern int IRailZoneServer_GetZoneName(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Address(RVA = "0x3A4180", Offset = "0x3A2980", Length = "0x87")]
	[Token(Token = "0x6002561")]
	public static extern int IRailZoneServer_GetZoneDescriptionLanguages(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002562")]
	[Address(RVA = "0x3A4210", Offset = "0x3A2A10", Length = "0xAC")]
	public static extern int IRailZoneServer_GetZoneDescription(IntPtr jarg1, string jarg2, IntPtr jarg3);

	[PreserveSig]
	[Token(Token = "0x6002563")]
	[Address(RVA = "0x3A40F0", Offset = "0x3A28F0", Length = "0x87")]
	public static extern int IRailZoneServer_GetGameServerAddresses(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002564")]
	[Address(RVA = "0x3A4440", Offset = "0x3A2C40", Length = "0x87")]
	public static extern int IRailZoneServer_GetZoneMetadatas(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A4060", Offset = "0x3A2860", Length = "0x87")]
	[Token(Token = "0x6002565")]
	public static extern int IRailZoneServer_GetChildrenZoneIDs(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002566")]
	[Address(RVA = "0x3A4690", Offset = "0x3A2E90", Length = "0x7D")]
	public static extern bool IRailZoneServer_IsZoneVisiable(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A4610", Offset = "0x3A2E10", Length = "0x7D")]
	[Token(Token = "0x6002567")]
	public static extern bool IRailZoneServer_IsZoneJoinable(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002568")]
	[Address(RVA = "0x3A4340", Offset = "0x3A2B40", Length = "0x78")]
	public static extern uint IRailZoneServer_GetZoneEnableStartTime(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A42C0", Offset = "0x3A2AC0", Length = "0x78")]
	[Token(Token = "0x6002569")]
	public static extern uint IRailZoneServer_GetZoneEnableEndTime(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EB530", Offset = "0x3E9D30", Length = "0x78")]
	[Token(Token = "0x600256A")]
	public static extern void delete_IRailZoneServer(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396A20", Offset = "0x395220", Length = "0xA6")]
	[Token(Token = "0x600256B")]
	public static extern int IRailGroupChatHelper_AsyncQueryGroupsInfo(IntPtr jarg1, string jarg2);

	[PreserveSig]
	[Address(RVA = "0x396950", Offset = "0x395150", Length = "0xCA")]
	[Token(Token = "0x600256C")]
	public static extern IntPtr IRailGroupChatHelper_AsyncOpenGroupChat(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x600256D")]
	[Address(RVA = "0x3EA4B0", Offset = "0x3E8CB0", Length = "0x78")]
	public static extern void delete_IRailGroupChatHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396AD0", Offset = "0x3952D0", Length = "0x87")]
	[Token(Token = "0x600256E")]
	public static extern int IRailGroupChat_GetGroupInfo(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Address(RVA = "0x396B60", Offset = "0x395360", Length = "0x78")]
	[Token(Token = "0x600256F")]
	public static extern int IRailGroupChat_OpenGroupWindow(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EA530", Offset = "0x3E8D30", Length = "0x78")]
	[Token(Token = "0x6002570")]
	public static extern void delete_IRailGroupChat(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x397E80", Offset = "0x396680", Length = "0xC8")]
	[Token(Token = "0x6002571")]
	public static extern int IRailInGameStorePurchaseHelper_AsyncShowPaymentWindow(IntPtr jarg1, string jarg2, string jarg3);

	[PreserveSig]
	[Token(Token = "0x6002572")]
	[Address(RVA = "0x3EA8B0", Offset = "0x3E90B0", Length = "0x78")]
	public static extern void delete_IRailInGameStorePurchaseHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002573")]
	[Address(RVA = "0x391520", Offset = "0x38FD20", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailPlayer(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002574")]
	[Address(RVA = "0x3919A0", Offset = "0x3901A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailUsersHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390FA0", Offset = "0x38F7A0", Length = "0x78")]
	[Token(Token = "0x6002575")]
	public static extern IntPtr IRailFactory_RailFriends(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002576")]
	[Address(RVA = "0x390F20", Offset = "0x38F720", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailFloatingWindow(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002577")]
	[Address(RVA = "0x390E20", Offset = "0x38F620", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailBrowserHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002578")]
	[Address(RVA = "0x391320", Offset = "0x38FB20", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailInGamePurchase(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3912A0", Offset = "0x38FAA0", Length = "0x78")]
	[Token(Token = "0x6002579")]
	public static extern IntPtr IRailFactory_RailInGameCoin(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600257A")]
	[Address(RVA = "0x3915A0", Offset = "0x38FDA0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailRoomHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600257B")]
	[Address(RVA = "0x391020", Offset = "0x38F820", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailGameServerHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600257C")]
	[Address(RVA = "0x3917A0", Offset = "0x38FFA0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailStorageHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600257D")]
	[Address(RVA = "0x391920", Offset = "0x390120", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailUserSpaceHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600257E")]
	[Address(RVA = "0x391720", Offset = "0x38FF20", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailStatisticHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x391420", Offset = "0x38FC20", Length = "0x78")]
	[Token(Token = "0x600257F")]
	public static extern IntPtr IRailFactory_RailLeaderboardHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390CA0", Offset = "0x38F4A0", Length = "0x78")]
	[Token(Token = "0x6002580")]
	public static extern IntPtr IRailFactory_RailAchievementHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002581")]
	[Address(RVA = "0x3914A0", Offset = "0x38FCA0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailNetworkHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x390D20", Offset = "0x38F520", Length = "0x78")]
	[Token(Token = "0x6002582")]
	public static extern IntPtr IRailFactory_RailApps(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002583")]
	[Address(RVA = "0x3910A0", Offset = "0x38F8A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailGame(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002584")]
	[Address(RVA = "0x391A20", Offset = "0x390220", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailUtils(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002585")]
	[Address(RVA = "0x390DA0", Offset = "0x38F5A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailAssetsHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002586")]
	[Address(RVA = "0x390EA0", Offset = "0x38F6A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailDlcHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x391620", Offset = "0x38FE20", Length = "0x78")]
	[Token(Token = "0x6002587")]
	public static extern IntPtr IRailFactory_RailScreenshotHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002588")]
	[Address(RVA = "0x391AA0", Offset = "0x3902A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailVoiceHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002589")]
	[Address(RVA = "0x391820", Offset = "0x390020", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailSystemHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3918A0", Offset = "0x3900A0", Length = "0x78")]
	[Token(Token = "0x600258A")]
	public static extern IntPtr IRailFactory_RailTextInputHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x391220", Offset = "0x38FA20", Length = "0x78")]
	[Token(Token = "0x600258B")]
	public static extern IntPtr IRailFactory_RailIMETextInputHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600258C")]
	[Address(RVA = "0x3911A0", Offset = "0x38F9A0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailHttpSessionHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600258D")]
	[Address(RVA = "0x3916A0", Offset = "0x38FEA0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailSmallObjectServiceHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600258E")]
	[Address(RVA = "0x391B20", Offset = "0x390320", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailZoneServerHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x391120", Offset = "0x38F920", Length = "0x78")]
	[Token(Token = "0x600258F")]
	public static extern IntPtr IRailFactory_RailGroupChatHelper(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002590")]
	[Address(RVA = "0x3913A0", Offset = "0x38FBA0", Length = "0x78")]
	public static extern IntPtr IRailFactory_RailInGameStorePurchaseHelper(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3EA030", Offset = "0x3E8830", Length = "0x78")]
	[Token(Token = "0x6002591")]
	public static extern void delete_IRailFactory(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D4650", Offset = "0x3D2E50", Length = "0x14B")]
	[Token(Token = "0x6002592")]
	public static extern bool RailNeedRestartAppForCheckingEnvironment(IntPtr jarg1, int jarg2, [In] string[] jarg3);

	[PreserveSig]
	[Address(RVA = "0x3D39E0", Offset = "0x3D21E0", Length = "0x6A")]
	[Token(Token = "0x6002593")]
	public static extern bool RailInitialize();

	[PreserveSig]
	[Token(Token = "0x6002594")]
	[Address(RVA = "0x3CDD80", Offset = "0x3CC580", Length = "0x65")]
	public static extern void RailFinalize();

	[PreserveSig]
	[Token(Token = "0x6002595")]
	[Address(RVA = "0x3CDDF0", Offset = "0x3CC5F0", Length = "0x65")]
	public static extern void RailFireEvents();

	[PreserveSig]
	[Token(Token = "0x6002596")]
	[Address(RVA = "0x3CDC90", Offset = "0x3CC490", Length = "0x65")]
	public static extern IntPtr RailFactory();

	[PreserveSig]
	[Token(Token = "0x6002597")]
	[Address(RVA = "0x3D1790", Offset = "0x3CFF90", Length = "0x87")]
	public static extern void RailGetSdkVersion(IntPtr jarg1, IntPtr jarg2);

	[PreserveSig]
	[Token(Token = "0x6002598")]
	[Address(RVA = "0x384B30", Offset = "0x383330", Length = "0x8F")]
	public static extern void CSharpRailRegisterEvent(int jarg1, RailEventCallBackFunction jarg2);

	[PreserveSig]
	[Token(Token = "0x6002599")]
	[Address(RVA = "0x384C30", Offset = "0x383430", Length = "0x8F")]
	public static extern void CSharpRailUnRegisterEvent(int jarg1, RailEventCallBackFunction jarg2);

	[PreserveSig]
	[Address(RVA = "0x384BC0", Offset = "0x3833C0", Length = "0x65")]
	[Token(Token = "0x600259A")]
	public static extern void CSharpRailUnRegisterAllEvent();

	[PreserveSig]
	[Token(Token = "0x600259B")]
	[Address(RVA = "0x3A7760", Offset = "0x3A5F60", Length = "0x65")]
	public static extern IntPtr NewInt();

	[PreserveSig]
	[Token(Token = "0x600259C")]
	[Address(RVA = "0x386C40", Offset = "0x385440", Length = "0x78")]
	public static extern void DeleteInt(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600259D")]
	[Address(RVA = "0x38C950", Offset = "0x38B150", Length = "0x78")]
	public static extern int GetInt(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600259E")]
	[Address(RVA = "0x3E3240", Offset = "0x3E1A40", Length = "0x85")]
	public static extern void SetInt(IntPtr jarg1, int jarg2);

	[PreserveSig]
	[Address(RVA = "0x3A76F0", Offset = "0x3A5EF0", Length = "0x65")]
	[Token(Token = "0x600259F")]
	public static extern IntPtr NewInt64();

	[PreserveSig]
	[Address(RVA = "0x38C850", Offset = "0x38B050", Length = "0x78")]
	[Token(Token = "0x60025A0")]
	public static extern long GetInt64(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E31B0", Offset = "0x3E19B0", Length = "0x87")]
	[Token(Token = "0x60025A1")]
	public static extern void SetInt64(IntPtr jarg1, long jarg2);

	[PreserveSig]
	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x386BC0", Offset = "0x3853C0", Length = "0x78")]
	public static extern void DeleteInt64(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x38C8D0", Offset = "0x38B0D0", Length = "0x78")]
	public static extern sbyte GetInt8(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x3BE830", Offset = "0x3BD030", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsRequestAllAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7F20", Offset = "0x3C6720", Length = "0x78")]
	[Token(Token = "0x60025A5")]
	public static extern IntPtr RailEventkRailEventRoomSetRoomTypeResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x3BE6C0", Offset = "0x3BCEC0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsMergeToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB000", Offset = "0x3C9800", Length = "0x78")]
	[Token(Token = "0x60025A7")]
	public static extern IntPtr RailEventkRailEventUserSpaceSubscribeResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6C70", Offset = "0x3C5470", Length = "0x78")]
	[Token(Token = "0x60025A8")]
	public static extern IntPtr RailEventkRailEventRoomNotifyMemberChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x3C3E70", Offset = "0x3C2670", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGamePurchasePurchaseProductsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5570", Offset = "0x3C3D70", Length = "0x78")]
	[Token(Token = "0x60025AA")]
	public static extern IntPtr RailEventkRailEventPlayerGetEncryptedGameTicketResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C28E0", Offset = "0x3C10E0", Length = "0x78")]
	[Token(Token = "0x60025AB")]
	public static extern IntPtr RailEventkRailEventGameServerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7C40", Offset = "0x3C6440", Length = "0x78")]
	[Token(Token = "0x60025AC")]
	public static extern IntPtr RailEventkRailEventRoomSetRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4E40", Offset = "0x3C3640", Length = "0x78")]
	[Token(Token = "0x60025AD")]
	public static extern IntPtr RailEventkRailEventNetworkCreateRawSessionRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025AE")]
	[Address(RVA = "0x3C5120", Offset = "0x3C3920", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventNetworkCreateSessionRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE3E0", Offset = "0x3BCBE0", Length = "0x78")]
	[Token(Token = "0x60025AF")]
	public static extern IntPtr RailEventkRailEventAssetsExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025B0")]
	[Address(RVA = "0x3CDB20", Offset = "0x3CC320", Length = "0x78")]
	public static extern IntPtr RailEventkRailPlatformNotifyEventJoinGameByUser_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025B1")]
	[Address(RVA = "0x3C0210", Offset = "0x3BEA10", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcInstallProgress_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBE60", Offset = "0x3CA660", Length = "0x78")]
	[Token(Token = "0x60025B2")]
	public static extern IntPtr RailEventkRailEventUsersNotifyInviter_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025B3")]
	[Address(RVA = "0x3C1A80", Offset = "0x3C0280", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C45A0", Offset = "0x3C2DA0", Length = "0x78")]
	[Token(Token = "0x60025B4")]
	public static extern IntPtr RailEventkRailEventLeaderboardAsyncCreated_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4710", Offset = "0x3C2F10", Length = "0x78")]
	[Token(Token = "0x60025B5")]
	public static extern IntPtr RailEventkRailEventLeaderboardAttachSpaceWork_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1630", Offset = "0x3BFE30", Length = "0x78")]
	[Token(Token = "0x60025B6")]
	public static extern IntPtr RailEventkRailEventFriendsMetadataChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C66B0", Offset = "0x3C4EB0", Length = "0x78")]
	[Token(Token = "0x60025B7")]
	public static extern IntPtr RailEventkRailEventRoomGetUserRoomListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BFDC0", Offset = "0x3BE5C0", Length = "0x78")]
	[Token(Token = "0x60025B8")]
	public static extern IntPtr RailEventkRailEventBrowserTryNavigateNewPageRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025B9")]
	[Address(RVA = "0x3C0AB0", Offset = "0x3BF2B0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcUninstallFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025BA")]
	[Address(RVA = "0x3BE9A0", Offset = "0x3BD1A0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsSplitFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1910", Offset = "0x3C0110", Length = "0x78")]
	[Token(Token = "0x60025BB")]
	public static extern IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsGamesResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025BC")]
	[Address(RVA = "0x3C4B60", Offset = "0x3C3360", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventLeaderboardUploaded_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025BD")]
	[Address(RVA = "0x3CD280", Offset = "0x3CBA80", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventVoiceChannelRemoveUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8C10", Offset = "0x3C7410", Length = "0x78")]
	[Token(Token = "0x60025BE")]
	public static extern IntPtr RailEventkRailEventSmallObjectServiceQueryObjectStateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025BF")]
	[Address(RVA = "0x3CC420", Offset = "0x3CAC20", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUtilsGameSettingMetadataChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C0")]
	[Address(RVA = "0x3C2320", Offset = "0x3C0B20", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerCreated_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C1")]
	[Address(RVA = "0x3C04F0", Offset = "0x3BECF0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcInstallStart_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C2")]
	[Address(RVA = "0x3CB730", Offset = "0x3C9F30", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUsersGetInviteDetailResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C3")]
	[Address(RVA = "0x3CAA40", Offset = "0x3C9240", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceQuerySpaceWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C4")]
	[Address(RVA = "0x3BD6F0", Offset = "0x3BBEF0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAchievementGlobalAchievementReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C5")]
	[Address(RVA = "0x3C9900", Offset = "0x3C8100", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStorageAsyncRenameStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025C6")]
	[Address(RVA = "0x3C1D60", Offset = "0x3C0560", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsReportPlayedWithUserListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CCB50", Offset = "0x3CB350", Length = "0x78")]
	[Token(Token = "0x60025C7")]
	public static extern IntPtr RailEventkRailEventVoiceChannelInviteEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9BE0", Offset = "0x3C83E0", Length = "0x78")]
	[Token(Token = "0x60025C8")]
	public static extern IntPtr RailEventkRailEventStorageAsyncWriteStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6990", Offset = "0x3C5190", Length = "0x78")]
	[Token(Token = "0x60025C9")]
	public static extern IntPtr RailEventkRailEventRoomKickOffMemberResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8930", Offset = "0x3C7130", Length = "0x78")]
	[Token(Token = "0x60025CA")]
	public static extern IntPtr RailEventkRailEventShowFloatingWindow_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025CB")]
	[Address(RVA = "0x3C7510", Offset = "0x3C5D10", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomNotifyRoomOwnerChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C0C20", Offset = "0x3BF420", Length = "0x78")]
	[Token(Token = "0x60025CC")]
	public static extern IntPtr RailEventkRailEventFinalize_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025CD")]
	[Address(RVA = "0x3CB5C0", Offset = "0x3C9DC0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUsersCancelInviteResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025CE")]
	[Address(RVA = "0x3C0380", Offset = "0x3BEB80", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcInstallStartResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025CF")]
	[Address(RVA = "0x3BF3B0", Offset = "0x3BDBB0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserDamageRectPaint_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D0")]
	[Address(RVA = "0x3BEDF0", Offset = "0x3BD5F0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsUpdateAssetPropertyFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D1")]
	[Address(RVA = "0x3C63D0", Offset = "0x3C4BD0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomGetRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D2")]
	[Address(RVA = "0x3CD6D0", Offset = "0x3CBED0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventZoneServerSwitchPlayerSelectedZoneResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D3")]
	[Address(RVA = "0x3C56E0", Offset = "0x3C3EE0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventPlayerGetGamePurchaseKey_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D4")]
	[Address(RVA = "0x3CD9B0", Offset = "0x3CC1B0", Length = "0x78")]
	public static extern IntPtr RailEventkRailPlatformNotifyEventJoinGameByRoom_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D5")]
	[Address(RVA = "0x3C77F0", Offset = "0x3C5FF0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomSetMemberMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D6")]
	[Address(RVA = "0x3CA8D0", Offset = "0x3C90D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceModifyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D7")]
	[Address(RVA = "0x3CD3F0", Offset = "0x3CBBF0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventVoiceChannelSpeakingUsersChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBFD0", Offset = "0x3CA7D0", Length = "0x78")]
	[Token(Token = "0x60025D8")]
	public static extern IntPtr RailEventkRailEventUsersRespondInvitation_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025D9")]
	[Address(RVA = "0x3BE100", Offset = "0x3BC900", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsDirectConsumeFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025DA")]
	[Address(RVA = "0x3C9A70", Offset = "0x3C8270", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStorageAsyncWriteFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CA5F0", Offset = "0x3C8DF0", Length = "0x78")]
	[Token(Token = "0x60025DB")]
	public static extern IntPtr RailEventkRailEventUserSpaceGetMyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7230", Offset = "0x3C5A30", Length = "0x78")]
	[Token(Token = "0x60025DC")]
	public static extern IntPtr RailEventkRailEventRoomNotifyRoomDestroyed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x3BF800", Offset = "0x3BE000", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserPaint_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE270", Offset = "0x3BCA70", Length = "0x78")]
	[Token(Token = "0x60025DE")]
	public static extern IntPtr RailEventkRailEventAssetsExchangeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3B90", Offset = "0x3C2390", Length = "0x78")]
	[Token(Token = "0x60025DF")]
	public static extern IntPtr RailEventkRailEventInGamePurchaseAllPurchasableProductsInfoReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x3C11E0", Offset = "0x3BF9E0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsGetFriendPlayedGamesResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x3C0F00", Offset = "0x3BF700", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsClearMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CCFA0", Offset = "0x3CB7A0", Length = "0x78")]
	[Token(Token = "0x60025E2")]
	public static extern IntPtr RailEventkRailEventVoiceChannelMemberChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C0D90", Offset = "0x3BF590", Length = "0x78")]
	[Token(Token = "0x60025E3")]
	public static extern IntPtr RailEventkRailEventFriendsAddFriendResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3A20", Offset = "0x3C2220", Length = "0x78")]
	[Token(Token = "0x60025E4")]
	public static extern IntPtr RailEventkRailEventInGamePurchaseAllProductsInfoReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BE550", Offset = "0x3BCD50", Length = "0x78")]
	[Token(Token = "0x60025E5")]
	public static extern IntPtr RailEventkRailEventAssetsMergeFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6DE0", Offset = "0x3C55E0", Length = "0x78")]
	[Token(Token = "0x60025E6")]
	public static extern IntPtr RailEventkRailEventRoomNotifyMemberkicked_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6820", Offset = "0x3C5020", Length = "0x78")]
	[Token(Token = "0x60025E7")]
	public static extern IntPtr RailEventkRailEventRoomJoinRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025E8")]
	[Address(RVA = "0x3C21B0", Offset = "0x3C09B0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerAuthSessionTicket_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1BF0", Offset = "0x3C03F0", Length = "0x78")]
	[Token(Token = "0x60025E9")]
	public static extern IntPtr RailEventkRailEventFriendsQueryPlayedWithFriendsTimeResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2BC0", Offset = "0x3C13C0", Length = "0x78")]
	[Token(Token = "0x60025EA")]
	public static extern IntPtr RailEventkRailEventGameServerRegisterToServerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025EB")]
	[Address(RVA = "0x3C4430", Offset = "0x3C2C30", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGameStorePurchasePaymentResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BFF30", Offset = "0x3BE730", Length = "0x78")]
	[Token(Token = "0x60025EC")]
	public static extern IntPtr RailEventkRailEventDlcCheckAllDlcsStateReadyResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025ED")]
	[Address(RVA = "0x3C8200", Offset = "0x3C6A00", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventScreenshotTakeScreenshotFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF970", Offset = "0x3BE170", Length = "0x78")]
	[Token(Token = "0x60025EE")]
	public static extern IntPtr RailEventkRailEventBrowserReloadResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025EF")]
	[Address(RVA = "0x3C87C0", Offset = "0x3C6FC0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventShowFloatingNotifyWindow_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025F0")]
	[Address(RVA = "0x3C3FE0", Offset = "0x3C27E0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGamePurchasePurchaseProductsToAssetsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C38B0", Offset = "0x3C20B0", Length = "0x78")]
	[Token(Token = "0x60025F1")]
	public static extern IntPtr RailEventkRailEventInGameCoinRequestCoinInfoResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025F2")]
	[Address(RVA = "0x3C7AD0", Offset = "0x3C62D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomSetRoomMaxMemberResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025F3")]
	[Address(RVA = "0x3CC2B0", Offset = "0x3CAAB0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUsersShowUserHomepageWindowResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C42C0", Offset = "0x3C2AC0", Length = "0x78")]
	[Token(Token = "0x60025F4")]
	public static extern IntPtr RailEventkRailEventInGameStorePurchasePayWindowDisplayed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025F5")]
	[Address(RVA = "0x3BF0D0", Offset = "0x3BD8D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserCloseResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C35D0", Offset = "0x3C1DD0", Length = "0x78")]
	[Token(Token = "0x60025F6")]
	public static extern IntPtr RailEventkRailEventIMEHelperTextInputSelectedResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3180", Offset = "0x3C1980", Length = "0x78")]
	[Token(Token = "0x60025F7")]
	public static extern IntPtr RailEventkRailEventGroupChatQueryGroupsInfoResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CA1A0", Offset = "0x3C89A0", Length = "0x78")]
	[Token(Token = "0x60025F8")]
	public static extern IntPtr RailEventkRailEventTextInputShowTextInputWindowResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2EA0", Offset = "0x3C16A0", Length = "0x78")]
	[Token(Token = "0x60025F9")]
	public static extern IntPtr RailEventkRailEventGameServerSetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CA310", Offset = "0x3C8B10", Length = "0x78")]
	[Token(Token = "0x60025FA")]
	public static extern IntPtr RailEventkRailEventUserSpaceDownloadProgress_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBCF0", Offset = "0x3CA4F0", Length = "0x78")]
	[Token(Token = "0x60025FB")]
	public static extern IntPtr RailEventkRailEventUsersInviteUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025FC")]
	[Address(RVA = "0x3C17A0", Offset = "0x3BFFA0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsOnlineStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB2E0", Offset = "0x3C9AE0", Length = "0x78")]
	[Token(Token = "0x60025FD")]
	public static extern IntPtr RailEventkRailEventUserSpaceUpdateMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025FE")]
	[Address(RVA = "0x3BEF60", Offset = "0x3BD760", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAssetsUpdateConsumeFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60025FF")]
	[Address(RVA = "0x3C6260", Offset = "0x3C4A60", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomGetRoomMembersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002600")]
	[Address(RVA = "0x3C5850", Offset = "0x3C4050", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventPlayerGetPlayerMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002601")]
	[Address(RVA = "0x3CCCC0", Offset = "0x3CB4C0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventVoiceChannelJoinedResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002602")]
	[Address(RVA = "0x3C3D00", Offset = "0x3C2500", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGamePurchaseFinishOrderResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BEC80", Offset = "0x3BD480", Length = "0x78")]
	[Token(Token = "0x6002603")]
	public static extern IntPtr RailEventkRailEventAssetsStartConsumeFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002604")]
	[Address(RVA = "0x3C2490", Offset = "0x3C0C90", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerFavoriteGameServers_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BF520", Offset = "0x3BDD20", Length = "0x78")]
	[Token(Token = "0x6002605")]
	public static extern IntPtr RailEventkRailEventBrowserJavascriptEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002606")]
	[Address(RVA = "0x3BD860", Offset = "0x3BC060", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAchievementPlayerAchievementReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6B00", Offset = "0x3C5300", Length = "0x78")]
	[Token(Token = "0x6002607")]
	public static extern IntPtr RailEventkRailEventRoomLeaveRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5CA0", Offset = "0x3C44A0", Length = "0x78")]
	[Token(Token = "0x6002608")]
	public static extern IntPtr RailEventkRailEventRoomCreated_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9D50", Offset = "0x3C8550", Length = "0x78")]
	[Token(Token = "0x6002609")]
	public static extern IntPtr RailEventkRailEventStorageQueryQuotaResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C0660", Offset = "0x3BEE60", Length = "0x78")]
	[Token(Token = "0x600260A")]
	public static extern IntPtr RailEventkRailEventDlcOwnershipChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600260B")]
	[Address(RVA = "0x3BF690", Offset = "0x3BDE90", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserNavigeteResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C1350", Offset = "0x3BFB50", Length = "0x78")]
	[Token(Token = "0x600260C")]
	public static extern IntPtr RailEventkRailEventFriendsGetInviteCommandLine_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600260D")]
	[Address(RVA = "0x3CD560", Offset = "0x3CBD60", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventVoiceChannelUsersSpeakingStateChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600260E")]
	[Address(RVA = "0x3C8EF0", Offset = "0x3C76F0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStatsNumOfPlayerReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600260F")]
	[Address(RVA = "0x3CB450", Offset = "0x3C9C50", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceVoteSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002610")]
	[Address(RVA = "0x3C00A0", Offset = "0x3BE8A0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcInstallFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002611")]
	[Address(RVA = "0x3C8D80", Offset = "0x3C7580", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStatsGlobalStatsReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CAE90", Offset = "0x3C9690", Length = "0x78")]
	[Token(Token = "0x6002612")]
	public static extern IntPtr RailEventkRailEventUserSpaceSearchSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC870", Offset = "0x3CB070", Length = "0x78")]
	[Token(Token = "0x6002613")]
	public static extern IntPtr RailEventkRailEventVoiceChannelCreateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDE20", Offset = "0x3BC620", Length = "0x78")]
	[Token(Token = "0x6002614")]
	public static extern IntPtr RailEventkRailEventAssetsCompleteConsumeByExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002615")]
	[Address(RVA = "0x3CABB0", Offset = "0x3C93B0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceRateSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5F80", Offset = "0x3C4780", Length = "0x78")]
	[Token(Token = "0x6002616")]
	public static extern IntPtr RailEventkRailEventRoomGetMemberMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C14C0", Offset = "0x3BFCC0", Length = "0x78")]
	[Token(Token = "0x6002617")]
	public static extern IntPtr RailEventkRailEventFriendsGetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CD110", Offset = "0x3CB910", Length = "0x78")]
	[Token(Token = "0x6002618")]
	public static extern IntPtr RailEventkRailEventVoiceChannelPushToTalkKeyChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9060", Offset = "0x3C7860", Length = "0x78")]
	[Token(Token = "0x6002619")]
	public static extern IntPtr RailEventkRailEventStatsPlayerStatsReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDF90", Offset = "0x3BC790", Length = "0x78")]
	[Token(Token = "0x600261A")]
	public static extern IntPtr RailEventkRailEventAssetsCompleteConsumeFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2600", Offset = "0x3C0E00", Length = "0x78")]
	[Token(Token = "0x600261B")]
	public static extern IntPtr RailEventkRailEventGameServerGetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5400", Offset = "0x3C3C00", Length = "0x78")]
	[Token(Token = "0x600261C")]
	public static extern IntPtr RailEventkRailEventPlayerGetAuthenticateURL_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CCE30", Offset = "0x3CB630", Length = "0x78")]
	[Token(Token = "0x600261D")]
	public static extern IntPtr RailEventkRailEventVoiceChannelLeaveResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600261E")]
	[Address(RVA = "0x3C6F50", Offset = "0x3C5750", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomNotifyMetadataChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600261F")]
	[Address(RVA = "0x3BD9D0", Offset = "0x3BC1D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventAchievementPlayerAchievementStored_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002620")]
	[Address(RVA = "0x3C4150", Offset = "0x3C2950", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGameStorePurchasePayWindowClosed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002621")]
	[Address(RVA = "0x3C7680", Offset = "0x3C5E80", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomOpenRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC9E0", Offset = "0x3CB1E0", Length = "0x78")]
	[Token(Token = "0x6002622")]
	public static extern IntPtr RailEventkRailEventVoiceChannelDataCaptured_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002623")]
	[Address(RVA = "0x3C5290", Offset = "0x3C3A90", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventPlayerAntiAddictionGameOnlineTimeChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002624")]
	[Address(RVA = "0x3C7DB0", Offset = "0x3C65B0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomSetRoomTagResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C60F0", Offset = "0x3C48F0", Length = "0x78")]
	[Token(Token = "0x6002625")]
	public static extern IntPtr RailEventkRailEventRoomGetRoomListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C7960", Offset = "0x3C6160", Length = "0x78")]
	[Token(Token = "0x6002626")]
	public static extern IntPtr RailEventkRailEventRoomSetNewRoomOwnerResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9790", Offset = "0x3C7F90", Length = "0x78")]
	[Token(Token = "0x6002627")]
	public static extern IntPtr RailEventkRailEventStorageAsyncReadStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BFC50", Offset = "0x3BE450", Length = "0x78")]
	[Token(Token = "0x6002628")]
	public static extern IntPtr RailEventkRailEventBrowserTitleChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CC140", Offset = "0x3CA940", Length = "0x78")]
	[Token(Token = "0x6002629")]
	public static extern IntPtr RailEventkRailEventUsersShowChatWindowWithFriendResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600262A")]
	[Address(RVA = "0x3CA760", Offset = "0x3C8F60", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceGetMySubscribedWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9EC0", Offset = "0x3C86C0", Length = "0x78")]
	[Token(Token = "0x600262B")]
	public static extern IntPtr RailEventkRailEventStorageShareToSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600262C")]
	[Address(RVA = "0x3C1070", Offset = "0x3BF870", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsFriendsListChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600262D")]
	[Address(RVA = "0x3CC590", Offset = "0x3CAD90", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUtilsGetImageDataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600262E")]
	[Address(RVA = "0x3CB8A0", Offset = "0x3CA0A0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUsersGetUserLimitsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600262F")]
	[Address(RVA = "0x3CA030", Offset = "0x3C8830", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventSystemStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002630")]
	[Address(RVA = "0x3C49F0", Offset = "0x3C31F0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventLeaderboardReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002631")]
	[Address(RVA = "0x3C32F0", Offset = "0x3C1AF0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventHttpSessionResponseResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002632")]
	[Address(RVA = "0x3CA480", Offset = "0x3C8C80", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUserSpaceDownloadResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C5B30", Offset = "0x3C4330", Length = "0x78")]
	[Token(Token = "0x6002633")]
	public static extern IntPtr RailEventkRailEventRoomClearRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002634")]
	[Address(RVA = "0x3C8AA0", Offset = "0x3C72A0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventSmallObjectServiceDownloadResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002635")]
	[Address(RVA = "0x3C5E10", Offset = "0x3C4610", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomGetAllDataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C94B0", Offset = "0x3C7CB0", Length = "0x78")]
	[Token(Token = "0x6002636")]
	public static extern IntPtr RailEventkRailEventStorageAsyncListStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002637")]
	[Address(RVA = "0x3C3010", Offset = "0x3C1810", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGroupChatOpenGroupChatResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002638")]
	[Address(RVA = "0x3C4880", Offset = "0x3C3080", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventLeaderboardEntryReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002639")]
	[Address(RVA = "0x3C73A0", Offset = "0x3C5BA0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomNotifyRoomGameServerChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600263A")]
	[Address(RVA = "0x3C70C0", Offset = "0x3C58C0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventRoomNotifyRoomDataReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600263B")]
	[Address(RVA = "0x3C07D0", Offset = "0x3BEFD0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventDlcQueryIsOwnedDlcsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CB170", Offset = "0x3C9970", Length = "0x78")]
	[Token(Token = "0x600263C")]
	public static extern IntPtr RailEventkRailEventUserSpaceSyncResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDCB0", Offset = "0x3BC4B0", Length = "0x78")]
	[Token(Token = "0x600263D")]
	public static extern IntPtr RailEventkRailEventAssetsAssetsChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C3460", Offset = "0x3C1C60", Length = "0x78")]
	[Token(Token = "0x600263E")]
	public static extern IntPtr RailEventkRailEventIMEHelperTextInputCompositionStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C0940", Offset = "0x3BF140", Length = "0x78")]
	[Token(Token = "0x600263F")]
	public static extern IntPtr RailEventkRailEventDlcRefundChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002640")]
	[Address(RVA = "0x3C2A50", Offset = "0x3C1250", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerPlayerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CBA10", Offset = "0x3CA210", Length = "0x78")]
	[Token(Token = "0x6002641")]
	public static extern IntPtr RailEventkRailEventUsersGetUsersInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C9340", Offset = "0x3C7B40", Length = "0x78")]
	[Token(Token = "0x6002642")]
	public static extern IntPtr RailEventkRailEventStorageAsyncDeleteStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002643")]
	[Address(RVA = "0x3C1ED0", Offset = "0x3C06D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventFriendsSetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002644")]
	[Address(RVA = "0x3BF240", Offset = "0x3BDA40", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserCreateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BEB10", Offset = "0x3BD310", Length = "0x78")]
	[Token(Token = "0x6002645")]
	public static extern IntPtr RailEventkRailEventAssetsSplitToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002646")]
	[Address(RVA = "0x3C8090", Offset = "0x3C6890", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventScreenshotPublishScreenshotFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002647")]
	[Address(RVA = "0x3CC700", Offset = "0x3CAF00", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventVoiceChannelAddUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C2040", Offset = "0x3C0840", Length = "0x78")]
	[Token(Token = "0x6002648")]
	public static extern IntPtr RailEventkRailEventGameServerAddFavoriteGameServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002649")]
	[Address(RVA = "0x3C8650", Offset = "0x3C6E50", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventSessionTicketGetSessionTicket_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600264A")]
	[Address(RVA = "0x3C2D30", Offset = "0x3C1530", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerRemoveFavoriteGameServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C6540", Offset = "0x3C4D40", Length = "0x78")]
	[Token(Token = "0x600264B")]
	public static extern IntPtr RailEventkRailEventRoomGetRoomTagResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600264C")]
	[Address(RVA = "0x3C91D0", Offset = "0x3C79D0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStatsPlayerStatsStored_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600264D")]
	[Address(RVA = "0x3C9620", Offset = "0x3C7E20", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventStorageAsyncReadFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600264E")]
	[Address(RVA = "0x3C84E0", Offset = "0x3C6CE0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventSessionTicketAuthSessionTicket_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C8370", Offset = "0x3C6B70", Length = "0x78")]
	[Token(Token = "0x600264F")]
	public static extern IntPtr RailEventkRailEventScreenshotTakeScreenshotRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CAD20", Offset = "0x3C9520", Length = "0x78")]
	[Token(Token = "0x6002650")]
	public static extern IntPtr RailEventkRailEventUserSpaceRemoveSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002651")]
	[Address(RVA = "0x3BFAE0", Offset = "0x3BE2E0", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventBrowserStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002652")]
	[Address(RVA = "0x3C2770", Offset = "0x3C0F70", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventGameServerGetSessionTicket_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002653")]
	[Address(RVA = "0x3CBB80", Offset = "0x3CA380", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventUsersInviteJoinGameResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4CD0", Offset = "0x3C34D0", Length = "0x78")]
	[Token(Token = "0x6002654")]
	public static extern IntPtr RailEventkRailEventNetworkCreateRawSessionFailed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002655")]
	[Address(RVA = "0x3C3740", Offset = "0x3C1F40", Length = "0x78")]
	public static extern IntPtr RailEventkRailEventInGameCoinPurchaseCoinsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3BDB40", Offset = "0x3BC340", Length = "0x78")]
	[Token(Token = "0x6002656")]
	public static extern IntPtr RailEventkRailEventAppQuerySubscribeWishPlayStateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C4FB0", Offset = "0x3C37B0", Length = "0x78")]
	[Token(Token = "0x6002657")]
	public static extern IntPtr RailEventkRailEventNetworkCreateSessionFailed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3C59C0", Offset = "0x3C41C0", Length = "0x78")]
	[Token(Token = "0x6002658")]
	public static extern IntPtr RailEventkRailEventQueryPlayerBannedStatus_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002659")]
	[Address(RVA = "0x3CD840", Offset = "0x3CC040", Length = "0x78")]
	public static extern IntPtr RailEventkRailPlatformNotifyEventJoinGameByGameServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37F580", Offset = "0x37DD80", Length = "0x78")]
	[Token(Token = "0x600265A")]
	public static extern IntPtr AsyncGetMySubscribedWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600265B")]
	[Address(RVA = "0x37F2E0", Offset = "0x37DAE0", Length = "0x78")]
	public static extern IntPtr AsyncGetMyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600265C")]
	[Address(RVA = "0x380330", Offset = "0x37EB30", Length = "0x78")]
	public static extern IntPtr AsyncQuerySpaceWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381D50", Offset = "0x380550", Length = "0x78")]
	[Token(Token = "0x600265D")]
	public static extern IntPtr AsyncUpdateMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600265E")]
	[Address(RVA = "0x3E4D00", Offset = "0x3E3500", Length = "0x78")]
	public static extern IntPtr SyncSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3819A0", Offset = "0x3801A0", Length = "0x78")]
	[Token(Token = "0x600265F")]
	public static extern IntPtr AsyncSubscribeSpaceWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002660")]
	[Address(RVA = "0x37FCE0", Offset = "0x37E4E0", Length = "0x78")]
	public static extern IntPtr AsyncModifyFavoritesWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002661")]
	[Address(RVA = "0x3812B0", Offset = "0x37FAB0", Length = "0x78")]
	public static extern IntPtr AsyncRemoveSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381FF0", Offset = "0x3807F0", Length = "0x78")]
	[Token(Token = "0x6002662")]
	public static extern IntPtr AsyncVoteSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3805D0", Offset = "0x37EDD0", Length = "0x78")]
	[Token(Token = "0x6002663")]
	public static extern IntPtr AsyncRateSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002664")]
	[Address(RVA = "0x381700", Offset = "0x37FF00", Length = "0x78")]
	public static extern IntPtr AsyncSearchSpaceWorksResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5920", Offset = "0x3E4120", Length = "0x78")]
	[Token(Token = "0x6002665")]
	public static extern IntPtr UserSpaceDownloadProgress_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5BC0", Offset = "0x3E43C0", Length = "0x78")]
	[Token(Token = "0x6002666")]
	public static extern IntPtr UserSpaceDownloadResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002667")]
	[Address(RVA = "0x3DE0A0", Offset = "0x3DC8A0", Length = "0x78")]
	public static extern IntPtr RailUsersInfoData_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002668")]
	[Address(RVA = "0x3DE770", Offset = "0x3DCF70", Length = "0x78")]
	public static extern IntPtr RailUsersNotifyInviter_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002669")]
	[Address(RVA = "0x3DE900", Offset = "0x3DD100", Length = "0x78")]
	public static extern IntPtr RailUsersRespondInvitation_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600266A")]
	[Address(RVA = "0x3DE230", Offset = "0x3DCA30", Length = "0x78")]
	public static extern IntPtr RailUsersInviteJoinGameResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600266B")]
	[Address(RVA = "0x3DDA40", Offset = "0x3DC240", Length = "0x78")]
	public static extern IntPtr RailUsersGetInviteDetailResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DD8B0", Offset = "0x3DC0B0", Length = "0x78")]
	[Token(Token = "0x600266C")]
	public static extern IntPtr RailUsersCancelInviteResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DE5E0", Offset = "0x3DCDE0", Length = "0x78")]
	[Token(Token = "0x600266D")]
	public static extern IntPtr RailUsersInviteUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600266E")]
	[Address(RVA = "0x3DDE00", Offset = "0x3DC600", Length = "0x78")]
	public static extern IntPtr RailUsersGetUserLimitsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7F20", Offset = "0x3D6720", Length = "0x78")]
	[Token(Token = "0x600266F")]
	public static extern IntPtr RailShowChatWindowWithFriendResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D80B0", Offset = "0x3D68B0", Length = "0x78")]
	[Token(Token = "0x6002670")]
	public static extern IntPtr RailShowUserHomepageWindowResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002671")]
	[Address(RVA = "0x3D1360", Offset = "0x3CFB60", Length = "0x78")]
	public static extern IntPtr RailGetImageDataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002672")]
	[Address(RVA = "0x3D08A0", Offset = "0x3CF0A0", Length = "0x78")]
	public static extern IntPtr RailGameSettingMetadataChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002673")]
	[Address(RVA = "0x3E4E90", Offset = "0x3E3690", Length = "0x78")]
	public static extern IntPtr TakeScreenshotResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002674")]
	[Address(RVA = "0x3E2FA0", Offset = "0x3E17A0", Length = "0x78")]
	public static extern IntPtr ScreenshotRequestInfo_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA0A0", Offset = "0x3A88A0", Length = "0x78")]
	[Token(Token = "0x6002675")]
	public static extern IntPtr PublishScreenshotResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002676")]
	[Address(RVA = "0x3DBAA0", Offset = "0x3DA2A0", Length = "0x78")]
	public static extern IntPtr RailSystemStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D50A0", Offset = "0x3D38A0", Length = "0x78")]
	[Token(Token = "0x6002677")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByGameServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002678")]
	[Address(RVA = "0x3D5350", Offset = "0x3D3B50", Length = "0x78")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByRoom_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002679")]
	[Address(RVA = "0x3D5600", Offset = "0x3D3E00", Length = "0x78")]
	public static extern IntPtr RailPlatformNotifyEventJoinGameByUser_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CDD00", Offset = "0x3CC500", Length = "0x78")]
	[Token(Token = "0x600267A")]
	public static extern IntPtr RailFinalize_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3DFD10", Offset = "0x3DE510", Length = "0x78")]
	[Token(Token = "0x600267B")]
	public static extern IntPtr RequestAllAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600267C")]
	[Address(RVA = "0x3E53E0", Offset = "0x3E3BE0", Length = "0x78")]
	public static extern IntPtr UpdateAssetsPropertyFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x386CC0", Offset = "0x3854C0", Length = "0x78")]
	[Token(Token = "0x600267D")]
	public static extern IntPtr DirectConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E49E0", Offset = "0x3E31E0", Length = "0x78")]
	[Token(Token = "0x600267E")]
	public static extern IntPtr StartConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600267F")]
	[Address(RVA = "0x3E5570", Offset = "0x3E3D70", Length = "0x78")]
	public static extern IntPtr UpdateConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002680")]
	[Address(RVA = "0x384F50", Offset = "0x383750", Length = "0x78")]
	public static extern IntPtr CompleteConsumeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E4280", Offset = "0x3E2A80", Length = "0x78")]
	[Token(Token = "0x6002681")]
	public static extern IntPtr SplitAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002682")]
	[Address(RVA = "0x3E4630", Offset = "0x3E2E30", Length = "0x78")]
	public static extern IntPtr SplitAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A6C70", Offset = "0x3A5470", Length = "0x78")]
	[Token(Token = "0x6002683")]
	public static extern IntPtr MergeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A6F10", Offset = "0x3A5710", Length = "0x78")]
	[Token(Token = "0x6002684")]
	public static extern IntPtr MergeAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002685")]
	[Address(RVA = "0x3850E0", Offset = "0x3838E0", Length = "0x78")]
	public static extern IntPtr CompleteConsumeByExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002686")]
	[Address(RVA = "0x388470", Offset = "0x386C70", Length = "0x78")]
	public static extern IntPtr ExchangeAssetsFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x388710", Offset = "0x386F10", Length = "0x78")]
	[Token(Token = "0x6002687")]
	public static extern IntPtr ExchangeAssetsToFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002688")]
	[Address(RVA = "0x3BA920", Offset = "0x3B9120", Length = "0x78")]
	public static extern IntPtr RailAssetsChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002689")]
	[Address(RVA = "0x3858D0", Offset = "0x3840D0", Length = "0x78")]
	public static extern IntPtr CreateBrowserResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600268A")]
	[Address(RVA = "0x3DFC90", Offset = "0x3DE490", Length = "0x78")]
	public static extern IntPtr ReloadBrowserResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x384ED0", Offset = "0x3836D0", Length = "0x78")]
	[Token(Token = "0x600268B")]
	public static extern IntPtr CloseBrowserResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A4790", Offset = "0x3A2F90", Length = "0x78")]
	[Token(Token = "0x600268C")]
	public static extern IntPtr JavascriptEventResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x383870", Offset = "0x382070", Length = "0x78")]
	[Token(Token = "0x600268D")]
	public static extern IntPtr BrowserNeedsPaintRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x382B20", Offset = "0x381320", Length = "0x78")]
	[Token(Token = "0x600268E")]
	public static extern IntPtr BrowserDamageRectNeedsPaintRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x384180", Offset = "0x382980", Length = "0x78")]
	[Token(Token = "0x600268F")]
	public static extern IntPtr BrowserRenderNavigateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002690")]
	[Address(RVA = "0x384320", Offset = "0x382B20", Length = "0x78")]
	public static extern IntPtr BrowserRenderStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002691")]
	[Address(RVA = "0x3845C0", Offset = "0x382DC0", Length = "0x78")]
	public static extern IntPtr BrowserRenderTitleChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x384760", Offset = "0x382F60", Length = "0x78")]
	[Token(Token = "0x6002692")]
	public static extern IntPtr BrowserTryNavigateNewPageRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002693")]
	[Address(RVA = "0x387630", Offset = "0x385E30", Length = "0x78")]
	public static extern IntPtr DlcInstallStart_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002694")]
	[Address(RVA = "0x387390", Offset = "0x385B90", Length = "0x78")]
	public static extern IntPtr DlcInstallStartResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002695")]
	[Address(RVA = "0x3870F0", Offset = "0x3858F0", Length = "0x78")]
	public static extern IntPtr DlcInstallProgress_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002696")]
	[Address(RVA = "0x386E50", Offset = "0x385650", Length = "0x78")]
	public static extern IntPtr DlcInstallFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002697")]
	[Address(RVA = "0x387D00", Offset = "0x386500", Length = "0x78")]
	public static extern IntPtr DlcUninstallFinished_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002698")]
	[Address(RVA = "0x384CC0", Offset = "0x3834C0", Length = "0x78")]
	public static extern IntPtr CheckAllDlcsStateReadyResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002699")]
	[Address(RVA = "0x3AA230", Offset = "0x3A8A30", Length = "0x78")]
	public static extern IntPtr QueryIsOwnedDlcsResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600269A")]
	[Address(RVA = "0x3877C0", Offset = "0x385FC0", Length = "0x78")]
	public static extern IntPtr DlcOwnershipChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600269B")]
	[Address(RVA = "0x387A60", Offset = "0x386260", Length = "0x78")]
	public static extern IntPtr DlcRefundChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600269C")]
	[Address(RVA = "0x3E3BA0", Offset = "0x3E23A0", Length = "0x78")]
	public static extern IntPtr ShowFloatingWindowResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600269D")]
	[Address(RVA = "0x3E3E40", Offset = "0x3E2640", Length = "0x78")]
	public static extern IntPtr ShowNotifyWindow_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37EC90", Offset = "0x37D490", Length = "0x78")]
	[Token(Token = "0x600269E")]
	public static extern IntPtr AsyncAcquireGameServerSessionTicketResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600269F")]
	[Address(RVA = "0x38B760", Offset = "0x389F60", Length = "0x78")]
	public static extern IntPtr GameServerStartSessionWithPlayerResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3860C0", Offset = "0x3848C0", Length = "0x78")]
	[Token(Token = "0x60026A0")]
	public static extern IntPtr CreateGameServerResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E3020", Offset = "0x3E1820", Length = "0x78")]
	[Token(Token = "0x60026A1")]
	public static extern IntPtr SetGameServerMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38C310", Offset = "0x38AB10", Length = "0x78")]
	[Token(Token = "0x60026A2")]
	public static extern IntPtr GetGameServerMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026A3")]
	[Address(RVA = "0x38B6E0", Offset = "0x389EE0", Length = "0x78")]
	public static extern IntPtr GameServerRegisterToServerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38C5B0", Offset = "0x38ADB0", Length = "0x78")]
	[Token(Token = "0x60026A4")]
	public static extern IntPtr GetGameServerPlayerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38BE50", Offset = "0x38A650", Length = "0x78")]
	[Token(Token = "0x60026A5")]
	public static extern IntPtr GetGameServerListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37F150", Offset = "0x37D950", Length = "0x78")]
	[Token(Token = "0x60026A6")]
	public static extern IntPtr AsyncGetFavoriteGameServersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026A7")]
	[Address(RVA = "0x37EE20", Offset = "0x37D620", Length = "0x78")]
	public static extern IntPtr AsyncAddFavoriteGameServerResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026A8")]
	[Address(RVA = "0x381120", Offset = "0x37F920", Length = "0x78")]
	public static extern IntPtr AsyncRemoveFavoriteGameServerResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026A9")]
	[Address(RVA = "0x37EB00", Offset = "0x37D300", Length = "0x78")]
	public static extern IntPtr AcquireSessionTicketResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026AA")]
	[Address(RVA = "0x3E4B70", Offset = "0x3E3370", Length = "0x78")]
	public static extern IntPtr StartSessionWithPlayerResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9770", Offset = "0x3A7F70", Length = "0x78")]
	[Token(Token = "0x60026AB")]
	public static extern IntPtr PlayerGetGamePurchaseKeyResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA6F0", Offset = "0x3A8EF0", Length = "0x78")]
	[Token(Token = "0x60026AC")]
	public static extern IntPtr QueryPlayerBannedStatus_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38BA80", Offset = "0x38A280", Length = "0x78")]
	[Token(Token = "0x60026AD")]
	public static extern IntPtr GetAuthenticateURLResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026AE")]
	[Address(RVA = "0x3AAA80", Offset = "0x3A9280", Length = "0x78")]
	public static extern IntPtr RailAntiAddictionGameOnlineTimeChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D11C0", Offset = "0x3CF9C0", Length = "0x78")]
	[Token(Token = "0x60026AF")]
	public static extern IntPtr RailGetEncryptedGameTicketResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B0")]
	[Address(RVA = "0x3D1600", Offset = "0x3CFE00", Length = "0x78")]
	public static extern IntPtr RailGetPlayerMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B1")]
	[Address(RVA = "0x3D0120", Offset = "0x3CE920", Length = "0x78")]
	public static extern IntPtr RailFriendsSetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B2")]
	[Address(RVA = "0x3CF420", Offset = "0x3CDC20", Length = "0x78")]
	public static extern IntPtr RailFriendsGetMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B3")]
	[Address(RVA = "0x3CF0F0", Offset = "0x3CD8F0", Length = "0x78")]
	public static extern IntPtr RailFriendsClearMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B4")]
	[Address(RVA = "0x3CF170", Offset = "0x3CD970", Length = "0x78")]
	public static extern IntPtr RailFriendsGetInviteCommandLine_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B5")]
	[Address(RVA = "0x3D00A0", Offset = "0x3CE8A0", Length = "0x78")]
	public static extern IntPtr RailFriendsReportPlayedWithUserListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B6")]
	[Address(RVA = "0x3CF6C0", Offset = "0x3CDEC0", Length = "0x78")]
	public static extern IntPtr RailFriendsListChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026B7")]
	[Address(RVA = "0x3CFA60", Offset = "0x3CE260", Length = "0x78")]
	public static extern IntPtr RailFriendsQueryFriendPlayedGamesResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CFD80", Offset = "0x3CE580", Length = "0x78")]
	[Token(Token = "0x60026B8")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CFF10", Offset = "0x3CE710", Length = "0x78")]
	[Token(Token = "0x60026B9")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsTimeResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CFBF0", Offset = "0x3CE3F0", Length = "0x78")]
	[Token(Token = "0x60026BA")]
	public static extern IntPtr RailFriendsQueryPlayedWithFriendsGamesResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3CEF60", Offset = "0x3CD760", Length = "0x78")]
	[Token(Token = "0x60026BB")]
	public static extern IntPtr RailFriendsAddFriendResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x3CF8D0", Offset = "0x3CE0D0", Length = "0x78")]
	public static extern IntPtr RailFriendsOnlineStateChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x3CF740", Offset = "0x3CDF40", Length = "0x78")]
	public static extern IntPtr RailFriendsMetadataChanged_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D2950", Offset = "0x3D1150", Length = "0x78")]
	[Token(Token = "0x60026BE")]
	public static extern IntPtr RailInGameCoinRequestCoinInfoResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D28D0", Offset = "0x3D10D0", Length = "0x78")]
	[Token(Token = "0x60026BF")]
	public static extern IntPtr RailInGameCoinPurchaseCoinsResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026C0")]
	[Address(RVA = "0x3D3370", Offset = "0x3D1B70", Length = "0x78")]
	public static extern IntPtr RailInGamePurchaseRequestAllPurchasableProductsResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D31E0", Offset = "0x3D19E0", Length = "0x78")]
	[Token(Token = "0x60026C1")]
	public static extern IntPtr RailInGamePurchaseRequestAllProductsResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x3D2C80", Offset = "0x3D1480", Length = "0x78")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026C3")]
	[Address(RVA = "0x3D2F30", Offset = "0x3D1730", Length = "0x78")]
	public static extern IntPtr RailInGamePurchasePurchaseProductsToAssetsResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026C4")]
	[Address(RVA = "0x3D2AE0", Offset = "0x3D12E0", Length = "0x78")]
	public static extern IntPtr RailInGamePurchaseFinishOrderResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D36A0", Offset = "0x3D1EA0", Length = "0x78")]
	[Token(Token = "0x60026C5")]
	public static extern IntPtr RailInGameStorePurchasePayWindowDisplayed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3500", Offset = "0x3D1D00", Length = "0x78")]
	[Token(Token = "0x60026C6")]
	public static extern IntPtr RailInGameStorePurchasePayWindowClosed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D3840", Offset = "0x3D2040", Length = "0x78")]
	[Token(Token = "0x60026C7")]
	public static extern IntPtr RailInGameStorePurchaseResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x386680", Offset = "0x384E80", Length = "0x78")]
	[Token(Token = "0x60026C8")]
	public static extern IntPtr CreateSessionRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026C9")]
	[Address(RVA = "0x3863E0", Offset = "0x384BE0", Length = "0x78")]
	public static extern IntPtr CreateSessionFailed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026CA")]
	[Address(RVA = "0x3A7450", Offset = "0x3A5C50", Length = "0x78")]
	public static extern IntPtr NetworkCreateRawSessionRequest_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A71B0", Offset = "0x3A59B0", Length = "0x78")]
	[Token(Token = "0x60026CB")]
	public static extern IntPtr NetworkCreateRawSessionFailed_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026CC")]
	[Address(RVA = "0x386250", Offset = "0x384A50", Length = "0x78")]
	public static extern IntPtr CreateRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026CD")]
	[Address(RVA = "0x3A9090", Offset = "0x3A7890", Length = "0x78")]
	public static extern IntPtr OpenRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026CE")]
	[Address(RVA = "0x38CD80", Offset = "0x38B580", Length = "0x78")]
	public static extern IntPtr GetRoomListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026CF")]
	[Address(RVA = "0x38DA30", Offset = "0x38C230", Length = "0x78")]
	public static extern IntPtr GetUserRoomListResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E3570", Offset = "0x3E1D70", Length = "0x78")]
	[Token(Token = "0x60026D0")]
	public static extern IntPtr SetNewRoomOwnerResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x38D240", Offset = "0x38BA40", Length = "0x78")]
	[Token(Token = "0x60026D1")]
	public static extern IntPtr GetRoomMembersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A6730", Offset = "0x3A4F30", Length = "0x78")]
	[Token(Token = "0x60026D2")]
	public static extern IntPtr LeaveRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D3")]
	[Address(RVA = "0x3A4A50", Offset = "0x3A3250", Length = "0x78")]
	public static extern IntPtr JoinRoomResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D4")]
	[Address(RVA = "0x38B8F0", Offset = "0x38A0F0", Length = "0x78")]
	public static extern IntPtr GetAllRoomDataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D5")]
	[Address(RVA = "0x3A4E80", Offset = "0x3A3680", Length = "0x78")]
	public static extern IntPtr KickOffMemberResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E3800", Offset = "0x3E2000", Length = "0x78")]
	[Token(Token = "0x60026D6")]
	public static extern IntPtr SetRoomTagResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D7")]
	[Address(RVA = "0x38D890", Offset = "0x38C090", Length = "0x78")]
	public static extern IntPtr GetRoomTagResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D8")]
	[Address(RVA = "0x3E3670", Offset = "0x3E1E70", Length = "0x78")]
	public static extern IntPtr SetRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026D9")]
	[Address(RVA = "0x38D5F0", Offset = "0x38BDF0", Length = "0x78")]
	public static extern IntPtr GetRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026DA")]
	[Address(RVA = "0x384D40", Offset = "0x383540", Length = "0x78")]
	public static extern IntPtr ClearRoomMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026DB")]
	[Address(RVA = "0x3E32D0", Offset = "0x3E1AD0", Length = "0x78")]
	public static extern IntPtr SetMemberMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026DC")]
	[Address(RVA = "0x38C9D0", Offset = "0x38B1D0", Length = "0x78")]
	public static extern IntPtr GetMemberMetadataResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026DD")]
	[Address(RVA = "0x3E02E0", Offset = "0x3DEAE0", Length = "0x78")]
	public static extern IntPtr RoomDataReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E3880", Offset = "0x3E2080", Length = "0x78")]
	[Token(Token = "0x60026DE")]
	public static extern IntPtr SetRoomTypeResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E35F0", Offset = "0x3E1DF0", Length = "0x78")]
	[Token(Token = "0x60026DF")]
	public static extern IntPtr SetRoomMaxMemberResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E0")]
	[Address(RVA = "0x3A77D0", Offset = "0x3A5FD0", Length = "0x78")]
	public static extern IntPtr NotifyMetadataChange_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A7FB0", Offset = "0x3A67B0", Length = "0x78")]
	[Token(Token = "0x60026E1")]
	public static extern IntPtr NotifyRoomMemberChange_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E2")]
	[Address(RVA = "0x3A8470", Offset = "0x3A6C70", Length = "0x78")]
	public static extern IntPtr NotifyRoomMemberKicked_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E3")]
	[Address(RVA = "0x3A7A70", Offset = "0x3A6270", Length = "0x78")]
	public static extern IntPtr NotifyRoomDestroy_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A8930", Offset = "0x3A7130", Length = "0x78")]
	[Token(Token = "0x60026E4")]
	public static extern IntPtr NotifyRoomOwnerChange_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A7C00", Offset = "0x3A6400", Length = "0x78")]
	[Token(Token = "0x60026E5")]
	public static extern IntPtr NotifyRoomGameServerChange_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E6")]
	[Address(RVA = "0x380090", Offset = "0x37E890", Length = "0x78")]
	public static extern IntPtr AsyncQueryQuotaResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E7")]
	[Address(RVA = "0x3E3A10", Offset = "0x3E2210", Length = "0x78")]
	public static extern IntPtr ShareStorageToSpaceWorkResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x380760", Offset = "0x37EF60", Length = "0x78")]
	[Token(Token = "0x60026E8")]
	public static extern IntPtr AsyncReadFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x382180", Offset = "0x380980", Length = "0x78")]
	public static extern IntPtr AsyncWriteFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x380C40", Offset = "0x37F440", Length = "0x78")]
	public static extern IntPtr AsyncReadStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x382650", Offset = "0x380E50", Length = "0x78")]
	[Token(Token = "0x60026EB")]
	public static extern IntPtr AsyncWriteStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x37F820", Offset = "0x37E020", Length = "0x78")]
	[Token(Token = "0x60026EC")]
	public static extern IntPtr AsyncListFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x381440", Offset = "0x37FC40", Length = "0x78")]
	[Token(Token = "0x60026ED")]
	public static extern IntPtr AsyncRenameStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026EE")]
	[Address(RVA = "0x37EFB0", Offset = "0x37D7B0", Length = "0x78")]
	public static extern IntPtr AsyncDeleteStreamFileResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026EF")]
	[Address(RVA = "0x386A30", Offset = "0x385230", Length = "0x78")]
	public static extern IntPtr CreateVoiceChannelResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F0")]
	[Address(RVA = "0x3A4BE0", Offset = "0x3A33E0", Length = "0x78")]
	public static extern IntPtr JoinVoiceChannelResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F1")]
	[Address(RVA = "0x3A69D0", Offset = "0x3A51D0", Length = "0x78")]
	public static extern IntPtr LeaveVoiceChannelResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E5E60", Offset = "0x3E4660", Length = "0x78")]
	[Token(Token = "0x60026F2")]
	public static extern IntPtr VoiceChannelAddUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F3")]
	[Address(RVA = "0x3E6A10", Offset = "0x3E5210", Length = "0x78")]
	public static extern IntPtr VoiceChannelRemoveUsersResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F4")]
	[Address(RVA = "0x3E6210", Offset = "0x3E4A10", Length = "0x78")]
	public static extern IntPtr VoiceChannelInviteEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F5")]
	[Address(RVA = "0x3E65E0", Offset = "0x3E4DE0", Length = "0x78")]
	public static extern IntPtr VoiceChannelMemeberChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F6")]
	[Address(RVA = "0x3E6880", Offset = "0x3E5080", Length = "0x78")]
	public static extern IntPtr VoiceChannelPushToTalkKeyChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3E7170", Offset = "0x3E5970", Length = "0x78")]
	[Token(Token = "0x60026F7")]
	public static extern IntPtr VoiceChannelUsersSpeakingStateChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F8")]
	[Address(RVA = "0x3E6DC0", Offset = "0x3E55C0", Length = "0x78")]
	public static extern IntPtr VoiceChannelSpeakingUsersChangedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026F9")]
	[Address(RVA = "0x3E7410", Offset = "0x3E5C10", Length = "0x78")]
	public static extern IntPtr VoiceDataCapturedEvent_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026FA")]
	[Address(RVA = "0x3DBE50", Offset = "0x3DA650", Length = "0x78")]
	public static extern IntPtr RailTextInputResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA880", Offset = "0x3A9080", Length = "0x78")]
	[Token(Token = "0x60026FB")]
	public static extern IntPtr QuerySubscribeWishPlayStateResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D1F30", Offset = "0x3D0730", Length = "0x78")]
	[Token(Token = "0x60026FC")]
	public static extern IntPtr RailIMEHelperTextInputCompositionState_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D21E0", Offset = "0x3D09E0", Length = "0x78")]
	[Token(Token = "0x60026FD")]
	public static extern IntPtr RailIMEHelperTextInputSelectedResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026FE")]
	[Address(RVA = "0x3D1B80", Offset = "0x3D0380", Length = "0x78")]
	public static extern IntPtr RailHttpSessionResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x60026FF")]
	[Address(RVA = "0x3D85F0", Offset = "0x3D6DF0", Length = "0x78")]
	public static extern IntPtr RailSmallObjectStateQueryResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002700")]
	[Address(RVA = "0x3D8460", Offset = "0x3D6C60", Length = "0x78")]
	public static extern IntPtr RailSmallObjectDownloadResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002701")]
	[Address(RVA = "0x3DB910", Offset = "0x3DA110", Length = "0x78")]
	public static extern IntPtr RailSwitchPlayerSelectedZoneResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D7500", Offset = "0x3D5D00", Length = "0x78")]
	[Token(Token = "0x6002702")]
	public static extern IntPtr RailQueryGroupsInfoResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3D5020", Offset = "0x3D3820", Length = "0x78")]
	[Token(Token = "0x6002703")]
	public static extern IntPtr RailOpenGroupChatResult_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39A070", Offset = "0x398870", Length = "0x78")]
	[Token(Token = "0x6002704")]
	public static extern IntPtr IRailPlayerAchievement_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396360", Offset = "0x394B60", Length = "0x78")]
	[Token(Token = "0x6002705")]
	public static extern IntPtr IRailGlobalAchievement_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9220", Offset = "0x3A7A20", Length = "0x78")]
	[Token(Token = "0x6002706")]
	public static extern IntPtr PlayerAchievementReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A92A0", Offset = "0x3A7AA0", Length = "0x78")]
	[Token(Token = "0x6002707")]
	public static extern IntPtr PlayerAchievementStored_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002708")]
	[Address(RVA = "0x38DBC0", Offset = "0x38C3C0", Length = "0x78")]
	public static extern IntPtr GlobalAchievementReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002709")]
	[Address(RVA = "0x38EC00", Offset = "0x38D400", Length = "0x78")]
	public static extern IntPtr IRailAssets_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600270A")]
	[Address(RVA = "0x390430", Offset = "0x38EC30", Length = "0x78")]
	public static extern IntPtr IRailBrowser_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600270B")]
	[Address(RVA = "0x38FD60", Offset = "0x38E560", Length = "0x78")]
	public static extern IntPtr IRailBrowserRender_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600270C")]
	[Address(RVA = "0x394C10", Offset = "0x393410", Length = "0x78")]
	public static extern IntPtr IRailGameServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x398A50", Offset = "0x397250", Length = "0x78")]
	[Token(Token = "0x600270D")]
	public static extern IntPtr IRailLeaderboard_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600270E")]
	[Address(RVA = "0x3982C0", Offset = "0x396AC0", Length = "0x78")]
	public static extern IntPtr IRailLeaderboardEntries_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600270F")]
	[Address(RVA = "0x3A5EA0", Offset = "0x3A46A0", Length = "0x78")]
	public static extern IntPtr LeaderboardReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002710")]
	[Address(RVA = "0x3A53D0", Offset = "0x3A3BD0", Length = "0x78")]
	public static extern IntPtr LeaderboardCreated_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A59C0", Offset = "0x3A41C0", Length = "0x78")]
	[Token(Token = "0x6002711")]
	public static extern IntPtr LeaderboardEntryReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002712")]
	[Address(RVA = "0x3A6150", Offset = "0x3A4950", Length = "0x78")]
	public static extern IntPtr LeaderboardUploaded_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002713")]
	[Address(RVA = "0x3A5120", Offset = "0x3A3920", Length = "0x78")]
	public static extern IntPtr LeaderboardAttachSpaceWork_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002714")]
	[Address(RVA = "0x39C940", Offset = "0x39B140", Length = "0x78")]
	public static extern IntPtr IRailRoom_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39D100", Offset = "0x39B900", Length = "0x78")]
	[Token(Token = "0x6002715")]
	public static extern IntPtr IRailScreenshot_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39A4B0", Offset = "0x398CB0", Length = "0x78")]
	[Token(Token = "0x6002716")]
	public static extern IntPtr IRailPlayerStats_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002717")]
	[Address(RVA = "0x3968D0", Offset = "0x3950D0", Length = "0x78")]
	public static extern IntPtr IRailGlobalStats_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A9FA0", Offset = "0x3A87A0", Length = "0x78")]
	[Token(Token = "0x6002718")]
	public static extern IntPtr PlayerStatsReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3AA020", Offset = "0x3A8820", Length = "0x78")]
	[Token(Token = "0x6002719")]
	public static extern IntPtr PlayerStatsStored_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600271A")]
	[Address(RVA = "0x3A8DF0", Offset = "0x3A75F0", Length = "0x78")]
	public static extern IntPtr NumberOfPlayerReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600271B")]
	[Address(RVA = "0x38DD50", Offset = "0x38C550", Length = "0x78")]
	public static extern IntPtr GlobalStatsRequestReceived_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x600271C")]
	[Address(RVA = "0x392020", Offset = "0x390820", Length = "0x78")]
	public static extern IntPtr IRailFile_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A0910", Offset = "0x39F110", Length = "0x78")]
	[Token(Token = "0x600271D")]
	public static extern IntPtr IRailStreamFile_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x39EAD0", Offset = "0x39D2D0", Length = "0x78")]
	[Token(Token = "0x600271E")]
	public static extern IntPtr IRailSpaceWork_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A3060", Offset = "0x3A1860", Length = "0x78")]
	[Token(Token = "0x600271F")]
	public static extern IntPtr IRailVoiceChannel_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002720")]
	[Address(RVA = "0x397420", Offset = "0x395C20", Length = "0x78")]
	public static extern IntPtr IRailHttpSession_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Token(Token = "0x6002721")]
	[Address(RVA = "0x3971A0", Offset = "0x3959A0", Length = "0x78")]
	public static extern IntPtr IRailHttpResponse_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x3A4710", Offset = "0x3A2F10", Length = "0x78")]
	[Token(Token = "0x6002722")]
	public static extern IntPtr IRailZoneServer_SWIGUpcast(IntPtr jarg1);

	[PreserveSig]
	[Address(RVA = "0x396BE0", Offset = "0x3953E0", Length = "0x78")]
	[Token(Token = "0x6002723")]
	public static extern IntPtr IRailGroupChat_SWIGUpcast(IntPtr jarg1);

	[Token(Token = "0x6002724")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public RAIL_API_PINVOKE()
	{
	}
}
