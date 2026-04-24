//Type is in global namespace

public class PnlMusicSlider : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	public RectTransform rectImage; //Field offset: 0x18
	public Vector2 oriScale; //Field offset: 0x20
	public Vector2 changeScaleOffset; //Field offset: 0x28
	public float animatorTime; //Field offset: 0x30
	private Tweener m_Tweener; //Field offset: 0x38
	private bool isDrag; //Field offset: 0x40

	public PnlMusicSlider() { }

	private void Awake() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

}

