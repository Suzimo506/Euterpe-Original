namespace Assets.Scripts.Database;

public class DBConfigCharacterFestivalVoice : BaseDBConfigLocalObject<DBConfigLocalCharacterFestivalVoice, LocalCharacterFestivalVoiceInfo>
{
	private List<CharacterFestivalVoiceInfo> m_Items; //Field offset: 0x40

	protected private List<CharacterFestivalVoiceInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigCharacterFestivalVoice() { }

	public virtual void Deserialize(string str) { }

	protected List<CharacterFestivalVoiceInfo> get_list() { }

	public CharacterFestivalVoiceInfo GetInfoByIndex(int index) { }

	private void set_list(List<CharacterFestivalVoiceInfo> value) { }

}

