//Type is in global namespace

public class MusicButtonAreaTitle : MonoBehaviour
{
	[SerializeField]
	private Text m_Txt; //Field offset: 0x18
	[SerializeField]
	private LongSongNameController m_LongName; //Field offset: 0x20
	[SerializeField]
	private CanvasGroup m_CanvasGroup; //Field offset: 0x28
	private bool m_IsSpecialFont; //Field offset: 0x30

	public string title
	{
		 get { } //Length: 39
	}

	public MusicButtonAreaTitle() { }

	public string get_title() { }

	public void RefreshTxt(string title, bool isSpecialFont = false) { }

}

