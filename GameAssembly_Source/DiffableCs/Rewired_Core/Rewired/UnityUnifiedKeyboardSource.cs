namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class UnityUnifiedKeyboardSource : IDisposable, IGetSetEnabled, IUnifiedKeyboardSource
{
	private const int LZKnjDKtSFnXsKqktyFLODSDANGM = 132; //Field offset: 0x0
	private static HardwareControllerMap_Game MhjTLmNEsvwhicQUqDKcaLxzDtrT; //Field offset: 0x0
	private bool dDPTnfkiUGCQQHgOhJldFBaHbwjJc; //Field offset: 0x10
	private bool HJIqUdpanNSGICxZbMmGqcqhazEs; //Field offset: 0x11

	public override int buttonCount
	{
		 get { } //Length: 6
	}

	public override Extension controllerExtension
	{
		 get { } //Length: 3
	}

	public override bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 59
	}

	public override HardwareControllerMap_Game hardwareMap
	{
		 get { } //Length: 105
	}

	public override InputSource inputSource
	{
		 get { } //Length: 6
	}

	public UnityUnifiedKeyboardSource() { }

	public override void Clear() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public override int get_buttonCount() { }

	public override Extension get_controllerExtension() { }

	public override bool get_enabled() { }

	public override HardwareControllerMap_Game get_hardwareMap() { }

	public override InputSource get_inputSource() { }

	public static ControllerElementType GetHardwareElementType(int elementIdentifierId) { }

	private static HardwareControllerMap_Game QHMiJoFAqQcoYBQEtIIbWNOcAuRY() { }

	public override void set_enabled(bool value) { }

	public override void UpdateInputData(ControllerDataUpdater dataUpdater) { }

}

