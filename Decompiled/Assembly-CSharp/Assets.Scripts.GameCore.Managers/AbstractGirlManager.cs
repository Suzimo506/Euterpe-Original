using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using FormulaBase;
using GameCore.GameObjectLogics.GameObjectControl;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200072F")]
public abstract class AbstractGirlManager : BaseManager
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40025BC")]
	protected bool m_IsJumpingAction;

	[Token(Token = "0x40025BD")]
	[FieldOffset(Offset = "0x18")]
	protected GirlActionController m_CurGirlActionController;

	[Token(Token = "0x40025BE")]
	[FieldOffset(Offset = "0x20")]
	protected Animator m_CurAnimator;

	[Token(Token = "0x40025BF")]
	[FieldOffset(Offset = "0x28")]
	protected SpineActionController m_Sac;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40025C0")]
	protected List<string> m_HurtVoice;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40025C1")]
	protected List<string> m_EmptyHitVoice;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40025C2")]
	protected bool m_IsAir;

	[Token(Token = "0x40025C3")]
	[FieldOffset(Offset = "0x48")]
	protected AudioSource m_GirlEffectAs;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40025C6")]
	public Coroutine hurtCoroutine;

	[Token(Token = "0x40025C7")]
	[FieldOffset(Offset = "0x60")]
	protected List<decimal> m_DownHitTime;

	[Token(Token = "0x40025C8")]
	[FieldOffset(Offset = "0x68")]
	protected float m_MulHitTime;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40025C9")]
	protected float m_MulHitHardTime;

	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40025CB")]
	public GameObject girl;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40025CC")]
	public GameObject girlGhost;

	[Token(Token = "0x40025CD")]
	protected const float play_wait_for_comeout = 3f;

	[Token(Token = "0x40025CE")]
	[FieldOffset(Offset = "0x88")]
	protected bool isCommingOut;

	[Token(Token = "0x1700063C")]
	public bool isThisFrameJumpUp
	{
		[CompilerGenerated]
		[Address(RVA = "0x50B3E0", Offset = "0x509BE0", Length = "0x5")]
		[Token(Token = "0x60042A8")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Address(RVA = "0x642820", Offset = "0x641020", Length = "0x4")]
		[Token(Token = "0x60042A9")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063D")]
	public bool isThisFrameJumpDown
	{
		[Token(Token = "0x60042AA")]
		[CompilerGenerated]
		[Address(RVA = "0x642810", Offset = "0x641010", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x642830", Offset = "0x641030", Length = "0x4")]
		[Token(Token = "0x60042AB")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700063E")]
	public AudioSource girlEffectAs
	{
		[Token(Token = "0x60042AD")]
		[Address(RVA = "0x46EF30", Offset = "0x46D730", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700063F")]
	protected List<SubSpineController> SubCtrlEntities
	{
		[CompilerGenerated]
		[Token(Token = "0x60042AE")]
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x17000640")]
	public bool IsAir
	{
		[Address(RVA = "0x47F9B0", Offset = "0x47E1B0", Length = "0x5")]
		[Token(Token = "0x60042B1")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000641")]
	public Animator animator
	{
		[Token(Token = "0x60042B2")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000642")]
	public bool IsCommingOut
	{
		[Token(Token = "0x60042B3")]
		[Address(RVA = "0x44E3B0", Offset = "0x44CBB0", Length = "0x8")]
		get
		{
			return default(bool);
		}
	}

	[Address(RVA = "0x785010", Offset = "0x783810", Length = "0x84")]
	[Token(Token = "0x60042AC")]
	public void PlayAnimationCallback(string actionKey)
	{
	}

	[Token(Token = "0x60042B0")]
	[Address(RVA = "0x783D40", Offset = "0x782540", Length = "0xC4A")]
	public void InitAutoPlay()
	{
	}

	[Token(Token = "0x60042B4")]
	[Address(RVA = "0x7859C0", Offset = "0x7841C0", Length = "0x186")]
	public override void Release()
	{
	}

	[Token(Token = "0x60042B5")]
	[Address(RVA = "0x782DC0", Offset = "0x7815C0", Length = "0x437")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60042B6")]
	[Address(RVA = "0x785D50", Offset = "0x784550", Length = "0xD3")]
	private void SetupHurtVoice(int roleIdx, int skinIdx)
	{
	}

	[Token(Token = "0x60042B7")]
	[Address(RVA = "0x785C70", Offset = "0x784470", Length = "0xD3")]
	private void SetupEmptyHitVoice(int roleIdx, int skinIdx)
	{
	}

	[Token(Token = "0x60042B8")]
	[Address(RVA = "0x785E30", Offset = "0x784630", Length = "0xC2")]
	private void SetupVoice(int roleIdx, int skinIdx, VoiceType voiceType, ref List<string> voiceNameList)
	{
	}

	[Token(Token = "0x60042B9")]
	[Address(RVA = "0x785B50", Offset = "0x784350", Length = "0x10F")]
	private void RoleEmptyHitVoiceHandle(int roleIdx)
	{
	}

	[Token(Token = "0x60042BA")]
	[Address(RVA = "0x785920", Offset = "0x784120", Length = "0x9A")]
	private void PreloadEmptyHitAndHurtVoice()
	{
	}

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60042BB")]
	public abstract void PlayRandomHitNothingAnim();

	[Address(RVA = "0x0", Length = "0x0")]
	[Token(Token = "0x60042BC")]
	public abstract void AutoPlay(TimeNodeOrder tno, ref decimal ts, ref bool oneHint);

	[Address(RVA = "0x785390", Offset = "0x783B90", Length = "0x186")]
	[Token(Token = "0x60042BD")]
	protected void PlayLongEffectSound(bool toPlay)
	{
	}

	[Address(RVA = "0x784B70", Offset = "0x783370", Length = "0x49F")]
	[Token(Token = "0x60042BE")]
	public virtual void InstanceGirl()
	{
	}

	[Address(RVA = "0x784990", Offset = "0x783190", Length = "0x1DD")]
	[Token(Token = "0x60042BF")]
	protected void InitGirlInstanceControllers(int selectRoleIdx)
	{
	}

	[Address(RVA = "0x7834B0", Offset = "0x781CB0", Length = "0xCD")]
	[Token(Token = "0x60042C0")]
	private void CreateSubInstances(RoleSkin skin)
	{
	}

	[Address(RVA = "0x7833C0", Offset = "0x781BC0", Length = "0xEE")]
	[Token(Token = "0x60042C1")]
	public virtual void ComeOut()
	{
	}

	[Token(Token = "0x60042C2")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public virtual void OnBgmPlayAndBattleStart()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x7E290", Offset = "0x7D690")]
	[Token(Token = "0x60042C3")]
	[Address(RVA = "0x783350", Offset = "0x781B50", Length = "0x65")]
	private IEnumerator ComeOutFinished()
	{
		return null;
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x7E4B0", Offset = "0x7D8B0")]
	[Token(Token = "0x60042C4")]
	[Address(RVA = "0x782D20", Offset = "0x781520", Length = "0x65")]
	protected virtual IEnumerator AfterComeOut()
	{
		return null;
	}

	[Token(Token = "0x60042C5")]
	[Address(RVA = "0x7861E0", Offset = "0x7849E0", Length = "0x8E")]
	public void UnLockActionProtect()
	{
	}

	[Token(Token = "0x60042C6")]
	[Address(RVA = "0x782D90", Offset = "0x781590", Length = "0x2D")]
	public virtual void AttacksWithoutExchange(uint result, string actKey = null, int id = -1)
	{
	}

	[Token(Token = "0x60042C7")]
	[Address(RVA = "0x783580", Offset = "0x781D80", Length = "0x1B5")]
	public virtual void Dead()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x60042C8")]
	public virtual void BeMissed()
	{
	}

	[Token(Token = "0x60042C9")]
	[Address(RVA = "0x783200", Offset = "0x781A00", Length = "0x14F")]
	public virtual void BeAttackEffect()
	{
	}

	[Token(Token = "0x60042CA")]
	[Address(RVA = "0x785870", Offset = "0x784070", Length = "0xA3")]
	public void PlaySubInstanceAction()
	{
	}

	[Token(Token = "0x60042CB")]
	[Address(RVA = "0x7850A0", Offset = "0x7838A0", Length = "0x2E2")]
	private void PlayHurtRoleEffect()
	{
	}

	[Token(Token = "0x60042CC")]
	[Address(RVA = "0x0", Length = "0x0")]
	public abstract void PlayLongEndAnimator(bool isAir);

	[Token(Token = "0x60042CD")]
	[Address(RVA = "0x785520", Offset = "0x783D20", Length = "0x34A")]
	public virtual void PlayLongPressAnimator(bool isPress, bool isAir)
	{
	}

	[Token(Token = "0x60042CE")]
	[Address(RVA = "0x785C60", Offset = "0x784460", Length = "0x4")]
	public void SetTone(bool isAir)
	{
	}

	[Token(Token = "0x60042CF")]
	[Address(RVA = "0x45C980", Offset = "0x45B180", Length = "0x4")]
	public virtual void SetJumpingAction(bool value)
	{
	}

	[Token(Token = "0x60042D0")]
	[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
	public bool IsJumpingAction()
	{
		return default(bool);
	}

	[Token(Token = "0x60042D1")]
	[Address(RVA = "0x783D20", Offset = "0x782520", Length = "0x11")]
	public virtual void Hurt()
	{
	}

	[Token(Token = "0x60042D2")]
	[Address(RVA = "0x783C20", Offset = "0x782420", Length = "0xF6")]
	protected virtual void HurtOnlyAudio()
	{
	}

	[Token(Token = "0x60042D3")]
	[Address(RVA = "0x783740", Offset = "0x781F40", Length = "0x110")]
	public void DestroyGirlSpineAnimation()
	{
	}

	[Token(Token = "0x60042D4")]
	[Address(RVA = "0x783B40", Offset = "0x782340", Length = "0xD7")]
	public Vector3 GetCurrentGirlPositon()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60042D5")]
	[Address(RVA = "0x783860", Offset = "0x782060", Length = "0x2DB")]
	public Vector3 GetCurrentGirlBonePosition(string boneName)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60042D6")]
	[Address(RVA = "0x786270", Offset = "0x784A70", Length = "0x70")]
	protected AbstractGirlManager()
	{
	}
}
