using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Common;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.PeroTools.Nice.Interface;
using Cpp2ILInjected;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000750")]
public class StatisticsManager : Singleton<StatisticsManager>
{
	[Token(Token = "0x40026AA")]
	[FieldOffset(Offset = "0x10")]
	private List<Beat> m_Beats;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40026AB")]
	private int m_BeatIndex;

	[Token(Token = "0x40026AC")]
	[FieldOffset(Offset = "0x20")]
	public List<int> m_TutorialArray;

	[Token(Token = "0x40026AE")]
	[FieldOffset(Offset = "0x30")]
	private List<IData> m_SortedRecentPlayDataCache;

	[Token(Token = "0x40026AF")]
	[FieldOffset(Offset = "0x38")]
	private List<(string, int)> m_MostUseCharacterDatasCache;

	[Token(Token = "0x40026B0")]
	[FieldOffset(Offset = "0x40")]
	private bool m_BestDataCacheIsValid;

	[Token(Token = "0x40026B1")]
	[FieldOffset(Offset = "0x41")]
	private bool m_MostUseCharacterDatasCacheIsValid;

	[Token(Token = "0x40026B2")]
	[FieldOffset(Offset = "0x44")]
	private int maxRecentPlayDataCount;

	[Token(Token = "0x17000673")]
	public bool isNormalTutorial
	{
		[CompilerGenerated]
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x45A8E0", Offset = "0x4590E0", Length = "0x5")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x45AB40", Offset = "0x459340", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000674")]
	private List<IData> m_RecentPassLeveData
	{
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x7D34D0", Offset = "0x7D1CD0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60044BD")]
	[Address(RVA = "0x7D2490", Offset = "0x7D0C90", Length = "0x2B8")]
	public void OnBattleStart()
	{
	}

	[Token(Token = "0x60044BE")]
	[Address(RVA = "0x7D1560", Offset = "0x7CFD60", Length = "0xF28")]
	public void OnBattleEnd(bool fail = false)
	{
	}

	[Token(Token = "0x60044BF")]
	[Address(RVA = "0x7D05F0", Offset = "0x7CEDF0", Length = "0x1ED")]
	private void CheckAndAddRecentPlayData(string musicUid, int musicDifficulty, string characterUid, int skinIndex, int evaluate)
	{
	}

	[Token(Token = "0x60044C0")]
	[Address(RVA = "0x7D07E0", Offset = "0x7CEFE0", Length = "0x2D9")]
	private bool FilterSameRecentPlayData(string musicUid, int musicDifficulty, int evaluate)
	{
		return default(bool);
	}

	[Token(Token = "0x60044C1")]
	[Address(RVA = "0x7D0C00", Offset = "0x7CF400", Length = "0x348")]
	public void GetRecentBestPlayData(List<IData> temp, int count = 4)
	{
	}

	[Address(RVA = "0x7D0F50", Offset = "0x7CF750", Length = "0x609")]
	[Token(Token = "0x60044C2")]
	public void GetRecentMostUseCharaterUids(List<(string, int)> temp, int count = 3)
	{
	}

	[Address(RVA = "0x7D30A0", Offset = "0x7D18A0", Length = "0x37D")]
	[Token(Token = "0x60044C3")]
	private void UploadScore(SceneUploadResultData data)
	{
	}

	[Address(RVA = "0x7D2750", Offset = "0x7D0F50", Length = "0x37D")]
	[Token(Token = "0x60044C4")]
	public void OnChallengeAchievementEnd()
	{
	}

	[Token(Token = "0x60044C5")]
	[Address(RVA = "0x7D2DA0", Offset = "0x7D15A0", Length = "0x2FD")]
	public void OnTutorialEnd()
	{
	}

	[Token(Token = "0x60044C6")]
	[Address(RVA = "0x7D2C10", Offset = "0x7D1410", Length = "0xAD")]
	public void OnNomralTutorialCompleted()
	{
	}

	[Token(Token = "0x60044C7")]
	[Address(RVA = "0x7D2AD0", Offset = "0x7D12D0", Length = "0x130")]
	public void OnGetScore(int noteId, int configId, int judge, string noteType, int offset, int score, Side side, int combo, int addTime, int feverStart, int feverEnd, int feverValue)
	{
	}

	[Token(Token = "0x60044C8")]
	[Address(RVA = "0x7D2CC0", Offset = "0x7D14C0", Length = "0xDC")]
	public void OnNoteResult(int result)
	{
	}

	[Token(Token = "0x60044C9")]
	[Address(RVA = "0x7D0AC0", Offset = "0x7CF2C0", Length = "0x138")]
	public string GetControllerName()
	{
		return null;
	}

	[Token(Token = "0x60044CA")]
	[Address(RVA = "0x7D3420", Offset = "0x7D1C20", Length = "0xA2")]
	public StatisticsManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
