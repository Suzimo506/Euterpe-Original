using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x20006A1")]
public static class ReflectionUtils
{
	[Serializable]
	[Token(Token = "0x2000C38")]
	public class ReflectObject
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003C6E")]
		public UnityEngine.Object sourceObject;

		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x18")]
		public string reflectName;

		[Token(Token = "0x60060A3")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ReflectObject()
		{
		}
	}

	[Address(RVA = "0x930C60", Offset = "0x92F460", Length = "0x18F")]
	[Token(Token = "0x6003E71")]
	public static Dictionary<string, MemberInfo> GetTypeMemberNames(Type type, bool get = true, bool set = true, BindingFlags bf = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
	{
		return null;
	}

	[Token(Token = "0x6003E72")]
	[Address(RVA = "0x9305F0", Offset = "0x92EDF0", Length = "0x1B9")]
	public static Dictionary<string, MemberInfo> GetMemberNames(this GameObject gameObject, bool get = true, bool set = true, Func<MemberInfo, bool> predicate = null)
	{
		return null;
	}

	[Token(Token = "0x6003E73")]
	[Address(RVA = "0x931680", Offset = "0x92FE80", Length = "0x623")]
	public static Dictionary<string, MemberInfo> LimitMemeberInfo(Dictionary<string, MemberInfo> members, bool get, bool set)
	{
		return null;
	}

	[Token(Token = "0x6003E74")]
	[Address(RVA = "0x931CB0", Offset = "0x9304B0", Length = "0xF7")]
	public static string NickNameToReflectName(string str)
	{
		return null;
	}

	[Address(RVA = "0x931DB0", Offset = "0x9305B0", Length = "0x25")]
	[Token(Token = "0x6003E75")]
	public static string Reflect(ReflectObject reflectObj, object[] idxs)
	{
		return null;
	}

	[Address(RVA = "0x932000", Offset = "0x930800", Length = "0x1ED")]
	[Token(Token = "0x6003E76")]
	public static string Reflect(UnityEngine.Object sourceObj, string fieldName, object[] idxs)
	{
		return null;
	}

	[Address(RVA = "0x931DE0", Offset = "0x9305E0", Length = "0x219")]
	[Token(Token = "0x6003E77")]
	public static object Reflect(object obj, string path, string[] idxs)
	{
		return null;
	}

	[Address(RVA = "0x930DF0", Offset = "0x92F5F0", Length = "0x4BB")]
	[Token(Token = "0x6003E78")]
	public static object GetValue(object sourceObj, string name, object[] objs = null, BindingFlags bf = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
	{
		return null;
	}

	[Address(RVA = "0x930490", Offset = "0x92EC90", Length = "0x77")]
	[Token(Token = "0x6003E79")]
	public static Type GetElementType(Type type)
	{
		return null;
	}

	[Address(RVA = "0x9307B0", Offset = "0x92EFB0", Length = "0x1D8")]
	[Token(Token = "0x6003E7A")]
	public static Type GetMemberType(MemberInfo memberInfo)
	{
		return null;
	}

	[Address(RVA = "0x930370", Offset = "0x92EB70", Length = "0x111")]
	[Token(Token = "0x6003E7B")]
	public static int ArrayDepth(Type type, string path)
	{
		return default(int);
	}

	[Token(Token = "0x6003E7C")]
	[Address(RVA = "0x930510", Offset = "0x92ED10", Length = "0xDA")]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[Token(Token = "0x6003E7D")]
	[Address(RVA = "0x9312D0", Offset = "0x92FAD0", Length = "0xA2")]
	public static bool IsArray(Type type)
	{
		return default(bool);
	}

	[Token(Token = "0x6003E7E")]
	[Address(RVA = "0x9312B0", Offset = "0x92FAB0", Length = "0x19")]
	public static bool IsArrayFromType(Type t)
	{
		return default(bool);
	}

	[Address(RVA = "0x9314C0", Offset = "0x92FCC0", Length = "0xD3")]
	[Token(Token = "0x6003E7F")]
	public static bool IsList(Type type)
	{
		return default(bool);
	}

	[Address(RVA = "0x931380", Offset = "0x92FB80", Length = "0x135")]
	[Token(Token = "0x6003E80")]
	public static bool IsClass(Type type)
	{
		return default(bool);
	}

	[Address(RVA = "0x930B70", Offset = "0x92F370", Length = "0xE8")]
	[Token(Token = "0x6003E81")]
	public static Type[] GetSubClassOf(Type type)
	{
		return null;
	}

	[Address(RVA = "0x930990", Offset = "0x92F190", Length = "0x1DB")]
	[Token(Token = "0x6003E82")]
	public static string[] GetSubClassNameOf(Type type)
	{
		return null;
	}

	[Token(Token = "0x6003E83")]
	[Address(RVA = "0x9315A0", Offset = "0x92FDA0", Length = "0xD2")]
	public static bool IsSubClassOf(Type type, Type baseType)
	{
		return default(bool);
	}
}
