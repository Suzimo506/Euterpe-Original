namespace System.Diagnostics.Tracing;

public class EventSource : IDisposable
{
	private struct EventData
	{
		internal long m_Ptr; //Field offset: 0x0
		internal int m_Size; //Field offset: 0x8
		internal int m_Reserved; //Field offset: 0xC

		public IntPtr DataPointer
		{
			 get { } //Length: 10
			 set { } //Length: 31
		}

		public int Size
		{
			 set { } //Length: 4
		}

		public IntPtr get_DataPointer() { }

		public void set_DataPointer(IntPtr value) { }

		public void set_Size(int value) { }

		internal void SetMetadata(Byte* pointer, int size, int reserved) { }

	}

	public struct EventMetadata
	{
		public EventDescriptor Descriptor; //Field offset: 0x0
		public EventTags Tags; //Field offset: 0x10
		public bool EnabledForAnyListener; //Field offset: 0x14
		public bool EnabledForETW; //Field offset: 0x15
		public bool HasRelatedActivityID; //Field offset: 0x16
		public byte TriggersActivityTracking; //Field offset: 0x17
		public string Name; //Field offset: 0x18
		public string Message; //Field offset: 0x20
		public ParameterInfo[] Parameters; //Field offset: 0x28
		public TraceLoggingEventTypes TraceLoggingEventTypes; //Field offset: 0x30
		public EventActivityOptions ActivityOptions; //Field offset: 0x38

	}

	private class OverideEventProvider : EventProvider
	{
		private EventSource m_eventSource; //Field offset: 0x60

		public OverideEventProvider(EventSource eventSource) { }

		protected virtual void OnControllerCommand(ControllerCommand command, IDictionary<String, String> arguments, int perEventSourceSessionId, int etwSessionId) { }

	}

	private struct Sha1ForNonSecretPurposes
	{
		private long length; //Field offset: 0x0
		private UInt32[] w; //Field offset: 0x8
		private int pos; //Field offset: 0x10

		public void Append(byte input) { }

		public void Append(Byte[] input) { }

		private void Drain() { }

		public void Finish(Byte[] output) { }

		private static uint Rol1(uint input) { }

		private static uint Rol30(uint input) { }

		private static uint Rol5(uint input) { }

		public void Start() { }

	}

	[ThreadStatic]
	private static byte m_EventSourceExceptionRecurenceCount; //Field offset: 0x80000000
	internal static uint s_currentPid; //Field offset: 0x0
	internal static Action<Guid> s_activityDying; //Field offset: 0x8
	private static readonly Byte[] namespaceBytes; //Field offset: 0x10
	private static readonly Guid AspNetEventSourceGuid; //Field offset: 0x18
	private Byte[] providerMetadata; //Field offset: 0x10
	private string m_name; //Field offset: 0x18
	internal int m_id; //Field offset: 0x20
	private Guid m_guid; //Field offset: 0x24
	internal EventMetadata[] m_eventData; //Field offset: 0x38
	private Byte[] m_rawManifest; //Field offset: 0x40
	private EventHandler<EventCommandEventArgs> m_eventCommandExecuted; //Field offset: 0x48
	private EventSourceSettings m_config; //Field offset: 0x50
	private bool m_eventSourceEnabled; //Field offset: 0x54
	internal EventLevel m_level; //Field offset: 0x58
	internal EventKeywords m_matchAnyKeyword; //Field offset: 0x60
	internal EventDispatcher m_Dispatchers; //Field offset: 0x68
	private OverideEventProvider m_provider; //Field offset: 0x70
	private bool m_completelyInited; //Field offset: 0x78
	private Exception m_constructionException; //Field offset: 0x80
	private byte m_outOfBandMessageCount; //Field offset: 0x88
	private EventCommandEventArgs m_deferredCommands; //Field offset: 0x90
	private String[] m_traits; //Field offset: 0x98
	private SessionMask m_curLiveSessions; //Field offset: 0xA0
	private EtwSession[] m_etwSessionIdMap; //Field offset: 0xA8
	private List<EtwSession> m_legacySessions; //Field offset: 0xB0
	internal long m_keywordTriggers; //Field offset: 0xB8
	internal SessionMask m_activityFilteringForETWEnabled; //Field offset: 0xC0
	private ActivityTracker m_activityTracker; //Field offset: 0xC8

	public static Guid CurrentThreadActivityId
	{
		 get { } //Length: 39
	}

	internal static Guid FallbackActivityId
	{
		internal get { } //Length: 188
	}

	public Guid Guid
	{
		 get { } //Length: 11
	}

	internal static Guid InternalCurrentThreadActivityId
	{
		internal get { } //Length: 255
	}

	private bool IsDisposed
	{
		private get { } //Length: 74
	}

	public string Name
	{
		 get { } //Length: 5
	}

	private bool SelfDescribingEvents
	{
		private get { } //Length: 8
	}

	private bool ThrowOnEventWriteErrors
	{
		private get { } //Length: 7
	}

	private static EventSource() { }

	protected EventSource(EventSourceSettings settings, String[] traits) { }

	protected EventSource(EventSourceSettings settings) { }

	protected EventSource() { }

	private static void AddEventDescriptor(ref EventMetadata[] eventData, string eventName, EventAttribute eventAttribute, ParameterInfo[] eventParameters, bool hasRelatedActivityID) { }

	internal void AddListener(EventListener listener) { }

	private static void AddProviderEnumKind(ManifestBuilder manifest, FieldInfo staticField, string providerEnumKind) { }

	private static int AddValueToMetaData(List<Byte> metaData, string value) { }

	private bool AnyEventEnabled() { }

	private static bool AttributeTypeNamesMatch(Type attributeType, Type reflectedAttributeType) { }

	private static Byte[] CreateManifestAndDescriptors(Type eventSourceType, string eventSourceDllName, EventSource source, EventManifestOptions flags = 0) { }

	private static void DebugCheckEvent(ref Dictionary<String, String>& eventsByName, EventMetadata[] eventData, MethodInfo method, EventAttribute eventAttribute, ManifestBuilder manifest, EventManifestOptions options) { }

	private object DecodeObject(int eventId, int parameterId, ref EventData* data) { }

	private void DispatchToAllListeners(int eventId, Guid* childActivityID, EventWrittenEventArgs eventCallbackArgs) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	internal void DoCommand(EventCommandEventArgs commandArgs) { }

	internal bool EnableEventForDispatcher(EventDispatcher dispatcher, int eventId, bool value) { }

	private void EnsureDescriptorsInitialized() { }

	protected virtual void Finalize() { }

	private static Guid GenerateGuidFromName(string name) { }

	public static Guid get_CurrentThreadActivityId() { }

	internal static Guid get_FallbackActivityId() { }

	public Guid get_Guid() { }

	internal static Guid get_InternalCurrentThreadActivityId() { }

	private bool get_IsDisposed() { }

	public string get_Name() { }

	private bool get_SelfDescribingEvents() { }

	private bool get_ThrowOnEventWriteErrors() { }

	internal static Attribute GetCustomAttributeHelper(MemberInfo member, Type attributeType, EventManifestOptions flags = 0) { }

	private EventDispatcher GetDispatcher(EventListener listener) { }

	private SessionMask GetEtwSessionMask(int eventId, Guid* childActivityID) { }

	private static Type GetEventSourceBaseType(Type eventSourceType, bool allowEventSourceOverride, bool reflectionOnly) { }

	public static Guid GetGuid(Type eventSourceType) { }

	private static int GetHelperCallFirstArg(MethodInfo method) { }

	private static string GetName(Type eventSourceType, EventManifestOptions flags) { }

	public static string GetName(Type eventSourceType) { }

	internal static EventOpcode GetOpcodeWithDefault(EventOpcode opcode, string eventName) { }

	private int GetParamLengthIncludingByteArray(ParameterInfo[] parameters) { }

	private static int HexDigit(char c) { }

	private void Initialize(Guid eventSourceGuid, string eventSourceName, String[] traits) { }

	private void InitializeProviderMetadata() { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords, EventChannel channel) { }

	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	public bool IsEnabled() { }

	private bool IsEnabledByDefault(int eventNum, bool enable, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword) { }

	private bool IsEnabledCommon(bool enabled, EventLevel currentLevel, EventKeywords currentMatchAnyKeyword, EventLevel eventLevel, EventKeywords eventKeywords, EventChannel eventChannel) { }

	private void LogEventArgsMismatches(ParameterInfo[] infos, Object[] args) { }

	protected override void OnEventCommand(EventCommandEventArgs command) { }

	internal static bool ParseCommandArgs(IDictionary<String, String> commandArguments, out bool participateInSampling, out string activityFilters, out int sessionIdBit) { }

	private static bool RemoveFirstArgIfRelatedActivityId(ref ParameterInfo[] args) { }

	private void ReportActivitySamplingInfo(EventListener listener, SessionMask sessions) { }

	internal void ReportOutOfBandMessage(string msg, bool flush) { }

	internal void SendCommand(EventListener listener, int perEventSourceSessionId, int etwSessionId, EventCommand command, bool enable, EventLevel level, EventKeywords matchAnyKeyword, IDictionary<String, String> commandArguments) { }

	private bool SendManifest(Byte[] rawManifest) { }

	private Object[] SerializeEventArgs(int eventId, Object[] args) { }

	public static void SetCurrentThreadActivityId(Guid activityId) { }

	private void ThrowEventSourceException(string eventName, Exception innerEx = null) { }

	public virtual string ToString() { }

	private static void TrimEventDescriptors(ref EventMetadata[] eventData) { }

	private NameInfo UpdateDescriptor(string name, TraceLoggingEventTypes eventInfo, ref EventSourceOptions options, out EventDescriptor descriptor) { }

	internal void UpdateEtwSession(int sessionIdBit, int etwSessionId, bool bEnable, string activityFilters, bool participateInSampling) { }

	internal void UpdateKwdTriggers(bool enable) { }

	private void ValidateEventOpcodeForTransfer(ref EventMetadata eventData, string eventName) { }

	private EventSourceSettings ValidateSettings(EventSourceSettings settings) { }

	[NonEvent]
	[ReliabilityContract(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private void WriteCleanup(GCHandle* pPins, int cPins) { }

	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	protected void WriteEvent(int eventId, string arg1, string arg2) { }

	protected void WriteEvent(int eventId, int arg1) { }

	protected void WriteEvent(int eventId, string arg1) { }

	protected void WriteEvent(int eventId, long arg1) { }

	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	protected void WriteEvent(int eventId, Object[] args) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected void WriteEventCore(int eventId, int eventDataCount, EventData* data) { }

	private void WriteEventRaw(string eventName, ref EventDescriptor eventDescriptor, Guid* activityID, Guid* relatedActivityID, int dataCount, IntPtr data) { }

	private void WriteEventString(EventLevel level, long keywords, string msgString) { }

	private void WriteEventVarargs(int eventId, Guid* childActivityID, Object[] args) { }

	[CLSCompliant(/*Cpp2IL Warning: missing at least one required parameter*/)]
	protected void WriteEventWithRelatedActivityIdCore(int eventId, Guid* relatedActivityId, int eventDataCount, EventData* data) { }

	private void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, Object[] values) { }

	internal void WriteMultiMerge(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, EventData* data) { }

	private void WriteMultiMergeInner(string eventName, ref EventSourceOptions options, TraceLoggingEventTypes eventTypes, Guid* activityID, Guid* childActivityID, Object[] values) { }

	private void WriteStringToAllListeners(string eventName, string msg) { }

	internal void WriteStringToListener(EventListener listener, string msg, SessionMask m) { }

	private void WriteToAllListeners(int eventId, Guid* childActivityID, int eventDataCount, EventData* data) { }

	private void WriteToAllListeners(int eventId, Guid* childActivityID, Object[] args) { }

}

