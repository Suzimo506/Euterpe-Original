namespace PeroTools2.UI;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ClickableText : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public Action<String, String> onClick; //Field offset: 0x18

	public ClickableText() { }

	public override void OnPointerClick(PointerEventData eventData) { }

}

