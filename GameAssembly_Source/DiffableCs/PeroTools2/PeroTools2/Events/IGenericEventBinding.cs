namespace PeroTools2.Events;

public interface IGenericEventBinding : IBinding
{

	public List<EventBinder> events
	{
		 get { } //Length: 0
	}

	public List<EventBinder> get_events() { }

}

