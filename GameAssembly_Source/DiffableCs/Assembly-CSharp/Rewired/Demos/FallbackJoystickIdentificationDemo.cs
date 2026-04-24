namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FallbackJoystickIdentificationDemo : MonoBehaviour
{
	private const float windowWidth = 250; //Field offset: 0x0
	private const float windowHeight = 250; //Field offset: 0x0
	private const float inputDelay = 1; //Field offset: 0x0
	private bool identifyRequired; //Field offset: 0x18
	private Queue<Joystick> joysticksToIdentify; //Field offset: 0x20
	private float nextInputAllowedTime; //Field offset: 0x28
	private GUIStyle style; //Field offset: 0x30

	public FallbackJoystickIdentificationDemo() { }

	private void Awake() { }

	private void DrawDialogWindow(int windowId) { }

	public void IdentifyAllJoysticks() { }

	private void JoystickConnected(ControllerStatusChangedEventArgs args) { }

	private void JoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	private void OnGUI() { }

	private void Reset() { }

	private void SetInputDelay() { }

}

