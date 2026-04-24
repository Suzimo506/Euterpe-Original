using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController.AnimatorStateController;

[Token(Token = "0x200048F")]
public class OnCharacterJumpStateChange : StateMachineBehaviour
{
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x400189E")]
	[FieldOffset(Offset = "0x18")]
	public float percent;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400189F")]
	public OnCharacterJumpTiming.JumpState state;

	[Token(Token = "0x40018A0")]
	private static Coroutine s_StartCoroutine;

	[Token(Token = "0x40018A1")]
	private static Coroutine s_EndCoroutine;

	[Token(Token = "0x600343C")]
	[Address(RVA = "0x849420", Offset = "0x847C20", Length = "0x17E")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA = "0x849200", Offset = "0x847A00", Length = "0x216")]
	[Token(Token = "0x600343D")]
	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo)
	{
		return null;
	}

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x600343E")]
	public OnCharacterJumpStateChange()
	{
	}
}
