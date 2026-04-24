namespace Assets.Scripts.Database;

internal class DBConfigAnchor : BaseDBConfigObject
{
	private Dictionary<String, AnchorMusicInfo> m_AnchorMusicInfos; //Field offset: 0x38
	private Dictionary<String, AnchorElfinList> m_AnchorElfinInfos; //Field offset: 0x40
	private Dictionary<String, AnchorBanBgmInfo> m_BanUiBgmInfos; //Field offset: 0x48

	public virtual int count
	{
		 get { } //Length: 138
	}

	public DBConfigAnchor() { }

	public virtual void Deserialize(string str) { }

	public virtual int get_count() { }

	public bool TryGetBanUiBgmIsBan(string musicName, out AnchorBanBgmInfo info) { }

	public bool TryGetElfin(string elfinIndex, out AnchorElfinList info) { }

	public bool TryGetMusicIsBan(string musicUid, out AnchorMusicInfo info) { }

}

