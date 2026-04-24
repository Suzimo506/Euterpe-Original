namespace UnityEngine.UIElements;

public class MouseLeaveWindowEvent : MouseEventBase<MouseLeaveWindowEvent>
{

	public MouseLeaveWindowEvent() { }

	public static MouseLeaveWindowEvent GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

}

