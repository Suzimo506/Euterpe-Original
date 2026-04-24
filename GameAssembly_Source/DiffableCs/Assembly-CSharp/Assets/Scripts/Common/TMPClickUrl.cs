namespace Assets.Scripts.Common;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TMPClickUrl : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	public bool isNoChannel; //Field offset: 0x18
	private TextMeshProUGUI m_TextMeshPro; //Field offset: 0x20

	public TMPClickUrl() { }

	private void Awake() { }

	public override void OnPointerClick(PointerEventData eventData) { }

}

