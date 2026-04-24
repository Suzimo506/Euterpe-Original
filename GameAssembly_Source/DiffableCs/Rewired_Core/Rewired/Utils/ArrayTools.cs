namespace Rewired.Utils;

public static class ArrayTools
{

	public static T[] Add(T[] array, T item) { }

	public static int Add(ref T[] array, T item) { }

	public static T[] AddIfUnique(T[] array, T item) { }

	public static int AddIfUnique(ref String[] array, string item, bool ignoreCase) { }

	public static int AddIfUnique(ref T[] array, T item) { }

	public static T[] Combine(T[] array1, T[] array2) { }

	public static String[] Combine(String[] inArray1, String[] inArray2) { }

	public static Single[] Combine(Single[] inArray1, Single[] inArray2) { }

	public static void Combine(ref T[] array1, T[] array2) { }

	public static Byte[] Combine(Byte[] inArray1, Byte[] inArray2) { }

	public static Int32[] Combine(Int32[] inArray1, Int32[] inArray2) { }

	public static void Compact(ref T[] array) { }

	public static bool Contains(T[] array, T item) { }

	public static bool Contains(String[] array, string item, bool ignoreCase) { }

	public static Int32[] ConvertToIntArray(Array array) { }

	public static Single[] CopyRange(Single[] inArray, int startPos, int length) { }

	public static Int32[] CopyRange(Int32[] inArray, int startPos, int length) { }

	public static Byte[] CopyRange(Byte[] inArray, int startPos, int length) { }

	public static String[] CopyRange(String[] inArray, int startPos, int length) { }

	public static int Count(T[] array, Predicate<T> predicate) { }

	public static T[] DeepClone(T[] array) { }

	public static void Expand(ref T[] array, int length) { }

	public static void Fill(T[] array, T value, int startIndex) { }

	public static void Fill(T[] array, T value) { }

	public static void Fill(T[] array, T value, int startIndex, int length) { }

	public static T Find(T[] array, Predicate<T> predicate) { }

	public static int IndexOf(UInt32[] array, uint value) { }

	public static int IndexOf(String[] array, string value, StringComparison stringComparison) { }

	public static int IndexOf(String[] array, string value) { }

	public static int IndexOf(Boolean[] array, bool value) { }

	public static int IndexOf(T[] array, T item) { }

	public static int IndexOf(Double[] array, double value) { }

	public static int IndexOf(UInt16[] array, ushort value) { }

	public static int IndexOf(Int16[] array, short value) { }

	public static int IndexOf(Single[] array, float value) { }

	public static int IndexOf(Int32[] array, int value) { }

	public static T[] Insert(T[] array, int index, T item) { }

	public static int Insert(ref T[] array, int index, T item) { }

	public static bool IsEqual(Byte[] a1, Byte[] a2) { }

	public static bool IsNullOrEmpty(T[] array) { }

	public static void MoveEntryDown(T[] array, int index) { }

	public static void MoveEntryUp(T[] array, int index) { }

	public static T[] ParseArray(string line) { }

	public static void Populate(T[] array, int startIndex, int length) { }

	public static void Populate(T[] array, Func<T> instantiator) { }

	public static void Populate(T[] array, int startIndex, int length, Func<T> instantiator) { }

	public static void Populate(T[] array) { }

	public static bool Remove(ref String[] array, string item, bool ignoreCase) { }

	public static bool Remove(ref T[] array, T item) { }

	public static T[] Remove(T[] array, T item) { }

	public static bool RemoveAt(ref T[] array, int index) { }

	public static T[] RemoveAt(T[] array, int index) { }

	public static void RemoveDuplicates(ref String[] array, bool ignoreCase) { }

	public static T[] ShallowCopy(T[] array) { }

	public static void ShallowCopy(T[] sourceArray, T[] targetArray) { }

	public static void ShallowCopy(Int32[] sourceArray, Int32[] targetArray) { }

	public static void ShallowCopy(Boolean[] sourceArray, Boolean[] targetArray) { }

	public static void ShallowCopy(Single[] sourceArray, Single[] targetArray) { }

	public static T[] SortAscending(T[] array, out Int32[] sortedIndices) { }

	public static T[] SortDescending(T[] array, out Int32[] sortedIndices, bool ascending = true) { }

	public static RaycastHit[] SortNearToFar(RaycastHit[] hits) { }

	public static bool SubArray(ref T[] array, int startIndex) { }

	public static bool SubArray(ref T[] array, int startIndex, int count) { }

	public static int ToBitmask(Boolean[] array, int startIndex, int count = 32) { }

	public static String[] ToLowerStripSpaces(String[] array) { }

	public static void Trim(String[] array) { }

}

