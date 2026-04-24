namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TouchButtonExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	public bool allowMouseControl; //Field offset: 0x18
	[CompilerGenerated]
	private bool <isPressed>k__BackingField; //Field offset: 0x19

	public private bool isPressed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public TouchButtonExample() { }

	private void Awake() { }

	[CompilerGenerated]
	public bool get_isPressed() { }

	private static bool IsMousePointerId(int id) { }

	private void Restart() { }

	[CompilerGenerated]
	private void set_isPressed(bool value) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

}

