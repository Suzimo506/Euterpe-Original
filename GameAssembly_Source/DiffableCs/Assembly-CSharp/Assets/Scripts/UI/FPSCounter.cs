namespace Assets.Scripts.UI;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FPSCounter : MonoBehaviour
{
	public float updateInterval; //Field offset: 0x18
	private Text m_Text; //Field offset: 0x20
	private TextMeshProUGUI m_TextMeshProUGUI; //Field offset: 0x28
	private int m_PassFrame; //Field offset: 0x30
	private float m_PassTime; //Field offset: 0x34
	private IVariable m_ShowFpsVariable; //Field offset: 0x38
	private bool m_ShouldShow; //Field offset: 0x40

	public FPSCounter() { }

	private void Awake() { }

	private void OnDestroy() { }

}

