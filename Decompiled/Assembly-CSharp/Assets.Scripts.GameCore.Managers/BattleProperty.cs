using System;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000737")]
public class BattleProperty : Singleton<BattleProperty>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40025E1")]
	public int maxHp;

	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40025E2")]
	public decimal missHardTime;

	[Token(Token = "0x40025E3")]
	[FieldOffset(Offset = "0x24")]
	public bool isBloodMissHardTime;

	[Token(Token = "0x40025E4")]
	[FieldOffset(Offset = "0x28")]
	public int greatToPerfect;

	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x40025E5")]
	public int missToGreat;

	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0x30")]
	public float heartNoteRate;

	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x40025E7")]
	public float musicNoteRate;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40025E8")]
	public float hideNoteRate;

	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x40025E9")]
	public float blockNoteRate;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40025EA")]
	public float blockDamageRate;

	[Token(Token = "0x40025EB")]
	[FieldOffset(Offset = "0x44")]
	public float expRate;

	[Token(Token = "0x40025EC")]
	[FieldOffset(Offset = "0x48")]
	public bool hasGodChance;

	[Token(Token = "0x40025ED")]
	[FieldOffset(Offset = "0x4C")]
	public int godTimeCount;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40025EE")]
	public float godTime;

	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0x54")]
	public bool isInGod;

	[Token(Token = "0x40025F0")]
	[FieldOffset(Offset = "0x58")]
	public float comboRate;

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0x5C")]
	public int missComboMax;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40025F2")]
	public int hpSkillCount;

	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40025F3")]
	public int hpRevive;

	[Token(Token = "0x40025F4")]
	[FieldOffset(Offset = "0x68")]
	public float reviveRate;

	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x6C")]
	public decimal skillMissHardTime;

	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x7C")]
	public bool isOffFever;

	[Token(Token = "0x40025F7")]
	[FieldOffset(Offset = "0x80")]
	public int maxFever;

	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x40025F8")]
	public decimal hpChangedPerTime;

	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0x94")]
	public bool isLyrithSpecialLogic;

	[Token(Token = "0x40025FA")]
	[FieldOffset(Offset = "0x95")]
	public bool isHpChangable;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40025FB")]
	public float scoreExtraRate;

	[Token(Token = "0x40025FC")]
	[FieldOffset(Offset = "0x9C")]
	public float scoreCoefficient;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x40025FD")]
	public float feverTime;

	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x40025FE")]
	public int hurtReduce;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x40025FF")]
	public float hurtReduceRate;

	[FieldOffset(Offset = "0xAC")]
	[Token(Token = "0x4002600")]
	public int reviveDeadline;

	[Token(Token = "0x4002601")]
	[FieldOffset(Offset = "0xB0")]
	public decimal reviveDuration;

	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4002602")]
	public bool isReviveInvoked;

	[Token(Token = "0x4002603")]
	[FieldOffset(Offset = "0xC4")]
	public decimal reviveValue;

	[Token(Token = "0x4002604")]
	[FieldOffset(Offset = "0xD4")]
	public float bossAttackScoreRate;

	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4002605")]
	public bool isFeverGod;

	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0xDC")]
	public float feverScoreRate;

	[Token(Token = "0x4002607")]
	[FieldOffset(Offset = "0xE0")]
	public float perfectScoreExtra;

	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0xE4")]
	public int perfectHpRevive;

	[Token(Token = "0x4002609")]
	[FieldOffset(Offset = "0xE8")]
	public int musicNoteAddHp;

	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0xEC")]
	public decimal hitRangeAddValue;

	[FieldOffset(Offset = "0xFC")]
	[Token(Token = "0x400260B")]
	public decimal blockRP;

	[Token(Token = "0x400260C")]
	[FieldOffset(Offset = "0x10C")]
	public decimal blockRG;

	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x400260D")]
	public Func<float, float> accFunc;

	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400260E")]
	public bool isCatchAvailable;

	[Token(Token = "0x400260F")]
	[FieldOffset(Offset = "0x129")]
	public bool isGroundCatching;

	[FieldOffset(Offset = "0x12A")]
	[Token(Token = "0x4002610")]
	public bool isAirCatching;

	[FieldOffset(Offset = "0x12B")]
	[Token(Token = "0x4002611")]
	public bool isGcCharacter;

	[Token(Token = "0x4002612")]
	[FieldOffset(Offset = "0x12C")]
	public bool isDisappearNote;

	[Token(Token = "0x4002613")]
	[FieldOffset(Offset = "0x12D")]
	public bool isHideGameScene;

	[FieldOffset(Offset = "0x12E")]
	[Token(Token = "0x4002614")]
	public bool isRhythmElfin;

	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4002615")]
	public int RhythmCounter;

	[Token(Token = "0x4002616")]
	[FieldOffset(Offset = "0x134")]
	public bool isRhythmBuffStage;

	[FieldOffset(Offset = "0x135")]
	[Token(Token = "0x4002617")]
	public bool isRhythmUseSkill;

	[Token(Token = "0x4002618")]
	[FieldOffset(Offset = "0x136")]
	public bool isRhythmSuperBattlewornMusic;

	[Token(Token = "0x4002619")]
	[FieldOffset(Offset = "0x137")]
	public bool isOlaDash;

	[Token(Token = "0x400261A")]
	[FieldOffset(Offset = "0x138")]
	public bool isMuseDashHaveErrorEffect;

	[FieldOffset(Offset = "0x139")]
	[Token(Token = "0x400261B")]
	public bool isCloseOptimize;

	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x400261C")]
	public string traceResStr;

	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x400261D")]
	public bool isNeonEggIncubation;

	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x400261E")]
	public int currentNeonEggForm;

	[Token(Token = "0x400261F")]
	[FieldOffset(Offset = "0x150")]
	public bool jumpAndFloat;

	[Token(Token = "0x17000645")]
	public float wisaFeverTime
	{
		[Token(Token = "0x600431C")]
		[Address(RVA = "0x78A180", Offset = "0x788980", Length = "0x9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600431D")]
	[Address(RVA = "0x789FB0", Offset = "0x7887B0", Length = "0x1CC")]
	public BattleProperty()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
