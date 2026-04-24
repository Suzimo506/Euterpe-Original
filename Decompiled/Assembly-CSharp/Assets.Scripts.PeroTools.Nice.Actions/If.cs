using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200061C")]
public class If : Group
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x148C0", Offset = "0x13CC0")]
	[Token(Token = "0x4002276")]
	[FieldOffset(Offset = "0x28")]
	private IVariable m_IsExecute;

	[Token(Token = "0x6003B73")]
	[Address(RVA = "0x745620", Offset = "0x743E20", Length = "0x4D")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B74")]
	[Address(RVA = "0x745670", Offset = "0x743E70", Length = "0x7")]
	public If()
	{
	}
}
