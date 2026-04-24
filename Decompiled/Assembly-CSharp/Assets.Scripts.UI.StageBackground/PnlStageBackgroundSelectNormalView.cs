using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000832")]
public class PnlStageBackgroundSelectNormalView : PnlStageBackgroundSelectBase
{
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002AAA")]
	[SerializeField]
	private StageBackgroundSelectCell m_BgCellPref;

	[Token(Token = "0x4002AAB")]
	[SerializeField]
	[FieldOffset(Offset = "0x38")]
	private Transform m_Contents;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002AAC")]
	[SerializeField]
	private RectTransform m_SelectViewRectTransformTrans;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002AAD")]
	private List<StageBackgroundSelectCell> m_BgCellList;

	[Address(RVA = "0x616A70", Offset = "0x615270", Length = "0x137")]
	[Token(Token = "0x6004B6C")]
	public override void ScrollToCell(int cellIndex)
	{
	}

	[Token(Token = "0x6004B6D")]
	[Address(RVA = "0x616920", Offset = "0x615120", Length = "0x14B")]
	public override void ScrollToCell(string cellPos)
	{
	}

	[Token(Token = "0x6004B6E")]
	[Address(RVA = "0x616840", Offset = "0x615040", Length = "0xD5")]
	public override void ScrollAndSelectCell(StageBackgroundSelectCell selectCell)
	{
	}

	[Token(Token = "0x6004B6F")]
	[Address(RVA = "0x616350", Offset = "0x614B50", Length = "0x31C")]
	public override void RefreshCellState(List<StageBackgroundData> bgDataList)
	{
	}

	[Token(Token = "0x6004B70")]
	[Address(RVA = "0x616270", Offset = "0x614A70", Length = "0xDE")]
	private void AdaptViewWidth()
	{
	}

	[Token(Token = "0x6004B71")]
	[Address(RVA = "0x616670", Offset = "0x614E70", Length = "0x1C5")]
	public override void Release()
	{
	}

	[Token(Token = "0x6004B72")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlStageBackgroundSelectNormalView()
	{
	}
}
