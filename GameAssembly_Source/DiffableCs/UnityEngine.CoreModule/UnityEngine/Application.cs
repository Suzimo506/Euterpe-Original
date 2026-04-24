namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Application
{
	internal sealed class LogCallback : MulticastDelegate
	{

		public LogCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string condition, string stackTrace, LogType type, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string condition, string stackTrace, LogType type) { }

	}

	internal sealed class LowMemoryCallback : MulticastDelegate
	{

		public LowMemoryCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static LowMemoryCallback lowMemory; //Field offset: 0x0
	private static LogCallback s_LogCallbackHandler; //Field offset: 0x8
	private static LogCallback s_LogCallbackHandlerThreaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<Boolean> focusChanged; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action<String> deepLinkActivated; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Func<Boolean> wantsToQuit; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static Action quitting; //Field offset: 0x30

	public static event Action<Boolean> focusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 168
		[CompilerGenerated]
		 remove { } //Length: 168
	}

	public static event LogCallback logMessageReceived
	{
		 add { } //Length: 169
		 remove { } //Length: 133
	}

	public static event Action quitting
	{
		[CompilerGenerated]
		 add { } //Length: 168
		[CompilerGenerated]
		 remove { } //Length: 168
	}

	public static ThreadPriority backgroundLoadingPriority
	{
		[FreeFunction]
		 set { } //Length: 49
	}

	public static string companyName
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static string dataPath
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static string identifier
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static NetworkReachability internetReachability
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static bool isBatchMode
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static bool isEditor
	{
		 get { } //Length: 5
	}

	public static bool isFocused
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static bool isMobilePlatform
	{
		 get { } //Length: 87
	}

	public static bool isPlaying
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[SecurityCritical]
	public static string persistentDataPath
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static RuntimePlatform platform
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static string productName
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static bool runInBackground
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static string streamingAssetsPath
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static SystemLanguage systemLanguage
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static int targetFrameRate
	{
		[FreeFunction]
		 get { } //Length: 42
		[FreeFunction]
		 set { } //Length: 49
	}

	public static string unityVersion
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	public static string version
	{
		[FreeFunction]
		 get { } //Length: 42
	}

	[CompilerGenerated]
	public static void add_focusChanged(Action<Boolean> value) { }

	public static void add_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void add_quitting(Action value) { }

	[RequiredByNativeCode]
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	internal static void CallLowMemory() { }

	[FreeFunction]
	public static string get_companyName() { }

	[FreeFunction]
	public static string get_dataPath() { }

	[FreeFunction]
	public static string get_identifier() { }

	[FreeFunction]
	public static NetworkReachability get_internetReachability() { }

	[FreeFunction]
	public static bool get_isBatchMode() { }

	public static bool get_isEditor() { }

	[FreeFunction]
	public static bool get_isFocused() { }

	public static bool get_isMobilePlatform() { }

	[FreeFunction]
	public static bool get_isPlaying() { }

	[FreeFunction]
	public static string get_persistentDataPath() { }

	[FreeFunction]
	public static RuntimePlatform get_platform() { }

	[FreeFunction]
	public static string get_productName() { }

	[FreeFunction]
	public static bool get_runInBackground() { }

	[FreeFunction]
	public static string get_streamingAssetsPath() { }

	[FreeFunction]
	public static SystemLanguage get_systemLanguage() { }

	[FreeFunction]
	public static int get_targetFrameRate() { }

	[FreeFunction]
	public static string get_unityVersion() { }

	[FreeFunction]
	public static string get_version() { }

	[RequiredByNativeCode]
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	internal static void InvokeDeepLinkActivated(string url) { }

	[RequiredByNativeCode]
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	internal static void InvokeOnBeforeRender() { }

	[FreeFunction]
	public static void OpenURL(string url) { }

	[FreeFunction]
	public static void Quit(int exitCode) { }

	public static void Quit() { }

	[CompilerGenerated]
	public static void remove_focusChanged(Action<Boolean> value) { }

	public static void remove_logMessageReceived(LogCallback value) { }

	[CompilerGenerated]
	public static void remove_quitting(Action value) { }

	[FreeFunction]
	public static void set_backgroundLoadingPriority(ThreadPriority value) { }

	[FreeFunction]
	public static void set_targetFrameRate(int value) { }

	[FreeFunction]
	private static void SetLogCallbackDefined(bool defined) { }

}

