using System.Collections.Generic;
using Cpp2ILInjected;
using FormulaBase;

namespace Assets.Factorys;

[Token(Token = "0x2000568")]
public struct TimeNodeOrderResult
{
	[Token(Token = "0x4001FE9")]
	[FieldOffset(Offset = "0x0")]
	public Dictionary<int, List<TimeNodeOrder>> tnos;

	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4001FEA")]
	public int lastTnoIndex;

	[Token(Token = "0x4001FEB")]
	[FieldOffset(Offset = "0xC")]
	public decimal lastTnoTime;
}
