using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043F")]
public class AchievementManager
{
	[Token(Token = "0x2000B1E")]
	internal struct FFIEvents
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EC2")]
		internal delegate void UserAchievementUpdateHandler(IntPtr ptr, ref UserAchievement userAchievement);

		[Token(Token = "0x4003951")]
		[FieldOffset(Offset = "0x0")]
		internal UserAchievementUpdateHandler OnUserAchievementUpdate;
	}

	[Token(Token = "0x2000B1F")]
	internal struct FFIMethods
	{
		[Token(Token = "0x2000EC3")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SetUserAchievementCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000EC4")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SetUserAchievementMethod(IntPtr methodsPtr, long achievementId, byte percentComplete, IntPtr callbackData, SetUserAchievementCallback callback);

		[Token(Token = "0x2000EC5")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void FetchUserAchievementsCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000EC6")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void FetchUserAchievementsMethod(IntPtr methodsPtr, IntPtr callbackData, FetchUserAchievementsCallback callback);

		[Token(Token = "0x2000EC7")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void CountUserAchievementsMethod(IntPtr methodsPtr, ref int count);

		[Token(Token = "0x2000EC8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result GetUserAchievementMethod(IntPtr methodsPtr, long userAchievementId, ref UserAchievement userAchievement);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EC9")]
		internal delegate Result GetUserAchievementAtMethod(IntPtr methodsPtr, int index, ref UserAchievement userAchievement);

		[Token(Token = "0x4003952")]
		[FieldOffset(Offset = "0x0")]
		internal SetUserAchievementMethod SetUserAchievement;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003953")]
		internal FetchUserAchievementsMethod FetchUserAchievements;

		[Token(Token = "0x4003954")]
		[FieldOffset(Offset = "0x10")]
		internal CountUserAchievementsMethod CountUserAchievements;

		[Token(Token = "0x4003955")]
		[FieldOffset(Offset = "0x18")]
		internal GetUserAchievementMethod GetUserAchievement;

		[Token(Token = "0x4003956")]
		[FieldOffset(Offset = "0x20")]
		internal GetUserAchievementAtMethod GetUserAchievementAt;
	}

	[Token(Token = "0x2000B20")]
	public delegate void SetUserAchievementHandler(Result result);

	[Token(Token = "0x2000B21")]
	public delegate void FetchUserAchievementsHandler(Result result);

	[Token(Token = "0x2000B22")]
	public delegate void UserAchievementUpdateHandler(ref UserAchievement userAchievement);

	[Token(Token = "0x400179D")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400179E")]
	private object MethodsStructure;

	[Token(Token = "0x1700047E")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x9920D0", Offset = "0x9908D0", Length = "0x110")]
		[Token(Token = "0x6003241")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x14000040")]
	public event UserAchievementUpdateHandler OnUserAchievementUpdate
	{
		[Address(RVA = "0x992030", Offset = "0x990830", Length = "0x9E")]
		[Token(Token = "0x6003242")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x9921F0", Offset = "0x9909F0", Length = "0x9E")]
		[Token(Token = "0x6003243")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003244")]
	[Address(RVA = "0x991EB0", Offset = "0x9906B0", Length = "0x17C")]
	internal AchievementManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Address(RVA = "0x991B80", Offset = "0x990380", Length = "0xB6")]
	[Token(Token = "0x6003245")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003246")]
	[Address(RVA = "0x991D10", Offset = "0x990510", Length = "0x90")]
	[MonoPInvokeCallback]
	private static void SetUserAchievementCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003247")]
	[Address(RVA = "0x991DB0", Offset = "0x9905B0", Length = "0xFB")]
	public void SetUserAchievement(long achievementId, byte percentComplete, SetUserAchievementHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003248")]
	[Address(RVA = "0x991860", Offset = "0x990060", Length = "0x90")]
	private static void FetchUserAchievementsCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003249")]
	[Address(RVA = "0x991900", Offset = "0x990100", Length = "0xDF")]
	public void FetchUserAchievements(FetchUserAchievementsHandler callback)
	{
	}

	[Token(Token = "0x600324A")]
	[Address(RVA = "0x991800", Offset = "0x990000", Length = "0x53")]
	public int CountUserAchievements()
	{
		return default(int);
	}

	[Address(RVA = "0x991AB0", Offset = "0x9902B0", Length = "0xC0")]
	[Token(Token = "0x600324B")]
	public UserAchievement GetUserAchievement(long userAchievementId)
	{
		return default(UserAchievement);
	}

	[Token(Token = "0x600324C")]
	[Address(RVA = "0x9919E0", Offset = "0x9901E0", Length = "0xCC")]
	public UserAchievement GetUserAchievementAt(int index)
	{
		return default(UserAchievement);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x600324D")]
	[Address(RVA = "0x991C40", Offset = "0x990440", Length = "0xC5")]
	private static void OnUserAchievementUpdateImpl(IntPtr ptr, ref UserAchievement userAchievement)
	{
	}
}
