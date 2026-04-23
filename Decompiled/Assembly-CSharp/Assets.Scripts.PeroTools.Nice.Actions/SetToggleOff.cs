using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x2000637")]
public class SetToggleOff : Action
{
	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private Toggle m_Toggle;

	[Address(RVA = "0x74E560", Offset = "0x74CD60", Length = "0x20")]
	[Token(Token = "0x6003BEA")]
	public override void Execute()
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x6003BEB")]
	public SetToggleOff()
	{
	}
}
