//Type is in global namespace

public class GUIView : MonoBehaviour
{
	private const string PROGRESS_KEY = "Progress"; //Field offset: 0x0
	private const string MUTED_KEY = "IsSoundMuted"; //Field offset: 0x0
	private const string SCORE_KEY = "Highscore"; //Field offset: 0x0
	private const string PLAYERNAME_KEY = "PlayerName"; //Field offset: 0x0
	private float progress; //Field offset: 0x18
	private bool muted; //Field offset: 0x1C
	private int score; //Field offset: 0x20
	private string playername; //Field offset: 0x28

	public GUIView() { }

	private void OnGUI() { }

	public void RefreshData() { }

	public void SaveData() { }

	private void Start() { }

	private void Update() { }

}

