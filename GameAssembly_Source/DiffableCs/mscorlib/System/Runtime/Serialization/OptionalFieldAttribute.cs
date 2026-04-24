namespace System.Runtime.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
[ComVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class OptionalFieldAttribute : Attribute
{
	private int versionAdded; //Field offset: 0x10

	public int VersionAdded
	{
		 set { } //Length: 122
	}

	public OptionalFieldAttribute() { }

	public void set_VersionAdded(int value) { }

}

