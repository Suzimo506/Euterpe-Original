using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Events;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000836")]
public class StageBackgroundSelectCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4002AC5")]
	private Image m_ImgPreview;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002AC6")]
	[SerializeField]
	private Image m_ImgPreviewUnSelect;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4002AC7")]
	private Image m_ImgLock;

	[SerializeField]
	[Token(Token = "0x4002AC8")]
	[FieldOffset(Offset = "0x38")]
	private Button m_BtnSelected;

	[SerializeField]
	[Token(Token = "0x4002AC9")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_BgSelectMark;

	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4002ACA")]
	private GameObject m_ImgPurchasedSign;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4002ACB")]
	[SerializeField]
	private GameObject m_ImgWeeklyFreeSign;

	[SerializeField]
	[Token(Token = "0x4002ACC")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_ImgRedot;

	[Token(Token = "0x4002ACD")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Text m_TxtBgName;

	[SerializeField]
	[Token(Token = "0x4002ACE")]
	[FieldOffset(Offset = "0x68")]
	private Text m_TxtBgNameUnSelect;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002ACF")]
	private StageBackgroundData m_SelectData;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002AD0")]
	private bool m_BgIsUnlocked;

	[FieldOffset(Offset = "0x79")]
	[Token(Token = "0x4002AD1")]
	private bool m_BgIsLimitedFree;

	[FieldOffset(Offset = "0x7A")]
	[Token(Token = "0x4002AD2")]
	private bool m_IsCellClicked;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002AD3")]
	private OnFancyScrollViewCellUpdate m_FsvCellUpdate;

	[Token(Token = "0x4002AD4")]
	[FieldOffset(Offset = "0x88")]
	private PnlStageBackgroundView m_RootView;

	[Token(Token = "0x17000847")]
	public int CellIndex
	{
		[CompilerGenerated]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		[Token(Token = "0x6004B9C")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6004B9D")]
		set
		{
		}
	}

	[Token(Token = "0x17000848")]
	public PnlStageBackgroundView RootView
	{
		[Token(Token = "0x6004B9E")]
		[Address(RVA = "0x5C14D0", Offset = "0x5BFCD0", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x17000849")]
	public StageBackgroundData BgSelectData
	{
		[Token(Token = "0x6004B9F")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x603430", Offset = "0x601C30", Length = "0x96")]
		set
		{
		}
	}

	[Token(Token = "0x1700084A")]
	public bool BgCanUsed
	{
		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x603420", Offset = "0x601C20", Length = "0xD")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004BA2")]
	[Address(RVA = "0x6032B0", Offset = "0x601AB0", Length = "0x120")]
	public void SetCellOnSelect(bool isSelected)
	{
	}

	[Address(RVA = "0x603000", Offset = "0x601800", Length = "0x2A0")]
	[Token(Token = "0x6004BA3")]
	public void SetCellOnPreviewSelect(bool isSelected)
	{
	}

	[Address(RVA = "0x6033E0", Offset = "0x601BE0", Length = "0x3C")]
	[Token(Token = "0x6004BA4")]
	public void ShowPreviewBackground()
	{
	}

	[Token(Token = "0x6004BA5")]
	[Address(RVA = "0x602410", Offset = "0x600C10", Length = "0x262")]
	public void OnClickToSelect()
	{
	}

	[Token(Token = "0x6004BA6")]
	[Address(RVA = "0x602990", Offset = "0x601190", Length = "0x66A")]
	private void SetCellContent()
	{
	}

	[Token(Token = "0x6004BA7")]
	[Address(RVA = "0x602680", Offset = "0x600E80", Length = "0x1ED")]
	private void OnDataIndexChanged(int dataIdx)
	{
	}

	[Token(Token = "0x6004BA8")]
	[Address(RVA = "0x6023C0", Offset = "0x600BC0", Length = "0x4A")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004BA9")]
	[Address(RVA = "0x602900", Offset = "0x601100", Length = "0x83")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6004BAA")]
	[Address(RVA = "0x602870", Offset = "0x601070", Length = "0x88")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004BAB")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public StageBackgroundSelectCell()
	{
	}
}
