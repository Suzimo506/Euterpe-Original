namespace Assets.Scripts.Database;

public abstract class BaseDataObject
{
	[CompilerGenerated]
	private int <listIndex>k__BackingField; //Field offset: 0x10
	protected Dictionary<String, Object> m_MaskValue; //Field offset: 0x18

	public int listIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected BaseDataObject() { }

	public void AddMaskValue(string fieldName, object maskValue) { }

	public override void ClearMaskValue() { }

	[CompilerGenerated]
	public int get_listIndex() { }

	public override void Init(int index) { }

	public void RemoveMaskValue(string fieldName) { }

	[CompilerGenerated]
	protected void set_listIndex(int value) { }

}

