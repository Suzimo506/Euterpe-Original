using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200069A")]
public static class LinqUtils
{
	[Token(Token = "0x6003E12")]
	[Address(RVA = "0x7F10F0", Offset = "0x7EF8F0", Length = "0xD")]
	public static T[] ToArray<T>(this IEnumerable<T> array)
	{
		return null;
	}

	[Token(Token = "0x6003E13")]
	[Address(RVA = "0x7F22F0", Offset = "0x7F0AF0", Length = "0x1F6")]
	public static T[] ToArray<T>(this IList<T> array)
	{
		return null;
	}

	[Address(RVA = "0x93E550", Offset = "0x93CD50", Length = "0x7A")]
	[Token(Token = "0x6003E14")]
	public static List<T> ToList<T>(this IEnumerable<T> array)
	{
		return null;
	}

	[Token(Token = "0x6003E15")]
	[Address(RVA = "0x93D760", Offset = "0x93BF60", Length = "0x122")]
	public static List<T> Where<T>(this IList<T> array, Func<T, bool> predicate)
	{
		return null;
	}

	[Address(RVA = "0x93E5D0", Offset = "0x93CDD0", Length = "0x240")]
	[Token(Token = "0x6003E16")]
	public static List<T> Where<T>(this IEnumerable<T> array, Func<T, bool> predicate)
	{
		return null;
	}

	[Token(Token = "0x6003E17")]
	[Address(RVA = "0x93D3F0", Offset = "0x93BBF0", Length = "0x204")]
	public static List<T> OfType<T>(this IList array)
	{
		return null;
	}

	[Token(Token = "0x6003E18")]
	[Address(RVA = "0x9D23B0", Offset = "0x9D0BB0", Length = "0x18E")]
	public static void For<T>(this IList<T> array, Action<T> predicate)
	{
	}

	[Address(RVA = "0x9D1C50", Offset = "0x9D0450", Length = "0x1A6")]
	[Token(Token = "0x6003E19")]
	public static void For<T>(this IEnumerable<T> array, Action<T> predicate)
	{
	}

	[Address(RVA = "0x919540", Offset = "0x917D40", Length = "0xD2")]
	[Token(Token = "0x6003E1A")]
	public static T Find<T>(this IList<T> array, Func<T, bool> predicate) where T : class
	{
		return null;
	}

	[Address(RVA = "0xF38C70", Offset = "0xF37470", Length = "0xD1")]
	[Token(Token = "0x6003E1B")]
	public static int FindIndex<T>(this IList<T> array, Func<T, bool> predicate) where T : class
	{
		return default(int);
	}

	[Address(RVA = "0xF389B0", Offset = "0xF371B0", Length = "0xE9")]
	[Token(Token = "0x6003E1C")]
	public static int Count<T>(this IList<T> array, Func<T, bool> predicate)
	{
		return default(int);
	}

	[Address(RVA = "0x93D600", Offset = "0x93BE00", Length = "0x157")]
	[Token(Token = "0x6003E1D")]
	public static List<T> Reverse<T>(this IList<T> array)
	{
		return null;
	}

	[Token(Token = "0x6003E1E")]
	[Address(RVA = "0x9199D0", Offset = "0x9181D0", Length = "0x89")]
	public static T Last<T>(this IList<T> array)
	{
		return (T)null;
	}

	[Address(RVA = "0x9197D0", Offset = "0x917FD0", Length = "0x4A")]
	[Token(Token = "0x6003E1F")]
	public static T First<T>(this IList<T> array)
	{
		return (T)null;
	}

	[Address(RVA = "0x18B0740", Offset = "0x18AEF40", Length = "0xCC")]
	[Token(Token = "0x6003E20")]
	public static bool Contains<T>(this IList<T> array, T predicate)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E21")]
	[Address(RVA = "0x18B0810", Offset = "0x18AF010", Length = "0xCE")]
	public static bool Exists<T>(this IList<T> array, Func<T, bool> predicate)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E22")]
	[Address(RVA = "0x93C590", Offset = "0x93AD90", Length = "0x196")]
	public static List<T> Cast<T>(this IList array)
	{
		return null;
	}

	[Address(RVA = "0x93CBE0", Offset = "0x93B3E0", Length = "0x114")]
	[Token(Token = "0x6003E23")]
	public static List<T> Cast<T>(this IList<T> array)
	{
		return null;
	}

	[Address(RVA = "0xF389B0", Offset = "0xF371B0", Length = "0xE9")]
	[Token(Token = "0x6003E24")]
	public static int Max<T>(this IList<T> array, Func<T, int> predicate)
	{
		return default(int);
	}

	[Address(RVA = "0x9D26E0", Offset = "0x9D0EE0", Length = "0xEB")]
	[Token(Token = "0x6003E25")]
	public static float Max<T>(this IList<T> array, Func<T, float> predicate)
	{
		return default(float);
	}

	[Address(RVA = "0x93CD00", Offset = "0x93B500", Length = "0xF0")]
	[Token(Token = "0x6003E26")]
	public static decimal Max<T>(this IList<T> array, Func<T, decimal> predicate)
	{
		return default(decimal);
	}

	[Token(Token = "0x6003E27")]
	[Address(RVA = "0xF389B0", Offset = "0xF371B0", Length = "0xE9")]
	public static int Min<T>(this IList<T> array, Func<T, int> predicate)
	{
		return default(int);
	}

	[Address(RVA = "0x9D26E0", Offset = "0x9D0EE0", Length = "0xEB")]
	[Token(Token = "0x6003E28")]
	public static float Min<T>(this IList<T> array, Func<T, float> predicate)
	{
		return default(float);
	}

	[Token(Token = "0x6003E29")]
	[Address(RVA = "0x93CD00", Offset = "0x93B500", Length = "0xF0")]
	public static decimal Min<T>(this IList<T> array, Func<T, decimal> predicate)
	{
		return default(decimal);
	}

	[Address(RVA = "0x93D760", Offset = "0x93BF60", Length = "0x122")]
	[Token(Token = "0x6003E2A")]
	public static List<T1> Select<T1, T2>(this IList<T2> array, Func<T2, T1> predicate)
	{
		return null;
	}

	[Address(RVA = "0x93D760", Offset = "0x93BF60", Length = "0x122")]
	[Token(Token = "0x6003E2B")]
	public static List<T1> Select<T1, T2>(this IEnumerable<T2> array, Func<T2, T1> predicate)
	{
		return null;
	}

	[Token(Token = "0x6003E2C")]
	[Address(RVA = "0x9D2B70", Offset = "0x9D1370", Length = "0x1C0")]
	public static void SelectNoAlloc<T1, T2>(this IList<T2> array, List<T1> list, Func<T2, T1> predicate)
	{
	}

	[Token(Token = "0x6003E2D")]
	[Address(RVA = "0x919C30", Offset = "0x918430", Length = "0xE9")]
	public static T Single<T>(this IList<T> array, Func<T, bool> predicate)
	{
		return (T)null;
	}

	[Address(RVA = "0x9D26E0", Offset = "0x9D0EE0", Length = "0xEB")]
	[Token(Token = "0x6003E2E")]
	public static float Sum<T>(this IList<T> array, Func<T, float> predicate)
	{
		return default(float);
	}

	[Token(Token = "0x6003E2F")]
	[Address(RVA = "0xF389B0", Offset = "0xF371B0", Length = "0xE9")]
	public static int Sum<T>(this IList<T> array, Func<T, int> predicate)
	{
		return default(int);
	}
}
