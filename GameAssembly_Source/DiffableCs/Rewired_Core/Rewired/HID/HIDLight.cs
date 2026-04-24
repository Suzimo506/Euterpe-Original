namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDLight
{
	private byte BxaTYwFsIfyFpnVgxOgXacKWJvUN; //Field offset: 0x10
	private byte vMpurkblRoxKLplYaflbFeiugrMTA; //Field offset: 0x11
	private byte SPhYxWltPTNHIMMXeLELFBlIGcwcA; //Field offset: 0x12
	[CompilerGenerated]
	private Action vPsDozCJCVMjeVUWZOMSDnwfbAuQc; //Field offset: 0x18

	public event Action ValueChangedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public float ColorB
	{
		 get { } //Length: 20
		 set { } //Length: 67
	}

	public byte ColorBRaw
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	public float ColorG
	{
		 get { } //Length: 20
		 set { } //Length: 67
	}

	public byte ColorGRaw
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	public float ColorR
	{
		 get { } //Length: 20
		 set { } //Length: 67
	}

	public byte ColorRRaw
	{
		 get { } //Length: 5
		 set { } //Length: 20
	}

	public HIDLight() { }

	public HIDLight(byte unnamed_param_0, byte unnamed_param_1, byte unnamed_param_2) { }

	[CompilerGenerated]
	public void add_ValueChangedEvent(Action value) { }

	public float get_ColorB() { }

	public byte get_ColorBRaw() { }

	public float get_ColorG() { }

	public byte get_ColorGRaw() { }

	public float get_ColorR() { }

	public byte get_ColorRRaw() { }

	[CompilerGenerated]
	public void remove_ValueChangedEvent(Action value) { }

	public void set_ColorB(float value) { }

	public void set_ColorBRaw(byte value) { }

	public void set_ColorG(float value) { }

	public void set_ColorGRaw(byte value) { }

	public void set_ColorR(float value) { }

	public void set_ColorRRaw(byte value) { }

}

