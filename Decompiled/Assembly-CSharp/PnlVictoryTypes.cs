using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20000B8")]
public class PnlVictoryTypes
{
	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x10")]
	public int index;

	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004CC")]
	private string m_Description;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x20")]
	public PnlVictoryControls[] controls;

	[Token(Token = "0x600055E")]
	[Address(RVA = "0x567520", Offset = "0x565D20", Length = "0xAC")]
	public PnlVictoryControls GetPnlVictoryControls(bool is43)
	{
		return null;
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public PnlVictoryTypes()
	{
	}
}
