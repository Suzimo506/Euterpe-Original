using System;
using System.Text;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000435")]
public class ApplicationManager
{
	[Token(Token = "0x2000ADD")]
	internal struct FFIEvents
	{
	}

	[Token(Token = "0x2000ADE")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E37")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ValidateOrExitCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E38")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ValidateOrExitMethod(IntPtr methodsPtr, IntPtr callbackData, ValidateOrExitCallback callback);

		[Token(Token = "0x2000E39")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void GetCurrentLocaleMethod(IntPtr methodsPtr, StringBuilder locale);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E3A")]
		internal delegate void GetCurrentBranchMethod(IntPtr methodsPtr, StringBuilder branch);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E3B")]
		internal delegate void GetOAuth2TokenCallback(IntPtr ptr, Result result, ref OAuth2Token oauth2Token);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E3C")]
		internal delegate void GetOAuth2TokenMethod(IntPtr methodsPtr, IntPtr callbackData, GetOAuth2TokenCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E3D")]
		internal delegate void GetTicketCallback(IntPtr ptr, Result result, ref string data);

		[Token(Token = "0x2000E3E")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void GetTicketMethod(IntPtr methodsPtr, IntPtr callbackData, GetTicketCallback callback);

		[Token(Token = "0x40038E2")]
		[FieldOffset(Offset = "0x0")]
		internal ValidateOrExitMethod ValidateOrExit;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038E3")]
		internal GetCurrentLocaleMethod GetCurrentLocale;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038E4")]
		internal GetCurrentBranchMethod GetCurrentBranch;

		[Token(Token = "0x40038E5")]
		[FieldOffset(Offset = "0x18")]
		internal GetOAuth2TokenMethod GetOAuth2Token;

		[Token(Token = "0x40038E6")]
		[FieldOffset(Offset = "0x20")]
		internal GetTicketMethod GetTicket;
	}

	[Token(Token = "0x2000ADF")]
	public delegate void ValidateOrExitHandler(Result result);

	[Token(Token = "0x2000AE0")]
	public delegate void GetOAuth2TokenHandler(Result result, ref OAuth2Token oauth2Token);

	[Token(Token = "0x2000AE1")]
	public delegate void GetTicketHandler(Result result, ref string data);

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001778")]
	private IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001779")]
	private object MethodsStructure;

	[Token(Token = "0x17000474")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x995260", Offset = "0x993A60", Length = "0x110")]
		[Token(Token = "0x600316E")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Address(RVA = "0x995130", Offset = "0x993930", Length = "0x121")]
	[Token(Token = "0x600316F")]
	internal ApplicationManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003170")]
	[Address(RVA = "0x994F50", Offset = "0x993750", Length = "0x62")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003171")]
	[Address(RVA = "0x994FC0", Offset = "0x9937C0", Length = "0x90")]
	private static void ValidateOrExitCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003172")]
	[Address(RVA = "0x995060", Offset = "0x993860", Length = "0xC5")]
	public void ValidateOrExit(ValidateOrExitHandler callback)
	{
	}

	[Token(Token = "0x6003173")]
	[Address(RVA = "0x994BA0", Offset = "0x9933A0", Length = "0x9A")]
	public string GetCurrentLocale()
	{
		return null;
	}

	[Token(Token = "0x6003174")]
	[Address(RVA = "0x994B00", Offset = "0x993300", Length = "0x9A")]
	public string GetCurrentBranch()
	{
		return null;
	}

	[Token(Token = "0x6003175")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x994C40", Offset = "0x993440", Length = "0xA0")]
	private static void GetOAuth2TokenCallbackImpl(IntPtr ptr, Result result, ref OAuth2Token oauth2Token)
	{
	}

	[Token(Token = "0x6003176")]
	[Address(RVA = "0x994CF0", Offset = "0x9934F0", Length = "0xD0")]
	public void GetOAuth2Token(GetOAuth2TokenHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003177")]
	[Address(RVA = "0x994DD0", Offset = "0x9935D0", Length = "0xA0")]
	private static void GetTicketCallbackImpl(IntPtr ptr, Result result, ref string data)
	{
	}

	[Token(Token = "0x6003178")]
	[Address(RVA = "0x994E80", Offset = "0x993680", Length = "0xC8")]
	public void GetTicket(GetTicketHandler callback)
	{
	}
}
