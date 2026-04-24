using System.Collections.Generic;
using Assets.Scripts.GameCore.GameObjectLogics.GameObjectControl.Impls;
using Assets.Scripts.GameCore.Interface;
using Assets.Scripts.PeroTools.Managers;
using Cpp2ILInjected;
using GameLogic;
using Spine.Unity;
using UnityEngine;

[Token(Token = "0x2000039")]
public abstract class BaseEnemyObjectController : BaseSpineObjectController, IUpdate
{
	[Token(Token = "0x4000166")]
	public const string POINT_CENTER = "pc";

	[Token(Token = "0x4000167")]
	private static string[] listResultMap;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000168")]
	[SerializeField]
	public bool attackedDoNothing;

	[Token(Token = "0x4000169")]
	[FieldOffset(Offset = "0x60")]
	private SpineMountController m_SpineMountController;

	[Token(Token = "0x400016A")]
	[FieldOffset(Offset = "0x68")]
	protected SkeletonAnimation m_SkeletonAnimation;

	[Token(Token = "0x400016B")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_CatchObj;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400016C")]
	protected MusicData m_MusicData;

	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x400016D")]
	private int m_HpAdd;

	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x400016E")]
	private SkeletonAnimation m_BloodAnimtion;

	[Token(Token = "0x400016F")]
	[FieldOffset(Offset = "0x1E8")]
	private float m_ShowTick;

	[FieldOffset(Offset = "0x1EC")]
	[Token(Token = "0x4000170")]
	private bool m_HasMiss;

	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x4000171")]
	protected uint m_NodeType;

	[FieldOffset(Offset = "0x1F4")]
	[Token(Token = "0x4000172")]
	protected bool m_IsBeAttacked;

	[FieldOffset(Offset = "0x1F5")]
	[Token(Token = "0x4000173")]
	private bool m_HasDjmax;

	[FieldOffset(Offset = "0x1F6")]
	[Token(Token = "0x4000174")]
	protected bool m_IsHarmerNote;

	[Token(Token = "0x4000175")]
	[FieldOffset(Offset = "0x1F7")]
	protected bool m_IsSpiNote;

	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000176")]
	protected GameObject m_NoteHitFxObj;

	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000177")]
	protected List<INoteExObjectController> m_ExNoteControllers;

	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000178")]
	private bool m_HasNoteResult;

	[Token(Token = "0x4000179")]
	[FieldOffset(Offset = "0x20C")]
	public int nextNoteResult;

	[Token(Token = "0x400017A")]
	[FieldOffset(Offset = "0x210")]
	protected bool m_IsBoom;

	[FieldOffset(Offset = "0x211")]
	[Token(Token = "0x400017B")]
	private bool m_ReleaseFlag;

	[Token(Token = "0x17000023")]
	public MusicData MusicData
	{
		[Address(RVA = "0x5F95E0", Offset = "0x5F7DE0", Length = "0xA3")]
		[Token(Token = "0x6000152")]
		get
		{
			return default(MusicData);
		}
	}

	[Token(Token = "0x17000024")]
	public bool IsHarmerNote
	{
		[Address(RVA = "0x5F95C0", Offset = "0x5F7DC0", Length = "0x8")]
		[Token(Token = "0x6000153")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public bool IsSpiNote
	{
		[Address(RVA = "0x5F95D0", Offset = "0x5F7DD0", Length = "0x8")]
		[Token(Token = "0x6000154")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000026")]
	public SkeletonAnimation SkeletonAnimation
	{
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		[Token(Token = "0x6000155")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000027")]
	protected List<INoteExObjectController> ExObjectControllers
	{
		[Address(RVA = "0x5F9540", Offset = "0x5F7D40", Length = "0x77")]
		[Token(Token = "0x6000156")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	public GameObject NoteHitFx
	{
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5F9690", Offset = "0x5F7E90", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000029")]
	public UnityGameManager.LoopType LoopType
	{
		[Address(RVA = "0x492780", Offset = "0x490F80", Length = "0x6")]
		[Token(Token = "0x600016C")]
		get
		{
			return default(UnityGameManager.LoopType);
		}
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x5F3FB0", Offset = "0x5F27B0", Length = "0x18")]
	public void AttackedSuccessful(uint result, bool isDead = true)
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6000159")]
	public virtual bool IsShotPause()
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x600015A")]
	public virtual void SetShotPause(decimal tick)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x44A0F0", Offset = "0x4488F0", Length = "0x4")]
	public override void SetIdx(int idx)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x5F4EB0", Offset = "0x5F36B0", Length = "0xA61")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x5F4A30", Offset = "0x5F3230", Length = "0x18F")]
	private void DjmaxInit()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x5F6300", Offset = "0x5F4B00", Length = "0x1E0")]
	public void OnBossIn(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x5F64F0", Offset = "0x5F4CF0", Length = "0x1E0")]
	[Token(Token = "0x600015F")]
	public void OnBossOut(object sender, object rev, params object[] args)
	{
	}

	[Address(RVA = "0x5F3FD0", Offset = "0x5F27D0", Length = "0xA5B")]
	[Token(Token = "0x6000160")]
	public override bool ControllerMissCheck(int i, decimal currentTick)
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x5F4BC0", Offset = "0x5F33C0", Length = "0x102")]
	private void EnableVisible()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x5F7DD0", Offset = "0x5F65D0", Length = "0x515")]
	public override void OnControllerStart()
	{
	}

	[Address(RVA = "0x5F4DE0", Offset = "0x5F35E0", Length = "0xCF")]
	[Token(Token = "0x6000163")]
	private float GetSkeletonAnimShowDistance()
	{
		return default(float);
	}

	[Address(RVA = "0x5F4CD0", Offset = "0x5F34D0", Length = "0x101")]
	[Token(Token = "0x6000164")]
	private void EnemySkAnimInit()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x5F66E0", Offset = "0x5F4EE0", Length = "0x152")]
	public override void OnControllerAttackedButHurt(int result, bool isDeaded, int objIdx = -1)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x5F6840", Offset = "0x5F5040", Length = "0x11EB")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Address(RVA = "0x5F7A30", Offset = "0x5F6230", Length = "0x39F")]
	[Token(Token = "0x6000167")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x5F5920", Offset = "0x5F4120", Length = "0x24C")]
	private void MakeBlood()
	{
	}

	[Address(RVA = "0x5F8EE0", Offset = "0x5F76E0", Length = "0x32F")]
	[Token(Token = "0x6000169")]
	private bool __OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x5F5B70", Offset = "0x5F4370", Length = "0x64E")]
	private void MissAndHurt(MusicData md, bool resetCombo)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x5F61C0", Offset = "0x5F49C0", Length = "0x135")]
	private void NoteDisappearLogic(object sender, object reciever, params object[] args)
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x5F8B80", Offset = "0x5F7380", Length = "0xE2")]
	protected virtual void Release()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x5F8A10", Offset = "0x5F7210", Length = "0x169")]
	protected virtual void ReleaseEvent()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x5F82F0", Offset = "0x5F6AF0", Length = "0x53F")]
	public void OnTouhouFever()
	{
	}

	[Address(RVA = "0x5F8830", Offset = "0x5F7030", Length = "0x159")]
	[Token(Token = "0x6000170")]
	public void OnUpdate()
	{
	}

	[Address(RVA = "0x5F8990", Offset = "0x5F7190", Length = "0x7B")]
	[Token(Token = "0x6000171")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x5F8C70", Offset = "0x5F7470", Length = "0x7B")]
	[Token(Token = "0x6000172")]
	public override void Resume()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x5F94D0", Offset = "0x5F7CD0", Length = "0x70")]
	protected BaseEnemyObjectController()
	{
	}
}
