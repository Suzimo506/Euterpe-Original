namespace UnityEngine.UIElements;

public class IMGUIEvent : EventBase<IMGUIEvent>
{

	public IMGUIEvent() { }

	public static IMGUIEvent GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

}

