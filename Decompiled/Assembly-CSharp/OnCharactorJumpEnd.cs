using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000048")]
public class OnCharactorJumpEnd : StateMachineBehaviour
{
	[Address(RVA = "0x86EFC0", Offset = "0x86D7C0", Length = "0xB6")]
	[Token(Token = "0x600020C")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600020D")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x600020E")]
	public OnCharactorJumpEnd()
	{
	}
}
