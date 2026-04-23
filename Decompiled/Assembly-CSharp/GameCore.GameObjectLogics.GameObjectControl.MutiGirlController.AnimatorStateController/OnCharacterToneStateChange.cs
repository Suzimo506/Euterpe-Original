using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController.AnimatorStateController;

[Token(Token = "0x2000490")]
public class OnCharacterToneStateChange : StateMachineBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[Token(Token = "0x40018A2")]
	public float percent;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40018A3")]
	public OnToneChange.ToneState state;

	[Token(Token = "0x40018A4")]
	private static Coroutine s_AirCoroutine;

	[Token(Token = "0x40018A5")]
	private static Coroutine s_GroundCoroutine;

	[Address(RVA = "0x849720", Offset = "0x847F20", Length = "0x17E")]
	[Token(Token = "0x600343F")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0x8495A0", Offset = "0x847DA0", Length = "0x178")]
	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo)
	{
		return null;
	}

	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	[Token(Token = "0x6003441")]
	public OnCharacterToneStateChange()
	{
	}
}
