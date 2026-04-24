namespace PeroTools2.Commons;

public class SingletonMonoBehaviourInternal : SerializedMonoBehaviour
{
	private static T s_Instance; //Field offset: 0x0

	internal static T instance
	{
		internal get { } //Length: 832
	}

	public SingletonMonoBehaviourInternal`1() { }

	private void Awake() { }

	public void DestroyInstance() { }

	internal static T get_instance() { }

}

