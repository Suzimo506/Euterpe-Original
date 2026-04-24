using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.GeneralLocalization;

[Token(Token = "0x2000661")]
public class Scheme
{
	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0x10")]
	public OptionEntry activeOption;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40023BF")]
	public List<GlobalOptionPair> optionPairs;

	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0x20")]
	public SchemeEntry schemeEntry;

	[Token(Token = "0x6003D49")]
	[Address(RVA = "0x7624D0", Offset = "0x760CD0", Length = "0x1DA")]
	public string GetOptionName(int index)
	{
		return null;
	}

	[Address(RVA = "0x7623C0", Offset = "0x760BC0", Length = "0x102")]
	[Token(Token = "0x6003D4A")]
	public List<string> GetAllOptionsName()
	{
		return null;
	}

	[Address(RVA = "0x7622D0", Offset = "0x760AD0", Length = "0xE1")]
	[Token(Token = "0x6003D4B")]
	public void GetAllOptionsName(List<string> list)
	{
	}

	[Token(Token = "0x6003D4C")]
	[Address(RVA = "0x762210", Offset = "0x760A10", Length = "0xB4")]
	public bool Exist(string optionName)
	{
		return default(bool);
	}

	[Address(RVA = "0x7626B0", Offset = "0x760EB0", Length = "0x3C")]
	[Token(Token = "0x6003D4D")]
	public int OptionCount()
	{
		return default(int);
	}

	[Address(RVA = "0x7626F0", Offset = "0x760EF0", Length = "0x69")]
	[Token(Token = "0x6003D4E")]
	public Scheme()
	{
	}
}
