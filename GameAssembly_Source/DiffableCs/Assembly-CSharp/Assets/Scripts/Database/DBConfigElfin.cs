namespace Assets.Scripts.Database;

public class DBConfigElfin : BaseDBConfigLocalObject<DBConfigLocalElfin, LocalElfinInfo>
{
	private List<ElfinInfo> m_Items; //Field offset: 0x40

	public int freeCount
	{
		 get { } //Length: 254
	}

	protected private List<ElfinInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public int noHideCount
	{
		 get { } //Length: 248
	}

	public DBConfigElfin() { }

	public virtual void Deserialize(string str) { }

	public int get_freeCount() { }

	protected List<ElfinInfo> get_list() { }

	public int get_noHideCount() { }

	public ElfinInfo GetElfinInfoByIndex(int index) { }

	public ElfinInfo GetElfinInfoByOrder(int order) { }

	public int GetFreeCountByRarity(string rarity) { }

	private void set_list(List<ElfinInfo> value) { }

}

