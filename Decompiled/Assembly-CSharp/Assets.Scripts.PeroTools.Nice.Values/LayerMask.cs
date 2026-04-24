using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D8")]
public class LayerMask : IValue
{
	[Token(Token = "0x400219F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private UnityEngine.LayerMask m_Result;

	[Token(Token = "0x17000559")]
	public object result
	{
		[Address(RVA = "0x97E620", Offset = "0x97CE20", Length = "0x42")]
		[Token(Token = "0x60039E6")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039E7")]
		[Address(RVA = "0x97E670", Offset = "0x97CE70", Length = "0x67")]
		set
		{
		}
	}

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public LayerMask()
	{
	}
}
