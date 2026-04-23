using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x2000408")]
public class ActivityManager
{
	[Token(Token = "0x2000ACB")]
	internal struct FFIEvents
	{
		[Token(Token = "0x2000E0B")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ActivityJoinHandler(IntPtr ptr, string secret);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E0C")]
		internal delegate void ActivitySpectateHandler(IntPtr ptr, string secret);

		[Token(Token = "0x2000E0D")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ActivityJoinRequestHandler(IntPtr ptr, ref User user);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E0E")]
		internal delegate void ActivityInviteHandler(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038A0")]
		internal ActivityJoinHandler OnActivityJoin;

		[Token(Token = "0x40038A1")]
		[FieldOffset(Offset = "0x8")]
		internal ActivitySpectateHandler OnActivitySpectate;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40038A2")]
		internal ActivityJoinRequestHandler OnActivityJoinRequest;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40038A3")]
		internal ActivityInviteHandler OnActivityInvite;
	}

	[Token(Token = "0x2000ACC")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E0F")]
		internal delegate Result RegisterCommandMethod(IntPtr methodsPtr, string command);

		[Token(Token = "0x2000E10")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result RegisterSteamMethod(IntPtr methodsPtr, uint steamId);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E11")]
		internal delegate void UpdateActivityCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E12")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void UpdateActivityMethod(IntPtr methodsPtr, ref Activity activity, IntPtr callbackData, UpdateActivityCallback callback);

		[Token(Token = "0x2000E13")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ClearActivityCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E14")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void ClearActivityMethod(IntPtr methodsPtr, IntPtr callbackData, ClearActivityCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E15")]
		internal delegate void SendRequestReplyCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E16")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SendRequestReplyMethod(IntPtr methodsPtr, long userId, ActivityJoinRequestReply reply, IntPtr callbackData, SendRequestReplyCallback callback);

		[Token(Token = "0x2000E17")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SendInviteCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E18")]
		internal delegate void SendInviteMethod(IntPtr methodsPtr, long userId, ActivityActionType type, string content, IntPtr callbackData, SendInviteCallback callback);

		[Token(Token = "0x2000E19")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void AcceptInviteCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E1A")]
		internal delegate void AcceptInviteMethod(IntPtr methodsPtr, long userId, IntPtr callbackData, AcceptInviteCallback callback);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40038A4")]
		internal RegisterCommandMethod RegisterCommand;

		[Token(Token = "0x40038A5")]
		[FieldOffset(Offset = "0x8")]
		internal RegisterSteamMethod RegisterSteam;

		[Token(Token = "0x40038A6")]
		[FieldOffset(Offset = "0x10")]
		internal UpdateActivityMethod UpdateActivity;

		[Token(Token = "0x40038A7")]
		[FieldOffset(Offset = "0x18")]
		internal ClearActivityMethod ClearActivity;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40038A8")]
		internal SendRequestReplyMethod SendRequestReply;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40038A9")]
		internal SendInviteMethod SendInvite;

		[Token(Token = "0x40038AA")]
		[FieldOffset(Offset = "0x30")]
		internal AcceptInviteMethod AcceptInvite;
	}

	[Token(Token = "0x2000ACD")]
	public delegate void UpdateActivityHandler(Result result);

	[Token(Token = "0x2000ACE")]
	public delegate void ClearActivityHandler(Result result);

	[Token(Token = "0x2000ACF")]
	public delegate void SendRequestReplyHandler(Result result);

	[Token(Token = "0x2000AD0")]
	public delegate void SendInviteHandler(Result result);

	[Token(Token = "0x2000AD1")]
	public delegate void AcceptInviteHandler(Result result);

	[Token(Token = "0x2000AD2")]
	public delegate void ActivityJoinHandler(string secret);

	[Token(Token = "0x2000AD3")]
	public delegate void ActivitySpectateHandler(string secret);

	[Token(Token = "0x2000AD4")]
	public delegate void ActivityJoinRequestHandler(ref User user);

	[Token(Token = "0x2000AD5")]
	public delegate void ActivityInviteHandler(ActivityActionType type, ref User user, ref Activity activity);

	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001684")]
	private object MethodsStructure;

	[Token(Token = "0x1700046E")]
	private FFIMethods Methods
	{
		[Token(Token = "0x600312A")]
		[Address(RVA = "0x9946D0", Offset = "0x992ED0", Length = "0x118")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400002B")]
	public event ActivityJoinHandler OnActivityJoin
	{
		[CompilerGenerated]
		[Address(RVA = "0x994590", Offset = "0x992D90", Length = "0x9E")]
		[Token(Token = "0x600312B")]
		add
		{
		}
		[Token(Token = "0x600312C")]
		[CompilerGenerated]
		[Address(RVA = "0x994930", Offset = "0x993130", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002C")]
	public event ActivitySpectateHandler OnActivitySpectate
	{
		[Token(Token = "0x600312D")]
		[Address(RVA = "0x994630", Offset = "0x992E30", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x600312E")]
		[Address(RVA = "0x9949D0", Offset = "0x9931D0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400002D")]
	public event ActivityJoinRequestHandler OnActivityJoinRequest
	{
		[Address(RVA = "0x9944F0", Offset = "0x992CF0", Length = "0x9E")]
		[Token(Token = "0x600312F")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x994890", Offset = "0x993090", Length = "0x9E")]
		[Token(Token = "0x6003130")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002E")]
	public event ActivityInviteHandler OnActivityInvite
	{
		[CompilerGenerated]
		[Token(Token = "0x6003131")]
		[Address(RVA = "0x994450", Offset = "0x992C50", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003132")]
		[Address(RVA = "0x9947F0", Offset = "0x992FF0", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x993BD0", Offset = "0x9923D0", Length = "0x9E")]
	[Token(Token = "0x6003129")]
	public void RegisterCommand()
	{
	}

	[Token(Token = "0x6003133")]
	[Address(RVA = "0x9941F0", Offset = "0x9929F0", Length = "0x258")]
	internal ActivityManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003134")]
	[Address(RVA = "0x993630", Offset = "0x991E30", Length = "0x19C")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003135")]
	[Address(RVA = "0x993B30", Offset = "0x992330", Length = "0x9D")]
	public void RegisterCommand(string command)
	{
	}

	[Token(Token = "0x6003136")]
	[Address(RVA = "0x993C70", Offset = "0x992470", Length = "0x9D")]
	public void RegisterSteam(uint steamId)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003137")]
	[Address(RVA = "0x994060", Offset = "0x992860", Length = "0x90")]
	private static void UpdateActivityCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003138")]
	[Address(RVA = "0x994100", Offset = "0x992900", Length = "0xE7")]
	public void UpdateActivity(Activity activity, UpdateActivityHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003139")]
	[Address(RVA = "0x9934A0", Offset = "0x991CA0", Length = "0x90")]
	private static void ClearActivityCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x993540", Offset = "0x991D40", Length = "0xE0")]
	[Token(Token = "0x600313A")]
	public void ClearActivity(ClearActivityHandler callback)
	{
	}

	[Address(RVA = "0x993EC0", Offset = "0x9926C0", Length = "0x90")]
	[Token(Token = "0x600313B")]
	[MonoPInvokeCallback]
	private static void SendRequestReplyCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x993F60", Offset = "0x992760", Length = "0xFD")]
	[Token(Token = "0x600313C")]
	public void SendRequestReply(long userId, ActivityJoinRequestReply reply, SendRequestReplyHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x600313D")]
	[Address(RVA = "0x993D10", Offset = "0x992510", Length = "0x90")]
	private static void SendInviteCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x993DB0", Offset = "0x9925B0", Length = "0x10E")]
	[Token(Token = "0x600313E")]
	public void SendInvite(long userId, ActivityActionType type, string content, SendInviteHandler callback)
	{
	}

	[Address(RVA = "0x993310", Offset = "0x991B10", Length = "0x90")]
	[Token(Token = "0x600313F")]
	[MonoPInvokeCallback]
	private static void AcceptInviteCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x9933B0", Offset = "0x991BB0", Length = "0xE9")]
	[Token(Token = "0x6003140")]
	public void AcceptInvite(long userId, AcceptInviteHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x9938C0", Offset = "0x9920C0", Length = "0xC5")]
	[Token(Token = "0x6003141")]
	private static void OnActivityJoinImpl(IntPtr ptr, string secret)
	{
	}

	[Address(RVA = "0x993A60", Offset = "0x992260", Length = "0xC5")]
	[Token(Token = "0x6003142")]
	[MonoPInvokeCallback]
	private static void OnActivitySpectateImpl(IntPtr ptr, string secret)
	{
	}

	[Address(RVA = "0x993990", Offset = "0x992190", Length = "0xC5")]
	[Token(Token = "0x6003143")]
	[MonoPInvokeCallback]
	private static void OnActivityJoinRequestImpl(IntPtr ptr, ref User user)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003144")]
	[Address(RVA = "0x9937D0", Offset = "0x991FD0", Length = "0xE9")]
	private static void OnActivityInviteImpl(IntPtr ptr, ActivityActionType type, ref User user, ref Activity activity)
	{
	}
}
