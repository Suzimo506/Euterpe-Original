namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TouchJoystickExample : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	public bool allowMouseControl; //Field offset: 0x18
	public int radius; //Field offset: 0x1C
	private Vector2 origAnchoredPosition; //Field offset: 0x20
	private Vector3 origWorldPosition; //Field offset: 0x28
	private Vector2 origScreenResolution; //Field offset: 0x34
	private ScreenOrientation origScreenOrientation; //Field offset: 0x3C
	private bool hasFinger; //Field offset: 0x40
	private int lastFingerId; //Field offset: 0x44
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; //Field offset: 0x48

	public private Vector2 position
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public TouchJoystickExample() { }

	[CompilerGenerated]
	public Vector2 get_position() { }

	private static bool IsMousePointerId(int id) { }

	private void Restart() { }

	[CompilerGenerated]
	private void set_position(Vector2 value) { }

	private void Start() { }

	private void StoreOrigValues() { }

	private override void UnityEngine.EventSystems.IDragHandler.OnDrag(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(PointerEventData eventData) { }

	private override void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(PointerEventData eventData) { }

	private void Update() { }

	private void UpdateValue(Vector3 value) { }

}

