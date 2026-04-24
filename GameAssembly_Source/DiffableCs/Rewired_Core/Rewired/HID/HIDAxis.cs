namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDAxis : HIDControllerElement
{
	public int rawValue; //Field offset: 0x20
	public double timestamp; //Field offset: 0x28
	public readonly int byteLength; //Field offset: 0x30
	public readonly int startIndex; //Field offset: 0x34
	public readonly bool isSigned; //Field offset: 0x38
	public readonly int minValue; //Field offset: 0x3C
	public readonly int maxValue; //Field offset: 0x40
	public readonly int zeroValue; //Field offset: 0x44

	public HIDAxis(byte unnamed_param_0, HIDInfo unnamed_param_1, bool unnamed_param_2, int unnamed_param_3) { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

}

