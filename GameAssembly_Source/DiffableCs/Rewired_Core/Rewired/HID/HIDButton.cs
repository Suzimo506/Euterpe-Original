namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDButton : HIDControllerElement
{
	public bool rawValue; //Field offset: 0x20
	public double timestamp; //Field offset: 0x28

	public HIDButton(byte unnamed_param_0, HIDInfo unnamed_param_1) { }

	public void SetValue(bool rawValue, double timestamp) { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

}

