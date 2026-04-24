using System;
using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.Structs.Modules;
using Assets.Scripts.UI.Panels.PnlRole;
using Cpp2ILInjected;
using PeroPeroGames.DataStatistics.Utils;
using UnityEngine;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004F2")]
public class ThinkingDataPeripheralHelper
{
	[Token(Token = "0x4001ABF")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, object> m_PlayerData;

	[Token(Token = "0x4001AC0")]
	[FieldOffset(Offset = "0x18")]
	private ThinkingDataTimeCount m_TimeCount;

	[Token(Token = "0x4001AC1")]
	[FieldOffset(Offset = "0x20")]
	private List<Dictionary<string, object>> m_SearchInfoList;

	[Token(Token = "0x4001AC2")]
	private const string music_name = "\ufffd";

	[Token(Token = "0x4001AC3")]
	private const string music_author = "\ufffd";

	[Token(Token = "0x4001AC4")]
	private const string music_level_designer = "关\ufffd";

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001AC5")]
	private Dictionary<string, DateTime> m_ThinkingTimeEvents;

	[Token(Token = "0x4001AC6")]
	[FieldOffset(Offset = "0x30")]
	private string m_CurrentTemp;

	[Token(Token = "0x60036D7")]
	[Address(RVA = "0x87B000", Offset = "0x879800", Length = "0x48")]
	public void Initiaztion()
	{
	}

	[Address(RVA = "0x87CD40", Offset = "0x87B540", Length = "0x8C")]
	[Token(Token = "0x60036D8")]
	public void StartReCordTime(string thinkingEventName)
	{
	}

	[Address(RVA = "0x87CE20", Offset = "0x87B620", Length = "0x7D")]
	[Token(Token = "0x60036D9")]
	public void StopRecordTime(string thinkingEventName)
	{
	}

	[Token(Token = "0x60036DA")]
	[Address(RVA = "0x87AF00", Offset = "0x879700", Length = "0xFF")]
	public double GetThinkingEventTime(string thinkingEventName)
	{
		return default(double);
	}

	[Token(Token = "0x60036DB")]
	[Address(RVA = "0x87C5E0", Offset = "0x87ADE0", Length = "0x215")]
	public void PostToThinkingData(string dataStatisticsEventDefinesName, MusicInfo musicInfo, string source = null)
	{
	}

	[Token(Token = "0x60036DC")]
	[Address(RVA = "0x87C800", Offset = "0x87B000", Length = "0x1A1")]
	private void SendFavoriteMusicBehavior(string dataStatisticsEventDefinesNameMusicInfo, MusicInfo musicInfo, string source)
	{
	}

	[Token(Token = "0x60036DD")]
	[Address(RVA = "0x87BE10", Offset = "0x87A610", Length = "0x1CC")]
	public void PostSelectMusicPanelInfo(DateTime playerInTime, string inModuleMessage, string outModuleMessage)
	{
	}

	[Token(Token = "0x60036DE")]
	[Address(RVA = "0x87B300", Offset = "0x879B00", Length = "0x1A8")]
	public void PostDifficultFilterInfo(int minDiffValue, int maxDIffValue, double duration)
	{
	}

	[Token(Token = "0x60036DF")]
	[Address(RVA = "0x87B7F0", Offset = "0x879FF0", Length = "0x2B3")]
	public void PostMusicSearchInfo(string searchText, MusicInfoResult musicInfos, MusicInfoResult authorInfos, MusicInfoResult levelDesignerInfos)
	{
	}

	[Token(Token = "0x60036E0")]
	[Address(RVA = "0x87AD90", Offset = "0x879590", Length = "0x16D")]
	private Dictionary<string, object> GetSearchResultInfo(MusicInfo musicInfo, string searchType)
	{
		return null;
	}

	[Token(Token = "0x60036E1")]
	[Address(RVA = "0x87B4B0", Offset = "0x879CB0", Length = "0x33D")]
	public void PostMusicChooseInfo(Vector2Int diffValue, string chooseMusicType, string searchName, double duration, MusicInfo musicInfo)
	{
	}

	[Address(RVA = "0x87BFE0", Offset = "0x87A7E0", Length = "0x2FA")]
	[Token(Token = "0x60036E2")]
	public void PostSkinPreviewInfo(PnlRoleSkinContainer pnlRoleSkinContainer, int characterInfoIndex)
	{
	}

	[Token(Token = "0x60036E3")]
	[Address(RVA = "0x87C2E0", Offset = "0x87AAE0", Length = "0x2FA")]
	public void PostSkinWearInfo(PnlRoleSkinContainer pnlRoleSkinContainer, int characterInfoIndex)
	{
	}

	[Token(Token = "0x60036E4")]
	[Address(RVA = "0x87BAB0", Offset = "0x87A2B0", Length = "0x179")]
	public void PostSelectBgPreView(string themeBgId, string themeBgName)
	{
	}

	[Token(Token = "0x60036E5")]
	[Address(RVA = "0x87BC30", Offset = "0x87A430", Length = "0x1DA")]
	public void PostSelectBgWear(string themeBgId, string themeBgName, bool isUnlock, bool canTry)
	{
	}

	[Token(Token = "0x60036E6")]
	[Address(RVA = "0x87C9B0", Offset = "0x87B1B0", Length = "0x2B6")]
	public void SendWaysToShop()
	{
	}

	[Token(Token = "0x60036E7")]
	[Address(RVA = "0x87CC70", Offset = "0x87B470", Length = "0xCB")]
	public void SendWaysToShop(string str)
	{
	}

	[Address(RVA = "0x87AC70", Offset = "0x879470", Length = "0x117")]
	[Token(Token = "0x60036E8")]
	public void CommonSendString(string eventName, string propertyName, string info)
	{
	}

	[Token(Token = "0x60036E9")]
	[Address(RVA = "0x87CF40", Offset = "0x87B740", Length = "0x248")]
	public void abilityAdvancedToPost(int oldAbility, int reachAbility, DateTime changeTime, DateTime previousChangeTime)
	{
	}

	[Address(RVA = "0x87AB80", Offset = "0x879380", Length = "0xE6")]
	[Token(Token = "0x60036EA")]
	public void CheckShopTag(string temp)
	{
	}

	[Address(RVA = "0x87B230", Offset = "0x879A30", Length = "0xCC")]
	[Token(Token = "0x60036EB")]
	public void NeedToCountSend(string eventName, string propertyName, string temp)
	{
	}

	[Address(RVA = "0x87B050", Offset = "0x879850", Length = "0x1D7")]
	[Token(Token = "0x60036EC")]
	public void LocalAchievementInfo(string languageJSON, string type, string uid)
	{
	}

	[Token(Token = "0x60036ED")]
	[Address(RVA = "0x87CDD0", Offset = "0x87B5D0", Length = "0x4F")]
	public void StopCount()
	{
	}

	[Address(RVA = "0x87CEA0", Offset = "0x87B6A0", Length = "0x96")]
	[Token(Token = "0x60036EE")]
	public ThinkingDataPeripheralHelper()
	{
	}
}
