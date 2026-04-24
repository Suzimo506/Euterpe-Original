namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal static class CollectionUtils
{
	[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static class EmptyArrayContainer
	{
		[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public static readonly T[] Empty; //Field offset: 0x0

		private static EmptyArrayContainer`1() { }

	}


	[Extension]
	public static void AddRange(IList<T> initial, IEnumerable<T> collection) { }

	public static T[] ArrayEmpty() { }

	[Extension]
	public static bool Contains(List<T> list, T value, IEqualityComparer comparer) { }

	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, Int32[] indices) { }

	[Extension]
	public static void FastReverse(List<T> list) { }

	private static IList<Int32> GetDimensions(IList values, int dimensionsCount) { }

	[Extension]
	public static int IndexOf(IEnumerable<T> collection, Func<T, Boolean> predicate) { }

	[Extension]
	public static int IndexOfReference(List<T> list, T item) { }

	public static bool IsDictionaryType(Type type) { }

	public static bool IsNullOrEmpty(ICollection<T> collection) { }

	private static object JaggedArrayGetValue(IList values, Int32[] indices) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

}

