namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public sealed class GameObject : object
{

	[Obsolete]
	public bool active
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
	}

	public bool activeInHierarchy
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool activeSelf
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public GameObject gameObject
	{
		 get { } //Length: 6
	}

	public bool isStatic
	{
		[NativeMethod]
		 get { } //Length: 51
		[NativeMethod]
		 set { } //Length: 66
	}

	internal bool isStaticBatchable
	{
		[NativeMethod]
		internal get { } //Length: 51
	}

	public int layer
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Scene scene
	{
		[FreeFunction]
		 get { } //Length: 68
	}

	public ulong sceneCullingMask
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public string tag
	{
		[FreeFunction]
		 get { } //Length: 51
		[FreeFunction]
		 set { } //Length: 66
	}

	public Transform transform
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public GameObject(string name, Type[] components) { }

	public GameObject() { }

	public GameObject(string name) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component AddComponent(Type componentType) { }

	public T AddComponent() { }

	[FreeFunction]
	internal Component AddComponentInternal(string className) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName, object parameter) { }

	[FreeFunction]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[FreeFunction]
	public bool CompareTag(string tag) { }

	[FreeFunction]
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	[FreeFunction]
	public static GameObject Find(string name) { }

	[FreeFunction]
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	[FreeFunction]
	public static GameObject FindGameObjectWithTag(string tag) { }

	public static GameObject FindWithTag(string tag) { }

	[NativeMethod]
	public bool get_active() { }

	[NativeMethod]
	public bool get_activeInHierarchy() { }

	[NativeMethod]
	public bool get_activeSelf() { }

	public GameObject get_gameObject() { }

	[NativeMethod]
	public bool get_isStatic() { }

	[NativeMethod]
	internal bool get_isStaticBatchable() { }

	public int get_layer() { }

	[FreeFunction]
	public Scene get_scene() { }

	private void get_scene_Injected(out Scene ret) { }

	[FreeFunction]
	public ulong get_sceneCullingMask() { }

	[FreeFunction]
	public string get_tag() { }

	[FreeFunction]
	public Transform get_transform() { }

	public T GetComponent() { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponent(Type type) { }

	public Component GetComponent(string type) { }

	[FreeFunction]
	internal Component GetComponentByName(string type) { }

	[FreeFunction]
	[NativeWritableSelf]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponentInChildren(Type type) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInChildren(bool includeInactive) { }

	public T GetComponentInParent() { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponentInParent(Type type) { }

	public void GetComponents(Type type, List<Component> results) { }

	public void GetComponents(List<T> results) { }

	public Component[] GetComponents(Type type) { }

	public T[] GetComponents() { }

	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	public void GetComponentsInChildren(List<T> results) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInChildren(Type type) { }

	public T[] GetComponentsInChildren() { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public T[] GetComponentsInParent() { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInParent(Type type) { }

	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	[FreeFunction]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[FreeFunction]
	private Component Internal_AddComponentWithType(Type componentType) { }

	[FreeFunction]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName, object value) { }

	[FreeFunction]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName, object value) { }

	[FreeFunction]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName) { }

	[NativeMethod]
	public void set_active(bool value) { }

	[NativeMethod]
	public void set_isStatic(bool value) { }

	public void set_layer(int value) { }

	[FreeFunction]
	public void set_tag(string value) { }

	[NativeMethod]
	public void SetActive(bool value) { }

	[NativeMethod]
	[Obsolete]
	public void SetActiveRecursively(bool state) { }

	public bool TryGetComponent(Type type, out Component component) { }

	public bool TryGetComponent(out T component) { }

	[FreeFunction]
	[NativeWritableSelf]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Component TryGetComponentInternal(Type type) { }

}

