using System;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005DC")]
public class Enum : IValue
{
	[SerializeField]
	[Token(Token = "0x40021A3")]
	[FieldOffset(Offset = "0x10")]
	private System.Enum m_Result;

	[Token(Token = "0x1700055D")]
	public object result
	{
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		[Token(Token = "0x60039F2")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039F3")]
		[Address(RVA = "0x979960", Offset = "0x978160", Length = "0x90")]
		set
		{
		}
	}

	[Token(Token = "0x60039F4")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Enum()
	{
	}
}
