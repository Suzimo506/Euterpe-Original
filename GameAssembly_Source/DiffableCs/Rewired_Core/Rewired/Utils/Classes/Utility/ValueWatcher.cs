namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class ValueWatcher
{
	internal enum AFBFeOndQgyAJZcgVNaFXyaypDk
	{
		ValueChanged = 0,
	}


	public abstract bool autoTriggerEvent
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract bool changed
	{
		 get { } //Length: 0
	}

	protected ValueWatcher() { }

	public abstract void AddEventListener(AFBFeOndQgyAJZcgVNaFXyaypDk eventType, Delegate listener) { }

	public abstract bool get_autoTriggerEvent() { }

	public abstract bool get_changed() { }

	public abstract void RemoveEventListener(AFBFeOndQgyAJZcgVNaFXyaypDk eventType, Delegate listener) { }

	public abstract void set_autoTriggerEvent(bool value) { }

	public abstract bool TriggerEvent() { }

	public abstract bool Update() { }

	public abstract bool Use() { }

}

