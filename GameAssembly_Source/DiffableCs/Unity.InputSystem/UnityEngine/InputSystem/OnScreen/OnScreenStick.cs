namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OnScreenStick : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	private float m_MovementRange; //Field offset: 0x30
	[InputControl]
	[SerializeField]
	private string m_ControlPath; //Field offset: 0x38
	private Vector3 m_StartPos; //Field offset: 0x40
	private Vector2 m_PointerDownPos; //Field offset: 0x4C

	protected virtual string controlPathInternal
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public float movementRange
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public OnScreenStick() { }

	protected virtual string get_controlPathInternal() { }

	public float get_movementRange() { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected virtual void set_controlPathInternal(string value) { }

	public void set_movementRange(float value) { }

	private void Start() { }

}

