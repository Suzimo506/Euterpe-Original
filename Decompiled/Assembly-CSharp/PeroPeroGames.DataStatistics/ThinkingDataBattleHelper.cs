using System.Collections.Generic;
using Assets.Scripts.Database;
using Cpp2ILInjected;
using PeroPeroGames.DataStatistics.Utils;

namespace PeroPeroGames.DataStatistics;

[Token(Token = "0x20004EF")]
public class ThinkingDataBattleHelper : IDataPush
{
	[Token(Token = "0x4001AB5")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, object> m_PlayerData;

	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x18")]
	private List<string> m_PlayerNoteData;

	[Token(Token = "0x60036BD")]
	[Address(RVA = "0x43FC10", Offset = "0x43E410", Length = "0x15")]
	private bool isNetWorkConneted()
	{
		return default(bool);
	}

	[Address(RVA = "0x878C30", Offset = "0x877430", Length = "0xFA")]
	[Token(Token = "0x60036BE")]
	private string GetChineseDifficulty(int diff = -1)
	{
		return null;
	}

	[Token(Token = "0x60036BF")]
	[Address(RVA = "0x8796B0", Offset = "0x877EB0", Length = "0xEF")]
	private string PlayerGameTime()
	{
		return null;
	}

	[Address(RVA = "0x879FE0", Offset = "0x8787E0", Length = "0x8")]
	[Token(Token = "0x60036C0")]
	public void SendMDAbandonEvent(string reason)
	{
	}

	[Address(RVA = "0x87A000", Offset = "0x878800", Length = "0x86")]
	[Token(Token = "0x60036C1")]
	public void SendMDPlayEvent(string endtype)
	{
	}

	[Address(RVA = "0x879FF0", Offset = "0x8787F0", Length = "0x7")]
	[Token(Token = "0x60036C2")]
	public void SendMDFailureEvent()
	{
	}

	[Address(RVA = "0x879A00", Offset = "0x878200", Length = "0x26C")]
	[Token(Token = "0x60036C3")]
	private void RefreshPlayerAbandonProperty(string abandonReason)
	{
	}

	[Token(Token = "0x60036C4")]
	[Address(RVA = "0x8797A0", Offset = "0x877FA0", Length = "0x189")]
	public void PostNewPlayerTutorialInfo(string finishedType)
	{
	}

	[Token(Token = "0x60036C5")]
	[Address(RVA = "0x878B60", Offset = "0x877360", Length = "0xC2")]
	private void GetBattleAccuracyAndCombo()
	{
	}

	[Address(RVA = "0x878D30", Offset = "0x877530", Length = "0x977")]
	[Token(Token = "0x60036C6")]
	private void PlayerEvent(string endtype = null)
	{
	}

	[Address(RVA = "0x87A090", Offset = "0x878890", Length = "0x67")]
	[Token(Token = "0x60036C7")]
	public void playerSourceStr(string source)
	{
	}

	[Address(RVA = "0x879C70", Offset = "0x878470", Length = "0x36B")]
	[Token(Token = "0x60036C8")]
	private void RefreshPlayerFailure()
	{
	}

	[Token(Token = "0x60036C9")]
	[Address(RVA = "0x8786F0", Offset = "0x876EF0", Length = "0x462")]
	private void CommonPlayerProperty(MusicInfo musicInfo, DBConfigAlbums.AlbumsInfo albumInfo)
	{
	}

	[Token(Token = "0x60036CA")]
	[Address(RVA = "0x878340", Offset = "0x876B40", Length = "0x3AF")]
	public void CheckNoteHit(int result, int judgeState)
	{
	}

	[Token(Token = "0x60036CB")]
	[Address(RVA = "0x878260", Offset = "0x876A60", Length = "0xD7")]
	private void AddPlayerSkinProperty(LocalCharacterInfo battleRoleInfo, LocalElfinInfo battleElfinInfo)
	{
	}

	[Token(Token = "0x60036CC")]
	[Address(RVA = "0x8799A0", Offset = "0x8781A0", Length = "0x59")]
	public void PushDataByTrack(string dataStatisticsName)
	{
	}

	[Address(RVA = "0x879930", Offset = "0x878130", Length = "0x68")]
	[Token(Token = "0x60036CD")]
	public void PushDataByTrack(string dataStatisticsName, Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x60036CE")]
	[Address(RVA = "0x37E430", Offset = "0x37CC30", Length = "0x7")]
	public ThinkingDataBattleHelper()
	{
	}
}
