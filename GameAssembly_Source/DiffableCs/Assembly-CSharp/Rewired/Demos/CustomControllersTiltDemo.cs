namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomControllersTiltDemo : MonoBehaviour
{
	public Transform target; //Field offset: 0x18
	public float speed; //Field offset: 0x20
	private CustomController controller; //Field offset: 0x28
	private Player player; //Field offset: 0x30

	public CustomControllersTiltDemo() { }

	private void Awake() { }

	private void OnInputUpdate() { }

	private void Update() { }

}

