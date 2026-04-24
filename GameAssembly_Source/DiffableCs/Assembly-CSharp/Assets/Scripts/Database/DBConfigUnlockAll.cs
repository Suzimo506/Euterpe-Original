namespace Assets.Scripts.Database;

public class DBConfigUnlockAll : BaseDBConfigObject
{
	private List<UnlockAllInfo> m_Items; //Field offset: 0x38

	protected private List<UnlockAllInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigUnlockAll() { }

	public virtual void Deserialize(string str) { }

	public UnlockAllInfo FindMinimumGapInfo(decimal price) { }

	protected List<UnlockAllInfo> get_list() { }

	public UnlockAllInfo GetInfoByIndex(int i) { }

	public UnlockAllInfo GetInfoByUid(string uid) { }

	public UnlockAllInfo GetMaxPriceInfo() { }

	public string GetUidByIndex(int i) { }

	private void set_list(List<UnlockAllInfo> value) { }

}

