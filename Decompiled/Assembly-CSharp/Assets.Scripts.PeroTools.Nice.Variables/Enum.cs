using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C3")]
public class Enum : IVariable, IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400217C")]
	private string m_Key;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x400217D")]
	private List<IVariable> m_Params;

	[Token(Token = "0x17000542")]
	public object result
	{
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x9797A0", Offset = "0x977FA0", Length = "0x1BE")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
		set
		{
		}
	}

	[Token(Token = "0x6003994")]
	[Address(RVA = "0x979730", Offset = "0x977F30", Length = "0x69")]
	public Enum()
	{
	}
}
