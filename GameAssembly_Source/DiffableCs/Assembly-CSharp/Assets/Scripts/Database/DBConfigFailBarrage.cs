namespace Assets.Scripts.Database;

public class DBConfigFailBarrage : BaseDBConfigLocalObject<DBConfigLocalFailBarrage, FailBarrageLocalConfig>
{
	private List<FailBarrageConfig> m_Items; //Field offset: 0x40

	protected private List<FailBarrageConfig> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigFailBarrage() { }

	public virtual void Deserialize(string str) { }

	protected List<FailBarrageConfig> get_list() { }

	public FailBarrageConfig GetBarrageConfigByIndex(int index) { }

	private void set_list(List<FailBarrageConfig> value) { }

}

