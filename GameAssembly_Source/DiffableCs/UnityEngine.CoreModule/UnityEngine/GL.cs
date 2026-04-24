namespace UnityEngine;

[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NativeHeader(/*Cpp2IL Warning: missing at least one required parameter*/)]
[StaticAccessor(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class GL
{

	[FreeFunction]
	public static void Begin(int mode) { }

	public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor) { }

	[FreeFunction]
	public static void End() { }

	[FreeFunction]
	private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth) { }

	private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth) { }

	[FreeFunction]
	public static void LoadOrtho() { }

	[FreeFunction]
	public static void PopMatrix() { }

	[FreeFunction]
	public static void PushMatrix() { }

	public static void TexCoord2(float x, float y) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void TexCoord3(float x, float y, float z) { }

	[NativeName(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void Vertex3(float x, float y, float z) { }

}

