namespace Prime31;

public class ThreadingCallbackHelper : MonoBehaviour
{
	private List<Action> _actions; //Field offset: 0x18
	private List<Action> _currentActions; //Field offset: 0x20

	public ThreadingCallbackHelper() { }

	public void addActionToQueue(Action action) { }

	public void disableIfEmpty() { }

	private void Update() { }

}

