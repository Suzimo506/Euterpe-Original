namespace LitJson;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
{
	private IList<JsonData> inst_array; //Field offset: 0x10
	private bool inst_boolean; //Field offset: 0x18
	private double inst_double; //Field offset: 0x20
	private int inst_int; //Field offset: 0x28
	private long inst_long; //Field offset: 0x30
	private IDictionary<String, JsonData> inst_object; //Field offset: 0x38
	private string inst_string; //Field offset: 0x40
	private string json; //Field offset: 0x48
	private JsonType type; //Field offset: 0x50
	private IList<KeyValuePair`2<String, JsonData>> object_list; //Field offset: 0x58

	public int Count
	{
		 get { } //Length: 81
	}

	public bool IsArray
	{
		 get { } //Length: 8
	}

	public bool IsBoolean
	{
		 get { } //Length: 8
	}

	public bool IsDouble
	{
		 get { } //Length: 8
	}

	public bool IsInt
	{
		 get { } //Length: 8
	}

	public bool IsLong
	{
		 get { } //Length: 8
	}

	public bool IsObject
	{
		 get { } //Length: 8
	}

	public bool IsString
	{
		 get { } //Length: 8
	}

	public JsonData Item
	{
		 get { } //Length: 182
		 set { } //Length: 680
	}

	public JsonData Item
	{
		 get { } //Length: 341
		 set { } //Length: 643
	}

	public ICollection<String> Keys
	{
		 get { } //Length: 82
	}

	private override bool LitJson.IJsonWrapper.IsArray
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsBoolean
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsDouble
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsInt
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsLong
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsObject
	{
		private get { } //Length: 8
	}

	private override bool LitJson.IJsonWrapper.IsString
	{
		private get { } //Length: 8
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 81
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 81
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 81
	}

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 81
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 81
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 93
		private set { } //Length: 211
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 582
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 582
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 81
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 81
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 181
		private set { } //Length: 75
	}

	private override object System.Collections.Specialized.IOrderedDictionary.Item
	{
		private get { } //Length: 202
		private set { } //Length: 483
	}

	public JsonData(string str) { }

	public JsonData(long number) { }

	public JsonData(int number) { }

	public JsonData(double number) { }

	public JsonData(bool boolean) { }

	public JsonData() { }

	public JsonData(object obj) { }

	public int Add(object value) { }

	public void Clear() { }

	private ICollection EnsureCollection() { }

	private IDictionary EnsureDictionary() { }

	private IList EnsureList() { }

	public override bool Equals(JsonData x) { }

	public int get_Count() { }

	public bool get_IsArray() { }

	public bool get_IsBoolean() { }

	public bool get_IsDouble() { }

	public bool get_IsInt() { }

	public bool get_IsLong() { }

	public bool get_IsObject() { }

	public bool get_IsString() { }

	public JsonData get_Item(int index) { }

	public JsonData get_Item(string prop_name) { }

	public ICollection<String> get_Keys() { }

	public override JsonType GetJsonType() { }

	private override bool LitJson.IJsonWrapper.get_IsArray() { }

	private override bool LitJson.IJsonWrapper.get_IsBoolean() { }

	private override bool LitJson.IJsonWrapper.get_IsDouble() { }

	private override bool LitJson.IJsonWrapper.get_IsInt() { }

	private override bool LitJson.IJsonWrapper.get_IsLong() { }

	private override bool LitJson.IJsonWrapper.get_IsObject() { }

	private override bool LitJson.IJsonWrapper.get_IsString() { }

	private override bool LitJson.IJsonWrapper.GetBoolean() { }

	private override double LitJson.IJsonWrapper.GetDouble() { }

	private override int LitJson.IJsonWrapper.GetInt() { }

	private override long LitJson.IJsonWrapper.GetLong() { }

	private override string LitJson.IJsonWrapper.GetString() { }

	private override void LitJson.IJsonWrapper.SetBoolean(bool val) { }

	private override void LitJson.IJsonWrapper.SetDouble(double val) { }

	private override void LitJson.IJsonWrapper.SetInt(int val) { }

	private override void LitJson.IJsonWrapper.SetLong(long val) { }

	private override void LitJson.IJsonWrapper.SetString(string val) { }

	private override string LitJson.IJsonWrapper.ToJson() { }

	private override void LitJson.IJsonWrapper.ToJson(JsonWriter writer) { }

	public static string op_Explicit(JsonData data) { }

	public static long op_Explicit(JsonData data) { }

	public static int op_Explicit(JsonData data) { }

	public static bool op_Explicit(JsonData data) { }

	public static double op_Explicit(JsonData data) { }

	public static JsonData op_Implicit(string data) { }

	public static JsonData op_Implicit(long data) { }

	public static JsonData op_Implicit(int data) { }

	public static JsonData op_Implicit(bool data) { }

	public static JsonData op_Implicit(double data) { }

	public void set_Item(string prop_name, JsonData value) { }

	public void set_Item(int index, JsonData value) { }

	public override void SetJsonType(JsonType type) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override void System.Collections.IDictionary.Clear() { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	private override object System.Collections.Specialized.IOrderedDictionary.get_Item(int idx) { }

	private override IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator() { }

	private override void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value) { }

	private override void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx) { }

	private override void System.Collections.Specialized.IOrderedDictionary.set_Item(int idx, object value) { }

	public void ToJson(JsonWriter writer) { }

	public string ToJson() { }

	private JsonData ToJsonData(object obj) { }

	public virtual string ToString() { }

	private static void WriteJson(IJsonWrapper obj, JsonWriter writer) { }

}

