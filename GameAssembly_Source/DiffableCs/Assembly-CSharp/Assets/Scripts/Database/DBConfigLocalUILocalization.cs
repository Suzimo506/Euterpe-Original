namespace Assets.Scripts.Database;

public class DBConfigLocalUILocalization : BaseDBConfigObject
{
	private List<LocalUILocalizationInfo> m_Items; //Field offset: 0x38

	protected List<LocalUILocalizationInfo> list
	{
		 get { } //Length: 5
		 set { } //Length: 54
	}

	public LocalUILocalizationInfo uiLocalizationInfo
	{
		 get { } //Length: 77
	}

	public DBConfigLocalUILocalization() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalUILocalizationInfo> get_list() { }

	public LocalUILocalizationInfo get_uiLocalizationInfo() { }

	protected void set_list(List<LocalUILocalizationInfo> value) { }

}

