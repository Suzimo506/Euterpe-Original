namespace Assets.Scripts.UI.Panels;

public class PnlBackgroundSetting : MonoBehaviour, IPreWarm
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string sceneName; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <OnSliderValueChanged>b__0(IData b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public string sceneName; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal bool <OnSceneIndexChanged>b__0(IData b) { }

	}

	private static List<String> s_SceneNames; //Field offset: 0x0
	public Image[] images; //Field offset: 0x18
	public Slider slider; //Field offset: 0x20
	public Text text; //Field offset: 0x28
	public FancyScrollView fancyScrollView; //Field offset: 0x30
	public AudioClip optionBgmClip; //Field offset: 0x38
	private List<IData> m_Brightnesses; //Field offset: 0x40
	[SerializeField]
	private Button m_BackButton; //Field offset: 0x48
	[SerializeField]
	private Animator m_Animator; //Field offset: 0x50

	public PnlBackgroundSetting() { }

	public void Awake() { }

	private void OnBackClicked() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnSceneIndexChanged(int index) { }

	private void OnSliderValueChanged(float value) { }

	private void OnSliderValueChanged(float value, bool reset) { }

	public override void PreWarm(int slice) { }

}

