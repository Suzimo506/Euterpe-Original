using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.Events;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000689")]
public class ObjectPool<T> where T : new()
{
	[Token(Token = "0x40023CF")]
	[FieldOffset(Offset = "0x0")]
	private readonly Stack<T> m_Stack;

	[Token(Token = "0x40023D0")]
	[FieldOffset(Offset = "0x0")]
	private readonly UnityAction<T> m_ActionOnGet;

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40023D1")]
	private readonly UnityAction<T> m_ActionOnRelease;

	[Token(Token = "0x170005C4")]
	public int countAll
	{
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		[Token(Token = "0x6003DA3")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x4879F0", Offset = "0x4861F0", Length = "0x4")]
		[Token(Token = "0x6003DA4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170005C5")]
	public int countActive
	{
		[Address(RVA = "0x1360BF0", Offset = "0x135F3F0", Length = "0x60")]
		[Token(Token = "0x6003DA5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005C6")]
	public int countInactive
	{
		[Address(RVA = "0x958C40", Offset = "0x957440", Length = "0x2B")]
		[Token(Token = "0x6003DA6")]
		get
		{
			return default(int);
		}
	}

	[Address(RVA = "0x1360B20", Offset = "0x135F320", Length = "0xC4")]
	[Token(Token = "0x6003DA7")]
	public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
	{
	}

	[Token(Token = "0x6003DA8")]
	[Address(RVA = "0x1360940", Offset = "0x135F140", Length = "0xDF")]
	public T Get()
	{
		return (T)null;
	}

	[Token(Token = "0x6003DA9")]
	[Address(RVA = "0x1360A20", Offset = "0x135F220", Length = "0xFF")]
	public void Release(T element)
	{
	}
}
