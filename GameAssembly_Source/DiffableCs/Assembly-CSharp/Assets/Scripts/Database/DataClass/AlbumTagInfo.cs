namespace Assets.Scripts.Database.DataClass;

public class AlbumTagInfo
{
	private int m_TagIndex; //Field offset: 0x10
	public string tagUid; //Field offset: 0x18
	public string name; //Field offset: 0x20
	private List<String> m_MusicUids; //Field offset: 0x28
	private List<AlbumDisplayMusic> m_DisplayMusicUids; //Field offset: 0x30
	private List<AlbumsInfo> m_AlbumsInfos; //Field offset: 0x38
	public bool isWeekFree; //Field offset: 0x40
	public bool isNew; //Field offset: 0x41
	public bool isDisplayTitle; //Field offset: 0x42
	public CustomTagInfo customInfo; //Field offset: 0x48
	public string iconName; //Field offset: 0x50
	public Texture2D icon; //Field offset: 0x58

	public List<AlbumsInfo> albumsInfos
	{
		 get { } //Length: 5
	}

	public bool isCustomTag
	{
		 get { } //Length: 11
	}

	public List<String> musicUids
	{
		 get { } //Length: 5
	}

	public int tagIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string tagName
	{
		 get { } //Length: 365
	}

	public AlbumTagInfo() { }

	public void AddTagUids(List<String> buffer) { }

	public void ClearTagUids() { }

	public List<AlbumsInfo> get_albumsInfos() { }

	public bool get_isCustomTag() { }

	public List<String> get_musicUids() { }

	public int get_tagIndex() { }

	public string get_tagName() { }

	public void GetDisplayAlbums(List<AlbumDisplayMusic> buffer, bool clear = false) { }

	public void GetIconAsync(Action<Texture2D> callback) { }

	public void GetMusicUids(List<String> buffer, bool clear = false) { }

	public void InitCustomTagInfo(CustomTagInfo info) { }

	public void LinkMusicUidList() { }

	public void set_tagIndex(int value) { }

	public void SetTagUids(List<String> uids) { }

	public void SetWeekFree(int albumJsonIndex) { }

	public void ShallowCopy(AlbumTagInfo tagInfo) { }

}

