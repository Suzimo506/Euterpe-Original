using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using FormulaBase;
using GameCore.GameObjectLogics.GameObjectManager;
using GameLogic;
using PeroPeroGames.GlobalDefines;
using Spine.Unity;
using UnityEngine;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074D")]
public class SkillManager : Singleton<SkillManager>
{
	[Token(Token = "0x2000CC5")]
	public enum RacerRinState
	{
		[Token(Token = "0x4003DFD")]
		Normal,
		[Token(Token = "0x4003DFE")]
		Mad
	}

	[Token(Token = "0x4002698")]
	[FieldOffset(Offset = "0x10")]
	private readonly Dictionary<int, Type> m_RoleSkills;

	[Token(Token = "0x4002699")]
	[FieldOffset(Offset = "0x18")]
	private readonly Dictionary<int, Type> m_ElfinSkills;

	[Token(Token = "0x400269A")]
	private static bool s_SkillInvalid;

	[Token(Token = "0x400269B")]
	public static readonly int racer_rin_skill_hp;

	[Token(Token = "0x400269C")]
	private static Coroutine zombieSkillStart;

	[Token(Token = "0x400269D")]
	private static Coroutine zombieSkillStop;

	[Token(Token = "0x400269E")]
	private static float m_CatchReactAirTime;

	[Token(Token = "0x400269F")]
	private static float m_CatchReactGroundTime;

	[Token(Token = "0x40026A0")]
	private const int catch_head_notes = 1;

	[Token(Token = "0x40026A1")]
	private const int catch_notes = 2;

	[Token(Token = "0x40026A2")]
	private static readonly Dictionary<int, int[]> rarityWeights;

	[Token(Token = "0x40026A4")]
	private static bool s_IsLinStart;

	[Token(Token = "0x40026A5")]
	private static bool s_IsLinEnd;

	[Token(Token = "0x17000670")]
	public static bool isRacerKeepMad
	{
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x6EC100", Offset = "0x6EA900", Length = "0x48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000671")]
	private static BloodHeirGirlManager BloodHeirGirlMgr
	{
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x6EBFB0", Offset = "0x6EA7B0", Length = "0xE7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000672")]
	public static WisadelGirlManager WisadelGirl
	{
		[CompilerGenerated]
		[Token(Token = "0x6004497")]
		[Address(RVA = "0x6EC0A0", Offset = "0x6EA8A0", Length = "0x57")]
		private get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x6004498")]
		[Address(RVA = "0x6EC150", Offset = "0x6EA950", Length = "0x67")]
		set
		{
		}
	}

	[Address(RVA = "0x6E0060", Offset = "0x6DE860", Length = "0x443")]
	[Token(Token = "0x6004451")]
	public void Apply()
	{
	}

	[Token(Token = "0x6004452")]
	[Address(RVA = "0x6E6730", Offset = "0x6E4F30", Length = "0x18A")]
	public static void ReleaseReference()
	{
	}

	[Token(Token = "0x6004453")]
	[Address(RVA = "0x6E31B0", Offset = "0x6E19B0", Length = "0x298")]
	private void InitCache()
	{
	}

	[Token(Token = "0x6004454")]
	[Address(RVA = "0x6E64D0", Offset = "0x6E4CD0", Length = "0x109")]
	private void PreloadElfinSkill(int index)
	{
	}

	[Token(Token = "0x6004455")]
	[Address(RVA = "0x6E1A20", Offset = "0x6E0220", Length = "0x104")]
	private static bool CheckRoleSkillIsValidate(int role, bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004456")]
	[Address(RVA = "0x6E1B30", Offset = "0x6E0330", Length = "0x4F")]
	public static bool CheckSleepyRinSkillIsValidate()
	{
		return default(bool);
	}

	[Token(Token = "0x6004457")]
	[Address(RVA = "0x6E65E0", Offset = "0x6E4DE0", Length = "0x142")]
	public static void RampageSkill(ref byte result, ref bool isElfinSkill, MusicData md)
	{
	}

	[Token(Token = "0x6004459")]
	[Address(RVA = "0x6E18A0", Offset = "0x6E00A0", Length = "0x56")]
	public static bool CheckIsRacerRin(bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600445A")]
	[Address(RVA = "0x6E9860", Offset = "0x6E8060", Length = "0x776")]
	public static bool SkillRacerRin_UpEightyHp_MissToGreat(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x6E93E0", Offset = "0x6E7BE0", Length = "0x474")]
	[Token(Token = "0x600445B")]
	private static void SkillRacerRin_UpEightyHp_DoubleNoteCheck(MusicData md)
	{
	}

	[Token(Token = "0x600445C")]
	[Address(RVA = "0x6E9FE0", Offset = "0x6E87E0", Length = "0x13D")]
	public static decimal SkillRacerRin_UpEightyHp_ResetMissHardTime()
	{
		return default(decimal);
	}

	[Token(Token = "0x600445D")]
	[Address(RVA = "0x6E9260", Offset = "0x6E7A60", Length = "0x17B")]
	public static void SkillRacerRin_DownEightyHp_HardTimeInvalidate()
	{
	}

	[Token(Token = "0x600445E")]
	[Address(RVA = "0x6E8D60", Offset = "0x6E7560", Length = "0x4F1")]
	public static void SkillRacerRin_DownEightyHp_GreatToPerfect(MusicData md, ref byte resultCode, bool isElfinSkill = false)
	{
	}

	[Token(Token = "0x600445F")]
	[Address(RVA = "0x6E1840", Offset = "0x6E0040", Length = "0x56")]
	public static bool CheckIsPirateRin(bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004460")]
	[Address(RVA = "0x6E60B0", Offset = "0x6E48B0", Length = "0xAD")]
	public static void PirateRin_CheckLongPressStartJudged(int pressHeaderResult, ref bool hitStay)
	{
	}

	[Token(Token = "0x6004461")]
	[Address(RVA = "0x6E5E30", Offset = "0x6E4630", Length = "0x274")]
	public static void PirateRin_AutoLongPressing(MusicData pressHeaderMd, TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x6004462")]
	[Address(RVA = "0x6E6160", Offset = "0x6E4960", Length = "0xCC")]
	public static void PirateRin_LongPressEndResult(ref MusicData pressEndMd, ref TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x6004463")]
	[Address(RVA = "0x6E6230", Offset = "0x6E4A30", Length = "0x29B")]
	public static void PirateRin_ShortLongPressOptimization(TimeNodeOrder tno)
	{
	}

	[Address(RVA = "0x6EBA30", Offset = "0x6EA230", Length = "0x363")]
	[Token(Token = "0x6004464")]
	public static void ZombieSkill(bool invoke)
	{
	}

	[Token(Token = "0x6004465")]
	[Address(RVA = "0x6E3930", Offset = "0x6E2130", Length = "0xA7")]
	public static void JkSetCatchTime(bool isAir, float time)
	{
	}

	[Token(Token = "0x6004466")]
	[Address(RVA = "0x6E38C0", Offset = "0x6E20C0", Length = "0x6F")]
	public static void JkResetCatchTime()
	{
	}

	[Token(Token = "0x6004467")]
	[Address(RVA = "0x6E3580", Offset = "0x6E1D80", Length = "0x216")]
	public static void JkCatchInputCheck(int index)
	{
	}

	[Token(Token = "0x6004468")]
	[Address(RVA = "0x6E37A0", Offset = "0x6E1FA0", Length = "0x53")]
	public static void JkRefreshCatch(bool isAir)
	{
	}

	[Token(Token = "0x6004469")]
	[Address(RVA = "0x6E3800", Offset = "0x6E2000", Length = "0xBE")]
	public static void JkResetCatchTime(bool isAir)
	{
	}

	[Address(RVA = "0x6E3EC0", Offset = "0x6E26C0", Length = "0x7C0")]
	[Token(Token = "0x600446A")]
	public static void LoadJKSkill(List<MusicData> musicDatas)
	{
	}

	[Token(Token = "0x600446B")]
	[Address(RVA = "0x6E3450", Offset = "0x6E1C50", Length = "0x12B")]
	private static void JkAddCatchNotes(int index, int listIndex)
	{
	}

	[Token(Token = "0x600446C")]
	[Address(RVA = "0x6EA120", Offset = "0x6E8920", Length = "0x38D")]
	public static void TaoistBuroHurtAndCostFeverEnergy(ref int hurtValue)
	{
	}

	[Token(Token = "0x600446D")]
	[Address(RVA = "0x6E2A50", Offset = "0x6E1250", Length = "0x216")]
	public static float GetHurtReduceFeverTime(int costFeverValue)
	{
		return default(float);
	}

	[Token(Token = "0x600446E")]
	[Address(RVA = "0x6E1960", Offset = "0x6E0160", Length = "0x56")]
	public static bool CheckIsTaoistBuro(bool isEffectByElSlience = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600446F")]
	[Address(RVA = "0x6E1780", Offset = "0x6DFF80", Length = "0x56")]
	public static bool CheckIsHastuneMiku(bool isEffectByElSlience = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004470")]
	[Address(RVA = "0x6E1900", Offset = "0x6E0100", Length = "0x56")]
	public static bool CheckIsRinLen(bool isEffectByElSlience = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004471")]
	[Address(RVA = "0x6E17E0", Offset = "0x6DFFE0", Length = "0x56")]
	public static bool CheckIsLegendBuro(bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004472")]
	[Address(RVA = "0x6E3CF0", Offset = "0x6E24F0", Length = "0x112")]
	public static void LegendBuroSkill_AutoMultiHitWhenMultiNoteIsHitted(int hitCount)
	{
	}

	[Token(Token = "0x6004473")]
	[Address(RVA = "0x6E39E0", Offset = "0x6E21E0", Length = "0x1A5")]
	public static void LegendBuroSkill_AutoHitMultiEnemy(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x6004474")]
	[Address(RVA = "0x6E3B90", Offset = "0x6E2390", Length = "0x15C")]
	public static void LegendBuroSkill_AutoMultiHitClose()
	{
	}

	[Token(Token = "0x6004476")]
	[Address(RVA = "0x6E1660", Offset = "0x6DFE60", Length = "0x56")]
	public static bool CheckIsBloodHeir(bool isEffectByElSlience = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004477")]
	[Address(RVA = "0x6E0CF0", Offset = "0x6DF4F0", Length = "0x12")]
	public static bool BloodHeirSkill_IsNoteCanCreateSpHp(BmsNodeUid noteBmsUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004478")]
	[Address(RVA = "0x6E0BD0", Offset = "0x6DF3D0", Length = "0x113")]
	public static bool BloodHeirSkill_IfGetBloodWillSkillOn(int toGetHpValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6004479")]
	[Address(RVA = "0x6E0D10", Offset = "0x6DF510", Length = "0x108")]
	public static bool BloodHeirSkill_IsRoleSkillOn()
	{
		return default(bool);
	}

	[Token(Token = "0x600447A")]
	[Address(RVA = "0x6E0850", Offset = "0x6DF050", Length = "0x37F")]
	public static void BloodHeirSkill_ChangeToExtraScore(MusicData md)
	{
	}

	[Token(Token = "0x600447B")]
	[Address(RVA = "0x6E1320", Offset = "0x6DFB20", Length = "0x1FE")]
	public static void BloodHeirSkill_PickMusicTouchNote(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x600447C")]
	[Address(RVA = "0x6E10E0", Offset = "0x6DF8E0", Length = "0x231")]
	public static bool BloodHeirSkill_NoteMiss2Great(int tnoIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600447D")]
	[Address(RVA = "0x6E0E20", Offset = "0x6DF620", Length = "0x2BF")]
	public static void BloodHeirSkill_NoteGreat2Perfect(MusicData md, ref byte hitResult, ref bool isSkill, bool isElfinSkill)
	{
	}

	[Address(RVA = "0x6E0700", Offset = "0x6DEF00", Length = "0x14B")]
	[Token(Token = "0x600447E")]
	public static void BloodHeirSkill_AddBloodingStateActionSuffix(SkeletonAnimation skAnima, ref string skeletonActionName)
	{
	}

	[Token(Token = "0x600447F")]
	[Address(RVA = "0x6E1720", Offset = "0x6DFF20", Length = "0x56")]
	public static bool CheckIsDiverBuro(bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004480")]
	[Address(RVA = "0x6E1520", Offset = "0x6DFD20", Length = "0x13D")]
	private static bool CheckDiverBuroSkillIsDisable()
	{
		return default(bool);
	}

	[Token(Token = "0x6004481")]
	[Address(RVA = "0x6E0CF0", Offset = "0x6DF4F0", Length = "0x12")]
	private static bool DiverSkillIsTrue(BmsNodeUid noteBmsUid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004482")]
	[Address(RVA = "0x6E3050", Offset = "0x6E1850", Length = "0x153")]
	private static DaveFishQuality GetRandomRarity(int level)
	{
		return default(DaveFishQuality);
	}

	[Token(Token = "0x6004483")]
	[Address(RVA = "0x6E2C70", Offset = "0x6E1470", Length = "0x3D9")]
	private static DaveFishData GetRandomFishByRarity(DaveFishQuality quality)
	{
		return null;
	}

	[Address(RVA = "0x6E27B0", Offset = "0x6E0FB0", Length = "0x295")]
	[Token(Token = "0x6004484")]
	private static DaveFishData GenerateFishes(int level)
	{
		return null;
	}

	[Address(RVA = "0x6E2160", Offset = "0x6E0960", Length = "0x644")]
	[Token(Token = "0x6004485")]
	public static void DaveFishRandom(List<MusicData> musicTickData)
	{
	}

	[Token(Token = "0x6004486")]
	[Address(RVA = "0x6E86B0", Offset = "0x6E6EB0", Length = "0x6A7")]
	public static void SisterSkill(List<MusicData> musicDatas)
	{
	}

	[Token(Token = "0x6004487")]
	[Address(RVA = "0x6E16C0", Offset = "0x6DFEC0", Length = "0x56")]
	public static bool CheckIsDancerMarija(bool isEffectByElSlience = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6004488")]
	[Address(RVA = "0x6E2000", Offset = "0x6E0800", Length = "0x158")]
	public static void DancerAutoFeverStart()
	{
	}

	[Token(Token = "0x6004489")]
	[Address(RVA = "0x6E53D0", Offset = "0x6E3BD0", Length = "0x2F0")]
	public static bool NekoSkill(int hp)
	{
		return default(bool);
	}

	[Token(Token = "0x600448A")]
	[Address(RVA = "0x6EB870", Offset = "0x6EA070", Length = "0x1BD")]
	public static void YumeSkill(int index)
	{
	}

	[Address(RVA = "0x6E1B80", Offset = "0x6E0380", Length = "0x47A")]
	[Token(Token = "0x600448B")]
	public static bool ClearSkill(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x6DF9C0", Offset = "0x6DE1C0", Length = "0x146")]
	[Token(Token = "0x600448C")]
	public static void AmiyaSkillG2P(ref byte result, ref bool isSkill, MusicData md)
	{
	}

	[Address(RVA = "0x6DFB10", Offset = "0x6DE310", Length = "0x546")]
	[Token(Token = "0x600448D")]
	public static bool AmiyaSkillM2G(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600448E")]
	[Address(RVA = "0x6E8590", Offset = "0x6E6D90", Length = "0x11B")]
	private static void SetEffectLocate(GameObject effect, bool isAir)
	{
	}

	[Token(Token = "0x600448F")]
	[Address(RVA = "0x6E4E10", Offset = "0x6E3610", Length = "0x158")]
	public static void MikuSkill_ReverseLongPressNoteJudgeState(ref bool hitStay, ref bool hitEnd)
	{
	}

	[Token(Token = "0x6004490")]
	[Address(RVA = "0x6E4F70", Offset = "0x6E3770", Length = "0x452")]
	public static void MikuSkill_ReverseSingleNoteJudgeState(TimeNodeOrder tno, ref bool isRoadActivation, ref bool isAirActivation, ref bool isLongActivation)
	{
	}

	[Token(Token = "0x6004491")]
	[Address(RVA = "0x6E4690", Offset = "0x6E2E90", Length = "0x774")]
	private static bool MikuSkill_ReverseJudgeOpitimazation(TimeNodeOrder tno)
	{
		return default(bool);
	}

	[Token(Token = "0x6004492")]
	[Address(RVA = "0x6E6CF0", Offset = "0x6E54F0", Length = "0x2A5")]
	public static void RinLenSkill_AddMissedNotes(TimeNodeOrder tno)
	{
	}

	[Address(RVA = "0x6E6FA0", Offset = "0x6E57A0", Length = "0x25E")]
	[Token(Token = "0x6004493")]
	public static void RinLenSkill_AutoBeatMissedNotes(TimeNodeOrder tno)
	{
	}

	[Token(Token = "0x6004494")]
	[Address(RVA = "0x6E7400", Offset = "0x6E5C00", Length = "0x36E")]
	public static void RinLenSkill_PreInitSameTickDifferentRailNotesData(ref List<MusicData> musicTickDatas)
	{
	}

	[Address(RVA = "0x6E7200", Offset = "0x6E5A00", Length = "0x1FC")]
	[Token(Token = "0x6004495")]
	public static void RinLenSkill_ChangeDoubleClickJudgeResult(MusicData md, ref byte noteResult)
	{
	}

	[Token(Token = "0x6004496")]
	[Address(RVA = "0x6E7770", Offset = "0x6E5F70", Length = "0x4AC")]
	public static void RinLenSkill_ShowAttackToMissedNotes(int idx, byte resultCode)
	{
	}

	[Token(Token = "0x6004499")]
	[Address(RVA = "0x6E19C0", Offset = "0x6E01C0", Length = "0x56")]
	public static bool CheckIsWisadel(bool isAffectedByElfinSliencer = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600449A")]
	[Address(RVA = "0x6EA8B0", Offset = "0x6E90B0", Length = "0x32F")]
	public static void WisadelSkill_ChangeNoteJudgedResult(MusicData md, ref byte resultCode, ref bool isSkill, bool isElfinSkill)
	{
	}

	[Address(RVA = "0x6EB190", Offset = "0x6E9990", Length = "0x4D5")]
	[Token(Token = "0x600449B")]
	public static bool WisadelSkill_OnFeverMissedNoteJudged(int idx)
	{
		return default(bool);
	}

	[Address(RVA = "0x6EAD40", Offset = "0x6E9540", Length = "0x44F")]
	[Token(Token = "0x600449C")]
	public static bool WisadelSkill_OnFeverMissCheck(int noteIdx, MusicData md)
	{
		return default(bool);
	}

	[Token(Token = "0x600449D")]
	[Address(RVA = "0x6EABE0", Offset = "0x6E93E0", Length = "0x158")]
	public static bool WisadelSkill_CheckWisaIsOnFever()
	{
		return default(bool);
	}

	[Token(Token = "0x600449E")]
	[Address(RVA = "0x6EB670", Offset = "0x6E9E70", Length = "0xC0")]
	public static bool WisadelSkill_ShowWisadelAtkEffect(bool isAirAtk)
	{
		return default(bool);
	}

	[Token(Token = "0x600449F")]
	[Address(RVA = "0x6EB740", Offset = "0x6E9F40", Length = "0x12E")]
	public static void WisadelSkill_ShowWisadelJumpEffect()
	{
	}

	[Address(RVA = "0x6E6940", Offset = "0x6E5140", Length = "0x3AC")]
	[Token(Token = "0x60044A0")]
	public static bool RhythmSkill(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x6E68C0", Offset = "0x6E50C0", Length = "0x75")]
	[Token(Token = "0x60044A1")]
	public static void RhythmDoctorG2P(ref byte result, ref bool isElfinSkill, MusicData md)
	{
	}

	[Token(Token = "0x60044A2")]
	[Address(RVA = "0x6E7C20", Offset = "0x6E6420", Length = "0x969")]
	public static bool RobotSkill(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60044A3")]
	[Address(RVA = "0x6E3E10", Offset = "0x6E2610", Length = "0xA2")]
	public static void LilithSkill(byte result)
	{
	}

	[Token(Token = "0x60044A4")]
	[Address(RVA = "0x6E5BD0", Offset = "0x6E43D0", Length = "0x1D2")]
	public static void NeonEggFormR6Skill(ref int hurtValue, bool isAir)
	{
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0x6E5DB0", Offset = "0x6E45B0", Length = "0x78")]
	public static void NeonEggFormSayaSkill()
	{
	}

	[Address(RVA = "0x6E56D0", Offset = "0x6E3ED0", Length = "0x4F3")]
	[Token(Token = "0x60044A6")]
	public static bool NeonEggFormLinSkill(int index)
	{
		return default(bool);
	}

	[Address(RVA = "0x6E04B0", Offset = "0x6DECB0", Length = "0x249")]
	[Token(Token = "0x60044A7")]
	public static bool BetaDogSkill(int hp)
	{
		return default(bool);
	}

	[Token(Token = "0x60044A8")]
	[Address(RVA = "0x6EBF10", Offset = "0x6EA710", Length = "0x9B")]
	public SkillManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
