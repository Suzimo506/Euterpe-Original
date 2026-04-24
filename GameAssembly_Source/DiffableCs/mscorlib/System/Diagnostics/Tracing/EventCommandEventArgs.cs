namespace System.Diagnostics.Tracing;

public class EventCommandEventArgs : EventArgs
{
	[CompilerGenerated]
	private EventCommand <Command>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private IDictionary<String, String> <Arguments>k__BackingField; //Field offset: 0x18
	internal EventSource eventSource; //Field offset: 0x20
	internal EventDispatcher dispatcher; //Field offset: 0x28
	internal EventListener listener; //Field offset: 0x30
	internal int perEventSourceSessionId; //Field offset: 0x38
	internal int etwSessionId; //Field offset: 0x3C
	internal bool enable; //Field offset: 0x40
	internal EventLevel level; //Field offset: 0x44
	internal EventKeywords matchAnyKeyword; //Field offset: 0x48
	internal EventCommandEventArgs nextCommand; //Field offset: 0x50

	public internal IDictionary<String, String> Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	public internal EventCommand Command
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal EventCommandEventArgs(EventCommand command, IDictionary<String, String> arguments, EventSource eventSource, EventListener listener, int perEventSourceSessionId, int etwSessionId, bool enable, EventLevel level, EventKeywords matchAnyKeyword) { }

	[CompilerGenerated]
	public IDictionary<String, String> get_Arguments() { }

	[CompilerGenerated]
	public EventCommand get_Command() { }

	[CompilerGenerated]
	internal void set_Arguments(IDictionary<String, String> value) { }

	[CompilerGenerated]
	internal void set_Command(EventCommand value) { }

}

