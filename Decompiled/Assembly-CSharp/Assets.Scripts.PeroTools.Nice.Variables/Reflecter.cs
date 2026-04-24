using System;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C6")]
public class Reflecter
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002185")]
	private string m_Path;

	[Token(Token = "0x4002186")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private IVariable[] m_Params;

	[Token(Token = "0x4002187")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private Type m_Type;

	[Address(RVA = "0x982420", Offset = "0x980C20", Length = "0x4EC")]
	[Token(Token = "0x60039A5")]
	public object GetValue(object source)
	{
		return null;
	}

	[Address(RVA = "0x982D10", Offset = "0x981510", Length = "0x265")]
	[Token(Token = "0x60039A6")]
	public void SetValue(object value, object source)
	{
	}

	[Address(RVA = "0x982230", Offset = "0x980A30", Length = "0x1E9")]
	[Token(Token = "0x60039A7")]
	private object GetSource(object source)
	{
		return null;
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039A8")]
	public Reflecter()
	{
	}
}
