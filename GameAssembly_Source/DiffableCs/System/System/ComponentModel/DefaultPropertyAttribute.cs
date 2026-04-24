namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DefaultPropertyAttribute : Attribute
{
	public static readonly DefaultPropertyAttribute Default; //Field offset: 0x0
	private readonly string name; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 5
	}

	private static DefaultPropertyAttribute() { }

	public DefaultPropertyAttribute(string name) { }

	public virtual bool Equals(object obj) { }

	public string get_Name() { }

	public virtual int GetHashCode() { }

}

