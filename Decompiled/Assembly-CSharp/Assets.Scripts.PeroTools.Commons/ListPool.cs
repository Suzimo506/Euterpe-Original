using System.Collections.Generic;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000688")]
public static class ListPool<T>
{
	[Token(Token = "0x40023CE")]
	private static readonly ObjectPool<List<T>> s_ListPool;

	[Token(Token = "0x6003DA0")]
	[Address(RVA = "0x135D4A0", Offset = "0x135BCA0", Length = "0x155")]
	public static List<T> Get()
	{
		return null;
	}

	[Token(Token = "0x6003DA1")]
	[Address(RVA = "0x135D600", Offset = "0x135BE00", Length = "0x165")]
	public static void Release(List<T> toRelease)
	{
	}
}
