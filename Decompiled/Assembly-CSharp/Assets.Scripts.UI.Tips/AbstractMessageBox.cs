using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Nice.Actions;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Tips;

[Token(Token = "0x200087E")]
public abstract class AbstractMessageBox : SerializedMonoBehaviour
{
	[Token(Token = "0x4002C51")]
	[SerializeField]
	[FieldOffset(Offset = "0x58")]
	protected Popup m_Popup;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002C52")]
	[SerializeField]
	protected Text m_Title;

	[SerializeField]
	[Token(Token = "0x4002C53")]
	[FieldOffset(Offset = "0x68")]
	protected Text m_Msg;

	[Token(Token = "0x4002C5B")]
	[FieldOffset(Offset = "0xA8")]
	public System.Action onYesAct;

	[Token(Token = "0x4002C5C")]
	[FieldOffset(Offset = "0xB0")]
	public System.Action onNoAct;

	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002C5D")]
	public System.Action onCloseAct;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002C5E")]
	[SerializeField]
	protected Button m_YesButton;

	[SerializeField]
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4002C5F")]
	protected Button m_NoButton;

	[Token(Token = "0x4002C60")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	protected Button m_CancelButton;

	[SerializeField]
	[Token(Token = "0x4002C61")]
	[FieldOffset(Offset = "0xD8")]
	protected Button m_HelpButton;

	[SerializeField]
	[Token(Token = "0x4002C62")]
	[FieldOffset(Offset = "0xE0")]
	protected string m_MessageBoxKey;

	[FieldOffset(Offset = "0xE8")]
	[Token(Token = "0x4002C63")]
	protected bool m_PlayClickAudio;

	[FieldOffset(Offset = "0xE9")]
	[Token(Token = "0x4002C64")]
	[SerializeField]
	protected bool m_AutoClose;

	[Token(Token = "0x4002C65")]
	[SerializeField]
	[FieldOffset(Offset = "0xEA")]
	protected bool m_IsBaseMessageBox;

	[SerializeField]
	[Token(Token = "0x4002C66")]
	[FieldOffset(Offset = "0xEC")]
	protected ButtonType m_ButtonType;

	[Token(Token = "0x4002C67")]
	private static string[] s_TitleLocal;

	[Token(Token = "0x1700086F")]
	public string MessageBoxKey
	{
		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x48E510", Offset = "0x48CD10", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000870")]
	public string MessageBoxTitle
	{
		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x5F0D50", Offset = "0x5EF550", Length = "0x27")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x5F1230", Offset = "0x5EFA30", Length = "0x40")]
		set
		{
		}
	}

	[Token(Token = "0x17000871")]
	public string MessageBoxText
	{
		[Address(RVA = "0x5F0D20", Offset = "0x5EF520", Length = "0x27")]
		[Token(Token = "0x6004D6D")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x5F11E0", Offset = "0x5EF9E0", Length = "0x40")]
		set
		{
		}
	}

	[Token(Token = "0x1400008C")]
	public event System.Action onYesClicked
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x5F0C80", Offset = "0x5EF480", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x5F1140", Offset = "0x5EF940", Length = "0x9E")]
		[Token(Token = "0x6004D55")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400008D")]
	public event System.Action onNoClicked
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D56")]
		[Address(RVA = "0x5F0AA0", Offset = "0x5EF2A0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Address(RVA = "0x5F0F60", Offset = "0x5EF760", Length = "0x9E")]
		[Token(Token = "0x6004D57")]
		remove
		{
		}
	}

	[Token(Token = "0x1400008E")]
	public event System.Action onCancelClicked
	{
		[CompilerGenerated]
		[Address(RVA = "0x5F08C0", Offset = "0x5EF0C0", Length = "0x9E")]
		[Token(Token = "0x6004D58")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004D59")]
		[Address(RVA = "0x5F0D80", Offset = "0x5EF580", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x1400008F")]
	public event System.Action onHelpClicked
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D5A")]
		[Address(RVA = "0x5F0A00", Offset = "0x5EF200", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6004D5B")]
		[Address(RVA = "0x5F0EC0", Offset = "0x5EF6C0", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000090")]
	public event System.Action onShutClicked
	{
		[Token(Token = "0x6004D5C")]
		[Address(RVA = "0x5F0BE0", Offset = "0x5EF3E0", Length = "0x9E")]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6004D5D")]
		[Address(RVA = "0x5F10A0", Offset = "0x5EF8A0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000091")]
	public event System.Action onClose
	{
		[CompilerGenerated]
		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x5F0960", Offset = "0x5EF160", Length = "0x9E")]
		add
		{
		}
		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x5F0E20", Offset = "0x5EF620", Length = "0x9E")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000092")]
	public event System.Action onShow
	{
		[Token(Token = "0x6004D60")]
		[CompilerGenerated]
		[Address(RVA = "0x5F0B40", Offset = "0x5EF340", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x5F1000", Offset = "0x5EF800", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6004D61")]
		remove
		{
		}
	}

	[Address(RVA = "0x5F0410", Offset = "0x5EEC10", Length = "0x12")]
	[Token(Token = "0x6004D62")]
	public void SetPopTypeOnce(PopupType targetType)
	{
	}

	[Token(Token = "0x6004D63")]
	[Address(RVA = "0x5F0110", Offset = "0x5EE910", Length = "0x7")]
	public void SetAutoClose(bool enable)
	{
	}

	[Token(Token = "0x6004D64")]
	[Address(RVA = "0x5EFE40", Offset = "0x5EE640", Length = "0x111")]
	protected virtual void OnYesClicked()
	{
	}

	[Token(Token = "0x6004D65")]
	[Address(RVA = "0x5EFC10", Offset = "0x5EE410", Length = "0x111")]
	protected virtual void OnNoClicked()
	{
	}

	[Token(Token = "0x6004D66")]
	[Address(RVA = "0x5EF9F0", Offset = "0x5EE1F0", Length = "0x101")]
	protected virtual void OnCancelClicked()
	{
	}

	[Token(Token = "0x6004D67")]
	[Address(RVA = "0x5EFB00", Offset = "0x5EE300", Length = "0x101")]
	protected virtual void OnHelpClicked()
	{
	}

	[Address(RVA = "0x5EFD30", Offset = "0x5EE530", Length = "0x109")]
	[Token(Token = "0x6004D68")]
	protected virtual void OnShutClicked()
	{
	}

	[Token(Token = "0x6004D69")]
	[Address(RVA = "0x5F0430", Offset = "0x5EEC30", Length = "0x1A")]
	public void SetShutEnable(bool enable)
	{
	}

	[Token(Token = "0x6004D6F")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnSetTitle()
	{
	}

	[Token(Token = "0x6004D70")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	protected virtual void OnSetMsg()
	{
	}

	[Token(Token = "0x6004D71")]
	[Address(RVA = "0x5EF980", Offset = "0x5EE180", Length = "0x40")]
	public virtual Button GetMsgBoxButton(ButtonType type)
	{
		return null;
	}

	[Token(Token = "0x6004D72")]
	[Address(RVA = "0x5F0120", Offset = "0x5EE920", Length = "0x1D2")]
	public virtual void SetButtonDisplay(ButtonType t)
	{
	}

	[Token(Token = "0x6004D73")]
	[Address(RVA = "0x5F0300", Offset = "0x5EEB00", Length = "0x107")]
	public virtual bool SetButtonText(ButtonType type, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D74")]
	[Address(RVA = "0x5EF750", Offset = "0x5EDF50", Length = "0xBD")]
	public virtual void ClearAllEvent()
	{
	}

	[Token(Token = "0x6004D75")]
	[Address(RVA = "0x5EF810", Offset = "0x5EE010", Length = "0x78")]
	public virtual void ClearEvent(ButtonType t)
	{
	}

	[Token(Token = "0x6004D76")]
	[Address(RVA = "0x5EF470", Offset = "0x5EDC70", Length = "0x2D9")]
	public virtual void AwakeInit()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6004D77")]
	public virtual void StartInit()
	{
	}

	[Token(Token = "0x6004D78")]
	[Address(RVA = "0x5EF950", Offset = "0x5EE150", Length = "0x27")]
	public virtual void Destroy()
	{
	}

	[Token(Token = "0x6004D79")]
	[Address(RVA = "0x5F0450", Offset = "0x5EEC50", Length = "0x45")]
	public virtual void Show()
	{
	}

	[Token(Token = "0x6004D7A")]
	[Address(RVA = "0x5F0450", Offset = "0x5EEC50", Length = "0x45")]
	public virtual void Show(params object[] param)
	{
	}

	[Token(Token = "0x6004D7B")]
	[Address(RVA = "0x5F04A0", Offset = "0x5EECA0", Length = "0x155")]
	public virtual void Show(string title, string msg)
	{
	}

	[Token(Token = "0x6004D7C")]
	[Address(RVA = "0x5EF8F0", Offset = "0x5EE0F0", Length = "0x56")]
	public virtual void Close(bool disablePrevPopup = false)
	{
	}

	[Token(Token = "0x6004D7D")]
	[Address(RVA = "0x5EF890", Offset = "0x5EE090", Length = "0x55")]
	public virtual void CloseAll()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x6004D7E")]
	public abstract void SetSetting(string key, int value);

	[Address(RVA = "0x5EFF60", Offset = "0x5EE760", Length = "0x1A4")]
	[Token(Token = "0x6004D7F")]
	public virtual void ResetMsgBox()
	{
	}

	[Token(Token = "0x6004D80")]
	[Address(RVA = "0x4248F0", Offset = "0x4230F0", Length = "0x7")]
	protected AbstractMessageBox()
	{
	}
}
