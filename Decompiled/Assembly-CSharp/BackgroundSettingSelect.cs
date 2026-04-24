using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D6")]
public class BackgroundSettingSelect : UISelectManage
{
	[Token(Token = "0x4000549")]
	[FieldOffset(Offset = "0x118")]
	public Assets.Scripts.PeroTools.Nice.Components.FancyScrollView imgFsv;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400054A")]
	public Slider darkSlider;

	[Token(Token = "0x400054B")]
	[FieldOffset(Offset = "0x128")]
	public GameObject darkBtnNext;

	[Token(Token = "0x400054C")]
	[FieldOffset(Offset = "0x130")]
	public GameObject darkBtnPrevious;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x400054D")]
	public Color highLight;

	[Token(Token = "0x400054E")]
	[FieldOffset(Offset = "0x148")]
	public Color normal;

	[Token(Token = "0x400054F")]
	[FieldOffset(Offset = "0x158")]
	private int m_ImgFsvIndex;

	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000550")]
	private PointsBar m_Bar;

	[Token(Token = "0x4000551")]
	[SerializeField]
	[FieldOffset(Offset = "0x168")]
	private UISetColor[] m_UiSetColors;

	[Address(RVA = "0x5F34C0", Offset = "0x5F1CC0", Length = "0x2FB")]
	[Token(Token = "0x600060A")]
	public override void OnInit()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x5F3480", Offset = "0x5F1C80", Length = "0x2C")]
	public override GameObject DefaultSelectObj()
	{
		return null;
	}

	[Address(RVA = "0x5F38B0", Offset = "0x5F20B0", Length = "0xB4")]
	[Token(Token = "0x600060C")]
	public override List<GameObject> SetSelectableObj()
	{
		return null;
	}

	[Address(RVA = "0x5F37C0", Offset = "0x5F1FC0", Length = "0xE9")]
	[Token(Token = "0x600060D")]
	protected override void OnSelect(GameObject currentObj)
	{
	}

	[Token(Token = "0x600060E")]
	[Address(RVA = "0x5F34B0", Offset = "0x5F1CB0", Length = "0x7")]
	private void OnImgFsvChange(int i)
	{
	}

	[Address(RVA = "0x4C5020", Offset = "0x4C3820", Length = "0x7")]
	[Token(Token = "0x600060F")]
	public BackgroundSettingSelect()
	{
	}
}
