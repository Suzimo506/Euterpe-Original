namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class Gizmos
{

	public static Color color
	{
		 set { } //Length: 51
	}

	public static Matrix4x4 matrix
	{
		 set { } //Length: 51
	}

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	[NativeThrows]
	public static void DrawSphere(Vector3 center, float radius) { }

	private static void DrawSphere_Injected(ref Vector3 center, float radius) { }

	[NativeThrows]
	public static void DrawWireCube(Vector3 center, Vector3 size) { }

	private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size) { }

	[NativeThrows]
	public static void DrawWireSphere(Vector3 center, float radius) { }

	private static void DrawWireSphere_Injected(ref Vector3 center, float radius) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

	public static void set_matrix(Matrix4x4 value) { }

	private static void set_matrix_Injected(ref Matrix4x4 value) { }

}

