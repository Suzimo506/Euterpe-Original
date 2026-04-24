using Cpp2ILInjected;
using FormulaBase;
using GameLogic;
using UnityEngine;

namespace Assets.Scripts.GameCore.HostComponent;

[Token(Token = "0x200072C")]
public class BattleRoleAttributeComponent
{
	[Token(Token = "0x4002596")]
	private static BattleRoleAttributeComponent m_Instance;

	[Token(Token = "0x4002597")]
	[FieldOffset(Offset = "0x10")]
	private int m_Hp;

	[Token(Token = "0x4002598")]
	[FieldOffset(Offset = "0x14")]
	public int hurt;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002599")]
	private int m_JudgeState;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400259A")]
	public int early;

	[Token(Token = "0x400259B")]
	[FieldOffset(Offset = "0x20")]
	public int late;

	[Token(Token = "0x400259C")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine m_ZombiaCoroutine1;

	[Token(Token = "0x400259D")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine m_ZombiaCoroutine2;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400259E")]
	private bool m_IsShowLateEarly;

	[Token(Token = "0x400259F")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsChangeHp;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40025A0")]
	private Coroutine m_HurtEffectCoroutine;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40025A1")]
	private Coroutine m_ZombiaCoroutine;

	[Token(Token = "0x17000638")]
	public static BattleRoleAttributeComponent instance
	{
		[Token(Token = "0x6004256")]
		[Address(RVA = "0x78CAE0", Offset = "0x78B2E0", Length = "0xAE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000639")]
	public int Hp
	{
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x78CB90", Offset = "0x78B390", Length = "0x71")]
		set
		{
		}
	}

	[Token(Token = "0x1700063A")]
	public bool IsChangeHp
	{
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x49B050", Offset = "0x499850", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700063B")]
	public int judgeState
	{
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600425B")]
	[Address(RVA = "0x78C170", Offset = "0x78A970", Length = "0x206")]
	public void Init()
	{
	}

	[Address(RVA = "0x78BB80", Offset = "0x78A380", Length = "0x6E")]
	[Token(Token = "0x600425C")]
	private void Destroy()
	{
	}

	[Token(Token = "0x600425D")]
	[Address(RVA = "0x78A190", Offset = "0x788990", Length = "0x5B2")]
	public void AddHp(int value)
	{
	}

	[Token(Token = "0x600425E")]
	[Address(RVA = "0x78C3C0", Offset = "0x78ABC0", Length = "0x58C")]
	public void MissHardEffect(float duration)
	{
	}

	[Token(Token = "0x600425F")]
	[Address(RVA = "0x78BC30", Offset = "0x78A430", Length = "0x53")]
	public float HpRate()
	{
		return default(float);
	}

	[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
	[Token(Token = "0x6004260")]
	public int GetHp()
	{
		return default(int);
	}

	[Token(Token = "0x6004261")]
	[Address(RVA = "0x78BBF0", Offset = "0x78A3F0", Length = "0x3D")]
	public int GetHpMax()
	{
		return default(int);
	}

	[Token(Token = "0x6004262")]
	[Address(RVA = "0x78C950", Offset = "0x78B150", Length = "0xF0")]
	public void Miss()
	{
	}

	[Token(Token = "0x6004263")]
	[Address(RVA = "0x78BD20", Offset = "0x78A520", Length = "0x447")]
	public void Hurt(int hurtValue, bool isAir)
	{
	}

	[Token(Token = "0x6004264")]
	[Address(RVA = "0x78BC90", Offset = "0x78A490", Length = "0x88")]
	public void HurtRedScreenEffect()
	{
	}

	[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
	[Token(Token = "0x6004265")]
	public int GetHurtValue()
	{
		return default(int);
	}

	[Token(Token = "0x6004266")]
	[Address(RVA = "0x78C380", Offset = "0x78AB80", Length = "0x3E")]
	public bool IsDead()
	{
		return default(bool);
	}

	[Token(Token = "0x6004267")]
	[Address(RVA = "0x78BA10", Offset = "0x78A210", Length = "0x164")]
	public void Dead()
	{
	}

	[Token(Token = "0x6004268")]
	[Address(RVA = "0x78CA50", Offset = "0x78B250", Length = "0x89")]
	public void Revive(bool ifFirstLoad = false)
	{
	}

	[Token(Token = "0x6004269")]
	[Address(RVA = "0x78B170", Offset = "0x789970", Length = "0x895")]
	private int CalScore(MusicData md, int result)
	{
		return default(int);
	}

	[Token(Token = "0x600426A")]
	[Address(RVA = "0x78A750", Offset = "0x788F50", Length = "0xA10")]
	public void AttackScore(int idx, int result, TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x600426B")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BattleRoleAttributeComponent()
	{
	}
}
