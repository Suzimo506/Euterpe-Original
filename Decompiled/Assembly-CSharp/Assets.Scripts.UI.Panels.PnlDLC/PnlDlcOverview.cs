using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Components;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000942")]
public class PnlDlcOverview : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003239")]
	[FieldOffset(Offset = "0x18")]
	private PnlDlc m_Parent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400323A")]
	[SerializeField]
	private Assets.Scripts.PeroTools.Nice.Components.FancyScrollView m_OverviewFsv;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400323B")]
	private List<IPnlDlcCellData> m_DisplayCellDataList;

	[Address(RVA = "0x82A6D0", Offset = "0x828ED0", Length = "0x16D")]
	[Token(Token = "0x600542A")]
	public void Init()
	{
	}

	[Address(RVA = "0x82A840", Offset = "0x829040", Length = "0x69")]
	[Token(Token = "0x600542B")]
	public PnlDlcOverview()
	{
	}
}
