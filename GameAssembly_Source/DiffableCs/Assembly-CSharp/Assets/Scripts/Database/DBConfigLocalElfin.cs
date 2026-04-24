namespace Assets.Scripts.Database;

public class DBConfigLocalElfin : BaseDBConfigObject
{
	private List<LocalElfinInfo> m_Items; //Field offset: 0x38

	protected private List<LocalElfinInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalElfin() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalElfinInfo> get_list() { }

	public LocalElfinInfo GetInfoByIndex(int index) { }

	private void set_list(List<LocalElfinInfo> value) { }

}

