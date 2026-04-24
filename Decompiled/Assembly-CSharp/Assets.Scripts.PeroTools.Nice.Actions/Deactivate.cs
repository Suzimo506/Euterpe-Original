using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000618")]
public class Deactivate : Action
{
	[Token(Token = "0x4002266")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x11BD0", Offset = "0x10FD0")]
	private IVariable m_Object;

	[Token(Token = "0x6003B5E")]
	[Address(RVA = "0x73E130", Offset = "0x73C930", Length = "0x14B")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003B5F")]
	public Deactivate()
	{
	}
}
