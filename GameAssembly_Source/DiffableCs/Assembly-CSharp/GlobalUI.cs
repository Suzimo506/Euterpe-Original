//Type is in global namespace

public class GlobalUI : SerializedMonoBehaviour
{
	private static GlobalUI s_Instance; //Field offset: 0x0
	public IInitialization[] initObjs; //Field offset: 0x58
	private bool m_Invoke; //Field offset: 0x60

	public static GlobalUI instance
	{
		 get { } //Length: 53
	}

	public GlobalUI() { }

	private void Awake() { }

	public static GlobalUI get_instance() { }

	private void OnDestroy() { }

	private void Start() { }

}

