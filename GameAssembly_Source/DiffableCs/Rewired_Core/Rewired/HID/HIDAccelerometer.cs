namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDAccelerometer : HIDControllerElement
{
	public readonly Single[] rawValue; //Field offset: 0x20
	public double timestamp; //Field offset: 0x28
	public readonly int valueLength; //Field offset: 0x30
	private readonly Byte[] QjmNKTFvVcQlySuPNgFvOlbXFJbZ; //Field offset: 0x38
	private readonly int LOAmVmAFVGItLtoHRLJaGjmyKFRE; //Field offset: 0x40
	private readonly int VFktbYKqgoHohQxHPtuhtHWVDSCz; //Field offset: 0x44
	private readonly Action<Byte[], Single[]> bTckYQTvShOcvHUBpOnekntDHyFd; //Field offset: 0x48

	public HIDAccelerometer(byte unnamed_param_0, HIDInfo unnamed_param_1, int unnamed_param_2, Action<Byte[], Single[]> unnamed_param_3) { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

	public void UpdateValueManual(Single[] value, double timestamp) { }

}

