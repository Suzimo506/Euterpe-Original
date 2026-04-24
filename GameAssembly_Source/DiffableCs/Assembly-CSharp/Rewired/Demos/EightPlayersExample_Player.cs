namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class EightPlayersExample_Player : MonoBehaviour
{
	public int playerId; //Field offset: 0x18
	public float moveSpeed; //Field offset: 0x1C
	public float bulletSpeed; //Field offset: 0x20
	public GameObject bulletPrefab; //Field offset: 0x28
	private Player player; //Field offset: 0x30
	private CharacterController cc; //Field offset: 0x38
	private Vector3 moveVector; //Field offset: 0x40
	private bool fire; //Field offset: 0x4C
	private bool initialized; //Field offset: 0x4D

	public EightPlayersExample_Player() { }

	private void Awake() { }

	private void GetInput() { }

	private void Initialize() { }

	private void ProcessInput() { }

	private void Update() { }

}

