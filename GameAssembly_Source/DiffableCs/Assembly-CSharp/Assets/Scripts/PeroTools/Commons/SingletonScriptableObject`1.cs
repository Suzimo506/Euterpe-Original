namespace Assets.Scripts.PeroTools.Commons;

public class SingletonScriptableObject : SerializedScriptableObject
{
	protected static T m_Instance; //Field offset: 0x0

	public static T instance
	{
		 get { } //Length: 1547
	}

	public SingletonScriptableObject`1() { }

	public void DestroyInstance() { }

	public static T get_instance() { }

	public static string GetSingleScriptableObjectDirectory() { }

}

