namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDHat : HIDControllerElement
{
	[CustomObfuscation]
	internal enum Type
	{
		Default = 0,
		Custom = 1,
	}

	public int rawValue; //Field offset: 0x20
	public double timestamp; //Field offset: 0x28
	public readonly int byteLength; //Field offset: 0x30
	public readonly int startIndex; //Field offset: 0x34
	public readonly Type type; //Field offset: 0x38
	private Func<Int32, Int32> bTckYQTvShOcvHUBpOnekntDHyFd; //Field offset: 0x40

	public HIDHat(byte unnamed_param_0, HIDInfo unnamed_param_1, Type unnamed_param_2) { }

	public HIDHat(byte unnamed_param_0, HIDInfo unnamed_param_1, Func<Int32, Int32> unnamed_param_2) { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

}

