namespace System.Diagnostics.Tracing;

internal class ActivityTracker
{
	private class ActivityInfo
	{
		internal readonly string m_name; //Field offset: 0x10
		private readonly long m_uniqueId; //Field offset: 0x18
		internal readonly Guid m_guid; //Field offset: 0x20
		internal readonly int m_activityPathGuidOffset; //Field offset: 0x30
		internal readonly int m_level; //Field offset: 0x34
		internal readonly EventActivityOptions m_eventOptions; //Field offset: 0x38
		internal long m_lastChildID; //Field offset: 0x40
		internal int m_stopped; //Field offset: 0x48
		internal readonly ActivityInfo m_creator; //Field offset: 0x50
		internal readonly Guid m_activityIdToRestore; //Field offset: 0x58

		public Guid ActivityId
		{
			 get { } //Length: 11
		}

		public ActivityInfo(string name, long uniqueId, ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

		private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = false) { }

		public bool CanBeOrphan() { }

		private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

		private void CreateOverflowGuid(Guid* outPtr) { }

		public Guid get_ActivityId() { }

		public static string LiveActivities(ActivityInfo list) { }

		public static string Path(ActivityInfo activityInfo) { }

		public virtual string ToString() { }

		private static void WriteNibble(ref Byte* ptr, Byte* endPtr, uint value) { }

	}

	private static ActivityTracker s_activityTrackerInstance; //Field offset: 0x0
	private static long m_nextId; //Field offset: 0x8
	private AsyncLocal<ActivityInfo> m_current; //Field offset: 0x10
	private bool m_checkedForEnable; //Field offset: 0x18

	public static ActivityTracker Instance
	{
		 get { } //Length: 86
	}

	private static ActivityTracker() { }

	public ActivityTracker() { }

	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityInfo> args) { }

	public void Enable() { }

	private ActivityInfo FindActiveActivity(string name, ActivityInfo startLocation) { }

	public static ActivityTracker get_Instance() { }

	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

}

