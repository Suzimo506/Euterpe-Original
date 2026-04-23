using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Datas;

[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2060", Offset = "0x1460")]
[Token(Token = "0x2000602")]
public class Data : IData, IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40021C9")]
	private string m_Uid;

	[SerializeField]
	[Token(Token = "0x40021CA")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, IVariable> m_Fields;

	[Token(Token = "0x40021CB")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, IVariable> m_CurFields;

	[Token(Token = "0x1700056F")]
	public string uid
	{
		[Token(Token = "0x6003A80")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000570")]
	public Dictionary<string, IVariable> fields
	{
		[Address(RVA = "0x978E20", Offset = "0x977620", Length = "0x30F")]
		[Token(Token = "0x6003A82")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A81")]
		[Address(RVA = "0x979130", Offset = "0x977930", Length = "0x286")]
		set
		{
		}
	}

	[Token(Token = "0x17000571")]
	public IVariable Item
	{
		[Token(Token = "0x6003A83")]
		[Address(RVA = "0x978740", Offset = "0x976F40", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A84")]
		[Address(RVA = "0x978750", Offset = "0x976F50", Length = "0x77")]
		set
		{
		}
	}

	[Token(Token = "0x17000572")]
	public object result
	{
		[Address(RVA = "0x475C50", Offset = "0x474450", Length = "0x4")]
		[Token(Token = "0x6003A86")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A85")]
		[Address(RVA = "0x9793C0", Offset = "0x977BC0", Length = "0xDA")]
		set
		{
		}
	}

	[Token(Token = "0x6003A87")]
	[Address(RVA = "0x978A50", Offset = "0x977250", Length = "0x329")]
	public Data(string uid, IData data = null)
	{
	}

	[Token(Token = "0x6003A88")]
	[Address(RVA = "0x978D80", Offset = "0x977580", Length = "0x95")]
	public Data()
	{
	}
}
