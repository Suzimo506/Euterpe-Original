namespace UnityEngine.UIElements;

public class DragExitedEvent : DragAndDropEventBase<DragExitedEvent>
{

	public DragExitedEvent() { }

	public static DragExitedEvent GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected private virtual void PostDispatch(IPanel panel) { }

}

