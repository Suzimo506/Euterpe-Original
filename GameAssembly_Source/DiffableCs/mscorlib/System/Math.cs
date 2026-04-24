namespace System;

public static class Math
{
	private static double doubleRoundLimit; //Field offset: 0x0
	private const int maxRoundingDigits = 15; //Field offset: 0x0
	public const double PI = 3.141592653589793; //Field offset: 0x0
	public const double E = 2.718281828459045; //Field offset: 0x0
	private static Double[] roundPower10Double; //Field offset: 0x8

	private static Math() { }

	public static decimal Abs(decimal value) { }

	public static double Abs(double value) { }

	public static long Abs(long value) { }

	public static int Abs(int value) { }

	public static float Abs(float value) { }

	private static long AbsHelper(long value) { }

	private static int AbsHelper(int value) { }

	public static double Acos(double d) { }

	public static double Asin(double d) { }

	public static double Atan(double d) { }

	public static double Atan2(double y, double x) { }

	public static double Ceiling(double a) { }

	public static double Cos(double d) { }

	public static double Exp(double d) { }

	public static double Floor(double d) { }

	public static double IEEERemainder(double x, double y) { }

	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	private static double InternalTruncate(double d) { }

	public static double Log(double a, double newBase) { }

	public static double Log(double d) { }

	public static double Log10(double d) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static decimal Max(decimal val1, decimal val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static double Max(double val1, double val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float Max(float val1, float val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static long Max(long val1, long val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int Max(int val1, int val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static short Max(short val1, short val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static byte Max(byte val1, byte val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ushort Min(ushort val1, ushort val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static long Min(long val1, long val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int Min(int val1, int val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static decimal Min(decimal val1, decimal val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static short Min(short val1, short val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static byte Min(byte val1, byte val2) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static double Min(double val1, double val2) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static float Min(float val1, float val2) { }

	public static double Pow(double x, double y) { }

	public static double Round(double value, int digits, MidpointRounding mode) { }

	public static double Round(double value, MidpointRounding mode) { }

	public static decimal Round(decimal d) { }

	public static double Round(double value, int digits) { }

	public static double Round(double a) { }

	public static int Sign(long value) { }

	public static int Sign(float value) { }

	public static int Sign(int value) { }

	public static int Sign(double value) { }

	public static double Sin(double a) { }

	private static double SplitFractionDouble(Double* value) { }

	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static double Sqrt(double d) { }

	public static double Tan(double a) { }

	public static decimal Truncate(decimal d) { }

	public static double Truncate(double d) { }

}

