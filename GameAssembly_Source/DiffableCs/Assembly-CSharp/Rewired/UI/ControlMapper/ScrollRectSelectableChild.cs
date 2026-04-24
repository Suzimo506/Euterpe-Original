namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ScrollRectSelectableChild : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	public bool useCustomEdgePadding; //Field offset: 0x18
	public float customEdgePadding; //Field offset: 0x1C
	private ScrollRect parentScrollRect; //Field offset: 0x20
	private Selectable _selectable; //Field offset: 0x28

	private RectTransform parentScrollRectContentTransform
	{
		private get { } //Length: 27
	}

	private RectTransform rectTransform
	{
		private get { } //Length: 82
	}

	private Selectable selectable
	{
		private get { } //Length: 99
	}

	public ScrollRectSelectableChild() { }

	private RectTransform get_parentScrollRectContentTransform() { }

	private RectTransform get_rectTransform() { }

	private Selectable get_selectable() { }

	public override void OnSelect(BaseEventData eventData) { }

	private void Start() { }

}

