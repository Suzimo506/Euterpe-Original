using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Assets.Scripts.GameCore.Managers;
using Cpp2ILInjected;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectManager;

[Token(Token = "0x2000479")]
public class WisadelGirlManager : GeneralGirlManager
{
	[Token(Token = "0x4001833")]
	public const int w_skill_trig_count = 6;

	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4001835")]
	private int m_SkillCount;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001836")]
	private GameObject m_FxNoteVertigo;

	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0xA8")]
	private Assets.Scripts.Database.CharacterInfo m_CharacterInfo;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0xB0")]
	private WisadelGameEffectController m_WisadelGameEffectCtrl;

	[Token(Token = "0x1700049D")]
	public int SkillCount
	{
		[Address(RVA = "0x8A0DA0", Offset = "0x89F5A0", Length = "0x7")]
		[Token(Token = "0x6003368")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700049E")]
	public GameObject FxNoteVertigo
	{
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x90FD00", Offset = "0x90E500", Length = "0x12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700049F")]
	public bool CanInvokeFever
	{
		[Address(RVA = "0x432400", Offset = "0x430C00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600336A")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x89A130", Offset = "0x898930", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x170004A0")]
	public WisadelGameEffectController WisadelGameEffectCtrl
	{
		[Token(Token = "0x600336C")]
		[Address(RVA = "0x49A8E0", Offset = "0x4990E0", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600336D")]
	[Address(RVA = "0x90F680", Offset = "0x90DE80", Length = "0x21B")]
	public override void AwakeInit()
	{
	}

	[Address(RVA = "0x90FBA0", Offset = "0x90E3A0", Length = "0x15A")]
	[Token(Token = "0x600336E")]
	public override void StartInit()
	{
	}

	[Token(Token = "0x600336F")]
	[Address(RVA = "0x90F8E0", Offset = "0x90E0E0", Length = "0x8F")]
	public override void PlayRandomHitNothingAnim()
	{
	}

	[Token(Token = "0x6003370")]
	[Address(RVA = "0x90F8A0", Offset = "0x90E0A0", Length = "0x20")]
	private void OnDead()
	{
	}

	[Address(RVA = "0x90FB50", Offset = "0x90E350", Length = "0x4F")]
	[Token(Token = "0x6003371")]
	private bool SkillIsInvalidate()
	{
		return default(bool);
	}

	[Token(Token = "0x6003372")]
	[Address(RVA = "0x90F8D0", Offset = "0x90E0D0", Length = "0x7")]
	private void OnRoleSkillOn()
	{
	}

	[Token(Token = "0x6003373")]
	[Address(RVA = "0x90F970", Offset = "0x90E170", Length = "0x1D4")]
	public override void Release()
	{
	}

	[Token(Token = "0x6003374")]
	[Address(RVA = "0x6DEFD0", Offset = "0x6DD7D0", Length = "0x7")]
	public WisadelGirlManager()
	{
	}
}
