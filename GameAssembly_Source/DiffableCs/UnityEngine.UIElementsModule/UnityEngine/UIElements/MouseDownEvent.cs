namespace UnityEngine.UIElements;

public class MouseDownEvent : MouseEventBase<MouseDownEvent>
{

	public MouseDownEvent() { }

	internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent) { }

	internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent) { }

	private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent) { }

}

