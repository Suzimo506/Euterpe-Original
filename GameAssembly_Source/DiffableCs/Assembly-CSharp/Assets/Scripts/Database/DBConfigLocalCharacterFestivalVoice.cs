namespace Assets.Scripts.Database;

public class DBConfigLocalCharacterFestivalVoice : BaseDBConfigObject
{
	private List<LocalCharacterFestivalVoiceInfo> m_Items; //Field offset: 0x38

	protected private List<LocalCharacterFestivalVoiceInfo> list
	{
		 get { } //Length: 5
		private set { } //Length: 54
	}

	public DBConfigLocalCharacterFestivalVoice() { }

	public virtual void Deserialize(string str) { }

	protected List<LocalCharacterFestivalVoiceInfo> get_list() { }

	public LocalCharacterFestivalVoiceInfo GetInfoByListIndex(int index) { }

	private void set_list(List<LocalCharacterFestivalVoiceInfo> value) { }

}

