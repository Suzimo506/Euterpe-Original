using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Datas;

[Token(Token = "0x2000605")]
[CreateAssetMenu]
public class SingletonDataObject : DataObject
{
	[Token(Token = "0x40021D1")]
	[SerializeField]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsSaved;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40021D2")]
	private Dictionary<string, IVariable> m_OriginField;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40021D3")]
	public bool isSync;

	[Address(RVA = "0x9843E0", Offset = "0x982BE0", Length = "0x94")]
	[Token(Token = "0x6003AA3")]
	public void Load()
	{
	}

	[Token(Token = "0x6003AA4")]
	[Address(RVA = "0x984480", Offset = "0x982C80", Length = "0x2CF")]
	public void Reload()
	{
	}

	[Address(RVA = "0x9842C0", Offset = "0x982AC0", Length = "0x11F")]
	[Token(Token = "0x6003AA5")]
	public void LoadFromJson(string json)
	{
	}

	[Address(RVA = "0x9841A0", Offset = "0x9829A0", Length = "0x11F")]
	[Obsolete]
	[Token(Token = "0x6003AA6")]
	public void LoadFromBytes(byte[] bytes)
	{
	}

	[Address(RVA = "0x984840", Offset = "0x983040", Length = "0x263")]
	[Token(Token = "0x6003AA7")]
	public Dictionary<string, IVariable> ToConstance()
	{
		return null;
	}

	[Token(Token = "0x6003AA8")]
	[Address(RVA = "0x983D10", Offset = "0x982510", Length = "0x117")]
	public SingletonDataObject Clone()
	{
		return null;
	}

	[Token(Token = "0x6003AA9")]
	[Address(RVA = "0x984AB0", Offset = "0x9832B0", Length = "0x19E")]
	public string ToJson()
	{
		return null;
	}

	[Obsolete]
	[Token(Token = "0x6003AAA")]
	[Address(RVA = "0x9847F0", Offset = "0x982FF0", Length = "0x47")]
	public byte[] ToBytes()
	{
		return null;
	}

	[Address(RVA = "0x984760", Offset = "0x982F60", Length = "0x85")]
	[Token(Token = "0x6003AAB")]
	public void Save()
	{
	}

	[Token(Token = "0x6003AAC")]
	[Address(RVA = "0x984750", Offset = "0x982F50", Length = "0x10")]
	public void Reset()
	{
	}

	[Address(RVA = "0x983FD0", Offset = "0x9827D0", Length = "0x1CE")]
	[Token(Token = "0x6003AAD")]
	public static Dictionary<string, IVariable> JsonToField(string json)
	{
		return null;
	}

	[Address(RVA = "0x983E30", Offset = "0x982630", Length = "0x197")]
	[Token(Token = "0x6003AAE")]
	public static string FieldToJson(Dictionary<string, IVariable> field)
	{
		return null;
	}

	[Token(Token = "0x6003AAF")]
	[Address(RVA = "0x9786D0", Offset = "0x976ED0", Length = "0x69")]
	public SingletonDataObject()
	{
	}
}
