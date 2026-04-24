namespace Rewired.Drivers.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IDriver_RailDriver : IControllerDriver
{

	public bool SpeakerEnabled
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool get_SpeakerEnabled() { }

	public void set_SpeakerEnabled(bool value) { }

	public void SetLEDDisplay(int digitIndex, byte digitBitValues) { }

	public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues) { }

}

