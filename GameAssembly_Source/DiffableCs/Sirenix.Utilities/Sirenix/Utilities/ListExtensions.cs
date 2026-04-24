namespace Sirenix.Utilities;

[Extension]
public static class ListExtensions
{

	public static void SetLength(ref IList<T>& list, int length) { }

	public static void SetLength(ref IList<T>& list, int length, Func<T> newElement) { }

	[Extension]
	public static void SetLength(IList<T> list, int length) { }

	[Extension]
	public static void SetLength(IList<T> list, int length, Func<T> newElement) { }

}

