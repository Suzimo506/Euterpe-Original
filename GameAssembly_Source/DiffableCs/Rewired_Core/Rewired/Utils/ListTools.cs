namespace Rewired.Utils;

public static class ListTools
{

	public static int AddAndCreateList(ref IList<T>& list, T item) { }

	public static bool AddIfUnique(IList<T> list, T item) { }

	public static List<T> Combine(IList<T> list1, IList<T> list2) { }

	public static void Concat(IList<T> list1, IList<T> list2) { }

	public static List<Object> ConvertToObjeclist(IList<T> list) { }

	public static bool CopyTo(IList<T> fromList, IList<T> toList) { }

	public static bool CopyTo(IList<T> fromList, IList<T> toList, int fromListStartIndex) { }

	public static bool CopyTo(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count) { }

	public static int Count(IList<T> list, Predicate<T> predicate) { }

	public static T Find(IList<T> list, Predicate<T> predicate) { }

	public static bool IsNullOrEmpty(IList<T> list) { }

	public static bool OffsetAtIndex(IList<T> list, int index, bool offsetDown, bool offsetNow = true) { }

	private static bool OoGPKCoJrCwyUgfOSnFmRFQrNySo(IList<> unnamed_param_0,  unnamed_param_1) { }

	public static List<T> ShallowCopy(List<T> list) { }

	public static T[] ToArray(IList<T> list) { }

	public static void TryClear(IList<T> list) { }

}

