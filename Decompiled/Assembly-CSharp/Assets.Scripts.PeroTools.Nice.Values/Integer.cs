using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005CF")]
public class Integer : IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002196")]
	[SerializeField]
	private int m_Result;

	[Token(Token = "0x17000550")]
	public object result
	{
		[Address(RVA = "0x97E560", Offset = "0x97CD60", Length = "0x42")]
		[Token(Token = "0x60039CB")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039CC")]
		[Address(RVA = "0x97E5B0", Offset = "0x97CDB0", Length = "0x67")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039CD")]
	public Integer()
	{
	}
}
