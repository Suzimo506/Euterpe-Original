namespace System.Diagnostics.Tracing;

public struct EventSourceOptions
{
	internal EventKeywords keywords; //Field offset: 0x0
	internal EventTags tags; //Field offset: 0x8
	internal EventActivityOptions activityOptions; //Field offset: 0xC
	internal byte level; //Field offset: 0x10
	internal byte opcode; //Field offset: 0x11
	internal byte valuesSet; //Field offset: 0x12

	public EventKeywords Keywords
	{
		 set { } //Length: 8
	}

	public EventLevel Level
	{
		 set { } //Length: 89
	}

	public EventOpcode Opcode
	{
		 set { } //Length: 89
	}

	public void set_Keywords(EventKeywords value) { }

	public void set_Level(EventLevel value) { }

	public void set_Opcode(EventOpcode value) { }

}

