using System;
using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using GameLogic;
using PeroPeroGames.GlobalDefines;

namespace Assets.Scripts.GameCore.HostComponent;

[Token(Token = "0x200072D")]
public class TaskStageTarget : Singleton<TaskStageTarget>
{
	[Token(Token = "0x40025A2")]
	[FieldOffset(Offset = "0x10")]
	private int m_EnergyCount;

	[Token(Token = "0x40025A3")]
	[FieldOffset(Offset = "0x14")]
	private int m_MusicCount;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40025A4")]
	private int m_HitCount;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x40025A5")]
	private int m_LongPressCount;

	[Token(Token = "0x40025A6")]
	[FieldOffset(Offset = "0x20")]
	private int m_MaxCombo;

	[Token(Token = "0x40025A7")]
	[FieldOffset(Offset = "0x24")]
	private int m_Score;

	[Token(Token = "0x40025A8")]
	[FieldOffset(Offset = "0x28")]
	private int m_Block;

	[Token(Token = "0x40025A9")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Blood;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40025AA")]
	private int m_LongPressHitCount;

	[Token(Token = "0x40025AB")]
	[FieldOffset(Offset = "0x34")]
	private int m_HitEnemy;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40025AC")]
	private int m_BossNearHit;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40025AD")]
	private int m_HurtMiss;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40025AE")]
	private int m_MissCombo;

	[Token(Token = "0x40025AF")]
	[FieldOffset(Offset = "0x44")]
	private int m_Recover;

	[Token(Token = "0x40025B0")]
	[FieldOffset(Offset = "0x48")]
	private int m_MaxDamage;

	[Token(Token = "0x40025B1")]
	[FieldOffset(Offset = "0x4C")]
	private int m_Damage;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40025B2")]
	private int m_HideNote;

	[Token(Token = "0x40025B3")]
	[FieldOffset(Offset = "0x54")]
	private int m_RedPoint;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40025B4")]
	private int m_BluePoint;

	[Token(Token = "0x40025B5")]
	[FieldOffset(Offset = "0x5C")]
	private int m_MissResult;

	[Token(Token = "0x40025B6")]
	[FieldOffset(Offset = "0x60")]
	private int m_CoolResult;

	[Token(Token = "0x40025B7")]
	[FieldOffset(Offset = "0x64")]
	private int m_GreatResult;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40025B8")]
	private int m_PerfectResult;

	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40025B9")]
	private int m_JumpOverResult;

	[Token(Token = "0x40025BA")]
	[FieldOffset(Offset = "0x70")]
	private int m_FeverResult;

	[Token(Token = "0x600426D")]
	[Address(RVA = "0x79D1E0", Offset = "0x79B9E0", Length = "0x374")]
	public bool IsAll(BmsNodeUid[] ibmsId, byte result)
	{
		return default(bool);
	}

	[Obsolete]
	[Token(Token = "0x600426E")]
	[Address(RVA = "0x79D560", Offset = "0x79BD60", Length = "0x25E")]
	public bool IsAll(string[] ibmsId, byte result)
	{
		return default(bool);
	}

	[Token(Token = "0x600426F")]
	[Address(RVA = "0x79D7C0", Offset = "0x79BFC0", Length = "0x8")]
	public bool IsFullCombo()
	{
		return default(bool);
	}

	[Token(Token = "0x6004270")]
	[Address(RVA = "0x79BE40", Offset = "0x79A640", Length = "0xC4")]
	public float GetAccuracy()
	{
		return default(float);
	}

	[Obsolete]
	[Token(Token = "0x6004271")]
	[Address(RVA = "0x79CD20", Offset = "0x79B520", Length = "0x412")]
	public float GetTrueAccuracy()
	{
		return default(float);
	}

	[Token(Token = "0x6004272")]
	[Address(RVA = "0x79C870", Offset = "0x79B070", Length = "0x4A2")]
	public float GetTrueAccuracyNew()
	{
		return default(float);
	}

	[Token(Token = "0x6004273")]
	[Address(RVA = "0x79C510", Offset = "0x79AD10", Length = "0x1CF")]
	public KeyValuePair<string, int> GetStageEvaluate()
	{
		return default(KeyValuePair<string, int>);
	}

	[Address(RVA = "0x79D7D0", Offset = "0x79BFD0", Length = "0x2FE")]
	[Token(Token = "0x6004274")]
	public void SetPlayResult(int idx, uint result, bool isMulEnd = false)
	{
	}

	[Address(RVA = "0x79B1D0", Offset = "0x7999D0", Length = "0x184")]
	[Token(Token = "0x6004275")]
	private void AddCount(uint result, int value)
	{
	}

	[Token(Token = "0x6004276")]
	[Address(RVA = "0x79DAD0", Offset = "0x79C2D0", Length = "0xC")]
	public void TriggerNoteMiss()
	{
	}

	[Token(Token = "0x6004277")]
	[Address(RVA = "0x79D140", Offset = "0x79B940", Length = "0x9A")]
	private void InvokeJudgeEvent(uint result)
	{
	}

	[Token(Token = "0x6004278")]
	[Address(RVA = "0x79B3A0", Offset = "0x799BA0", Length = "0x208")]
	public void AddHitCount(ref MusicData md, bool isDouble = false)
	{
	}

	[Address(RVA = "0x79B600", Offset = "0x799E00", Length = "0x268")]
	[Token(Token = "0x6004279")]
	public void AddHitCount(TaskCount countType, int value)
	{
	}

	[Address(RVA = "0x44A0E0", Offset = "0x4488E0", Length = "0x4")]
	[Token(Token = "0x600427A")]
	public int GetHitCount()
	{
		return default(int);
	}

	[Token(Token = "0x600427B")]
	[Address(RVA = "0x79C160", Offset = "0x79A960", Length = "0xF8")]
	public int GetHitCountByResult(TaskResult result)
	{
		return default(int);
	}

	[Token(Token = "0x600427C")]
	[Address(RVA = "0x79BF10", Offset = "0x79A710", Length = "0x1C0")]
	public int GetCountValue(TaskCount taskType)
	{
		return default(int);
	}

	[Token(Token = "0x600427D")]
	[Address(RVA = "0x79C120", Offset = "0x79A920", Length = "0x39")]
	public int GetHitCountByResult(uint result)
	{
		return default(int);
	}

	[Token(Token = "0x600427E")]
	[Address(RVA = "0x79C280", Offset = "0x79AA80", Length = "0x1E4")]
	public float GetHitPercent(uint result)
	{
		return default(float);
	}

	[Token(Token = "0x600427F")]
	[Address(RVA = "0x79B380", Offset = "0x799B80", Length = "0x4")]
	public void AddEnergyItemCount(int value)
	{
	}

	[Token(Token = "0x6004280")]
	[Address(RVA = "0x42CB40", Offset = "0x42B340", Length = "0x4")]
	public int GetEnergyItemCount()
	{
		return default(int);
	}

	[Token(Token = "0x6004281")]
	[Address(RVA = "0x79B900", Offset = "0x79A100", Length = "0x4")]
	public void AddNoteItemCount(int value)
	{
	}

	[Token(Token = "0x6004282")]
	[Address(RVA = "0x50A7E0", Offset = "0x508FE0", Length = "0x4")]
	public int GetNoteItemCount()
	{
		return default(int);
	}

	[Address(RVA = "0x79B1B0", Offset = "0x7999B0", Length = "0x9")]
	[Token(Token = "0x6004283")]
	public void AddComboMax(int value)
	{
	}

	[Address(RVA = "0x42D1E0", Offset = "0x42B9E0", Length = "0x4")]
	[Token(Token = "0x6004284")]
	public int GetComboMax()
	{
		return default(int);
	}

	[Address(RVA = "0x79B370", Offset = "0x799B70", Length = "0x9")]
	[Token(Token = "0x6004285")]
	public void AddDamageMax(int value)
	{
	}

	[Address(RVA = "0x79B910", Offset = "0x79A110", Length = "0x52F")]
	[Token(Token = "0x6004286")]
	public void AddScore(int value, int id, string noteType, bool isAir, float time = -1f, byte customJudge = 0)
	{
	}

	[Address(RVA = "0x79B180", Offset = "0x799980", Length = "0x4")]
	[Token(Token = "0x6004287")]
	public void AddBlock(int value)
	{
	}

	[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
	[Token(Token = "0x6004288")]
	public int GetBlock()
	{
		return default(int);
	}

	[Address(RVA = "0x79B190", Offset = "0x799990", Length = "0x4")]
	[Token(Token = "0x6004289")]
	public void AddBlood(int value)
	{
	}

	[Token(Token = "0x600428A")]
	[Address(RVA = "0x597010", Offset = "0x595810", Length = "0x4")]
	public int GetBlood()
	{
		return default(int);
	}

	[Token(Token = "0x600428B")]
	[Address(RVA = "0x79B8C0", Offset = "0x79A0C0", Length = "0x4")]
	public void AddHitEnemy(int value)
	{
	}

	[Address(RVA = "0x597000", Offset = "0x595800", Length = "0x4")]
	[Token(Token = "0x600428C")]
	public int GetHitEnemy()
	{
		return default(int);
	}

	[Address(RVA = "0x79B8E0", Offset = "0x79A0E0", Length = "0x4")]
	[Token(Token = "0x600428D")]
	public void AddLongPressHit(int value)
	{
	}

	[Token(Token = "0x600428E")]
	[Address(RVA = "0x597020", Offset = "0x595820", Length = "0x4")]
	public int GetLongPressHit()
	{
		return default(int);
	}

	[Address(RVA = "0x79B1A0", Offset = "0x7999A0", Length = "0x4")]
	[Token(Token = "0x600428F")]
	public void AddBossNearHit(int value)
	{
	}

	[Token(Token = "0x6004290")]
	[Address(RVA = "0x596FF0", Offset = "0x5957F0", Length = "0x4")]
	public int GetBossNearHit()
	{
		return default(int);
	}

	[Token(Token = "0x6004291")]
	[Address(RVA = "0x79B8F0", Offset = "0x79A0F0", Length = "0x4")]
	public void AddMiss(int value)
	{
	}

	[Token(Token = "0x6004292")]
	[Address(RVA = "0x45A8F0", Offset = "0x4590F0", Length = "0x4")]
	public int GetMiss()
	{
		return default(int);
	}

	[Token(Token = "0x6004293")]
	[Address(RVA = "0x79B1C0", Offset = "0x7999C0", Length = "0xF")]
	public void AddComboMiss(int value)
	{
	}

	[Token(Token = "0x6004294")]
	[Address(RVA = "0x597030", Offset = "0x595830", Length = "0x4")]
	public int GetComboMiss()
	{
		return default(int);
	}

	[Address(RVA = "0x6F50D0", Offset = "0x6F38D0", Length = "0x4")]
	[Token(Token = "0x6004295")]
	public int GetAddScore()
	{
		return default(int);
	}

	[Token(Token = "0x6004296")]
	[Address(RVA = "0x79C470", Offset = "0x79AC70", Length = "0x91")]
	public int GetScore()
	{
		return default(int);
	}

	[Token(Token = "0x6004297")]
	[Address(RVA = "0x78DEB0", Offset = "0x78C6B0", Length = "0x4")]
	public void SetRecover(int value)
	{
	}

	[Token(Token = "0x6004298")]
	[Address(RVA = "0x782D10", Offset = "0x781510", Length = "0x4")]
	public int GetRecover()
	{
		return default(int);
	}

	[Token(Token = "0x6004299")]
	[Address(RVA = "0x79B8D0", Offset = "0x79A0D0", Length = "0x4")]
	public void AddLongPressFinishCount(int value)
	{
	}

	[Address(RVA = "0x597040", Offset = "0x595840", Length = "0x4")]
	[Token(Token = "0x600429A")]
	public int GetLongPressFinishCount()
	{
		return default(int);
	}

	[Token(Token = "0x600429B")]
	[Address(RVA = "0x79B390", Offset = "0x799B90", Length = "0x4")]
	public void AddHideNodeCount(int value)
	{
	}

	[Token(Token = "0x600429C")]
	[Address(RVA = "0x492770", Offset = "0x490F70", Length = "0x4")]
	public int GetHideNoteHitCount()
	{
		return default(int);
	}

	[Token(Token = "0x600429D")]
	[Address(RVA = "0x79C6E0", Offset = "0x79AEE0", Length = "0x18D")]
	public int GetTotalNum(uint noteType = uint.MaxValue)
	{
		return default(int);
	}

	[Token(Token = "0x600429E")]
	[Address(RVA = "0x79DAE0", Offset = "0x79C2E0", Length = "0x38")]
	public TaskStageTarget()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
