namespace Newtonsoft.Json.Utilities;

[Nullable(/*Cpp2IL Warning: missing at least one required parameter*/)]
[NullableContext(/*Cpp2IL Warning: missing at least one required parameter*/)]
internal class ThreadSafeStore
{
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; //Field offset: 0x0
	private readonly Func<TKey, TValue> _creator; //Field offset: 0x0

	public ThreadSafeStore`2(Func<TKey, TValue> creator) { }

	public TValue Get(TKey key) { }

}

