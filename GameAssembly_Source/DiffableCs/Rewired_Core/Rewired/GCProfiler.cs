namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class GCProfiler
{

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void Begin(string name) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void Clear() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void End() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void LogReport() { }

}

