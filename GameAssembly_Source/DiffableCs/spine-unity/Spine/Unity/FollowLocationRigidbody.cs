namespace Spine.Unity;

[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class FollowLocationRigidbody : MonoBehaviour
{
	public Transform reference; //Field offset: 0x18
	private Rigidbody ownRigidbody; //Field offset: 0x20

	public FollowLocationRigidbody() { }

	private void Awake() { }

	private void FixedUpdate() { }

}

