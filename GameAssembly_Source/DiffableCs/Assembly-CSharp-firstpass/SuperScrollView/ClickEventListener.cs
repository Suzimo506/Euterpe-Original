namespace SuperScrollView;

public class ClickEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	private Action<GameObject> mClickedHandler; //Field offset: 0x18
	private Action<GameObject> mDoubleClickedHandler; //Field offset: 0x20
	private Action<GameObject> mOnPointerDownHandler; //Field offset: 0x28
	private Action<GameObject> mOnPointerUpHandler; //Field offset: 0x30
	private bool mIsPressed; //Field offset: 0x38

	public bool IsPressd
	{
		 get { } //Length: 5
	}

	public ClickEventListener() { }

	public static ClickEventListener Get(GameObject obj) { }

	public bool get_IsPressd() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void SetClickEventHandler(Action<GameObject> handler) { }

	public void SetDoubleClickEventHandler(Action<GameObject> handler) { }

	public void SetPointerDownHandler(Action<GameObject> handler) { }

	public void SetPointerUpHandler(Action<GameObject> handler) { }

}

