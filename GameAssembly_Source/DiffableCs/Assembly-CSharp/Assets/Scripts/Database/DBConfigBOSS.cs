namespace Assets.Scripts.Database;

internal class DBConfigBOSS : BaseDBConfigObject
{
	private List<BOSSInfo> m_Items; //Field offset: 0x38

	protected List<BOSSInfo> list
	{
		 get { } //Length: 5
		 set { } //Length: 54
	}

	public DBConfigBOSS() { }

	public virtual void Deserialize(string str) { }

	protected List<BOSSInfo> get_list() { }

	public BOSSInfo GetInfoBySceneName(string sceneName) { }

	protected void set_list(List<BOSSInfo> value) { }

}

