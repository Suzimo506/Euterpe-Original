namespace FlexFramework.Excel;

public struct Range : IEquatable<Range>
{
	[CompilerGenerated]
	private Address <From>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Address <To>k__BackingField; //Field offset: 0x8

	public private Address From
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Address To
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Range(Address from, Address to) { }

	public Range(string range) { }

	public bool Contains(Address address) { }

	public bool Contains(Range range) { }

	public override bool Equals(Range other) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public Address get_From() { }

	[CompilerGenerated]
	public Address get_To() { }

	public virtual int GetHashCode() { }

	public static bool IsValid(string range) { }

	public static bool op_Equality(Range range, Range other) { }

	public static bool op_Inequality(Range range, Range other) { }

	[CompilerGenerated]
	private void set_From(Address value) { }

	[CompilerGenerated]
	private void set_To(Address value) { }

	public virtual string ToString() { }

}

