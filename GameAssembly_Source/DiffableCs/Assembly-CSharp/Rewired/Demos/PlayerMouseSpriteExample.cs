namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PlayerMouseSpriteExample : MonoBehaviour
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int playerId; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string horizontalAction; //Field offset: 0x20
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string verticalAction; //Field offset: 0x28
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string wheelAction; //Field offset: 0x30
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string leftButtonAction; //Field offset: 0x38
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string rightButtonAction; //Field offset: 0x40
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public string middleButtonAction; //Field offset: 0x48
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float distanceFromCamera; //Field offset: 0x50
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float spriteScale; //Field offset: 0x54
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject pointerPrefab; //Field offset: 0x58
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public GameObject clickEffectPrefab; //Field offset: 0x60
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public bool hideHardwarePointer; //Field offset: 0x68
	private GameObject pointer; //Field offset: 0x70
	private PlayerMouse mouse; //Field offset: 0x78

	public PlayerMouseSpriteExample() { }

	private void Awake() { }

	private void CreateClickEffect(Color color) { }

	private void OnScreenPositionChanged(Vector2 position) { }

	private void Update() { }

}

