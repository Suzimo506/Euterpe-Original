using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Assets.Scripts.PeroTools.Nice.Variables;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000630")]
public class SetFunction : Action
{
	[SerializeField]
	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x10")]
	private MethodType m_Type;

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40022EE")]
	private Script m_Script;

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40022EF")]
	private string m_EnumKey;

	[Token(Token = "0x40022F0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<IVariable> m_Params;

	[Address(RVA = "0x74B6E0", Offset = "0x749EE0", Length = "0x22A")]
	[Token(Token = "0x6003BCD")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x74B910", Offset = "0x74A110", Length = "0x91")]
	[Token(Token = "0x6003BCE")]
	public SetFunction()
	{
	}
}
