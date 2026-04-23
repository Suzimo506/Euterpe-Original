using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000735")]
public class AchievementManager : Singleton<AchievementManager>
{
	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0x18")]
	private int m_BaseStageAchiCount;

	[Token(Token = "0x17000644")]
	public List<string> achievements
	{
		[CompilerGenerated]
		[Token(Token = "0x600430B")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x600430A")]
		[Address(RVA = "0x4894E0", Offset = "0x487CE0", Length = "0xC")]
		private set
		{
		}
	}

	[Address(RVA = "0x787280", Offset = "0x785A80", Length = "0x102")]
	[Token(Token = "0x600430C")]
	private void Init()
	{
	}

	[Address(RVA = "0x787390", Offset = "0x785B90", Length = "0x52")]
	[Token(Token = "0x600430D")]
	public bool IsDone(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x600430E")]
	[Address(RVA = "0x787000", Offset = "0x785800", Length = "0x27B")]
	public GlobalAchievementArgs GetGlobalAchievementArgs(bool isSuccess)
	{
		return default(GlobalAchievementArgs);
	}

	[Token(Token = "0x600430F")]
	[Address(RVA = "0x786E50", Offset = "0x785650", Length = "0x115")]
	public void Do(bool isSuccess)
	{
	}

	[Token(Token = "0x6004310")]
	[Address(RVA = "0x787610", Offset = "0x785E10", Length = "0xB00")]
	private void RecordBattleArgs(ref GlobalAchievementArgs args, bool isSuccess)
	{
	}

	[Token(Token = "0x6004311")]
	[Address(RVA = "0x7862E0", Offset = "0x784AE0", Length = "0x96D")]
	private void CheckGlobalAchievement(ref GlobalAchievementArgs args, bool isSuccess)
	{
	}

	[Token(Token = "0x6004312")]
	[Address(RVA = "0x7873F0", Offset = "0x785BF0", Length = "0x212")]
	public void ItemChipAchievementCheck()
	{
	}

	[Token(Token = "0x6004313")]
	[Address(RVA = "0x786D50", Offset = "0x785550", Length = "0xF3")]
	public void DoTutorialAchievement()
	{
	}

	[Token(Token = "0x6004314")]
	[Address(RVA = "0x786F70", Offset = "0x785770", Length = "0x8C")]
	private void EasyDoAchievement(string index, bool isFinish)
	{
	}

	[Address(RVA = "0x786C50", Offset = "0x785450", Length = "0xF6")]
	[Token(Token = "0x6004315")]
	private void DoAchievement(string index, int[] targets, int value)
	{
	}

	[Token(Token = "0x6004316")]
	[Address(RVA = "0x788120", Offset = "0x786920", Length = "0xF0")]
	private void Reward(string uid)
	{
	}

	[Token(Token = "0x6004317")]
	[Address(RVA = "0x788220", Offset = "0x786A20", Length = "0x38")]
	public AchievementManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
