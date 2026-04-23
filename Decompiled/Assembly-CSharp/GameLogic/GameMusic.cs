using System.Collections.Generic;
using Cpp2ILInjected;
using DYUnityLib;
using FormulaBase;
using UnityEngine;

namespace GameLogic;

[Token(Token = "0x20004A8")]
public class GameMusic
{
	[Token(Token = "0x400190C")]
	public const uint TOUCH_ACTION_NONE = 0u;

	[Token(Token = "0x400190D")]
	public const uint TOUCH_ACTION_SIGNLE_PRESS = 1u;

	[Token(Token = "0x400190E")]
	public const uint TOUCH_ACTION_LONG_PRESS = 2u;

	[Token(Token = "0x400190F")]
	public const uint TOUCH_ACTION_SLIDE_UP = 4u;

	[Token(Token = "0x4001910")]
	public const uint TOUCH_ACTION_SLIDE_DOWN = 5u;

	[Token(Token = "0x4001911")]
	public const int A_PERFECT_RANGE_INDEX = 0;

	[Token(Token = "0x4001912")]
	public const int A_GREAT_RANGE_INDEX = 1;

	[Token(Token = "0x4001913")]
	public const int B_PERFECT_RANGE_INDEX = 2;

	[Token(Token = "0x4001914")]
	public const int B_GREAT_RANGE_INDEX = 3;

	[Token(Token = "0x4001915")]
	public const int NODE_IS_NOT_A_BOSS = 0;

	[Token(Token = "0x4001916")]
	public const int NODE_IS_BOSS_BODY_ATTACK = 1;

	[Token(Token = "0x4001917")]
	public const int NODE_IS_BOSS_THROW_ATTACK = 2;

	[Token(Token = "0x4001918")]
	public const string wheel_destroy = "destroy";

	[Token(Token = "0x4001919")]
	private const string DEFAULT_ANIMATION = "AttackTargetObject/EnemyNormal";

	[Token(Token = "0x400191A")]
	[FieldOffset(Offset = "0x10")]
	private FixUpdateTimer objTimer;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400191B")]
	private FixUpdateTimer stepTimer;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400191C")]
	private FixUpdateTimer sceneObjTimer;

	[Token(Token = "0x400191D")]
	[FieldOffset(Offset = "0x28")]
	private float m_LastMusicTick;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400191E")]
	private Dictionary<int, List<int>> m_MissMap;

	[Token(Token = "0x400191F")]
	[FieldOffset(Offset = "0x38")]
	private int m_TnoIdx;

	[Token(Token = "0x4001920")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine m_ShowVictoryCoroutine;

	[Token(Token = "0x4001921")]
	[FieldOffset(Offset = "0x48")]
	private Coroutine m_EndCoroutine;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001922")]
	private int m_BlockNoDamageAirIndex;

	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4001923")]
	private int m_BlockNoDamageGroundIndex;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001924")]
	private bool m_DevilDebuffFlag;

	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4001925")]
	private decimal m_CurTnoTime;

	[Token(Token = "0x4001926")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsVictoryShow;

	[Token(Token = "0x4001927")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_IsEnd;

	[Token(Token = "0x4001928")]
	[FieldOffset(Offset = "0x70")]
	private float m_Gap;

	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4001929")]
	public bool invoke;

	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x78")]
	private decimal m_DoubleBlockGap;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400192B")]
	public List<int> catchHeadNotes;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400192C")]
	public List<int> catchNotes;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400192D")]
	public List<int> fingers;

	[Token(Token = "0x400192E")]
	[FieldOffset(Offset = "0xA0")]
	private float m_CurTime;

	[Token(Token = "0x400192F")]
	[FieldOffset(Offset = "0xA4")]
	private float m_IntervalTime;

	[Token(Token = "0x4001930")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_IsTriggerHurt;

	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0xAC")]
	private float m_MulHitTime;

	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001932")]
	private float m_MulHitHardTime;

	[Token(Token = "0x170004CC")]
	public decimal CurTnoTime
	{
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x904D60", Offset = "0x903560", Length = "0xB")]
		get
		{
			return default(decimal);
		}
	}

	[Token(Token = "0x60034E6")]
	[Address(RVA = "0x900D00", Offset = "0x8FF500", Length = "0xDF")]
	public void GameMusicFixTimerUpdate()
	{
	}

	[Token(Token = "0x60034E7")]
	[Address(RVA = "0x900DE0", Offset = "0x8FF5E0", Length = "0x297")]
	public void GameMusicTimerUpdate()
	{
	}

	[Token(Token = "0x60034E9")]
	[Address(RVA = "0x9025A0", Offset = "0x900DA0", Length = "0x14A")]
	public void ReleaseReferences()
	{
	}

	[Token(Token = "0x60034EA")]
	[Address(RVA = "0x901530", Offset = "0x8FFD30", Length = "0xA2")]
	private void InitLyrithData()
	{
	}

	[Address(RVA = "0x902140", Offset = "0x900940", Length = "0x2D8")]
	[Token(Token = "0x60034EB")]
	private void LyrithLogic(ref decimal ts, int hp)
	{
	}

	[Address(RVA = "0x902BD0", Offset = "0x9013D0", Length = "0x563")]
	[Token(Token = "0x60034EC")]
	private void SuperBattlewornInsomniacAnimator(ref decimal ts)
	{
	}

	[Address(RVA = "0x902420", Offset = "0x900C20", Length = "0x170")]
	[Token(Token = "0x60034ED")]
	private void MuseDashHaveErrorLogic(ref decimal ts)
	{
	}

	[Address(RVA = "0x903140", Offset = "0x901940", Length = "0x16D9")]
	[Token(Token = "0x60034EE")]
	public void TimerStepTrigger(decimal ts)
	{
	}

	[Address(RVA = "0x9000D0", Offset = "0x8FE8D0", Length = "0x415")]
	[Token(Token = "0x60034EF")]
	private void BattleEnd()
	{
	}

	[Token(Token = "0x60034F0")]
	[Address(RVA = "0x904820", Offset = "0x903020", Length = "0x476")]
	public void TimerTrigger(decimal ts)
	{
	}

	[Token(Token = "0x60034F1")]
	[Address(RVA = "0x9004F0", Offset = "0x8FECF0", Length = "0x80F")]
	private void Catch(TimeNodeOrder tno, int groundIndex, int airIndex, ref bool oneHint, bool roadCatch, bool airCatch)
	{
	}

	[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
	[Token(Token = "0x60034F2")]
	public void SetTimer(FixUpdateTimer timer)
	{
	}

	[Token(Token = "0x60034F3")]
	[Address(RVA = "0x48EDC0", Offset = "0x48D5C0", Length = "0xC")]
	public void SetStepTimer(FixUpdateTimer timer)
	{
	}

	[Token(Token = "0x60034F4")]
	[Address(RVA = "0x483E40", Offset = "0x482640", Length = "0xC")]
	public void SetSceneObjTimer(FixUpdateTimer timer)
	{
	}

	[Address(RVA = "0x902910", Offset = "0x901110", Length = "0x191")]
	[Token(Token = "0x60034F5")]
	public void Run()
	{
	}

	[Token(Token = "0x60034F6")]
	[Address(RVA = "0x902B20", Offset = "0x901320", Length = "0xA4")]
	public void Stop()
	{
	}

	[Address(RVA = "0x9026F0", Offset = "0x900EF0", Length = "0x21F")]
	[Token(Token = "0x60034F7")]
	private void Reset()
	{
	}

	[Address(RVA = "0x902AB0", Offset = "0x9012B0", Length = "0x6E")]
	[Token(Token = "0x60034F8")]
	private void StopVictoryCoroutine()
	{
	}

	[Token(Token = "0x60034F9")]
	[Address(RVA = "0x901FE0", Offset = "0x9007E0", Length = "0x159")]
	public void LoadMusicDataByFileName()
	{
	}

	[Token(Token = "0x60034FA")]
	[Address(RVA = "0x9015E0", Offset = "0x8FFDE0", Length = "0x2E5")]
	public void InitMusicData()
	{
	}

	[Token(Token = "0x60034FB")]
	[Address(RVA = "0x901080", Offset = "0x8FF880", Length = "0x24A")]
	public int GetMusicIndexByGenTick(decimal genTick)
	{
		return default(int);
	}

	[Token(Token = "0x60034FC")]
	[Address(RVA = "0x9012D0", Offset = "0x8FFAD0", Length = "0x131")]
	public string GetNodePrefabName(int idx)
	{
		return null;
	}

	[Token(Token = "0x60034FD")]
	[Address(RVA = "0x9018D0", Offset = "0x9000D0", Length = "0x70D")]
	private void InitTimer(decimal total)
	{
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x901410", Offset = "0x8FFC10", Length = "0x115")]
	private void InitEventTrigger()
	{
	}

	[Address(RVA = "0x904CA0", Offset = "0x9034A0", Length = "0xB7")]
	[Token(Token = "0x60034FF")]
	public GameMusic()
	{
	}
}
