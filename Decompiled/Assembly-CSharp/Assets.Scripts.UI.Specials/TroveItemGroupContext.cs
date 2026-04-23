using System;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Token(Token = "0x2000864")]
public class TroveItemGroupContext : FancyGridViewContext
{
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002BCE")]
	public PnlTroves pnlTroves;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002BCF")]
	public ToggleGroup toggleGroup;

	[Token(Token = "0x4002BD0")]
	[FieldOffset(Offset = "0x50")]
	public int selectedIndex;

	[Token(Token = "0x4002BD1")]
	[FieldOffset(Offset = "0x58")]
	public PnlTroveItem selectedTroveItem;

	[Token(Token = "0x4002BD2")]
	[FieldOffset(Offset = "0x60")]
	public Action<int> onCellClicked;

	[Token(Token = "0x4002BD3")]
	[FieldOffset(Offset = "0x68")]
	public Action<int> onCellSelect;

	[Token(Token = "0x4002BD4")]
	[FieldOffset(Offset = "0x70")]
	public int cellCount;

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6004CBD")]
	public TroveItemGroupContext()
	{
	}
}
