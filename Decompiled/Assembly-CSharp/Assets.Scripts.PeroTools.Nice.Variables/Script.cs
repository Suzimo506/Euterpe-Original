using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C5")]
public class Script : IVariable, IValue
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4002183")]
	private GameObject m_GameObject;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002184")]
	[SerializeField]
	private List<Reflecter> m_Reflecters;

	[Token(Token = "0x17000544")]
	public object result
	{
		[Address(RVA = "0x983990", Offset = "0x982190", Length = "0x7")]
		[Token(Token = "0x600399F")]
		get
		{
			return null;
		}
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		[Token(Token = "0x60039A0")]
		set
		{
		}
	}

	[Address(RVA = "0x983990", Offset = "0x982190", Length = "0x7")]
	[Token(Token = "0x60039A1")]
	public void Invoke()
	{
	}

	[Address(RVA = "0x9838D0", Offset = "0x9820D0", Length = "0xBA")]
	[Token(Token = "0x60039A2")]
	public object GetValue()
	{
		return null;
	}

	[Token(Token = "0x60039A3")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public void SetValue(object value)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039A4")]
	public Script()
	{
	}
}
