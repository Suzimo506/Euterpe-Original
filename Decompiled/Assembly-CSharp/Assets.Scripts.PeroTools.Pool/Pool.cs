using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Pool;

[Token(Token = "0x20005BB")]
public class Pool<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002171")]
	private readonly Stack<T> _caches;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4002172")]
	private readonly Func<T> _newFunc;

	[Token(Token = "0x4002173")]
	[FieldOffset(Offset = "0x0")]
	private readonly Action<T> _releaseAction;

	[Token(Token = "0x4002174")]
	private static Pool<T> _pools;

	[Token(Token = "0x6003975")]
	[Address(RVA = "0x13614F0", Offset = "0x135FCF0", Length = "0x1CB")]
	public static T Get(Func<T> newFunc, Action<T> releaseAction)
	{
		return (T)null;
	}

	[Token(Token = "0x6003976")]
	[Address(RVA = "0x13617C0", Offset = "0x135FFC0", Length = "0xFD")]
	public static void Release(T t)
	{
	}

	[Token(Token = "0x6003977")]
	[Address(RVA = "0x13618C0", Offset = "0x13600C0", Length = "0xC5")]
	public Pool(Func<T> newFunc, Action<T> releaseAction)
	{
	}

	[Token(Token = "0x6003978")]
	[Address(RVA = "0x13616C0", Offset = "0x135FEC0", Length = "0x86")]
	public T Pop()
	{
		return (T)null;
	}

	[Token(Token = "0x6003979")]
	[Address(RVA = "0x1361750", Offset = "0x135FF50", Length = "0x6A")]
	public void Push(T t)
	{
	}
}
