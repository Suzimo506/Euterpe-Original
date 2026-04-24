//Type is in global namespace

public class QAButton : MonoBehaviour
{
	public RectTransform answer; //Field offset: 0x18
	public Button button; //Field offset: 0x20
	public RectTransform imgSelect; //Field offset: 0x28
	private float m_AnswerSpace; //Field offset: 0x30
	public Color highlight; //Field offset: 0x34
	public Color normal; //Field offset: 0x44
	public AudioClip onClick; //Field offset: 0x58
	private RectTransform m_Content; //Field offset: 0x60
	private RectTransform m_Rect; //Field offset: 0x68
	private Vector2 m_ContentSize; //Field offset: 0x70
	private bool m_Show; //Field offset: 0x78
	private CanvasGroup m_CanvasGroup; //Field offset: 0x80
	private Text m_Title; //Field offset: 0x88
	private bool m_InAnim; //Field offset: 0x90
	public bool alwaysExpand; //Field offset: 0x91

	public QAButton() { }

	[CompilerGenerated]
	private Vector2 <OnClick>b__19_0() { }

	[CompilerGenerated]
	private void <OnClick>b__19_1(Vector2 a) { }

	[CompilerGenerated]
	private Vector2 <OnClick>b__19_2() { }

	[CompilerGenerated]
	private void <OnClick>b__19_3(Vector2 b) { }

	[CompilerGenerated]
	private void <OnClick>b__19_4() { }

	[CompilerGenerated]
	private float <OnClick>b__19_5() { }

	[CompilerGenerated]
	private void <OnClick>b__19_6(float c) { }

	[CompilerGenerated]
	private void <OnEnable>b__17_0() { }

	[CompilerGenerated]
	private Color <SetSelect>b__20_0() { }

	[CompilerGenerated]
	private void <SetSelect>b__20_1(Color a) { }

	private void Awake() { }

	public bool inAnim() { }

	public void OnClick(bool playSound = true) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void SetSelect(bool enable) { }

}

