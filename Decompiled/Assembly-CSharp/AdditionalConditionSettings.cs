using System;
using Cpp2ILInjected;

[Serializable]
[Token(Token = "0x2000053")]
public class AdditionalConditionSettings
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40001EA")]
	public bool isSupSelectOn;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40001EB")]
	public DifficultyFilterDefines conditionFilter;

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x590A80", Offset = "0x58F280", Length = "0x7")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public AdditionalConditionSettings()
	{
	}
}
