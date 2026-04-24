namespace Assets.Scripts.Database;

public class DBConfigWelcome : BaseDBConfigLocalObject<DBConfigLocalWelcome, LocalWelcomeInfo>
{
	private List<WelcomeInfo> m_Items; //Field offset: 0x40

	public int freeCount
	{
		 get { } //Length: 254
	}

	protected private List<WelcomeInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigWelcome() { }

	public virtual void Deserialize(string str) { }

	public int get_freeCount() { }

	protected List<WelcomeInfo> get_list() { }

	public WelcomeInfo GetWelcomeInfoByIndex(int index) { }

	private void set_list(List<WelcomeInfo> value) { }

}

