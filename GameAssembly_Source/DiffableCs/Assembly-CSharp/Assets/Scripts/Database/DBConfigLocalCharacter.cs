namespace Assets.Scripts.Database;

public class DBConfigLocalCharacter : BaseDBConfigObject
{
	private List<LocalCharacterInfo> m_Items; //Field offset: 0x38

	protected private List<LocalCharacterInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalCharacter() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalCharacterInfo> get_list() { }

	public LocalCharacterInfo GetInfoByIndex(int index) { }

	private void set_list(List<LocalCharacterInfo> value) { }

}

