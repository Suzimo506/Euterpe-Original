namespace UnityEngine.UIElements;

public class DragUpdatedEvent : DragAndDropEventBase<DragUpdatedEvent>
{

	public DragUpdatedEvent() { }

	public static DragUpdatedEvent GetPooled(Event systemEvent) { }

	protected private virtual void PostDispatch(IPanel panel) { }

}

