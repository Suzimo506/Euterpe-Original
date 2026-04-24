namespace System.Buffers;

[Extension]
public static class BuffersExtensions
{

	[Extension]
	public static void CopyTo(in ReadOnlySequence<T>& source, Span<T> destination) { }

	private static void CopyToMultiSegment(in ReadOnlySequence<T>& sequence, Span<T> destination) { }

	[Extension]
	public static T[] ToArray(in ReadOnlySequence<T>& sequence) { }

}

