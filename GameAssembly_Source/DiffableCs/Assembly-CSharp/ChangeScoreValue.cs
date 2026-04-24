//Type is in global namespace

public class ChangeScoreValue : MonoBehaviour
{
	public Text text; //Field offset: 0x18
	public TextMeshProUGUI gcText; //Field offset: 0x20
	public Text djmaxText; //Field offset: 0x28
	public GameObject[] scores; //Field offset: 0x30
	public GameObject[] apIcons; //Field offset: 0x38
	private int m_Index; //Field offset: 0x40
	private int m_SceneIdx; //Field offset: 0x44
	private PeroString m_PeroString; //Field offset: 0x48

	public ChangeScoreValue() { }

	private void Awake() { }

	public void InitUi() { }

	private void OnDestroy() { }

	private void OnJudged(uint result) { }

	private void OnScoreChange(int score) { }

	private void SetApIcons(bool enable) { }

}

