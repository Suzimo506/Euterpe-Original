namespace Assets.Scripts.UI.Controls;

public class CharacterExpression : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Bulletin> <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Start>b__21_0(Bulletin b) { }

	}

	private ExpressionContainer m_Expressions; //Field offset: 0x18
	private int m_CharacterIdx; //Field offset: 0x20
	private string m_Language; //Field offset: 0x28
	public Text text; //Field offset: 0x30
	public Animator bubbleAnimator; //Field offset: 0x38
	private Coroutine m_Coroutine; //Field offset: 0x40
	private Coroutine m_EndCoroutine; //Field offset: 0x48
	private CoroutineManager m_CoroutineManager; //Field offset: 0x50
	private AudioSource m_AudioSource; //Field offset: 0x58
	public Button m_Btn; //Field offset: 0x60
	private MuseShow m_MuseShow; //Field offset: 0x68
	private CharacterApply m_CharacterApply; //Field offset: 0x70
	private bool m_IsFinishAnim; //Field offset: 0x78
	public string tipExpressionAnimName; //Field offset: 0x80
	public float tipExpressionTime; //Field offset: 0x88
	public GameObject tipExpressionContent; //Field offset: 0x90
	private bool m_IsTriggerNekoMainHidden; //Field offset: 0x98
	private int m_NekoMainHiddenNum; //Field offset: 0x9C
	private float m_BubbleOutTime; //Field offset: 0xA0
	private int m_ClickCount; //Field offset: 0xA4

	public CharacterExpression() { }

	[CompilerGenerated]
	private void <Express>b__27_0() { }

	[CompilerGenerated]
	private void <PlayEndCallback>b__28_0() { }

	[CompilerGenerated]
	private void <TipExpression>b__33_0() { }

	[CompilerGenerated]
	private void <TipExpression>b__33_1() { }

	private void Awake() { }

	public void Express(int index, int soundIndex) { }

	public void Express(Expression expression, int soundIndex = -1) { }

	private void InvokeSteamAchievement() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnMuseShowClicked() { }

	private void PlayEndCallback() { }

	private void RandomExpress() { }

	private void RefreshExpressions() { }

	public void SetMuseShow(MuseShow museShow) { }

	private void Start() { }

	public void TipExpression(bool test = false) { }

}

