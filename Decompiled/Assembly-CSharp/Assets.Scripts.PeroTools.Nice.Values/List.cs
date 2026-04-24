using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005E5")]
public class List : IValue
{
	[Token(Token = "0x40021AC")]
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	private object m_Result;

	[Token(Token = "0x17000566")]
	public object result
	{
		[Token(Token = "0x6003A0E")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003A0F")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x6003A10")]
	[Address(RVA = "0x97E6E0", Offset = "0x97CEE0", Length = "0x69")]
	public List()
	{
	}
}
