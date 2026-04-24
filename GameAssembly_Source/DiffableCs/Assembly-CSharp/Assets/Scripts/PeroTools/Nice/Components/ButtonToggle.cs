namespace Assets.Scripts.PeroTools.Nice.Components;

public class ButtonToggle : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Toggle> <>9__17_0; //Field offset: 0x8
		public static Predicate<Toggle> <>9__18_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnClick>b__18_0(Toggle t) { }

		internal bool <OnEnable>b__17_0(Toggle t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Toggle tgl; //Field offset: 0x10
		public ButtonToggle <>4__this; //Field offset: 0x18

		public <>c__DisplayClass14_0() { }

		internal void <Awake>b__2(bool state) { }

	}

	public ToggleGroup group; //Field offset: 0x58
	public Button btnPre; //Field offset: 0x60
	public Button btnNext; //Field offset: 0x68
	public AudioClip clickSfx; //Field offset: 0x70
	public Text levelDesigner; //Field offset: 0x78
	public GameObject masterLockImg; //Field offset: 0x80
	public GameObject masterLevelImg; //Field offset: 0x88
	public bool isLoop; //Field offset: 0x90
	private int m_Index; //Field offset: 0x94
	public List<Toggle> toggles; //Field offset: 0x98
	public List<Text> texts; //Field offset: 0xA0
	[CompilerGenerated]
	private Action onDifficultyChanged; //Field offset: 0xA8

	public event Action onDifficultyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public ButtonToggle() { }

	[CompilerGenerated]
	private void <Awake>b__14_0() { }

	[CompilerGenerated]
	private void <Awake>b__14_1() { }

	[CompilerGenerated]
	public void add_onDifficultyChanged(Action value) { }

	private void Awake() { }

	private void OnClick(bool pre) { }

	public void OnEnable() { }

	private void OnToggleValueChanged(Toggle tgl, bool state) { }

	[CompilerGenerated]
	public void remove_onDifficultyChanged(Action value) { }

	private void ToggleDiff() { }

}

