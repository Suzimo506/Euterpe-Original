namespace System.Diagnostics.Tracing;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EventFieldAttribute : Attribute
{
	[CompilerGenerated]
	private EventFieldTags <Tags>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EventFieldFormat <Format>k__BackingField; //Field offset: 0x20

	public EventFieldFormat Format
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	internal string Name
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	public EventFieldTags Tags
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[CompilerGenerated]
	public EventFieldFormat get_Format() { }

	[CompilerGenerated]
	internal string get_Name() { }

	[CompilerGenerated]
	public EventFieldTags get_Tags() { }

}

