using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000436")]
public class UserManager
{
	[Token(Token = "0x2000AE2")]
	internal struct FFIEvents
	{
		[Token(Token = "0x2000E3F")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CurrentUserUpdateHandler(IntPtr ptr);

		[Token(Token = "0x40038E7")]
		[FieldOffset(Offset = "0x0")]
		internal CurrentUserUpdateHandler OnCurrentUserUpdate;
	}

	[Token(Token = "0x2000AE3")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000E40")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetCurrentUserMethod(IntPtr methodsPtr, ref User currentUser);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E41")]
		internal delegate void GetUserCallback(IntPtr ptr, Result result, ref User user);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E42")]
		internal delegate void GetUserMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E43")]
		internal delegate Result GetCurrentUserPremiumTypeMethod(IntPtr methodsPtr, ref PremiumType premiumType);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E44")]
		internal delegate Result CurrentUserHasFlagMethod(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038E8")]
		internal GetCurrentUserMethod GetCurrentUser;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40038E9")]
		internal GetUserMethod GetUser;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038EA")]
		internal GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType;

		[Token(Token = "0x40038EB")]
		[FieldOffset(Offset = "0x18")]
		internal CurrentUserHasFlagMethod CurrentUserHasFlag;
	}

	[Token(Token = "0x2000AE4")]
	public delegate void GetUserHandler(Result result, ref User user);

	[Token(Token = "0x2000AE5")]
	public delegate void CurrentUserUpdateHandler();

	[Token(Token = "0x400177A")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x400177B")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x17000475")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x21BEAB0", Offset = "0x21BD2B0", Length = "0x106")]
		[Token(Token = "0x6003179")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400002F")]
	public event CurrentUserUpdateHandler OnCurrentUserUpdate
	{
		[Address(RVA = "0x21BEA10", Offset = "0x21BD210", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600317A")]
		add
		{
		}
		[Address(RVA = "0x21BEBC0", Offset = "0x21BD3C0", Length = "0x9E")]
		[Token(Token = "0x600317B")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Address(RVA = "0x21BE8A0", Offset = "0x21BD0A0", Length = "0x16C")]
	[Token(Token = "0x600317C")]
	internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x600317D")]
	[Address(RVA = "0x21BE730", Offset = "0x21BCF30", Length = "0xA6")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x21BE4F0", Offset = "0x21BCCF0", Length = "0xA7")]
	[Token(Token = "0x600317E")]
	public User GetCurrentUser()
	{
		return default(User);
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x21BE5A0", Offset = "0x21BCDA0", Length = "0xA0")]
	[Token(Token = "0x600317F")]
	private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user)
	{
	}

	[Token(Token = "0x6003180")]
	[Address(RVA = "0x21BE650", Offset = "0x21BCE50", Length = "0xDC")]
	public void GetUser(long userId, GetUserHandler callback)
	{
	}

	[Token(Token = "0x6003181")]
	[Address(RVA = "0x21BE440", Offset = "0x21BCC40", Length = "0xA1")]
	public PremiumType GetCurrentUserPremiumType()
	{
		return default(PremiumType);
	}

	[Address(RVA = "0x21BE380", Offset = "0x21BCB80", Length = "0xB5")]
	[Token(Token = "0x6003182")]
	public bool CurrentUserHasFlag(UserFlag flag)
	{
		return default(bool);
	}

	[Token(Token = "0x6003183")]
	[Address(RVA = "0x21BE7E0", Offset = "0x21BCFE0", Length = "0xB2")]
	[MonoPInvokeCallback]
	private static void OnCurrentUserUpdateImpl(IntPtr ptr)
	{
	}
}
