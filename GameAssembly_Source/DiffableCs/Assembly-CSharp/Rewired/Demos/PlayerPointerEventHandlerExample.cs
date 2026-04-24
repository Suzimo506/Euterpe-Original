namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	private const int logLength = 10; //Field offset: 0x0
	public Text text; //Field offset: 0x18
	private List<String> log; //Field offset: 0x20

	public PlayerPointerEventHandlerExample() { }

	private static string GetSourceName(PlayerPointerEventData playerEventData) { }

	private void Log(string o) { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public override void OnScroll(PointerEventData eventData) { }

	private void Update() { }

}

