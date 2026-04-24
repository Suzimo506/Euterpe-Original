namespace System.ComponentModel;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class DefaultValueAttribute : Attribute
{
	private object value; //Field offset: 0x10

	public override object Value
	{
		 get { } //Length: 5
	}

	public DefaultValueAttribute(int value) { }

	public DefaultValueAttribute(long value) { }

	public DefaultValueAttribute(bool value) { }

	public DefaultValueAttribute(string value) { }

	public DefaultValueAttribute(object value) { }

	public virtual bool Equals(object obj) { }

	public override object get_Value() { }

	public virtual int GetHashCode() { }

}

