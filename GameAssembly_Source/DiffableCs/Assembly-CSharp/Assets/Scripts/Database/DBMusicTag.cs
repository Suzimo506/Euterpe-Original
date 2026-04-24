namespace Assets.Scripts.Database;

public class DBMusicTag : BaseDatabase
{
	private List<String> m_CollectionList; //Field offset: 0x10
	private List<String> m_HideList; //Field offset: 0x18
	private List<String> m_HistoryList; //Field offset: 0x20
	private int m_SelectedDiffTglIndex; //Field offset: 0x28
	private string m_FindKeyword; //Field offset: 0x30
	private int m_PrevRandomIndex; //Field offset: 0x38
	private MusicInfo m_CurRandomMusicInfo; //Field offset: 0x40
	private MusicInfo m_CurSelectedMusicInfo; //Field offset: 0x48
	private List<Int32> m_AlbumTagsSort; //Field offset: 0x50
	private List<Int32> m_CustomAlbumTagsSort; //Field offset: 0x58
	private readonly Dictionary<Int32, AlbumTagInfo> m_AllAlbumTagData; //Field offset: 0x60
	private Dictionary<String, MusicInfo> m_AllMusicInfo; //Field offset: 0x68
	private Dictionary<Int32, List`1<MusicInfo>> m_AllDiffInfo; //Field offset: 0x70
	[CompilerGenerated]
	private bool <isLoaclTagInfo>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <planPackageCount>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <newAlbumInited>k__BackingField; //Field offset: 0x80
	private List<String> m_StageShowMusicUids; //Field offset: 0x88
	private List<String> m_StageRandomMusicUids; //Field offset: 0x90
	private bool m_LockMusic; //Field offset: 0x98
	private int m_SelectMusicTagItemIndex; //Field offset: 0x9C
	private Vector2Int m_DifficultyLevel; //Field offset: 0xA0
	private int m_CurSelectedTagIndex; //Field offset: 0xA8
	private int m_CurSelectedMusicIdx; //Field offset: 0xAC
	[CompilerGenerated]
	private string <pnlSelectMusicUid>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private string <pnlMusicTagSelectMusicUid>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <isUnknow>k__BackingField; //Field offset: 0xC0

	public int allMusicCount
	{
		 get { } //Length: 70
	}

	public List<String> Collection
	{
		 get { } //Length: 5
	}

	public int collectionCount
	{
		 get { } //Length: 59
	}

	public int curSelectedMusicIdx
	{
		 get { } //Length: 7
		 set { } //Length: 188
	}

	public int customTagsCount
	{
		 get { } //Length: 59
	}

	public Vector2Int difficultyLevel
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public List<String> Hide
	{
		 get { } //Length: 5
	}

	public int hideCount
	{
		 get { } //Length: 59
	}

	public List<String> History
	{
		 get { } //Length: 5
	}

	public int historyCount
	{
		 get { } //Length: 59
	}

	public bool isLoaclTagInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool isRandom
	{
		 get { } //Length: 9
	}

	public bool isUnknow
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string musicFindKeyWord
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public bool newAlbumInited
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int planPackageCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string pnlMusicTagSelectMusicUid
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public string pnlSelectMusicUid
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public int selectedDiffTglIndex
	{
		 get { } //Length: 4
		 set { } //Length: 137
	}

	public int selectedTagIndex
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int selectMusicTagItemIndex
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int stageShowMusicCount
	{
		 get { } //Length: 62
	}

	public DBMusicTag() { }

	public void AddAlbumTagData(int index, AlbumTagInfo tag) { }

	public void AddAllMusicInfo(DBConfigALBUM albumInfo) { }

	public void AddCollection(MusicInfo musicInfo) { }

	public void AddCustomAlbumTagsSort(int tagIndex) { }

	public bool AddHide(MusicInfo musicInfo) { }

	public void AddHistory(string musicUid) { }

	public bool AllAlbumTagsSortContains(int index) { }

	public virtual void AwakeInit() { }

	public void CleanTags(int cleanIndex) { }

	public bool ContainsCollection(MusicInfo musicInfo) { }

	public bool ContainsHide(MusicInfo musicInfo) { }

	public MusicInfo CurMusicInfo() { }

	public virtual void Flush() { }

	public int get_allMusicCount() { }

	public List<String> get_Collection() { }

	public int get_collectionCount() { }

	public int get_curSelectedMusicIdx() { }

	public int get_customTagsCount() { }

	public Vector2Int get_difficultyLevel() { }

	public List<String> get_Hide() { }

	public int get_hideCount() { }

	public List<String> get_History() { }

	public int get_historyCount() { }

	[CompilerGenerated]
	public bool get_isLoaclTagInfo() { }

	public bool get_isRandom() { }

	[CompilerGenerated]
	public bool get_isUnknow() { }

	public string get_musicFindKeyWord() { }

	[CompilerGenerated]
	public bool get_newAlbumInited() { }

	[CompilerGenerated]
	public int get_planPackageCount() { }

	[CompilerGenerated]
	public string get_pnlMusicTagSelectMusicUid() { }

	[CompilerGenerated]
	public string get_pnlSelectMusicUid() { }

	public int get_selectedDiffTglIndex() { }

	public int get_selectedTagIndex() { }

	public int get_selectMusicTagItemIndex() { }

	public int get_stageShowMusicCount() { }

	public AlbumTagInfo GetAlbumTagInfo(int target) { }

	public void GetAllDiffInfo(List<MusicInfo> buffer) { }

	public void GetAllDiffInfo(int diff, List<MusicInfo> buffer) { }

	public void GetAllMusicInfo(List<MusicInfo> buffer) { }

	public void GetAllTagsIndexSort(List<Int32> buffer) { }

	public void GetCollection(List<String> listBuffer) { }

	public AlbumTagInfo GetCurSelectedTagInfo() { }

	public Vector2Int GetDifficultyLevel(out bool isRev) { }

	public List<String> GetHottestMusicUid() { }

	public MusicInfo GetMusicInfoFromAll(string musicUid) { }

	public MusicInfo GetMusicInfoFromShowMusicUids(int index) { }

	public void GetMusicInfosByUids(List<String> uids, List<MusicInfo> buffer) { }

	public int GetShowMusicIndex(string uid) { }

	public string GetShowStageUidByIndex(int index) { }

	public void InitAllDiffInfo() { }

	public void InitDatabase() { }

	public bool IsEmptyByTagIndex(int tagIndex = -1) { }

	public bool IsSelected(int tagIndex) { }

	public void RefreshShowMusicUids(List<String> buffer) { }

	public virtual void Release() { }

	public bool RemoveCollection(MusicInfo musicInfo) { }

	public bool RemoveHide(MusicInfo musicInfo) { }

	public void RemoveShowMusicUid(MusicInfo musicInfo) { }

	public void ReplaceMusic(MusicInfo musicInfo) { }

	public void ReplaceMusic(string uid) { }

	public void ResetCurMusic() { }

	public MusicInfo SelectRandomMusic() { }

	public void set_curSelectedMusicIdx(int value) { }

	public void set_difficultyLevel(Vector2Int value) { }

	[CompilerGenerated]
	public void set_isLoaclTagInfo(bool value) { }

	[CompilerGenerated]
	public void set_isUnknow(bool value) { }

	public void set_musicFindKeyWord(string value) { }

	[CompilerGenerated]
	public void set_newAlbumInited(bool value) { }

	[CompilerGenerated]
	public void set_planPackageCount(int value) { }

	[CompilerGenerated]
	public void set_pnlMusicTagSelectMusicUid(string value) { }

	[CompilerGenerated]
	public void set_pnlSelectMusicUid(string value) { }

	public void set_selectedDiffTglIndex(int value) { }

	public void set_selectedTagIndex(int value) { }

	public void set_selectMusicTagItemIndex(int value) { }

	public void SetLock(bool enable) { }

	public void SetSelectedMusic(MusicInfo selectMusicInfo, bool isRandom = false) { }

}

