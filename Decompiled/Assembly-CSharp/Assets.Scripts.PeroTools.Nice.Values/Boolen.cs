using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D1")]
public class Boolen : IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002198")]
	private bool m_Result;

	[Token(Token = "0x17000552")]
	public object result
	{
		[Token(Token = "0x60039D1")]
		[Address(RVA = "0x973730", Offset = "0x971F30", Length = "0x43")]
		get
		{
			return null;
		}
		[Address(RVA = "0x973780", Offset = "0x971F80", Length = "0x68")]
		[Token(Token = "0x60039D2")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039D3")]
	public Boolen()
	{
	}
}
