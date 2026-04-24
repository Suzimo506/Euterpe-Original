//Type is in global namespace

public class ThinkingSDKAutoTrack : MonoBehaviour
{
	private string mAppId; //Field offset: 0x18
	private AUTO_TRACK_EVENTS mAutoTrackEvents; //Field offset: 0x20
	private Dictionary<String, Dictionary`2<String, Object>> mAutoTrackProperties; //Field offset: 0x28
	private bool mStarted; //Field offset: 0x30
	private IAutoTrackEventCallback_PC mEventCallback_PC; //Field offset: 0x38

	public ThinkingSDKAutoTrack() { }

	public void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties, string appId) { }

	public void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback_PC eventCallback, string appId) { }

	private void OnApplicationFocus(bool hasFocus) { }

	private void OnApplicationQuit() { }

	public void SetAppId(string appId) { }

	public void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties) { }

	private void Start() { }

	private void Update() { }

}

