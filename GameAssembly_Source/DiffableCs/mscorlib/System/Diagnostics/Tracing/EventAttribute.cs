namespace System.Diagnostics.Tracing;

[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class EventAttribute : Attribute
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private EventTask <Task>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private byte <Version>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private EventTags <Tags>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private EventActivityOptions <ActivityOptions>k__BackingField; //Field offset: 0x34
	private EventOpcode m_opcode; //Field offset: 0x38
	private bool m_opcodeSet; //Field offset: 0x3C

	public EventActivityOptions ActivityOptions
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private int EventId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal bool IsOpcodeSet
	{
		internal get { } //Length: 5
	}

	public EventKeywords Keywords
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public EventLevel Level
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 12
	}

	public EventOpcode Opcode
	{
		 get { } //Length: 4
		 set { } //Length: 8
	}

	public EventTags Tags
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public EventTask Task
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public byte Version
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EventAttribute(int eventId) { }

	[CompilerGenerated]
	public EventActivityOptions get_ActivityOptions() { }

	[CompilerGenerated]
	public int get_EventId() { }

	internal bool get_IsOpcodeSet() { }

	[CompilerGenerated]
	public EventKeywords get_Keywords() { }

	[CompilerGenerated]
	public EventLevel get_Level() { }

	[CompilerGenerated]
	public string get_Message() { }

	public EventOpcode get_Opcode() { }

	[CompilerGenerated]
	public EventTags get_Tags() { }

	[CompilerGenerated]
	public EventTask get_Task() { }

	[CompilerGenerated]
	public byte get_Version() { }

	[CompilerGenerated]
	public void set_ActivityOptions(EventActivityOptions value) { }

	[CompilerGenerated]
	private void set_EventId(int value) { }

	[CompilerGenerated]
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	public void set_Opcode(EventOpcode value) { }

	[CompilerGenerated]
	public void set_Task(EventTask value) { }

}

