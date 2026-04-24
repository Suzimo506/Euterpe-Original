using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
[Token(Token = "0x2000650")]
public class PoolManager : Singleton<PoolManager>
{
	[Token(Token = "0x170005AA")]
	public Dictionary<string, FastPool> fastPools
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6003CC2")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		[Token(Token = "0x6003CC1")]
		private set
		{
		}
	}

	[Token(Token = "0x170005AB")]
	public FastPool Item
	{
		[Address(RVA = "0x761560", Offset = "0x75FD60", Length = "0x7B")]
		[Token(Token = "0x6003CC3")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CC4")]
	[Address(RVA = "0x7611A0", Offset = "0x75F9A0", Length = "0x5F")]
	private void Init()
	{
	}

	[Token(Token = "0x6003CC5")]
	[Address(RVA = "0x2018BA0", Offset = "0x20173A0", Length = "0x18C")]
	public FastPool MakeFastPool<T>(T source, int preload, int capacity = -1, Transform parent = null) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003CC6")]
	[Address(RVA = "0x761200", Offset = "0x75FA00", Length = "0x17C")]
	public FastPool MakeFastPool(GameObject source, int preload, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Token(Token = "0x6003CC7")]
	[Address(RVA = "0x761380", Offset = "0x75FB80", Length = "0x193")]
	public FastPool MakeFastPool(string name, int preload, int capacity, Transform parent = null)
	{
		return null;
	}

	[Address(RVA = "0x760E10", Offset = "0x75F610", Length = "0x16E")]
	[Token(Token = "0x6003CC8")]
	public void DestroyFastPool(FastPool pool)
	{
	}

	[Address(RVA = "0x760F80", Offset = "0x75F780", Length = "0x96")]
	[Token(Token = "0x6003CC9")]
	public void DestroyFastPool(string uid)
	{
	}

	[Address(RVA = "0x761120", Offset = "0x75F920", Length = "0x3A")]
	[Token(Token = "0x6003CCA")]
	public GameObject FastInstantiate(string name, int preload, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Address(RVA = "0x761160", Offset = "0x75F960", Length = "0x3A")]
	[Token(Token = "0x6003CCB")]
	public GameObject FastInstantiate(GameObject go, int preload, int capacity = -1, Transform parent = null)
	{
		return null;
	}

	[Token(Token = "0x6003CCC")]
	[Address(RVA = "0x761020", Offset = "0x75F820", Length = "0xFF")]
	public void FastDestroy(GameObject gameObject)
	{
	}

	[Address(RVA = "0x761520", Offset = "0x75FD20", Length = "0x38")]
	[Token(Token = "0x6003CCD")]
	public PoolManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
