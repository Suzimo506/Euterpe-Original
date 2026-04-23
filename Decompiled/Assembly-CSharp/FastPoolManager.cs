using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000071")]
public class FastPoolManager : SingletonMonoBehaviour<FastPoolManager>
{
	[SerializeField]
	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x18")]
	private List<FastPool> predefinedPools;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400031A")]
	private Dictionary<int, FastPool> pools;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400031B")]
	private Transform curTransform;

	[Token(Token = "0x17000060")]
	public Dictionary<int, FastPool> Pools
	{
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6000360")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x44AE80", Offset = "0x449680", Length = "0x1FE")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	private void Start()
	{
	}

	[Address(RVA = "0x200B630", Offset = "0x2009E30", Length = "0xBC")]
	[Token(Token = "0x6000363")]
	public static FastPool CreatePoolC<T>(T component, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0, Transform newRootTransform = null) where T : Component
	{
		return null;
	}

	[Address(RVA = "0x44B2A0", Offset = "0x449AA0", Length = "0x261")]
	[Token(Token = "0x6000364")]
	public static FastPool CreatePool(GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0, Transform newRootTransform = null)
	{
		return null;
	}

	[Address(RVA = "0x44B080", Offset = "0x449880", Length = "0x21B")]
	[Token(Token = "0x6000365")]
	public static FastPool CreatePool(int id, GameObject prefab, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
	{
		return null;
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x44B620", Offset = "0x449E20", Length = "0x13D")]
	public static FastPool GetPool(GameObject prefab, bool createIfNotExists = true)
	{
		return null;
	}

	[Address(RVA = "0x44B8C0", Offset = "0x44A0C0", Length = "0xB3")]
	[Token(Token = "0x6000367")]
	public static FastPool GetPool(int id, GameObject prefab, bool createIfNotExists = true)
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x44B760", Offset = "0x449F60", Length = "0x153")]
	public static FastPool GetPool(Component component, bool createIfNotExists = true)
	{
		return null;
	}

	[Address(RVA = "0x44B510", Offset = "0x449D10", Length = "0x108")]
	[Token(Token = "0x6000369")]
	public static void DestroyPool(FastPool pool)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x44B980", Offset = "0x44A180", Length = "0x6E")]
	public FastPoolManager()
	{
		((SingletonMonoBehaviour<>)(object)this)._002Ector();
	}
}
