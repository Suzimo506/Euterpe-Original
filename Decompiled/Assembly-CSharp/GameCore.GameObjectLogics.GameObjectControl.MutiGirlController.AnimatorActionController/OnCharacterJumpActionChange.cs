using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController.AnimatorActionController;

[Token(Token = "0x2000491")]
public class OnCharacterJumpActionChange : StateMachineBehaviour
{
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x40018A6")]
	[FieldOffset(Offset = "0x18")]
	public float percent;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40018A7")]
	public OnCharacterJumpTiming.JumpState state;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40018A8")]
	public bool endDust;

	[Token(Token = "0x40018A9")]
	private static Coroutine m_StartCoroutine;

	[Token(Token = "0x40018AA")]
	private static Coroutine m_EndCoroutine;

	[Address(RVA = "0x849080", Offset = "0x847880", Length = "0x17E")]
	[Token(Token = "0x6003442")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA = "0x848ED0", Offset = "0x8476D0", Length = "0x1A7")]
	[Token(Token = "0x6003443")]
	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo)
	{
		return null;
	}

	[Address(RVA = "0x4A3CC0", Offset = "0x4A24C0", Length = "0xB")]
	[Token(Token = "0x6003444")]
	public OnCharacterJumpActionChange()
	{
	}
}
