namespace Assets.Scripts.Database;

public class DBConfigMusicSearchTag : BaseDBConfigObject
{
	private List<MusicSearchTagInfo> m_Items; //Field offset: 0x38
	private Dictionary<String, MusicSearchTagInfo> m_Dictionary; //Field offset: 0x40

	protected List<MusicSearchTagInfo> list
	{
		 get { } //Length: 5
		 set { } //Length: 54
	}

	public DBConfigMusicSearchTag() { }

	public virtual void Deserialize(string str) { }

	protected List<MusicSearchTagInfo> get_list() { }

	protected void set_list(List<MusicSearchTagInfo> value) { }

	public bool TryGetInfo(string musicUid, out MusicSearchTagInfo info) { }

}

