using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.Structs;
using Assets.Scripts.UI.Specials;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091E")]
public class DLCInfoSubControl : DLCInfoBaseControl
{
	[SerializeField]
	[Token(Token = "0x4003100")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform m_RectTransform;

	[SerializeField]
	[Token(Token = "0x4003101")]
	[FieldOffset(Offset = "0x68")]
	private DlcSizeAlbumPair m_DlcSizeAlbumPair;

	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x832F0", Offset = "0x826F0")]
	[Token(Token = "0x4003102")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform m_ImgBaseRectTransform;

	[SerializeField]
	[Token(Token = "0x4003103")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_CellContent;

	[SerializeField]
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4003104")]
	private Image m_BaseImage;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4003105")]
	private string m_BaseSongCellBg;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4003106")]
	private Color m_BaseSongCellBgColor;

	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x15870", Offset = "0x14C70")]
	[SerializeField]
	[Token(Token = "0x4003107")]
	private DlcBillboardControl m_BillboardControl;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4003108")]
	[SerializeField]
	private DlcBillboardControl m_Billboard2Control;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4003109")]
	[SerializeField]
	private GridLayoutGroup m_GridLayout;

	[Token(Token = "0x400310A")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private HorizontalLayoutGroup m_HorizontalLayoutGroup;

	[SerializeField]
	[Token(Token = "0x400310B")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, GridLayoutArgs> m_GridLayoutArgs;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400310C")]
	[SerializeField]
	private GameObject m_MusicDiscoCell;

	[SerializeField]
	[Token(Token = "0x400310D")]
	[FieldOffset(Offset = "0xD0")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x84230", Offset = "0x83630")]
	private EnableDisableHooker m_SliderHooker;

	[SerializeField]
	[Token(Token = "0x400310E")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject m_DownTip;

	[SerializeField]
	[Token(Token = "0x400310F")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x857A0", Offset = "0x84BA0")]
	[FieldOffset(Offset = "0xE0")]
	private DlcCountDownControl m_Countdown;

	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	[Token(Token = "0x4003110")]
	private DlcCountDownControlStandard m_CountdownStandard;

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4003111")]
	private List<DLCSongCellControl> m_CellControls;

	[Token(Token = "0x4003113")]
	[FieldOffset(Offset = "0x100")]
	[Attribute(Name = "HeaderAttribute", RVA = "0x85AD0", Offset = "0x84ED0")]
	public Button btnPlayAlbumDes;

	[Token(Token = "0x4003114")]
	[FieldOffset(Offset = "0x108")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x4003115")]
	[FieldOffset(Offset = "0x110")]
	private Stack<DLCSongCellControl> m_CellStack;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4003116")]
	private PnlDlc m_PnlDlc;

	[SerializeField]
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4003117")]
	[Attribute(Name = "TooltipAttribute", RVA = "0x85BA0", Offset = "0x84FA0")]
	private bool isUseDefault4x3AutoSize;

	[FieldOffset(Offset = "0x124")]
	[SerializeField]
	[Attribute(Name = "HeaderAttribute", RVA = "0x85C90", Offset = "0x85090")]
	[Token(Token = "0x4003118")]
	private Vector2 m_ImgSizeBase4x3;

	[FieldOffset(Offset = "0x12C")]
	[Token(Token = "0x4003119")]
	[SerializeField]
	private Vector2 m_ImgSizeBase16x9;

	[SerializeField]
	[Token(Token = "0x400311A")]
	[FieldOffset(Offset = "0x134")]
	private Vector2 m_ImgSizeNotBill4x3;

	[SerializeField]
	[Token(Token = "0x400311B")]
	[FieldOffset(Offset = "0x13C")]
	private Vector2 m_ImgSizeNotBill16x9;

	[Token(Token = "0x170008BC")]
	public int jsonIndex
	{
		[CompilerGenerated]
		[Address(RVA = "0x427D00", Offset = "0x426500", Length = "0x7")]
		[Token(Token = "0x60052AE")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x427D20", Offset = "0x426520", Length = "0x7")]
		[Token(Token = "0x60052AF")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008BD")]
	public PnlDlc pnlDlc
	{
		[Address(RVA = "0x427D10", Offset = "0x426510", Length = "0x8")]
		[Token(Token = "0x60052B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60052B1")]
	[Address(RVA = "0x426010", Offset = "0x424810", Length = "0x122")]
	public override void Init(PnlDlc pnlDlc)
	{
	}

	[Address(RVA = "0x4263D0", Offset = "0x424BD0", Length = "0x1D0")]
	[Token(Token = "0x60052B2")]
	public override void OnItemChange(int cellIndex)
	{
	}

	[Token(Token = "0x60052B3")]
	[Address(RVA = "0x426390", Offset = "0x424B90", Length = "0x3C")]
	public override void OnFinalItemChange(bool isSelected)
	{
	}

	[Token(Token = "0x60052B4")]
	[Address(RVA = "0x425B10", Offset = "0x424310", Length = "0x1F7")]
	private void Awake()
	{
	}

	[Token(Token = "0x60052B5")]
	[Address(RVA = "0x426280", Offset = "0x424A80", Length = "0x10C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60052B6")]
	[Address(RVA = "0x427630", Offset = "0x425E30", Length = "0xCE")]
	public override void SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Token(Token = "0x60052B7")]
	[Address(RVA = "0x425D10", Offset = "0x424510", Length = "0x101")]
	public void CloseAllPlayerMask()
	{
	}

	[Address(RVA = "0x425E20", Offset = "0x424620", Length = "0xD3")]
	[Token(Token = "0x60052B8")]
	private DLCSongCellControl CreateCell()
	{
		return null;
	}

	[Address(RVA = "0x425F00", Offset = "0x424700", Length = "0x109")]
	[Token(Token = "0x60052B9")]
	private void FastDestroy()
	{
	}

	[Address(RVA = "0x426140", Offset = "0x424940", Length = "0x105")]
	[Token(Token = "0x60052BA")]
	public void OnCellClicked(DLCSongCellControl cell)
	{
	}

	[Address(RVA = "0x426770", Offset = "0x424F70", Length = "0x492")]
	[Token(Token = "0x60052BB")]
	public void Refresh(int index, bool forceRefresh = false)
	{
	}

	[Token(Token = "0x60052BC")]
	[Address(RVA = "0x426650", Offset = "0x424E50", Length = "0x99")]
	private void RecoverArknightAlpha()
	{
	}

	[Address(RVA = "0x427700", Offset = "0x425F00", Length = "0x561")]
	[Token(Token = "0x60052BD")]
	private void UIRefresh()
	{
	}

	[Address(RVA = "0x4266F0", Offset = "0x424EF0", Length = "0x77")]
	[Token(Token = "0x60052BE")]
	public override void RefreshCountDown()
	{
	}

	[Address(RVA = "0x426C10", Offset = "0x425410", Length = "0x103")]
	[Token(Token = "0x60052BF")]
	private void SetBaseSize(int i)
	{
	}

	[Address(RVA = "0x426D20", Offset = "0x425520", Length = "0x3ED")]
	[Token(Token = "0x60052C0")]
	private void SetBaseUI(DlcUIExtensionInfo dlcUIExtensionInfo, bool needChangeSize = true)
	{
	}

	[Token(Token = "0x60052C1")]
	[Address(RVA = "0x4273D0", Offset = "0x425BD0", Length = "0x251")]
	private void SetImgSizeForOverview(DlcBillboardInfo billboardInfo)
	{
	}

	[Token(Token = "0x60052C2")]
	[Address(RVA = "0x427110", Offset = "0x425910", Length = "0x14A")]
	private void SetBillboardContent(DlcBillboardInfo billboardInfo)
	{
	}

	[Token(Token = "0x60052C3")]
	[Address(RVA = "0x427260", Offset = "0x425A60", Length = "0x86")]
	private void SetBillboardUI(DlcUIExtensionInfo dlcUIExtensionInfo)
	{
	}

	[Address(RVA = "0x4272F0", Offset = "0x425AF0", Length = "0xDC")]
	[Token(Token = "0x60052C4")]
	private void SetCountDown(DlcUIExtensionInfo dlcUIExtensionInfo)
	{
	}

	[Token(Token = "0x60052C5")]
	[Address(RVA = "0x4265B0", Offset = "0x424DB0", Length = "0x94")]
	private void OnSliderActiveChanged(GameObject go, bool enable)
	{
	}

	[Token(Token = "0x60052C6")]
	[Address(RVA = "0x426250", Offset = "0x424A50", Length = "0x2D")]
	private void OnClickSetPnlDlcTip()
	{
	}

	[Token(Token = "0x60052C7")]
	[Address(RVA = "0x427C70", Offset = "0x426470", Length = "0x8B")]
	public DLCInfoSubControl()
	{
	}
}
