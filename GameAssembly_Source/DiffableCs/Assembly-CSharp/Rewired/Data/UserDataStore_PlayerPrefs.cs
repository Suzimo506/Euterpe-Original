namespace Rewired.Data;

public class UserDataStore_PlayerPrefs : UserDataStore
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public Joystick joystick; //Field offset: 0x10

		public <>c__DisplayClass78_0() { }

		internal bool <LoadJoystickAssignmentsNow>b__0(JoystickAssignmentHistoryInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_1
	{
		public JoystickInfo joystickInfo; //Field offset: 0x10

		public <>c__DisplayClass78_1() { }

		internal bool <LoadJoystickAssignmentsNow>b__1(JoystickAssignmentHistoryInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_2
	{
		public Joystick match; //Field offset: 0x10

		public <>c__DisplayClass78_2() { }

		internal bool <LoadJoystickAssignmentsNow>b__2(JoystickAssignmentHistoryInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <LoadJoystickAssignmentsDeferred>d__80 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public UserDataStore_PlayerPrefs <>4__this; //Field offset: 0x20

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
		public <LoadJoystickAssignmentsDeferred>d__80(int <>1__state) { }

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

	private class ControllerAssignmentSaveInfo
	{
		internal class JoystickInfo
		{
			public Guid instanceGuid; //Field offset: 0x10
			public string hardwareIdentifier; //Field offset: 0x20
			public int id; //Field offset: 0x28

			public JoystickInfo() { }

		}

		internal class PlayerInfo
		{
			public int id; //Field offset: 0x10
			public bool hasKeyboard; //Field offset: 0x14
			public bool hasMouse; //Field offset: 0x15
			public JoystickInfo[] joysticks; //Field offset: 0x18

			public int joystickCount
			{
				 get { } //Length: 14
			}

			public PlayerInfo() { }

			public bool ContainsJoystick(int joystickId) { }

			public int get_joystickCount() { }

			public int IndexOfJoystick(int joystickId) { }

		}

		public PlayerInfo[] players; //Field offset: 0x10

		public int playerCount
		{
			 get { } //Length: 14
		}

		public ControllerAssignmentSaveInfo() { }

		public ControllerAssignmentSaveInfo(int playerCount) { }

		public bool ContainsPlayer(int playerId) { }

		public int get_playerCount() { }

		public int IndexOfPlayer(int playerId) { }

	}

	private class JoystickAssignmentHistoryInfo
	{
		public readonly Joystick joystick; //Field offset: 0x10
		public readonly int oldJoystickId; //Field offset: 0x18

		public JoystickAssignmentHistoryInfo(Joystick joystick, int oldJoystickId) { }

	}

	private const string thisScriptName = "UserDataStore_PlayerPrefs"; //Field offset: 0x0
	private const string logPrefix = "Rewired: "; //Field offset: 0x0
	private const string editorLoadedMessage = "
***IMPORTANT:*** Changes made to the Rewired Input Manager configuration after the last time XML data was saved WILL NOT be used because the loaded old saved data has overwritten these values. If you change something in the Rewired Input Manager such as a Joystick Map or Input Behavior settings, you will not see these changes reflected in the current configuration. Clear PlayerPrefs using the inspector option on the UserDataStore_PlayerPrefs component."; //Field offset: 0x0
	private const string playerPrefsKeySuffix_controllerAssignments = "ControllerAssignments"; //Field offset: 0x0
	private const int controllerMapPPKeyVersion_original = 0; //Field offset: 0x0
	private const int controllerMapPPKeyVersion_includeDuplicateJoystickIndex = 1; //Field offset: 0x0
	private const int controllerMapPPKeyVersion_supportDisconnectedControllers = 2; //Field offset: 0x0
	private const int controllerMapPPKeyVersion_includeFormatVersion = 2; //Field offset: 0x0
	private const int controllerMapPPKeyVersion = 2; //Field offset: 0x0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool isEnabled; //Field offset: 0x18
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool loadDataOnStart; //Field offset: 0x19
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool loadJoystickAssignments; //Field offset: 0x1A
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool loadKeyboardAssignments; //Field offset: 0x1B
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool loadMouseAssignments; //Field offset: 0x1C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string playerPrefsKeyPrefix; //Field offset: 0x20
	private bool allowImpreciseJoystickAssignmentMatching; //Field offset: 0x28
	private bool deferredJoystickAssignmentLoadPending; //Field offset: 0x29
	private bool wasJoystickEverDetected; //Field offset: 0x2A
	private List<Int32> __allActionIds; //Field offset: 0x30
	private string __allActionIdsString; //Field offset: 0x38

	private List<Int32> allActionIds
	{
		private get { } //Length: 508
	}

	private string allActionIdsString
	{
		private get { } //Length: 289
	}

	public bool IsEnabled
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private bool loadControllerAssignments
	{
		private get { } //Length: 20
	}

	public bool LoadDataOnStart
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LoadJoystickAssignments
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LoadKeyboardAssignments
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool LoadMouseAssignments
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	private string playerPrefsKey_controllerAssignments
	{
		private get { } //Length: 67
	}

	public string PlayerPrefsKeyPrefix
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public UserDataStore_PlayerPrefs() { }

	private void AddDefaultMappingsForNewActions(ControllerIdentifier controllerIdentifier, ControllerMap controllerMap, List<Int32> knownActionIds) { }

	private bool ControllerAssignmentSaveDataExists() { }

	private Joystick FindJoystickPrecise(JoystickInfo joystickInfo) { }

	private List<Int32> get_allActionIds() { }

	private string get_allActionIdsString() { }

	public bool get_IsEnabled() { }

	private bool get_loadControllerAssignments() { }

	public bool get_LoadDataOnStart() { }

	public bool get_LoadJoystickAssignments() { }

	public bool get_LoadKeyboardAssignments() { }

	public bool get_LoadMouseAssignments() { }

	private string get_playerPrefsKey_controllerAssignments() { }

	public string get_PlayerPrefsKeyPrefix() { }

	private string GetBasePlayerPrefsKey(Player player) { }

	private List<Int32> GetControllerMapKnownActionIds(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	private string GetControllerMapKnownActionIdsPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	private string GetControllerMapPlayerPrefsKey(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	private static string GetControllerMapPlayerPrefsKeyCommonSuffix(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId, int ppKeyVersion) { }

	private static Type GetControllerMapType(ControllerType controllerType) { }

	private string GetControllerMapXml(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	private static int GetDuplicateIndex(Player player, ControllerIdentifier controllerIdentifier) { }

	private string GetInputBehaviorPlayerPrefsKey(Player player, int inputBehaviorId) { }

	private string GetInputBehaviorXml(Player player, int id) { }

	private string GetJoystickCalibrationMapPlayerPrefsKey(Joystick joystick) { }

	private string GetJoystickCalibrationMapXml(Joystick joystick) { }

	public virtual void Load() { }

	private int LoadAll() { }

	private int LoadAllJoystickCalibrationData() { }

	private ControllerAssignmentSaveInfo LoadControllerAssignmentData() { }

	private bool LoadControllerAssignmentsNow() { }

	public virtual void LoadControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public virtual void LoadControllerData(ControllerType controllerType, int controllerId) { }

	private int LoadControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	private int LoadControllerDataNow(ControllerType controllerType, int controllerId) { }

	public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	private ControllerMap LoadControllerMap(Player player, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId) { }

	private int LoadControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	public virtual void LoadInputBehavior(int playerId, int behaviorId) { }

	private int LoadInputBehaviorNow(int playerId, int behaviorId) { }

	private int LoadInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	private int LoadInputBehaviors(int playerId) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerator LoadJoystickAssignmentsDeferred() { }

	private bool LoadJoystickAssignmentsNow(ControllerAssignmentSaveInfo data) { }

	private int LoadJoystickCalibrationData(int joystickId) { }

	private int LoadJoystickCalibrationData(Joystick joystick) { }

	private int LoadJoystickData(int joystickId) { }

	private bool LoadKeyboardAndMouseAssignmentsNow(ControllerAssignmentSaveInfo data) { }

	public virtual void LoadPlayerData(int playerId) { }

	private int LoadPlayerDataNow(Player player) { }

	private int LoadPlayerDataNow(int playerId) { }

	protected virtual void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	protected virtual void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args) { }

	protected virtual void OnInitialize() { }

	private void RefreshLayoutManager(int playerId) { }

	public virtual void Save() { }

	private void SaveAll() { }

	private void SaveAllJoystickCalibrationData() { }

	private bool SaveControllerAssignments() { }

	public virtual void SaveControllerData(int playerId, ControllerType controllerType, int controllerId) { }

	public virtual void SaveControllerData(ControllerType controllerType, int controllerId) { }

	private void SaveControllerDataNow(int playerId, ControllerType controllerType, int controllerId) { }

	private void SaveControllerDataNow(ControllerType controllerType, int controllerId) { }

	private void SaveControllerMap(Player player, ControllerMap controllerMap) { }

	public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap) { }

	private void SaveControllerMaps(int playerId, ControllerType controllerType, int controllerId) { }

	private void SaveControllerMaps(Player player, PlayerSaveData playerSaveData) { }

	public virtual void SaveInputBehavior(int playerId, int behaviorId) { }

	private void SaveInputBehaviorNow(Player player, InputBehavior inputBehavior) { }

	private void SaveInputBehaviorNow(int playerId, int behaviorId) { }

	private void SaveInputBehaviors(Player player, PlayerSaveData playerSaveData) { }

	private void SaveJoystickCalibrationData(int joystickId) { }

	private void SaveJoystickCalibrationData(Joystick joystick) { }

	private void SaveJoystickData(int joystickId) { }

	public virtual void SavePlayerData(int playerId) { }

	private void SavePlayerDataNow(Player player) { }

	private void SavePlayerDataNow(int playerId) { }

	public void set_IsEnabled(bool value) { }

	public void set_LoadDataOnStart(bool value) { }

	public void set_LoadJoystickAssignments(bool value) { }

	public void set_LoadKeyboardAssignments(bool value) { }

	public void set_LoadMouseAssignments(bool value) { }

	public void set_PlayerPrefsKeyPrefix(string value) { }

	private bool TryFindJoysticksImprecise(JoystickInfo joystickInfo, out List<Joystick>& matches) { }

}

