using Cpp2ILInjected;
using GameCore.GameObjectLogics.GameObjectManager.BattleQuestion;
using GameLogic;

namespace GameCore.GameObjectLogics.GameObjectManager._2025FoolActivity;

[Token(Token = "0x2000484")]
public class FoolQaActManager
{
	[Token(Token = "0x4001868")]
	private static int s_SavedSelectedRoleIdx;

	[Token(Token = "0x4001869")]
	private static int s_SavedSelectedElfinIdx;

	[Token(Token = "0x400186A")]
	[FieldOffset(Offset = "0x10")]
	private FoolQaActData m_ActData;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400186B")]
	private FoolQaActView m_ActView;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400186C")]
	private MusicData m_LastBossMultiHitData;

	[Token(Token = "0x400186D")]
	[FieldOffset(Offset = "0x180")]
	private int m_BossHitLostPoint;

	[FieldOffset(Offset = "0x184")]
	[Token(Token = "0x400186E")]
	private bool m_IsBossMul;

	[Token(Token = "0x170004B3")]
	public FoolQaActData Data
	{
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60033AD")]
	[Address(RVA = "0x8F84C0", Offset = "0x8F6CC0", Length = "0x13F")]
	public static bool IsSelectFoolQaActSong()
	{
		return default(bool);
	}

	[Address(RVA = "0x8F8D00", Offset = "0x8F7500", Length = "0x13D")]
	[Token(Token = "0x60033AE")]
	public static void ReplaceLegendRoleAndElfinInCurrentScene()
	{
	}

	[Address(RVA = "0x8F7C20", Offset = "0x8F6420", Length = "0x746")]
	[Token(Token = "0x60033AF")]
	public void GamePreload(BattleQuestionCoreController ctrl)
	{
	}

	[Token(Token = "0x60033B0")]
	[Address(RVA = "0x8F8370", Offset = "0x8F6B70", Length = "0x14A")]
	public void GameStart()
	{
	}

	[Token(Token = "0x60033B1")]
	[Address(RVA = "0x8F7B80", Offset = "0x8F6380", Length = "0x98")]
	private void GameVictory()
	{
	}

	[Token(Token = "0x60033B2")]
	[Address(RVA = "0x8F7B80", Offset = "0x8F6380", Length = "0x98")]
	private void GameOnFailed()
	{
	}

	[Token(Token = "0x60033B3")]
	[Address(RVA = "0x8F75F0", Offset = "0x8F5DF0", Length = "0x124")]
	private void GameEndFailed()
	{
	}

	[Token(Token = "0x60033B4")]
	[Address(RVA = "0x8F7720", Offset = "0x8F5F20", Length = "0x458")]
	public void GameEnd()
	{
	}

	[Address(RVA = "0x8F74F0", Offset = "0x8F5CF0", Length = "0xF4")]
	[Token(Token = "0x60033B5")]
	public bool CheckGameIsFail(MultHitEnemyController ctrl)
	{
		return default(bool);
	}

	[Address(RVA = "0x8F7B80", Offset = "0x8F6380", Length = "0x98")]
	[Token(Token = "0x60033B6")]
	private void OnGameVictory(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x8F8BE0", Offset = "0x8F73E0", Length = "0x2A")]
	[Token(Token = "0x60033B7")]
	private void OnMultiHitStart(MultHitEnemyController multHitEnemyController)
	{
	}

	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x8F8B50", Offset = "0x8F7350", Length = "0x80")]
	private void OnMultiHitOn(int hitCount)
	{
	}

	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x8F8C10", Offset = "0x8F7410", Length = "0xEE")]
	private void OnNoteMiss(int noteIdx)
	{
	}

	[Address(RVA = "0x8F8A50", Offset = "0x8F7250", Length = "0xFE")]
	[Token(Token = "0x60033BA")]
	private void OnGirlMissAndHurt(object sender, object reciever, object[] args)
	{
	}

	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x8F8980", Offset = "0x8F7180", Length = "0xCA")]
	private void OnGirlIn(object sender, object reciever, object[] args)
	{
	}

	[Address(RVA = "0x8F8940", Offset = "0x8F7140", Length = "0x3C")]
	[Token(Token = "0x60033BC")]
	private void OnBossEnter()
	{
	}

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x8F8600", Offset = "0x8F6E00", Length = "0x338")]
	private void OnAnswerCompleted(MusicData md, bool answerResult)
	{
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x8F8E40", Offset = "0x8F7640", Length = "0x23A")]
	private void ShowCharacterRepliedEffects(MusicData md, bool answerRes)
	{
	}

	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	[Token(Token = "0x60033BF")]
	public FoolQaActManager()
	{
	}
}
