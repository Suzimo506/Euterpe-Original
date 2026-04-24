//Type is in global namespace

public class StageBtnPlaySpecial : SingletonMonoBehaviour<StageBtnPlaySpecial>, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
{
	public Image btnPress; //Field offset: 0x18
	private float m_StartSchedule; //Field offset: 0x20
	private float m_MaxSchedule; //Field offset: 0x24
	private bool m_IsBtnDown; //Field offset: 0x28
	private bool m_IsBeginHoldAnim; //Field offset: 0x29
	private float m_CurPressTimer; //Field offset: 0x2C
	private Vector2 m_MousePositon; //Field offset: 0x30
	public float m_DeadDistance; //Field offset: 0x38

	public StageBtnPlaySpecial() { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData data) { }

	public override void OnPointerUp(PointerEventData data) { }

	private void ResetInputData() { }

	private void Update() { }

}

