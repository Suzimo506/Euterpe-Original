namespace PeroTools2.Events;

public interface IEventBinding : IBinding
{

	public Dictionary<UInt32, BaseValueDelegate> events
	{
		 get { } //Length: 0
	}

	public Dictionary<UInt32, BaseValueDelegate> get_events() { }

}

