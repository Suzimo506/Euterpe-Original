namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequiredByNativeCode]
public class Collider : Component
{

	public Rigidbody attachedRigidbody
	{
		[NativeMethod]
		 get { } //Length: 51
	}

	public bool enabled
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	[NativeMethod]
	public Rigidbody get_attachedRigidbody() { }

	public bool get_enabled() { }

	public void set_enabled(bool value) { }

}

