namespace Assets.Scripts.PeroTools.UI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class LongPressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public bool longPressIncludePointerDown; //Field offset: 0x18
	public float delta; //Field offset: 0x1C
	public float triggerDelta; //Field offset: 0x20
	public Action onPressDown; //Field offset: 0x28
	public Action<Boolean> onPress; //Field offset: 0x30
	public Action onPressUp; //Field offset: 0x38
	private Button m_Button; //Field offset: 0x40
	private bool m_Flag; //Field offset: 0x48
	private float m_PressStartTime; //Field offset: 0x4C
	private float m_LastPressTime; //Field offset: 0x50

	public LongPressButton() { }

	private void Awake() { }

	public bool IsActive() { }

	public bool IsInteractable() { }

	private void OnEnable() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	private void Update() { }

}

