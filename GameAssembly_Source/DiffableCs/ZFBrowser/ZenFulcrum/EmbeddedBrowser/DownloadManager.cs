namespace ZenFulcrum.EmbeddedBrowser;

public class DownloadManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public DownloadManager <>4__this; //Field offset: 0x10
		public Browser browser; //Field offset: 0x18

		public <>c__DisplayClass7_0() { }

		internal void <ManageDownloads>b__0(int id, JSONNode info) { }

		internal void <ManageDownloads>b__1(int id, JSONNode info) { }

	}

	internal class Download
	{
		public Browser browser; //Field offset: 0x10
		public int downloadId; //Field offset: 0x18
		public string name; //Field offset: 0x20
		public string path; //Field offset: 0x28
		public int speed; //Field offset: 0x30
		public int percent; //Field offset: 0x34
		public string status; //Field offset: 0x38

		public Download() { }

	}

	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool manageAllBrowsers; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool promptForFileNames; //Field offset: 0x19
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string saveFolder; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Text statusBar; //Field offset: 0x28
	public List<Download> downloads; //Field offset: 0x30
	private StringBuilder sb; //Field offset: 0x38

	public string Status
	{
		 get { } //Length: 1409
	}

	public DownloadManager() { }

	public void Awake() { }

	public void CancelAll() { }

	public void ClearAll() { }

	public string get_Status() { }

	public static string GetUserDownloadFolder() { }

	private void HandleDownloadStarted(Browser browser, int downloadId, JSONNode info) { }

	private void HandleDownloadStatus(Browser browser, int downloadId, JSONNode info) { }

	public void ManageDownloads(Browser browser) { }

	public void PauseAll() { }

	public void ResumeAll() { }

	private static int SHGetKnownFolderPath(Guid rfid, uint dwFlags, IntPtr hToken, out IntPtr ppszPath) { }

	public void Update() { }

}

