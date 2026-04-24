namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IInputSource : IDisposable
{

	public event Action DeviceChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DeviceChangedEvent(Action value) { }

	public IList<TJoy> GetJoysticks() { }

	[CompilerGenerated]
	public void remove_DeviceChangedEvent(Action value) { }

	public void SystemDeviceConnected() { }

	public void SystemDeviceDisconnected() { }

	public void Update() { }

	public void UpdateDevices(UpdateLoopType updateLoop) { }

	public void UpdateFinished() { }

}

