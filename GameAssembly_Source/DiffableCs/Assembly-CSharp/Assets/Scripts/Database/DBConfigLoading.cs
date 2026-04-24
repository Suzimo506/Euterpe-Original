namespace Assets.Scripts.Database;

public class DBConfigLoading : BaseDBConfigLocalObject<DBConfigLocalLoading, LocalLoadingInfo>
{
	private List<LoadingInfo> m_Items; //Field offset: 0x40

	public int freeCount
	{
		 get { } //Length: 254
	}

	protected private List<LoadingInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLoading() { }

	public virtual void Deserialize(string str) { }

	public int get_freeCount() { }

	protected List<LoadingInfo> get_list() { }

	public LoadingInfo GetLoadingInfoByIndex(int index) { }

	private void set_list(List<LoadingInfo> value) { }

}

