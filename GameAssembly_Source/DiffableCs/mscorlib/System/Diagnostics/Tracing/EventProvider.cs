namespace System.Diagnostics.Tracing;

internal class EventProvider : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public List<SessionInfo> liveSessionList; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal void <GetSessions>b__0(int etwSessionId, long matchAllKeywords) { }

	}

	internal struct EventData
	{
		internal ulong Ptr; //Field offset: 0x0
		internal uint Size; //Field offset: 0x8
		internal uint Reserved; //Field offset: 0xC

	}

	[AttributeUsage(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private sealed class MonoPInvokeCallbackAttribute : Attribute
	{

		public MonoPInvokeCallbackAttribute(Type t) { }

	}

	internal struct SessionInfo
	{
		internal int sessionIdBit; //Field offset: 0x0
		internal int etwSessionId; //Field offset: 0x4

		internal SessionInfo(int sessionIdBit_, int etwSessionId_) { }

	}

	internal enum WriteEventErrorCode
	{
		NoError = 0,
		NoFreeBuffers = 1,
		EventTooBig = 2,
		NullInput = 3,
		TooManyArgs = 4,
		Other = 5,
	}

	[ThreadStatic]
	private static WriteEventErrorCode s_returnCode; //Field offset: 0x80000000
	private static bool m_setInformationMissing; //Field offset: 0x0
	private static Int32[] nibblebits; //Field offset: 0x8
	private EtwEnableCallback m_etwCallback; //Field offset: 0x10
	private GCHandle m_thisGCHandle; //Field offset: 0x18
	private long m_regHandle; //Field offset: 0x20
	private byte m_level; //Field offset: 0x28
	private long m_anyKeywordMask; //Field offset: 0x30
	private long m_allKeywordMask; //Field offset: 0x38
	private List<SessionInfo> m_liveSessions; //Field offset: 0x40
	private bool m_enabled; //Field offset: 0x48
	private Guid m_providerId; //Field offset: 0x4C
	internal bool m_disposed; //Field offset: 0x5C

	protected EventLevel Level
	{
		 get { } //Length: 5
	}

	protected EventKeywords MatchAnyKeyword
	{
		 get { } //Length: 5
	}

	private static EventProvider() { }

	internal EventProvider() { }

	private static int bitcount(uint n) { }

	private static int bitindex(uint n) { }

	private void Deregister() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	private static object EncodeObject(ref object data, ref EventData* dataDescriptor, ref Byte* dataBuffer, ref uint totalEventSize) { }

	[MonoPInvokeCallback(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private static void EtwEnableCallBack(in Guid sourceId, in int controlCode, in byte setLevel, in long anyKeyword, in long allKeyword, in EVENT_FILTER_DESCRIPTOR* filterData, in Void* callbackContext) { }

	private void EtwEnableCallBackImpl(in int controlCode, in byte setLevel, in long anyKeyword, in long allKeyword, in EVENT_FILTER_DESCRIPTOR* filterData) { }

	private uint EventUnregister() { }

	protected virtual void Finalize() { }

	private static int FindNull(Byte[] buffer, int idx) { }

	protected EventLevel get_Level() { }

	protected EventKeywords get_MatchAnyKeyword() { }

	private bool GetDataFromController(int etwSessionId, EVENT_FILTER_DESCRIPTOR* filterData, out ControllerCommand command, out Byte[] data, out int dataStart) { }

	public static WriteEventErrorCode GetLastWriteEventError() { }

	private void GetSessionInfo(Action<Int32, Int64> action) { }

	private static void GetSessionInfoCallback(int etwSessionId, long matchAllKeywords, ref List<SessionInfo>& sessionList) { }

	private List<Tuple`2<SessionInfo, Boolean>> GetSessions() { }

	private static int IndexOfSessionInList(List<SessionInfo> sessions, int etwSessionId) { }

	public bool IsEnabled(byte level, long keywords) { }

	public bool IsEnabled() { }

	protected override void OnControllerCommand(ControllerCommand command, IDictionary<String, String> arguments, int sessionId, int etwSessionId) { }

	internal void Register(Guid providerGuid) { }

	internal int SetInformation(EVENT_INFO_CLASS eventInfoClass, Void* data, int dataSize) { }

	private static void SetLastError(int error) { }

	internal bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, Object[] eventPayload) { }

	protected private bool WriteEvent(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* childActivityID, int dataCount, IntPtr data) { }

	internal bool WriteEventRaw(ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

}

