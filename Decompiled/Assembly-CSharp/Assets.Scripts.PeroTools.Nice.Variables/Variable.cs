using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Variables;

[Token(Token = "0x20005C8")]
public class Variable : IVariable, IValue
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400218E")]
	[SerializeField]
	private VariableType m_Type;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400218F")]
	[SerializeField]
	private string m_Uid;

	[Token(Token = "0x4002190")]
	[SerializeField]
	[FieldOffset(Offset = "0x20")]
	private IVariable m_Variable;

	[Token(Token = "0x17000549")]
	public object result
	{
		[Address(RVA = "0x9895F0", Offset = "0x987DF0", Length = "0x8B")]
		[Token(Token = "0x60039B2")]
		get
		{
			return null;
		}
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x989680", Offset = "0x987E80", Length = "0x87")]
		set
		{
		}
	}

	[Token(Token = "0x60039B4")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public Variable()
	{
	}
}
