namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DisplayNameAttribute : Attribute
{
	public static readonly DisplayNameAttribute Default; //Field offset: 0x0
	private string _displayName; //Field offset: 0x10

	public override string DisplayName
	{
		 get { } //Length: 5
	}

	protected string DisplayNameValue
	{
		 get { } //Length: 5
	}

	private static DisplayNameAttribute() { }

	public DisplayNameAttribute() { }

	public DisplayNameAttribute(string displayName) { }

	public virtual bool Equals(object obj) { }

	public override string get_DisplayName() { }

	protected string get_DisplayNameValue() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

