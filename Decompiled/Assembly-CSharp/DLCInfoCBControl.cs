using System;
using System.Collections.Generic;
using Assets.Scripts.UI.Panels.PnlDLC;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000106")]
public class DLCInfoCBControl : DLCInfoBaseControl
{
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x15870", Offset = "0x14C70")]
	[SerializeField]
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x60")]
	private DlcBillboardControl m_BillboardControl;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000676")]
	private Dictionary<string, PackageState> pgStates;

	[SerializeField]
	[Token(Token = "0x4000677")]
	[FieldOffset(Offset = "0x70")]
	private CBScrollRect m_CbScrollRect;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000678")]
	[SerializeField]
	private CBScrollview m_CbScrollview;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000679")]
	private List<CollectionBundleSelectItemData> pgSelectDatas;

	[Token(Token = "0x400067A")]
	[FieldOffset(Offset = "0x88")]
	private int m_CellIndex;

	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400067B")]
	private bool m_IsSelected;

	[Token(Token = "0x400067C")]
	[FieldOffset(Offset = "0x90")]
	private PnlDlc m_PnlDlc;

	[Token(Token = "0x1700009E")]
	private DlcCellCBData m_DlcCellCBData
	{
		[Address(RVA = "0x46CF60", Offset = "0x46B760", Length = "0xA8")]
		[Token(Token = "0x600079B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009F")]
	public string cbUid
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x46CE60", Offset = "0x46B660", Length = "0x2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A0")]
	public string curSelectUid
	{
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x46CE90", Offset = "0x46B690", Length = "0xB5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000A1")]
	public bool isSelected
	{
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x46CF50", Offset = "0x46B750", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A2")]
	public PnlDlc pnlDlc
	{
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x46B810", Offset = "0x46A010", Length = "0x1A")]
	[Token(Token = "0x60007A0")]
	public override void Init(PnlDlc pnlDlc)
	{
	}

	[Address(RVA = "0x46CA40", Offset = "0x46B240", Length = "0x2D")]
	[Token(Token = "0x60007A1")]
	public void RefreshSelectUidInCellCbData(string uid)
	{
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0x46B9A0", Offset = "0x46A1A0", Length = "0x18A")]
	public override void OnFinalItemChange(bool isSelected)
	{
	}

	[Address(RVA = "0x46BE30", Offset = "0x46A630", Length = "0x7")]
	[Token(Token = "0x60007A3")]
	private void RefreshAfterTimeIsGet(DateTime dateTime)
	{
	}

	[Address(RVA = "0x46B600", Offset = "0x469E00", Length = "0x7C")]
	[Token(Token = "0x60007A4")]
	private void FailRefresh(long temp, string failReason)
	{
	}

	[Address(RVA = "0x46BB40", Offset = "0x46A340", Length = "0x2EB")]
	[Token(Token = "0x60007A5")]
	private void OnReset()
	{
	}

	[Address(RVA = "0x46BB30", Offset = "0x46A330", Length = "0x7")]
	[Token(Token = "0x60007A6")]
	public override void OnItemChange(int cellIndex)
	{
	}

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void RefreshCountDown()
	{
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0x46C9B0", Offset = "0x46B1B0", Length = "0x8E")]
	private void RefreshSelectItemData()
	{
	}

	[Address(RVA = "0x46C890", Offset = "0x46B090", Length = "0x11B")]
	[Token(Token = "0x60007A9")]
	public void RefreshRightShowItem()
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0x46CA70", Offset = "0x46B270", Length = "0x8A")]
	public override void SetPlayMask(int index, bool isBillboard = false)
	{
	}

	[Address(RVA = "0x46BE40", Offset = "0x46A640", Length = "0xA42")]
	[Token(Token = "0x60007AB")]
	private void RefreshAndSortItemData()
	{
	}

	[Address(RVA = "0x46B830", Offset = "0x46A030", Length = "0x162")]
	[Token(Token = "0x60007AC")]
	private bool IsSelectDatasContainsTargetUid(string targetUid)
	{
		return default(bool);
	}

	[Address(RVA = "0x46CB00", Offset = "0x46B300", Length = "0x1EB")]
	[Token(Token = "0x60007AD")]
	private void SortItemDatas()
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x46B750", Offset = "0x469F50", Length = "0x8F")]
	public CollectionBundleSelectItemData GetSelectItemDataByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x46B680", Offset = "0x469E80", Length = "0xC9")]
	public int GetIndexByUid(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x46B7E0", Offset = "0x469FE0", Length = "0x25")]
	private static int GetStatePriority(PackageState state)
	{
		return default(int);
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x46CDC0", Offset = "0x46B5C0", Length = "0x99")]
	public DLCInfoCBControl()
	{
	}
}
