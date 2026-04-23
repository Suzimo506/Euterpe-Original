using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.PeroTools.Commons;

[Token(Token = "0x200069B")]
public static class JsonUtils
{
	[Address(RVA = "0x92DEA0", Offset = "0x92C6A0", Length = "0x43")]
	[Token(Token = "0x6003E30")]
	public static object UnityClone(this object obj)
	{
		return null;
	}

	[Address(RVA = "0x92D180", Offset = "0x92B980", Length = "0xA7")]
	[Token(Token = "0x6003E31")]
	public static object Clone(this object obj)
	{
		return null;
	}

	[Token(Token = "0x6003E32")]
	[Address(RVA = "0x92DC40", Offset = "0x92C440", Length = "0x1E4")]
	public static List<string> Paths(JToken jToken, params JTokenType[] types)
	{
		return null;
	}

	[Address(RVA = "0x92CF40", Offset = "0x92B740", Length = "0x237")]
	[Token(Token = "0x6003E33")]
	public static int ArrayDepth(JToken jToken, string path)
	{
		return default(int);
	}

	[Token(Token = "0x6003E34")]
	[Address(RVA = "0x92D9A0", Offset = "0x92C1A0", Length = "0x101")]
	public static bool IsNullOrEmpty(this JToken token)
	{
		return default(bool);
	}

	[Address(RVA = "0x92D630", Offset = "0x92BE30", Length = "0x365")]
	[Token(Token = "0x6003E35")]
	public static JToken GetValue(JToken jToken, string path, int[] idxs)
	{
		return null;
	}

	[Address(RVA = "0x92DAB0", Offset = "0x92C2B0", Length = "0xFE")]
	[Token(Token = "0x6003E36")]
	public static List<string> Keys(this JToken jToken)
	{
		return null;
	}

	[Address(RVA = "0x92DBB0", Offset = "0x92C3B0", Length = "0x80")]
	[Token(Token = "0x6003E37")]
	public static string Name(this JToken jToken)
	{
		return null;
	}

	[Address(RVA = "0x92D310", Offset = "0x92BB10", Length = "0x31B")]
	[Token(Token = "0x6003E38")]
	public static List<string> DiffProperty(object newValue, object oldValue)
	{
		return null;
	}

	[Address(RVA = "0x92DE40", Offset = "0x92C640", Length = "0x4B")]
	[Token(Token = "0x6003E39")]
	public static Dictionary<string, object> ToDictionary(object obj)
	{
		return null;
	}

	[Address(RVA = "0x92DE30", Offset = "0x92C630", Length = "0x7")]
	[Token(Token = "0x6003E3A")]
	public static JArray ToArray(string json)
	{
		return null;
	}

	[Address(RVA = "0x92DE90", Offset = "0x92C690", Length = "0x7")]
	[Token(Token = "0x6003E3B")]
	public static JObject ToObject(string json)
	{
		return null;
	}

	[Token(Token = "0x6003E3C")]
	[Address(RVA = "0x918B00", Offset = "0x917300", Length = "0x87")]
	public static T DeserializeByJson<T>(string jsonName, JsonSerializerSettings setting = null)
	{
		return (T)null;
	}

	[Token(Token = "0x6003E3D")]
	[Address(RVA = "0x918EF0", Offset = "0x9176F0", Length = "0xCB")]
	public static T Deserialize<T>(string json, JsonSerializerSettings setting = null)
	{
		return (T)null;
	}

	[Token(Token = "0x6003E3E")]
	[Address(RVA = "0x92D230", Offset = "0x92BA30", Length = "0x71")]
	public static object Deserialize(string json, Type type, JsonSerializerSettings setting = null)
	{
		return null;
	}

	[Token(Token = "0x6003E3F")]
	[Address(RVA = "0x92D2B0", Offset = "0x92BAB0", Length = "0x51")]
	public static object Deserialize(string json)
	{
		return null;
	}

	[Token(Token = "0x6003E40")]
	[Address(RVA = "0x9D1950", Offset = "0x9D0150", Length = "0x61")]
	public static string Serialize<T>(T target, JsonSerializerSettings setting = null)
	{
		return null;
	}
}
