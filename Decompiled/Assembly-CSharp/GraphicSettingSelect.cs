using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000E7")]
public class GraphicSettingSelect : UISelectManage
{
	[Token(Token = "0x40005B8")]
	[FieldOffset(Offset = "0x118")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView dpiFullScreen;

	[Token(Token = "0x40005B9")]
	[FieldOffset(Offset = "0x120")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView dpiWindow;

	[Token(Token = "0x40005BA")]
	[FieldOffset(Offset = "0x128")]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenMode;

	[Token(Token = "0x40005BB")]
	[FieldOffset(Offset = "0x130")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenMode_Win;

	[Token(Token = "0x40005BC")]
	[FieldOffset(Offset = "0x138")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView screenMode_Mac;

	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x140")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView fpsFsv;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x40005BE")]
	public GameObject confirm;

	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x150")]
	public GameObject enterBackgroundBtn;

	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x40005C0")]
	public GameObject enterBackgroundSelectImg;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x40005C1")]
	public GameObject feverSettingBtn;

	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x40005C2")]
	public GameObject feverSettingSelectImg;

	[Token(Token = "0x40005C3")]
	[FieldOffset(Offset = "0x170")]
	public DpiSelect dpiSelect;

	[Token(Token = "0x40005C4")]
	[FieldOffset(Offset = "0x178")]
	public Color highlightColor;

	[FieldOffset(Offset = "0x188")]
	[Token(Token = "0x40005C5")]
	public Color normalColor;

	[FieldOffset(Offset = "0x198")]
	[Token(Token = "0x40005C6")]
	public Color m_SpColor;

	[Token(Token = "0x40005C7")]
	[SerializeField]
	[FieldOffset(Offset = "0x1A8")]
	private List<UISetColor> m_UiSetColors;

	[FieldOffset(Offset = "0x1B0")]
	[Token(Token = "0x40005C8")]
	private int m_DpiFullScreenIndex;

	[Token(Token = "0x40005C9")]
	[FieldOffset(Offset = "0x1B4")]
	private int m_DpiWindowIndex;

	[Token(Token = "0x40005CA")]
	[FieldOffset(Offset = "0x1B8")]
	private int m_ScreenModeIndex;

	[FieldOffset(Offset = "0x1BC")]
	[Token(Token = "0x40005CB")]
	private bool m_IsFullScreen;

	[FieldOffset(Offset = "0x1BD")]
	[Token(Token = "0x40005CC")]
	private bool m_HasBorder;

	[FieldOffset(Offset = "0x1BE")]
	[Token(Token = "0x40005CD")]
	private bool m_IsInit;

	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40005CE")]
	public AudioClip optionBgmClip;

	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x1C8")]
	private Vector2Int[] m_FullScreenResolutions;

	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x1D0")]
	private Vector2Int[] m_WindowsResolutions;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x1D8")]
	private int[] m_Fps;

	[Address(RVA = "0x5C2700", Offset = "0x5C0F00", Length = "0x6AB")]
	[Token(Token = "0x60006AD")]
	public override void OnInit()
	{
	}

	[Address(RVA = "0x5C2540", Offset = "0x5C0D40", Length = "0x44")]
	[Token(Token = "0x60006AE")]
	public override void OnEnablePnl()
	{
	}

	[Address(RVA = "0x5C1C60", Offset = "0x5C0460", Length = "0x2D")]
	[Token(Token = "0x60006AF")]
	public override void AfterSelectDefaultObj()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60006B0")]
	private void OnFullScreenDpiChange(int i)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60006B1")]
	private void OnWindowDpiChange(int i)
	{
	}

	[Token(Token = "0x60006B2")]
	[Address(RVA = "0x5C2DB0", Offset = "0x5C15B0", Length = "0x220")]
	private void OnScreenModeChange(int i)
	{
	}

	[Address(RVA = "0x5C2590", Offset = "0x5C0D90", Length = "0x16E")]
	[Token(Token = "0x60006B3")]
	private void OnFpsChange(int i)
	{
	}

	[Address(RVA = "0x5C2090", Offset = "0x5C0890", Length = "0x30D")]
	[Token(Token = "0x60006B4")]
	private void OnClickConfirm()
	{
	}

	[Address(RVA = "0x5C1C90", Offset = "0x5C0490", Length = "0x30")]
	[Token(Token = "0x60006B5")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x5C23A0", Offset = "0x5C0BA0", Length = "0x197")]
	[Token(Token = "0x60006B6")]
	public override void OnDisablePnl()
	{
	}

	[Address(RVA = "0x5C3290", Offset = "0x5C1A90", Length = "0x27A")]
	[Token(Token = "0x60006B7")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x5C2FE0", Offset = "0x5C17E0", Length = "0x27D")]
	[Token(Token = "0x60006B8")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x5C1FA0", Offset = "0x5C07A0", Length = "0xEA")]
	private Vector2Int GetResolutions(string uid)
	{
		return default(Vector2Int);
	}

	[Address(RVA = "0x5C1F20", Offset = "0x5C0720", Length = "0x7E")]
	[Token(Token = "0x60006BA")]
	private string GetResolutionsUid(Vector2 resolution)
	{
		return null;
	}

	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x5C1DA0", Offset = "0x5C05A0", Length = "0x17E")]
	private int GetResolutionsIndex(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x5C1CD0", Offset = "0x5C04D0", Length = "0xC2")]
	private int GetFpsIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x5C3260", Offset = "0x5C1A60", Length = "0x20")]
	public override Transform SetEdgeObj(GameObject currentObj)
	{
		return null;
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x5C3510", Offset = "0x5C1D10", Length = "0x44E")]
	public GraphicSettingSelect()
	{
	}
}
