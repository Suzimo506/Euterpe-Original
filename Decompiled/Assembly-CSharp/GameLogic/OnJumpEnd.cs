using Cpp2ILInjected;
using Spine;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x20004A2")]
public class OnJumpEnd : DoNothing
{
	[Token(Token = "0x4001909")]
	[FieldOffset(Offset = "0x28")]
	private SpineActionController m_Sac;

	[Token(Token = "0x400190A")]
	[FieldOffset(Offset = "0x30")]
	private Animator m_Animator;

	[Address(RVA = "0x5D56F0", Offset = "0x5D3EF0", Length = "0xB0")]
	[Token(Token = "0x60034D5")]
	public override void Init()
	{
	}

	[Address(RVA = "0x5D54D0", Offset = "0x5D3CD0", Length = "0x217")]
	[Token(Token = "0x60034D6")]
	public override void Do(TrackEntry entry)
	{
	}

	[Token(Token = "0x60034D7")]
	[Address(RVA = "0x441AE0", Offset = "0x4402E0", Length = "0x7")]
	public OnJumpEnd()
	{
	}
}
