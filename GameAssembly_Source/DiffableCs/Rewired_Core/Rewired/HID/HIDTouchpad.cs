namespace Rewired.HID;

[CustomClassObfuscation]
[CustomObfuscation]
internal class HIDTouchpad : HIDControllerElement
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	public struct TouchData
	{
		public int touchId; //Field offset: 0x0
		public float timeStamp; //Field offset: 0x4
		public bool isTouching; //Field offset: 0x8
		public int positionRawX; //Field offset: 0xC
		public int positionRawY; //Field offset: 0x10
		public float positionX; //Field offset: 0x14
		public float positionY; //Field offset: 0x18
		public int positionAbsX; //Field offset: 0x1C
		public int positionAbsY; //Field offset: 0x20

		public void Clear() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public class TouchpadInfo
	{
		public int maxTouches; //Field offset: 0x10
		public int minX; //Field offset: 0x14
		public int maxX; //Field offset: 0x18
		public int minY; //Field offset: 0x1C
		public int maxY; //Field offset: 0x20
		public bool invertY; //Field offset: 0x24
		public bool reverseY; //Field offset: 0x25

		public TouchpadInfo(int unnamed_param_0, int unnamed_param_1, int unnamed_param_2, int unnamed_param_3, int unnamed_param_4, bool unnamed_param_5, bool unnamed_param_6) { }

		public void CalculateTouch(ref TouchData data) { }

	}

	private TouchpadInfo eoyNYXXBHPrEdOLhNMyqrCgBOfxA; //Field offset: 0x20
	private Queue<TouchData> ucPMHEAGVxryjponqMkhsIKcMtQH; //Field offset: 0x28
	private TouchData[] HurehqHFylWHceZFgPUjlkCXCPhIb; //Field offset: 0x30
	private Action<NativeBuffer, TouchData[]> bTckYQTvShOcvHUBpOnekntDHyFd; //Field offset: 0x38
	public TouchData[] values; //Field offset: 0x40

	public HIDTouchpad(byte unnamed_param_0, TouchpadInfo unnamed_param_1, HIDInfo unnamed_param_2, Action<NativeBuffer, TouchData[]> unnamed_param_3) { }

	public bool IsTouching(int touchId) { }

	public void ProcessQueue() { }

	public virtual void UpdateValue(NativeBuffer inputReport, double timestamp) { }

}

