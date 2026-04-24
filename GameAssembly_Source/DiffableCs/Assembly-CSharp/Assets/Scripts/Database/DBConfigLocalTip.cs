namespace Assets.Scripts.Database;

public class DBConfigLocalTip : BaseDBConfigObject
{
	private Dictionary<String, String> m_Items; //Field offset: 0x38

	public virtual int count
	{
		 get { } //Length: 67
	}

	public DBConfigLocalTip() { }

	public virtual void Deserialize(string str) { }

	public virtual int get_count() { }

	public string GetTip(string key) { }

}

