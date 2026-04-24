namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDVibrationMotor
{
	private int MRNsqXzyFLbuWKfkEiGnDeYvgjhtA; //Field offset: 0x10
	private int JPnHAjPhYQhjiwOnvIZRFwwAlXPo; //Field offset: 0x14
	private int ZUsTrcMwzKHjSaWFnuMuxNjojrsDA; //Field offset: 0x18
	[CompilerGenerated]
	private Action vPsDozCJCVMjeVUWZOMSDnwfbAuQc; //Field offset: 0x20

	public event Action ValueChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float Speed
	{
		 get { } //Length: 39
		 set { } //Length: 70
	}

	public int SpeedRaw
	{
		 get { } //Length: 4
		 set { } //Length: 20
	}

	public HIDVibrationMotor(int unnamed_param_0, int unnamed_param_1) { }

	[CompilerGenerated]
	public void add_ValueChangedEvent(Action value) { }

	private float avynVIQZKyayBscqbFtvZspVsFMJ(int unnamed_param_0) { }

	private int DDUFTxOjbjeNRhMPGdUTOmNMwfcsA(float unnamed_param_0) { }

	public float get_Speed() { }

	public int get_SpeedRaw() { }

	[CompilerGenerated]
	public void remove_ValueChangedEvent(Action value) { }

	public void set_Speed(float value) { }

	public void set_SpeedRaw(int value) { }

}

