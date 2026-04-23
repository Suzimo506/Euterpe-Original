using System;
using Cpp2ILInjected;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200057E")]
[Flags]
internal enum StageAchiConditionType
{
	[Token(Token = "0x4002086")]
	None = 0,
	[Token(Token = "0x4002087")]
	Punch = 1,
	[Token(Token = "0x4002088")]
	Score = 2,
	[Token(Token = "0x4002089")]
	Judge = 4,
	[Token(Token = "0x400208A")]
	Evaluate = 8,
	[Token(Token = "0x400208B")]
	Fever = 0x10,
	[Token(Token = "0x400208C")]
	Hurt = 0x20,
	[Token(Token = "0x400208D")]
	Combo = 0x40,
	[Token(Token = "0x400208E")]
	Count = 7
}
