namespace Assets.Scripts.Database;

public class DBConfigLocalALBUM : BaseDBConfigObject
{
	private List<LocalALBUMInfo> m_Items; //Field offset: 0x38

	protected private List<LocalALBUMInfo> List
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalALBUM() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalALBUMInfo> get_List() { }

	public LocalALBUMInfo GetLocalAlbumInfoByIndex(int index) { }

	private void set_List(List<LocalALBUMInfo> value) { }

}

