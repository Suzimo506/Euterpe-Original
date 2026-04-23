using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004A")]
public class OnToneChange : StateMachineBehaviour
{
	[Token(Token = "0x20009AF")]
	public enum ToneState
	{
		[Token(Token = "0x40034C0")]
		Ground,
		[Token(Token = "0x40034C1")]
		Air
	}

	[Token(Token = "0x40001B6")]
	[Attribute(Name = "RangeAttribute", RVA = "0x25E40", Offset = "0x25240")]
	[FieldOffset(Offset = "0x18")]
	public float percent;

	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x1C")]
	public ToneState state;

	[Token(Token = "0x40001B8")]
	private static Coroutine s_AirCoroutine;

	[Token(Token = "0x40001B9")]
	private static Coroutine s_GroundCoroutine;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x86F4B0", Offset = "0x86DCB0", Length = "0x17E")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Address(RVA = "0x86F330", Offset = "0x86DB30", Length = "0x178")]
	[Token(Token = "0x6000214")]
	private Coroutine Invoke(Animator animator, AnimatorStateInfo stateInfo)
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	public OnToneChange()
	{
	}
}
