namespace Assets.Scripts.PeroTools.UI;

public class PassthoughDragEvent : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject passTarget; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool includeChildrens; //Field offset: 0x20

	public PassthoughDragEvent() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

}

