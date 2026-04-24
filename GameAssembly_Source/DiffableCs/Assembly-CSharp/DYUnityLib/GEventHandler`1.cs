namespace DYUnityLib;

public class GEventHandler : AbstractEventHandler
{
	[CompilerGenerated]
	private TriggerHandler<T> Trigger; //Field offset: 0x0
	[CompilerGenerated]
	private uint <id>k__BackingField; //Field offset: 0x0

	public event TriggerHandler<T> Trigger
	{
		[CompilerGenerated]
		 add { } //Length: 188
		[CompilerGenerated]
		 remove { } //Length: 188
	}

	public private uint id
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public GEventHandler`1(uint id) { }

	[CompilerGenerated]
	public void add_Trigger(TriggerHandler<T> value) { }

	public virtual void ClearEvent() { }

	[CompilerGenerated]
	public uint get_id() { }

	internal virtual void Play(Object[] args = null) { }

	public void RaiseEvent(T arg) { }

	[CompilerGenerated]
	public void remove_Trigger(TriggerHandler<T> value) { }

	[CompilerGenerated]
	private void set_id(uint value) { }

}

