using System.Collections.Generic;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq;

namespace Assets.Scripts.GameCore.Managers;

[Token(Token = "0x2000754")]
public class TempRankDataManager : Singleton<TempRankDataManager>
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40026C2")]
	private bool m_IsCurMusicBestRanKInfoNew;

	[Token(Token = "0x40026C3")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, JToken> m_SelfBestRankInfos;

	[Token(Token = "0x40026C4")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, RankReportData> m_SelfRankReportDatas;

	[Token(Token = "0x17000678")]
	public bool isCurMusicBestRanKInfoNew
	{
		[Address(RVA = "0x45CA50", Offset = "0x45B250", Length = "0x5")]
		[Token(Token = "0x60044EA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60044EB")]
	[Address(RVA = "0x7D83F0", Offset = "0x7D6BF0", Length = "0x29D")]
	public void AddRankReportData(string musicUid, int selectDiff, int score, float accuracy, int combo, string evaluate, int order = -2)
	{
	}

	[Token(Token = "0x60044EC")]
	[Address(RVA = "0x7D8290", Offset = "0x7D6A90", Length = "0x15E")]
	public void AddRankReportDataOrder(string musicUid, int difficulty, int order)
	{
	}

	[Token(Token = "0x60044ED")]
	[Address(RVA = "0x7D8C10", Offset = "0x7D7410", Length = "0x7D")]
	public void RemoveCurRankReportData(string uid)
	{
	}

	[Address(RVA = "0x7D89E0", Offset = "0x7D71E0", Length = "0x226")]
	[Token(Token = "0x60044EE")]
	public RankReportData GetCurMusicRankInfo()
	{
		return null;
	}

	[Token(Token = "0x60044EF")]
	[Address(RVA = "0x7D8C90", Offset = "0x7D7490", Length = "0x67")]
	public void SetCurMusicBestRankInfoData(string uid, JToken newRankData)
	{
	}

	[Token(Token = "0x60044F0")]
	[Address(RVA = "0x634900", Offset = "0x633100", Length = "0x5")]
	public void SetCurMusicBestRankInfoOld()
	{
	}

	[Token(Token = "0x60044F1")]
	[Address(RVA = "0x7D8690", Offset = "0x7D6E90", Length = "0x34D")]
	public int GetCurMusicBestRankOrder()
	{
		return default(int);
	}

	[Token(Token = "0x60044F2")]
	[Address(RVA = "0x7D8D00", Offset = "0x7D7500", Length = "0x9B")]
	public TempRankDataManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
