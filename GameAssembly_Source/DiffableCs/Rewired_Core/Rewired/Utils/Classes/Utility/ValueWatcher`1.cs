namespace Rewired.Utils.Classes.Utility;

[CustomClassObfuscation]
[CustomObfuscation]
internal sealed class ValueWatcher : ValueWatcher
{
	private static IEqualityComparer<T> rLMrTzmZAFZxcBUxnDGOmwafHlYB; //Field offset: 0x0
	private bool JhfVLJuySjYbrmucTKiAhTrpRPSL; //Field offset: 0x0
	private T lrEGaNDUNYurjPaNJJqytrOckxvj; //Field offset: 0x0
	private bool jpYPUsOfVYmmisplobLEbkhtSazt; //Field offset: 0x0
	private Func<T> MNzkWOZZjlJliNaPBjYqHKJdZMmu; //Field offset: 0x0
	private Action<T> EYVNSNZdgqzTLGefHmUNQDovEjdH; //Field offset: 0x0

	public event Action<T> ChangedEvent
	{
		 add { } //Length: 132
		 remove { } //Length: 132
	}

	public virtual bool autoTriggerEvent
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public virtual bool changed
	{
		 get { } //Length: 5
	}

	public Func<T> getValueDelegate
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public T value
	{
		 get { } //Length: 5
	}

	private static ValueWatcher`1() { }

	public ValueWatcher`1(T unnamed_param_0, Func<T> unnamed_param_1, bool unnamed_param_2) { }

	public ValueWatcher`1(T unnamed_param_0, bool unnamed_param_1) { }

	public void add_ChangedEvent(Action<T> value) { }

	public virtual void AddEventListener(AFBFeOndQgyAJZcgVNaFXyaypDk eventType, Delegate listener) { }

	public virtual bool get_autoTriggerEvent() { }

	public virtual bool get_changed() { }

	public Func<T> get_getValueDelegate() { }

	public T get_value() { }

	public void remove_ChangedEvent(Action<T> value) { }

	public virtual void RemoveEventListener(AFBFeOndQgyAJZcgVNaFXyaypDk eventType, Delegate listener) { }

	public bool Set(T value) { }

	public virtual void set_autoTriggerEvent(bool value) { }

	public void set_getValueDelegate(Func<T> value) { }

	public virtual bool TriggerEvent() { }

	public virtual bool Update() { }

	public virtual bool Use() { }

}

