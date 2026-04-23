using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;

[Token(Token = "0x2000765")]
public class OnCharacterJumpTiming : StateMachineBehaviour
{
	[Token(Token = "0x2000CF8")]
	public enum JumpState
	{
		[Token(Token = "0x4003E57")]
		Start,
		[Token(Token = "0x4003E58")]
		End
	}

	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002733")]
	public float percent;

	[Token(Token = "0x4002734")]
	[FieldOffset(Offset = "0x1C")]
	public JumpState state;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002735")]
	public bool endDust;

	[Token(Token = "0x4002736")]
	private static Coroutine m_StartCoroutine;

	[Token(Token = "0x4002737")]
	private static Coroutine m_EndCoroutine;

	[Token(Token = "0x6004574")]
	[Address(RVA = "0x4A3B40", Offset = "0x4A2340", Length = "0x17E")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004575")]
	[Address(RVA = "0x4A38B0", Offset = "0x4A20B0", Length = "0x28C")]
	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo)
	{
		return null;
	}

	[Token(Token = "0x6004576")]
	[Address(RVA = "0x4A3CC0", Offset = "0x4A24C0", Length = "0xB")]
	public OnCharacterJumpTiming()
	{
	}
}
