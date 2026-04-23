using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Datas;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x200074E")]
public class StageAchievementManager : Singleton<StageAchievementManager>
{
	[Token(Token = "0x40026A6")]
	[FieldOffset(Offset = "0x10")]
	private SingletonDataObject m_StageAchievement;

	[Token(Token = "0x40026A7")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_StageAchievements;

	[Token(Token = "0x60044AB")]
	[Address(RVA = "0x7CFAE0", Offset = "0x7CE2E0", Length = "0x94")]
	private void Init()
	{
	}

	[Token(Token = "0x60044AC")]
	[Address(RVA = "0x7CF880", Offset = "0x7CE080", Length = "0x1F1")]
	private AchievementArgs GetAchievementArgs()
	{
		return default(AchievementArgs);
	}

	[Token(Token = "0x60044AD")]
	[Address(RVA = "0x7CF820", Offset = "0x7CE020", Length = "0x51")]
	public void Do()
	{
	}

	[Token(Token = "0x60044AE")]
	[Address(RVA = "0x7CF550", Offset = "0x7CDD50", Length = "0x2C8")]
	public void DoAchievements(AchievementArgs achiArgs)
	{
	}

	[Address(RVA = "0x7CFB80", Offset = "0x7CE380", Length = "0x52")]
	[Token(Token = "0x60044AF")]
	public bool IsFinish(string saveId)
	{
		return default(bool);
	}

	[Token(Token = "0x60044B0")]
	[Address(RVA = "0x7CFA80", Offset = "0x7CE280", Length = "0x5D")]
	public int GetFinishCount(string saveId)
	{
		return default(int);
	}

	[Token(Token = "0x60044B1")]
	[Address(RVA = "0x7CF490", Offset = "0x7CDC90", Length = "0xB4")]
	public int AddFinishCount(string saveId, int count)
	{
		return default(int);
	}

	[Token(Token = "0x60044B2")]
	[Address(RVA = "0x7CFBE0", Offset = "0x7CE3E0", Length = "0x115")]
	private void Reward(string uid)
	{
	}

	[Address(RVA = "0x7CFD00", Offset = "0x7CE500", Length = "0x38")]
	[Token(Token = "0x60044B3")]
	public StageAchievementManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
