namespace Assets.Scripts.PeroTools.Nice.Datas;

[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DataManager : Singleton<DataManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public string name; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal string <GetUids>b__0(KeyValuePair<String, IVariable> field) { }

	}

	private const int m_Version = 8; //Field offset: 0x0
	private const char splitChar = '\u2F'; //Field offset: 0x0
	[CompilerGenerated]
	private Dictionary<String, IData> <datas>k__BackingField; //Field offset: 0x10
	private ISync m_PlatformISync; //Field offset: 0x18

	public private Dictionary<String, IData> datas
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public SingletonDataObject Item
	{
		 get { } //Length: 319
		 set { } //Length: 206
	}

	public DataManager() { }

	private void FixSave() { }

	[CompilerGenerated]
	public Dictionary<String, IData> get_datas() { }

	public SingletonDataObject get_Item(string uid) { }

	public List<String> GetUids() { }

	public IVariable GetVariable(string uid) { }

	public void Init() { }

	protected void Load() { }

	protected override void LoadData() { }

	[Obsolete]
	public void LoadFromBytes(Byte[] bytes) { }

	public void LoadFromJson(string json) { }

	private void LoadInit() { }

	public void Reset() { }

	public void Save() { }

	[CompilerGenerated]
	private void set_datas(Dictionary<String, IData> value) { }

	public void set_Item(string uid, SingletonDataObject value) { }

	public void SetVariable(string uid, IVariable variable) { }

	[Obsolete]
	public Byte[] ToBytes() { }

	public string ToJson() { }

	private void VersionCheckUp() { }

}

