namespace Assets.Scripts.Database;

public class DBConfigLocalAlbums : BaseDBConfigObject
{
	private List<String> m_Items; //Field offset: 0x38

	protected private List<String> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalAlbums() { }

	public virtual void Deserialize(string str) { }

	protected List<String> get_list() { }

	public string GetLocalTitleByIndex(int index) { }

	private void set_list(List<String> value) { }

}

