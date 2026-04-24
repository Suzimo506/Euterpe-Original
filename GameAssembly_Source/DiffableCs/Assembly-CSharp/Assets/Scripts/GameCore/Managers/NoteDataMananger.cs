namespace Assets.Scripts.GameCore.Managers;

public class NoteDataMananger : SingletonScriptableObject<NoteDataMananger>
{
	[SerializeField]
	private List<NoteConfigData> m_NoteDatas; //Field offset: 0x58

	public List<NoteConfigData> noteDatas
	{
		 get { } //Length: 5
	}

	public NoteDataMananger() { }

	public List<NoteConfigData> get_noteDatas() { }

	public NoteConfigData GetMirrorNoteByUidPathway(string uid, int pathway) { }

	public NoteConfigData GetNoteByUid(string uid) { }

	private void Init() { }

}

