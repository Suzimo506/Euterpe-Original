using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000912")]
public class CollabBundleViewController : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40030CE")]
	[SerializeField]
	private PeroScrollRect m_ScrollRect;

	[SerializeField]
	[Token(Token = "0x40030CF")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_CellPrefab;

	[Token(Token = "0x40030D0")]
	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_SubCellPrefab;

	[SerializeField]
	[Token(Token = "0x40030D1")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_PoolObjTransform;

	[Token(Token = "0x40030D2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Button m_BtnUp;

	[SerializeField]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40030D3")]
	private Button m_BtnDown;

	[Token(Token = "0x40030D4")]
	[FieldOffset(Offset = "0x48")]
	private DLCInfoCollabControl m_Parent;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40030D5")]
	private Queue<GameObject> m_PoolQueue;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40030D6")]
	private List<CollabBundleCell> m_List;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40030D7")]
	private int m_SelectedIPIndex;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40030D8")]
	private int m_SelectedPackageIndex;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40030D9")]
	private bool m_Inited;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40030DA")]
	private List<List<CollectionBundleSelectItemData>> m_CollectionDataPreIPList;

	[Token(Token = "0x40030DB")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_PrePackageNumsAtIndexList;

	[Token(Token = "0x170008B7")]
	public int selectedPackageIndexInAll
	{
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x423AD0", Offset = "0x4222D0", Length = "0x66")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x422D80", Offset = "0x421580", Length = "0x281")]
	[Token(Token = "0x600525A")]
	public void Init(DLCInfoCollabControl parent)
	{
	}

	[Address(RVA = "0x423010", Offset = "0x421810", Length = "0x2D2")]
	[Token(Token = "0x600525B")]
	public void RefreshItem(List<List<CollectionBundleSelectItemData>> collectionDataPreIPList)
	{
	}

	[Address(RVA = "0x4233C0", Offset = "0x421BC0", Length = "0x74")]
	[Token(Token = "0x600525C")]
	public void SelectCurIPIndex()
	{
	}

	[Address(RVA = "0x423500", Offset = "0x421D00", Length = "0x84")]
	[Token(Token = "0x600525D")]
	public void SelectTargetPackagerInTargetIP(int ipIndex, int packageIndex)
	{
	}

	[Address(RVA = "0x423440", Offset = "0x421C40", Length = "0xB9")]
	[Token(Token = "0x600525E")]
	public void SelectIndex(int index)
	{
	}

	[Token(Token = "0x600525F")]
	[Address(RVA = "0x423600", Offset = "0x421E00", Length = "0x178")]
	public void SetSelectedPackageIndex(int index)
	{
	}

	[Token(Token = "0x6005260")]
	[Address(RVA = "0x422BA0", Offset = "0x4213A0", Length = "0x1D9")]
	public GameObject GetSubCell(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6005261")]
	[Address(RVA = "0x4232F0", Offset = "0x421AF0", Length = "0xC1")]
	public void ReturnSubCell(GameObject subCell)
	{
	}

	[Token(Token = "0x6005262")]
	[Address(RVA = "0x4238E0", Offset = "0x4220E0", Length = "0x142")]
	private void TurnUp()
	{
	}

	[Token(Token = "0x6005263")]
	[Address(RVA = "0x423780", Offset = "0x421F80", Length = "0x15A")]
	private void TurnDown()
	{
	}

	[Address(RVA = "0x423590", Offset = "0x421D90", Length = "0x65")]
	[Token(Token = "0x6005264")]
	public void SetBtnActive(bool value)
	{
	}

	[Token(Token = "0x6005265")]
	[Address(RVA = "0x423A30", Offset = "0x422230", Length = "0x9D")]
	public CollabBundleViewController()
	{
	}
}
