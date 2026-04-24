namespace Assets.Scripts.PeroTools.Managers;

public class SceneManager : Singleton<SceneManager>
{
	public string loadingSceneName; //Field offset: 0x10
	public float leastLoadingTime; //Field offset: 0x18
	[CompilerGenerated]
	private string <preSceneName>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private UnityAction onBeforeLoadNewScene; //Field offset: 0x28
	public string loadSceneNameViaLoadingScene; //Field offset: 0x30
	public UnityAction completeCallBack; //Field offset: 0x38
	public UnityAction preloadCallback; //Field offset: 0x40

	public event UnityAction onBeforeLoadNewScene
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UnityAction<Scene, Scene> onSceneChanged
	{
		 add { } //Length: 81
		 remove { } //Length: 81
	}

	public event UnityAction<Scene, LoadSceneMode> onSceneLoad
	{
		 add { } //Length: 81
		 remove { } //Length: 81
	}

	public Scene curScene
	{
		 get { } //Length: 72
	}

	public private string preSceneName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Scene scene
	{
		 get { } //Length: 72
	}

	public string sceneName
	{
		 get { } //Length: 89
	}

	public SceneManager() { }

	[CompilerGenerated]
	public void add_onBeforeLoadNewScene(UnityAction value) { }

	public void add_onSceneChanged(UnityAction<Scene, Scene> value) { }

	public void add_onSceneLoad(UnityAction<Scene, LoadSceneMode> value) { }

	public Scene get_curScene() { }

	[CompilerGenerated]
	public string get_preSceneName() { }

	public Scene get_scene() { }

	public string get_sceneName() { }

	private void Init() { }

	public void InvokeOnBeforeLoadNewScene() { }

	public void LoadSceneSync(string sName) { }

	public void LoadSceneViaLoadingScene(string sceneName, UnityAction completeCallBack = null) { }

	[CompilerGenerated]
	public void remove_onBeforeLoadNewScene(UnityAction value) { }

	public void remove_onSceneChanged(UnityAction<Scene, Scene> value) { }

	public void remove_onSceneLoad(UnityAction<Scene, LoadSceneMode> value) { }

	[CompilerGenerated]
	private void set_preSceneName(string value) { }

}

