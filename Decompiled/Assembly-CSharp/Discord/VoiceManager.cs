using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Discord;

[Token(Token = "0x200043E")]
public class VoiceManager
{
	[Token(Token = "0x2000B1A")]
	internal struct FFIEvents
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB6")]
		internal delegate void SettingsUpdateHandler(IntPtr ptr);

		[Token(Token = "0x4003946")]
		[FieldOffset(Offset = "0x0")]
		internal SettingsUpdateHandler OnSettingsUpdate;
	}

	[Token(Token = "0x2000B1B")]
	internal struct FFIMethods
	{
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB7")]
		internal delegate Result GetInputModeMethod(IntPtr methodsPtr, ref InputMode inputMode);

		[Token(Token = "0x2000EB8")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate void SetInputModeCallback(IntPtr ptr, Result result);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EB9")]
		internal delegate void SetInputModeMethod(IntPtr methodsPtr, InputMode inputMode, IntPtr callbackData, SetInputModeCallback callback);

		[Token(Token = "0x2000EBA")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result IsSelfMuteMethod(IntPtr methodsPtr, ref bool mute);

		[Token(Token = "0x2000EBB")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetSelfMuteMethod(IntPtr methodsPtr, bool mute);

		[Token(Token = "0x2000EBC")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result IsSelfDeafMethod(IntPtr methodsPtr, ref bool deaf);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EBD")]
		internal delegate Result SetSelfDeafMethod(IntPtr methodsPtr, bool deaf);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EBE")]
		internal delegate Result IsLocalMuteMethod(IntPtr methodsPtr, long userId, ref bool mute);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EBF")]
		internal delegate Result SetLocalMuteMethod(IntPtr methodsPtr, long userId, bool mute);

		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		[Token(Token = "0x2000EC0")]
		internal delegate Result GetLocalVolumeMethod(IntPtr methodsPtr, long userId, ref byte volume);

		[Token(Token = "0x2000EC1")]
		[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x173E0", Offset = "0x167E0")]
		internal delegate Result SetLocalVolumeMethod(IntPtr methodsPtr, long userId, byte volume);

		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x0")]
		internal GetInputModeMethod GetInputMode;

		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4003948")]
		internal SetInputModeMethod SetInputMode;

		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x10")]
		internal IsSelfMuteMethod IsSelfMute;

		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x18")]
		internal SetSelfMuteMethod SetSelfMute;

		[Token(Token = "0x400394B")]
		[FieldOffset(Offset = "0x20")]
		internal IsSelfDeafMethod IsSelfDeaf;

		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400394C")]
		internal SetSelfDeafMethod SetSelfDeaf;

		[Token(Token = "0x400394D")]
		[FieldOffset(Offset = "0x30")]
		internal IsLocalMuteMethod IsLocalMute;

		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400394E")]
		internal SetLocalMuteMethod SetLocalMute;

		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400394F")]
		internal GetLocalVolumeMethod GetLocalVolume;

		[Token(Token = "0x4003950")]
		[FieldOffset(Offset = "0x48")]
		internal SetLocalVolumeMethod SetLocalVolume;
	}

	[Token(Token = "0x2000B1C")]
	public delegate void SetInputModeHandler(Result result);

	[Token(Token = "0x2000B1D")]
	public delegate void SettingsUpdateHandler();

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400179A")]
	private IntPtr MethodsPtr;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400179B")]
	private object MethodsStructure;

	[Token(Token = "0x1700047D")]
	private FFIMethods Methods
	{
		[Address(RVA = "0x45C100", Offset = "0x45A900", Length = "0x11E")]
		[Token(Token = "0x6003230")]
		get
		{
			return default(FFIMethods);
		}
	}

	[Token(Token = "0x1400003F")]
	public event SettingsUpdateHandler OnSettingsUpdate
	{
		[Token(Token = "0x6003231")]
		[CompilerGenerated]
		[Address(RVA = "0x45C060", Offset = "0x45A860", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x45C220", Offset = "0x45AA20", Length = "0x9E")]
		remove
		{
		}
	}

	[Address(RVA = "0x45BEE0", Offset = "0x45A6E0", Length = "0x17C")]
	[Token(Token = "0x6003233")]
	internal VoiceManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0x45B6C0", Offset = "0x459EC0", Length = "0xB6")]
	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events)
	{
	}

	[Token(Token = "0x6003235")]
	[Address(RVA = "0x45B550", Offset = "0x459D50", Length = "0xA6")]
	public InputMode GetInputMode()
	{
		return default(InputMode);
	}

	[MonoPInvokeCallback]
	[Address(RVA = "0x45BA80", Offset = "0x45A280", Length = "0x90")]
	[Token(Token = "0x6003236")]
	private static void SetInputModeCallbackImpl(IntPtr ptr, Result result)
	{
	}

	[Token(Token = "0x6003237")]
	[Address(RVA = "0x45BB20", Offset = "0x45A320", Length = "0xFD")]
	public void SetInputMode(InputMode inputMode, SetInputModeHandler callback)
	{
	}

	[Address(RVA = "0x45B900", Offset = "0x45A100", Length = "0xB4")]
	[Token(Token = "0x6003238")]
	public bool IsSelfMute()
	{
		return default(bool);
	}

	[Address(RVA = "0x45BE40", Offset = "0x45A640", Length = "0x9F")]
	[Token(Token = "0x6003239")]
	public void SetSelfMute(bool mute)
	{
	}

	[Address(RVA = "0x45B840", Offset = "0x45A040", Length = "0xB4")]
	[Token(Token = "0x600323A")]
	public bool IsSelfDeaf()
	{
		return default(bool);
	}

	[Address(RVA = "0x45BDA0", Offset = "0x45A5A0", Length = "0x9F")]
	[Token(Token = "0x600323B")]
	public void SetSelfDeaf(bool deaf)
	{
	}

	[Address(RVA = "0x45B780", Offset = "0x459F80", Length = "0xBF")]
	[Token(Token = "0x600323C")]
	public bool IsLocalMute(long userId)
	{
		return default(bool);
	}

	[Token(Token = "0x600323D")]
	[Address(RVA = "0x45BC20", Offset = "0x45A420", Length = "0xB8")]
	public void SetLocalMute(long userId, bool mute)
	{
	}

	[Token(Token = "0x600323E")]
	[Address(RVA = "0x45B600", Offset = "0x459E00", Length = "0xBF")]
	public byte GetLocalVolume(long userId)
	{
		return default(byte);
	}

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x45BCE0", Offset = "0x45A4E0", Length = "0xB8")]
	public void SetLocalVolume(long userId, byte volume)
	{
	}

	[MonoPInvokeCallback]
	[Token(Token = "0x6003240")]
	[Address(RVA = "0x45B9C0", Offset = "0x45A1C0", Length = "0xB5")]
	private static void OnSettingsUpdateImpl(IntPtr ptr)
	{
	}
}
