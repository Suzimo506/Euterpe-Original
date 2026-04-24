namespace UnityEngine.SceneManagement;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public struct Scene
{
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	public int handle
	{
		 get { } //Length: 5
	}

	public bool isLoaded
	{
		 get { } //Length: 49
	}

	public string name
	{
		 get { } //Length: 49
	}

	public string path
	{
		 get { } //Length: 49
	}

	public virtual bool Equals(object other) { }

	public int get_handle() { }

	public bool get_isLoaded() { }

	public string get_name() { }

	public string get_path() { }

	public virtual int GetHashCode() { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static string GetNameInternal(int sceneHandle) { }

	[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static string GetPathInternal(int sceneHandle) { }

	public static bool op_Equality(Scene lhs, Scene rhs) { }

}

