namespace Spine.Collections;

[Extension]
public static class CollectionExtensions
{

	[Extension]
	public static OrderedDictionary<TKey, TSource> ToOrderedDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector) { }

	[Extension]
	public static OrderedDictionary<TKey, TSource> ToOrderedDictionary(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer) { }

}

