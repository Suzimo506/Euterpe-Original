namespace Assets.Scripts.PeroTools.Commons;

public abstract class SingletonBehaviour : MonoBehaviour
{
	private static T m_Instance; //Field offset: 0x0

	public static T instance
	{
		 get { } //Length: 70
	}

	protected SingletonBehaviour`1() { }

	private void Awake() { }

	public static T get_instance() { }

	protected abstract void Init() { }

}

