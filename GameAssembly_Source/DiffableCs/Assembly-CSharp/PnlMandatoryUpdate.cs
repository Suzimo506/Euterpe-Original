//Type is in global namespace

public class PnlMandatoryUpdate : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Action<JObject> succeedCallback; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <SendToBackendUrl>b__0(DownloadHandler handler) { }

	}

	public Button btnOnMandatoryUpdate; //Field offset: 0x18
	private bool isAvailable; //Field offset: 0x20
	private bool isLatest; //Field offset: 0x21

	public PnlMandatoryUpdate() { }

	[CompilerGenerated]
	private void <Start>b__3_0(JObject jObj) { }

	public void OnActivate() { }

	private void OnMandatoryUpdate() { }

	private void SendToBackendUrl(string url, string method = "GET", Dictionary<String, Object> datas = null, Action<JObject> succeedCallback = null) { }

	private void Start() { }

}

