namespace Rewired.Demos;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ControlRemappingDemo1 : MonoBehaviour
{
	private class Calibration : QueueEntry
	{
		[CompilerGenerated]
		private Player <player>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private ControllerType <controllerType>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Joystick <joystick>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private CalibrationMap <calibrationMap>k__BackingField; //Field offset: 0x38
		public int selectedElementIdentifierId; //Field offset: 0x40
		public bool recording; //Field offset: 0x44

		public private CalibrationMap calibrationMap
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private ControllerType controllerType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private Joystick joystick
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private Player player
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public Calibration(Player player, Joystick joystick, CalibrationMap calibrationMap) { }

		[CompilerGenerated]
		public CalibrationMap get_calibrationMap() { }

		[CompilerGenerated]
		public ControllerType get_controllerType() { }

		[CompilerGenerated]
		public Joystick get_joystick() { }

		[CompilerGenerated]
		public Player get_player() { }

		[CompilerGenerated]
		private void set_calibrationMap(CalibrationMap value) { }

		[CompilerGenerated]
		private void set_controllerType(ControllerType value) { }

		[CompilerGenerated]
		private void set_joystick(Joystick value) { }

		[CompilerGenerated]
		private void set_player(Player value) { }

	}

	private class ControllerSelection
	{
		private int _id; //Field offset: 0x10
		private int _idPrev; //Field offset: 0x14
		private ControllerType _type; //Field offset: 0x18
		private ControllerType _typePrev; //Field offset: 0x1C

		public bool hasSelection
		{
			 get { } //Length: 9
		}

		public int id
		{
			 get { } //Length: 4
			 set { } //Length: 10
		}

		public int idPrev
		{
			 get { } //Length: 4
		}

		public ControllerType type
		{
			 get { } //Length: 4
			 set { } //Length: 10
		}

		public ControllerType typePrev
		{
			 get { } //Length: 4
		}

		public ControllerSelection() { }

		public void Clear() { }

		public bool get_hasSelection() { }

		public int get_id() { }

		public int get_idPrev() { }

		public ControllerType get_type() { }

		public ControllerType get_typePrev() { }

		public void Set(int id, ControllerType type) { }

		public void set_id(int value) { }

		public void set_type(ControllerType value) { }

	}

	private class DialogHelper
	{
		internal enum DialogType
		{
			None = 0,
			JoystickConflict = 1,
			ElementConflict = 2,
			KeyConflict = 3,
			DeleteAssignmentConfirmation = 10,
			AssignElement = 11,
		}

		private const float openBusyDelay = 0.25; //Field offset: 0x0
		private const float closeBusyDelay = 0.1; //Field offset: 0x0
		private DialogType _type; //Field offset: 0x10
		private bool _enabled; //Field offset: 0x14
		private float _busyTime; //Field offset: 0x18
		private bool _busyTimerRunning; //Field offset: 0x1C
		private Action<Int32> drawWindowDelegate; //Field offset: 0x20
		private WindowFunction drawWindowFunction; //Field offset: 0x28
		private WindowProperties windowProperties; //Field offset: 0x30
		private int currentActionId; //Field offset: 0x60
		private Action<Int32, UserResponse> resultCallback; //Field offset: 0x68

		public bool busy
		{
			 get { } //Length: 5
		}

		private float busyTimer
		{
			private get { } //Length: 52
		}

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 89
		}

		public DialogType type
		{
			 get { } //Length: 13
			 set { } //Length: 82
		}

		public DialogHelper() { }

		public void Cancel() { }

		private void Close() { }

		public void Confirm(UserResponse response) { }

		public void Confirm() { }

		public void Draw() { }

		public void DrawCancelButton(string title) { }

		public void DrawCancelButton() { }

		public void DrawConfirmButton(UserResponse response) { }

		public void DrawConfirmButton(UserResponse response, string title) { }

		public void DrawConfirmButton() { }

		public void DrawConfirmButton(string title) { }

		private void DrawWindow(int windowId) { }

		public void FullReset() { }

		public bool get_busy() { }

		private float get_busyTimer() { }

		public bool get_enabled() { }

		public DialogType get_type() { }

		private void Reset() { }

		private void ResetTimers() { }

		public void set_enabled(bool value) { }

		public void set_type(DialogType value) { }

		private void StartBusyTimer(float time) { }

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<Int32, UserResponse> resultCallback, float openBusyDelay) { }

		public void StartModal(int queueActionId, DialogType type, WindowProperties windowProperties, Action<Int32, UserResponse> resultCallback) { }

		private void StateChanged(float delay) { }

		public void Update() { }

		private void UpdateTimers() { }

	}

	private class ElementAssignmentChange : QueueEntry
	{
		[CompilerGenerated]
		private ElementAssignmentChangeType <changeType>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Context <context>k__BackingField; //Field offset: 0x28

		public ElementAssignmentChangeType changeType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public private Context context
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public ElementAssignmentChange(ElementAssignmentChangeType changeType, Context context) { }

		public ElementAssignmentChange(ElementAssignmentChange other) { }

		[CompilerGenerated]
		public ElementAssignmentChangeType get_changeType() { }

		[CompilerGenerated]
		public Context get_context() { }

		[CompilerGenerated]
		public void set_changeType(ElementAssignmentChangeType value) { }

		[CompilerGenerated]
		private void set_context(Context value) { }

	}

	private enum ElementAssignmentChangeType
	{
		Add = 0,
		Replace = 1,
		Remove = 2,
		ReassignOrRemove = 3,
		ConflictCheck = 4,
	}

	private class FallbackJoystickIdentification : QueueEntry
	{
		[CompilerGenerated]
		private int <joystickId>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private string <joystickName>k__BackingField; //Field offset: 0x28

		public private int joystickId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private string joystickName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public FallbackJoystickIdentification(int joystickId, string joystickName) { }

		[CompilerGenerated]
		public int get_joystickId() { }

		[CompilerGenerated]
		public string get_joystickName() { }

		[CompilerGenerated]
		private void set_joystickId(int value) { }

		[CompilerGenerated]
		private void set_joystickName(string value) { }

	}

	private class JoystickAssignmentChange : QueueEntry
	{
		[CompilerGenerated]
		private int <playerId>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private int <joystickId>k__BackingField; //Field offset: 0x24
		[CompilerGenerated]
		private bool <assign>k__BackingField; //Field offset: 0x28

		public private bool assign
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private int joystickId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private int playerId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public JoystickAssignmentChange(int newPlayerId, int joystickId, bool assign) { }

		[CompilerGenerated]
		public bool get_assign() { }

		[CompilerGenerated]
		public int get_joystickId() { }

		[CompilerGenerated]
		public int get_playerId() { }

		[CompilerGenerated]
		private void set_assign(bool value) { }

		[CompilerGenerated]
		private void set_joystickId(int value) { }

		[CompilerGenerated]
		private void set_playerId(int value) { }

	}

	private enum QueueActionType
	{
		None = 0,
		JoystickAssignment = 1,
		ElementAssignment = 2,
		FallbackJoystickIdentification = 3,
		Calibrate = 4,
	}

	private abstract class QueueEntry
	{
		internal enum State
		{
			Waiting = 0,
			Confirmed = 1,
			Canceled = 2,
		}

		private static int uidCounter; //Field offset: 0x0
		[CompilerGenerated]
		private int <id>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private QueueActionType <queueActionType>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private State <state>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private UserResponse <response>k__BackingField; //Field offset: 0x1C

		public int id
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		protected static int nextId
		{
			 get { } //Length: 57
		}

		public QueueActionType queueActionType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public UserResponse response
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public State state
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public QueueEntry(QueueActionType queueActionType) { }

		public void Cancel() { }

		public void Confirm(UserResponse response) { }

		[CompilerGenerated]
		public int get_id() { }

		protected static int get_nextId() { }

		[CompilerGenerated]
		public QueueActionType get_queueActionType() { }

		[CompilerGenerated]
		public UserResponse get_response() { }

		[CompilerGenerated]
		public State get_state() { }

		[CompilerGenerated]
		protected void set_id(int value) { }

		[CompilerGenerated]
		protected void set_queueActionType(QueueActionType value) { }

		[CompilerGenerated]
		protected void set_response(UserResponse value) { }

		[CompilerGenerated]
		protected void set_state(State value) { }

	}

	internal enum UserResponse
	{
		Confirm = 0,
		Cancel = 1,
		Custom1 = 2,
		Custom2 = 3,
	}

	private struct WindowProperties
	{
		public int windowId; //Field offset: 0x0
		public Rect rect; //Field offset: 0x4
		public Action<String, String> windowDrawDelegate; //Field offset: 0x18
		public string title; //Field offset: 0x20
		public string message; //Field offset: 0x28

	}

	private const float defaultModalWidth = 250; //Field offset: 0x0
	private const float defaultModalHeight = 200; //Field offset: 0x0
	private const float assignmentTimeout = 5; //Field offset: 0x0
	private DialogHelper dialog; //Field offset: 0x18
	private InputMapper inputMapper; //Field offset: 0x20
	private ConflictFoundEventData conflictFoundEventData; //Field offset: 0x28
	private bool guiState; //Field offset: 0x30
	private bool busy; //Field offset: 0x31
	private bool pageGUIState; //Field offset: 0x32
	private Player selectedPlayer; //Field offset: 0x38
	private int selectedMapCategoryId; //Field offset: 0x40
	private ControllerSelection selectedController; //Field offset: 0x48
	private ControllerMap selectedMap; //Field offset: 0x50
	private bool showMenu; //Field offset: 0x58
	private bool startListening; //Field offset: 0x59
	private Vector2 actionScrollPos; //Field offset: 0x5C
	private Vector2 calibrateScrollPos; //Field offset: 0x64
	private Queue<QueueEntry> actionQueue; //Field offset: 0x70
	private bool setupFinished; //Field offset: 0x78
	private bool initialized; //Field offset: 0x79
	private bool isCompiling; //Field offset: 0x7A
	private GUIStyle style_wordWrap; //Field offset: 0x80
	private GUIStyle style_centeredBox; //Field offset: 0x88

	public ControlRemappingDemo1() { }

	private void Awake() { }

	protected void CheckRecompile() { }

	private void ClearControllerSelection() { }

	private void ClearMapSelection() { }

	private void ClearWorkingVars() { }

	private void Close() { }

	private void ControllerSelectionChanged() { }

	private void DialogResultCallback(int queueActionId, UserResponse response) { }

	private void DrawActionAssignmentButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) { }

	private void DrawAddActionMapButton(int playerId, InputAction action, AxisRange actionRange, ControllerSelection controller, ControllerMap controllerMap) { }

	private void DrawCalibrateButton() { }

	private void DrawCalibrationWindow(string title, string message) { }

	private void DrawCategoryActions() { }

	private void DrawControllerSelector() { }

	private void DrawElementAssignmentNormalConflictWindow(string title, string message) { }

	private void DrawElementAssignmentProtectedConflictWindow(string title, string message) { }

	private void DrawElementAssignmentWindow(string title, string message) { }

	private void DrawFallbackJoystickIdentificationWindow(string title, string message) { }

	private void DrawInitialScreen() { }

	private void DrawInvertButton(int playerId, InputAction action, Pole actionAxisContribution, ControllerSelection controller, ControllerMap controllerMap, ActionElementMap elementMap) { }

	private void DrawJoystickSelector() { }

	private void DrawMapCategories() { }

	private void DrawModalWindow(string title, string message) { }

	private void DrawModalWindow_OkayOnly(string title, string message) { }

	private void DrawMouseAssignment() { }

	private void DrawPage() { }

	private void DrawPlayerSelector() { }

	private void DrawReassignOrRemoveElementAssignmentWindow(string title, string message) { }

	private void EnqueueAction(QueueEntry entry) { }

	private Rect GetScreenCenteredRect(float width, float height) { }

	private void HandleMenuControl() { }

	public void IdentifyAllJoysticks() { }

	private void Initialize() { }

	private void JoystickConnected(ControllerStatusChangedEventArgs args) { }

	private void JoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	private void JoystickPreDisconnect(ControllerStatusChangedEventArgs args) { }

	private void OnConflictFound(ConflictFoundEventData data) { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void OnGUI() { }

	private void OnStopped(StoppedEventData data) { }

	private void Open() { }

	private void PlayerSelectionChanged() { }

	private bool ProcessAddOrReplaceElementAssignment(ElementAssignmentChange entry) { }

	private bool ProcessCalibration(Calibration entry) { }

	private bool ProcessElementAssignmentChange(ElementAssignmentChange entry) { }

	private bool ProcessElementAssignmentConflictCheck(ElementAssignmentChange entry) { }

	private bool ProcessFallbackJoystickIdentification(FallbackJoystickIdentification entry) { }

	private bool ProcessJoystickAssignmentChange(JoystickAssignmentChange entry) { }

	private void ProcessQueue() { }

	private bool ProcessRemoveElementAssignment(ElementAssignmentChange entry) { }

	private bool ProcessRemoveOrReassignElementAssignment(ElementAssignmentChange entry) { }

	private void RecompileWindow(int windowId) { }

	private void ResetAll() { }

	private void SetGUIStateEnd() { }

	private void SetGUIStateStart() { }

	private void Setup() { }

	private void ShowDialog() { }

	private void Subscribe() { }

	private void Unsubscribe() { }

}

