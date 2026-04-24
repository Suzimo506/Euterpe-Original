namespace Assets.Scripts.Database;

public abstract class BaseDBConfigObject : ISerialize
{
	protected string m_Text; //Field offset: 0x10
	protected string m_FileName; //Field offset: 0x18
	protected Type m_InfoType; //Field offset: 0x20
	protected Type m_LocalType; //Field offset: 0x28
	[CompilerGenerated]
	private IList <listInterface>k__BackingField; //Field offset: 0x30

	public override int count
	{
		 get { } //Length: 72
	}

	public string fileName
	{
		 get { } //Length: 5
	}

	protected IList listInterface
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public string text
	{
		 get { } //Length: 5
	}

	protected BaseDBConfigObject() { }

	public abstract void Deserialize(string str) { }

	public override bool DeserializeLocal(string fileName, string str, int language) { }

	public override int get_count() { }

	public string get_fileName() { }

	[CompilerGenerated]
	protected IList get_listInterface() { }

	public string get_text() { }

	public object GetValue(int index, string cmpKey) { }

	public object GetValue(string cmpKey, string cmpValue, string targetKey) { }

	public bool LoadConfigFile(string fileName, bool cache, string text) { }

	public override string Serialize() { }

	[CompilerGenerated]
	protected void set_listInterface(IList value) { }

}

