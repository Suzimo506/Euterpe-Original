namespace Assets.Scripts.PeroTools.Managers;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ConstanceManager : SingletonScriptableObject<ConstanceManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass2_0() { }

		internal bool <get_Item>b__0(ConstanceInfo c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string key; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <Get>b__0(ConstanceInfo c) { }

	}

	internal class ConstanceInfo
	{
		public string key; //Field offset: 0x10
		public string value; //Field offset: 0x18
		public string description; //Field offset: 0x20

		public ConstanceInfo() { }

	}

	public List<ConstanceInfo> constances; //Field offset: 0x58

	public string Item
	{
		 get { } //Length: 372
	}

	public ConstanceManager() { }

	public ConstanceInfo Get(string key) { }

	public string get_Item(string key) { }

	public bool GetBool(string key) { }

	public decimal GetDecimal(string key) { }

	public float GetFloat(string key) { }

	public int GetInt(string key) { }

}

