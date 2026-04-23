using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Values;

[Token(Token = "0x20005D0")]
public class Float : IValue
{
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002197")]
	private float m_Result;

	[Token(Token = "0x17000551")]
	public object result
	{
		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x979E70", Offset = "0x978670", Length = "0x46")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039CF")]
		[Address(RVA = "0x979EC0", Offset = "0x9786C0", Length = "0x67")]
		set
		{
		}
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60039D0")]
	public Float()
	{
	}
}
