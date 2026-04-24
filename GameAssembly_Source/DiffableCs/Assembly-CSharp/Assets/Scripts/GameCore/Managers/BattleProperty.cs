namespace Assets.Scripts.GameCore.Managers;

public class BattleProperty : Singleton<BattleProperty>
{
	public int maxHp; //Field offset: 0x10
	public decimal missHardTime; //Field offset: 0x14
	public bool isBloodMissHardTime; //Field offset: 0x24
	public int greatToPerfect; //Field offset: 0x28
	public int missToGreat; //Field offset: 0x2C
	public float heartNoteRate; //Field offset: 0x30
	public float musicNoteRate; //Field offset: 0x34
	public float hideNoteRate; //Field offset: 0x38
	public float blockNoteRate; //Field offset: 0x3C
	public float blockDamageRate; //Field offset: 0x40
	public float expRate; //Field offset: 0x44
	public bool hasGodChance; //Field offset: 0x48
	public int godTimeCount; //Field offset: 0x4C
	public float godTime; //Field offset: 0x50
	public bool isInGod; //Field offset: 0x54
	public float comboRate; //Field offset: 0x58
	public int missComboMax; //Field offset: 0x5C
	public int hpSkillCount; //Field offset: 0x60
	public int hpRevive; //Field offset: 0x64
	public float reviveRate; //Field offset: 0x68
	public decimal skillMissHardTime; //Field offset: 0x6C
	public bool isOffFever; //Field offset: 0x7C
	public int maxFever; //Field offset: 0x80
	public decimal hpChangedPerTime; //Field offset: 0x84
	public bool isLyrithSpecialLogic; //Field offset: 0x94
	public bool isHpChangable; //Field offset: 0x95
	public float scoreExtraRate; //Field offset: 0x98
	public float scoreCoefficient; //Field offset: 0x9C
	public float feverTime; //Field offset: 0xA0
	public int hurtReduce; //Field offset: 0xA4
	public int reviveDeadline; //Field offset: 0xA8
	public decimal reviveDuration; //Field offset: 0xAC
	public bool isReviveInvoked; //Field offset: 0xBC
	public decimal reviveValue; //Field offset: 0xC0
	public float bossAttackScoreRate; //Field offset: 0xD0
	public bool isFeverGod; //Field offset: 0xD4
	public float feverScoreRate; //Field offset: 0xD8
	public float perfectScoreExtra; //Field offset: 0xDC
	public int perfectHpRevive; //Field offset: 0xE0
	public int musicNoteAddHp; //Field offset: 0xE4
	public decimal hitRangeAddValue; //Field offset: 0xE8
	public decimal blockRP; //Field offset: 0xF8
	public decimal blockRG; //Field offset: 0x108
	public Func<Single, Single> accFunc; //Field offset: 0x118
	public bool isCatchAvailable; //Field offset: 0x120
	public bool isGroundCatching; //Field offset: 0x121
	public bool isAirCatching; //Field offset: 0x122
	public bool isGcCharacter; //Field offset: 0x123
	public bool isDisappearNote; //Field offset: 0x124
	public bool isHideGameScene; //Field offset: 0x125
	public bool isRhythmElfin; //Field offset: 0x126
	public int RhythmCounter; //Field offset: 0x128
	public bool isRhythmBuffStage; //Field offset: 0x12C
	public bool isRhythmUseSkill; //Field offset: 0x12D
	public bool isRhythmSuperBattlewornMusic; //Field offset: 0x12E
	public bool isCloseOptimize; //Field offset: 0x12F

	public BattleProperty() { }

}

