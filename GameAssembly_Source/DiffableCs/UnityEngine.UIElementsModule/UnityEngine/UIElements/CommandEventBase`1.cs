namespace UnityEngine.UIElements;

public abstract class CommandEventBase : EventBase<T>, ICommandEvent
{
	private string m_CommandName; //Field offset: 0x0

	protected string commandName
	{
		 set { } //Length: 12
	}

	protected CommandEventBase`1() { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	protected void set_commandName(string value) { }

}

