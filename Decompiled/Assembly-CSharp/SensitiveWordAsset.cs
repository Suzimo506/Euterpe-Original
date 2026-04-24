using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200008B")]
[CreateAssetMenu]
public class SensitiveWordAsset : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000391")]
	public List<string> cn;

	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x20")]
	public List<string> num;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000393")]
	public List<string> eng;

	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x30")]
	public List<string> all;

	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x38")]
	public List<string> specialChar;

	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x40")]
	private List<string> m_BlockingWord;

	[Address(RVA = "0x62CFC0", Offset = "0x62B7C0", Length = "0x83")]
	[Token(Token = "0x6000403")]
	private void BlockTest(string input)
	{
	}

	[Address(RVA = "0x62D050", Offset = "0x62B850", Length = "0x51F")]
	[Token(Token = "0x6000404")]
	public string Block(string input)
	{
		return null;
	}

	[Address(RVA = "0x62D570", Offset = "0x62BD70", Length = "0x24A")]
	[Token(Token = "0x6000405")]
	public SensitiveWordAsset()
	{
	}
}
