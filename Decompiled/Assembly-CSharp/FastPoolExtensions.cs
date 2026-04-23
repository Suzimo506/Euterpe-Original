using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000072")]
public static class FastPoolExtensions
{
	[Token(Token = "0x600036B")]
	[Address(RVA = "0x44AE40", Offset = "0x449640", Length = "0x33")]
	public static GameObject FastInstantiate(this GameObject sourcePrefab, Transform parentTransform = null)
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x44ADC0", Offset = "0x4495C0", Length = "0x76")]
	public static GameObject FastInstantiate(this GameObject sourcePrefab, Vector3 position, Quaternion rotation, Transform parentTransform = null)
	{
		return null;
	}

	[Address(RVA = "0x44AD00", Offset = "0x449500", Length = "0x3B")]
	[Token(Token = "0x600036D")]
	public static GameObject FastInstantiate(this GameObject sourcePrefab, int poolID, Transform parentTransform = null)
	{
		return null;
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x44AD40", Offset = "0x449540", Length = "0x76")]
	public static GameObject FastInstantiate(this GameObject sourcePrefab, int poolID, Vector3 position, Quaternion rotation, Transform parentTransform = null)
	{
		return null;
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x44ACC0", Offset = "0x4494C0", Length = "0x36")]
	public static void FastDestroy(this GameObject objectToDestroy, GameObject sourcePrefab)
	{
	}

	[Address(RVA = "0x44AAE0", Offset = "0x4492E0", Length = "0x169")]
	[Token(Token = "0x6000370")]
	public static void FastDestroy(this GameObject objectToDestroy, Component sourcePrefab)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x44AC90", Offset = "0x449490", Length = "0x23")]
	public static void FastDestroy(this GameObject objectToDestroy, FastPool pool)
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x44AC50", Offset = "0x449450", Length = "0x37")]
	public static void FastDestroy(this GameObject objectToDestroy, int poolID)
	{
	}
}
