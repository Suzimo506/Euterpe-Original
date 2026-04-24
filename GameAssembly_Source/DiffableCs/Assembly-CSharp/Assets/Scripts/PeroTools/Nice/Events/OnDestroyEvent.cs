namespace Assets.Scripts.PeroTools.Nice.Events;

[DisallowMultipleComponent]
public abstract class OnDestroyEvent : Event
{

	protected OnDestroyEvent() { }

	private void OnDestroy() { }

}

