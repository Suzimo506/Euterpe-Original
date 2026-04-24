using System;
using Assets.Scripts.Structs;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000CE")]
public class PnlTerminalTips : BaseMessageBox
{
	[SerializeField]
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0xF0")]
	private Text m_TxtItemTypes;

	[FieldOffset(Offset = "0xF8")]
	[Token(Token = "0x4000508")]
	[SerializeField]
	private Text m_TxtItemNames;

	[SerializeField]
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x100")]
	private ContentSizeFitter m_MainWindowCzf;

	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x400050A")]
	[SerializeField]
	private ContentSizeFitter m_TxtContainterCzf;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x110")]
	private ExchangeItem m_Args;

	[Obsolete]
	[Address(RVA = "0x563FA0", Offset = "0x5627A0", Length = "0x18")]
	[Token(Token = "0x60005CC")]
	public void SetArgs(ExchangeItem args)
	{
	}

	[Address(RVA = "0x563FC0", Offset = "0x5627C0", Length = "0x2AB")]
	[Token(Token = "0x60005CD")]
	public void SetItemInfos(ExchangeItem[] items)
	{
	}

	[Address(RVA = "0x564270", Offset = "0x562A70", Length = "0x6F")]
	[Token(Token = "0x60005CE")]
	public override void Show()
	{
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x563780", Offset = "0x561F80", Length = "0x7E8")]
	private void GetMessage(ExchangeItem item, out string itemType, out string itemName)
	{
		itemType = null;
		itemName = null;
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x4C6980", Offset = "0x4C5180", Length = "0x7")]
	public PnlTerminalTips()
	{
	}
}
