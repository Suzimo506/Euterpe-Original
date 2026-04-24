namespace xdsdk.Unity;

public class EventTriggerListener : EventTrigger
{
	internal sealed class VoidDelegate : MulticastDelegate
	{

		public VoidDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject go) { }

	}

	public VoidDelegate onClick; //Field offset: 0x20
	public VoidDelegate onDown; //Field offset: 0x28
	public VoidDelegate onEnter; //Field offset: 0x30
	public VoidDelegate onExit; //Field offset: 0x38
	public VoidDelegate onUp; //Field offset: 0x40
	public VoidDelegate onSelect; //Field offset: 0x48
	public VoidDelegate onDeselect; //Field offset: 0x50
	public VoidDelegate onUpdateSelect; //Field offset: 0x58
	public VoidDelegate onBeginDrag; //Field offset: 0x60

	public EventTriggerListener() { }

	public static EventTriggerListener Get(GameObject go) { }

	public virtual void OnBeginDrag(PointerEventData eventData) { }

	public virtual void OnDeselect(BaseEventData eventData) { }

	public virtual void OnDrag(PointerEventData data) { }

	public virtual void OnEndDrag(PointerEventData eventData) { }

	public virtual void OnPointerClick(PointerEventData eventData) { }

	public virtual void OnPointerDown(PointerEventData eventData) { }

	public virtual void OnPointerEnter(PointerEventData eventData) { }

	public virtual void OnPointerExit(PointerEventData eventData) { }

	public virtual void OnPointerUp(PointerEventData eventData) { }

	public virtual void OnSelect(BaseEventData eventData) { }

	public virtual void OnUpdateSelected(BaseEventData eventData) { }

}

