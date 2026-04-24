//Type is in global namespace

public class FSVScrollBar : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler
{
	internal sealed class OnDragBeginDelegate : MulticastDelegate
	{

		public OnDragBeginDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnDragDelegate : MulticastDelegate
	{

		public OnDragDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnDragEndDelegate : MulticastDelegate
	{

		public OnDragEndDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPointerDownDelegate : MulticastDelegate
	{

		public OnPointerDownDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnPointerUpDelegate : MulticastDelegate
	{

		public OnPointerUpDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public OnDragBeginDelegate onDragBeginEvent; //Field offset: 0x18
	public OnDragDelegate onDragEvent; //Field offset: 0x20
	public OnDragEndDelegate onDragEndEvent; //Field offset: 0x28
	public OnPointerDownDelegate onPointerDown; //Field offset: 0x30
	public OnPointerDownDelegate onPointerUp; //Field offset: 0x38

	public FSVScrollBar() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	public override void OnDrag(PointerEventData eventData) { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

}

