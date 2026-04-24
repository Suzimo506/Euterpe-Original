namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class DefaultEventAttribute : Attribute
{
	public static readonly DefaultEventAttribute Default; //Field offset: 0x0
	private readonly string name; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 5
	}

	private static DefaultEventAttribute() { }

	public DefaultEventAttribute(string name) { }

	public virtual bool Equals(object obj) { }

	public string get_Name() { }

	public virtual int GetHashCode() { }

}

