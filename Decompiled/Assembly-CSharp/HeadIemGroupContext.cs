using System;
using Assets.Scripts.UI.Panels;
using Cpp2ILInjected;
using FancyScrollView;

[Token(Token = "0x2000161")]
public class HeadIemGroupContext : FancyGridViewContext
{
	[Token(Token = "0x40008AF")]
	[FieldOffset(Offset = "0x40")]
	public PnlHead pnlHead;

	[Token(Token = "0x40008B0")]
	[FieldOffset(Offset = "0x48")]
	public int selectedIndex;

	[Token(Token = "0x40008B1")]
	[FieldOffset(Offset = "0x50")]
	public Action<int> onCellClicked;

	[Token(Token = "0x40008B2")]
	[FieldOffset(Offset = "0x58")]
	public HeadItemData applyHeadData;

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x6000A1F")]
	public HeadIemGroupContext()
	{
	}
}
