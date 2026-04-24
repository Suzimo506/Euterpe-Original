namespace Assets.Scripts.Database;

public class DBConfigLocalLoading : BaseDBConfigObject
{
	private List<LocalLoadingInfo> m_Items; //Field offset: 0x38

	protected private List<LocalLoadingInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalLoading() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalLoadingInfo> get_list() { }

	public LocalLoadingInfo GetInfoByIndex(int index) { }

	private void set_list(List<LocalLoadingInfo> value) { }

}

