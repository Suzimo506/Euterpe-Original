//Type is in global namespace

[DisallowMultipleComponent]
public class RailManager : MonoBehaviour
{
	private static RailManager instance_; //Field offset: 0x0
	private static bool ever_initialize_; //Field offset: 0x8
	private bool initialized_; //Field offset: 0x18

	public static bool Initialized
	{
		 get { } //Length: 189
	}

	private static RailManager Instance
	{
		private get { } //Length: 183
	}

	public RailManager() { }

	private void Awake() { }

	public static bool get_Initialized() { }

	private static RailManager get_Instance() { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public void OnRailEvent(RAILEventID id, EventBase data) { }

	private void Update() { }

}

