using System;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using MEC;
using UnityEngine;

namespace Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.BossController;

[Token(Token = "0x2000768")]
public class BossActionEffectController : MonoBehaviour, IPause
{
	[Token(Token = "0x4002741")]
	public const string boss_effect_name = "vfx_boss_action_change";

	[Token(Token = "0x4002742")]
	[SerializeField]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_BossVfxObj;

	[SerializeField]
	[Token(Token = "0x4002743")]
	[FieldOffset(Offset = "0x20")]
	private ParticleSystem m_BossBombEffect;

	[Token(Token = "0x4002744")]
	[FieldOffset(Offset = "0x28")]
	private CoroutineHandle m_EffectCoroutine;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002745")]
	private Animator m_BossEffectAnima;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002746")]
	private bool m_IsOnPlayEffect;

	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x4002747")]
	private bool m_IsBossHide;

	[Token(Token = "0x1700068C")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x49B590", Offset = "0x499D90", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004583")]
	[Address(RVA = "0x49A9E0", Offset = "0x4991E0", Length = "0x332")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004584")]
	[Address(RVA = "0x49AD20", Offset = "0x499520", Length = "0x196")]
	private void OnBossAtkActionChange(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x49AEC0", Offset = "0x4996C0", Length = "0x188")]
	[Token(Token = "0x6004585")]
	private void OnBossEnterIn(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x49B050", Offset = "0x499850", Length = "0x4")]
	[Token(Token = "0x6004586")]
	private void OnBossShowStateChange(bool isHide)
	{
	}

	[Token(Token = "0x6004587")]
	[Address(RVA = "0x49B060", Offset = "0x499860", Length = "0x249")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004588")]
	[Address(RVA = "0x49B3D0", Offset = "0x499BD0", Length = "0x13C")]
	private void SetEffectPlayCoroutine(float delayTime, Action function)
	{
	}

	[Token(Token = "0x6004589")]
	[Address(RVA = "0x49B2B0", Offset = "0x499AB0", Length = "0x87")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600458A")]
	[Address(RVA = "0x49B340", Offset = "0x499B40", Length = "0x8C")]
	public void Resume()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600458C")]
	public BossActionEffectController()
	{
	}
}
