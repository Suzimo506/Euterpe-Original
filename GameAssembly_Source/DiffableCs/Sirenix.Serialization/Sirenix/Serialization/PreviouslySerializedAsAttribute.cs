namespace Sirenix.Serialization;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PreviouslySerializedAsAttribute : Attribute
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10

	public private string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 12
	}

	public PreviouslySerializedAsAttribute(string name) { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	private void set_Name(string value) { }

}

