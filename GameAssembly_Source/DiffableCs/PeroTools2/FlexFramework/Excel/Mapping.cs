namespace FlexFramework.Excel;

public class Mapping
{
	private object _default; //Field offset: 0x10
	private int _column; //Field offset: 0x18
	[CompilerGenerated]
	private MemberInfo <Member>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Type <Type>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private bool <Fallback>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <Failed>k__BackingField; //Field offset: 0x31

	public int Column
	{
		 get { } //Length: 4
		 set { } //Length: 98
	}

	public object Default
	{
		 get { } //Length: 5
		 set { } //Length: 211
	}

	public bool Failed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Fallback
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private MemberInfo Member
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public private Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public Mapping(MemberInfo member) { }

	public Mapping(MemberInfo member, int column) { }

	public Mapping(MemberInfo member, int column, object default) { }

	public int get_Column() { }

	public object get_Default() { }

	[CompilerGenerated]
	public bool get_Failed() { }

	[CompilerGenerated]
	public bool get_Fallback() { }

	[CompilerGenerated]
	public MemberInfo get_Member() { }

	[CompilerGenerated]
	public Type get_Type() { }

	public void set_Column(int value) { }

	public void set_Default(object value) { }

	[CompilerGenerated]
	public void set_Failed(bool value) { }

	[CompilerGenerated]
	public void set_Fallback(bool value) { }

	[CompilerGenerated]
	private void set_Member(MemberInfo value) { }

	[CompilerGenerated]
	private void set_Type(Type value) { }

}

