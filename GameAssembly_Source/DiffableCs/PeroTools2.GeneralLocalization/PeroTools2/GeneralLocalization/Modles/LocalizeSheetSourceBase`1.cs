namespace PeroTools2.GeneralLocalization.Modles;

public abstract class LocalizeSheetSourceBase : SourceGeneric<T>
{
	[SerializeField]
	private string m_FileName; //Field offset: 0x0
	[SerializeField]
	private string m_UidColumn; //Field offset: 0x0
	[SerializeField]
	private string m_Uid; //Field offset: 0x0
	[SerializeField]
	private string m_TargetColumn; //Field offset: 0x0
	[CompilerGenerated]
	private string <optionName>k__BackingField; //Field offset: 0x0

	public string fileName
	{
		 get { } //Length: 5
	}

	internal string optionName
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public string targetColumn
	{
		 get { } //Length: 5
	}

	public string uid
	{
		 get { } //Length: 5
	}

	public string uidColumn
	{
		 get { } //Length: 5
	}

	[TupleElementNames(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<ValueTuple`2<String, String>> values
	{
		private get { } //Length: 1016
	}

	protected LocalizeSheetSourceBase`1() { }

	protected virtual T DefaultSource(Localization localiation) { }

	public string get_fileName() { }

	[CompilerGenerated]
	internal string get_optionName() { }

	public string get_targetColumn() { }

	public string get_uid() { }

	public string get_uidColumn() { }

	private List<ValueTuple`2<String, String>> get_values() { }

	[CompilerGenerated]
	internal void set_optionName(string value) { }

}

