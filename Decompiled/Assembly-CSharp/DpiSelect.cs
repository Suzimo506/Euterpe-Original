using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000E2")]
public class DpiSelect : UISelectManage
{
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x40005A3")]
	public Button btnCancel;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x40005A4")]
	public Color highLight;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x40005A5")]
	public Color normal;

	[Token(Token = "0x40005A6")]
	[FieldOffset(Offset = "0x140")]
	public Color textUnselectColor;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x40005A7")]
	private Image m_SelectBtnImg;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40005A8")]
	private Button m_SelectBtn;

	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private RectTransform m_ToggleGroupRectTrans;

	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Token(Token = "0x40005AA")]
	private Text m_TxtTop;

	[FieldOffset(Offset = "0x170")]
	[Token(Token = "0x40005AB")]
	[SerializeField]
	private Image m_ImgArrow;

	[Token(Token = "0x40005AC")]
	[SerializeField]
	[FieldOffset(Offset = "0x178")]
	private GameObject m_DpiItemPrefab;

	[SerializeField]
	[Token(Token = "0x40005AD")]
	[FieldOffset(Offset = "0x180")]
	private GridLayoutGroup m_ContentFridLayoutGroup;

	[Token(Token = "0x40005AE")]
	[FieldOffset(Offset = "0x188")]
	private List<DpiItem> m_DpiItems;

	[FieldOffset(Offset = "0x190")]
	[Token(Token = "0x40005AF")]
	private FastPool m_PoolDpiItem;

	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40005B0")]
	private List<GameObject> m_SelectableItems;

	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x1A0")]
	private List<Vector2Int> m_DefinedAndSupportDpis;

	[Token(Token = "0x17000090")]
	private List<Vector2Int> m_CurModeDpis
	{
		[Address(RVA = "0x4457E0", Offset = "0x443FE0", Length = "0x9D")]
		[Token(Token = "0x6000682")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000091")]
	private bool m_IsFullScreen
	{
		[Address(RVA = "0x445900", Offset = "0x444100", Length = "0x71")]
		[Token(Token = "0x6000683")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000092")]
	private bool m_HasBorder
	{
		[Address(RVA = "0x445880", Offset = "0x444080", Length = "0x71")]
		[Token(Token = "0x6000684")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x443FA0", Offset = "0x4427A0", Length = "0x472")]
	public void Init()
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x444740", Offset = "0x442F40", Length = "0x1F")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x444630", Offset = "0x442E30", Length = "0x10A")]
	[Token(Token = "0x6000687")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x444560", Offset = "0x442D60", Length = "0xCF")]
	[Token(Token = "0x6000688")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x444AB0", Offset = "0x4432B0", Length = "0x19A")]
	[Token(Token = "0x6000689")]
	public void RefreshTopTextAndArrowColor()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x444FD0", Offset = "0x4437D0", Length = "0x43A")]
	private void ShrinkOrSelectDpiItem()
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x444870", Offset = "0x443070", Length = "0x1F")]
	public void RefreshCurSelectedDpi()
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x445640", Offset = "0x443E40", Length = "0xC6")]
	private void UnSelectToggleGroup()
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x444C50", Offset = "0x443450", Length = "0x179")]
	private void SetNewDpiItem()
	{
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x4434E0", Offset = "0x441CE0", Length = "0x115")]
	private void DeselectAllDpiItemCheckMark()
	{
	}

	[Address(RVA = "0x443600", Offset = "0x441E00", Length = "0x511")]
	[Token(Token = "0x600068F")]
	private void GenerateDpiItem()
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x445410", Offset = "0x443C10", Length = "0x1B9")]
	private void SupportResolutionFilter()
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0x444FC0", Offset = "0x4437C0", Length = "0x8")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x444760", Offset = "0x442F60", Length = "0xA3")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Address(RVA = "0x443D20", Offset = "0x442520", Length = "0x58")]
	[Token(Token = "0x6000693")]
	public DpiItem GetDpiItemFormPool(Transform parent)
	{
		return null;
	}

	[Address(RVA = "0x444810", Offset = "0x443010", Length = "0x55")]
	[Token(Token = "0x6000694")]
	public void RecycleDpiItem(DpiItem dpiItem)
	{
	}

	[Address(RVA = "0x444890", Offset = "0x443090", Length = "0x176")]
	[Token(Token = "0x6000695")]
	private void RefreshHeight()
	{
	}

	[Address(RVA = "0x444A10", Offset = "0x443210", Length = "0x97")]
	[Token(Token = "0x6000696")]
	private void RefreshShowItem()
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x444DD0", Offset = "0x4435D0", Length = "0x1EB")]
	private void SetNewResolution(Vector2Int resolution)
	{
	}

	[Address(RVA = "0x443E00", Offset = "0x442600", Length = "0x198")]
	[Token(Token = "0x6000698")]
	private int GetSaveDataDpiIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x443B20", Offset = "0x442320", Length = "0xE8")]
	private int GetCurModeIndex(int x, int y)
	{
		return default(int);
	}

	[Address(RVA = "0x444420", Offset = "0x442C20", Length = "0x138")]
	[Token(Token = "0x600069A")]
	private bool IsSaveDataDpiItemChange(ref DpiItem curSelectDpiItem)
	{
		return default(bool);
	}

	[Address(RVA = "0x443D80", Offset = "0x442580", Length = "0x7E")]
	[Token(Token = "0x600069B")]
	public static string GetResolutionsUid(Vector2 resolution)
	{
		return null;
	}

	[Address(RVA = "0x443C10", Offset = "0x442410", Length = "0x108")]
	[Token(Token = "0x600069C")]
	public static Vector2Int GetCurSelectResolution()
	{
		return default(Vector2Int);
	}

	[Address(RVA = "0x445710", Offset = "0x443F10", Length = "0xCC")]
	[Token(Token = "0x600069D")]
	public DpiSelect()
	{
	}
}
