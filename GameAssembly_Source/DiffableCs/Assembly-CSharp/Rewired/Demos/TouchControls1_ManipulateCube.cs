namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class TouchControls1_ManipulateCube : MonoBehaviour
{
	public float rotateSpeed; //Field offset: 0x18
	public float moveSpeed; //Field offset: 0x1C
	private int currentColorIndex; //Field offset: 0x20
	private Color[] colors; //Field offset: 0x28

	public TouchControls1_ManipulateCube() { }

	private void OnCycleColor(InputActionEventData data) { }

	private void OnCycleColor() { }

	private void OnCycleColorReverse(InputActionEventData data) { }

	private void OnCycleColorReverse() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnMoveReceived(Vector2 move) { }

	private void OnMoveReceivedX(InputActionEventData data) { }

	private void OnMoveReceivedY(InputActionEventData data) { }

	private void OnRotationReceived(Vector2 rotate) { }

	private void OnRotationReceivedX(InputActionEventData data) { }

	private void OnRotationReceivedY(InputActionEventData data) { }

}

