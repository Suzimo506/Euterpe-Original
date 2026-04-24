//Type is in global namespace

public class LocalizationName : Singleton<LocalizationName>
{
	private Dictionary<Int32, String> m_AlbumCollectionsNames; //Field offset: 0x10
	private Dictionary<Int32, String> m_AlbumAllNames; //Field offset: 0x18
	private Dictionary<Int32, String> m_AlbumDefaultNames; //Field offset: 0x20
	private Dictionary<Int32, String> m_AlbumGiveUpNames; //Field offset: 0x28
	private Dictionary<Int32, String> m_AlbumHappyNames; //Field offset: 0x30
	private Dictionary<Int32, String> m_AlbumCuteNames; //Field offset: 0x38
	private Dictionary<Int32, String> m_AlbumThemeNames; //Field offset: 0x40
	private Dictionary<Int32, String> m_AlbumCollabNames; //Field offset: 0x48
	private Dictionary<Int32, String> m_AlbumHideNames; //Field offset: 0x50
	private Dictionary<Int32, String> m_AlbumNewName; //Field offset: 0x58
	private Dictionary<Int32, String> m_AlbumHistoryNames; //Field offset: 0x60
	private Dictionary<Int32, String> m_AlbumHideMapNames; //Field offset: 0x68
	private Dictionary<Int32, String> m_AlbumPlanNames; //Field offset: 0x70
	private Dictionary<Int32, String> m_RandomNames; //Field offset: 0x78
	private Dictionary<Int32, String> m_DifficultyScreenNames; //Field offset: 0x80
	private Dictionary<Int32, String> m_DifficultyNames; //Field offset: 0x88
	private Dictionary<Int32, String> m_WeekFreeNames; //Field offset: 0x90
	private Dictionary<Int32, String> m_MusicTagNoMusic; //Field offset: 0x98
	private Dictionary<Int32, String> m_MusicTagNoMusicByAnchor; //Field offset: 0xA0
	private Dictionary<Int32, String> m_SearchTitle; //Field offset: 0xA8
	private Dictionary<Int32, String> m_SearchArtist; //Field offset: 0xB0
	private Dictionary<Int32, String> m_SearchDesign; //Field offset: 0xB8
	private StringBuilder sb; //Field offset: 0xC0

	public string diffFilterTxtForStageOwn
	{
		 get { } //Length: 620
	}

	public string diffTxt
	{
		 get { } //Length: 249
	}

	public string weekFreeTxt
	{
		 get { } //Length: 249
	}

	public LocalizationName() { }

	public string get_diffFilterTxtForStageOwn() { }

	public string get_diffTxt() { }

	public string get_weekFreeTxt() { }

	public string GetBaseAlbumLock(int unlockLevel) { }

	public string GetMusicTagNoMusicTxt(bool isAnchor) { }

	public string GetRandomNameLocalization() { }

	public string GetSearchNameTxt(SearchType searchType) { }

	public string GetTagLocalization(int tagIndex, string tagUid) { }

}

