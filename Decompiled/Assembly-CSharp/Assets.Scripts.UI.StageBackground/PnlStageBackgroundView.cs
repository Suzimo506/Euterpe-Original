using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000833")]
public class PnlStageBackgroundView : MonoBehaviour
{
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4002AAF")]
	[Attribute(Name = "RangeAttribute", RVA = "0x18E30", Offset = "0x18230")]
	[SerializeField]
	private float m_SelectPopTweenDuration;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002AB0")]
	[SerializeField]
	private UISelectManage m_UISelectManage;

	[SerializeField]
	[Token(Token = "0x4002AB1")]
	[FieldOffset(Offset = "0x28")]
	private Button m_BtnShowBgSelect;

	[SerializeField]
	[Token(Token = "0x4002AB2")]
	[FieldOffset(Offset = "0x30")]
	private Button m_BtnCloseSelect;

	[SerializeField]
	[Token(Token = "0x4002AB3")]
	[FieldOffset(Offset = "0x38")]
	private Button m_BtnInputFocusCell;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002AB4")]
	[SerializeField]
	private RectTransform m_ImgNoSelectMark;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002AB5")]
	[SerializeField]
	private RectTransform m_ImgOnSelectingMark;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002AB6")]
	[SerializeField]
	private PnlStageBackgroundSelectFsv m_FsvBgSelect;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4002AB7")]
	[SerializeField]
	private PnlStageBackgroundSelectNormalView m_NormalBgSelect;

	[Token(Token = "0x4002AB8")]
	[FieldOffset(Offset = "0x60")]
	private PnlStageBackgroundSelectBase m_BgSelectView;

	[Token(Token = "0x4002AB9")]
	[FieldOffset(Offset = "0x68")]
	private LobbyBackgroundLoader m_BgLoader;

	[Token(Token = "0x4002ABA")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsShowSelect;

	[Token(Token = "0x4002ABB")]
	[FieldOffset(Offset = "0x71")]
	private bool m_CanMoveOther;

	[Token(Token = "0x17000840")]
	public int PreviewSelectedBgIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x6004B73")]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000841")]
	public PnlStageBackgroundSelectBase BgSelectView
	{
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004B76")]
	[Address(RVA = "0x5FECA0", Offset = "0x5FD4A0", Length = "0x281")]
	public void SwitchBackground(int bgId, bool notPreview = true)
	{
	}

	[Token(Token = "0x6004B77")]
	[Address(RVA = "0x5FE3B0", Offset = "0x5FCBB0", Length = "0x1DD")]
	private void OnClickToShowSelect()
	{
	}

	[Token(Token = "0x6004B78")]
	[Address(RVA = "0x5FE270", Offset = "0x5FCA70", Length = "0x138")]
	public void OnClickToCloseSelect()
	{
	}

	[Token(Token = "0x6004B79")]
	[Address(RVA = "0x5FE1A0", Offset = "0x5FC9A0", Length = "0xC8")]
	private void OnBackgroundDataUpdated()
	{
	}

	[Token(Token = "0x6004B7A")]
	[Address(RVA = "0x5FE800", Offset = "0x5FD000", Length = "0x2F2")]
	private void ResetBackgroundSelectView()
	{
	}

	[Token(Token = "0x6004B7B")]
	[Address(RVA = "0x5FEB00", Offset = "0x5FD300", Length = "0xFA")]
	private void ResetBackground()
	{
	}

	[Token(Token = "0x6004B7C")]
	[Address(RVA = "0x5FEC00", Offset = "0x5FD400", Length = "0x21")]
	private void SetShowBtnEnable(bool value)
	{
	}

	[Token(Token = "0x6004B7D")]
	[Address(RVA = "0x5FDFA0", Offset = "0x5FC7A0", Length = "0x1F8")]
	private void Awake()
	{
	}

	[Address(RVA = "0x5FEC30", Offset = "0x5FD430", Length = "0x68")]
	[Token(Token = "0x6004B7E")]
	private void Start()
	{
	}

	[Token(Token = "0x6004B7F")]
	[Address(RVA = "0x5FE6A0", Offset = "0x5FCEA0", Length = "0x15A")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004B80")]
	[Address(RVA = "0x5FE590", Offset = "0x5FCD90", Length = "0x10B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004B81")]
	[Address(RVA = "0x5FF0A0", Offset = "0x5FD8A0", Length = "0x190")]
	private void Update()
	{
	}

	[Token(Token = "0x6004B82")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlStageBackgroundView()
	{
	}
}
