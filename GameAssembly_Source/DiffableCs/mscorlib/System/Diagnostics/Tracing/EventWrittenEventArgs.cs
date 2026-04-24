namespace System.Diagnostics.Tracing;

public class EventWrittenEventArgs : EventArgs
{
	[CompilerGenerated]
	private int <EventId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Guid <RelatedActivityId>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private ReadOnlyCollection<Object> <Payload>k__BackingField; //Field offset: 0x28
	private string m_message; //Field offset: 0x30
	private string m_eventName; //Field offset: 0x38
	private EventSource m_eventSource; //Field offset: 0x40
	private ReadOnlyCollection<String> m_payloadNames; //Field offset: 0x48

	internal int EventId
	{
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	internal string EventName
	{
		internal set { } //Length: 12
	}

	internal string Message
	{
		internal set { } //Length: 12
	}

	internal ReadOnlyCollection<Object> Payload
	{
		[CompilerGenerated]
		internal set { } //Length: 12
	}

	internal ReadOnlyCollection<String> PayloadNames
	{
		internal set { } //Length: 12
	}

	internal Guid RelatedActivityId
	{
		[CompilerGenerated]
		internal set { } //Length: 8
	}

	internal EventWrittenEventArgs(EventSource eventSource) { }

	[CompilerGenerated]
	internal void set_EventId(int value) { }

	internal void set_EventName(string value) { }

	internal void set_Message(string value) { }

	[CompilerGenerated]
	internal void set_Payload(ReadOnlyCollection<Object> value) { }

	internal void set_PayloadNames(ReadOnlyCollection<String> value) { }

	[CompilerGenerated]
	internal void set_RelatedActivityId(Guid value) { }

}

