using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000698")]
public static class ArrayUtils
{
	[Address(RVA = "0x18AA7A0", Offset = "0x18A8FA0", Length = "0x115")]
	[Token(Token = "0x6003DF3")]
	public static bool TryGetValue<T>(this IList<T> list, int index, out T value)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref value) = null;
		return default(bool);
	}

	[Address(RVA = "0x18AA250", Offset = "0x18A8A50", Length = "0x2D4")]
	[Token(Token = "0x6003DF4")]
	public static bool TryGetKey<T, U>(this Dictionary<T, U> dic, U value, out T key)
	{
		System.Runtime.CompilerServices.Unsafe.As<T, @null>(ref key) = null;
		return default(bool);
	}

	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0x9C9190", Offset = "0x9C7990", Length = "0x1F3")]
	public static void Remove<T>(this Stack<T> stack, Predicate<T> value)
	{
	}

	[Address(RVA = "0x18A9DD0", Offset = "0x18A85D0", Length = "0xEF")]
	[Token(Token = "0x6003DF6")]
	public static bool Contains<T>(this T[] array, T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0xF311B0", Offset = "0xF2F9B0", Length = "0xA9")]
	public static int IndexOf<T>(this T[] array, T value)
	{
		return default(int);
	}

	[Token(Token = "0x6003DF8")]
	[Address(RVA = "0x7E3FB0", Offset = "0x7E27B0", Length = "0x127")]
	public static T[] Insert<T>(this T[] array, int index, T value)
	{
		return null;
	}

	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0x7E3DE0", Offset = "0x7E25E0", Length = "0xEC")]
	public static T[] Add<T>(this T[] array, T value)
	{
		return null;
	}

	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0x7B7960", Offset = "0x7B6160", Length = "0x2C")]
	public static void Add<T>(ref T[] array, T value)
	{
	}

	[Address(RVA = "0x7E40E0", Offset = "0x7E28E0", Length = "0x11F")]
	[Token(Token = "0x6003DFB")]
	public static T[] Remove<T>(this T[] array, int index)
	{
		return null;
	}

	[Address(RVA = "0x7B7960", Offset = "0x7B6160", Length = "0x2C")]
	[Token(Token = "0x6003DFC")]
	public static void Remove<T>(ref T[] array, int index)
	{
	}

	[Token(Token = "0x6003DFD")]
	[Address(RVA = "0x7E4200", Offset = "0x7E2A00", Length = "0x4C")]
	public static T[] Remove<T>(this T[] array, T value)
	{
		return null;
	}

	[Address(RVA = "0x9C9140", Offset = "0x9C7940", Length = "0x50")]
	[Token(Token = "0x6003DFE")]
	public static void Remove<T>(ref T[] array, T value)
	{
	}

	[Address(RVA = "0x9C8FC0", Offset = "0x9C77C0", Length = "0xB1")]
	[Token(Token = "0x6003DFF")]
	public static void MoveBack<T>(this T[] array, T value)
	{
	}

	[Address(RVA = "0x9C9080", Offset = "0x9C7880", Length = "0xBA")]
	[Token(Token = "0x6003E00")]
	public static void MoveForw<T>(this T[] array, T value)
	{
	}

	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x18A9D70", Offset = "0x18A8570", Length = "0x1B")]
	public static bool CanMoveBack<T>(this T[] array, T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E02")]
	[Address(RVA = "0x18A9D90", Offset = "0x18A8590", Length = "0x3C")]
	public static bool CanMoveForw<T>(this T[] array, T value)
	{
		return default(bool);
	}

	[Address(RVA = "0x678090", Offset = "0x676890", Length = "0xD")]
	[Token(Token = "0x6003E03")]
	public static T FindOne<T>(this T[] array, Predicate<T> callback)
	{
		return (T)null;
	}

	[Token(Token = "0x6003E04")]
	[Address(RVA = "0x7E4250", Offset = "0x7E2A50", Length = "0xDE")]
	public static T[] ToRefArray<T>(this List<T> list)
	{
		return null;
	}

	[Address(RVA = "0x9C9410", Offset = "0x9C7C10", Length = "0x109")]
	[Token(Token = "0x6003E05")]
	public static void Swap<T>(this IList<T> array, int left, int right)
	{
	}

	[Address(RVA = "0x93A380", Offset = "0x938B80", Length = "0xA2")]
	[Token(Token = "0x6003E06")]
	public static List<T> NewList<T>(int count, T defaultValue = default(T))
	{
		return null;
	}

	[Address(RVA = "0x9C9390", Offset = "0x9C7B90", Length = "0x71")]
	[Token(Token = "0x6003E07")]
	public static void Swap<T>(this T[] array, int left, int right)
	{
	}

	[Address(RVA = "0x9C8F40", Offset = "0x9C7740", Length = "0x77")]
	[Token(Token = "0x6003E08")]
	public static void Init<T>(this T[] array) where T : new()
	{
	}

	[Address(RVA = "0x911D70", Offset = "0x910570", Length = "0xF6")]
	[Token(Token = "0x6003E09")]
	public static T SafeGet<T>(this IList<T> list, int index)
	{
		return (T)null;
	}
}
