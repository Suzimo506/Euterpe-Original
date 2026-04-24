namespace System.Diagnostics.Tracing;

[EventSource]
internal class TplEtwProvider : EventSource
{
	internal class Keywords
	{
		public const EventKeywords Debug = 1; //Field offset: 0x0

	}

	public static TplEtwProvider Log; //Field offset: 0x6B21C

	public bool Debug
	{
		 get { } //Length: 16
	}

	private static TplEtwProvider() { }

	public TplEtwProvider() { }

	public void DebugFacilityMessage(string Facility, string Message) { }

	public void DebugFacilityMessage1(string Facility, string Message, string Arg) { }

	public bool get_Debug() { }

	public void SetActivityId(Guid Id) { }

}

