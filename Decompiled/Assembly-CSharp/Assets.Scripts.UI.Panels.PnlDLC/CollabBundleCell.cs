using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000910")]
public class CollabBundleCell : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D9A")]
	public class ColorParameter
	{
		[Token(Token = "0x400403D")]
		[FieldOffset(Offset = "0x10")]
		public Color imgBgColor;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400403E")]
		public Color txtNameColor;

		[Token(Token = "0x400403F")]
		[FieldOffset(Offset = "0x30")]
		public Color imgSaleBgColor;

		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4004040")]
		public Color txtSalecolor;

		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		[Token(Token = "0x600652B")]
		public ColorParameter()
		{
		}
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40030A6")]
	[SerializeField]
	private RectTransform m_Rect;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40030A7")]
	private PeroScrollRect m_ScrollRect;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40030A8")]
	private Text m_TxtLabel;

	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40030A9")]
	private Image m_ImgBg;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40030AA")]
	[SerializeField]
	private Button m_Btn;

	[SerializeField]
	[Token(Token = "0x40030AB")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_SaleObj;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40030AC")]
	[SerializeField]
	private Image m_ImgSaleBg;

	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[Token(Token = "0x40030AD")]
	private Text m_TxtSale;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40030AE")]
	[SerializeField]
	private float m_AddTime;

	[SerializeField]
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x40030AF")]
	private float m_CellSizeY;

	[SerializeField]
	[Token(Token = "0x40030B0")]
	[FieldOffset(Offset = "0x60")]
	private float m_Gap;

	[SerializeField]
	[Token(Token = "0x40030B1")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_Prefab;

	[SerializeField]
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40030B2")]
	private ColorParameter m_SelectColorParameter;

	[SerializeField]
	[Token(Token = "0x40030B3")]
	[FieldOffset(Offset = "0x78")]
	private ColorParameter m_UnselectColorParameter;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40030B4")]
	private CollabBundleViewController m_Parent;

	[Token(Token = "0x40030B5")]
	[FieldOffset(Offset = "0x88")]
	private int m_Index;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40030B6")]
	private List<CollectionBundleSelectItemData> m_DataList;

	[Token(Token = "0x40030B7")]
	[FieldOffset(Offset = "0x98")]
	private List<CollabBundleSubCell> m_SubCells;

	[Token(Token = "0x40030B8")]
	[FieldOffset(Offset = "0xA0")]
	private int m_SelectedIndex;

	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40030B9")]
	private bool m_IsSelected;

	[Token(Token = "0x40030BA")]
	[FieldOffset(Offset = "0xA8")]
	private Tween m_Tween;

	[Token(Token = "0x6005240")]
	[Address(RVA = "0x4214A0", Offset = "0x41FCA0", Length = "0x9D")]
	public void Init(CollabBundleViewController parent)
	{
	}

	[Token(Token = "0x6005241")]
	[Address(RVA = "0x4219A0", Offset = "0x4201A0", Length = "0x108")]
	public void SetData(int index, LocalCollabBundle localData, List<CollectionBundleSelectItemData> list)
	{
	}

	[Token(Token = "0x6005242")]
	[Address(RVA = "0x4217D0", Offset = "0x41FFD0", Length = "0x1C1")]
	private void ResetSubCellData()
	{
	}

	[Token(Token = "0x6005243")]
	[Address(RVA = "0x421BA0", Offset = "0x4203A0", Length = "0x183")]
	public void SetSelected(bool value)
	{
	}

	[Address(RVA = "0x421D30", Offset = "0x420530", Length = "0x19F")]
	[Token(Token = "0x6005244")]
	private void ToTargetCount(int count)
	{
	}

	[Token(Token = "0x6005245")]
	[Address(RVA = "0x4210D0", Offset = "0x41F8D0", Length = "0x1D8")]
	private void AddElement(int index)
	{
	}

	[Token(Token = "0x6005246")]
	[Address(RVA = "0x4215C0", Offset = "0x41FDC0", Length = "0x204")]
	private void RemoveElement(int index)
	{
	}

	[Token(Token = "0x6005247")]
	[Address(RVA = "0x4212B0", Offset = "0x41FAB0", Length = "0x1E8")]
	private void CollectionBundleHandle()
	{
	}

	[Address(RVA = "0x421AB0", Offset = "0x4202B0", Length = "0xED")]
	[Token(Token = "0x6005248")]
	public void SetSelectedByIndex(int index)
	{
	}

	[Token(Token = "0x6005249")]
	[Address(RVA = "0x421540", Offset = "0x41FD40", Length = "0x77")]
	public bool IsMoveBound(bool isUp)
	{
		return default(bool);
	}

	[Token(Token = "0x600524A")]
	[Address(RVA = "0x421F00", Offset = "0x420700", Length = "0x7D")]
	public CollabBundleCell()
	{
	}
}
