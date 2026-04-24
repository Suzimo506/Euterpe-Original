namespace Assets.Scripts.Database;

public class DBConfigALBUM : BaseDBConfigLocalObject<DBConfigLocalALBUM, LocalALBUMInfo>
{
	private List<MusicInfo> m_Items; //Field offset: 0x40

	protected private List<MusicInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigALBUM() { }

	public virtual void Deserialize(string str) { }

	protected List<MusicInfo> get_list() { }

	public void GetAllMusicInfo(List<MusicInfo> buffer) { }

	public void GetAllMusicInfo(Dictionary<String, MusicInfo> dic, bool clear = false) { }

	public void GetAllMusicUids(List<String> buffer, bool clear = false) { }

	public int GetIndexByUid(string uid) { }

	public MusicInfo GetMusicInfoByIndex(int index) { }

	public MusicInfo GetMusicInfoByMusicUid(string uid) { }

	private void set_list(List<MusicInfo> value) { }

}

