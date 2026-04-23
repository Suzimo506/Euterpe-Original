using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;
using PeroTools.Saves;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000640")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class ConfigManager : Singleton<ConfigManager>
{
	[Token(Token = "0x4002337")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_LocalFileSuffixs;

	[Token(Token = "0x4002338")]
	[FieldOffset(Offset = "0x18")]
	private DBConfig m_DbConfig;

	[Token(Token = "0x4002339")]
	private static Dictionary<Type, string> s_TypeDic;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400233A")]
	[Obsolete]
	private readonly Dictionary<string, JArray> m_Dictionary;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400233B")]
	[Obsolete]
	private readonly Dictionary<string, TextAsset> m_TextAssets;

	[Token(Token = "0x400233C")]
	[FieldOffset(Offset = "0x30")]
	private PrefsHandler m_PrefsHandler;

	[Token(Token = "0x1700059B")]
	[Obsolete]
	public JArray Item
	{
		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x7572A0", Offset = "0x755AA0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C26")]
	[Address(RVA = "0x912180", Offset = "0x910980", Length = "0x100")]
	public T GetConfigObject<T>(int albumJsonIndex = -1) where T : BaseDBConfigObject, new()
	{
		return null;
	}

	[Address(RVA = "0x7558D0", Offset = "0x7540D0", Length = "0x184")]
	[Token(Token = "0x6003C27")]
	private BaseDBConfigObject GetConfigObject(Type t, int albumIndex = -1)
	{
		return null;
	}

	[Address(RVA = "0x755840", Offset = "0x754040", Length = "0x82")]
	[Token(Token = "0x6003C28")]
	private BaseDBConfigObject GetConfigObject(Type type, string name)
	{
		return null;
	}

	[Address(RVA = "0x756790", Offset = "0x754F90", Length = "0x278")]
	[Token(Token = "0x6003C29")]
	private BaseDBConfigObject LoadConfigFile(string name, Type type, bool cache = false)
	{
		return null;
	}

	[Address(RVA = "0x756610", Offset = "0x754E10", Length = "0x174")]
	[Token(Token = "0x6003C2A")]
	private bool IsUseLocalFileSuffix(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C2B")]
	[Address(RVA = "0x756510", Offset = "0x754D10", Length = "0xF7")]
	private void Init()
	{
	}

	[Token(Token = "0x6003C2C")]
	[Address(RVA = "0x7564B0", Offset = "0x754CB0", Length = "0x5A")]
	private void InitPrefsHandler()
	{
	}

	[Obsolete]
	[Token(Token = "0x6003C2E")]
	[Address(RVA = "0x755FD0", Offset = "0x7547D0", Length = "0x463")]
	public JArray GetJson(string name, bool localization)
	{
		return null;
	}

	[Address(RVA = "0x755240", Offset = "0x753A40", Length = "0xB1")]
	[Token(Token = "0x6003C2F")]
	public void Add(string key, string data)
	{
	}

	[Token(Token = "0x6003C30")]
	[Address(RVA = "0x755330", Offset = "0x753B30", Length = "0x43")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003C31")]
	[Address(RVA = "0x756A10", Offset = "0x755210", Length = "0x6F")]
	public void Remove(string key)
	{
	}

	[Token(Token = "0x6003C32")]
	[Address(RVA = "0x755380", Offset = "0x753B80", Length = "0xD8")]
	public JToken Convert(string path)
	{
		return null;
	}

	[Obsolete]
	[Token(Token = "0x6003C33")]
	[Address(RVA = "0x7556B0", Offset = "0x753EB0", Length = "0xF8")]
	public int GetConfigIndex(string fileName, string cmpKey, object cmpValue)
	{
		return default(int);
	}

	[Token(Token = "0x6003C34")]
	[Address(RVA = "0x7557B0", Offset = "0x753FB0", Length = "0x3D")]
	[Obsolete]
	public int GetConfigIntValue(string fileName, int index, string key)
	{
		return default(int);
	}

	[Address(RVA = "0x7557F0", Offset = "0x753FF0", Length = "0x47")]
	[Token(Token = "0x6003C35")]
	[Obsolete]
	public int GetConfigIntValue(string fileName, string cmpKey, string targetKey, object cmpValue)
	{
		return default(int);
	}

	[Token(Token = "0x6003C36")]
	[Address(RVA = "0x755670", Offset = "0x753E70", Length = "0x3D")]
	[Obsolete]
	public float GetConfigFloatValue(string fileName, int index, string key)
	{
		return default(float);
	}

	[Address(RVA = "0x755620", Offset = "0x753E20", Length = "0x47")]
	[Token(Token = "0x6003C37")]
	[Obsolete]
	public float GetConfigFloatValue(string fileName, string cmpKey, string targetKey, object cmpValue)
	{
		return default(float);
	}

	[Obsolete]
	[Token(Token = "0x6003C38")]
	[Address(RVA = "0x755490", Offset = "0x753C90", Length = "0xB7")]
	public bool GetConfigBoolValue(string fileName, int index, string key)
	{
		return default(bool);
	}

	[Address(RVA = "0x755550", Offset = "0x753D50", Length = "0xC1")]
	[Obsolete]
	[Token(Token = "0x6003C39")]
	public bool GetConfigBoolValue(string fileName, string cmpKey, string targetKey, object cmpValue)
	{
		return default(bool);
	}

	[Address(RVA = "0x755A60", Offset = "0x754260", Length = "0x34")]
	[Token(Token = "0x6003C3A")]
	[Obsolete]
	public string GetConfigStringValue(string fileName, int index, string key)
	{
		return null;
	}

	[Obsolete]
	[Token(Token = "0x6003C3B")]
	[Address(RVA = "0x755AA0", Offset = "0x7542A0", Length = "0x3E")]
	public string GetConfigStringValue(string fileName, string cmpKey, string targetKey, object cmpValue)
	{
		return null;
	}

	[Obsolete]
	[Token(Token = "0x6003C3C")]
	[Address(RVA = "0x755AE0", Offset = "0x7542E0", Length = "0x31B")]
	public JToken GetConfigToken(string fileName, int index, string key)
	{
		return null;
	}

	[Address(RVA = "0x755E00", Offset = "0x754600", Length = "0x1C9")]
	[Token(Token = "0x6003C3D")]
	[Obsolete]
	public JToken GetConfigToken(string fileName, string cmpKey, string targetKey, object cmpValue)
	{
		return null;
	}

	[Address(RVA = "0x912290", Offset = "0x910A90", Length = "0x1B5")]
	[Token(Token = "0x6003C3E")]
	[Obsolete]
	public T GetObject<T>(string fileName)
	{
		return (T)null;
	}

	[Token(Token = "0x6003C3F")]
	[Obsolete]
	[Address(RVA = "0x756440", Offset = "0x754C40", Length = "0x3D")]
	public object GetObject(string fileName, Type type)
	{
		return null;
	}

	[Token(Token = "0x6003C40")]
	[Address(RVA = "0x756480", Offset = "0x754C80", Length = "0x27")]
	public string GetString(string fileName)
	{
		return null;
	}

	[Address(RVA = "0x756A80", Offset = "0x755280", Length = "0x78")]
	[Token(Token = "0x6003C41")]
	public void SaveObject(string fileName, object obj)
	{
	}

	[Address(RVA = "0x756B00", Offset = "0x755300", Length = "0x27")]
	[Token(Token = "0x6003C42")]
	public void SaveString(string fileName, string s)
	{
	}

	[Address(RVA = "0x756B30", Offset = "0x755330", Length = "0x27")]
	[Token(Token = "0x6003C43")]
	public void Save()
	{
	}

	[Address(RVA = "0x755460", Offset = "0x753C60", Length = "0x27")]
	[Token(Token = "0x6003C44")]
	public void Delete(string fileName)
	{
	}

	[Address(RVA = "0x755300", Offset = "0x753B00", Length = "0x27")]
	[Token(Token = "0x6003C45")]
	public void ClearAllPrefs()
	{
	}

	[Token(Token = "0x6003C46")]
	[Address(RVA = "0x757150", Offset = "0x755950", Length = "0x149")]
	public ConfigManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
