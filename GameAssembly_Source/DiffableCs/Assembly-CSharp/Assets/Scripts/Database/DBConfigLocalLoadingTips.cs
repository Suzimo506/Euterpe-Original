namespace Assets.Scripts.Database;

public class DBConfigLocalLoadingTips : BaseDBConfigObject
{
	private List<LocalLoadingTipsInfo> m_Items; //Field offset: 0x38

	private List<LocalLoadingTipsInfo> list
	{
		private get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalLoadingTips() { }

	public virtual void Deserialize(string str) { }

	private List<LocalLoadingTipsInfo> get_list() { }

	public void GetAllTips(List<String> buffer, bool clear) { }

	public LocalLoadingTipsInfo GetInfoByIndex(int index) { }

	private void set_list(List<LocalLoadingTipsInfo> value) { }

}

