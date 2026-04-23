using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x200091B")]
public class DLCInfoCollabControl : DLCInfoBaseControl
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40030F2")]
	[SerializeField]
	private CBScrollview m_CbScrollview;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40030F3")]
	[SerializeField]
	private CollabBundleViewController m_CollabView;

	[Token(Token = "0x40030F4")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsSelected;

	[Token(Token = "0x40030F5")]
	[FieldOffset(Offset = "0x78")]
	private PnlDlc m_PnlDlc;

	[Token(Token = "0x40030F6")]
	[FieldOffset(Offset = "0x80")]
	private int m_CellIndex;

	[Token(Token = "0x40030F7")]
	[FieldOffset(Offset = "0x88")]
	private DBConfigAlbums dbAlbum;

	[Token(Token = "0x40030F8")]
	[FieldOffset(Offset = "0x90")]
	private List<CollectionBundleSelectItemData> m_PgSelectDatas;

	[Token(Token = "0x40030F9")]
	[FieldOffset(Offset = "0x98")]
	private List<List<CollectionBundleSelectItemData>> m_CollectionDataPreIPList;

	[Token(Token = "0x170008BB")]
	private DlcCellCollabData m_DlcCellCollabData
	{
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x4257C0", Offset = "0x423FC0", Length = "0xA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005295")]
	[Address(RVA = "0x424D20", Offset = "0x423520", Length = "0x137")]
	public override void OnFinalItemChange(bool isSelected)
	{
	}

	[Address(RVA = "0x424E60", Offset = "0x423660", Length = "0x7")]
	[Token(Token = "0x6005296")]
	public override void OnItemChange(int cellIndex)
	{
	}

	[Token(Token = "0x6005297")]
	[Address(RVA = "0x424F70", Offset = "0x423770", Length = "0x7")]
	private void RefreshAfterTimeIsGet(DateTime dateTime)
	{
	}

	[Token(Token = "0x6005298")]
	[Address(RVA = "0x424C50", Offset = "0x423450", Length = "0x7C")]
	private void FailRefresh(long temp, string failReason)
	{
	}

	[Token(Token = "0x6005299")]
	[Address(RVA = "0x424E70", Offset = "0x423670", Length = "0xF9")]
	private void OnReset()
	{
	}

	[Token(Token = "0x600529A")]
	[Address(RVA = "0x424CD0", Offset = "0x4234D0", Length = "0x4D")]
	public override void Init(PnlDlc pnlDlc)
	{
	}

	[Token(Token = "0x600529B")]
	[Address(RVA = "0x424F80", Offset = "0x423780", Length = "0x415")]
	private void RefreshItemData()
	{
	}

	[Address(RVA = "0x424900", Offset = "0x423100", Length = "0x106")]
	[Token(Token = "0x600529C")]
	private void AddAlbumPackage(string uid, int ipIndex)
	{
	}

	[Address(RVA = "0x424A10", Offset = "0x423210", Length = "0x16B")]
	[Token(Token = "0x600529D")]
	private void AddCollectionBundlePackage(string uid, int ipIndex)
	{
	}

	[Address(RVA = "0x424B80", Offset = "0x423380", Length = "0xCE")]
	[Token(Token = "0x600529E")]
	private void AddDataItemToList(PackageState state, bool isCollectionBundle, string uid, int ipIndex)
	{
	}

	[Address(RVA = "0x4255B0", Offset = "0x423DB0", Length = "0x14E")]
	[Token(Token = "0x600529F")]
	private void SortDataList()
	{
	}

	[Token(Token = "0x60052A0")]
	[Address(RVA = "0x425700", Offset = "0x423F00", Length = "0x1D")]
	private int SortDataRuler(CollectionBundleSelectItemData data1, CollectionBundleSelectItemData data2)
	{
		return default(int);
	}

	[Token(Token = "0x60052A1")]
	[Address(RVA = "0x425480", Offset = "0x423C80", Length = "0xCC")]
	public void RefreshSelectUidInCellCbDataByIndex(int index)
	{
	}

	[Token(Token = "0x60052A2")]
	[Address(RVA = "0x425430", Offset = "0x423C30", Length = "0x4D")]
	public void RefreshSelectIPIndexAndPackageIndex(int ipIndex, int packageIndex)
	{
	}

	[Address(RVA = "0x4253A0", Offset = "0x423BA0", Length = "0x89")]
	[Token(Token = "0x60052A3")]
	public void RefreshRightShowItem()
	{
	}

	[Token(Token = "0x60052A4")]
	[Address(RVA = "0x425550", Offset = "0x423D50", Length = "0x54")]
	public override void SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Token(Token = "0x60052A5")]
	[Address(RVA = "0x425720", Offset = "0x423F20", Length = "0x9C")]
	public DLCInfoCollabControl()
	{
	}
}
