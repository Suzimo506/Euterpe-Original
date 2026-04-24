namespace UnityEngine.UIElements;

public class MouseUpEvent : MouseEventBase<MouseUpEvent>
{

	public MouseUpEvent() { }

	internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent) { }

	internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent) { }

	internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent) { }

	private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

