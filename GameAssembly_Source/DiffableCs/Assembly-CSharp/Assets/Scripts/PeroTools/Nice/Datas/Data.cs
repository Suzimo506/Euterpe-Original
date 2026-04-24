namespace Assets.Scripts.PeroTools.Nice.Datas;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Data : IData, IValue
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, IVariable>, Boolean> <>9__6_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, IVariable>, String> <>9__6_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, IVariable>, IVariable> <>9__6_2; //Field offset: 0x18
		public static Func<KeyValuePair`2<String, IVariable>, Boolean> <>9__14_0; //Field offset: 0x20
		public static Func<KeyValuePair`2<String, IVariable>, String> <>9__14_1; //Field offset: 0x28
		public static Func<KeyValuePair`2<String, IVariable>, IVariable> <>9__14_2; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__14_0(KeyValuePair<String, IVariable> kvp) { }

		internal string <.ctor>b__14_1(KeyValuePair<String, IVariable> kvp) { }

		internal IVariable <.ctor>b__14_2(KeyValuePair<String, IVariable> kvp) { }

		internal bool <set_fields>b__6_0(KeyValuePair<String, IVariable> d) { }

		internal string <set_fields>b__6_1(KeyValuePair<String, IVariable> d) { }

		internal IVariable <set_fields>b__6_2(KeyValuePair<String, IVariable> d) { }

	}

	[SerializeField]
	private string m_Uid; //Field offset: 0x10
	[SerializeField]
	private Dictionary<String, IVariable> m_Fields; //Field offset: 0x18
	private Dictionary<String, IVariable> m_CurFields; //Field offset: 0x20

	public override Dictionary<String, IVariable> fields
	{
		 get { } //Length: 782
		 set { } //Length: 646
	}

	public override IVariable Item
	{
		 get { } //Length: 8
		 set { } //Length: 8
	}

	public override object result
	{
		 get { } //Length: 4
		 set { } //Length: 311
	}

	public string uid
	{
		 get { } //Length: 5
	}

	public Data(string uid, IData data = null) { }

	public Data() { }

	public override Dictionary<String, IVariable> get_fields() { }

	public override IVariable get_Item(string uid) { }

	public override object get_result() { }

	public string get_uid() { }

	public void set_fields(Dictionary<String, IVariable> value) { }

	public override void set_Item(string uid, IVariable value) { }

	public override void set_result(object value) { }

}

