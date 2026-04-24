using System;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using FancyScrollView;
using UnityEngine;

[Token(Token = "0x2000144")]
public class ElfinItemGroupContext : FancyGridViewContext
{
	[Token(Token = "0x40007DD")]
	[FieldOffset(Offset = "0x40")]
	public PnlElfin pnlElfin;

	[Token(Token = "0x40007DE")]
	[FieldOffset(Offset = "0x48")]
	public int selectedOrderIndex;

	[Token(Token = "0x40007DF")]
	[FieldOffset(Offset = "0x4C")]
	public int selectedIndex;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40007E0")]
	private DBConfigElfin m_ConfigElfin;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40007E1")]
	public Action<int> onCellClicked;

	[Token(Token = "0x40007E2")]
	[FieldOffset(Offset = "0x60")]
	public Action<int> onCellSelect;

	[Token(Token = "0x40007E3")]
	[FieldOffset(Offset = "0x68")]
	public ElfinItem applyElfinItemData;

	[Token(Token = "0x40007E4")]
	[FieldOffset(Offset = "0x70")]
	public GameObject lastSelectedObj;

	[Token(Token = "0x170000B3")]
	public ElfinInfo selectedElfinInfo
	{
		[Address(RVA = "0x447850", Offset = "0x446050", Length = "0x87")]
		[Token(Token = "0x6000922")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public ElfinItemGroupContext()
	{
	}
}
