using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000636")]
public class SetToggle : Action
{
	[Token(Token = "0x4002317")]
	[SerializeField]
	[FieldOffset(Offset = "0x10")]
	private Toggle m_Toggle;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002318")]
	[Attribute(Name = "VariableAttribute", RVA = "0x24630", Offset = "0x23A30")]
	[SerializeField]
	private IVariable m_IsOn;

	[Address(RVA = "0x74E5C0", Offset = "0x74CDC0", Length = "0x5E")]
	[Token(Token = "0x6003BE8")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003BE9")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public SetToggle()
	{
	}
}
