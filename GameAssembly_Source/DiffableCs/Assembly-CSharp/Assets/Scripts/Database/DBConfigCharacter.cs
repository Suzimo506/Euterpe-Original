namespace Assets.Scripts.Database;

public class DBConfigCharacter : BaseDBConfigLocalObject<DBConfigLocalCharacter, LocalCharacterInfo>
{
	private List<CharacterInfo> m_Items; //Field offset: 0x40

	public int freeCount
	{
		 get { } //Length: 260
	}

	protected private List<CharacterInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public int noHideCount
	{
		 get { } //Length: 251
	}

	public DBConfigCharacter() { }

	public virtual void Deserialize(string str) { }

	public CharacterInfo FindCharacterInfo(Func<CharacterInfo, Boolean> func) { }

	public int get_freeCount() { }

	protected List<CharacterInfo> get_list() { }

	public int get_noHideCount() { }

	public CharacterInfo GetCharacterInfoByIndex(int index) { }

	public CharacterInfo GetCharacterInfoByMainShow(string mainShow) { }

	public CharacterInfo GetCharacterInfoByOrder(int order) { }

	public int GetFreeCountByRarity(string rarity) { }

	private void set_list(List<CharacterInfo> value) { }

}

