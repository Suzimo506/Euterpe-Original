namespace Assets.Scripts.UI;

public class SetSelectedUIElement : MonoBehaviour
{
	public GameObject firstSelected; //Field offset: 0x18
	public float delay; //Field offset: 0x20
	public Button btnClose; //Field offset: 0x28
	private EventSystem m_EventSystem; //Field offset: 0x30

	public SetSelectedUIElement() { }

	[CompilerGenerated]
	private void <OnEnable>b__6_0() { }

	private void Awake() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnUIClose() { }

}

