namespace UnityEngine.Assertions;

[DebuggerStepThrough]
public static class Assert
{
	[Obsolete]
	public static bool raiseExceptions; //Field offset: 0x2C927A8

	private static Assert() { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void AreEqual(T expected, T actual, string message) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void AreEqual(T expected, T actual, string message, IEqualityComparer<T> comparer) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void AreEqual(object expected, object actual, string message) { }

	[Conditional(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public static void AreEqual(int expected, int actual) { }

	private static void Fail(string message, string userMessage) { }

}

