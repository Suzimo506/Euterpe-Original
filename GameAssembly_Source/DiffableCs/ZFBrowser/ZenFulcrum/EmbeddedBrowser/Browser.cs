namespace ZenFulcrum.EmbeddedBrowser;

public class Browser : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<String, String> <>9__181_0; //Field offset: 0x8
		public static Action<Texture2D> <>9__181_1; //Field offset: 0x10
		public static Action<JSONNode> <>9__181_2; //Field offset: 0x18
		public static Action<JSONNode> <>9__181_3; //Field offset: 0x20
		public static Action<JSONNode> <>9__181_4; //Field offset: 0x28
		public static Action<JSONNode> <>9__181_5; //Field offset: 0x30
		public static Action <>9__181_6; //Field offset: 0x38
		public static Action <>9__181_7; //Field offset: 0x40
		public static Action <>9__181_8; //Field offset: 0x48
		public static Action<Int32, JSONNode> <>9__181_9; //Field offset: 0x50
		public static Action<String, Boolean, String> <>9__181_10; //Field offset: 0x58
		public static Action<Boolean, Boolean> <>9__181_11; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__182_0(Browser browser) { }

		internal void <.cctor>b__182_1(Browser browser) { }

		internal void <.ctor>b__181_0(string s, string s1) { }

		internal void <.ctor>b__181_1(Texture2D t) { }

		internal void <.ctor>b__181_10(string tagName, bool editable, string value) { }

		internal void <.ctor>b__181_11(bool mouseFocused, bool keyboardFocused) { }

		internal void <.ctor>b__181_2(JSONNode loadData) { }

		internal void <.ctor>b__181_3(JSONNode loadData) { }

		internal void <.ctor>b__181_4(JSONNode errCode) { }

		internal void <.ctor>b__181_5(JSONNode errInfo) { }

		internal void <.ctor>b__181_6() { }

		internal void <.ctor>b__181_7() { }

		internal void <.ctor>b__181_8() { }

		internal void <.ctor>b__181_9(int downloadId, JSONNode info) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass105_0
	{
		public JSONNode err; //Field offset: 0x10
		public Browser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass105_0() { }

		internal void <Awake>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass105_1
	{
		public JSONNode err; //Field offset: 0x10
		public Browser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass105_1() { }

		internal void <Awake>b__6() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_0
	{
		public Action callback; //Field offset: 0x10
		public Browser <>4__this; //Field offset: 0x18

		public <>c__DisplayClass108_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass108_1
	{
		public ReadyFunc func; //Field offset: 0x10
		public <>c__DisplayClass108_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass108_1() { }

		internal void <WhenReady>b__0(int id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public string url; //Field offset: 0x18
		public bool force; //Field offset: 0x20

		public <>c__DisplayClass121_0() { }

		internal void <LoadURL>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public string html; //Field offset: 0x18
		public string url; //Field offset: 0x20

		public <>c__DisplayClass122_0() { }

		internal void <LoadHTML>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass125_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public NewWindowAction action; //Field offset: 0x18
		public INewWindowHandler newWindowHandler; //Field offset: 0x20

		public <>c__DisplayClass125_0() { }

		internal void <SetNewWindowHandler>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass126_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public FrameCommand command; //Field offset: 0x18

		public <>c__DisplayClass126_0() { }

		internal void <SendFrameCommand>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass142_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public bool show; //Field offset: 0x18

		public <>c__DisplayClass142_0() { }

		internal void <ShowDevTools>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass145_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public int width; //Field offset: 0x18
		public int height; //Field offset: 0x1C

		public <>c__DisplayClass145_0() { }

		internal void <_Resize>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass150_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public float value; //Field offset: 0x18

		public <>c__DisplayClass150_0() { }

		internal void <set_Zoom>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass151_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public int id; //Field offset: 0x18
		public Promise<JSONNode> promise; //Field offset: 0x20
		public string resultJS; //Field offset: 0x28
		public string scriptURL; //Field offset: 0x30

		public <>c__DisplayClass151_0() { }

		internal void <EvalJS>b__0(JSONNode val, bool isError) { }

		internal void <EvalJS>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass152_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public int id; //Field offset: 0x18
		public Promise<JSONNode> promise; //Field offset: 0x20
		public string resultJS; //Field offset: 0x28
		public string scriptURL; //Field offset: 0x30

		public <>c__DisplayClass152_0() { }

		internal void <EvalJSCSP>b__0(JSONNode val, bool isError) { }

		internal void <EvalJSCSP>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass155_0
	{
		public JSCallback callback; //Field offset: 0x10

		public <>c__DisplayClass155_0() { }

		internal void <RegisterFunction>b__0(JSONNode value, bool error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass162_0
	{
		public Browser <>4__this; //Field offset: 0x10
		public Browser overlayBrowser; //Field offset: 0x18

		public <>c__DisplayClass162_0() { }

		internal void <SetOverlay>b__0() { }

		internal void <SetOverlay>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass173_0
	{
		public Browser browser; //Field offset: 0x10
		public int callbackId; //Field offset: 0x18
		public string data; //Field offset: 0x20

		public <>c__DisplayClass173_0() { }

		internal void <CB_ForwardJSCallFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public Browser browser; //Field offset: 0x10
		public ChangeType changeType; //Field offset: 0x18
		public string arg1; //Field offset: 0x20

		public <>c__DisplayClass174_0() { }

		internal void <CB_ChangeFunc>b__0() { }

		internal void <CB_ChangeFunc>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass175_0
	{
		public Browser browser; //Field offset: 0x10
		public DialogType dialogType; //Field offset: 0x18
		public string text; //Field offset: 0x20
		public string promptText; //Field offset: 0x28

		public <>c__DisplayClass175_0() { }

		internal void <CB_DisplayDialogFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_0
	{
		public string json; //Field offset: 0x10
		public Browser browser; //Field offset: 0x18
		public int x; //Field offset: 0x20
		public int y; //Field offset: 0x24

		public <>c__DisplayClass176_0() { }

		internal void <CB_ShowContextMenuFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass177_0
	{
		public Browser browser; //Field offset: 0x10
		public string message; //Field offset: 0x18
		public string source; //Field offset: 0x20
		public int line; //Field offset: 0x28

		public <>c__DisplayClass177_0() { }

		internal void <CB_ConsoleFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass178_0
	{
		public Browser browser; //Field offset: 0x10
		public int browserId; //Field offset: 0x18

		public <>c__DisplayClass178_0() { }

		internal void <CB_ReadyFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass179_0
	{
		public Browser browser; //Field offset: 0x10
		public bool canGoBack; //Field offset: 0x18
		public bool canGoForward; //Field offset: 0x19
		public bool lodaing; //Field offset: 0x1A
		public string url; //Field offset: 0x20

		public <>c__DisplayClass179_0() { }

		internal void <CB_NavStateFunc>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass180_0
	{
		public Browser browser; //Field offset: 0x10
		public int newBrowserId; //Field offset: 0x18

		public <>c__DisplayClass180_0() { }

		internal void <CB_NewWindowFunc>b__0() { }

	}

	internal sealed class JSCallback : MulticastDelegate
	{

		public JSCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(JSONNode args, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(JSONNode args) { }

	}

	internal sealed class JSResultFunc : MulticastDelegate
	{

		public JSResultFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(JSONNode value, bool isError, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(JSONNode value, bool isError) { }

	}

	[Flags]
	internal enum NewWindowAction
	{
		Ignore = 1,
		Redirect = 2,
		NewBrowser = 3,
		NewWindow = 4,
	}

	private static int lastUpdateFrame; //Field offset: 0x0
	protected static Dictionary<Int32, List`1<Object>> allThingsToRemember; //Field offset: 0x8
	[CompilerGenerated]
	private static Action<Browser> onAnyBrowserCreated; //Field offset: 0x10
	[CompilerGenerated]
	private static Action<Browser> onAnyBrowserDestroyed; //Field offset: 0x18
	internal static Dictionary<Int32, Browser> allBrowsers; //Field offset: 0x20
	protected IBrowserUI _uiHandler; //Field offset: 0x18
	protected bool uiHandlerAssigned; //Field offset: 0x20
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string _url; //Field offset: 0x28
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _width; //Field offset: 0x30
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _height; //Field offset: 0x34
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool generateMipmap; //Field offset: 0x38
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Color32 baseColor; //Field offset: 0x3C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _zoom; //Field offset: 0x40
	[CompilerGenerated]
	private Action<String, String> onConsoleMessage; //Field offset: 0x48
	[FlagsField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public ContextMenuOrigin allowContextMenuOn; //Field offset: 0x50
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private NewWindowAction newWindowAction; //Field offset: 0x54
	[CompilerGenerated]
	private INewWindowHandler <NewWindowHandler>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private bool <EnableRendering>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <EnableInput>k__BackingField; //Field offset: 0x61
	[CompilerGenerated]
	private CookieManager <CookieManager>k__BackingField; //Field offset: 0x68
	protected private int browserId; //Field offset: 0x70
	private int unsafeBrowserId; //Field offset: 0x74
	protected bool browserIdRequested; //Field offset: 0x78
	protected Texture2D texture; //Field offset: 0x80
	[CompilerGenerated]
	private Action<Texture2D> afterResize; //Field offset: 0x88
	protected bool textureIsOurs; //Field offset: 0x90
	protected bool forceNextRender; //Field offset: 0x91
	protected bool isPopup; //Field offset: 0x92
	protected List<Action> thingsToDo; //Field offset: 0x98
	protected List<Action> onloadActions; //Field offset: 0xA0
	protected List<Object> thingsToRemember; //Field offset: 0xA8
	private int nextCallbackId; //Field offset: 0xB0
	protected Dictionary<Int32, JSResultFunc> registeredCallbacks; //Field offset: 0xB8
	[CompilerGenerated]
	private ReadyFunc onNativeReady; //Field offset: 0xC0
	[CompilerGenerated]
	private Action<JSONNode> onLoad; //Field offset: 0xC8
	[CompilerGenerated]
	private Action<JSONNode> onFetch; //Field offset: 0xD0
	[CompilerGenerated]
	private Action<JSONNode> onFetchError; //Field offset: 0xD8
	[CompilerGenerated]
	private Action<JSONNode> onCertError; //Field offset: 0xE0
	[CompilerGenerated]
	private Action onSadTab; //Field offset: 0xE8
	[CompilerGenerated]
	private Action onTextureUpdated; //Field offset: 0xF0
	[CompilerGenerated]
	private Action onNavStateChange; //Field offset: 0xF8
	public Action<Int32, JSONNode> onDownloadStarted; //Field offset: 0x100
	[CompilerGenerated]
	private Action<Int32, JSONNode> onDownloadStatus; //Field offset: 0x108
	[CompilerGenerated]
	private Action<String, Boolean, String> onNodeFocus; //Field offset: 0x110
	[CompilerGenerated]
	private Action<Boolean, Boolean> onBrowserFocus; //Field offset: 0x118
	[HideInInspector]
	public readonly BrowserFocusState focusState; //Field offset: 0x120
	private BrowserInput browserInput; //Field offset: 0x128
	private Browser overlay; //Field offset: 0x130
	private bool skipNextLoad; //Field offset: 0x138
	private bool loadPending; //Field offset: 0x139
	private BrowserNavState navState; //Field offset: 0x140
	private bool newWindowHandlerSet; //Field offset: 0x148
	private INewWindowHandler newWindowHandler; //Field offset: 0x150
	protected DialogHandler dialogHandler; //Field offset: 0x158
	private Action pageReplacer; //Field offset: 0x160
	private float pageReplacerPriority; //Field offset: 0x168
	protected List<Action> thingsToDoClone; //Field offset: 0x170
	private Color32[] colorBuffer; //Field offset: 0x178

	public event Action<Texture2D> afterResize
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public static event Action<Browser> onAnyBrowserCreated
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event Action<Browser> onAnyBrowserDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public event Action<Boolean, Boolean> onBrowserFocus
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<JSONNode> onCertError
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String, String> onConsoleMessage
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<Int32, JSONNode> onDownloadStatus
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	[Obsolete]
	public event Action<JSONNode> onFetch
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<JSONNode> onFetchError
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<JSONNode> onLoad
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	protected event ReadyFunc onNativeReady
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onNavStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String, Boolean, String> onNodeFocus
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onSadTab
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action onTextureUpdated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public bool CanGoBack
	{
		 get { } //Length: 30
	}

	public bool CanGoForward
	{
		 get { } //Length: 30
	}

	public private CookieManager CookieManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public bool EnableInput
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool EnableRendering
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsLoaded
	{
		 get { } //Length: 136
	}

	public bool IsLoadingRaw
	{
		 get { } //Length: 30
	}

	public bool IsReady
	{
		 get { } //Length: 8
	}

	public static string LocalUrlPrefix
	{
		 get { } //Length: 100
	}

	[Obsolete]
	public INewWindowHandler NewWindowHandler
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Vector2 Size
	{
		 get { } //Length: 52
	}

	public Texture2D Texture
	{
		 get { } //Length: 8
	}

	public IBrowserUI UIHandler
	{
		 get { } //Length: 5
		 set { } //Length: 16
	}

	public string Url
	{
		 get { } //Length: 30
		 set { } //Length: 11
	}

	public float Zoom
	{
		 get { } //Length: 6
		 set { } //Length: 282
	}

	protected void _EvalJS(string script, string scriptURL) { }

	internal void _RaiseFocusEvent(bool mouseIsFocused, bool keyboardIsFocused) { }

	protected void _Resize(Texture2D newTexture, bool newTextureIsOurs) { }

	private static Browser() { }

	public Browser() { }

	[CompilerGenerated]
	private void <Awake>b__105_0(int id) { }

	[CompilerGenerated]
	private void <Awake>b__105_1(string message, string source) { }

	[CompilerGenerated]
	private void <Awake>b__105_2(JSONNode err) { }

	[CompilerGenerated]
	private void <Awake>b__105_3(JSONNode err) { }

	[CompilerGenerated]
	private void <Awake>b__105_4() { }

	[CompilerGenerated]
	private void <Awake>b__105_7() { }

	[CompilerGenerated]
	private void <CreateDialogHandler>b__113_0(bool affirm, string text1, string text2) { }

	[CompilerGenerated]
	private void <CreateDialogHandler>b__113_1(int commandId) { }

	[CompilerGenerated]
	public void add_afterResize(Action<Texture2D> value) { }

	[CompilerGenerated]
	public static void add_onAnyBrowserCreated(Action<Browser> value) { }

	[CompilerGenerated]
	public static void add_onAnyBrowserDestroyed(Action<Browser> value) { }

	[CompilerGenerated]
	public void add_onBrowserFocus(Action<Boolean, Boolean> value) { }

	[CompilerGenerated]
	public void add_onCertError(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void add_onConsoleMessage(Action<String, String> value) { }

	[CompilerGenerated]
	public void add_onDownloadStatus(Action<Int32, JSONNode> value) { }

	[CompilerGenerated]
	public void add_onFetch(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void add_onFetchError(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void add_onLoad(Action<JSONNode> value) { }

	[CompilerGenerated]
	protected void add_onNativeReady(ReadyFunc value) { }

	[CompilerGenerated]
	public void add_onNavStateChange(Action value) { }

	[CompilerGenerated]
	public void add_onNodeFocus(Action<String, Boolean, String> value) { }

	[CompilerGenerated]
	public void add_onSadTab(Action value) { }

	[CompilerGenerated]
	public void add_onTextureUpdated(Action value) { }

	protected void Awake() { }

	public IPromise<JSONNode> CallFunction(string name, JSONNode[] arguments) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_ChangeFunc(int browserId, ChangeType changeType, string arg1) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_ConsoleFunc(int browserId, string message, string source, int line) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_DisplayDialogFunc(int browserId, DialogType dialogType, IntPtr textPtr, IntPtr promptTextPtr, IntPtr sourceURL) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_ForwardJSCallFunc(int browserId, int callbackId, string data, int size) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_NavStateFunc(int browserId, bool canGoBack, bool canGoForward, bool lodaing, IntPtr urlRaw) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_NewWindowFunc(int creatorBrowserId, int newBrowserId, IntPtr urlPtr) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_ReadyFunc(int browserId) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void CB_ShowContextMenuFunc(int browserId, string json, int x, int y, ContextMenuOrigin origin) { }

	protected void CheckSanity() { }

	protected void CreateDialogHandler() { }

	internal bool DeferUnready(Action ifNotReady) { }

	public void DownloadCommand(int downloadId, DownloadAction action, string fileName = null) { }

	public IPromise<JSONNode> EvalJS(string script, string scriptURL = "scripted command") { }

	public IPromise<JSONNode> EvalJSCSP(string script, string scriptURL = "scripted command") { }

	public bool get_CanGoBack() { }

	public bool get_CanGoForward() { }

	[CompilerGenerated]
	public CookieManager get_CookieManager() { }

	[CompilerGenerated]
	public bool get_EnableInput() { }

	[CompilerGenerated]
	public bool get_EnableRendering() { }

	public bool get_IsLoaded() { }

	public bool get_IsLoadingRaw() { }

	public bool get_IsReady() { }

	public static string get_LocalUrlPrefix() { }

	[CompilerGenerated]
	public INewWindowHandler get_NewWindowHandler() { }

	public Vector2 get_Size() { }

	public Texture2D get_Texture() { }

	public IBrowserUI get_UIHandler() { }

	public string get_Url() { }

	public float get_Zoom() { }

	private static Browser GetBrowser(int browserId) { }

	public void GoBack() { }

	public void GoForward() { }

	protected void HandleInput() { }

	protected void LateUpdate() { }

	public void LoadDataURI(string text, string mimeType = "text/html") { }

	public void LoadDataURI(Byte[] data, string mimeType) { }

	public void LoadHTML(string html, string url = null) { }

	public void LoadURL(string url, bool force) { }

	protected void OnApplicationFocus(bool focus) { }

	protected void OnApplicationPause(bool paused) { }

	protected void OnDestroy() { }

	protected void OnDisable() { }

	protected void OnItemChange(ChangeType type, string arg1) { }

	public void PressKey(KeyCode key, KeyAction action = 2) { }

	protected void ProcessCallbacks() { }

	public void QueuePageReplacer(Action replacePage, float priority) { }

	public void RegisterFunction(string name, JSCallback callback) { }

	public void Reload(bool force = false) { }

	[CompilerGenerated]
	public void remove_afterResize(Action<Texture2D> value) { }

	[CompilerGenerated]
	public static void remove_onAnyBrowserCreated(Action<Browser> value) { }

	[CompilerGenerated]
	public static void remove_onAnyBrowserDestroyed(Action<Browser> value) { }

	[CompilerGenerated]
	public void remove_onBrowserFocus(Action<Boolean, Boolean> value) { }

	[CompilerGenerated]
	public void remove_onCertError(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void remove_onConsoleMessage(Action<String, String> value) { }

	[CompilerGenerated]
	public void remove_onDownloadStatus(Action<Int32, JSONNode> value) { }

	[CompilerGenerated]
	public void remove_onFetch(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void remove_onFetchError(Action<JSONNode> value) { }

	[CompilerGenerated]
	public void remove_onLoad(Action<JSONNode> value) { }

	[CompilerGenerated]
	protected void remove_onNativeReady(ReadyFunc value) { }

	[CompilerGenerated]
	public void remove_onNavStateChange(Action value) { }

	[CompilerGenerated]
	public void remove_onNodeFocus(Action<String, Boolean, String> value) { }

	[CompilerGenerated]
	public void remove_onSadTab(Action value) { }

	[CompilerGenerated]
	public void remove_onTextureUpdated(Action value) { }

	protected void Render() { }

	internal void RequestNativeBrowser(int newBrowserId = 0) { }

	public void Resize(int width, int height) { }

	public void Resize(Texture2D newTexture) { }

	public void RunOnMainThread(Action callback) { }

	public void SendFrameCommand(FrameCommand command) { }

	[CompilerGenerated]
	private void set_CookieManager(CookieManager value) { }

	[CompilerGenerated]
	public void set_EnableInput(bool value) { }

	[CompilerGenerated]
	public void set_EnableRendering(bool value) { }

	[CompilerGenerated]
	public void set_NewWindowHandler(INewWindowHandler value) { }

	public void set_UIHandler(IBrowserUI value) { }

	public void set_Url(string value) { }

	public void set_Zoom(float value) { }

	public void SetNewWindowHandler(NewWindowAction action, INewWindowHandler newWindowHandler) { }

	public void SetOverlay(Browser overlayBrowser) { }

	public void ShowDevTools(bool show = true) { }

	public void Stop() { }

	public void TypeText(string text) { }

	protected void Update() { }

	public void UpdateCursor() { }

	public void WhenLoaded(Action callback) { }

	public void WhenReady(Action callback) { }

}

