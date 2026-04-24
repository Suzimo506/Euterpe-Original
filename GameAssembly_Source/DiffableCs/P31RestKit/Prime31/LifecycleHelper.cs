namespace Prime31;

public class LifecycleHelper : MonoBehaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Action<Boolean> onApplicationPausedEvent; //Field offset: 0x18

	public event Action<Boolean> onApplicationPausedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public LifecycleHelper() { }

	[CompilerGenerated]
	public void add_onApplicationPausedEvent(Action<Boolean> value) { }

	private void OnApplicationPause(bool paused) { }

	[CompilerGenerated]
	public void remove_onApplicationPausedEvent(Action<Boolean> value) { }

}

