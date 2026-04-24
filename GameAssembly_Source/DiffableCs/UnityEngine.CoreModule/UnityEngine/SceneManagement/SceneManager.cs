namespace UnityEngine.SceneManagement;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class SceneManager
{
	internal static bool s_AllowLoadScene; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static UnityAction<Scene> sceneUnloaded; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static UnityAction<Scene, Scene> activeSceneChanged; //Field offset: 0x18

	public static event UnityAction<Scene, Scene> activeSceneChanged
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static event UnityAction<Scene> sceneUnloaded
	{
		[CompilerGenerated]
		 add { } //Length: 254
		[CompilerGenerated]
		 remove { } //Length: 254
	}

	public static int sceneCount
	{
		[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[NativeMethod]
		[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
		 get { } //Length: 42
	}

	private static SceneManager() { }

	[CompilerGenerated]
	public static void add_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[CompilerGenerated]
	public static void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	public static void add_sceneUnloaded(UnityAction<Scene> value) { }

	[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[NativeMethod]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static int get_sceneCount() { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Scene GetActiveScene() { }

	private static void GetActiveScene_Injected(out Scene ret) { }

	[NativeThrows]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Scene GetSceneAt(int index) { }

	private static void GetSceneAt_Injected(int index, out Scene ret) { }

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene) { }

	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters) { }

	[ExcludeFromDocs]
	public static void LoadScene(string sceneName) { }

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	[ExcludeFromDocs]
	public static void LoadScene(int sceneBuildIndex) { }

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters) { }

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[CompilerGenerated]
	public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value) { }

	[CompilerGenerated]
	public static void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	public static void remove_sceneUnloaded(UnityAction<Scene> value) { }

	public static AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options) { }

	[NativeThrows]
	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options) { }

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options) { }

}

