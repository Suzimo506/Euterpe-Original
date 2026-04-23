using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C2")]
public class Constance : IVariable, IValue
{
	[Token(Token = "0x400217B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private IValue m_Value;

	[Token(Token = "0x17000541")]
	public object result
	{
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x975B10", Offset = "0x974310", Length = "0x48")]
		get
		{
			return null;
		}
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x975B60", Offset = "0x974360", Length = "0x76")]
		set
		{
		}
	}

	[Address(RVA = "0x494AC0", Offset = "0x4932C0", Length = "0x30")]
	[Token(Token = "0x6003990")]
	public Constance(IValue value)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003991")]
	public Constance()
	{
	}
}
