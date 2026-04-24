namespace System.Data;

[EventSource]
internal class DataCommonEventSource : EventSource
{
	internal static readonly DataCommonEventSource Log; //Field offset: 0x0
	private static long s_nextScopeId; //Field offset: 0x8

	private static DataCommonEventSource() { }

	public DataCommonEventSource() { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal long EnterScope(string message) { }

	[NonEvent]
	internal long EnterScope(string format, T1 arg1) { }

	[NonEvent]
	internal long EnterScope(string format, T1 arg1, T2 arg2) { }

	[NonEvent]
	internal long EnterScope(string format, T1 arg1, T2 arg2, T3 arg3) { }

	[NonEvent]
	internal long EnterScope(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void ExitScope(long scopeId) { }

	[Event(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal void Trace(string message) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0, T1 arg1) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }

	[NonEvent]
	internal void Trace(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }

}

