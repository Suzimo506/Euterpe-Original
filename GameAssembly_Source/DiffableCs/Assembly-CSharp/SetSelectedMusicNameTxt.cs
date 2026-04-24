//Type is in global namespace

public class SetSelectedMusicNameTxt : MonoBehaviour
{
	public Text txt; //Field offset: 0x18
	public bool isMusicName; //Field offset: 0x20
	public bool isMusicAuthor; //Field offset: 0x21
	private LongSongNameController m_LongCtrl; //Field offset: 0x28

	public SetSelectedMusicNameTxt() { }

	private void Awake() { }

	private string GetSelectedMusicAuthor() { }

	private string GetSelectedMusicName(out bool isSpecialFont) { }

	private void OnEnable() { }

}

