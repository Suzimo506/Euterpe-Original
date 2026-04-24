using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils;

[Token(Token = "0x20001EE")]
[AttributeAttribute(Name = "EditorBrowsableAttribute", RVA = "0x11BB0", Offset = "0x10FB0")]
public class ExternalTools : IExternalTools
{
	[Token(Token = "0x4000D72")]
	private static Func<object> _getPlatformInitializerDelegate;

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D73")]
	private bool _isEditorPaused;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D74")]
	private Action<bool> _EditorPausedStateChangedEvent;

	[Token(Token = "0x17000308")]
	public static Func<object> getPlatformInitializerDelegate
	{
		[Address(RVA = "0x620850", Offset = "0x61F050", Length = "0x35")]
		[Token(Token = "0x6000FCA")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x6209B0", Offset = "0x61F1B0", Length = "0x42")]
		set
		{
		}
	}

	[Token(Token = "0x17000309")]
	public bool isEditorPaused
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x6000FCE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700030A")]
	public bool UnityInput_IsTouchPressureSupported
	{
		[Address(RVA = "0x620840", Offset = "0x61F040", Length = "0x7")]
		[Token(Token = "0x6000FE3")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000015")]
	public event Action<bool> EditorPausedStateChangedEvent
	{
		[Address(RVA = "0x620720", Offset = "0x61EF20", Length = "0x76")]
		[Token(Token = "0x6000FCF")]
		add
		{
		}
		[Address(RVA = "0x620890", Offset = "0x61F090", Length = "0x76")]
		[Token(Token = "0x6000FD0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
	{
		[CompilerGenerated]
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x6207A0", Offset = "0x61EFA0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x620910", Offset = "0x61F110", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x6000FCC")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ExternalTools()
	{
	}

	[Token(Token = "0x6000FCD")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6000FD1")]
	[Address(RVA = "0x620430", Offset = "0x61EC30", Length = "0x7")]
	public object GetPlatformInitializer()
	{
		return null;
	}

	[Token(Token = "0x6000FD2")]
	[Address(RVA = "0x6203F0", Offset = "0x61EBF0", Length = "0x35")]
	public string GetFocusedEditorWindowTitle()
	{
		return null;
	}

	[Token(Token = "0x6000FD3")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public bool IsEditorSceneViewFocused()
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD4")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public bool LinuxInput_IsJoystickPreconfigured(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FD7")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public int XboxOneInput_GetUserIdForGamepad(uint id)
	{
		return default(int);
	}

	[Token(Token = "0x6000FD8")]
	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
	{
		return default(ulong);
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6000FD9")]
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0x6206E0", Offset = "0x61EEE0", Length = "0x35")]
	public string XboxOneInput_GetControllerType(ulong xboxControllerId)
	{
		return null;
	}

	[Address(RVA = "0x47F9A0", Offset = "0x47E1A0", Length = "0x3")]
	[Token(Token = "0x6000FDB")]
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
	{
		return default(uint);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000FDC")]
	public void XboxOne_Gamepad_UpdatePlugin()
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6000FDD")]
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000FDE")]
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
	{
	}

	[Token(Token = "0x6000FDF")]
	[Address(RVA = "0x620350", Offset = "0x61EB50", Length = "0x97")]
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
	{
		vids = null;
		pids = null;
	}

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0x4E94D0", Offset = "0x4E7CD0", Length = "0x6")]
	public int GetAndroidAPILevel()
	{
		return default(int);
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0x620460", Offset = "0x61EC60", Length = "0x139")]
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
	{
		return default(bool);
	}

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0x6205A0", Offset = "0x61EDA0", Length = "0x13D")]
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
	{
	}

	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x620450", Offset = "0x61EC50", Length = "0xA")]
	public float UnityInput_GetTouchPressure(ref Touch touch)
	{
		return default(float);
	}

	[Token(Token = "0x6000FE5")]
	[Address(RVA = "0x620440", Offset = "0x61EC40", Length = "0xA")]
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
	{
		return default(float);
	}

	[Address(RVA = "0x6201A0", Offset = "0x61E9A0", Length = "0x6C")]
	[Token(Token = "0x6000FE6")]
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
	{
		return null;
	}

	[Token(Token = "0x6000FE7")]
	[Address(RVA = "0x6202B0", Offset = "0x61EAB0", Length = "0x99")]
	public Type[] GetControllerTemplateTypes()
	{
		return null;
	}

	[Address(RVA = "0x620210", Offset = "0x61EA10", Length = "0x9A")]
	[Token(Token = "0x6000FE8")]
	public Type[] GetControllerTemplateInterfaceTypes()
	{
		return null;
	}
}
