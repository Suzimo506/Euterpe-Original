namespace Assets.Scripts.UI.Controls;

public class UITutorial : SingletonMonoBehaviour<UITutorial>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <OnHpReduct>b__13_0() { }

	}

	[SerializeField]
	private Button[] m_Restart; //Field offset: 0x18
	[SerializeField]
	private Button[] m_Exit; //Field offset: 0x20
	public GameObject autoObj; //Field offset: 0x28
	private Animator m_Animator; //Field offset: 0x30
	private Sequence m_AddLifeSeq; //Field offset: 0x38

	public Animator animator
	{
		 get { } //Length: 95
	}

	public UITutorial() { }

	private void Awake() { }

	public Animator get_animator() { }

	private void OnDestroy() { }

	private void OnExitClicked() { }

	private void OnHpReduct(object sender, object reciever, Object[] args) { }

	private void OnPause() { }

	private void OnRestartClicked() { }

	private void OnResume() { }

	private void Start() { }

	private void Update() { }

}

