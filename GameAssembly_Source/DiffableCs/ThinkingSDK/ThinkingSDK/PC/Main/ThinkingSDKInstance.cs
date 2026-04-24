namespace ThinkingSDK.PC.Main;

public class ThinkingSDKInstance
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public int batchSize; //Field offset: 0x10
		public ThinkingSDKInstance <>4__this; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <FlushImmediately>b__0(Dictionary<String, Object> result) { }

	}

	[CompilerGenerated]
	private sealed class <WaitAndFlush>d__45 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public ThinkingSDKInstance <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <WaitAndFlush>d__45(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static ThinkingSDKInstance mCurrentInstance; //Field offset: 0x0
	private static MonoBehaviour sMono; //Field offset: 0x8
	private string mAppid; //Field offset: 0x10
	private string mServer; //Field offset: 0x18
	protected string mDistinctID; //Field offset: 0x20
	protected string mAccountID; //Field offset: 0x28
	private bool mOptTracking; //Field offset: 0x30
	private Dictionary<String, Object> mTimeEvents; //Field offset: 0x38
	private bool mEnableTracking; //Field offset: 0x40
	private bool mEventSaveOnly; //Field offset: 0x41
	protected Dictionary<String, Object> mSupperProperties; //Field offset: 0x48
	protected Dictionary<String, Dictionary`2<String, Object>> mAutoTrackProperties; //Field offset: 0x50
	private ThinkingSDKConfig mConfig; //Field offset: 0x58
	private ThinkingSDKBaseRequest mRequest; //Field offset: 0x60
	private ThinkingSDKTimeCalibration mTimeCalibration; //Field offset: 0x68
	private IDynamicSuperProperties_PC mDynamicProperties; //Field offset: 0x70
	private MonoBehaviour mMono; //Field offset: 0x78
	private ThinkingSDKAutoTrack mAutoTrack; //Field offset: 0x80
	private ResponseHandle mResponseHandle; //Field offset: 0x88

	private ThinkingSDKTask mTask
	{
		private get { } //Length: 154
	}

	public ThinkingSDKInstance(string appId, string server, ThinkingSDKConfig config, MonoBehaviour mono = null) { }

	[CompilerGenerated]
	private void <.ctor>b__26_0(Dictionary<String, Object> result) { }

	[CompilerGenerated]
	private void <.ctor>b__26_1(Dictionary<String, Object> result) { }

	[CompilerGenerated]
	private void <Flush>b__46_0(Dictionary<String, Object> result) { }

	public override string AccountID() { }

	public override void ClearSuperProperties() { }

	public static ThinkingSDKInstance CreateLightInstance() { }

	private void DefaultData() { }

	private void DefaultTrackState() { }

	public override string DistinctId() { }

	public override void EnableAutoTrack(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties) { }

	public override void EnableAutoTrack(AUTO_TRACK_EVENTS events, IAutoTrackEventCallback_PC eventCallback) { }

	public void EnableTracking(bool isEnable) { }

	public override void Flush() { }

	public void FlushImmediately() { }

	private ThinkingSDKTask get_mTask() { }

	public ThinkingSDKTimeInter GetTime(DateTime dateTime) { }

	public override void Identifiy(string distinctID) { }

	protected bool IsPaused() { }

	public override void Login(string accountID) { }

	public override void Logout() { }

	public void OptTracking(bool optTracking) { }

	public void OptTrackingAndDeleteUser() { }

	public Dictionary<String, Object> PresetProperties() { }

	private void SendData(ThinkingSDKEventData data) { }

	private void SendData(ThinkingSDKEventData data, bool immediately) { }

	private void SendData(ThinkingSDKBaseData data) { }

	private void SendData(ThinkingSDKBaseData data, bool immediately) { }

	public override void SetAutoTrackProperties(AUTO_TRACK_EVENTS events, Dictionary<String, Object> properties) { }

	public void SetDynamicSuperProperties(IDynamicSuperProperties_PC dynamicSuperProperties) { }

	public override void SetSuperProperties(Dictionary<String, Object> superProperties) { }

	public void SetTimeCalibratieton(ThinkingSDKTimeCalibration timeCalibration) { }

	public void SetTrackStatus(TA_TRACK_STATUS status) { }

	public override Dictionary<String, Object> SuperProperties() { }

	public void TimeEvent(string eventName) { }

	public string TimeString(DateTime dateTime) { }

	public void Track(string eventName, Dictionary<String, Object> properties, DateTime date, bool immediately) { }

	public void Track(string eventName, Dictionary<String, Object> properties) { }

	public void Track(ThinkingSDKEventData analyticsEvent) { }

	public void Track(string eventName, Dictionary<String, Object> properties, DateTime date) { }

	public override void UnsetSuperProperty(string propertyKey) { }

	public void UserAdd(Dictionary<String, Object> properties) { }

	public void UserAdd(Dictionary<String, Object> properties, DateTime dateTime) { }

	public void UserAppend(Dictionary<String, Object> properties) { }

	public void UserAppend(Dictionary<String, Object> properties, DateTime dateTime) { }

	public void UserDelete() { }

	public void UserDelete(DateTime dateTime) { }

	public void UserSet(Dictionary<String, Object> properties) { }

	public void UserSet(Dictionary<String, Object> properties, DateTime dateTime) { }

	public void UserSetOnce(Dictionary<String, Object> properties) { }

	public void UserSetOnce(Dictionary<String, Object> properties, DateTime dateTime) { }

	public void UserUniqAppend(Dictionary<String, Object> properties, DateTime dateTime) { }

	public void UserUniqAppend(Dictionary<String, Object> properties) { }

	public void UserUnset(List<String> propertyKeys) { }

	public void UserUnset(List<String> propertyKeys, DateTime dateTime) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator WaitAndFlush() { }

}

