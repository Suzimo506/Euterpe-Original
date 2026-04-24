namespace Assets.Scripts.Database;

public class DBConfigUILocalization : BaseDBConfigLocalObject<DBConfigLocalUILocalization, LocalUILocalizationInfo>
{
	private StringBuilder m_StringBuilder; //Field offset: 0x40

	public DBConfigUILocalization() { }

	public virtual void Deserialize(string str) { }

	public string GetLocalization(string key, List<String> args = null) { }

	public string GetLocalization(string key, int langIndex, List<String> args = null) { }

}

