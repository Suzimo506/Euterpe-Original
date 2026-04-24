namespace Assets.Scripts.Database;

public class DBConfigLocalWelcome : BaseDBConfigObject
{
	private List<LocalWelcomeInfo> m_Items; //Field offset: 0x38

	protected private List<LocalWelcomeInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalWelcome() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalWelcomeInfo> get_list() { }

	public LocalWelcomeInfo GetInfoByIndex(int index) { }

	private void set_list(List<LocalWelcomeInfo> value) { }

}

