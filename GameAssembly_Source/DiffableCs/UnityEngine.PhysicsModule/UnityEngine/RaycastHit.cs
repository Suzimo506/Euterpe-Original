namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[UsedByNativeCode]
public struct RaycastHit
{
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Vector3 m_Point; //Field offset: 0x0
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Vector3 m_Normal; //Field offset: 0xC
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal uint m_FaceID; //Field offset: 0x18
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal float m_Distance; //Field offset: 0x1C
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal Vector2 m_UV; //Field offset: 0x20
	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal int m_Collider; //Field offset: 0x28

	public Collider collider
	{
		 get { } //Length: 164
	}

	public float distance
	{
		 get { } //Length: 8
	}

	public Vector3 normal
	{
		 get { } //Length: 19
	}

	public Vector3 point
	{
		 get { } //Length: 18
	}

	public Rigidbody rigidbody
	{
		 get { } //Length: 183
	}

	public Vector2 textureCoord
	{
		 get { } //Length: 154
	}

	public Transform transform
	{
		 get { } //Length: 240
	}

	[FreeFunction]
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

	public Collider get_collider() { }

	public float get_distance() { }

	public Vector3 get_normal() { }

	public Vector3 get_point() { }

	public Rigidbody get_rigidbody() { }

	public Vector2 get_textureCoord() { }

	public Transform get_transform() { }

}

