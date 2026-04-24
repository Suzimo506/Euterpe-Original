namespace PeroTools2.Commons;

public class SingletonScriptableObject : SerializedScriptableObject
{
	private static T s_Instance; //Field offset: 0x0

	public static T instance
	{
		 get { } //Length: 720
	}

	public SingletonScriptableObject`1() { }

	public void DestroyInstance() { }

	public static T get_instance() { }

}

