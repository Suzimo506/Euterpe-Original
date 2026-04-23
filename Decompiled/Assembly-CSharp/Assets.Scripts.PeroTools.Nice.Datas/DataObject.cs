using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Datas;

[CreateAssetMenu]
[Attribute(Name = "DefaultMemberAttribute", RVA = "0x2E90", Offset = "0x2290")]
[Token(Token = "0x2000604")]
public class DataObject : SerializedScriptableObject, IData
{
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40021D0")]
	[SerializeField]
	protected Dictionary<string, IVariable> m_Fields;

	[Token(Token = "0x17000575")]
	public Dictionary<string, IVariable> fields
	{
		[Address(RVA = "0x429C40", Offset = "0x428440", Length = "0x5")]
		[Token(Token = "0x6003A9F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000576")]
	public IVariable Item
	{
		[Address(RVA = "0x978740", Offset = "0x976F40", Length = "0x8")]
		[Token(Token = "0x6003AA0")]
		get
		{
			return null;
		}
		[Address(RVA = "0x978750", Offset = "0x976F50", Length = "0x77")]
		[Token(Token = "0x6003AA1")]
		set
		{
		}
	}

	[Address(RVA = "0x9786D0", Offset = "0x976ED0", Length = "0x69")]
	[Token(Token = "0x6003AA2")]
	public DataObject()
	{
	}
}
