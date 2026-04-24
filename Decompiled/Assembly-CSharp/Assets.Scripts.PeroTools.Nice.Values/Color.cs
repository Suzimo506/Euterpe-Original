using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D7")]
public class Color : IValue
{
	[SerializeField]
	[Token(Token = "0x400219E")]
	[FieldOffset(Offset = "0x10")]
	private UnityEngine.Color m_Result;

	[Token(Token = "0x17000558")]
	public object result
	{
		[Address(RVA = "0x975A50", Offset = "0x974250", Length = "0x44")]
		[Token(Token = "0x60039E3")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039E4")]
		[Address(RVA = "0x975AA0", Offset = "0x9742A0", Length = "0x69")]
		set
		{
		}
	}

	[Token(Token = "0x60039E5")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Color()
	{
	}
}
