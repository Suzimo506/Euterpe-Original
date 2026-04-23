using System.Collections.Generic;
using Assets.Scripts.Database;
using Assets.Scripts.PeroTools.Commons;
using Cpp2ILInjected;

[Token(Token = "0x2000055")]
public class MusicTagManager : Singleton<MusicTagManager>
{
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x10")]
	private DBMusicTag m_DbMusicTag;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40001F5")]
	private bool m_InitFlag;

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x8CA4C0", Offset = "0x8C8CC0", Length = "0x1DB")]
	public bool RefreshStageDisplayMusics(int tagIndex = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x8C8A50", Offset = "0x8C7250", Length = "0xFA")]
	public void EnterBattleInit()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x8C8470", Offset = "0x8C6C70", Length = "0x175")]
	private void AllTagSort()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x8C86B0", Offset = "0x8C6EB0", Length = "0x391")]
	private void CustomTagPaser()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x8CA0B0", Offset = "0x8C88B0", Length = "0x32")]
	private void OnWeekFreeRefreshed()
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x8CA0F0", Offset = "0x8C88F0", Length = "0x19C")]
	private void RefreshAllTagWeekfreeState()
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x8C85F0", Offset = "0x8C6DF0", Length = "0xBA")]
	private void CleanInvalidUid(List<string> buffer)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x8CA340", Offset = "0x8C8B40", Length = "0x17B")]
	public bool RefreshStageDisplayMusics(List<string> musicUids, bool doNotFilterHideMusic = false)
	{
		return default(bool);
	}

	[Address(RVA = "0x8C8350", Offset = "0x8C6B50", Length = "0x119")]
	[Token(Token = "0x6000267")]
	private void AddRandomButton(ref List<string> sourceMusicList)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x8CAF30", Offset = "0x8C9730", Length = "0x354")]
	private void SetLastSelectMusicIndex()
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x8CA2F0", Offset = "0x8C8AF0", Length = "0x49")]
	public bool RefreshStageDisplayMusics(List<string> uids, int tagIndex, bool doNotFilterHideMusic = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x8C9710", Offset = "0x8C7F10", Length = "0x227")]
	public void InitDatas()
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x8CA060", Offset = "0x8C8860", Length = "0x48")]
	private void OnLogout()
	{
	}

	[Address(RVA = "0x8C9FD0", Offset = "0x8C87D0", Length = "0x86")]
	[Token(Token = "0x600026C")]
	private void OnGotUserInfo()
	{
	}

	[Address(RVA = "0x8CA290", Offset = "0x8C8A90", Length = "0x51")]
	[Token(Token = "0x600026D")]
	public void RefreshDBDisplayMusics()
	{
	}

	[Address(RVA = "0x8CB290", Offset = "0x8C9A90", Length = "0xF3")]
	[Token(Token = "0x600026E")]
	public void StageRefreshDBDisplayMusics()
	{
	}

	[Address(RVA = "0x8C9030", Offset = "0x8C7830", Length = "0x1C2")]
	[Token(Token = "0x600026F")]
	private void InitAllMusicInfo()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x8C8B50", Offset = "0x8C7350", Length = "0x4A4")]
	private void InitAlbumTagInfo()
	{
	}

	[Address(RVA = "0x8C9200", Offset = "0x8C7A00", Length = "0x500")]
	[Token(Token = "0x6000271")]
	private void InitBaseMusicTagsData()
	{
	}

	[Address(RVA = "0x8C9BC0", Offset = "0x8C83C0", Length = "0x254")]
	[Token(Token = "0x6000272")]
	private void InitNewAlbum()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x8C9E20", Offset = "0x8C8620", Length = "0x1AC")]
	private void InitTagState()
	{
	}

	[Address(RVA = "0x8C9940", Offset = "0x8C8140", Length = "0x277")]
	[Token(Token = "0x6000274")]
	private void InitDefaultInfo()
	{
	}

	[Address(RVA = "0x8CA6A0", Offset = "0x8C8EA0", Length = "0x4D1")]
	[Token(Token = "0x6000275")]
	private bool RefreshStageMusicInfoByDiffAndCondition()
	{
		return default(bool);
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x8CAB80", Offset = "0x8C9380", Length = "0x294")]
	private bool RefreshStageMusicInfoByDiff()
	{
		return default(bool);
	}

	[Address(RVA = "0x8CAE20", Offset = "0x8C9620", Length = "0x105")]
	[Token(Token = "0x6000277")]
	private bool RefreshStageMusicInfoBySearch()
	{
		return default(bool);
	}

	[Address(RVA = "0x8CB390", Offset = "0x8C9B90", Length = "0xBA")]
	[Token(Token = "0x6000278")]
	public MusicTagManager()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
