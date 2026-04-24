namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class PolygonCollider2D : Collider2D
{

	public void SetPath(int index, Vector2[] points) { }

	[NativeMethod]
	private void SetPath_Internal(int index, Vector2[] points) { }

}

