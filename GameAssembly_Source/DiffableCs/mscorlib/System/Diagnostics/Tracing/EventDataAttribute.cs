namespace System.Diagnostics.Tracing;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EventDataAttribute : Attribute
{
	private EventLevel level; //Field offset: 0x10
	private EventOpcode opcode; //Field offset: 0x14
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private EventTags <Tags>k__BackingField; //Field offset: 0x28

	internal EventKeywords Keywords
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal EventLevel Level
	{
		internal get { } //Length: 4
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal EventOpcode Opcode
	{
		internal get { } //Length: 4
	}

	internal EventTags Tags
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	[CompilerGenerated]
	internal EventKeywords get_Keywords() { }

	internal EventLevel get_Level() { }

	[CompilerGenerated]
	public string get_Name() { }

	internal EventOpcode get_Opcode() { }

	[CompilerGenerated]
	internal EventTags get_Tags() { }

}

