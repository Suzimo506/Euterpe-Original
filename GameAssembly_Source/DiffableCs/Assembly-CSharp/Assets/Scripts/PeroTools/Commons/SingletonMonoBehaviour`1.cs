namespace Assets.Scripts.PeroTools.Commons;

public class SingletonMonoBehaviour : MonoBehaviour
{
	private static T m_Instance; //Field offset: 0x0

	public static T instance
	{
		 get { } //Length: 620
	}

	public SingletonMonoBehaviour`1() { }

	private void Awake() { }

	public void DestroyInstance() { }

	public static T get_instance() { }

}

