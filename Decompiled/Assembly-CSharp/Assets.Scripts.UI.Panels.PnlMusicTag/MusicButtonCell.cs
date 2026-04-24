using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlMusicTag;

[Token(Token = "0x20008FE")]
public class MusicButtonCell : BaseMusicButton
{
	[SerializeField]
	[Token(Token = "0x4003027")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_WeekFreeIcon;

	[SerializeField]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4003028")]
	private GameObject m_ImgLvLockIcon;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4003029")]
	[SerializeField]
	private GameObject m_ImgBuyLockIcon;

	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400302A")]
	private GameObject m_ImgAnchorIcon;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x400302B")]
	private GameObject m_MasterLockIcon;

	[SerializeField]
	[Token(Token = "0x400302C")]
	[FieldOffset(Offset = "0x50")]
	private LongSongNameController m_LongTxtCtrl;

	[SerializeField]
	[Token(Token = "0x400302D")]
	[FieldOffset(Offset = "0x58")]
	private Image m_Img;

	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Token(Token = "0x400302E")]
	private Text m_LevelTxt;

	[Token(Token = "0x400302F")]
	[SerializeField]
	[FieldOffset(Offset = "0x68")]
	private Image m_BgImg;

	[Token(Token = "0x4003030")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public RectTransform m_RectTransform;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4003031")]
	[SerializeField]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x4003032")]
	[FieldOffset(Offset = "0x80")]
	private int m_TabIndex;

	[Token(Token = "0x4003033")]
	[FieldOffset(Offset = "0x84")]
	private int m_ClickCount;

	[Token(Token = "0x170008AF")]
	public MusicInfo musicInfo
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x60051A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000095")]
	public event Action<MusicButtonCell, int> OnClicked
	{
		[Token(Token = "0x60051A5")]
		[CompilerGenerated]
		[Address(RVA = "0x67A350", Offset = "0x678B50", Length = "0x9E")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60051A6")]
		[Address(RVA = "0x67A3F0", Offset = "0x678BF0", Length = "0x9E")]
		remove
		{
		}
	}

	[Token(Token = "0x60051A7")]
	[Address(RVA = "0x679890", Offset = "0x678090", Length = "0x89")]
	private void Awake()
	{
	}

	[Token(Token = "0x60051A8")]
	[Address(RVA = "0x679960", Offset = "0x678160", Length = "0x51")]
	private void OnButtonClicked()
	{
	}

	[Token(Token = "0x60051A9")]
	[Address(RVA = "0x67A0C0", Offset = "0x6788C0", Length = "0x280")]
	public void UiRefresh()
	{
	}

	[Token(Token = "0x60051AA")]
	[Address(RVA = "0x679920", Offset = "0x678120", Length = "0x36")]
	public void InitMusicCell(MusicInfo initMusicInfo, int tabIndex)
	{
	}

	[Token(Token = "0x60051AB")]
	[Address(RVA = "0x6799C0", Offset = "0x6781C0", Length = "0x72")]
	private void ResetIcon()
	{
	}

	[Token(Token = "0x60051AC")]
	[Address(RVA = "0x679B70", Offset = "0x678370", Length = "0x30D")]
	private void SetIcon()
	{
	}

	[Token(Token = "0x60051AD")]
	[Address(RVA = "0x679A40", Offset = "0x678240", Length = "0x96")]
	private bool SetAnchorIcon()
	{
		return default(bool);
	}

	[Address(RVA = "0x679E80", Offset = "0x678680", Length = "0x128")]
	[Token(Token = "0x60051AE")]
	private bool SetLevelIcon()
	{
		return default(bool);
	}

	[Address(RVA = "0x67A040", Offset = "0x678840", Length = "0x7D")]
	[Token(Token = "0x60051AF")]
	private bool SetWeekFreeIcon()
	{
		return default(bool);
	}

	[Token(Token = "0x60051B0")]
	[Address(RVA = "0x679AE0", Offset = "0x6782E0", Length = "0x81")]
	private bool SetBuyIcon()
	{
		return default(bool);
	}

	[Token(Token = "0x60051B1")]
	[Address(RVA = "0x679FB0", Offset = "0x6787B0", Length = "0x81")]
	private bool SetMasterIcon()
	{
		return default(bool);
	}

	[Token(Token = "0x60051B2")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MusicButtonCell()
	{
	}
}
