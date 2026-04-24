using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000638")]
public class SetToggleOn : Action
{
	[SerializeField]
	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x10")]
	private Toggle m_Toggle;

	[Address(RVA = "0x74E590", Offset = "0x74CD90", Length = "0x20")]
	[Token(Token = "0x6003BEC")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BED")]
	public SetToggleOn()
	{
	}
}
