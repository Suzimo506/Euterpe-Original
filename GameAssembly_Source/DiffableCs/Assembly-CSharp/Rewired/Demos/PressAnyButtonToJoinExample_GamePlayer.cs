namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PressAnyButtonToJoinExample_GamePlayer : MonoBehaviour
{
	public int playerId; //Field offset: 0x18
	public float moveSpeed; //Field offset: 0x1C
	public float bulletSpeed; //Field offset: 0x20
	public GameObject bulletPrefab; //Field offset: 0x28
	private CharacterController cc; //Field offset: 0x30
	private Vector3 moveVector; //Field offset: 0x38
	private bool fire; //Field offset: 0x44

	private Player player
	{
		private get { } //Length: 217
	}

	public PressAnyButtonToJoinExample_GamePlayer() { }

	private Player get_player() { }

	private void GetInput() { }

	private void OnEnable() { }

	private void ProcessInput() { }

	private void Update() { }

}

