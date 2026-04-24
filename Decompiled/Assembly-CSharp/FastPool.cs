using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000070")]
public class FastPool
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400030D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x6F800", Offset = "0x6EC00")]
	public GameObject sourcePrefab;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x70FB0", Offset = "0x703B0")]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400030E")]
	public int Capacity;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71020", Offset = "0x70420")]
	public int PreloadCount;

	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71180", Offset = "0x70580")]
	[Token(Token = "0x4000310")]
	public PoolItemNotificationType NotificationType;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71310", Offset = "0x70710")]
	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x2C")]
	public bool WarmOnLoad;

	[FieldOffset(Offset = "0x2D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x71500", Offset = "0x70900")]
	[Token(Token = "0x4000312")]
	public bool ParentOnCache;

	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x715A0", Offset = "0x709A0")]
	[SerializeField]
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x2E")]
	private bool useCustomID;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x30")]
	private int customID;

	[Token(Token = "0x4000315")]
	[HideInInspector]
	[SerializeField]
	[FieldOffset(Offset = "0x34")]
	private int cached_internal;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x38")]
	private Stack<GameObject> cache;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> gameObjects;

	[Token(Token = "0x1700005A")]
	public int ID
	{
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600034A")]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		[Address(RVA = "0x42CB50", Offset = "0x42B350", Length = "0x4")]
		[Token(Token = "0x600034B")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005B")]
	public string Name
	{
		[Address(RVA = "0x44C9D0", Offset = "0x44B1D0", Length = "0x1D")]
		[Token(Token = "0x600034C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005C")]
	public int Cached
	{
		[Address(RVA = "0x44C980", Offset = "0x44B180", Length = "0x3B")]
		[Token(Token = "0x600034D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700005D")]
	public bool IsValid
	{
		[Address(RVA = "0x44C9C0", Offset = "0x44B1C0", Length = "0x5")]
		[Token(Token = "0x600034E")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x44CA30", Offset = "0x44B230", Length = "0x4")]
		[Token(Token = "0x600034F")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700005E")]
	public Transform parentTransform
	{
		[Address(RVA = "0x4434B0", Offset = "0x441CB0", Length = "0x5")]
		[Token(Token = "0x6000351")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x4434D0", Offset = "0x441CD0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700005F")]
	public List<GameObject> cached
	{
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x44C9F0", Offset = "0x44B1F0", Length = "0x39")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x44C7C0", Offset = "0x44AFC0", Length = "0xD8")]
	public FastPool(GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x44C8A0", Offset = "0x44B0A0", Length = "0xD8")]
	public FastPool(int id, GameObject prefab, Transform rootTransform = null, bool warmOnLoad = true, int preloadCount = 0, int capacity = 0)
	{
	}

	[Address(RVA = "0x44C320", Offset = "0x44AB20", Length = "0x32C")]
	[Token(Token = "0x6000355")]
	public bool Init(Transform rootTransform)
	{
		return default(bool);
	}

	[Address(RVA = "0x44C290", Offset = "0x44AA90", Length = "0x86")]
	[Token(Token = "0x6000356")]
	private void Init(GameObject go)
	{
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x44BA00", Offset = "0x44A200", Length = "0xB1")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x915260", Offset = "0x913A60", Length = "0xF8")]
	public T FastInstantiate<T>(Transform parent = null, Action<GameObject> callback = null) where T : Component
	{
		return null;
	}

	[Address(RVA = "0x915360", Offset = "0x913B60", Length = "0xF5")]
	[Token(Token = "0x6000359")]
	public T FastInstantiate<T>(Vector3 position, Quaternion rotation, Transform parent = null, Action<GameObject> callback = null) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600035A")]
	[Address(RVA = "0x44C1A0", Offset = "0x44A9A0", Length = "0xE9")]
	public GameObject FastInstantiate(Transform parent = null, Action<GameObject> callback = null)
	{
		return null;
	}

	[Address(RVA = "0x44BE90", Offset = "0x44A690", Length = "0x309")]
	[Token(Token = "0x600035B")]
	public GameObject FastInstantiate(Vector3 position, Quaternion rotation, Transform parent = null, Action<GameObject> callback = null)
	{
		return null;
	}

	[Address(RVA = "0x9CDDC0", Offset = "0x9CC5C0", Length = "0xC1")]
	[Token(Token = "0x600035C")]
	public void FastDestroy<T>(T sceneObject) where T : Component
	{
	}

	[Address(RVA = "0x44BBD0", Offset = "0x44A3D0", Length = "0x2B3")]
	[Token(Token = "0x600035D")]
	public void FastDestroy(GameObject sceneObject)
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x44BAC0", Offset = "0x44A2C0", Length = "0x100")]
	public void FastDestroyAll()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x44C650", Offset = "0x44AE50", Length = "0x160")]
	private GameObject MakeClone(Vector3 position, Quaternion rotation, Transform parent)
	{
		return null;
	}
}
