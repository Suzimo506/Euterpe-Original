namespace System.Net;

internal sealed class NetEventSource : EventSource
{
	internal class Keywords
	{
		public const EventKeywords Default = 1; //Field offset: 0x0
		public const EventKeywords Debug = 2; //Field offset: 0x0
		public const EventKeywords EnterExit = 4; //Field offset: 0x0

	}

	public static readonly NetEventSource Log; //Field offset: 0x6A850

	public static bool IsEnabled
	{
		 get { } //Length: 100
	}

	private static NetEventSource() { }

	public NetEventSource() { }

	[NonEvent]
	public static void Enter(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	public static void Error(object thisOrContextObject, object message, string memberName = null) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	public static void Exit(object thisOrContextObject, FormattableString formattableString = null, string memberName = null) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	public static object Format(object value) { }

	[NonEvent]
	private static string Format(FormattableString s) { }

	public static bool get_IsEnabled() { }

	[NonEvent]
	public static int GetHashCode(object value) { }

	[NonEvent]
	public static string IdOf(object value) { }

}

