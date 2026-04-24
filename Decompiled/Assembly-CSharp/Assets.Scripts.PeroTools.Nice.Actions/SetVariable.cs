using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000639")]
public class SetVariable : Action
{
	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private IVariable m_Variable;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400231C")]
	[SerializeField]
	private IVariable m_TargetVariable;

	[Address(RVA = "0x74E620", Offset = "0x74CE20", Length = "0x219")]
	[Token(Token = "0x6003BEE")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003BEF")]
	[Address(RVA = "0x74E840", Offset = "0x74D040", Length = "0x7D")]
	private bool IsVariableType()
	{
		return default(bool);
	}

	[Token(Token = "0x6003BF0")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SetVariable()
	{
	}
}
