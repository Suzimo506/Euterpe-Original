using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200069F")]
public static class RandomUtils
{
	[Token(Token = "0x6003E67")]
	[Address(RVA = "0x92FF70", Offset = "0x92E770", Length = "0x3D3")]
	public static int RandomEvent(IList<float> probabilities, params Action[] events)
	{
		return default(int);
	}

	[Address(RVA = "0x91D920", Offset = "0x91C120", Length = "0xCE")]
	[Token(Token = "0x6003E68")]
	public static T Random<T>(this IList<T> array)
	{
		return (T)null;
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0x91DB10", Offset = "0x91C310", Length = "0xDF")]
	public static T Random<T>(this IList<T> array, out int index)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref index) = null;
		return (T)null;
	}

	[Address(RVA = "0x92FE80", Offset = "0x92E680", Length = "0xE9")]
	[Token(Token = "0x6003E6A")]
	public static object LRandom(this IList array)
	{
		return null;
	}

	[Token(Token = "0x6003E6B")]
	[Address(RVA = "0x930360", Offset = "0x92EB60", Length = "0x8")]
	public static int Random(int min, int max)
	{
		return default(int);
	}

	[Address(RVA = "0x930350", Offset = "0x92EB50", Length = "0x8")]
	[Token(Token = "0x6003E6C")]
	public static float Random(float min, float max)
	{
		return default(float);
	}
}
