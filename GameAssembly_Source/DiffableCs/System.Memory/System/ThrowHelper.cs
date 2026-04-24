namespace System;

internal static class ThrowHelper
{

	private static Exception CreateArgumentException_DestinationTooShort() { }

	private static Exception CreateArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	private static Exception CreateArgumentNullException(ExceptionArgument argument) { }

	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument) { }

	private static Exception CreateArgumentOutOfRangeException() { }

	private static Exception CreateArgumentOutOfRangeException_OffsetOutOfRange() { }

	private static Exception CreateArgumentOutOfRangeException_PositionOutOfRange() { }

	private static Exception CreateArgumentValidationException(Array array, int start) { }

	private static Exception CreateArgumentValidationException(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) { }

	private static Exception CreateArrayTypeMismatchException() { }

	private static Exception CreateIndexOutOfRangeException() { }

	private static Exception CreateInvalidOperationException() { }

	private static Exception CreateInvalidOperationException_EndPositionNotReached() { }

	private static Exception CreateStartOrEndArgumentValidationException(long start) { }

	internal static void ThrowArgumentException_DestinationTooShort() { }

	internal static void ThrowArgumentException_InvalidTypeWithPointersNotSupported(Type type) { }

	internal static void ThrowArgumentNullException(ExceptionArgument argument) { }

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument) { }

	internal static void ThrowArgumentOutOfRangeException() { }

	internal static void ThrowArgumentOutOfRangeException_OffsetOutOfRange() { }

	internal static void ThrowArgumentOutOfRangeException_PositionOutOfRange() { }

	public static void ThrowArgumentValidationException(ReadOnlySequenceSegment<T> startSegment, int startIndex, ReadOnlySequenceSegment<T> endSegment) { }

	public static void ThrowArgumentValidationException(Array array, int start) { }

	internal static void ThrowArrayTypeMismatchException() { }

	internal static void ThrowIndexOutOfRangeException() { }

	internal static void ThrowInvalidOperationException() { }

	internal static void ThrowInvalidOperationException_EndPositionNotReached() { }

	public static void ThrowStartOrEndArgumentValidationException(long start) { }

}

