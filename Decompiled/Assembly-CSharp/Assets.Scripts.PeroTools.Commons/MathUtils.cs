using System;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200069E")]
public static class MathUtils
{
	[Address(RVA = "0x92EF30", Offset = "0x92D730", Length = "0x10")]
	[Token(Token = "0x6003E4A")]
	public static float Lerp(float a, float b, float t)
	{
		return default(float);
	}

	[Token(Token = "0x6003E4B")]
	[Address(RVA = "0x92EF40", Offset = "0x92D740", Length = "0x1B")]
	public static int LongToInt(long value)
	{
		return default(int);
	}

	[Address(RVA = "0x92E4A0", Offset = "0x92CCA0", Length = "0x18F")]
	[Token(Token = "0x6003E4C")]
	public static int DecimalToInt(decimal value, decimal magnifyingPower)
	{
		return default(int);
	}

	[Address(RVA = "0x92E840", Offset = "0x92D040", Length = "0x2B")]
	[Token(Token = "0x6003E4D")]
	public static int FloatToInt(float value, float magnifyingPower)
	{
		return default(int);
	}

	[Token(Token = "0x6003E4E")]
	[Address(RVA = "0x92EFE0", Offset = "0x92D7E0", Length = "0x8E")]
	public static float Round(float value, int num)
	{
		return default(float);
	}

	[Address(RVA = "0x92EF70", Offset = "0x92D770", Length = "0x69")]
	[Token(Token = "0x6003E4F")]
	public static float RoundX(float value, int num)
	{
		return default(float);
	}

	[Address(RVA = "0x92E870", Offset = "0x92D070", Length = "0x8E")]
	[Token(Token = "0x6003E50")]
	public static float Floor(float value, int num)
	{
		return default(float);
	}

	[Token(Token = "0x6003E51")]
	[Address(RVA = "0x92E270", Offset = "0x92CA70", Length = "0x8E")]
	public static float Ceil(float value, int num)
	{
		return default(float);
	}

	[Address(RVA = "0x92ED50", Offset = "0x92D550", Length = "0x71")]
	[Token(Token = "0x6003E52")]
	public static bool IsInRect(Rect rect, Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E53")]
	[Address(RVA = "0x92EB80", Offset = "0x92D380", Length = "0x183")]
	public static bool InRange(ref decimal value, ref decimal left, ref decimal right, bool IncudeEqual)
	{
		return default(bool);
	}

	[Address(RVA = "0x92ED30", Offset = "0x92D530", Length = "0x1E")]
	[Token(Token = "0x6003E54")]
	public static bool InRange(int value, int left, int right, bool IncudeEqual)
	{
		return default(bool);
	}

	[Address(RVA = "0x92ED10", Offset = "0x92D510", Length = "0x20")]
	[Token(Token = "0x6003E55")]
	public static bool InRange(float value, float left, float right, bool IncudeEqual)
	{
		return default(bool);
	}

	[Address(RVA = "0x92E900", Offset = "0x92D100", Length = "0x19")]
	[Token(Token = "0x6003E56")]
	public static bool InRange(ref Vector2 outVec, ref Vector2 inVec)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E57")]
	[Address(RVA = "0x92E920", Offset = "0x92D120", Length = "0x25F")]
	public static bool InRange(DateTime now, DateTime from, DateTime to, bool ignoreYear, bool includeToday = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E58")]
	[Address(RVA = "0x92E420", Offset = "0x92CC20", Length = "0x7E")]
	public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003E59")]
	[Address(RVA = "0x92E370", Offset = "0x92CB70", Length = "0xAA")]
	public static Vector3 Clamp(Vector3 value, Vector3 min, Vector3 max)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6003E5A")]
	[Address(RVA = "0x92E350", Offset = "0x92CB50", Length = "0x11")]
	public static int Clamp(int value, int min, int max)
	{
		return default(int);
	}

	[Address(RVA = "0x92E330", Offset = "0x92CB30", Length = "0x12")]
	[Token(Token = "0x6003E5B")]
	public static float Clamp(float value, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6003E5C")]
	[Address(RVA = "0x92EF60", Offset = "0x92D760", Length = "0xD")]
	public static float Normalize(float value, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6003E5D")]
	[Address(RVA = "0x92E300", Offset = "0x92CB00", Length = "0x29")]
	public static float ClampNormalize(float value, float min, float max)
	{
		return default(float);
	}

	[Address(RVA = "0x92E630", Offset = "0x92CE30", Length = "0xF6")]
	[Token(Token = "0x6003E5E")]
	public static double Distance(Vector3 start, Vector3 end)
	{
		return default(double);
	}

	[Address(RVA = "0x92E740", Offset = "0x92CF40", Length = "0xFD")]
	[Token(Token = "0x6003E5F")]
	public static double Distance(Vector2 start, Vector2 end)
	{
		return default(double);
	}

	[Address(RVA = "0x92E730", Offset = "0x92CF30", Length = "0x5")]
	[Token(Token = "0x6003E60")]
	public static double Distance(double start, double end)
	{
		return default(double);
	}

	[Token(Token = "0x6003E61")]
	[Address(RVA = "0x92EDD0", Offset = "0x92D5D0", Length = "0x15F")]
	public static bool IsPointInTrapezoid(Vector2[] polygon, float x, float y)
	{
		return default(bool);
	}

	[Address(RVA = "0x92E1D0", Offset = "0x92C9D0", Length = "0x93")]
	[Token(Token = "0x6003E62")]
	public static int C36to10(string xStart)
	{
		return default(int);
	}

	[Address(RVA = "0x92E120", Offset = "0x92C920", Length = "0xA8")]
	[Token(Token = "0x6003E63")]
	public static int C36to10S(char xChar)
	{
		return default(int);
	}

	[Address(RVA = "0x92E0E0", Offset = "0x92C8E0", Length = "0x10")]
	[Token(Token = "0x6003E64")]
	public static float Abs(float a)
	{
		return default(float);
	}

	[Address(RVA = "0x92E110", Offset = "0x92C910", Length = "0x8")]
	[Token(Token = "0x6003E65")]
	public static int Abs(int a)
	{
		return default(int);
	}

	[Token(Token = "0x6003E66")]
	[Address(RVA = "0x92E0F0", Offset = "0x92C8F0", Length = "0x11")]
	public static double Abs(double a)
	{
		return default(double);
	}
}
