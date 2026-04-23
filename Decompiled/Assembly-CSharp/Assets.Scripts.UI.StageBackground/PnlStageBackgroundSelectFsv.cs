using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.StageBackground;

[Token(Token = "0x2000831")]
public class PnlStageBackgroundSelectFsv : PnlStageBackgroundSelectBase
{
	[Token(Token = "0x4002AA6")]
	private const float scroll_to_cell_duration = 0.1f;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002AA7")]
	[SerializeField]
	private GameObject m_FsvCell;

	[Token(Token = "0x4002AA8")]
	[FieldOffset(Offset = "0x38")]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_SelectFsv;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002AA9")]
	private bool m_FsvIsScrolling;

	[Token(Token = "0x1700083F")]
	public bool FsvIsScrolling
	{
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		[Token(Token = "0x6004B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004B61")]
	[Address(RVA = "0x615AB0", Offset = "0x6142B0", Length = "0x121")]
	public override void Init()
	{
	}

	[Address(RVA = "0x615EF0", Offset = "0x6146F0", Length = "0xF1")]
	[Token(Token = "0x6004B62")]
	public override void Release()
	{
	}

	[Address(RVA = "0x6161A0", Offset = "0x6149A0", Length = "0xCB")]
	[Token(Token = "0x6004B63")]
	public override void ScrollToCell(int cellIndex)
	{
	}

	[Token(Token = "0x6004B64")]
	[Address(RVA = "0x6160B0", Offset = "0x6148B0", Length = "0xE2")]
	public override void ScrollToCell(string cellPos)
	{
	}

	[Address(RVA = "0x615FF0", Offset = "0x6147F0", Length = "0xBD")]
	[Token(Token = "0x6004B65")]
	public override void ScrollAndSelectCell(StageBackgroundSelectCell selectCell)
	{
	}

	[Address(RVA = "0x615DF0", Offset = "0x6145F0", Length = "0xF7")]
	[Token(Token = "0x6004B66")]
	public override void RefreshCellState(List<StageBackgroundData> bgDataList)
	{
	}

	[Address(RVA = "0x615DA0", Offset = "0x6145A0", Length = "0x45")]
	[Token(Token = "0x6004B67")]
	private void OnScrolling(Assets.Scripts.PeroTools.Nice.Components.FancyScrollView.State state)
	{
	}

	[Address(RVA = "0x615BE0", Offset = "0x6143E0", Length = "0xFF")]
	[Token(Token = "0x6004B68")]
	private void OnCellIndexSelect(int cellIndex)
	{
	}

	[Address(RVA = "0x615CE0", Offset = "0x6144E0", Length = "0xBF")]
	[Token(Token = "0x6004B69")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6004B6A")]
	public PnlStageBackgroundSelectFsv()
	{
	}
}
