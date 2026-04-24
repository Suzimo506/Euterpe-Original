using System.Collections.Generic;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Nice.Actions;

[Token(Token = "0x200061B")]
public abstract class Group : Action
{
	[SerializeField]
	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x10")]
	protected List<IPlayable> m_Playables;

	[Token(Token = "0x4002274")]
	[FieldOffset(Offset = "0x18")]
	protected DG.Tweening.Sequence m_Sequence;

	[Token(Token = "0x4002275")]
	[FieldOffset(Offset = "0x20")]
	protected float m_Time;

	[Token(Token = "0x17000585")]
	public override float duration
	{
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x745510", Offset = "0x743D10", Length = "0x103")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000586")]
	public List<IPlayable> playables
	{
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Address(RVA = "0x93C350", Offset = "0x93AB50", Length = "0x1E3")]
	[Token(Token = "0x6003B6C")]
	public List<T> GetPlayables<T>() where T : IPlayable
	{
		return null;
	}

	[Address(RVA = "0x744CE0", Offset = "0x7434E0", Length = "0x136")]
	[Token(Token = "0x6003B6D")]
	public override void Enter()
	{
	}

	[Token(Token = "0x6003B6E")]
	[Address(RVA = "0x744E20", Offset = "0x743620", Length = "0x2D5")]
	public override void Execute()
	{
	}

	[Token(Token = "0x6003B6F")]
	[Address(RVA = "0x745100", Offset = "0x743900", Length = "0x103")]
	public override void Exit()
	{
	}

	[Address(RVA = "0x745210", Offset = "0x743A10", Length = "0x13E")]
	[Token(Token = "0x6003B70")]
	public override void Pause()
	{
	}

	[Address(RVA = "0x745350", Offset = "0x743B50", Length = "0x14E")]
	[Token(Token = "0x6003B71")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6003B72")]
	[Address(RVA = "0x7454A0", Offset = "0x743CA0", Length = "0x70")]
	protected Group()
	{
	}
}
