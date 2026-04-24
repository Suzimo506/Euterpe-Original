namespace Assets.Scripts.Managers;

public class EventHandler : AbstractEventHandler
{
	[CompilerGenerated]
	private TriggerHandler trigger; //Field offset: 0x18

	public event TriggerHandler trigger
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public EventHandler(string uid) { }

	[CompilerGenerated]
	public void add_trigger(TriggerHandler value) { }

	internal EventHandler Clear() { }

	public virtual void ClearEvent() { }

	public void GetDelegate() { }

	internal void Play() { }

	internal virtual void Play(Object[] args = null) { }

	[CompilerGenerated]
	public void remove_trigger(TriggerHandler value) { }

}

