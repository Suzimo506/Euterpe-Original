namespace Assets.Scripts.Database;

public class DBConfigTip : BaseDBConfigLocalObject<DBConfigLocalTip, KeyValuePair`2<String, String>>
{
	private Dictionary<String, String> m_Items; //Field offset: 0x40

	public virtual int count
	{
		 get { } //Length: 67
	}

	public DBConfigTip() { }

	public virtual void Deserialize(string str) { }

	public virtual int get_count() { }

	public static string GetTip(string key) { }

}

