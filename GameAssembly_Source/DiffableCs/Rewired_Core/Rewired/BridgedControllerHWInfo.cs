namespace Rewired;

[CustomClassObfuscation]
[CustomObfuscation]
internal class BridgedControllerHWInfo
{
	public bool isMock; //Field offset: 0x10
	public InputSource inputManagerSource; //Field offset: 0x14
	public InputSource inputSource; //Field offset: 0x18
	public ControlDeviceType deviceType; //Field offset: 0x1C
	public string hardwareIdentifier; //Field offset: 0x20
	public int hardwareAxisCount; //Field offset: 0x28
	public int hardwareButtonCount; //Field offset: 0x2C
	public int hardwareHatCount; //Field offset: 0x30
	public string hw_productName; //Field offset: 0x38
	public PidVid hw_pidVid; //Field offset: 0x40
	public Guid hw_deviceGuid; //Field offset: 0x44
	public int hw_productId; //Field offset: 0x54
	public string hw_bluetoothDeviceName; //Field offset: 0x58
	public bool hw_isBluetoothDevice; //Field offset: 0x60
	public bool hw_supportsVoice; //Field offset: 0x61
	public bool hw_supportsVibration; //Field offset: 0x62
	public XInputDeviceSubType hw_xInputSubType; //Field offset: 0x64
	public string hw_manufacturer; //Field offset: 0x68
	public string hw_serialNumber; //Field offset: 0x70
	public int hw_vendorId; //Field offset: 0x78
	public int hw_version; //Field offset: 0x7C
	public string hw_systemDeviceName; //Field offset: 0x80
	public bool hw_isSDL2Gamepad; //Field offset: 0x88
	public WebGLWebBrowserType webGL_webBrowserType; //Field offset: 0x8C
	public WebGLOSType webGL_osType; //Field offset: 0x90
	public WebGLGamepadMappingType webGL_mappingType; //Field offset: 0x94
	public String[] webGL_webBrowserVersionSplit; //Field offset: 0x98
	public String[] webGL_osVersionSplit; //Field offset: 0xA0
	public int hw_localVibrationMotorCount; //Field offset: 0xA8
	public string definitionMatchTag; //Field offset: 0xB0

	public BridgedControllerHWInfo() { }

	public BridgedControllerHWInfo(BridgedControllerHWInfo unnamed_param_0) { }

	private void BnqhzELOcDQdRgbpbumxMbohILKB(BridgedControllerHWInfo unnamed_param_0) { }

}

