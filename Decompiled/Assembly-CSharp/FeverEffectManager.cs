using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;

[Token(Token = "0x200004F")]
public class FeverEffectManager : MonoBehaviour, IPause
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001C4")]
	[SerializeField]
	private int m_FeverIndex;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40001C5")]
	private ReverseColor m_ReverseColor;

	[SerializeField]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40001C6")]
	private GameObject m_Background;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40001C7")]
	private Animator m_BgAnimator;

	[SerializeField]
	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x38")]
	private SpriteRenderer m_WhitBoardRender;

	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 outScenePosition;

	[Token(Token = "0x40001CA")]
	[SerializeField]
	[FieldOffset(Offset = "0x50")]
	private GameObject[] m_Particles;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject[] m_EndParticles;

	[Token(Token = "0x40001CC")]
	private const float COME_OUT_DURING_TIME = 0.15f;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40001CD")]
	private bool m_IsActivatedComeOut;

	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x61")]
	private bool m_IfShow;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x68")]
	private UnityGameManager m_UnityGameManager;

	[Token(Token = "0x40001D0")]
	private static FeverEffectManager m_Instance;

	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001D1")]
	private List<ParticleSystem> m_PauseParticleSystemList;

	[Token(Token = "0x40001D2")]
	private static int s_WaitingOutside;

	[Token(Token = "0x40001D3")]
	private static int s_ComeIn;

	[Token(Token = "0x40001D4")]
	private static int s_ComeOut;

	[Token(Token = "0x40001D5")]
	private static int s_Standby;

	[Token(Token = "0x40001D6")]
	private const int DefaultFeverIndex = 0;

	[Token(Token = "0x40001D7")]
	private const int christmas_fever = 3;

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x78")]
	protected Tweener m_FeverInTween;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40001D9")]
	protected Tweener m_FeverOutTween;

	[Token(Token = "0x17000047")]
	public static FeverEffectManager instance
	{
		[Address(RVA = "0x44E3C0", Offset = "0x44CBC0", Length = "0x56")]
		[Token(Token = "0x6000237")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x44E3B0", Offset = "0x44CBB0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x44E420", Offset = "0x44CC20", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000244")]
		private set
		{
		}
	}

	[Address(RVA = "0x44DC40", Offset = "0x44C440", Length = "0x1C2")]
	[Token(Token = "0x6000238")]
	private void Start()
	{
	}

	[Address(RVA = "0x44D900", Offset = "0x44C100", Length = "0xAC")]
	[Token(Token = "0x6000239")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x44D0B0", Offset = "0x44B8B0", Length = "0xE1")]
	private void EnableEndParticles(bool enable)
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x44D1A0", Offset = "0x44B9A0", Length = "0xE1")]
	private void EnableParticles(bool enable)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x44D290", Offset = "0x44BA90", Length = "0x1D0")]
	public void InitFeverBadApple()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x44D470", Offset = "0x44BC70", Length = "0x1DB")]
	public void InitFeverEffect()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x44D820", Offset = "0x44C020", Length = "0xDE")]
	private void InvokeNormalFever()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x44CA40", Offset = "0x44B240", Length = "0x1E8")]
	public void ActivateFever(bool isForce = false)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x44CDC0", Offset = "0x44B5C0", Length = "0x2E1")]
	public void CancelFeverEffect()
	{
	}

	[Address(RVA = "0x44D650", Offset = "0x44BE50", Length = "0x1C4")]
	[Token(Token = "0x6000241")]
	private void InvokeBadAppleFever()
	{
	}

	[Address(RVA = "0x44CC30", Offset = "0x44B430", Length = "0x186")]
	[Token(Token = "0x6000242")]
	public void CancelBadAppleFeverEffect()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x44D9B0", Offset = "0x44C1B0", Length = "0x15F")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x44DB10", Offset = "0x44C310", Length = "0x12F")]
	public void Resume()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x44E350", Offset = "0x44CB50", Length = "0x58")]
	public FeverEffectManager()
	{
	}
}
