using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.GameCore.Interface;
using Cpp2ILInjected;
using GameLogic;
using MEC;

namespace GameCore.GameObjectLogics.ExtraControl.BloodheirExControl;

[Token(Token = "0x2000495")]
public class BloodHeirSpHpCreateController : IPause
{
	[Token(Token = "0x40018C4")]
	private const float start_create_blood_delay = 20f;

	[Token(Token = "0x40018C5")]
	private const int create_rate_add_value = 1;

	[Token(Token = "0x40018C6")]
	[FieldOffset(Offset = "0x10")]
	private int m_Rate;

	[Token(Token = "0x40018C7")]
	[FieldOffset(Offset = "0x18")]
	private List<MusicData> m_MonsterNoteDatas;

	[Token(Token = "0x40018C8")]
	[FieldOffset(Offset = "0x20")]
	private BloodHeirSkillDataModel m_SkillDataModel;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40018C9")]
	private CoroutineHandle m_DelayStartCreateBloodHandle;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40018CA")]
	private CoroutineHandle m_CreatingBloodAddRateHandle;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40018CB")]
	private CoroutineHandle m_CreatingBloodJudgeHandle;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40018CC")]
	private CoroutineHandle m_ResetBloodAddRateStateHandle;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40018CD")]
	private int m_CreatedCount;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40018CE")]
	private int m_HitNum;

	[Token(Token = "0x40018CF")]
	[FieldOffset(Offset = "0x40")]
	private bool m_CanCreateBlood;

	[Token(Token = "0x170004BC")]
	public bool IsGlobal
	{
		[CompilerGenerated]
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x5F9A70", Offset = "0x5F8270", Length = "0x5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003471")]
	[Address(RVA = "0x83CB30", Offset = "0x83B330", Length = "0x1F8")]
	public void Init()
	{
	}

	[Token(Token = "0x6003472")]
	[Address(RVA = "0x83CDA0", Offset = "0x83B5A0", Length = "0xE1")]
	public void Release()
	{
	}

	[Token(Token = "0x6003473")]
	[Address(RVA = "0x83CA80", Offset = "0x83B280", Length = "0xAF")]
	public void DelayToStartCreateBlood()
	{
	}

	[Token(Token = "0x6003474")]
	[Address(RVA = "0x83CE90", Offset = "0x83B690", Length = "0xF7")]
	private void ResetCreateBloodState()
	{
	}

	[Address(RVA = "0x83D000", Offset = "0x83B800", Length = "0xFF")]
	[Token(Token = "0x6003475")]
	private void StartCreateBlood()
	{
	}

	[Token(Token = "0x6003476")]
	[Address(RVA = "0x83D100", Offset = "0x83B900", Length = "0x70")]
	private void StopCreateBlood()
	{
	}

	[Token(Token = "0x6003477")]
	[Address(RVA = "0x83CD30", Offset = "0x83B530", Length = "0x70")]
	public void Pause(bool pauseCorountine)
	{
	}

	[Address(RVA = "0x83CF90", Offset = "0x83B790", Length = "0x70")]
	[Token(Token = "0x6003478")]
	public void Resume()
	{
	}

	[Token(Token = "0x600347A")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public BloodHeirSpHpCreateController()
	{
	}
}
