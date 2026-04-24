namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class HIDControllerElement
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	public class HIDInfo
	{
		public ushort usagePage; //Field offset: 0x10
		public ushort usage; //Field offset: 0x12
		public int dataIndex; //Field offset: 0x14
		public int bitSize; //Field offset: 0x18
		public int logicalMin; //Field offset: 0x1C
		public int logicalMax; //Field offset: 0x20
		public int physicalMin; //Field offset: 0x24
		public int physicalMax; //Field offset: 0x28
		public uint units; //Field offset: 0x2C
		public uint unitsExp; //Field offset: 0x30

		public HIDInfo() { }

	}

	public readonly byte reportId; //Field offset: 0x10
	public readonly HIDInfo hidInfo; //Field offset: 0x18

	public HIDControllerElement(byte unnamed_param_0, HIDInfo unnamed_param_1) { }

	public abstract void UpdateValue(NativeBuffer inputReport, double timestamp) { }

}

