using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x200049F")]
public class MultiOnJumpEnd : DoNothing
{
	[Token(Token = "0x4001906")]
	[FieldOffset(Offset = "0x28")]
	private SpineActionController m_Sac;

	[Token(Token = "0x4001907")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Animator;

	[Address(RVA = "0x5D4350", Offset = "0x5D2B50", Length = "0xB0")]
	[Token(Token = "0x60034CB")]
	public override void Init()
	{
	}

	[Address(RVA = "0x5D4120", Offset = "0x5D2920", Length = "0x227")]
	[Token(Token = "0x60034CC")]
	public override void Do(TrackEntry entry)
	{
	}

	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	[Token(Token = "0x60034CD")]
	public MultiOnJumpEnd()
	{
	}
}
