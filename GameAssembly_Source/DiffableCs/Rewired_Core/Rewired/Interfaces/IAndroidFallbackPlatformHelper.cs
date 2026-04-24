namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IAndroidFallbackPlatformHelper
{

	public event Action DeviceChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public IAndroidFallbackDS4Helper ds4Helper
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_DeviceChangedEvent(Action value) { }

	public IAndroidFallbackDS4Helper get_ds4Helper() { }

	public string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex) { }

	[CompilerGenerated]
	public void remove_DeviceChangedEvent(Action value) { }

}

