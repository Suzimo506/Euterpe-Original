namespace Assets.Scripts.Database;

public class DBConfigLocalFailBarrage : BaseDBConfigObject
{
	private List<FailBarrageLocalConfig> m_Items; //Field offset: 0x38

	protected private List<FailBarrageLocalConfig> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalFailBarrage() { }

	public virtual void Deserialize(string str) { }

	protected List<FailBarrageLocalConfig> get_list() { }

	public bool GetFailBarrage(int roleIndex, List<String> buffer) { }

	private void set_list(List<FailBarrageLocalConfig> value) { }

}

