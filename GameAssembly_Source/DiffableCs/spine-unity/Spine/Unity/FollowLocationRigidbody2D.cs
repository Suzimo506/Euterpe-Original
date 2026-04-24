namespace Spine.Unity;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FollowLocationRigidbody2D : MonoBehaviour
{
	public Transform reference; //Field offset: 0x18
	public bool followFlippedX; //Field offset: 0x20
	private Rigidbody2D ownRigidbody; //Field offset: 0x28

	public FollowLocationRigidbody2D() { }

	private void Awake() { }

	private void FixedUpdate() { }

}

