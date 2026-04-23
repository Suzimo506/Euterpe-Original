using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x2000695")]
public static class GameUtils
{
	[Token(Token = "0x6003DD0")]
	[Address(RVA = "0x925C00", Offset = "0x924400", Length = "0x1DE")]
	public static bool GetChilds(this GameObject go, List<Transform> buffer, bool clear = true, bool includeAllChild = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DD1")]
	[Address(RVA = "0x925A70", Offset = "0x924270", Length = "0x18A")]
	public static bool GetChilds(this Transform tf, List<Transform> buffer, bool clear = true, bool includeAllChild = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003DD2")]
	[Address(RVA = "0x925590", Offset = "0x923D90", Length = "0xF7")]
	private static void FindAllChilds(Transform tf, List<Transform> buffer, bool includeAllChild)
	{
	}

	[Address(RVA = "0x9261D0", Offset = "0x9249D0", Length = "0xC4")]
	[Token(Token = "0x6003DD3")]
	public static string GetPathInScene(this Transform transform)
	{
		return null;
	}

	[Token(Token = "0x6003DD4")]
	[Address(RVA = "0x916230", Offset = "0x914A30", Length = "0x2F")]
	public static T GetOrAddComponent<T>(this Component cmp) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003DD5")]
	[Address(RVA = "0x916260", Offset = "0x914A60", Length = "0xA0")]
	public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6003DD6")]
	[Address(RVA = "0x926130", Offset = "0x924930", Length = "0x9B")]
	public static Component GetOrAddComponent(this GameObject gameObject, Type type)
	{
		return null;
	}

	[Token(Token = "0x6003DD7")]
	[Address(RVA = "0x925340", Offset = "0x923B40", Length = "0x164")]
	public static List<Component> EnableAllComponents(this GameObject go, bool enabled = true, params Type[] types)
	{
		return null;
	}

	[Token(Token = "0x6003DD8")]
	[Address(RVA = "0x925240", Offset = "0x923A40", Length = "0xF3")]
	public static List<Component> EnableAllComponents(Component[] cs, bool enabled = true, params Type[] types)
	{
		return null;
	}

	[Token(Token = "0x6003DD9")]
	[Address(RVA = "0x926650", Offset = "0x924E50", Length = "0x184")]
	public static void SetVisible(this GameObject go, bool isVisisble)
	{
	}

	[Address(RVA = "0x9254B0", Offset = "0x923CB0", Length = "0xD1")]
	[Token(Token = "0x6003DDA")]
	public static void Enable(this GameObject gameObject, bool isTo = true, bool includeInactive = true, params Type[] components)
	{
	}

	[Token(Token = "0x6003DDB")]
	[Address(RVA = "0x93C220", Offset = "0x93AA20", Length = "0x126")]
	public static List<T> GetAllComponents<T>(this GameObject go, bool inactive = true) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6003DDC")]
	[Address(RVA = "0x93B750", Offset = "0x939F50", Length = "0x345")]
	public static List<T> FindObjectsByType<T>(Transform parent = null, bool includeInactive = true)
	{
		return null;
	}

	[Address(RVA = "0x93BED0", Offset = "0x93A6D0", Length = "0x345")]
	[Token(Token = "0x6003DDD")]
	public static List<T> FindObjectsOfType<T>(Transform parent = null, bool includeInactive = true) where T : UnityEngine.Object
	{
		return null;
	}

	[Address(RVA = "0x915A60", Offset = "0x914260", Length = "0x64")]
	[Token(Token = "0x6003DDE")]
	public static T FindObjectOfType<T>(Transform parent = null, bool includeInactive = true) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6003DDF")]
	[Address(RVA = "0x925690", Offset = "0x923E90", Length = "0x1EB")]
	public static List<GameObject> FindGameObjectsWithTag(string tag)
	{
		return null;
	}

	[Address(RVA = "0x915D60", Offset = "0x914560", Length = "0x1E4")]
	[Token(Token = "0x6003DE0")]
	public static T GetObject<T>(object obj) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6003DE1")]
	[Address(RVA = "0x915AD0", Offset = "0x9142D0", Length = "0x28B")]
	public static T GetObject<T>(this UnityEngine.Object obj) where T : UnityEngine.Object
	{
		return null;
	}

	[Token(Token = "0x6003DE2")]
	[Address(RVA = "0x925FF0", Offset = "0x9247F0", Length = "0x136")]
	public static UnityEngine.Object GetObject(this UnityEngine.Object obj, string type)
	{
		return null;
	}

	[Token(Token = "0x6003DE3")]
	[Address(RVA = "0x9267E0", Offset = "0x924FE0", Length = "0x15B")]
	public static void SortChildren(this Transform t, Comparison<Transform> comparison, bool includeInActive = false)
	{
	}

	[Address(RVA = "0x926B70", Offset = "0x925370", Length = "0x1DF")]
	[Token(Token = "0x6003DE4")]
	public static bool TryParse(string s, out Vector2 res)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector2, @null>(ref res) = null;
		return default(bool);
	}

	[Address(RVA = "0x926940", Offset = "0x925140", Length = "0x22A")]
	[Token(Token = "0x6003DE5")]
	public static bool TryParse(string s, out Vector3 res)
	{
		System.Runtime.CompilerServices.Unsafe.As<Vector3, @null>(ref res) = null;
		return default(bool);
	}

	[Token(Token = "0x6003DE6")]
	[Address(RVA = "0x9262A0", Offset = "0x924AA0", Length = "0xC9")]
	public static float GetTime(this Animator animator)
	{
		return default(float);
	}

	[Token(Token = "0x6003DE7")]
	[Address(RVA = "0x926550", Offset = "0x924D50", Length = "0xFD")]
	public static void SetTime(this Animator animator, float time)
	{
	}

	[Address(RVA = "0x926370", Offset = "0x924B70", Length = "0x9F")]
	[Token(Token = "0x6003DE8")]
	public static bool IsComplete(this Animator animator)
	{
		return default(bool);
	}

	[Address(RVA = "0x925880", Offset = "0x924080", Length = "0x1E6")]
	[Token(Token = "0x6003DE9")]
	public static float GetAnimLength(this Animator anim, string clipName)
	{
		return default(float);
	}

	[Token(Token = "0x6003DEA")]
	[Address(RVA = "0x925DE0", Offset = "0x9245E0", Length = "0x85")]
	public static int GetCurrentAnimHash(this Animator animator)
	{
		return default(int);
	}

	[Address(RVA = "0x925E70", Offset = "0x924670", Length = "0x170")]
	[Token(Token = "0x6003DEB")]
	public static string GetCurrentAnimName(this Animator animator)
	{
		return null;
	}

	[Address(RVA = "0x926410", Offset = "0x924C10", Length = "0x135")]
	[Token(Token = "0x6003DEC")]
	public static void SetEnable(this Behaviour[] behaviours, bool enable)
	{
	}
}
