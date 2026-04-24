using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Assets.Scripts.UI.Tips;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[Token(Token = "0x2000197")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x428E0", Offset = "0x41CE0")]
public class StageLikeToggle : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IInputKeyBinding
{
	[Token(Token = "0x4000A00")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_ButtonName;

	[SerializeField]
	[Token(Token = "0x4000A01")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_ImgLike;

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000A02")]
	private GameObject m_ImgHide;

	[Token(Token = "0x4000A03")]
	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	private Image m_HoldImg;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000A04")]
	[SerializeField]
	private float m_HoldTime;

	[Token(Token = "0x4000A05")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsHide;

	[FieldOffset(Offset = "0x3D")]
	[Token(Token = "0x4000A06")]
	private bool m_IsCollection;

	[Token(Token = "0x4000A07")]
	[FieldOffset(Offset = "0x3E")]
	private bool m_IsClickHide;

	[FieldOffset(Offset = "0x3F")]
	[Token(Token = "0x4000A08")]
	private bool m_IsBeginHoldAnim;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000A09")]
	private Button m_Button;

	[Token(Token = "0x4000A0A")]
	[FieldOffset(Offset = "0x48")]
	private Effect m_ParTglLikes;

	[Token(Token = "0x4000A0B")]
	[FieldOffset(Offset = "0x50")]
	private Effect m_ParTglDisLikes;

	[Token(Token = "0x4000A0C")]
	[FieldOffset(Offset = "0x58")]
	private AbstractMessageBox m_HideMsg;

	[Token(Token = "0x4000A0D")]
	[FieldOffset(Offset = "0x60")]
	private AbstractMessageBox m_CancelHideMsg;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000A0E")]
	private AbstractMessageBox m_LikeCancelMsg;

	[Token(Token = "0x4000A0F")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsPointDown;

	[Token(Token = "0x4000A10")]
	[FieldOffset(Offset = "0x74")]
	private float m_LongHoldTimer;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000A15")]
	private UISelectManage m_UiManage;

	[Token(Token = "0x170000DD")]
	private bool isOn
	{
		[Address(RVA = "0x517850", Offset = "0x516050", Length = "0xD")]
		[Token(Token = "0x6000B7E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000DE")]
	private MusicInfo selectMusicInfo
	{
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x517860", Offset = "0x516060", Length = "0xAA")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DF")]
	public UISelectManage GetPanelOrder
	{
		[Address(RVA = "0x49A8B0", Offset = "0x4990B0", Length = "0x8")]
		[Token(Token = "0x6000B9A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000E0")]
	public bool IsOnCurrentPanel
	{
		[Address(RVA = "0x5177B0", Offset = "0x515FB0", Length = "0x95")]
		[Token(Token = "0x6000B9B")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000007")]
	public event Action<MusicInfo> onAddHide
	{
		[CompilerGenerated]
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x5175D0", Offset = "0x515DD0", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x5179B0", Offset = "0x5161B0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<MusicInfo> onRemoveHide
	{
		[Address(RVA = "0x517710", Offset = "0x515F10", Length = "0x9E")]
		[Token(Token = "0x6000B82")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000B83")]
		[CompilerGenerated]
		[Address(RVA = "0x517AF0", Offset = "0x5162F0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action<MusicInfo> onAddCollection
	{
		[Address(RVA = "0x517530", Offset = "0x515D30", Length = "0x9E")]
		[Token(Token = "0x6000B84")]
		[CompilerGenerated]
		add
		{
		}
		[Address(RVA = "0x517910", Offset = "0x516110", Length = "0x9E")]
		[Token(Token = "0x6000B85")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action<MusicInfo> onRemoveCollection
	{
		[Token(Token = "0x6000B86")]
		[CompilerGenerated]
		[Address(RVA = "0x517670", Offset = "0x515E70", Length = "0x9E")]
		add
		{
		}
		[Address(RVA = "0x517A50", Offset = "0x516250", Length = "0x9E")]
		[Token(Token = "0x6000B87")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x516290", Offset = "0x514A90", Length = "0x126")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5163C0", Offset = "0x514BC0", Length = "0x293")]
	[Token(Token = "0x6000B89")]
	private void InitMsg()
	{
	}

	[Address(RVA = "0x516A10", Offset = "0x515210", Length = "0x5")]
	[Token(Token = "0x6000B8A")]
	private void OnHideMsgShow()
	{
	}

	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x516A00", Offset = "0x515200", Length = "0x5")]
	private void OnHideMsgClose()
	{
	}

	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x516740", Offset = "0x514F40", Length = "0x10B")]
	public void MusicChanged(MusicInfo mi)
	{
	}

	[Token(Token = "0x6000B8D")]
	[Address(RVA = "0x5170D0", Offset = "0x5158D0", Length = "0x3D")]
	private void UpdateIcon()
	{
	}

	[Token(Token = "0x6000B8E")]
	[Address(RVA = "0x516660", Offset = "0x514E60", Length = "0x5")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Address(RVA = "0x516C00", Offset = "0x515400", Length = "0x7")]
	[Token(Token = "0x6000B8F")]
	public void OnPointerUp(PointerEventData data)
	{
	}

	[Token(Token = "0x6000B90")]
	[Address(RVA = "0x516660", Offset = "0x514E60", Length = "0x5")]
	private void KeyPress()
	{
	}

	[Address(RVA = "0x516670", Offset = "0x514E70", Length = "0xC0")]
	[Token(Token = "0x6000B91")]
	private void KeyUp()
	{
	}

	[Token(Token = "0x6000B92")]
	[Address(RVA = "0x516850", Offset = "0x515050", Length = "0x1AD")]
	private void OnClicked(bool state)
	{
	}

	[Address(RVA = "0x517110", Offset = "0x515910", Length = "0x3C5")]
	[Token(Token = "0x6000B93")]
	private void Update()
	{
	}

	[Token(Token = "0x6000B94")]
	[Address(RVA = "0x516000", Offset = "0x514800", Length = "0x280")]
	private void AddCollection()
	{
	}

	[Token(Token = "0x6000B95")]
	[Address(RVA = "0x516E20", Offset = "0x515620", Length = "0x1B8")]
	private void RemoveCollection()
	{
	}

	[Address(RVA = "0x516A20", Offset = "0x515220", Length = "0x1D6")]
	[Token(Token = "0x6000B96")]
	private void OnHideMusic()
	{
	}

	[Token(Token = "0x6000B97")]
	[Address(RVA = "0x516C10", Offset = "0x515410", Length = "0x154")]
	private void OnRemoveHideMusic()
	{
	}

	[Address(RVA = "0x516D70", Offset = "0x515570", Length = "0xA9")]
	[Token(Token = "0x6000B98")]
	private void OnRemoveLikeMusic()
	{
	}

	[Token(Token = "0x6000B99")]
	[Address(RVA = "0x516FE0", Offset = "0x5157E0", Length = "0xEB")]
	public void SetPanelOrder(UISelectManage uiManage)
	{
	}

	[Token(Token = "0x6000B9C")]
	[Address(RVA = "0x5174E0", Offset = "0x515CE0", Length = "0x4D")]
	public StageLikeToggle()
	{
	}
}
