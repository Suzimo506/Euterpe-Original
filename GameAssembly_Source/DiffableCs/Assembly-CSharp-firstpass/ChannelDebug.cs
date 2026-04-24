//Type is in global namespace

public class ChannelDebug : MonoBehaviour
{
	public GameObject theObject; //Field offset: 0x18
	public int audioChannel; //Field offset: 0x20
	public float audioSensibility; //Field offset: 0x24
	public float scalefactor; //Field offset: 0x28
	public float lerpTime; //Field offset: 0x2C
	private int currentChannel; //Field offset: 0x30
	private Vector3 oldLocalScale; //Field offset: 0x34

	public ChannelDebug() { }

	private void OnGUI() { }

	private void Start() { }

	private void Update() { }

}

