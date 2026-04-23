using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl;

[Token(Token = "0x2000766")]
public class PlayAnimation : StateMachineBehaviour
{
	[Token(Token = "0x2000CFA")]
	public enum Timing
	{
		[Token(Token = "0x4003E5D")]
		Enter,
		[Token(Token = "0x4003E5E")]
		Exit
	}

	[Token(Token = "0x2000CFB")]
	public enum PlayType
	{
		[Token(Token = "0x4003E60")]
		Skeleton,
		[Token(Token = "0x4003E61")]
		DOTween,
		[Token(Token = "0x4003E62")]
		Animation,
		[Token(Token = "0x4003E63")]
		Animator
	}

	[Token(Token = "0x2000CFC")]
	public enum ActionType
	{
		[Token(Token = "0x4003E65")]
		Reset,
		[Token(Token = "0x4003E66")]
		KeepCurrent
	}

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002738")]
	public PlayType playType;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002739")]
	public List<string> animationNames;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400273A")]
	public bool isLoop;

	[Token(Token = "0x400273B")]
	[FieldOffset(Offset = "0x2C")]
	public ActionType actionType;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400273C")]
	public Timing timing;

	[Token(Token = "0x400273D")]
	[FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0x38")]
	private SkeletonAnimation m_SAnimation;

	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x40")]
	private Animation m_Animation;

	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0x48")]
	private Sequence m_DelaySeq;

	[Token(Token = "0x6004577")]
	[Address(RVA = "0x4A3CD0", Offset = "0x4A24D0", Length = "0xF")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004578")]
	[Address(RVA = "0x4A3CE0", Offset = "0x4A24E0", Length = "0xF")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6004579")]
	[Address(RVA = "0x4A3CF0", Offset = "0x4A24F0", Length = "0x31C")]
	private void Play(Animator animator)
	{
	}

	[Token(Token = "0x600457A")]
	[Address(RVA = "0x4A38A0", Offset = "0x4A20A0", Length = "0x7")]
	public PlayAnimation()
	{
	}
}
