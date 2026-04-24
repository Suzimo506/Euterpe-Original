namespace UnityEngine;

[NativeClass(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class Component : object
{

	public GameObject gameObject
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Transform transform
	{
		[FreeFunction]
		 get { } //Length: 51
	}

	public Component() { }

	[FreeFunction]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	[FreeFunction]
	public GameObject get_gameObject() { }

	[FreeFunction]
	public Transform get_transform() { }

	public T GetComponent() { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponent(Type type) { }

	[FreeFunction]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	public T GetComponentInParent() { }

	[TypeInferenceRule(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public Component GetComponentInParent(Type t) { }

	public void GetComponents(Type type, List<Component> results) { }

	public void GetComponents(List<T> results) { }

	public T[] GetComponents() { }

	[FreeFunction]
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(List<T> results) { }

	public Component[] GetComponentsInChildren(Type t, bool includeInactive) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> result) { }

	public T[] GetComponentsInChildren() { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public T[] GetComponentsInParent() { }

	[FreeFunction]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	public bool TryGetComponent(out T component) { }

}

