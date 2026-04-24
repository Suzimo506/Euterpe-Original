namespace FlexFramework.Excel;

public class Cell : ICloneable<Cell>
{
	[CompilerGenerated]
	private Address <Address>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private object <Value>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsSpan>k__BackingField; //Field offset: 0x20

	public Address Address
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool Boolean
	{
		 get { } //Length: 166
	}

	public double Double
	{
		 get { } //Length: 167
	}

	public int Integer
	{
		 get { } //Length: 165
	}

	public bool IsBoolean
	{
		 get { } //Length: 73
	}

	public bool IsDouble
	{
		 get { } //Length: 73
	}

	public bool IsInteger
	{
		 get { } //Length: 73
	}

	public bool IsSingle
	{
		 get { } //Length: 73
	}

	public bool IsSpan
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsString
	{
		 get { } //Length: 73
	}

	public float Single
	{
		 get { } //Length: 167
	}

	public string String
	{
		 get { } //Length: 165
	}

	public override string Text
	{
		 get { } //Length: 108
	}

	public object Value
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public Cell(double value, Address address) { }

	public Cell(float value, Address address) { }

	public Cell() { }

	public Cell(Address address) { }

	public Cell(string value, Address address) { }

	public Cell(bool value, Address address) { }

	public Cell(int value, Address address) { }

	public Cell(long value, Address address) { }

	public override Cell DeepClone() { }

	[CompilerGenerated]
	public Address get_Address() { }

	public bool get_Boolean() { }

	public double get_Double() { }

	public int get_Integer() { }

	public bool get_IsBoolean() { }

	public bool get_IsDouble() { }

	public bool get_IsInteger() { }

	public bool get_IsSingle() { }

	[CompilerGenerated]
	public bool get_IsSpan() { }

	public bool get_IsString() { }

	public float get_Single() { }

	public string get_String() { }

	public override string get_Text() { }

	[CompilerGenerated]
	public object get_Value() { }

	public static float op_Implicit(Cell cell) { }

	public static string op_Implicit(Cell cell) { }

	public static int op_Implicit(Cell cell) { }

	public static bool op_Implicit(Cell cell) { }

	public static double op_Implicit(Cell cell) { }

	[CompilerGenerated]
	public void set_Address(Address value) { }

	[CompilerGenerated]
	public void set_IsSpan(bool value) { }

	[CompilerGenerated]
	public void set_Value(object value) { }

	public override Cell ShallowClone() { }

	public virtual string ToString() { }

}

