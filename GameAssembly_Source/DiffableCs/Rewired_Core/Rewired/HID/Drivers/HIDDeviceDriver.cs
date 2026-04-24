namespace Rewired.HID.Drivers;

[CustomClassObfuscation]
[CustomObfuscation]
internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver
{
	[CustomObfuscation]
	internal enum DriverType
	{
		None = 0,
		DualShock4 = 1,
		DualSense = 2,
		RailDriver = 3,
	}

	[CustomObfuscation]
	public sealed class GetHidFeatureData : MulticastDelegate
	{

		public GetHidFeatureData(object unnamed_param_0, IntPtr unnamed_param_1) { }

		public override IAsyncResult BeginInvoke(byte reportId, AsyncCallback callback, object object) { }

		public override Byte[] EndInvoke(IAsyncResult result) { }

		public override Byte[] Invoke(byte reportId) { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public class InitArgs
	{
		public UpdateLoopSetting updateLoopSetting; //Field offset: 0x10
		public DeviceConnectionType connectionType; //Field offset: 0x14
		public int minAxisValue; //Field offset: 0x18
		public int maxAxisValue; //Field offset: 0x1C
		public int hatZeroValue; //Field offset: 0x20
		public int hatSpan; //Field offset: 0x24
		public int inputReportLength; //Field offset: 0x28
		public int outputReportLength; //Field offset: 0x2C
		public Func<OutputReport, Boolean> synchronousWriteOutputReportDelegate; //Field offset: 0x30
		public Action<OutputReport> asynchronousWriteOutputReportDelegate; //Field offset: 0x38
		public GetHidFeatureData getFeatureReportDelegate; //Field offset: 0x40

		public InitArgs(UpdateLoopSetting unnamed_param_0, DeviceConnectionType unnamed_param_1, int unnamed_param_2, int unnamed_param_3, int unnamed_param_4, int unnamed_param_5, int unnamed_param_6, int unnamed_param_7, Func<OutputReport, Boolean> unnamed_param_8, Action<OutputReport> unnamed_param_9, GetHidFeatureData unnamed_param_10) { }

	}

	public HIDAxis[] axes; //Field offset: 0x10
	public HIDButton[] buttons; //Field offset: 0x18
	public HIDHat[] hats; //Field offset: 0x20
	public HIDAccelerometer[] accelerometers; //Field offset: 0x28
	public HIDGyroscope[] gyroscopes; //Field offset: 0x30
	public HIDTouchpad[] touchpads; //Field offset: 0x38
	public HIDVibrationMotor[] vibrationMotors; //Field offset: 0x40
	public HIDLight[] lights; //Field offset: 0x48
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x50

	public override int AccelerometerCount
	{
		 get { } //Length: 14
	}

	public override int AxisCount
	{
		 get { } //Length: 14
	}

	public override int ButtonCount
	{
		 get { } //Length: 14
	}

	protected bool disposed
	{
		 get { } //Length: 5
	}

	public override int GyroscopeCount
	{
		 get { } //Length: 14
	}

	public override int HatCount
	{
		 get { } //Length: 14
	}

	public override int LightCount
	{
		 get { } //Length: 14
	}

	public override int TouchpadCount
	{
		 get { } //Length: 14
	}

	public override int VibrationMotorCount
	{
		 get { } //Length: 14
	}

	public HIDDeviceDriver() { }

	public abstract Extension CreateControllerExtension() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public static DriverType FindDriverId(int vendorId, int productId) { }

	public override int get_AccelerometerCount() { }

	public override int get_AxisCount() { }

	public override int get_ButtonCount() { }

	protected bool get_disposed() { }

	public override int get_GyroscopeCount() { }

	public override int get_HatCount() { }

	public override int get_LightCount() { }

	public override int get_TouchpadCount() { }

	public override int get_VibrationMotorCount() { }

	public static HIDDeviceDriver GetDriver(DriverType driverId, InitArgs hidDriverInitArgs) { }

	public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp) { }

	public abstract void Update(UpdateLoopType updateLoop) { }

}

