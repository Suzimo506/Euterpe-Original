namespace UnityEngine.InputSystem.OnScreen;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[HelpURL(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class OnScreenButton : OnScreenControl, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[InputControl]
	[SerializeField]
	private string m_ControlPath; //Field offset: 0x30

	protected virtual string controlPathInternal
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public OnScreenButton() { }

	protected virtual string get_controlPathInternal() { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	protected virtual void set_controlPathInternal(string value) { }

}

