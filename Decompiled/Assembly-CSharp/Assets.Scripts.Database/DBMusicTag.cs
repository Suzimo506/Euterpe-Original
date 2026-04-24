using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.Scripts.Database.DataClass;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Database;

[Token(Token = "0x2000817")]
public class DBMusicTag : BaseDatabase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4002A31")]
	private List<string> m_CollectionList;

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002A32")]
	private List<string> m_HideList;

	[Token(Token = "0x4002A33")]
	[FieldOffset(Offset = "0x20")]
	private List<string> m_HistoryList;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002A34")]
	private int m_SelectedDiffTglIndex;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002A35")]
	private string m_FindKeyword;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002A36")]
	private int m_PrevRandomIndex;

	[Token(Token = "0x4002A37")]
	[FieldOffset(Offset = "0x40")]
	private MusicInfo m_CurRandomMusicInfo;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002A38")]
	private MusicInfo m_CurSelectedMusicInfo;

	[Token(Token = "0x4002A39")]
	[FieldOffset(Offset = "0x50")]
	private MusicInfo m_CurHideMusicInfo;

	[Token(Token = "0x4002A3A")]
	[FieldOffset(Offset = "0x58")]
	private List<int> m_AlbumTagsSort;

	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4002A3B")]
	private List<int> m_CustomAlbumTagsSort;

	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002A3C")]
	private readonly Dictionary<int, AlbumTagInfo> m_AllAlbumTagData;

	[Token(Token = "0x4002A3D")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<string, MusicInfo> m_AllMusicInfo;

	[Token(Token = "0x4002A3E")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<int, List<MusicInfo>> m_AllDiffInfo;

	[Token(Token = "0x4002A42")]
	[FieldOffset(Offset = "0x90")]
	private List<string> m_StageShowMusicUids;

	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4002A43")]
	private List<string> m_StageRandomMusicUids;

	[Token(Token = "0x4002A44")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_LockMusic;

	[Token(Token = "0x4002A45")]
	[FieldOffset(Offset = "0xA4")]
	private int m_SelectMusicTagItemIndex;

	[Token(Token = "0x4002A46")]
	[FieldOffset(Offset = "0xA8")]
	private Vector2Int m_DifficultyLevel;

	[Token(Token = "0x4002A47")]
	[FieldOffset(Offset = "0xB0")]
	private int m_CurSelectedTagIndex;

	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4002A48")]
	private int m_CurSelectedMusicIdx;

	[Token(Token = "0x17000786")]
	public List<string> Collection
	{
		[Token(Token = "0x6004966")]
		[Address(RVA = "0x46DBB0", Offset = "0x46C3B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000787")]
	public List<string> Hide
	{
		[Token(Token = "0x6004967")]
		[Address(RVA = "0x42CF40", Offset = "0x42B740", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000788")]
	public List<string> History
	{
		[Token(Token = "0x6004968")]
		[Address(RVA = "0x44B9F0", Offset = "0x44A1F0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000789")]
	public string musicFindKeyWord
	{
		[Token(Token = "0x6004969")]
		[Address(RVA = "0x45EEE0", Offset = "0x45D6E0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x600496A")]
		[Address(RVA = "0x45EF10", Offset = "0x45D710", Length = "0xC")]
		set
		{
		}
	}

	[Token(Token = "0x1700078A")]
	public int selectedDiffTglIndex
	{
		[Token(Token = "0x600496B")]
		[Address(RVA = "0x49EAA0", Offset = "0x49D2A0", Length = "0x4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600496C")]
		[Address(RVA = "0x102CE70", Offset = "0x102B670", Length = "0x89")]
		set
		{
		}
	}

	[Token(Token = "0x1700078B")]
	public int customTagsCount
	{
		[Address(RVA = "0x102CC60", Offset = "0x102B460", Length = "0x3B")]
		[Token(Token = "0x600496E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700078C")]
	public int hideCount
	{
		[Token(Token = "0x600497F")]
		[Address(RVA = "0x102CCA0", Offset = "0x102B4A0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700078D")]
	public int collectionCount
	{
		[Address(RVA = "0x102CA60", Offset = "0x102B260", Length = "0x3B")]
		[Token(Token = "0x6004984")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700078E")]
	public int historyCount
	{
		[Token(Token = "0x6004986")]
		[Address(RVA = "0x102CCE0", Offset = "0x102B4E0", Length = "0x3B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700078F")]
	public int allMusicCount
	{
		[Token(Token = "0x600498C")]
		[Address(RVA = "0x102CA10", Offset = "0x102B210", Length = "0x46")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000790")]
	public bool isLoaclTagInfo
	{
		[Address(RVA = "0x5B7310", Offset = "0x5B5B10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600498D")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x600498E")]
		[Address(RVA = "0xA61A80", Offset = "0xA60280", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000791")]
	public int planPackageCount
	{
		[CompilerGenerated]
		[Token(Token = "0x600498F")]
		[Address(RVA = "0x8997A0", Offset = "0x897FA0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0xBF01B0", Offset = "0xBEE9B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6004990")]
		set
		{
		}
	}

	[Token(Token = "0x17000792")]
	public bool newAlbumInited
	{
		[CompilerGenerated]
		[Token(Token = "0x6004991")]
		[Address(RVA = "0x44E3B0", Offset = "0x44CBB0", Length = "0x8")]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		[Token(Token = "0x6004992")]
		[Address(RVA = "0x44E420", Offset = "0x44CC20", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000793")]
	public int stageShowMusicCount
	{
		[Address(RVA = "0x102CD40", Offset = "0x102B540", Length = "0x3E")]
		[Token(Token = "0x6004994")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000794")]
	public List<string> stageShowMusicList
	{
		[Address(RVA = "0x46D010", Offset = "0x46B810", Length = "0x8")]
		[Token(Token = "0x6004995")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000795")]
	public int curSelectedMusicIdx
	{
		[Address(RVA = "0x4865D0", Offset = "0x484DD0", Length = "0x7")]
		[Token(Token = "0x60049A0")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x102CD80", Offset = "0x102B580", Length = "0xBC")]
		[Token(Token = "0x60049A1")]
		set
		{
		}
	}

	[Token(Token = "0x17000796")]
	public string pnlSelectMusicUid
	{
		[Address(RVA = "0x49A890", Offset = "0x499090", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60049A2")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60049A3")]
		[Address(RVA = "0x49A970", Offset = "0x499170", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x17000797")]
	public string pnlMusicTagSelectMusicUid
	{
		[CompilerGenerated]
		[Token(Token = "0x60049A4")]
		[Address(RVA = "0x49A8D0", Offset = "0x4990D0", Length = "0x8")]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[Token(Token = "0x60049A5")]
		[Address(RVA = "0x49A9B0", Offset = "0x4991B0", Length = "0xF")]
		set
		{
		}
	}

	[Token(Token = "0x17000798")]
	public int pnlMusicTagHeaderTreeIndex
	{
		[CompilerGenerated]
		[Token(Token = "0x60049A6")]
		[Address(RVA = "0x48D5E0", Offset = "0x48BDE0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Address(RVA = "0x102CE50", Offset = "0x102B650", Length = "0x7")]
		[Token(Token = "0x60049A7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000799")]
	public int selectedTagIndex
	{
		[Token(Token = "0x60049A8")]
		[Address(RVA = "0x4870C0", Offset = "0x4858C0", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60049A9")]
		[Address(RVA = "0x102CF00", Offset = "0x102B700", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700079A")]
	public int selectMusicTagItemIndex
	{
		[Token(Token = "0x60049AA")]
		[Address(RVA = "0x8A0E90", Offset = "0x89F690", Length = "0x7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60049AB")]
		[Address(RVA = "0x102CE60", Offset = "0x102B660", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x1700079B")]
	public Vector2Int difficultyLevel
	{
		[Token(Token = "0x60049AC")]
		[Address(RVA = "0x460250", Offset = "0x45EA50", Length = "0x8")]
		get
		{
			return default(Vector2Int);
		}
		[Address(RVA = "0xA61C40", Offset = "0xA60440", Length = "0x8")]
		[Token(Token = "0x60049AD")]
		set
		{
		}
	}

	[Token(Token = "0x1700079C")]
	public string curMusicName
	{
		[Address(RVA = "0x102CAA0", Offset = "0x102B2A0", Length = "0x1B1")]
		[Token(Token = "0x60049AE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700079D")]
	public bool isRandom
	{
		[Address(RVA = "0x102CD20", Offset = "0x102B520", Length = "0x9")]
		[Token(Token = "0x60049B1")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700079E")]
	public bool isUnknow
	{
		[CompilerGenerated]
		[Address(RVA = "0x102CD30", Offset = "0x102B530", Length = "0x8")]
		[Token(Token = "0x60049B2")]
		get
		{
			return default(bool);
		}
		[Address(RVA = "0x102CE40", Offset = "0x102B640", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60049B3")]
		set
		{
		}
	}

	[Token(Token = "0x6004965")]
	[Address(RVA = "0x102AC60", Offset = "0x1029460", Length = "0x7E8")]
	public void InitDatabase()
	{
	}

	[Address(RVA = "0x102C050", Offset = "0x102A850", Length = "0x372")]
	[Token(Token = "0x600496D")]
	public MusicInfo SelectRandomMusic()
	{
		return null;
	}

	[Token(Token = "0x600496F")]
	[Address(RVA = "0x1029080", Offset = "0x1027880", Length = "0x1FB")]
	private int CompareAlbumIndexByMusicUid(string x, string y)
	{
		return default(int);
	}

	[Token(Token = "0x6004970")]
	[Address(RVA = "0x1028880", Offset = "0x1027080", Length = "0x210")]
	private void AddHideMusicUid(string musicInfoUid)
	{
	}

	[Address(RVA = "0x102C620", Offset = "0x102AE20", Length = "0x80")]
	[Token(Token = "0x6004971")]
	public void SortHideList()
	{
	}

	[Address(RVA = "0x1028820", Offset = "0x1027020", Length = "0x50")]
	[Token(Token = "0x6004972")]
	public void AddCustomAlbumTagsSort(int tagIndex)
	{
	}

	[Token(Token = "0x6004973")]
	[Address(RVA = "0x1028C80", Offset = "0x1027480", Length = "0x78")]
	public bool AllAlbumTagsSortContains(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6004974")]
	[Address(RVA = "0x1029E10", Offset = "0x1028610", Length = "0x1ED")]
	public void GetAllTagsIndexSort(List<int> buffer)
	{
	}

	[Token(Token = "0x6004975")]
	[Address(RVA = "0x1029900", Offset = "0x1028100", Length = "0xCB")]
	public AlbumTagInfo GetAlbumTagInfo(int target)
	{
		return null;
	}

	[Address(RVA = "0x10285E0", Offset = "0x1026DE0", Length = "0x72")]
	[Token(Token = "0x6004976")]
	public void AddAlbumTagData(int index, AlbumTagInfo tag)
	{
	}

	[Address(RVA = "0x102A690", Offset = "0x1028E90", Length = "0x138")]
	[Token(Token = "0x6004977")]
	public void GetMusicInfosByUids(List<string> uids, List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0x1029CD0", Offset = "0x10284D0", Length = "0x13F")]
	[Token(Token = "0x6004978")]
	public void GetAllMusicInfo(List<MusicInfo> buffer)
	{
	}

	[Token(Token = "0x6004979")]
	[Address(RVA = "0x1028D00", Offset = "0x1027500", Length = "0x30D")]
	public void CleanTags(int cleanIndex)
	{
	}

	[Token(Token = "0x600497A")]
	[Address(RVA = "0x1028AA0", Offset = "0x10272A0", Length = "0x111")]
	public bool AddHide(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600497B")]
	[Address(RVA = "0x102BC80", Offset = "0x102A480", Length = "0xBB")]
	public bool RemoveHide(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600497C")]
	[Address(RVA = "0x102B610", Offset = "0x1029E10", Length = "0x91")]
	public bool IsMusicHide(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600497D")]
	[Address(RVA = "0x102B6B0", Offset = "0x1029EB0", Length = "0x90")]
	public bool IsMusicHide(string uid)
	{
		return default(bool);
	}

	[Token(Token = "0x600497E")]
	[Address(RVA = "0x102B450", Offset = "0x1029C50", Length = "0x132")]
	public bool IsAlbumAllMusicHide(DBConfigAlbums.AlbumsInfo albumsInfo)
	{
		return default(bool);
	}

	[Address(RVA = "0x1028690", Offset = "0x1026E90", Length = "0x184")]
	[Token(Token = "0x6004980")]
	public void AddCollection(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x6004981")]
	[Address(RVA = "0x102BB30", Offset = "0x102A330", Length = "0x14C")]
	public bool RemoveCollection(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6004982")]
	[Address(RVA = "0x1029280", Offset = "0x1027A80", Length = "0x91")]
	public bool ContainsCollection(MusicInfo musicInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6004983")]
	[Address(RVA = "0x102A000", Offset = "0x1028800", Length = "0x174")]
	public void GetCollection(List<string> listBuffer)
	{
	}

	[Address(RVA = "0x1028BC0", Offset = "0x10273C0", Length = "0xB8")]
	[Token(Token = "0x6004985")]
	public void AddHistory(string musicUid)
	{
	}

	[Address(RVA = "0x10299D0", Offset = "0x10281D0", Length = "0x89")]
	[Token(Token = "0x6004987")]
	public void GetAllDiffInfo(int diff, List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0x1029A60", Offset = "0x1028260", Length = "0x26D")]
	[Token(Token = "0x6004988")]
	public void GetAllDiffInfo(List<MusicInfo> buffer)
	{
	}

	[Address(RVA = "0x1028660", Offset = "0x1026E60", Length = "0x27")]
	[Token(Token = "0x6004989")]
	public void AddAllMusicInfo(DBConfigALBUM albumInfo)
	{
	}

	[Token(Token = "0x600498A")]
	[Address(RVA = "0x102A950", Offset = "0x1029150", Length = "0x30C")]
	public void InitAllDiffInfo()
	{
	}

	[Token(Token = "0x600498B")]
	[Address(RVA = "0x102A520", Offset = "0x1028D20", Length = "0xBD")]
	public MusicInfo GetMusicInfoFromAll(string musicUid)
	{
		return null;
	}

	[Token(Token = "0x6004993")]
	[Address(RVA = "0x102B760", Offset = "0x1029F60", Length = "0x3CE")]
	public void RefreshShowMusicUids(List<string> buffer, bool isRemoveWeekFreeAndHidedMusic = false)
	{
	}

	[Token(Token = "0x6004996")]
	[Address(RVA = "0x102BF30", Offset = "0x102A730", Length = "0x111")]
	public void ResetCurMusic()
	{
	}

	[Token(Token = "0x6004997")]
	[Address(RVA = "0x1029010", Offset = "0x1027810", Length = "0x70")]
	public void ClearHideMusicInfoAndReset()
	{
	}

	[Token(Token = "0x6004998")]
	[Address(RVA = "0x102A5E0", Offset = "0x1028DE0", Length = "0xA2")]
	public MusicInfo GetMusicInfoFromShowMusicUids(int index)
	{
		return null;
	}

	[Token(Token = "0x6004999")]
	[Address(RVA = "0x102A8F0", Offset = "0x10290F0", Length = "0x5D")]
	public string GetShowStageUidByIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x600499A")]
	[Address(RVA = "0x102A7D0", Offset = "0x1028FD0", Length = "0x55")]
	public int GetShowMusicIndex(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x600499B")]
	[Address(RVA = "0x102A830", Offset = "0x1029030", Length = "0xBB")]
	public int GetShowMusicLastIndex(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x600499C")]
	[Address(RVA = "0x102A2F0", Offset = "0x1028AF0", Length = "0x52")]
	public int GetHideMusicIndex(string uid)
	{
		return default(int);
	}

	[Token(Token = "0x600499D")]
	[Address(RVA = "0xA4D7B0", Offset = "0xA4BFB0", Length = "0x7")]
	public void SetLock(bool enable)
	{
	}

	[Address(RVA = "0x102C3D0", Offset = "0x102ABD0", Length = "0x242")]
	[Token(Token = "0x600499E")]
	public void SetSelectedMusic(MusicInfo selectMusicInfo, bool isRandom = false, bool isIgnoreLock = true)
	{
	}

	[Token(Token = "0x600499F")]
	[Address(RVA = "0x102BD40", Offset = "0x102A540", Length = "0x91")]
	public void RemoveShowMusicUid(MusicInfo musicInfo)
	{
	}

	[Address(RVA = "0x102A250", Offset = "0x1028A50", Length = "0x92")]
	[Token(Token = "0x60049AF")]
	public Vector2Int GetDifficultyLevel(out bool isRev)
	{
		System.Runtime.CompilerServices.Unsafe.As<bool, @null>(ref isRev) = null;
		return default(Vector2Int);
	}

	[Address(RVA = "0x1029320", Offset = "0x1027B20", Length = "0x17")]
	[Token(Token = "0x60049B0")]
	public MusicInfo CurMusicInfo()
	{
		return null;
	}

	[Token(Token = "0x60049B4")]
	[Address(RVA = "0x102A180", Offset = "0x1028980", Length = "0xCE")]
	public AlbumTagInfo GetCurSelectedTagInfo()
	{
		return null;
	}

	[Token(Token = "0x60049B5")]
	[Address(RVA = "0x102B750", Offset = "0x1029F50", Length = "0xA")]
	public bool IsSelected(int tagIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60049B6")]
	[Address(RVA = "0x102A350", Offset = "0x1028B50", Length = "0x1CA")]
	public List<string> GetHottestMusicUid()
	{
		return null;
	}

	[Token(Token = "0x60049B7")]
	[Address(RVA = "0x102B590", Offset = "0x1029D90", Length = "0x71")]
	public bool IsEmptyByTagIndex(int tagIndex = -1)
	{
		return default(bool);
	}

	[Address(RVA = "0x102BDE0", Offset = "0x102A5E0", Length = "0xC1")]
	[Token(Token = "0x60049B8")]
	public void ReplaceMusic(string uid, bool isHideMusic = false)
	{
	}

	[Token(Token = "0x60049B9")]
	[Address(RVA = "0x102BEB0", Offset = "0x102A6B0", Length = "0x7E")]
	public void ReplaceMusic(MusicInfo musicInfo)
	{
	}

	[Token(Token = "0x60049BA")]
	[Address(RVA = "0x1029340", Offset = "0x1027B40", Length = "0x5BE")]
	public override void Flush()
	{
	}

	[Token(Token = "0x60049BB")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void AwakeInit()
	{
	}

	[Token(Token = "0x60049BC")]
	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	public override void Release()
	{
	}

	[Token(Token = "0x60049BD")]
	[Address(RVA = "0x102C700", Offset = "0x102AF00", Length = "0x30A")]
	public DBMusicTag()
	{
	}
}
