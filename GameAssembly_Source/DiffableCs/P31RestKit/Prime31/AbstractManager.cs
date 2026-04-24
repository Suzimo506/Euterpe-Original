namespace Prime31;

public abstract class AbstractManager : MonoBehaviour
{
	private static LifecycleHelper _prime31LifecycleHelperRef; //Field offset: 0x0
	private static ThreadingCallbackHelper _threadingCallbackHelper; //Field offset: 0x8
	private static GameObject _prime31GameObject; //Field offset: 0x10

	public static LifecycleHelper coroutineSurrogate
	{
		 get { } //Length: 177
	}

	public static LifecycleHelper lifecycleHelper
	{
		 get { } //Length: 177
	}

	protected AbstractManager() { }

	private void Awake() { }

	public static void createThreadingCallbackHelper() { }

	public static LifecycleHelper get_coroutineSurrogate() { }

	public static LifecycleHelper get_lifecycleHelper() { }

	public static GameObject getPrime31ManagerGameObject() { }

	public static ThreadingCallbackHelper getThreadingCallbackHelper() { }

	public static void initialize(Type type) { }

}

