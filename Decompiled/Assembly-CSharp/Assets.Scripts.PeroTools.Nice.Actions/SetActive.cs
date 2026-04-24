using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200062F")]
public class SetActive : Action
{
	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x1F870", Offset = "0x1EC70")]
	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x10")]
	private IVariable m_Object;

	[SerializeField]
	[Attribute(Name = "VariableAttribute", RVA = "0x1FA90", Offset = "0x1EE90")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40022EC")]
	private IVariable m_IsActive;

	[Token(Token = "0x6003BCB")]
	[Address(RVA = "0x74B560", Offset = "0x749D60", Length = "0x170")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BCC")]
	public SetActive()
	{
	}
}
