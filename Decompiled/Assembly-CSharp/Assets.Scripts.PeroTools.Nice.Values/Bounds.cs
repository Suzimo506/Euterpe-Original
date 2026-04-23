using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D6")]
public class Bounds : IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400219D")]
	[SerializeField]
	private UnityEngine.Bounds m_Result;

	[Token(Token = "0x17000557")]
	public object result
	{
		[Address(RVA = "0x9737F0", Offset = "0x971FF0", Length = "0x4F")]
		[Token(Token = "0x60039E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039E1")]
		[Address(RVA = "0x973840", Offset = "0x972040", Length = "0x73")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039E2")]
	public Bounds()
	{
	}
}
