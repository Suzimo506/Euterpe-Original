namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class object
{
	internal static int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x10

	public HideFlags hideFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public string name
	{
		 get { } //Length: 108
		 set { } //Length: 123
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[NativeMethod]
	private static bool CurrentThreadIsMainThread() { }

	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	[NativeMethod]
	public static void Destroy(object obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[NativeMethod]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	[Obsolete]
	public static void DestroyObject(object obj, float t) { }

	[ExcludeFromDocs]
	[Obsolete]
	public static void DestroyObject(object obj) { }

	[NativeMethod]
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunction]
	public static void DontDestroyOnLoad(object target) { }

	private void EnsureRunningOnMainThread() { }

	public virtual bool Equals(object other) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object FindObjectOfType(Type type) { }

	public static T FindObjectOfType() { }

	public static T[] FindObjectsOfType() { }

	[FreeFunction]
	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static Object[] FindObjectsOfType(Type type) { }

	[Obsolete]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction]
	[Obsolete]
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	[FreeFunction]
	[Obsolete]
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[FreeFunction]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	public HideFlags get_hideFlags() { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction]
	private static string GetName(object obj) { }

	[NativeMethod]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	public static T Instantiate(T original, Transform parent) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Instantiate(object original, Transform parent) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Instantiate(object original) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[FreeFunction]
	private static object Internal_CloneSingle(object data) { }

	[FreeFunction]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction]
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingle_Injected(object data, ref Vector3 pos, ref Quaternion rot) { }

	[FreeFunction]
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static object Internal_InstantiateSingleWithParent_Injected(object data, Transform parent, ref Vector3 pos, ref Quaternion rot) { }

	private static bool IsNativeObjectAlive(object o) { }

	[FreeFunction]
	internal static bool IsPersistent(object obj) { }

	public static bool op_Equality(object x, object y) { }

	public static bool op_Implicit(object exists) { }

	public static bool op_Inequality(object x, object y) { }

	public void set_hideFlags(HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction]
	private static void SetName(object obj, string name) { }

	public virtual string ToString() { }

	[FreeFunction]
	private static string ToString(object obj) { }

}

