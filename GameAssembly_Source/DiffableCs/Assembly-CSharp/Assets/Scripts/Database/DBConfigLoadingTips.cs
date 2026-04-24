namespace Assets.Scripts.Database;

public class DBConfigLoadingTips : BaseDBConfigLocalObject<DBConfigLocalLoadingTips, LocalLoadingTipsInfo>
{
	private List<LoadingTipsInfo> m_Items; //Field offset: 0x40

	protected List<LoadingTipsInfo> list
	{
		 get { } //Length: 5
		 set { } //Length: 54
	}

	public DBConfigLoadingTips() { }

	public virtual void Deserialize(string str) { }

	protected List<LoadingTipsInfo> get_list() { }

	protected void set_list(List<LoadingTipsInfo> value) { }

}

