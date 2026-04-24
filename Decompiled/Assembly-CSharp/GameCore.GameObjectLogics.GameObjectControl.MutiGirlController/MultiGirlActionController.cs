using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.GameObjectLogics.ExtraControl;
using Cpp2ILInjected;
using GameLogic;
using UnityEngine;

namespace GameCore.GameObjectLogics.GameObjectControl.MutiGirlController;

[Token(Token = "0x200048D")]
public class MultiGirlActionController : BaseSpineObjectController
{
	[Token(Token = "0x4001898")]
	[FieldOffset(Offset = "0x78")]
	private RoleBattleSubControl m_SubControl;

	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001899")]
	public int tnoIdx;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400189A")]
	private Coroutine m_StopMissHardEffectCoroutine;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400189B")]
	private bool m_SkillHitting;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400189C")]
	private Coroutine m_SubAttackEndCoro;

	[Token(Token = "0x170004B6")]
	public MultiCharaType charaType
	{
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x4E8C60", Offset = "0x4E7460", Length = "0x4")]
		[CompilerGenerated]
		get
		{
			return default(MultiCharaType);
		}
		[Address(RVA = "0x7B0960", Offset = "0x7AF160", Length = "0x4")]
		[Token(Token = "0x60033F9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170004B7")]
	public SpineActionController spineActionCtrl
	{
		[Address(RVA = "0x4293D0", Offset = "0x427BD0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60033FB")]
		get
		{
			return null;
		}
		[Address(RVA = "0x5A6760", Offset = "0x5A4F60", Length = "0xC")]
		[CompilerGenerated]
		[Token(Token = "0x60033FA")]
		private set
		{
		}
	}

	[Token(Token = "0x170004B8")]
	public GameObject go
	{
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x4293C0", Offset = "0x427BC0", Length = "0x5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x5C14A0", Offset = "0x5BFCA0", Length = "0xC")]
		private set
		{
		}
	}

	[Token(Token = "0x170004B9")]
	public Animator animator
	{
		[Address(RVA = "0x462D00", Offset = "0x461500", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60033FF")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60033FE")]
		[Address(RVA = "0x422030", Offset = "0x420830", Length = "0xC")]
		private set
		{
		}
	}

	[Address(RVA = "0x424E60", Offset = "0x423660", Length = "0x7")]
	[Token(Token = "0x6003400")]
	public override void SetIdx(int idx)
	{
	}

	[Address(RVA = "0x845510", Offset = "0x843D10", Length = "0x194")]
	[Token(Token = "0x6003401")]
	public override void Init(int scene)
	{
	}

	[Token(Token = "0x6003402")]
	[Address(RVA = "0x845C60", Offset = "0x844460", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Address(RVA = "0x845D40", Offset = "0x844540", Length = "0x6C6")]
	[Token(Token = "0x6003403")]
	private void RegistEvents()
	{
	}

	[Token(Token = "0x6003404")]
	[Address(RVA = "0x846FB0", Offset = "0x8457B0", Length = "0x268")]
	private void UnRegistEvents()
	{
	}

	[Address(RVA = "0x843A60", Offset = "0x842260", Length = "0x99")]
	[Token(Token = "0x6003405")]
	private void ActionChangeAfterMultiHit()
	{
	}

	[Token(Token = "0x6003406")]
	[Address(RVA = "0x678080", Offset = "0x676880", Length = "0x3")]
	private void ActionSwitchActor()
	{
	}

	[Token(Token = "0x6003407")]
	[Address(RVA = "0x8451A0", Offset = "0x8439A0", Length = "0x6A")]
	private void ActionMultiHitEnd()
	{
	}

	[Token(Token = "0x6003408")]
	[Address(RVA = "0x845210", Offset = "0x843A10", Length = "0x6A")]
	private void ActionMultiHits(int hitCount)
	{
	}

	[Token(Token = "0x6003409")]
	[Address(RVA = "0x843BB0", Offset = "0x8423B0", Length = "0x31F")]
	private void ActionDead()
	{
	}

	[Token(Token = "0x600340A")]
	[Address(RVA = "0x8440E0", Offset = "0x8428E0", Length = "0x4E5")]
	private void ActionHurt()
	{
	}

	[Token(Token = "0x600340B")]
	[Address(RVA = "0x8433A0", Offset = "0x841BA0", Length = "0xA3")]
	private void ActionAfterHurt()
	{
	}

	[Token(Token = "0x600340C")]
	[Address(RVA = "0x843FA0", Offset = "0x8427A0", Length = "0x131")]
	private void ActionEmptyAttack(string actKey)
	{
	}

	[Token(Token = "0x600340D")]
	[Address(RVA = "0x843B00", Offset = "0x842300", Length = "0xAC")]
	private void ActionComeOut()
	{
	}

	[Address(RVA = "0x843450", Offset = "0x841C50", Length = "0x605")]
	[Token(Token = "0x600340E")]
	private void ActionAttack(string actKey, uint result, int id = -1)
	{
	}

	[Address(RVA = "0x845280", Offset = "0x843A80", Length = "0x28D")]
	[Token(Token = "0x600340F")]
	private void ActionSynergyAttack(string mainAttackActionKey, string actionKey, uint result)
	{
	}

	[Address(RVA = "0x8447A0", Offset = "0x842FA0", Length = "0x5A6")]
	[Token(Token = "0x6003410")]
	private void ActionLongPress(bool isPress, bool isAir)
	{
	}

	[Address(RVA = "0x844670", Offset = "0x842E70", Length = "0x128")]
	[Token(Token = "0x6003411")]
	private void ActionLongPressEnd(bool isAirNote)
	{
	}

	[Address(RVA = "0x843ED0", Offset = "0x8426D0", Length = "0xC0")]
	[Token(Token = "0x6003412")]
	private void ActionDoubleAttack(string mainSpineActionState, uint result)
	{
	}

	[Address(RVA = "0x8445D0", Offset = "0x842DD0", Length = "0x9C")]
	[Token(Token = "0x6003413")]
	private void ActionInvicinble()
	{
	}

	[Address(RVA = "0x844D50", Offset = "0x843550", Length = "0x447")]
	[Token(Token = "0x6003414")]
	private void ActionMissedDoubleNoteJudge(int id = -1)
	{
	}

	[Token(Token = "0x6003415")]
	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	public override bool ControllerMissCheck(int idx, decimal currentTick)
	{
		return default(bool);
	}

	[Token(Token = "0x6003416")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void OnControllerStart()
	{
	}

	[Address(RVA = "0x431710", Offset = "0x42FF10", Length = "0x3")]
	[Token(Token = "0x6003417")]
	public override bool OnControllerMiss(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6003418")]
	public override void OnControllerAttacked(int result, bool isDeaded)
	{
	}

	[Token(Token = "0x6003419")]
	[Address(RVA = "0x845C70", Offset = "0x844470", Length = "0xC1")]
	public override void Pause(bool pauseCorountine)
	{
	}

	[Token(Token = "0x600341A")]
	[Address(RVA = "0x846550", Offset = "0x844D50", Length = "0xC1")]
	public override void Resume()
	{
	}

	[Address(RVA = "0x8457D0", Offset = "0x843FD0", Length = "0x48F")]
	[Token(Token = "0x600341B")]
	private string JumpAttack(string atkName, uint result, int id = -1)
	{
		return null;
	}

	[Address(RVA = "0x846410", Offset = "0x844C10", Length = "0x135")]
	[Token(Token = "0x600341C")]
	private void ResetSortingOrder()
	{
	}

	[Token(Token = "0x600341D")]
	[Address(RVA = "0x846620", Offset = "0x844E20", Length = "0x120")]
	private void StartStopMissHardEffectTimer()
	{
	}

	[Address(RVA = "0x846920", Offset = "0x845120", Length = "0x436")]
	[Token(Token = "0x600341E")]
	public void SupportRoleAttack(uint result, int id, float dt = 0.3f)
	{
	}

	[Token(Token = "0x600341F")]
	[Address(RVA = "0x8456B0", Offset = "0x843EB0", Length = "0x116")]
	private void InvokeSubAttack(bool isAirMd, uint result)
	{
	}

	[Address(RVA = "0x846750", Offset = "0x844F50", Length = "0x1C9")]
	[Token(Token = "0x6003420")]
	public void SubAttackEnd(float dt, MusicData md)
	{
	}

	[Address(RVA = "0x5C1430", Offset = "0x5BFC30", Length = "0x7")]
	[Token(Token = "0x6003421")]
	public MultiGirlActionController()
	{
	}
}
