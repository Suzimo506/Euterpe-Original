namespace Rewired.Interfaces;

[CustomClassObfuscation]
[CustomObfuscation]
internal interface IUnifiedMouseSource
{

	public int axisCount
	{
		 get { } //Length: 0
	}

	public int buttonCount
	{
		 get { } //Length: 0
	}

	public Extension controllerExtension
	{
		 get { } //Length: 0
	}

	public HardwareControllerMap_Game hardwareMap
	{
		 get { } //Length: 0
	}

	public InputSource inputSource
	{
		 get { } //Length: 0
	}

	public Vector2 mousePosition
	{
		 get { } //Length: 0
	}

	public void Clear() { }

	public int get_axisCount() { }

	public int get_buttonCount() { }

	public Extension get_controllerExtension() { }

	public HardwareControllerMap_Game get_hardwareMap() { }

	public InputSource get_inputSource() { }

	public Vector2 get_mousePosition() { }

	public void UpdateInputData(ControllerDataUpdater dataUpdater) { }

}

