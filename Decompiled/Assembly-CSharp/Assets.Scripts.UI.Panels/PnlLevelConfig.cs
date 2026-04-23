using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels;

[Token(Token = "0x20008E7")]
public class PnlLevelConfig : BaseMessageBox
{
	[Token(Token = "0x2000D7C")]
	private enum Direction
	{
		[Token(Token = "0x4003FDF")]
		Up,
		[Token(Token = "0x4003FE0")]
		Down,
		[Token(Token = "0x4003FE1")]
		Left,
		[Token(Token = "0x4003FE2")]
		Right
	}

	[FieldOffset(Offset = "0xF0")]
	[Token(Token = "0x4002F4C")]
	public LevelConfigGridView levelConfigGridView;

	[Token(Token = "0x4002F4D")]
	[FieldOffset(Offset = "0xF8")]
	private string m_CurSelectLevelConfigType;

	[Attribute(Name = "HeaderAttribute", RVA = "0x5FBC0", Offset = "0x5EFC0")]
	[Token(Token = "0x4002F4E")]
	[FieldOffset(Offset = "0x100")]
	public List<Toggle> toggles;

	[Token(Token = "0x4002F4F")]
	[FieldOffset(Offset = "0x108")]
	public Color colorToggleOn;

	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4002F50")]
	public Color colorToggleOff;

	[Token(Token = "0x4002F51")]
	[FieldOffset(Offset = "0x128")]
	public Color colorToggleTextOn;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4002F52")]
	public Color colorToggleTextOff;

	[Token(Token = "0x4002F53")]
	[FieldOffset(Offset = "0x148")]
	private PnlLevelConfigSelect m_LevelConfigSelect;

	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4002F54")]
	[SerializeField]
	private Button m_BtnSpeClose;

	[Token(Token = "0x4002F55")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Button m_BtnSpeConfirm;

	[Token(Token = "0x4002F56")]
	[FieldOffset(Offset = "0x160")]
	private List<LevelConfigItemData> listCharacterDatasSorted;

	[Token(Token = "0x4002F57")]
	[FieldOffset(Offset = "0x168")]
	private List<LevelConfigItemData> listElfinDatasSorted;

	[Token(Token = "0x4002F58")]
	[FieldOffset(Offset = "0x170")]
	public Button btnQ;

	[Token(Token = "0x4002F59")]
	[FieldOffset(Offset = "0x178")]
	public Button btnE;

	[Token(Token = "0x4002F5A")]
	[FieldOffset(Offset = "0x180")]
	private LevelConfigSelectionData m_LevelConfigSelectionData;

	[Token(Token = "0x4002F5B")]
	private static Dictionary<string, Sprite> m_SpriteCache;

	[Token(Token = "0x170008A3")]
	public Button BtnSpeConfirm
	{
		[Address(RVA = "0x832820", Offset = "0x831020", Length = "0x8")]
		[Token(Token = "0x60050B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A4")]
	public LevelConfigSelectionData LevelConfigSelectionData
	{
		[Address(RVA = "0x682270", Offset = "0x680A70", Length = "0x8")]
		[Token(Token = "0x60050B1")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A5")]
	public string curSelectLevelConfigType
	{
		[Address(RVA = "0x4E8C50", Offset = "0x4E7450", Length = "0x8")]
		[Token(Token = "0x60050B2")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60050B3")]
	[Address(RVA = "0x830430", Offset = "0x82EC30", Length = "0x5E")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60050B4")]
	[Address(RVA = "0x830490", Offset = "0x82EC90", Length = "0x4D8")]
	private void GenerateCellDatas()
	{
	}

	[Address(RVA = "0x831F50", Offset = "0x830750", Length = "0x4FC")]
	[Token(Token = "0x60050B5")]
	private void SortCell()
	{
	}

	[Address(RVA = "0x830E70", Offset = "0x82F670", Length = "0x245")]
	[Token(Token = "0x60050B6")]
	private void InitBtn()
	{
	}

	[Token(Token = "0x60050B7")]
	[Address(RVA = "0x831AF0", Offset = "0x8302F0", Length = "0xF")]
	public void SetLevelConfigSelectionData(LevelConfigSelectionData levelConfigSelectionData)
	{
	}

	[Address(RVA = "0x831E70", Offset = "0x830670", Length = "0xD8")]
	[Token(Token = "0x60050B8")]
	public override void Show()
	{
	}

	[Address(RVA = "0x8317A0", Offset = "0x82FFA0", Length = "0x141")]
	[Token(Token = "0x60050B9")]
	public void RefreshNavigation()
	{
	}

	[Token(Token = "0x60050BA")]
	[Address(RVA = "0x8318F0", Offset = "0x8300F0", Length = "0x1F4")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x60050BB")]
	[Address(RVA = "0x831520", Offset = "0x82FD20", Length = "0x274")]
	private void OnToggleValueChange(bool isOn)
	{
	}

	[Token(Token = "0x60050BC")]
	[Address(RVA = "0x831480", Offset = "0x82FC80", Length = "0x9B")]
	private void OnSpeConfirmBtnClick()
	{
	}

	[Token(Token = "0x60050BD")]
	[Address(RVA = "0x8312D0", Offset = "0x82FAD0", Length = "0x1A5")]
	private void OnSpeCloseBtnClick()
	{
	}

	[Token(Token = "0x60050BE")]
	[Address(RVA = "0x8302D0", Offset = "0x82EAD0", Length = "0x154")]
	private void ApplySelectionData()
	{
	}

	[Address(RVA = "0x831B00", Offset = "0x830300", Length = "0x265")]
	[Token(Token = "0x60050BF")]
	private void SetupNavigation(List<RectTransform> listemp)
	{
	}

	[Token(Token = "0x60050C0")]
	[Address(RVA = "0x830970", Offset = "0x82F170", Length = "0x3C3")]
	private Selectable GetNearestInDirection(RectTransform currentRect, List<RectTransform> list, Direction direction)
	{
		return null;
	}

	[Token(Token = "0x60050C1")]
	[Address(RVA = "0x831270", Offset = "0x82FA70", Length = "0x5E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60050C2")]
	[Address(RVA = "0x8310C0", Offset = "0x82F8C0", Length = "0x1A9")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60050C3")]
	[Address(RVA = "0x830D40", Offset = "0x82F540", Length = "0x123")]
	public static Sprite GetSprite(string key)
	{
		return null;
	}

	[Token(Token = "0x60050C4")]
	[Address(RVA = "0x831D70", Offset = "0x830570", Length = "0xF6")]
	public static void ShowLevelConfigSelect(LevelConfigSelectionData opts)
	{
	}

	[Address(RVA = "0x832730", Offset = "0x830F30", Length = "0xE2")]
	[Token(Token = "0x60050C5")]
	public PnlLevelConfig()
	{
	}
}
