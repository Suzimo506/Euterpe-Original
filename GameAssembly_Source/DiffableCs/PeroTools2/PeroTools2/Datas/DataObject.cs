namespace PeroTools2.Datas;

[CreateAssetMenu]
[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DataObject : SerializedScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, IVariable>, Boolean> <>9__16_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, IVariable>, String> <>9__16_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, IVariable>, IVariable> <>9__16_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <ToConstance>b__16_0(KeyValuePair<String, IVariable> field) { }

		internal string <ToConstance>b__16_1(KeyValuePair<String, IVariable> field) { }

		internal IVariable <ToConstance>b__16_2(KeyValuePair<String, IVariable> field) { }

	}

	[CompilerGenerated]
	private static readonly JsonSerializerSettings <deserializeSetting>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static readonly JsonSerializerSettings <serializeSetting>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Dictionary<String, IVariable> <fields>k__BackingField; //Field offset: 0x58
	[SerializeField]
	internal bool save; //Field offset: 0x60

	internal static JsonSerializerSettings deserializeSetting
	{
		[CompilerGenerated]
		internal get { } //Length: 86
	}

	internal override bool disableFields
	{
		internal get { } //Length: 3
	}

	[SerializeField]
	internal Dictionary<String, IVariable> fields
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public IVariable Item
	{
		 get { } //Length: 228
		 set { } //Length: 98
	}

	public IEnumerable<String> keyNames
	{
		 get { } //Length: 67
	}

	internal static JsonSerializerSettings serializeSetting
	{
		[CompilerGenerated]
		internal get { } //Length: 183
	}

	private static DataObject() { }

	public DataObject() { }

	private void Awake() { }

	internal static string FieldToJson(Dictionary<String, IVariable> field) { }

	[CompilerGenerated]
	internal static JsonSerializerSettings get_deserializeSetting() { }

	internal override bool get_disableFields() { }

	[CompilerGenerated]
	internal Dictionary<String, IVariable> get_fields() { }

	public IVariable get_Item(string uid) { }

	public IEnumerable<String> get_keyNames() { }

	[CompilerGenerated]
	internal static JsonSerializerSettings get_serializeSetting() { }

	internal static Dictionary<String, IVariable> JsonToField(string json) { }

	internal void Load() { }

	[Obsolete]
	public void LoadFromBytes(Byte[] bytes) { }

	public void LoadFromJson(string json) { }

	public void Reset() { }

	public void Save() { }

	[CompilerGenerated]
	private void set_fields(Dictionary<String, IVariable> value) { }

	public void set_Item(string uid, IVariable value) { }

	[Obsolete]
	public Byte[] ToBytes() { }

	internal Dictionary<String, IVariable> ToConstance() { }

	public string ToJson() { }

}

