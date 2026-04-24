namespace Assets.Scripts.Database;

public class DBConfigAlbums : BaseDBConfigLocalObject<DBConfigLocalAlbums, String>
{
	internal class AlbumsInfo : BaseDataObject
	{
		public string uid; //Field offset: 0x20
		public string title; //Field offset: 0x28
		public string tag; //Field offset: 0x30
		public bool needPurchase; //Field offset: 0x38
		public string price; //Field offset: 0x40
		public string jsonName; //Field offset: 0x48
		public string prefabsName; //Field offset: 0x50
		public bool free; //Field offset: 0x58
		protected AlbumExInfo m_AlbumExInfo; //Field offset: 0x5C

		public int albumJsonIndex
		{
			 get { } //Length: 4
		}

		public int albumUidIndex
		{
			 get { } //Length: 4
		}

		public AlbumsInfo() { }

		private void ExInfoInit() { }

		public int get_albumJsonIndex() { }

		public int get_albumUidIndex() { }

		public void GetAlbumMusicUids(List<String> buffer, bool clear = false) { }

		public virtual void Init(int index) { }

	}

	private List<AlbumsInfo> m_Items; //Field offset: 0x40
	private int m_MaxAlbumUid; //Field offset: 0x48

	protected private List<AlbumsInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public int maxAlbunUid
	{
		 get { } //Length: 4
	}

	public DBConfigAlbums() { }

	public virtual void Deserialize(string str) { }

	protected List<AlbumsInfo> get_list() { }

	public int get_maxAlbunUid() { }

	public int GetAlbumIndexByUid(string uid) { }

	public AlbumsInfo GetAlbumInfoByAlbumJsonIndex(int albumIndex) { }

	public AlbumsInfo GetAlbumInfoByIndex(int index) { }

	public AlbumsInfo GetAlbumInfoByMusicInfo(MusicInfo musicInfo) { }

	public AlbumsInfo GetAlbumsInfoByUid(string uid) { }

	private void set_list(List<AlbumsInfo> value) { }

}

