namespace Rewired.Demos.GamepadTemplateUI;

public class GamepadTemplateUI : MonoBehaviour
{
	private class Stick
	{
		private RectTransform _transform; //Field offset: 0x10
		private Vector2 _origPosition; //Field offset: 0x18
		private int _xAxisElementId; //Field offset: 0x20
		private int _yAxisElementId; //Field offset: 0x24

		public Vector2 position
		{
			 get { } //Length: 254
			 set { } //Length: 215
		}

		public Stick(RectTransform transform, int xAxisElementId, int yAxisElementId) { }

		public bool ContainsElement(int elementId) { }

		public Vector2 get_position() { }

		public void Reset() { }

		public void set_position(Vector2 value) { }

		public void SetAxisPosition(int elementId, float value) { }

	}

	private class UIElement
	{
		public int id; //Field offset: 0x10
		public ControllerUIElement element; //Field offset: 0x18

		public UIElement(int id, ControllerUIElement element) { }

	}

	private const float stickRadius = 20; //Field offset: 0x0
	public int playerId; //Field offset: 0x18
	[SerializeField]
	private RectTransform leftStick; //Field offset: 0x20
	[SerializeField]
	private RectTransform rightStick; //Field offset: 0x28
	[SerializeField]
	private ControllerUIElement leftStickX; //Field offset: 0x30
	[SerializeField]
	private ControllerUIElement leftStickY; //Field offset: 0x38
	[SerializeField]
	private ControllerUIElement leftStickButton; //Field offset: 0x40
	[SerializeField]
	private ControllerUIElement rightStickX; //Field offset: 0x48
	[SerializeField]
	private ControllerUIElement rightStickY; //Field offset: 0x50
	[SerializeField]
	private ControllerUIElement rightStickButton; //Field offset: 0x58
	[SerializeField]
	private ControllerUIElement actionBottomRow1; //Field offset: 0x60
	[SerializeField]
	private ControllerUIElement actionBottomRow2; //Field offset: 0x68
	[SerializeField]
	private ControllerUIElement actionBottomRow3; //Field offset: 0x70
	[SerializeField]
	private ControllerUIElement actionTopRow1; //Field offset: 0x78
	[SerializeField]
	private ControllerUIElement actionTopRow2; //Field offset: 0x80
	[SerializeField]
	private ControllerUIElement actionTopRow3; //Field offset: 0x88
	[SerializeField]
	private ControllerUIElement leftShoulder; //Field offset: 0x90
	[SerializeField]
	private ControllerUIElement leftTrigger; //Field offset: 0x98
	[SerializeField]
	private ControllerUIElement rightShoulder; //Field offset: 0xA0
	[SerializeField]
	private ControllerUIElement rightTrigger; //Field offset: 0xA8
	[SerializeField]
	private ControllerUIElement center1; //Field offset: 0xB0
	[SerializeField]
	private ControllerUIElement center2; //Field offset: 0xB8
	[SerializeField]
	private ControllerUIElement center3; //Field offset: 0xC0
	[SerializeField]
	private ControllerUIElement dPadUp; //Field offset: 0xC8
	[SerializeField]
	private ControllerUIElement dPadRight; //Field offset: 0xD0
	[SerializeField]
	private ControllerUIElement dPadDown; //Field offset: 0xD8
	[SerializeField]
	private ControllerUIElement dPadLeft; //Field offset: 0xE0
	private UIElement[] _uiElementsArray; //Field offset: 0xE8
	private Dictionary<Int32, ControllerUIElement> _uiElements; //Field offset: 0xF0
	private IList<ControllerTemplateElementTarget> _tempTargetList; //Field offset: 0xF8
	private Stick[] _sticks; //Field offset: 0x100

	private Player player
	{
		private get { } //Length: 102
	}

	public GamepadTemplateUI() { }

	private void ActivateElements(Player player, int actionId) { }

	private void Awake() { }

	private void DrawActiveElements() { }

	private void DrawLabel(ControllerUIElement uiElement, InputAction action, ControllerMap controllerMap, IControllerTemplate template, IControllerTemplateElement element) { }

	private void DrawLabels() { }

	private void DrawLabels(Player player, InputAction action) { }

	private Player get_player() { }

	private Stick GetStick(int elementId) { }

	private void OnControllerConnected(ControllerStatusChangedEventArgs args) { }

	private void OnControllerDisconnected(ControllerStatusChangedEventArgs args) { }

	private void OnDestroy() { }

	private void Start() { }

	private void Update() { }

}

