using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043B")]
public class OverlayManager
{
	[Token(Token = "0x2000B07")]
	internal struct FFIEvents
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E8E")]
		internal delegate void ToggleHandler(IntPtr ptr, bool locked);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003928")]
		internal ToggleHandler OnToggle;
	}

	[Token(Token = "0x2000B08")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E8F")]
		internal delegate void IsEnabledMethod(IntPtr methodsPtr, ref bool enabled);

		[Token(Token = "0x2000E90")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void IsLockedMethod(IntPtr methodsPtr, ref bool locked);

		[Token(Token = "0x2000E91")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SetLockedCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E92")]
		internal delegate void SetLockedMethod(IntPtr methodsPtr, bool locked, IntPtr callbackData, SetLockedCallback callback);

		[Token(Token = "0x2000E93")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void OpenActivityInviteCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E94")]
		internal delegate void OpenActivityInviteMethod(IntPtr methodsPtr, ActivityActionType type, IntPtr callbackData, OpenActivityInviteCallback callback);

		[Token(Token = "0x2000E95")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void OpenGuildInviteCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E96")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void OpenGuildInviteMethod(IntPtr methodsPtr, string code, IntPtr callbackData, OpenGuildInviteCallback callback);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000E97")]
		internal delegate void OpenVoiceSettingsCallback(IntPtr ptr, Result result);

		[Token(Token = "0x2000E98")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void OpenVoiceSettingsMethod(IntPtr methodsPtr, IntPtr callbackData, OpenVoiceSettingsCallback callback);

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4003929")]
		internal IsEnabledMethod IsEnabled;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400392A")]
		internal IsLockedMethod IsLocked;

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400392B")]
		internal SetLockedMethod SetLocked;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400392C")]
		internal OpenActivityInviteMethod OpenActivityInvite;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400392D")]
		internal OpenGuildInviteMethod OpenGuildInvite;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400392E")]
		internal OpenVoiceSettingsMethod OpenVoiceSettings;
	}

	[Token(Token = "0x2000B09")]
	public delegate void SetLockedHandler(Result result);

	[Token(Token = "0x2000B0A")]
	public delegate void OpenActivityInviteHandler(Result result);

	[Token(Token = "0x2000B0B")]
	public delegate void OpenGuildInviteHandler(Result result);

	[Token(Token = "0x2000B0C")]
	public delegate void OpenVoiceSettingsHandler(Result result);

	[Token(Token = "0x2000B0D")]
	public delegate void ToggleHandler(bool locked);

	[Token(Token = "0x4001791")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr MethodsPtr;

	[Token(Token = "0x4001792")]
	[FieldOffset(Offset = "0x18")]
	private object MethodsStructure;

	[Token(Token = "0x1700047A")]
	private FFIMethods Methods
	{
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x21B8820", Offset = "0x21B7020", Length = "0x10E")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400003C")]
	public event ToggleHandler OnToggle
	{
		[CompilerGenerated]
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x21B8780", Offset = "0x21B6F80", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x21B8930", Offset = "0x21B7130", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x60031F9")]
	[Address(RVA = "0x21B8600", Offset = "0x21B6E00", Length = "0x17C")]
	internal OverlayManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031FA")]
	[Address(RVA = "0x21B7D60", Offset = "0x21B6560", Length = "0xB6")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x60031FB")]
	[Address(RVA = "0x21B7E20", Offset = "0x21B6620", Length = "0x56")]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[Token(Token = "0x60031FC")]
	[Address(RVA = "0x21B7E80", Offset = "0x21B6680", Length = "0x57")]
	public bool IsLocked()
	{
		return default(bool);
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x60031FD")]
	[Address(RVA = "0x21B8470", Offset = "0x21B6C70", Length = "0x90")]
	private static void SetLockedCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x60031FE")]
	[Address(RVA = "0x21B8510", Offset = "0x21B6D10", Length = "0xE8")]
	public void SetLocked(bool locked, SetLockedHandler callback)
	{
	}

	[Token(Token = "0x60031FF")]
	[Address(RVA = "0x21B7FB0", Offset = "0x21B67B0", Length = "0x90")]
	[MonoPInvokeCallback]
	private static void OpenActivityInviteCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Address(RVA = "0x21B8050", Offset = "0x21B6850", Length = "0xF0")]
	[Token(Token = "0x6003200")]
	public void OpenActivityInvite(ActivityActionType type, OpenActivityInviteHandler callback)
	{
	}

	[Token(Token = "0x6003201")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x21B8150", Offset = "0x21B6950", Length = "0x90")]
	private static void OpenGuildInviteCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003202")]
	[Address(RVA = "0x21B81F0", Offset = "0x21B69F0", Length = "0xE7")]
	public void OpenGuildInvite(string code, OpenGuildInviteHandler callback)
	{
	}

	[Token(Token = "0x6003203")]
	[MonoPInvokeCallback]
	[Address(RVA = "0x21B82E0", Offset = "0x21B6AE0", Length = "0x90")]
	private static void OpenVoiceSettingsCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003204")]
	[Address(RVA = "0x21B8380", Offset = "0x21B6B80", Length = "0xE0")]
	public void OpenVoiceSettings(OpenVoiceSettingsHandler callback)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003205")]
	[Address(RVA = "0x21B7EE0", Offset = "0x21B66E0", Length = "0xC6")]
	private static void OnToggleImpl(IntPtr ptr, bool locked)
	{
	}
}
