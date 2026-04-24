namespace UnityEngine.InputSystem;

internal class InputManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<InputDevice, String> <>9__155_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <MakeDeviceNameUnique>b__155_0(InputDevice x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__60
	{
		public static readonly <>c__60<TDevice> <>9; //Field offset: 0x0
		public static Func<InputDevice> <>9__60_0; //Field offset: 0x0

		private static <>c__60`1() { }

		public <>c__60`1() { }

		internal InputDevice <RegisterPrecompiledLayout>b__60_0() { }

	}

	[CompilerGenerated]
	private sealed class <ListControlLayouts>d__76 : IEnumerable<String>, IEnumerable, IEnumerator<String>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private string <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private string basedOn; //Field offset: 0x28
		public string <>3__basedOn; //Field offset: 0x30
		public InputManager <>4__this; //Field offset: 0x38
		private InternedString <internedBasedOn>5__2; //Field offset: 0x40
		private Enumerator<InternedString, Type> <>7__wrap2; //Field offset: 0x50
		private Enumerator<InternedString, String> <>7__wrap3; //Field offset: 0x80
		private Enumerator<InternedString, Func<InputControlLayout>> <>7__wrap4; //Field offset: 0xB0

		private override string System.Collections.Generic.IEnumerator<System.String>.Current
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
		public <ListControlLayouts>d__76(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

		private void <>m__Finally5() { }

		private void <>m__Finally6() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<String> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator() { }

		[DebuggerHidden]
		private override string System.Collections.Generic.IEnumerator<System.String>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public struct AvailableDevice
	{
		public InputDeviceDescription description; //Field offset: 0x0
		public int deviceId; //Field offset: 0x38
		public bool isNative; //Field offset: 0x3C
		public bool isRemoved; //Field offset: 0x3D

	}

	public enum DeviceDisableScope
	{
		Everywhere = 0,
		InFrontendOnly = 1,
		TemporaryWhilePlayerIsInBackground = 2,
	}

	public struct StateChangeMonitorListener
	{
		public InputControl control; //Field offset: 0x0
		public IInputStateChangeMonitor monitor; //Field offset: 0x8
		public long monitorIndex; //Field offset: 0x10

	}

	public struct StateChangeMonitorsForDevice
	{
		public BitRegion[] memoryRegions; //Field offset: 0x0
		public StateChangeMonitorListener[] listeners; //Field offset: 0x8
		public DynamicBitfield signalled; //Field offset: 0x10

		public int count
		{
			 get { } //Length: 4
		}

		public void Add(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

		public void Clear() { }

		public int get_count() { }

		public void Remove(IInputStateChangeMonitor monitor, long monitorIndex) { }

	}

	private struct StateChangeMonitorTimeout
	{
		public InputControl control; //Field offset: 0x0
		public double time; //Field offset: 0x8
		public IInputStateChangeMonitor monitor; //Field offset: 0x10
		public long monitorIndex; //Field offset: 0x18
		public int timerIndex; //Field offset: 0x20

	}

	internal int m_LayoutRegistrationVersion; //Field offset: 0x10
	private float m_PollingFrequency; //Field offset: 0x14
	internal Collection m_Layouts; //Field offset: 0x18
	private TypeTable m_Processors; //Field offset: 0x58
	private TypeTable m_Interactions; //Field offset: 0x60
	private TypeTable m_Composites; //Field offset: 0x68
	private int m_DevicesCount; //Field offset: 0x70
	private InputDevice[] m_Devices; //Field offset: 0x78
	private Dictionary<Int32, InputDevice> m_DevicesById; //Field offset: 0x80
	internal int m_AvailableDeviceCount; //Field offset: 0x88
	internal AvailableDevice[] m_AvailableDevices; //Field offset: 0x90
	internal int m_DisconnectedDevicesCount; //Field offset: 0x98
	internal InputDevice[] m_DisconnectedDevices; //Field offset: 0xA0
	internal InputUpdateType m_UpdateMask; //Field offset: 0xA8
	private InputUpdateType m_CurrentUpdate; //Field offset: 0xAC
	internal InputStateBuffers m_StateBuffers; //Field offset: 0xB0
	private CallbackArray<Action`2<InputDevice, InputDeviceChange>> m_DeviceChangeListeners; //Field offset: 0xE0
	private CallbackArray<Action`2<InputDevice, InputEventPtr>> m_DeviceStateChangeListeners; //Field offset: 0x130
	private CallbackArray<InputDeviceFindControlLayoutDelegate> m_DeviceFindLayoutCallbacks; //Field offset: 0x180
	internal CallbackArray<InputDeviceCommandDelegate> m_DeviceCommandCallbacks; //Field offset: 0x1D0
	private CallbackArray<Action`2<String, InputControlLayoutChange>> m_LayoutChangeListeners; //Field offset: 0x220
	private CallbackArray<Action`2<InputEventPtr, InputDevice>> m_EventListeners; //Field offset: 0x270
	private CallbackArray<Action> m_BeforeUpdateListeners; //Field offset: 0x2C0
	private CallbackArray<Action> m_AfterUpdateListeners; //Field offset: 0x310
	private CallbackArray<Action> m_SettingsChangedListeners; //Field offset: 0x360
	private bool m_NativeBeforeUpdateHooked; //Field offset: 0x3B0
	private bool m_HaveDevicesWithStateCallbackReceivers; //Field offset: 0x3B1
	private bool m_HasFocus; //Field offset: 0x3B2
	private InputEventStream m_InputEventStream; //Field offset: 0x3B8
	private InputDeviceExecuteCommandDelegate m_DeviceFindExecuteCommandDelegate; //Field offset: 0x430
	private int m_DeviceFindExecuteCommandDeviceId; //Field offset: 0x438
	internal IInputRuntime m_Runtime; //Field offset: 0x440
	internal InputMetrics m_Metrics; //Field offset: 0x448
	internal InputSettings m_Settings; //Field offset: 0x480
	internal StateChangeMonitorsForDevice[] m_StateChangeMonitors; //Field offset: 0x488
	private InlinedArray<StateChangeMonitorTimeout> m_StateChangeMonitorTimeouts; //Field offset: 0x490

	public event Action onAfterUpdate
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action onBeforeUpdate
	{
		 add { } //Length: 85
		 remove { } //Length: 75
	}

	public event Action<InputDevice, InputDeviceChange> onDeviceChange
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event InputDeviceCommandDelegate onDeviceCommand
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action<InputDevice, InputEventPtr> onDeviceStateChange
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action<InputEventPtr, InputDevice> onEvent
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event InputDeviceFindControlLayoutDelegate onFindControlLayoutForDevice
	{
		 add { } //Length: 85
		 remove { } //Length: 75
	}

	public event Action<String, InputControlLayoutChange> onLayoutChange
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action onSettingsChange
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public TypeTable composites
	{
		 get { } //Length: 5
	}

	public InputUpdateType defaultUpdateType
	{
		 get { } //Length: 24
	}

	public ReadOnlyArray<InputDevice> devices
	{
		 get { } //Length: 94
	}

	private bool gameHasFocus
	{
		private get { } //Length: 8
	}

	private bool gameIsPlaying
	{
		private get { } //Length: 3
	}

	private bool gameShouldGetInputRegardlessOfFocus
	{
		private get { } //Length: 33
	}

	public TypeTable interactions
	{
		 get { } //Length: 5
	}

	public bool isProcessingEvents
	{
		 get { } //Length: 8
	}

	public InputMetrics metrics
	{
		 get { } //Length: 376
	}

	public float pollingFrequency
	{
		 get { } //Length: 6
		 set { } //Length: 155
	}

	public TypeTable processors
	{
		 get { } //Length: 5
	}

	public InputSettings settings
	{
		 get { } //Length: 8
		 set { } //Length: 256
	}

	public InputUpdateType updateMask
	{
		 get { } //Length: 7
		 set { } //Length: 28
	}

	public InputManager() { }

	[CompilerGenerated]
	private long <TryFindMatchingControlLayout>b__72_0(ref InputDeviceCommand commandRef) { }

	public void add_onAfterUpdate(Action value) { }

	public void add_onBeforeUpdate(Action value) { }

	public void add_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	public void add_onDeviceCommand(InputDeviceCommandDelegate value) { }

	public void add_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	public void add_onEvent(Action<InputEventPtr, InputDevice> value) { }

	public void add_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	public void add_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	public void add_onSettingsChange(Action value) { }

	private void AddAvailableDevicesMatchingDescription(InputDeviceMatcher matcher, InternedString layout) { }

	internal void AddAvailableDevicesThatAreNowRecognized() { }

	private InputDevice AddDevice(InternedString layout, int deviceId, string deviceName = null, InputDeviceDescription deviceDescription = null, DeviceFlags deviceFlags = 0, InternedString variants = null) { }

	public void AddDevice(InputDevice device) { }

	public InputDevice AddDevice(InputDeviceDescription description) { }

	public InputDevice AddDevice(InputDeviceDescription description, bool throwIfNoLayoutFound, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	public InputDevice AddDevice(InputDeviceDescription description, InternedString layout, string deviceName = null, int deviceId = 0, DeviceFlags deviceFlags = 0) { }

	public InputDevice AddDevice(string layout, string name = null, InternedString variants = null) { }

	public InputDevice AddDevice(Type type, string name = null) { }

	public void AddDeviceUsage(InputDevice device, InternedString usage) { }

	public void AddStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

	public void AddStateChangeMonitorTimeout(InputControl control, IInputStateChangeMonitor monitor, double time, long monitorIndex, int timerIndex) { }

	internal void ApplySettings() { }

	private void AssignUniqueDeviceId(InputDevice device) { }

	internal void Destroy() { }

	private bool DoesLayoutExist(InternedString name) { }

	public void EnableOrDisableDevice(InputDevice device, bool enable, DeviceDisableScope scope = 0) { }

	private InternedString FindOrRegisterDeviceLayoutForType(Type type) { }

	private void FireStateChangeNotifications(int deviceIndex, double internalTime, InputEvent* eventPtr) { }

	private bool FlipBuffersForDeviceIfNecessary(InputDevice device, InputUpdateType updateType) { }

	public void FlushDisconnectedDevices() { }

	public TypeTable get_composites() { }

	public InputUpdateType get_defaultUpdateType() { }

	public ReadOnlyArray<InputDevice> get_devices() { }

	private bool get_gameHasFocus() { }

	private bool get_gameIsPlaying() { }

	private bool get_gameShouldGetInputRegardlessOfFocus() { }

	public TypeTable get_interactions() { }

	public bool get_isProcessingEvents() { }

	public InputMetrics get_metrics() { }

	public float get_pollingFrequency() { }

	public TypeTable get_processors() { }

	public InputSettings get_settings() { }

	public InputUpdateType get_updateMask() { }

	public int GetControls(string path, ref InputControlList<TControl>& controls) { }

	public InputDevice GetDevice(string nameOrLayout) { }

	public int GetUnsupportedDevices(List<InputDeviceDescription> descriptions) { }

	internal void Initialize(IInputRuntime runtime, InputSettings settings) { }

	internal void InitializeData() { }

	private void InitializeDefaultState(InputDevice device) { }

	private void InitializeDeviceState(InputDevice device) { }

	private void InstallBeforeUpdateHookIfNecessary() { }

	internal void InstallGlobals() { }

	internal void InstallRuntime(IInputRuntime runtime) { }

	private void InvokeAfterUpdateCallback(InputUpdateType updateType) { }

	private bool IsControlOrChildUsingLayoutRecursive(InputControl control, InternedString layout) { }

	private bool IsControlUsingLayout(InputControl control, InternedString layout) { }

	private bool IsDeviceLayoutMarkedAsSupportedInSettings(InternedString layoutName) { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public IEnumerable<String> ListControlLayouts(string basedOn = null) { }

	private void MakeDeviceNameUnique(InputDevice device) { }

	private void NotifyUsageChanged(InputDevice device) { }

	private void OnBeforeUpdate(InputUpdateType updateType) { }

	internal void OnFocusChanged(bool focus) { }

	private void OnNativeDeviceDiscovered(int deviceId, string deviceDescriptor) { }

	private void OnUpdate(InputUpdateType updateType, ref InputEventBuffer eventBuffer) { }

	private void PerformLayoutPostRegistration(InternedString layoutName, InlinedArray<InternedString> baseLayouts, bool isReplacement, bool isKnownToBeDeviceLayout = false, bool isOverride = false) { }

	private bool ProcessStateChangeMonitors(int deviceIndex, Void* newStateFromEvent, Void* oldStateOfDevice, uint newStateSizeInBytes, uint newStateOffsetInBytes) { }

	private void ProcessStateChangeMonitorTimeouts() { }

	public void QueueEvent(InputEventPtr ptr) { }

	private void QueueEvent(InputEvent* eventPtr) { }

	public void QueueEvent(ref TEvent inputEvent) { }

	private void ReallocateStateBuffers() { }

	private void RecreateDevice(InputDevice oldDevice, InternedString newLayout) { }

	private void RecreateDevicesUsingLayout(InternedString layout, bool isKnownToBeDeviceLayout = false) { }

	private void RecreateDevicesUsingLayoutWithInferiorMatch(InputDeviceMatcher deviceMatcher) { }

	public void RegisterControlLayout(string json, string name = null, bool isOverride = false) { }

	public void RegisterControlLayout(string name, Type type) { }

	public void RegisterControlLayoutBuilder(Func<InputControlLayout> method, string name, string baseLayout = null) { }

	public void RegisterControlLayoutMatcher(Type type, InputDeviceMatcher matcher) { }

	public void RegisterControlLayoutMatcher(string layoutName, InputDeviceMatcher matcher) { }

	public void RegisterPrecompiledLayout(string metadata) { }

	public void remove_onAfterUpdate(Action value) { }

	public void remove_onBeforeUpdate(Action value) { }

	public void remove_onDeviceChange(Action<InputDevice, InputDeviceChange> value) { }

	public void remove_onDeviceCommand(InputDeviceCommandDelegate value) { }

	public void remove_onDeviceStateChange(Action<InputDevice, InputEventPtr> value) { }

	public void remove_onEvent(Action<InputEventPtr, InputDevice> value) { }

	public void remove_onFindControlLayoutForDevice(InputDeviceFindControlLayoutDelegate value) { }

	public void remove_onLayoutChange(Action<String, InputControlLayoutChange> value) { }

	public void remove_onSettingsChange(Action value) { }

	public void RemoveControlLayout(string name) { }

	public void RemoveDevice(InputDevice device, bool keepOnListOfAvailableDevices = false) { }

	public void RemoveDeviceUsage(InputDevice device, InternedString usage) { }

	public void RemoveStateChangeMonitor(InputControl control, IInputStateChangeMonitor monitor, long monitorIndex) { }

	private void RemoveStateChangeMonitors(InputDevice device) { }

	public void RemoveStateChangeMonitorTimeout(IInputStateChangeMonitor monitor, long monitorIndex, int timerIndex) { }

	private static void ResetControlPathsRecursive(InputControl control) { }

	public void ResetDevice(InputDevice device, bool alsoResetDontResetControls = false, Nullable<Boolean> issueResetCommand = null) { }

	private void RestoreDevicesAfterDomainReloadIfNecessary() { }

	public void set_pollingFrequency(float value) { }

	public void set_settings(InputSettings value) { }

	public void set_updateMask(InputUpdateType value) { }

	public void SetDeviceUsage(InputDevice device, InternedString usage) { }

	private bool ShouldRunDeviceInBackground(InputDevice device) { }

	internal bool ShouldRunUpdate(InputUpdateType updateType) { }

	private void SyncAllDevicesWhenEditorIsActivated() { }

	public InternedString TryFindMatchingControlLayout(ref InputDeviceDescription deviceDescription, int deviceId = 0) { }

	public InputDevice TryGetDevice(Type layoutType) { }

	public InputDevice TryGetDevice(string nameOrLayout) { }

	public InputDevice TryGetDeviceById(int id) { }

	public InputControlLayout TryLoadControlLayout(InternedString name) { }

	public InputControlLayout TryLoadControlLayout(Type type) { }

	private InputDevice TryMatchDisconnectedDevice(string deviceDescriptor) { }

	internal void UninstallGlobals() { }

	public void Update() { }

	public void Update(InputUpdateType updateType) { }

	internal bool UpdateState(InputDevice device, InputUpdateType updateType, Void* statePtr, uint stateOffsetInDevice, uint stateSize, double internalTime, InputEventPtr eventPtr = null) { }

	internal bool UpdateState(InputDevice device, InputEvent* eventPtr, InputUpdateType updateType) { }

	private void WarnAboutDevicesFailingToRecreateAfterDomainReload() { }

	private static void WriteStateChange(DoubleBuffers buffers, int deviceIndex, ref InputStateBlock deviceStateBlock, uint stateOffsetInDevice, Void* statePtr, uint stateSizeInBytes, bool flippedBuffers) { }

}

