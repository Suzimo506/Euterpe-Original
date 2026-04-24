namespace Assets.Scripts.PeroTools.Nice.Datas;

[CreateAssetMenu]
public class SingletonDataObject : DataObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, IVariable>, String> <>9__4_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, IVariable>, IVariable> <>9__4_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, IVariable>, Boolean> <>9__7_0; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, IVariable>, String> <>9__7_1; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, IVariable>, IVariable> <>9__7_2; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal string <Reload>b__4_0(KeyValuePair<String, IVariable> f) { }

		internal IVariable <Reload>b__4_1(KeyValuePair<String, IVariable> f) { }

		internal bool <ToConstance>b__7_0(KeyValuePair<String, IVariable> field) { }

		internal string <ToConstance>b__7_1(KeyValuePair<String, IVariable> field) { }

		internal IVariable <ToConstance>b__7_2(KeyValuePair<String, IVariable> field) { }

	}

	[SerializeField]
	private bool m_IsSaved; //Field offset: 0x60
	private Dictionary<String, IVariable> m_OriginField; //Field offset: 0x68
	public bool isSync; //Field offset: 0x70

	public SingletonDataObject() { }

	public SingletonDataObject Clone() { }

	public static string FieldToJson(Dictionary<String, IVariable> field) { }

	public static Dictionary<String, IVariable> JsonToField(string json) { }

	public void Load() { }

	[Obsolete]
	public void LoadFromBytes(Byte[] bytes) { }

	public void LoadFromJson(string json) { }

	public void Reload() { }

	public void Reset() { }

	public void Save() { }

	[Obsolete]
	public Byte[] ToBytes() { }

	public Dictionary<String, IVariable> ToConstance() { }

	public string ToJson() { }

}

