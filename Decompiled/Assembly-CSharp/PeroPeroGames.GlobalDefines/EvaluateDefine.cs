using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace PeroPeroGames.GlobalDefines;

[StructLayout((LayoutKind)0, Size = 1)]
[Token(Token = "0x2000511")]
public struct EvaluateDefine
{
	[Token(Token = "0x4001C80")]
	public const int evaluate_d = 0;

	[Token(Token = "0x4001C81")]
	public const int evaluate_c = 1;

	[Token(Token = "0x4001C82")]
	public const int evaluate_b = 2;

	[Token(Token = "0x4001C83")]
	public const int evaluate_a = 3;

	[Token(Token = "0x4001C84")]
	public const int evaluate_s = 4;

	[Token(Token = "0x4001C85")]
	public const int evaluate_ss = 5;

	[Token(Token = "0x4001C86")]
	public const int evaluate_sss = 6;

	[Token(Token = "0x6003731")]
	[Address(RVA = "0x4F3E00", Offset = "0x4F2600", Length = "0xA4")]
	public static string EvaluateToString(int index)
	{
		return null;
	}

	[Address(RVA = "0x4F3D50", Offset = "0x4F2550", Length = "0x8C")]
	[Token(Token = "0x6003732")]
	public static string EvaluateToRecordStr(int index)
	{
		return null;
	}

	[Token(Token = "0x6003733")]
	[Address(RVA = "0x4F3C80", Offset = "0x4F2480", Length = "0xB0")]
	public static string EvaluateToRecordImg(int index)
	{
		return null;
	}

	[Token(Token = "0x6003734")]
	[Address(RVA = "0x4F3B00", Offset = "0x4F2300", Length = "0x17A")]
	public static int EvaluateToInt(string evaluete)
	{
		return default(int);
	}
}
