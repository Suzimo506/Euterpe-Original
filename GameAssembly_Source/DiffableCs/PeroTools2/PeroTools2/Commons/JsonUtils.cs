namespace PeroTools2.Commons;

[Extension]
public static class JsonUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<JToken, String> <>9__2_0; //Field offset: 0x8
		public static Func<JToken, String> <>9__7_0; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Object>, <>f__AnonymousType0`2<KeyValuePair`2<String, Object>, String>> <>9__9_0; //Field offset: 0x18
		public static Func<<>f__AnonymousType0`2<KeyValuePair`2<String, Object>, String>, String> <>9__9_3; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal <>f__AnonymousType0<KeyValuePair`2<String, Object>, String> <DiffProperty>b__9_0(KeyValuePair<String, Object> kvp) { }

		internal string <DiffProperty>b__9_3(<>f__AnonymousType0<KeyValuePair`2<String, Object>, String> <>h__TransparentIdentifier0) { }

		internal string <Keys>b__7_0(JToken t) { }

		internal string <Paths>b__2_0(JToken t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <ArrayDepth>b__0(JToken c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass5_0() { }

		internal bool <GetValue>b__0(JToken c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Dictionary<String, Object> newDic; //Field offset: 0x10
		public object value; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <DiffProperty>b__1(<>f__AnonymousType0<KeyValuePair`2<String, Object>, String> <>h__TransparentIdentifier0) { }

		internal bool <DiffProperty>b__2(<>f__AnonymousType0<KeyValuePair`2<String, Object>, String> <>h__TransparentIdentifier0) { }

	}


	public static int ArrayDepth(JToken jToken, string path) { }

	[Extension]
	public static object Clone(object obj) { }

	public static object Deserialize(string json) { }

	public static object Deserialize(string json, Type type, JsonSerializerSettings setting = null) { }

	public static T Deserialize(string json, JsonSerializerSettings setting = null) { }

	public static T DeserializeByJson(string jsonName, JsonSerializerSettings setting = null) { }

	public static List<String> DiffProperty(object newValue, object oldValue) { }

	public static JToken GetValue(JToken jToken, string path, Int32[] idxs) { }

	[Extension]
	public static bool IsNullOrEmpty(JToken token) { }

	[Extension]
	public static List<String> Keys(JToken jToken) { }

	[Extension]
	public static string Name(JToken jToken) { }

	private static void PathCallback(List<JToken> tokens, JToken token, JTokenType[] types) { }

	public static List<String> Paths(JToken jToken, JTokenType[] types) { }

	public static string Serialize(T target, JsonSerializerSettings setting = null) { }

	public static JArray ToArray(string json) { }

	public static Dictionary<String, Object> ToDictionary(object obj) { }

	public static JObject ToObject(string json) { }

	[Extension]
	public static object UnityClone(object obj) { }

}

