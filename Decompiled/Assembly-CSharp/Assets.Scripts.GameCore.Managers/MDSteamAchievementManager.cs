using Assets.Scripts.Database;
using Assets.Scripts.Managers;
using Assets.Scripts.Structs;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000751")]
internal class MDSteamAchievementManager : SteamAchievementManager
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40026B3")]
	private DBConfigSteamAchievement m_DBConfigSteamAchievement;

	[Token(Token = "0x40026B4")]
	[FieldOffset(Offset = "0x28")]
	private int m_NonHiddenCount;

	[Token(Token = "0x40026B5")]
	[FieldOffset(Offset = "0x2C")]
	private int m_FinishNonHiddenCount;

	[Token(Token = "0x60044CB")]
	[Address(RVA = "0x6D47C0", Offset = "0x6D2FC0", Length = "0x4C")]
	public MDSteamAchievementManager()
	{
	}

	[Token(Token = "0x60044CC")]
	[Address(RVA = "0x6D4280", Offset = "0x6D2A80", Length = "0xD4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60044CD")]
	[Address(RVA = "0x6D4270", Offset = "0x6D2A70", Length = "0xA")]
	private void InitUserData()
	{
	}

	[Address(RVA = "0x6D4590", Offset = "0x6D2D90", Length = "0xA")]
	[Token(Token = "0x60044CE")]
	protected override void RefreshState()
	{
	}

	[Token(Token = "0x60044CF")]
	[Address(RVA = "0x6D4410", Offset = "0x6D2C10", Length = "0x170")]
	private void Private_RefreshState(bool init)
	{
	}

	[Token(Token = "0x60044D0")]
	[Address(RVA = "0x6D4230", Offset = "0x6D2A30", Length = "0x1E")]
	protected override string GetApiNameById(int id)
	{
		return null;
	}

	[Token(Token = "0x60044D1")]
	[Address(RVA = "0x6D4250", Offset = "0x6D2A50", Length = "0x1E")]
	protected override string GetStateNameById(int id)
	{
		return null;
	}

	[Address(RVA = "0x6D4690", Offset = "0x6D2E90", Length = "0x12D")]
	[Token(Token = "0x60044D2")]
	public void TutorialDo()
	{
	}

	[Address(RVA = "0x6D4360", Offset = "0x6D2B60", Length = "0xA4")]
	[Token(Token = "0x60044D3")]
	public void ItemDo(int characterUnlockCount, int elfinUnlockCount, int loadingUnlockCount)
	{
	}

	[Address(RVA = "0x6D3B60", Offset = "0x6D2360", Length = "0x94")]
	[Token(Token = "0x60044D4")]
	public void BattleEndDo(ref GlobalAchievementArgs args)
	{
	}

	[Address(RVA = "0x6D45A0", Offset = "0x6D2DA0", Length = "0x6D")]
	[Token(Token = "0x60044D5")]
	public void SetSpecialSteamAchievement(int id, bool enable = true)
	{
	}

	[Token(Token = "0x60044D6")]
	[Address(RVA = "0x6D4610", Offset = "0x6D2E10", Length = "0x70")]
	private void SteamBattleAchievementCheck(ref GlobalAchievementArgs args)
	{
	}

	[Address(RVA = "0x6D4130", Offset = "0x6D2930", Length = "0xF9")]
	[Token(Token = "0x60044D7")]
	private void CheckOrderAchievement()
	{
	}

	[Token(Token = "0x60044D8")]
	[Address(RVA = "0x6D3C00", Offset = "0x6D2400", Length = "0x49C")]
	private void CheckBattleAchievement(int id, ref GlobalAchievementArgs args)
	{
	}
}
