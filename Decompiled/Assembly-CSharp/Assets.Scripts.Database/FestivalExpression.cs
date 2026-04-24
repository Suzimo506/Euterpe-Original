using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Database;

[Serializable]
[Token(Token = "0x20007A5")]
public class FestivalExpression : Expression
{
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400288B")]
	public DateTime dateFrom;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400288C")]
	public DateTime dateTo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400288D")]
	public bool ignoreYear;

	[Token(Token = "0x6004706")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public FestivalExpression()
	{
	}
}
