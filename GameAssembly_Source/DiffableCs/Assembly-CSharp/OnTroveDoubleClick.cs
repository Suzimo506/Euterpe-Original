//Type is in global namespace

public class OnTroveDoubleClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	private bool m_IsPotinterDowned; //Field offset: 0x18
	private bool m_BtnInvoked; //Field offset: 0x19

	public OnTroveDoubleClick() { }

	private void ClickWaitTimeOver() { }

	public override void OnPointerDown(PointerEventData data) { }

}

