using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000049")]
public class OnCharactorJumpStart : StateMachineBehaviour
{
	[Address(RVA = "0x86F080", Offset = "0x86D880", Length = "0xB6")]
	[Token(Token = "0x600020F")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x86F140", Offset = "0x86D940", Length = "0x1E3")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	public OnCharactorJumpStart()
	{
	}
}
