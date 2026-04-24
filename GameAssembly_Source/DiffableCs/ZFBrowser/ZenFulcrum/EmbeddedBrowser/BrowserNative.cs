namespace ZenFulcrum.EmbeddedBrowser;

public static class BrowserNative
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventHandler <>9__22_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <LoadNative>b__22_0(object sender, EventArgs args) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_addCLISwitch : MulticastDelegate
	{

		public Calltype_zfb_addCLISwitch(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string value, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string value) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_changeLoading : MulticastDelegate
	{

		public Calltype_zfb_changeLoading(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, LoadChange what, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, LoadChange what) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_characterEvent : MulticastDelegate
	{

		public Calltype_zfb_characterEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int character, int windowsKeyCode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int character, int windowsKeyCode) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_clearCookies : MulticastDelegate
	{

		public Calltype_zfb_clearCookies(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_copyToColor32 : MulticastDelegate
	{

		public Calltype_zfb_copyToColor32(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr src, IntPtr dest, int pixelCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr src, IntPtr dest, int pixelCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_createBrowser : MulticastDelegate
	{

		public Calltype_zfb_createBrowser(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ZFBSettings settings, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(ZFBSettings settings) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_destroyAllBrowsers : MulticastDelegate
	{

		public Calltype_zfb_destroyAllBrowsers(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_destroyBrowser : MulticastDelegate
	{

		public Calltype_zfb_destroyBrowser(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_doNav : MulticastDelegate
	{

		public Calltype_zfb_doNav(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int direction, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int direction) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_downloadCommand : MulticastDelegate
	{

		public Calltype_zfb_downloadCommand(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int downloadId, DownloadAction command, string fileName, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int downloadId, DownloadAction command, string fileName) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_editCookie : MulticastDelegate
	{

		public Calltype_zfb_editCookie(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, NativeCookie cookie, CookieAction action, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, NativeCookie cookie, CookieAction action) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_evalJS : MulticastDelegate
	{

		public Calltype_zfb_evalJS(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, string script, string scriptURL, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, string script, string scriptURL) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_flatColorTexture : MulticastDelegate
	{

		public Calltype_zfb_flatColorTexture(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int pixelCount, int r, int g, int b, int a, AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke(int pixelCount, int r, int g, int b, int a) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_free : MulticastDelegate
	{

		public Calltype_zfb_free(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr mem, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr mem) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_getCookies : MulticastDelegate
	{

		public Calltype_zfb_getCookies(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, GetCookieFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, GetCookieFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_getImage : MulticastDelegate
	{

		public Calltype_zfb_getImage(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool forceDirty, AsyncCallback callback, object object) { }

		public override RenderData EndInvoke(IAsyncResult result) { }

		public override RenderData Invoke(int id, bool forceDirty) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_getMouseCursor : MulticastDelegate
	{

		public Calltype_zfb_getMouseCursor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, out int width, out int height, AsyncCallback callback, object object) { }

		public override CursorType EndInvoke(out int width, out int height, IAsyncResult result) { }

		public override CursorType Invoke(int id, out int width, out int height) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_getMouseCustomCursor : MulticastDelegate
	{

		public Calltype_zfb_getMouseCustomCursor(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, IntPtr buffer, int width, int height, out int hotX, out int hotY, AsyncCallback callback, object object) { }

		public override void EndInvoke(out int hotX, out int hotY, IAsyncResult result) { }

		public override void Invoke(int id, IntPtr buffer, int width, int height, out int hotX, out int hotY) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_getVersion : MulticastDelegate
	{

		public Calltype_zfb_getVersion(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override IntPtr EndInvoke(IAsyncResult result) { }

		public override IntPtr Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_goToHTML : MulticastDelegate
	{

		public Calltype_zfb_goToHTML(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, string html, string url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, string html, string url) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_goToURL : MulticastDelegate
	{

		public Calltype_zfb_goToURL(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, string url, bool force, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, string url, bool force) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_init : MulticastDelegate
	{

		public Calltype_zfb_init(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(ZFBInitialSettings settings, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(ZFBInitialSettings settings) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_keyEvent : MulticastDelegate
	{

		public Calltype_zfb_keyEvent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool down, int windowsKeyCode, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, bool down, int windowsKeyCode) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_memcpy : MulticastDelegate
	{

		public Calltype_zfb_memcpy(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr dst, IntPtr src, int size, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr dst, IntPtr src, int size) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_mouseButton : MulticastDelegate
	{

		public Calltype_zfb_mouseButton(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, MouseButton button, bool down, int clickCount, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, MouseButton button, bool down, int clickCount) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_mouseMove : MulticastDelegate
	{

		public Calltype_zfb_mouseMove(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, float x, float y, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, float x, float y) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_mouseScroll : MulticastDelegate
	{

		public Calltype_zfb_mouseScroll(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int deltaX, int deltaY, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int deltaX, int deltaY) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_noop : MulticastDelegate
	{

		public Calltype_zfb_noop(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_numBrowsers : MulticastDelegate
	{

		public Calltype_zfb_numBrowsers(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerChangeCallback : MulticastDelegate
	{

		public Calltype_zfb_registerChangeCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, ChangeFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, ChangeFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerConsoleCallback : MulticastDelegate
	{

		public Calltype_zfb_registerConsoleCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, ConsoleFunc callback, AsyncCallback __callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, ConsoleFunc callback) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerContextMenuCallback : MulticastDelegate
	{

		public Calltype_zfb_registerContextMenuCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, ShowContextMenuFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, ShowContextMenuFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerDialogCallback : MulticastDelegate
	{

		public Calltype_zfb_registerDialogCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, DisplayDialogFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, DisplayDialogFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerJSCallback : MulticastDelegate
	{

		public Calltype_zfb_registerJSCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, ForwardJSCallFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, ForwardJSCallFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerNavStateCallback : MulticastDelegate
	{

		public Calltype_zfb_registerNavStateCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, NavStateFunc callback, AsyncCallback __callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, NavStateFunc callback) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_registerPopupCallback : MulticastDelegate
	{

		public Calltype_zfb_registerPopupCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, NewWindowAction windowAction, ZFBSettings baseSettings, NewWindowFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, NewWindowAction windowAction, ZFBSettings baseSettings, NewWindowFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_resize : MulticastDelegate
	{

		public Calltype_zfb_resize(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int w, int h, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int w, int h) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_sendCommandToFocusedFrame : MulticastDelegate
	{

		public Calltype_zfb_sendCommandToFocusedFrame(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, FrameCommand command, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, FrameCommand command) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_sendContextMenuResults : MulticastDelegate
	{

		public Calltype_zfb_sendContextMenuResults(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, int commandId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, int commandId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_sendDialogResults : MulticastDelegate
	{

		public Calltype_zfb_sendDialogResults(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool affirmed, string text1, string text2, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, bool affirmed, string text1, string text2) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_sendRequestData : MulticastDelegate
	{

		public Calltype_zfb_sendRequestData(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int requestId, IntPtr data, int dataSize, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int requestId, IntPtr data, int dataSize) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_sendRequestHeaders : MulticastDelegate
	{

		public Calltype_zfb_sendRequestHeaders(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int requestId, int responseLength, string headersJSON, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int requestId, int responseLength, string headersJSON) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setCallbacksEnabled : MulticastDelegate
	{

		public Calltype_zfb_setCallbacksEnabled(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool enabled, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool enabled) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setDebugFunc : MulticastDelegate
	{

		public Calltype_zfb_setDebugFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(MessageFunc debugFunc, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(MessageFunc debugFunc) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setFocused : MulticastDelegate
	{

		public Calltype_zfb_setFocused(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool focused, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, bool focused) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setLocalRequestHandler : MulticastDelegate
	{

		public Calltype_zfb_setLocalRequestHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NewRequestFunc requestFunc, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NewRequestFunc requestFunc) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setOverlay : MulticastDelegate
	{

		public Calltype_zfb_setOverlay(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, int overlayBrowserId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, int overlayBrowserId) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setReadyCallback : MulticastDelegate
	{

		public Calltype_zfb_setReadyCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, ReadyFunc cb, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, ReadyFunc cb) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_setZoom : MulticastDelegate
	{

		public Calltype_zfb_setZoom(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, double zoom, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, double zoom) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_showDevTools : MulticastDelegate
	{

		public Calltype_zfb_showDevTools(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int id, bool show, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int id, bool show) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_shutdown : MulticastDelegate
	{

		public Calltype_zfb_shutdown(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class Calltype_zfb_tick : MulticastDelegate
	{

		public Calltype_zfb_tick(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ChangeFunc : MulticastDelegate
	{

		public ChangeFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, ChangeType changeType, string arg1, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, ChangeType changeType, string arg1) { }

	}

	internal enum ChangeType
	{
		CHT_CURSOR = 0,
		CHT_BROWSER_CLOSE = 1,
		CHT_FETCH_FINISHED = 2,
		CHT_FETCH_FAILED = 3,
		CHT_LOAD_FINISHED = 4,
		CHT_CERT_ERROR = 5,
		CHT_SAD_TAB = 6,
		CHT_DOWNLOAD_STARTED = 7,
		CHT_DOWNLOAD_STATUS = 8,
		CHT_FOCUSED_NODE = 9,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ConsoleFunc : MulticastDelegate
	{

		public ConsoleFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, string message, string source, int line, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, string message, string source, int line) { }

	}

	[Flags]
	internal enum ContextMenuOrigin
	{
		Editable = 2,
		Image = 4,
		Selection = 8,
		Other = 1,
	}

	internal enum CookieAction
	{
		Delete = 0,
		Create = 1,
	}

	internal enum CursorType
	{
		Pointer = 0,
		Cross = 1,
		Hand = 2,
		IBeam = 3,
		Wait = 4,
		Help = 5,
		EastResize = 6,
		NorthResize = 7,
		NorthEastResize = 8,
		NorthWestResize = 9,
		SouthResize = 10,
		SouthEastResize = 11,
		SouthWestResize = 12,
		WestResize = 13,
		NorthSouthResize = 14,
		EastWestResize = 15,
		NorthEastSouthWestResize = 16,
		NorthWestSouthEastResize = 17,
		ColumnResize = 18,
		RowResize = 19,
		MiddlePanning = 20,
		EastPanning = 21,
		NorthPanning = 22,
		NorthEastPanning = 23,
		NorthWestPanning = 24,
		SouthPanning = 25,
		SouthEastPanning = 26,
		SouthWestPanning = 27,
		WestPanning = 28,
		Move = 29,
		VerticalText = 30,
		Cell = 31,
		ContextMenu = 32,
		Alias = 33,
		Progress = 34,
		NoDrop = 35,
		Copy = 36,
		None = 37,
		NotAllowed = 38,
		ZoomIn = 39,
		ZoomOut = 40,
		Grab = 41,
		Grabbing = 42,
		Custom = 43,
	}

	internal enum DialogType
	{
		DLT_HIDE = 0,
		DLT_ALERT = 1,
		DLT_CONFIRM = 2,
		DLT_PROMPT = 3,
		DLT_PAGE_UNLOAD = 4,
		DLT_PAGE_RELOAD = 5,
		DLT_GET_AUTH = 6,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class DisplayDialogFunc : MulticastDelegate
	{

		public DisplayDialogFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, DialogType dialogType, IntPtr dialogText, IntPtr initialPromptText, IntPtr sourceURL, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, DialogType dialogType, IntPtr dialogText, IntPtr initialPromptText, IntPtr sourceURL) { }

	}

	internal enum DownloadAction
	{
		Begin = 0,
		Cancel = 1,
		Pause = 2,
		Resume = 3,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ForwardJSCallFunc : MulticastDelegate
	{

		public ForwardJSCallFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, int callbackId, string data, int size, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, int callbackId, string data, int size) { }

	}

	internal enum FrameCommand
	{
		Undo = 0,
		Redo = 1,
		Cut = 2,
		Copy = 3,
		Paste = 4,
		Delete = 5,
		SelectAll = 6,
		ViewSource = 7,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class GetCookieFunc : MulticastDelegate
	{

		public GetCookieFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(NativeCookie cookie, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(NativeCookie cookie) { }

	}

	internal enum LoadChange
	{
		LC_STOP = 1,
		LC_RELOAD = 2,
		LC_FORCE_RELOAD = 3,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class MessageFunc : MulticastDelegate
	{

		public MessageFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	internal enum MouseButton
	{
		MBT_LEFT = 0,
		MBT_MIDDLE = 1,
		MBT_RIGHT = 2,
	}

	internal class NativeCookie
	{
		public string name; //Field offset: 0x10
		public string value; //Field offset: 0x18
		public string domain; //Field offset: 0x20
		public string path; //Field offset: 0x28
		public string creation; //Field offset: 0x30
		public string lastAccess; //Field offset: 0x38
		public string expires; //Field offset: 0x40
		public byte secure; //Field offset: 0x48
		public byte httpOnly; //Field offset: 0x49

		public NativeCookie() { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class NavStateFunc : MulticastDelegate
	{

		public NavStateFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, bool canGoBack, bool canGoForward, bool lodaing, IntPtr url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, bool canGoBack, bool canGoForward, bool lodaing, IntPtr url) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class NewRequestFunc : MulticastDelegate
	{

		public NewRequestFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int requestId, string url, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int requestId, string url) { }

	}

	internal enum NewWindowAction
	{
		NWA_IGNORE = 1,
		NWA_REDIRECT = 2,
		NWA_NEW_BROWSER = 3,
		NWA_NEW_WINDOW = 4,
	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class NewWindowFunc : MulticastDelegate
	{

		public NewWindowFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int creatorBrowserId, int newBrowserId, IntPtr initialURL, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int creatorBrowserId, int newBrowserId, IntPtr initialURL) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ReadyFunc : MulticastDelegate
	{

		public ReadyFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId) { }

	}

	internal struct RenderData
	{
		public IntPtr pixels; //Field offset: 0x0
		public int w; //Field offset: 0x8
		public int h; //Field offset: 0xC

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class ShowContextMenuFunc : MulticastDelegate
	{

		public ShowContextMenuFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int browserId, string menuJSON, int x, int y, ContextMenuOrigin origin, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int browserId, string menuJSON, int x, int y, ContextMenuOrigin origin) { }

	}

	[UnmanagedFunctionPointer(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal sealed class WindowCallbackFunc : MulticastDelegate
	{

		public WindowCallbackFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(int windowId, IntPtr data, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(int windowId, IntPtr data) { }

	}

	internal struct ZFBInitialSettings
	{
		public string cefPath; //Field offset: 0x0
		public string localePath; //Field offset: 0x8
		public string subprocessFile; //Field offset: 0x10
		public string userAgent; //Field offset: 0x18
		public string logFile; //Field offset: 0x20
		public string profilePath; //Field offset: 0x28
		public int debugPort; //Field offset: 0x30
		public int multiThreadedMessageLoop; //Field offset: 0x34

	}

	internal struct ZFBSettings
	{
		public int bgR; //Field offset: 0x0
		public int bgG; //Field offset: 0x4
		public int bgB; //Field offset: 0x8
		public int bgA; //Field offset: 0xC
		public int offscreen; //Field offset: 0x10

	}

	public const int DebugPort = 9849; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <NativeLoaded>k__BackingField; //Field offset: 0x0
	public const bool UsingAPIProxy = True; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <SymbolsLoaded>k__BackingField; //Field offset: 0x1
	public static readonly object symbolsLock; //Field offset: 0x8
	public static List<String> commandLineSwitches; //Field offset: 0x10
	public static WebResources webResources; //Field offset: 0x18
	private static bool isAppDomainUnloading; //Field offset: 0x20
	private static string _profilePath; //Field offset: 0x28
	private static IntPtr moduleHandle; //Field offset: 0x30
	public static Calltype_zfb_noop zfb_noop; //Field offset: 0x38
	public static Calltype_zfb_flatColorTexture zfb_flatColorTexture; //Field offset: 0x40
	public static Calltype_zfb_copyToColor32 zfb_copyToColor32; //Field offset: 0x48
	public static Calltype_zfb_free zfb_free; //Field offset: 0x50
	public static Calltype_zfb_memcpy zfb_memcpy; //Field offset: 0x58
	public static Calltype_zfb_getVersion zfb_getVersion; //Field offset: 0x60
	public static Calltype_zfb_setDebugFunc zfb_setDebugFunc; //Field offset: 0x68
	public static Calltype_zfb_setLocalRequestHandler zfb_setLocalRequestHandler; //Field offset: 0x70
	public static Calltype_zfb_sendRequestHeaders zfb_sendRequestHeaders; //Field offset: 0x78
	public static Calltype_zfb_sendRequestData zfb_sendRequestData; //Field offset: 0x80
	public static Calltype_zfb_setCallbacksEnabled zfb_setCallbacksEnabled; //Field offset: 0x88
	public static Calltype_zfb_destroyAllBrowsers zfb_destroyAllBrowsers; //Field offset: 0x90
	public static Calltype_zfb_addCLISwitch zfb_addCLISwitch; //Field offset: 0x98
	public static Calltype_zfb_init zfb_init; //Field offset: 0xA0
	public static Calltype_zfb_shutdown zfb_shutdown; //Field offset: 0xA8
	public static Calltype_zfb_createBrowser zfb_createBrowser; //Field offset: 0xB0
	public static Calltype_zfb_numBrowsers zfb_numBrowsers; //Field offset: 0xB8
	public static Calltype_zfb_destroyBrowser zfb_destroyBrowser; //Field offset: 0xC0
	public static Calltype_zfb_tick zfb_tick; //Field offset: 0xC8
	public static Calltype_zfb_setReadyCallback zfb_setReadyCallback; //Field offset: 0xD0
	public static Calltype_zfb_resize zfb_resize; //Field offset: 0xD8
	public static Calltype_zfb_setOverlay zfb_setOverlay; //Field offset: 0xE0
	public static Calltype_zfb_getImage zfb_getImage; //Field offset: 0xE8
	public static Calltype_zfb_registerNavStateCallback zfb_registerNavStateCallback; //Field offset: 0xF0
	public static Calltype_zfb_goToURL zfb_goToURL; //Field offset: 0xF8
	public static Calltype_zfb_goToHTML zfb_goToHTML; //Field offset: 0x100
	public static Calltype_zfb_doNav zfb_doNav; //Field offset: 0x108
	public static Calltype_zfb_setZoom zfb_setZoom; //Field offset: 0x110
	public static Calltype_zfb_changeLoading zfb_changeLoading; //Field offset: 0x118
	public static Calltype_zfb_showDevTools zfb_showDevTools; //Field offset: 0x120
	public static Calltype_zfb_setFocused zfb_setFocused; //Field offset: 0x128
	public static Calltype_zfb_mouseMove zfb_mouseMove; //Field offset: 0x130
	public static Calltype_zfb_mouseButton zfb_mouseButton; //Field offset: 0x138
	public static Calltype_zfb_mouseScroll zfb_mouseScroll; //Field offset: 0x140
	public static Calltype_zfb_keyEvent zfb_keyEvent; //Field offset: 0x148
	public static Calltype_zfb_characterEvent zfb_characterEvent; //Field offset: 0x150
	public static Calltype_zfb_registerConsoleCallback zfb_registerConsoleCallback; //Field offset: 0x158
	public static Calltype_zfb_evalJS zfb_evalJS; //Field offset: 0x160
	public static Calltype_zfb_registerJSCallback zfb_registerJSCallback; //Field offset: 0x168
	public static Calltype_zfb_registerChangeCallback zfb_registerChangeCallback; //Field offset: 0x170
	public static Calltype_zfb_getMouseCursor zfb_getMouseCursor; //Field offset: 0x178
	public static Calltype_zfb_getMouseCustomCursor zfb_getMouseCustomCursor; //Field offset: 0x180
	public static Calltype_zfb_registerDialogCallback zfb_registerDialogCallback; //Field offset: 0x188
	public static Calltype_zfb_sendDialogResults zfb_sendDialogResults; //Field offset: 0x190
	public static Calltype_zfb_registerPopupCallback zfb_registerPopupCallback; //Field offset: 0x198
	public static Calltype_zfb_registerContextMenuCallback zfb_registerContextMenuCallback; //Field offset: 0x1A0
	public static Calltype_zfb_sendContextMenuResults zfb_sendContextMenuResults; //Field offset: 0x1A8
	public static Calltype_zfb_sendCommandToFocusedFrame zfb_sendCommandToFocusedFrame; //Field offset: 0x1B0
	public static Calltype_zfb_getCookies zfb_getCookies; //Field offset: 0x1B8
	public static Calltype_zfb_editCookie zfb_editCookie; //Field offset: 0x1C0
	public static Calltype_zfb_clearCookies zfb_clearCookies; //Field offset: 0x1C8
	public static Calltype_zfb_downloadCommand zfb_downloadCommand; //Field offset: 0x1D0

	public static string LocalUrlPrefix
	{
		 get { } //Length: 43
	}

	public private static bool NativeLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 86
		[CompilerGenerated]
		private set { } //Length: 187
	}

	public static string ProfilePath
	{
		 get { } //Length: 87
		 set { } //Length: 254
	}

	public private static bool SymbolsLoaded
	{
		[CompilerGenerated]
		 get { } //Length: 87
		[CompilerGenerated]
		private set { } //Length: 92
	}

	private static BrowserNative() { }

	private static void ClearSymbols() { }

	private static void CloseLib() { }

	private static void FixProcessPermissions(CEFDirs dirs) { }

	private static bool FreeLibrary(IntPtr hModule) { }

	public static string get_LocalUrlPrefix() { }

	[CompilerGenerated]
	public static bool get_NativeLoaded() { }

	public static string get_ProfilePath() { }

	[CompilerGenerated]
	public static bool get_SymbolsLoaded() { }

	private static IntPtr GetFunc(IntPtr libHandle, string fnName) { }

	private static string GetLibError() { }

	private static IntPtr GetProcAddress(IntPtr hModule, string procName) { }

	private static void HandLoadSymbols(string binariesPath) { }

	private static IntPtr LoadLibraryW(string lpFileName) { }

	public static void LoadNative() { }

	public static void LoadSymbols() { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void LogCallback(string message) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void NewRequestCallback(int requestId, string url) { }

	private static IntPtr OpenLib(string name) { }

	[CompilerGenerated]
	private static void set_NativeLoaded(bool value) { }

	public static void set_ProfilePath(string value) { }

	[CompilerGenerated]
	private static void set_SymbolsLoaded(bool value) { }

	public static void UnloadNative() { }

}

