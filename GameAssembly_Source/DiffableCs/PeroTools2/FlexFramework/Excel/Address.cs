namespace FlexFramework.Excel;

public struct Address : IEquatable<Address>
{
	[CompilerGenerated]
	private int <Column>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Row>k__BackingField; //Field offset: 0x4

	public private int Column
	{
		[CompilerGenerated]
		 get { } //Length: 3
		[CompilerGenerated]
		private set { } //Length: 3
	}

	public string ColumnName
	{
		 get { } //Length: 9
	}

	public private int Row
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Address(string address) { }

	public Address(int column, int row) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public int get_Column() { }

	public string get_ColumnName() { }

	[CompilerGenerated]
	public int get_Row() { }

	public virtual int GetHashCode() { }

	public static bool IsValid(string address) { }

	public static Address op_Addition(Address address, int row) { }

	public static Range op_Addition(Address from, Address to) { }

	public static bool op_Equality(Address address, Address other) { }

	public static bool op_GreaterThan(Address address, Address other) { }

	public static bool op_GreaterThanOrEqual(Address address, Address other) { }

	public static bool op_Inequality(Address address, Address other) { }

	public static Address op_LeftShift(Address address, int column) { }

	public static bool op_LessThan(Address address, Address other) { }

	public static bool op_LessThanOrEqual(Address address, Address other) { }

	public static Address op_RightShift(Address address, int column) { }

	public static Address op_Subtraction(Address address, int row) { }

	public static string ParseColumn(int column) { }

	public static int ParseColumn(string column) { }

	[CompilerGenerated]
	private void set_Column(int value) { }

	[CompilerGenerated]
	private void set_Row(int value) { }

	private override bool System.IEquatable<FlexFramework.Excel.Address>.Equals(Address other) { }

	public virtual string ToString() { }

}

