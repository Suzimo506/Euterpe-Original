namespace Rewired.Utils;

[CustomClassObfuscation]
[CustomObfuscation]
internal static class CollectionTools
{

	public static void AddValueSafe(Dictionary<String, Object> data, string key, object value) { }

	public static Dictionary<TValue, TKey> CreateInverseDictionary(Dictionary<TKey, TValue> dict) { }

	public static TReturn GetDictionaryValueSafe(Dictionary<String, Object> dictionary, string key) { }

	public static TReturn GetDictionaryValueSafe(Dictionary<String, Object> dictionary, string key, out bool success) { }

	public static TValue GetDictionaryValueSafe(Dictionary<TKey, TValue> dictionary, TKey key) { }

	public static TValue GetDictionaryValueSafe(Dictionary<TKey, TValue> dictionary, TKey key, out bool success) { }

	public static bool GetDictionaryValueSafe(Dictionary<String, Object> dictionary, string key, ref TReturn value) { }

	public static bool GetDictionaryValueSafe(Dictionary<String, Object> dictionary, string key, Type type, ref object value) { }

	public static bool GetDictionaryValueSafe_float(Dictionary<String, Object> dictionary, string key, ref float value) { }

	public static bool GetDictionaryValueSafe_int(Dictionary<String, Object> dictionary, string key, ref int value) { }

	public static T GetValue(IEnumerable<T> enumerable, int index) { }

	public static T GetValue(IEnumerable enumerable, int index) { }

}

