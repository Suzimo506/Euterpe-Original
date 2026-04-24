namespace Assets.Scripts.UI.Controls;

public class ShowText : MonoBehaviour, IInitialization
{
	private static ShowText s_ShowText; //Field offset: 0x0
	[SerializeField]
	private Text m_Text; //Field offset: 0x18
	[Header(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private CanvasGroup m_CanvasGroup; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve m_Curve; //Field offset: 0x28
	private Tween m_Tween; //Field offset: 0x30

	public ShowText() { }

	public void Close() { }

	public override void Destroy() { }

	private void DoTweenInit() { }

	public override void OnAwake() { }

	private void OnComplete() { }

	private void OnKill() { }

	public override void OnStart() { }

	public void Show(string info) { }

	public static void ShowInfo(string info) { }

}

