using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200063C")]
public class ToggleGameObjectActivation : Action
{
	[FieldOffset(Offset = "0x10")]
	[Attribute(Name = "VariableAttribute", RVA = "0x25BF0", Offset = "0x24FF0")]
	[SerializeField]
	[Token(Token = "0x4002322")]
	private IVariable m_GameObject;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002323")]
	[SerializeField]
	[HideInInspector]
	private Toggle m_Toggle;

	[Token(Token = "0x6003BF6")]
	[Address(RVA = "0x74EBA0", Offset = "0x74D3A0", Length = "0x118")]
	public override void Enter()
	{
	}

	[Address(RVA = "0x74ECC0", Offset = "0x74D4C0", Length = "0xC1")]
	[Token(Token = "0x6003BF7")]
	public override void Exit()
	{
	}

	[Address(RVA = "0x74ED90", Offset = "0x74D590", Length = "0x5D")]
	[Token(Token = "0x6003BF8")]
	private void OnValueChanged(bool isOn)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BF9")]
	public ToggleGameObjectActivation()
	{
	}
}
