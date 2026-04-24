namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomControllerDemo : MonoBehaviour
{
	public int playerId; //Field offset: 0x18
	public string controllerTag; //Field offset: 0x20
	public bool useUpdateCallbacks; //Field offset: 0x28
	private int buttonCount; //Field offset: 0x2C
	private int axisCount; //Field offset: 0x30
	private Single[] axisValues; //Field offset: 0x38
	private Boolean[] buttonValues; //Field offset: 0x40
	private TouchJoystickExample[] joysticks; //Field offset: 0x48
	private TouchButtonExample[] buttons; //Field offset: 0x50
	private CustomController controller; //Field offset: 0x58
	private bool initialized; //Field offset: 0x60

	public CustomControllerDemo() { }

	private void Awake() { }

	private float GetAxisValueCallback(int index) { }

	private bool GetButtonValueCallback(int index) { }

	private void GetSourceAxisValues() { }

	private void GetSourceButtonValues() { }

	private void Initialize() { }

	private void OnInputSourceUpdate() { }

	private void SetControllerAxisValues() { }

	private void SetControllerButtonValues() { }

	private void Update() { }

}

