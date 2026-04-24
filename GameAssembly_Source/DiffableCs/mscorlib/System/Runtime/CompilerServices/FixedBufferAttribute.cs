namespace System.Runtime.CompilerServices;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class FixedBufferAttribute : Attribute
{
	private Type elementType; //Field offset: 0x10
	private int length; //Field offset: 0x18

	public Type ElementType
	{
		 get { } //Length: 5
	}

	public int Length
	{
		 get { } //Length: 4
	}

	public FixedBufferAttribute(Type elementType, int length) { }

	public Type get_ElementType() { }

	public int get_Length() { }

}

