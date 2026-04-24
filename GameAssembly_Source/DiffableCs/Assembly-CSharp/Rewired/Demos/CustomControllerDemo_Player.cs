namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
[RequireComponent(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class CustomControllerDemo_Player : MonoBehaviour
{
	public int playerId; //Field offset: 0x18
	public float speed; //Field offset: 0x1C
	public float bulletSpeed; //Field offset: 0x20
	public GameObject bulletPrefab; //Field offset: 0x28
	private Player _player; //Field offset: 0x30
	private CharacterController cc; //Field offset: 0x38

	private Player player
	{
		private get { } //Length: 140
	}

	public CustomControllerDemo_Player() { }

	private void Awake() { }

	private Player get_player() { }

	private void Update() { }

}

