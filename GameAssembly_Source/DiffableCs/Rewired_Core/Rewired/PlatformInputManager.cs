namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class PlatformInputManager
{
	protected Action<BridgedController> _DeviceConnectedEvent; //Field offset: 0x10
	protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent; //Field offset: 0x18
	protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent; //Field offset: 0x20
	protected Action _SystemDeviceConnectedEvent; //Field offset: 0x28
	protected Action _SystemDeviceDisconnectedEvent; //Field offset: 0x30

	[CustomObfuscation]
	public event Action<BridgedController> DeviceConnectedEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	[CustomObfuscation]
	public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	[CustomObfuscation]
	public event Action SystemDeviceConnectedEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	[CustomObfuscation]
	public event Action SystemDeviceDisconnectedEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	[CustomObfuscation]
	public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent
	{
		 add { } //Length: 118
		 remove { } //Length: 118
	}

	public abstract int deviceCount
	{
		 get { } //Length: 0
	}

	public abstract IInputSource inputSource
	{
		 get { } //Length: 0
	}

	public abstract InputSource inputSourceType
	{
		 get { } //Length: 0
	}

	public abstract PlatformInputManager primaryInputManager
	{
		 get { } //Length: 0
	}

	protected PlatformInputManager() { }

	public void add_DeviceConnectedEvent(Action<BridgedController> value) { }

	public void add_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	public void add_SystemDeviceConnectedEvent(Action value) { }

	public void add_SystemDeviceDisconnectedEvent(Action value) { }

	public void add_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	public abstract int get_deviceCount() { }

	public abstract IInputSource get_inputSource() { }

	public abstract InputSource get_inputSourceType() { }

	public abstract PlatformInputManager get_primaryInputManager() { }

	public abstract Action<Int32, ControllerDataUpdater> GetInputDataUpdateDelegate() { }

	public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource() { }

	public abstract IUnifiedMouseSource GetUnifiedMouseSource() { }

	public abstract void Initialize() { }

	public abstract void OnDestroy() { }

	public void remove_DeviceConnectedEvent(Action<BridgedController> value) { }

	public void remove_DeviceDisconnectedEvent(Action<ControllerDisconnectedEventArgs> value) { }

	public void remove_SystemDeviceConnectedEvent(Action value) { }

	public void remove_SystemDeviceDisconnectedEvent(Action value) { }

	public void remove_UpdateControllerInfoEvent(Action<UpdateControllerInfoEventArgs> value) { }

	public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId) { }

	public abstract void SystemDeviceConnected() { }

	public abstract void SystemDeviceDisconnected() { }

	public abstract void Update(UpdateLoopType currentUpdateLoop) { }

	public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data) { }

}

