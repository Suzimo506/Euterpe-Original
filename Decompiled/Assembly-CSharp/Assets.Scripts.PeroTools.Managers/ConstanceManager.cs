using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000641")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
public class ConstanceManager : SingletonScriptableObject<ConstanceManager>
{
	[Serializable]
	[Token(Token = "0x2000BEC")]
	public class ConstanceInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4003BB9")]
		public string key;

		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4003BBA")]
		public string value;

		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4003BBB")]
		public string description;

		[Token(Token = "0x6005FC7")]
		[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
		public ConstanceInfo()
		{
		}
	}

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400233D")]
	public List<ConstanceInfo> constances;

	[Token(Token = "0x1700059C")]
	public string Item
	{
		[Token(Token = "0x6003C48")]
		[Address(RVA = "0x757520", Offset = "0x755D20", Length = "0x174")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003C49")]
	[Address(RVA = "0x7573F0", Offset = "0x755BF0", Length = "0xB4")]
	public ConstanceInfo Get(string key)
	{
		return null;
	}

	[Address(RVA = "0x7573B0", Offset = "0x755BB0", Length = "0x1A")]
	[Token(Token = "0x6003C4A")]
	public float GetFloat(string key)
	{
		return default(float);
	}

	[Token(Token = "0x6003C4B")]
	[Address(RVA = "0x7573D0", Offset = "0x755BD0", Length = "0x1A")]
	public int GetInt(string key)
	{
		return default(int);
	}

	[Token(Token = "0x6003C4C")]
	[Address(RVA = "0x757320", Offset = "0x755B20", Length = "0x8B")]
	public decimal GetDecimal(string key)
	{
		return default(decimal);
	}

	[Token(Token = "0x6003C4D")]
	[Address(RVA = "0x7572B0", Offset = "0x755AB0", Length = "0x6E")]
	public bool GetBool(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C4E")]
	[Address(RVA = "0x7574B0", Offset = "0x755CB0", Length = "0x6E")]
	public ConstanceManager()
	{
		((SingletonScriptableObject<>)(object)this)._002Ector();
	}
}
