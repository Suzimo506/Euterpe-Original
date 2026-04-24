namespace Rewired.Integration.UnityUI;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
{
	internal class PlayerSetting
	{
		public int playerId; //Field offset: 0x10
		public List<PlayerMouse> playerMice; //Field offset: 0x18

		public PlayerSetting() { }

		private PlayerSetting(PlayerSetting other) { }

		public PlayerSetting Clone() { }

	}

	private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal"; //Field offset: 0x0
	private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical"; //Field offset: 0x0
	private const string DEFAULT_ACTION_SUBMIT = "UISubmit"; //Field offset: 0x0
	private const string DEFAULT_ACTION_CANCEL = "UICancel"; //Field offset: 0x0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InputManager_Base rewiredInputManager; //Field offset: 0x70
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool useAllRewiredGamePlayers; //Field offset: 0x78
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool useRewiredSystemPlayer; //Field offset: 0x79
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Int32[] rewiredPlayerIds; //Field offset: 0x80
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool usePlayingPlayersOnly; //Field offset: 0x88
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<PlayerMouse> playerMice; //Field offset: 0x90
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool moveOneElementPerAxisPress; //Field offset: 0x98
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool setActionsById; //Field offset: 0x99
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int horizontalActionId; //Field offset: 0x9C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int verticalActionId; //Field offset: 0xA0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int submitActionId; //Field offset: 0xA4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int cancelActionId; //Field offset: 0xA8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string m_HorizontalAxis; //Field offset: 0xB0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string m_VerticalAxis; //Field offset: 0xB8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string m_SubmitButton; //Field offset: 0xC0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private string m_CancelButton; //Field offset: 0xC8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_InputActionsPerSecond; //Field offset: 0xD0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float m_RepeatDelay; //Field offset: 0xD4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_allowMouseInput; //Field offset: 0xD8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_allowMouseInputIfTouchSupported; //Field offset: 0xD9
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_allowTouchInput; //Field offset: 0xDA
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_deselectIfBackgroundClicked; //Field offset: 0xDB
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_deselectBeforeSelecting; //Field offset: 0xDC
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool m_ForceModuleActive; //Field offset: 0xDD
	private Int32[] playerIds; //Field offset: 0xE0
	private bool recompiling; //Field offset: 0xE8
	private bool isTouchSupported; //Field offset: 0xE9
	private double m_PrevActionTime; //Field offset: 0xF0
	private Vector2 m_LastMoveVector; //Field offset: 0xF8
	private int m_ConsecutiveMoveCount; //Field offset: 0x100
	private bool m_HasFocus; //Field offset: 0x104

	[Obsolete]
	public bool allowActivationOnMobileDevice
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool allowMouseInput
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool allowMouseInputIfTouchSupported
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool allowTouchInput
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int CancelActionId
	{
		 get { } //Length: 7
		 set { } //Length: 345
	}

	public string cancelButton
	{
		 get { } //Length: 8
		 set { } //Length: 286
	}

	private bool deselectBeforeSelecting
	{
		private get { } //Length: 8
		private set { } //Length: 7
	}

	public bool deselectIfBackgroundClicked
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool forceModuleActive
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public int HorizontalActionId
	{
		 get { } //Length: 7
		 set { } //Length: 345
	}

	public string horizontalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 286
	}

	public float inputActionsPerSecond
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	protected virtual bool isMouseSupported
	{
		 get { } //Length: 282
	}

	private bool isTouchAllowed
	{
		private get { } //Length: 8
	}

	public bool MoveOneElementPerAxisPress
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public List<PlayerMouse> PlayerMice
	{
		 get { } //Length: 94
		 set { } //Length: 159
	}

	public float repeatDelay
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public InputManager_Base RewiredInputManager
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Int32[] RewiredPlayerIds
	{
		 get { } //Length: 121
		 set { } //Length: 175
	}

	public bool SetActionsById
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public int SubmitActionId
	{
		 get { } //Length: 7
		 set { } //Length: 345
	}

	public string submitButton
	{
		 get { } //Length: 8
		 set { } //Length: 286
	}

	public bool UseAllRewiredGamePlayers
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool UsePlayingPlayersOnly
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool UseRewiredSystemPlayer
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public int VerticalActionId
	{
		 get { } //Length: 7
		 set { } //Length: 345
	}

	public string verticalAxis
	{
		 get { } //Length: 8
		 set { } //Length: 286
	}

	private RewiredStandaloneInputModule() { }

	public virtual void ActivateModule() { }

	protected virtual void Awake() { }

	private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical) { }

	private void CheckEditorRecompile() { }

	private void ClearRewiredVars() { }

	public virtual void DeactivateModule() { }

	private bool DidAnyMouseMove() { }

	public bool get_allowActivationOnMobileDevice() { }

	public bool get_allowMouseInput() { }

	public bool get_allowMouseInputIfTouchSupported() { }

	public bool get_allowTouchInput() { }

	public int get_CancelActionId() { }

	public string get_cancelButton() { }

	private bool get_deselectBeforeSelecting() { }

	public bool get_deselectIfBackgroundClicked() { }

	public bool get_forceModuleActive() { }

	public int get_HorizontalActionId() { }

	public string get_horizontalAxis() { }

	public float get_inputActionsPerSecond() { }

	protected virtual bool get_isMouseSupported() { }

	private bool get_isTouchAllowed() { }

	public bool get_MoveOneElementPerAxisPress() { }

	public List<PlayerMouse> get_PlayerMice() { }

	public float get_repeatDelay() { }

	public InputManager_Base get_RewiredInputManager() { }

	public Int32[] get_RewiredPlayerIds() { }

	public bool get_SetActionsById() { }

	public int get_SubmitActionId() { }

	public string get_submitButton() { }

	public bool get_UseAllRewiredGamePlayers() { }

	public bool get_UsePlayingPlayersOnly() { }

	public bool get_UseRewiredSystemPlayer() { }

	public int get_VerticalActionId() { }

	public string get_verticalAxis() { }

	private float GetAxis(Player player, int actionId) { }

	private bool GetButton(Player player, int actionId) { }

	private bool GetButtonDown(Player player, int actionId) { }

	private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) { }

	private bool GetNegativeButton(Player player, int actionId) { }

	private bool GetNegativeButtonDown(Player player, int actionId) { }

	private Vector2 GetRawMoveVector() { }

	private void HandleMouseTouchDeselectionOnSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	private void InitializeRewired() { }

	protected virtual bool IsDefaultPlayer(int playerId) { }

	public virtual bool IsModuleSupported() { }

	private void OnApplicationFocus(bool hasFocus) { }

	protected virtual void OnDestroy() { }

	private void OnEditorRecompile() { }

	private void OnRewiredInitialized() { }

	private void OnRewiredShutDown() { }

	public virtual void Process() { }

	private void ProcessMouseEvent(int playerId, int pointerIndex) { }

	private void ProcessMouseEvents() { }

	private void ProcessMousePress(MouseButtonEventData data) { }

	private bool ProcessTouchEvents() { }

	private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	private bool SendMoveEventToSelectedObject() { }

	private bool SendSubmitEventToSelectedObject() { }

	private bool SendUpdateEventToSelectedObject() { }

	public void set_allowActivationOnMobileDevice(bool value) { }

	public void set_allowMouseInput(bool value) { }

	public void set_allowMouseInputIfTouchSupported(bool value) { }

	public void set_allowTouchInput(bool value) { }

	public void set_CancelActionId(int value) { }

	public void set_cancelButton(string value) { }

	private void set_deselectBeforeSelecting(bool value) { }

	public void set_deselectIfBackgroundClicked(bool value) { }

	public void set_forceModuleActive(bool value) { }

	public void set_HorizontalActionId(int value) { }

	public void set_horizontalAxis(string value) { }

	public void set_inputActionsPerSecond(float value) { }

	public void set_MoveOneElementPerAxisPress(bool value) { }

	public void set_PlayerMice(List<PlayerMouse> value) { }

	public void set_repeatDelay(float value) { }

	public void set_RewiredInputManager(InputManager_Base value) { }

	public void set_RewiredPlayerIds(Int32[] value) { }

	public void set_SetActionsById(bool value) { }

	public void set_SubmitActionId(int value) { }

	public void set_submitButton(string value) { }

	public void set_UseAllRewiredGamePlayers(bool value) { }

	public void set_UsePlayingPlayersOnly(bool value) { }

	public void set_UseRewiredSystemPlayer(bool value) { }

	public void set_VerticalActionId(int value) { }

	public void set_verticalAxis(string value) { }

	private void SetUpRewiredActions() { }

	private void SetUpRewiredPlayerMice() { }

	private void SetupRewiredVars() { }

	public virtual bool ShouldActivateModule() { }

	private bool ShouldIgnoreEventsOnNoFocus() { }

	public virtual void UpdateModule() { }

}

