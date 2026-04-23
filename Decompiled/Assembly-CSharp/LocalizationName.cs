using System.Collections.Generic;
using System.Text;
using Assets.Scripts.PeroTools.Commons;
using Assets.Scripts.UI.Panels.PnlMusicTag;
using Cpp2ILInjected;

[Token(Token = "0x2000157")]
public class LocalizationName : Singleton<LocalizationName>
{
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, string> m_AlbumCollectionsNames;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000863")]
	private Dictionary<int, string> m_AlbumAllNames;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000864")]
	private Dictionary<int, string> m_AlbumDefaultNames;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000865")]
	private Dictionary<int, string> m_AlbumGiveUpNames;

	[Token(Token = "0x4000866")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<int, string> m_AlbumHappyNames;

	[Token(Token = "0x4000867")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<int, string> m_AlbumCuteNames;

	[Token(Token = "0x4000868")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, string> m_AlbumThemeNames;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000869")]
	private Dictionary<int, string> m_AlbumCollabNames;

	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400086A")]
	private Dictionary<int, string> m_AlbumHideNames;

	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400086B")]
	private Dictionary<int, string> m_AlbumNewName;

	[Token(Token = "0x400086C")]
	[FieldOffset(Offset = "0x60")]
	private Dictionary<int, string> m_AlbumHistoryNames;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400086D")]
	private Dictionary<int, string> m_AlbumHideMapNames;

	[Token(Token = "0x400086E")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, string> m_AlbumPlanNames;

	[Token(Token = "0x400086F")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, string> m_RandomNames;

	[Token(Token = "0x4000870")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<int, string> m_DifficultyScreenNames;

	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000871")]
	private Dictionary<int, string> m_DifficultyNames;

	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000872")]
	private Dictionary<int, string> m_WeekFreeNames;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000873")]
	private Dictionary<int, string> m_MusicTagNoMusic;

	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000874")]
	private Dictionary<int, string> m_MusicTagNoMusicByAnchor;

	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000875")]
	private Dictionary<int, string> m_PleaseEnterSearchText;

	[Token(Token = "0x4000876")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, string> m_SearchTitle;

	[Token(Token = "0x4000877")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<int, string> m_SearchArtist;

	[Token(Token = "0x4000878")]
	[FieldOffset(Offset = "0xC0")]
	private Dictionary<int, string> m_SearchDesign;

	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000879")]
	private StringBuilder sb;

	[Token(Token = "0x170000CC")]
	public string diffFilterTxtForStageOwn
	{
		[Address(RVA = "0x8BC450", Offset = "0x8BAC50", Length = "0x26C")]
		[Token(Token = "0x60009CD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CD")]
	public string weekFreeTxt
	{
		[Address(RVA = "0x8BC7C0", Offset = "0x8BAFC0", Length = "0xF9")]
		[Token(Token = "0x60009CF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CE")]
	public string diffTxt
	{
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x8BC6C0", Offset = "0x8BAEC0", Length = "0xF9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60009CB")]
	[Address(RVA = "0x8BA880", Offset = "0x8B9080", Length = "0x1C0")]
	public string GetBaseAlbumLock(int unlockLevel)
	{
		return null;
	}

	[Address(RVA = "0x8BAF50", Offset = "0x8B9750", Length = "0xE4")]
	[Token(Token = "0x60009CC")]
	public string GetTagLocalization(int tagIndex, string tagUid)
	{
		return null;
	}

	[Address(RVA = "0x8BAA50", Offset = "0x8B9250", Length = "0x96")]
	[Token(Token = "0x60009CE")]
	public string GetDefaultUnlockSongText(int curLanguage)
	{
		return null;
	}

	[Address(RVA = "0x8BAD40", Offset = "0x8B9540", Length = "0xF6")]
	[Token(Token = "0x60009D0")]
	public string GetRandomNameLocalization()
	{
		return null;
	}

	[Token(Token = "0x60009D2")]
	[Address(RVA = "0x8BAAF0", Offset = "0x8B92F0", Length = "0x149")]
	public string GetMusicTagNoMusicTxt(bool isAnchor)
	{
		return null;
	}

	[Token(Token = "0x60009D3")]
	[Address(RVA = "0x8BAC40", Offset = "0x8B9440", Length = "0xF9")]
	public string GetPleaseEnterSearchText()
	{
		return null;
	}

	[Token(Token = "0x60009D4")]
	[Address(RVA = "0x8BAE40", Offset = "0x8B9640", Length = "0x10C")]
	public string GetSearchNameTxt(SearchType searchType)
	{
		return null;
	}

	[Address(RVA = "0x8BA770", Offset = "0x8B8F70", Length = "0x10D")]
	[Token(Token = "0x60009D5")]
	public string GetAlbumNameTxt(int albumId)
	{
		return null;
	}

	[Address(RVA = "0x8BB2C0", Offset = "0x8B9AC0", Length = "0x1187")]
	[Token(Token = "0x60009D6")]
	public LocalizationName()
	{
		((Singleton<>)(object)this)._002Ector();
	}
}
