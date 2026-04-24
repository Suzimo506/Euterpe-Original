using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DG.Tweening;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.PeroTools.Managers;

[Token(Token = "0x2000645")]
public class Effect
{
	[Token(Token = "0x4002343")]
	[FieldOffset(Offset = "0x18")]
	public float dieTime;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002345")]
	public bool isAutoDestroy;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002346")]
	private List<GameObject> m_GameObjects;

	[Token(Token = "0x4002347")]
	[FieldOffset(Offset = "0x38")]
	private readonly Dictionary<GameObject, ParticleSystem[]> m_Pars;

	[Token(Token = "0x4002348")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<GameObject, DOTweenAnimation[]> m_Tweens;

	[Token(Token = "0x4002349")]
	[FieldOffset(Offset = "0x48")]
	private readonly Dictionary<GameObject, Animator[]> m_Animators;

	[Token(Token = "0x400234A")]
	[FieldOffset(Offset = "0x50")]
	private readonly Dictionary<GameObject, Animation[]> m_Animations;

	[Token(Token = "0x400234B")]
	[FieldOffset(Offset = "0x58")]
	private readonly Dictionary<GameObject, SkeletonAnimation[]> m_SAnimations;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400234C")]
	private readonly Dictionary<GameObject, Sequence> m_DestroySeqs;

	[Token(Token = "0x170005A1")]
	public string uid
	{
		[CompilerGenerated]
		[Token(Token = "0x6003C75")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003C74")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170005A2")]
	public FastPool pool
	{
		[CompilerGenerated]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		[Token(Token = "0x6003C77")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6003C76")]
		[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
		private set
		{
		}
	}

	[Address(RVA = "0x7597B0", Offset = "0x757FB0", Length = "0x12")]
	[Token(Token = "0x6003C78")]
	private void FastDestroy(GameObject go)
	{
	}

	[Address(RVA = "0x759580", Offset = "0x757D80", Length = "0x223")]
	[Token(Token = "0x6003C79")]
	public GameObject CreateInstance()
	{
		return null;
	}

	[Token(Token = "0x6003C7A")]
	[Address(RVA = "0x75B1B0", Offset = "0x7599B0", Length = "0x248")]
	public Effect(GameObject go, int preload, int capacity = -1, Transform parent = null)
	{
	}

	[Token(Token = "0x6003C7B")]
	[Address(RVA = "0x75AF70", Offset = "0x759770", Length = "0x233")]
	public Effect(string u, int preload, int capacity = -1, Transform parent = null)
	{
	}

	[Token(Token = "0x6003C7C")]
	[Address(RVA = "0x759BF0", Offset = "0x7583F0", Length = "0x3D3")]
	public void Reset(GameObject go)
	{
	}

	[Address(RVA = "0x759880", Offset = "0x758080", Length = "0x361")]
	[Token(Token = "0x6003C7D")]
	public void Pause()
	{
	}

	[Address(RVA = "0x759FD0", Offset = "0x7587D0", Length = "0x36E")]
	[Token(Token = "0x6003C7E")]
	public void Resume()
	{
	}

	[Token(Token = "0x6003C7F")]
	[Address(RVA = "0x759250", Offset = "0x757A50", Length = "0x328")]
	public void Clear()
	{
	}

	[Token(Token = "0x6003C80")]
	[Address(RVA = "0x7597D0", Offset = "0x757FD0", Length = "0xA0")]
	private void Init()
	{
	}
}
