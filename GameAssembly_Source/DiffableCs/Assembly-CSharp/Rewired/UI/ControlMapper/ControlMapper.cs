namespace Rewired.UI.ControlMapper;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ControlMapper : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass341_0
	{
		public ControlMapper <>4__this; //Field offset: 0x10
		public Window window; //Field offset: 0x18
		public int controllerId; //Field offset: 0x20

		public <>c__DisplayClass341_0() { }

		internal void <ShowControllerAssignmentConflictWindow>b__0() { }

		internal void <ShowControllerAssignmentConflictWindow>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass342_0
	{
		public ControlMapper <>4__this; //Field offset: 0x10
		public Window window; //Field offset: 0x18
		public InputFieldInfo fieldInfo; //Field offset: 0x20
		public ControllerMap map; //Field offset: 0x28
		public ActionElementMap aem; //Field offset: 0x30
		public string actionName; //Field offset: 0x38

		public <>c__DisplayClass342_0() { }

		internal void <ShowBeginElementAssignmentReplacementWindow>b__0() { }

		internal void <ShowBeginElementAssignmentReplacementWindow>b__1() { }

		internal void <ShowBeginElementAssignmentReplacementWindow>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass349_0
	{
		public ControlMapper <>4__this; //Field offset: 0x10
		public Window window; //Field offset: 0x18
		public ElementAssignment assignment; //Field offset: 0x20
		public bool skipOtherPlayers; //Field offset: 0x44

		public <>c__DisplayClass349_0() { }

		internal void <ShowElementAssignmentConflictWindow>b__0() { }

		internal void <ShowElementAssignmentConflictWindow>b__1() { }

		internal void <ShowElementAssignmentConflictWindow>b__2() { }

		internal void <ShowElementAssignmentConflictWindow>b__3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass350_0
	{
		public ControlMapper <>4__this; //Field offset: 0x10
		public Window window; //Field offset: 0x18

		public <>c__DisplayClass350_0() { }

		internal void <ShowMouseAssignmentConflictWindow>b__0() { }

		internal void <ShowMouseAssignmentConflictWindow>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass403_0
	{
		public ControlMapper <>4__this; //Field offset: 0x10
		public Window window; //Field offset: 0x18

		public <>c__DisplayClass403_0() { }

		internal void <OpenModal>b__0() { }

		internal void <OpenModal>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass456_0
	{
		public ActionElementMap aem; //Field offset: 0x10

		public <>c__DisplayClass456_0() { }

		internal bool <ShowSwapButton>b__0(ElementAssignmentConflictInfo x) { }

	}

	[CompilerGenerated]
	private sealed class <ElementAssignmentConflicts>d__411 : IEnumerable<ElementAssignmentConflictInfo>, IEnumerable, IEnumerator<ElementAssignmentConflictInfo>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private ElementAssignmentConflictInfo <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x40
		private Player player; //Field offset: 0x48
		public Player <>3__player; //Field offset: 0x50
		private InputMapping mapping; //Field offset: 0x58
		public InputMapping <>3__mapping; //Field offset: 0x60
		public ControlMapper <>4__this; //Field offset: 0x68
		private ElementAssignment assignment; //Field offset: 0x70
		public ElementAssignment <>3__assignment; //Field offset: 0x94
		private bool skipOtherPlayers; //Field offset: 0xB8
		public bool <>3__skipOtherPlayers; //Field offset: 0xB9
		private ElementAssignmentConflictCheck <conflictCheck>5__2; //Field offset: 0xBC
		private IEnumerator<ElementAssignmentConflictInfo> <>7__wrap2; //Field offset: 0xF8

		private override ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 35
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 95
		}

		[DebuggerHidden]
		public <ElementAssignmentConflicts>d__411(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<ElementAssignmentConflictInfo> System.Collections.Generic.IEnumerable<Rewired.ElementAssignmentConflictInfo>.GetEnumerator() { }

		[DebuggerHidden]
		private override ElementAssignmentConflictInfo System.Collections.Generic.IEnumerator<Rewired.ElementAssignmentConflictInfo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class AxisCalibrator
	{
		public AxisCalibrationData data; //Field offset: 0x10
		public readonly Joystick joystick; //Field offset: 0x48
		public readonly int axisIndex; //Field offset: 0x50
		private Axis axis; //Field offset: 0x58
		private bool firstRun; //Field offset: 0x60

		public bool isValid
		{
			 get { } //Length: 9
		}

		public AxisCalibrator(Joystick joystick, int axisIndex) { }

		public void Commit() { }

		public bool get_isValid() { }

		public void RecordMinMax() { }

		public void RecordZero() { }

	}

	private class GUIButton : GUIElement
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass7_0
		{
			public Action<ButtonInfo> callback; //Field offset: 0x10
			public GUIButton <>4__this; //Field offset: 0x18

			public <>c__DisplayClass7_0() { }

			internal void <SetOnClickCallback>b__0() { }

		}


		protected Button button
		{
			 get { } //Length: 125
		}

		public ButtonInfo buttonInfo
		{
			 get { } //Length: 125
		}

		public GUIButton(GameObject gameObject) { }

		public GUIButton(Button button, Text label) { }

		protected Button get_button() { }

		public ButtonInfo get_buttonInfo() { }

		public void SetButtonInfoData(string identifier, int intData) { }

		public void SetOnClickCallback(Action<ButtonInfo> callback) { }

	}

	private abstract class GUIElement
	{
		public readonly GameObject gameObject; //Field offset: 0x10
		protected readonly Text text; //Field offset: 0x18
		public readonly Selectable selectable; //Field offset: 0x20
		protected readonly UIElementInfo uiElementInfo; //Field offset: 0x28
		protected bool permanentStateSet; //Field offset: 0x30
		protected readonly List<GUIElement> children; //Field offset: 0x38
		[CompilerGenerated]
		private RectTransform <rectTransform>k__BackingField; //Field offset: 0x40

		public private RectTransform rectTransform
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public GUIElement(GameObject gameObject) { }

		public GUIElement(Selectable selectable, Text label) { }

		public override void AddChild(GUIElement child) { }

		[CompilerGenerated]
		public RectTransform get_rectTransform() { }

		public override string GetLabel() { }

		protected override bool Init() { }

		[CompilerGenerated]
		private void set_rectTransform(RectTransform value) { }

		public override void SetActive(bool state) { }

		public void SetElementInfoData(string identifier, int intData) { }

		public override void SetFirstChildObjectWidth(LayoutElementSizeType type, int value) { }

		public override void SetInteractible(bool state, bool playTransition) { }

		public override void SetInteractible(bool state, bool playTransition, bool permanent) { }

		public override void SetLabel(string label) { }

		public override void SetTextWidth(int value) { }

	}

	private class GUIInputField : GUIElement
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass19_0
		{
			public Action<InputFieldInfo> callback; //Field offset: 0x10
			public GUIInputField <>4__this; //Field offset: 0x18

			public <>c__DisplayClass19_0() { }

			internal void <SetOnClickCallback>b__0() { }

		}

		[CompilerGenerated]
		private GUIToggle <toggle>k__BackingField; //Field offset: 0x48

		public int actionElementMapId
		{
			 get { } //Length: 150
			 set { } //Length: 146
		}

		protected Button button
		{
			 get { } //Length: 125
		}

		public int controllerId
		{
			 get { } //Length: 150
			 set { } //Length: 146
		}

		public InputFieldInfo fieldInfo
		{
			 get { } //Length: 125
		}

		public bool hasToggle
		{
			 get { } //Length: 9
		}

		public private GUIToggle toggle
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public GUIInputField(GameObject gameObject) { }

		public GUIInputField(Button button, Text label) { }

		public void AddToggle(GUIToggle toggle) { }

		public int get_actionElementMapId() { }

		protected Button get_button() { }

		public int get_controllerId() { }

		public InputFieldInfo get_fieldInfo() { }

		public bool get_hasToggle() { }

		[CompilerGenerated]
		public GUIToggle get_toggle() { }

		public void set_actionElementMapId(int value) { }

		public void set_controllerId(int value) { }

		[CompilerGenerated]
		private void set_toggle(GUIToggle value) { }

		public void SetFieldInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData) { }

		public override void SetInteractable(bool state, bool playTransition, bool permanent) { }

		public void SetOnClickCallback(Action<InputFieldInfo> callback) { }

	}

	private class GUILabel
	{
		[CompilerGenerated]
		private GameObject <gameObject>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private Text <text>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private RectTransform <rectTransform>k__BackingField; //Field offset: 0x20

		public private GameObject gameObject
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private RectTransform rectTransform
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		private Text text
		{
			[CompilerGenerated]
			private get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public GUILabel(GameObject gameObject) { }

		public GUILabel(Text label) { }

		private bool Check() { }

		[CompilerGenerated]
		public GameObject get_gameObject() { }

		[CompilerGenerated]
		public RectTransform get_rectTransform() { }

		[CompilerGenerated]
		private Text get_text() { }

		[CompilerGenerated]
		private void set_gameObject(GameObject value) { }

		[CompilerGenerated]
		private void set_rectTransform(RectTransform value) { }

		[CompilerGenerated]
		private void set_text(Text value) { }

		public void SetActive(bool state) { }

		public void SetFontStyle(FontStyle style) { }

		public void SetHeight(int height) { }

		public void SetLabel(string label) { }

		public void SetSize(int width, int height) { }

		public void SetTextAlignment(TextAnchor alignment) { }

		public void SetWidth(int width) { }

	}

	private class GUIToggle : GUIElement
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			public Action<ToggleInfo, Boolean> callback; //Field offset: 0x10
			public GUIToggle <>4__this; //Field offset: 0x18

			public <>c__DisplayClass10_0() { }

			internal void <SetOnSubmitCallback>b__0(BaseEventData data) { }

		}


		public int actionElementMapId
		{
			 get { } //Length: 150
			 set { } //Length: 146
		}

		protected Toggle toggle
		{
			 get { } //Length: 125
		}

		public ToggleInfo toggleInfo
		{
			 get { } //Length: 125
		}

		public GUIToggle(GameObject gameObject) { }

		public GUIToggle(Toggle toggle, Text label) { }

		public int get_actionElementMapId() { }

		protected Toggle get_toggle() { }

		public ToggleInfo get_toggleInfo() { }

		public void set_actionElementMapId(int value) { }

		public void SetOnSubmitCallback(Action<ToggleInfo, Boolean> callback) { }

		public void SetToggleInfoData(int actionId, AxisRange axisRange, ControllerType controllerType, int intData) { }

		public void SetToggleState(bool state) { }

	}

	[DefaultMember(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private class IndexedDictionary
	{
		private class Entry
		{
			public TKey key; //Field offset: 0x0
			public TValue value; //Field offset: 0x0

			public Entry(TKey key, TValue value) { }

		}

		private List<Entry<TKey, TValue>> list; //Field offset: 0x0

		public int Count
		{
			 get { } //Length: 42
		}

		public TValue Item
		{
			 get { } //Length: 52
		}

		public IndexedDictionary`2() { }

		public void Add(TKey key, TValue value) { }

		public void Clear() { }

		public bool ContainsKey(TKey key) { }

		public TValue Get(TKey key) { }

		public int get_Count() { }

		public TValue get_Item(int index) { }

		public int IndexOfKey(TKey key) { }

		public bool TryGet(TKey key, out TValue value) { }

	}

	private class InputActionSet
	{
		private int _actionId; //Field offset: 0x10
		private AxisRange _axisRange; //Field offset: 0x14

		public int actionId
		{
			 get { } //Length: 4
		}

		public AxisRange axisRange
		{
			 get { } //Length: 4
		}

		public InputActionSet(int actionId, AxisRange axisRange) { }

		public int get_actionId() { }

		public AxisRange get_axisRange() { }

	}

	internal class InputBehaviorSettings
	{
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private int _inputBehaviorId; //Field offset: 0x10
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _showJoystickAxisSensitivity; //Field offset: 0x14
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _showMouseXYAxisSensitivity; //Field offset: 0x15
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private string _labelLanguageKey; //Field offset: 0x18
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private string _joystickAxisSensitivityLabelLanguageKey; //Field offset: 0x20
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private string _mouseXYAxisSensitivityLabelLanguageKey; //Field offset: 0x28
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private Sprite _joystickAxisSensitivityIcon; //Field offset: 0x30
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private Sprite _mouseXYAxisSensitivityIcon; //Field offset: 0x38
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _joystickAxisSensitivityMin; //Field offset: 0x40
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _joystickAxisSensitivityMax; //Field offset: 0x44
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _mouseXYAxisSensitivityMin; //Field offset: 0x48
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _mouseXYAxisSensitivityMax; //Field offset: 0x4C

		public int inputBehaviorId
		{
			 get { } //Length: 4
		}

		public bool isValid
		{
			 get { } //Length: 22
		}

		public Sprite joystickAxisSensitivityIcon
		{
			 get { } //Length: 5
		}

		public string joystickAxisSensitivityLabelLanguageKey
		{
			 get { } //Length: 5
		}

		public float joystickAxisSensitivityMax
		{
			 get { } //Length: 6
		}

		public float joystickAxisSensitivityMin
		{
			 get { } //Length: 6
		}

		public string labelLanguageKey
		{
			 get { } //Length: 5
		}

		public Sprite mouseXYAxisSensitivityIcon
		{
			 get { } //Length: 5
		}

		public string mouseXYAxisSensitivityLabelLanguageKey
		{
			 get { } //Length: 5
		}

		public float mouseXYAxisSensitivityMax
		{
			 get { } //Length: 6
		}

		public float mouseXYAxisSensitivityMin
		{
			 get { } //Length: 6
		}

		public bool showJoystickAxisSensitivity
		{
			 get { } //Length: 5
		}

		public bool showMouseXYAxisSensitivity
		{
			 get { } //Length: 5
		}

		public InputBehaviorSettings() { }

		public int get_inputBehaviorId() { }

		public bool get_isValid() { }

		public Sprite get_joystickAxisSensitivityIcon() { }

		public string get_joystickAxisSensitivityLabelLanguageKey() { }

		public float get_joystickAxisSensitivityMax() { }

		public float get_joystickAxisSensitivityMin() { }

		public string get_labelLanguageKey() { }

		public Sprite get_mouseXYAxisSensitivityIcon() { }

		public string get_mouseXYAxisSensitivityLabelLanguageKey() { }

		public float get_mouseXYAxisSensitivityMax() { }

		public float get_mouseXYAxisSensitivityMin() { }

		public bool get_showJoystickAxisSensitivity() { }

		public bool get_showMouseXYAxisSensitivity() { }

	}

	private class InputGrid
	{
		private InputGridEntryList list; //Field offset: 0x10
		private List<GameObject> groups; //Field offset: 0x18

		public InputGrid() { }

		public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange) { }

		public void AddActionCategory(int mapCategoryId, int actionCategoryId) { }

		public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label) { }

		public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label) { }

		public void AddGroup(GameObject group) { }

		public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField) { }

		public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer) { }

		public void AddMapCategory(int mapCategoryId) { }

		public void ClearAll() { }

		private void ClearGroups() { }

		public void ClearLabels(int mapCategoryId) { }

		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

		public IEnumerable<InputActionSet> GetActionSets(int mapCategoryId) { }

		public float GetColumnHeight(int mapCategoryId) { }

		public GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

		public void HideAll() { }

		public void InitializeFields(int mapCategoryId) { }

		public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

		public void SetColumnHeight(int mapCategoryId, float height) { }

		public void SetFieldLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label) { }

		public void SetFieldsActive(int mapCategoryId, bool state) { }

		public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId) { }

		public void Show(int mapCategoryId) { }

	}

	private class InputGridEntryList
	{
		[CompilerGenerated]
		private sealed class <GetActionSets>d__18 : IEnumerable<InputActionSet>, IEnumerable, IEnumerator<InputActionSet>, IEnumerator, IDisposable
		{
			private int <>1__state; //Field offset: 0x10
			private InputActionSet <>2__current; //Field offset: 0x18
			private int <>l__initialThreadId; //Field offset: 0x20
			public InputGridEntryList <>4__this; //Field offset: 0x28
			private int mapCategoryId; //Field offset: 0x30
			public int <>3__mapCategoryId; //Field offset: 0x34
			private List<ActionEntry> <list>5__2; //Field offset: 0x38
			private int <count>5__3; //Field offset: 0x40
			private int <i>5__4; //Field offset: 0x44

			private override InputActionSet System.Collections.Generic.IEnumerator<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			private override object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				private get { } //Length: 5
			}

			[DebuggerHidden]
			public <GetActionSets>d__18(int <>1__state) { }

			private override bool MoveNext() { }

			[DebuggerHidden]
			private override IEnumerator<InputActionSet> System.Collections.Generic.IEnumerable<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.GetEnumerator() { }

			[DebuggerHidden]
			private override InputActionSet System.Collections.Generic.IEnumerator<Rewired.UI.ControlMapper.ControlMapper.InputActionSet>.get_Current() { }

			[DebuggerHidden]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[DebuggerHidden]
			private override object System.Collections.IEnumerator.get_Current() { }

			[DebuggerHidden]
			private override void System.Collections.IEnumerator.Reset() { }

			[DebuggerHidden]
			private override void System.IDisposable.Dispose() { }

		}

		private class ActionCategoryEntry
		{
			public readonly int actionCategoryId; //Field offset: 0x10
			public GUILabel label; //Field offset: 0x18

			public ActionCategoryEntry(int actionCategoryId) { }

			public void SetActive(bool state) { }

			public void SetLabel(GUILabel label) { }

		}

		private class ActionEntry
		{
			private IndexedDictionary<Int32, FieldSet> fieldSets; //Field offset: 0x10
			public GUILabel label; //Field offset: 0x18
			public readonly InputAction action; //Field offset: 0x20
			public readonly AxisRange axisRange; //Field offset: 0x28
			public readonly InputActionSet actionSet; //Field offset: 0x30

			public ActionEntry(InputAction action, AxisRange axisRange) { }

			public void AddInputField(ControllerType controllerType, int fieldIndex, GUIInputField inputField) { }

			public void AddInputFieldSet(ControllerType controllerType, GameObject fieldSetContainer) { }

			public void ClearLabels() { }

			public bool Contains(ControllerType controllerType, int fieldId) { }

			public GUIInputField GetGUIInputField(ControllerType controllerType, int fieldIndex) { }

			public void Initialize() { }

			public bool Matches(int actionId, AxisRange axisRange) { }

			public void PopulateField(ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

			public void SetActive(bool state) { }

			public void SetFieldLabel(ControllerType controllerType, int index, string label) { }

			public void SetFieldsActive(bool state) { }

			public void SetFixedFieldData(ControllerType controllerType, int controllerId) { }

			public void SetLabel(GUILabel label) { }

		}

		private class FieldSet
		{
			public readonly GameObject groupContainer; //Field offset: 0x10
			public readonly IndexedDictionary<Int32, GUIInputField> fields; //Field offset: 0x18

			public FieldSet(GameObject groupContainer) { }

		}

		private class MapCategoryEntry
		{
			private List<ActionEntry> _actionList; //Field offset: 0x10
			private IndexedDictionary<Int32, ActionCategoryEntry> _actionCategoryList; //Field offset: 0x18
			private float _columnHeight; //Field offset: 0x20

			public IndexedDictionary<Int32, ActionCategoryEntry> actionCategoryList
			{
				 get { } //Length: 5
			}

			public List<ActionEntry> actionList
			{
				 get { } //Length: 5
			}

			public float columnHeight
			{
				 get { } //Length: 6
				 set { } //Length: 6
			}

			public MapCategoryEntry() { }

			public ActionEntry AddAction(InputAction action, AxisRange axisRange) { }

			public ActionCategoryEntry AddActionCategory(int actionCategoryId) { }

			public bool ContainsActionEntry(int actionId, AxisRange axisRange) { }

			public IndexedDictionary<Int32, ActionCategoryEntry> get_actionCategoryList() { }

			public List<ActionEntry> get_actionList() { }

			public float get_columnHeight() { }

			public ActionCategoryEntry GetActionCategoryEntry(int actionCategoryId) { }

			public ActionEntry GetActionEntry(int actionId, AxisRange axisRange) { }

			public int IndexOfActionEntry(int actionId, AxisRange axisRange) { }

			public void set_columnHeight(float value) { }

			public void SetAllActive(bool state) { }

		}

		private IndexedDictionary<Int32, MapCategoryEntry> entries; //Field offset: 0x10

		public InputGridEntryList() { }

		public void AddAction(int mapCategoryId, InputAction action, AxisRange axisRange) { }

		public void AddActionCategory(int mapCategoryId, int actionCategoryId) { }

		private ActionCategoryEntry AddActionCategoryEntry(int mapCategoryId, int actionCategoryId) { }

		public void AddActionCategoryLabel(int mapCategoryId, int actionCategoryId, GUILabel label) { }

		private ActionEntry AddActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange) { }

		public void AddActionLabel(int mapCategoryId, int actionId, AxisRange axisRange, GUILabel label) { }

		public void AddInputField(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int fieldIndex, GUIInputField inputField) { }

		public void AddInputFieldSet(int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, GameObject fieldSetContainer) { }

		public void AddMapCategory(int mapCategoryId) { }

		public void Clear() { }

		public void ClearLabels(int mapCategoryId) { }

		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

		public bool Contains(int mapCategoryId, int actionId, AxisRange axisRange) { }

		private ActionEntry GetActionEntry(int mapCategoryId, int actionId, AxisRange axisRange) { }

		private ActionEntry GetActionEntry(int mapCategoryId, InputAction action, AxisRange axisRange) { }

		[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
		public IEnumerable<InputActionSet> GetActionSets(int mapCategoryId) { }

		public float GetColumnHeight(int mapCategoryId) { }

		public GUIInputField GetGUIInputField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

		public void HideAll() { }

		public void InitializeFields(int mapCategoryId) { }

		public void PopulateField(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId, int index, int actionElementMapId, string label, bool invert) { }

		public void SetColumnHeight(int mapCategoryId, float height) { }

		public void SetFieldsActive(int mapCategoryId, bool state) { }

		public void SetFixedFieldData(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int controllerId) { }

		public void SetLabel(int mapCategoryId, int actionId, AxisRange axisRange, ControllerType controllerType, int index, string label) { }

		public void Show(int mapCategoryId) { }

	}

	private class InputMapping
	{
		[CompilerGenerated]
		private string <actionName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private InputFieldInfo <fieldInfo>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private ControllerMap <map>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private ActionElementMap <aem>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private ControllerType <controllerType>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		private int <controllerId>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private ControllerPollingInfo <pollingInfo>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		private ModifierKeyFlags <modifierKeyFlags>k__BackingField; //Field offset: 0x70

		public private string actionName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private ActionElementMap aem
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public AxisRange axisRange
		{
			 get { } //Length: 79
		}

		public private int controllerId
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private ControllerType controllerType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public string elementName
		{
			 get { } //Length: 306
		}

		public private InputFieldInfo fieldInfo
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public private ControllerMap map
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 12
		}

		public ModifierKeyFlags modifierKeyFlags
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public ControllerPollingInfo pollingInfo
		{
			[CompilerGenerated]
			 get { } //Length: 37
			[CompilerGenerated]
			 set { } //Length: 44
		}

		public InputMapping(string actionName, InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, ControllerType controllerType, int controllerId) { }

		[CompilerGenerated]
		public string get_actionName() { }

		[CompilerGenerated]
		public ActionElementMap get_aem() { }

		public AxisRange get_axisRange() { }

		[CompilerGenerated]
		public int get_controllerId() { }

		[CompilerGenerated]
		public ControllerType get_controllerType() { }

		public string get_elementName() { }

		[CompilerGenerated]
		public InputFieldInfo get_fieldInfo() { }

		[CompilerGenerated]
		public ControllerMap get_map() { }

		[CompilerGenerated]
		public ModifierKeyFlags get_modifierKeyFlags() { }

		[CompilerGenerated]
		public ControllerPollingInfo get_pollingInfo() { }

		[CompilerGenerated]
		private void set_actionName(string value) { }

		[CompilerGenerated]
		private void set_aem(ActionElementMap value) { }

		[CompilerGenerated]
		private void set_controllerId(int value) { }

		[CompilerGenerated]
		private void set_controllerType(ControllerType value) { }

		[CompilerGenerated]
		private void set_fieldInfo(InputFieldInfo value) { }

		[CompilerGenerated]
		private void set_map(ControllerMap value) { }

		[CompilerGenerated]
		public void set_modifierKeyFlags(ModifierKeyFlags value) { }

		[CompilerGenerated]
		public void set_pollingInfo(ControllerPollingInfo value) { }

		public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo) { }

		public ElementAssignment ToElementAssignment(ControllerPollingInfo pollingInfo, ModifierKeyFlags modifierKeyFlags) { }

		public ElementAssignment ToElementAssignment() { }

	}

	private enum LayoutElementSizeType
	{
		MinSize = 0,
		PreferredSize = 1,
	}

	internal class MappingSet
	{
		internal enum ActionListMode
		{
			ActionCategory = 0,
			Action = 1,
		}

		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private int _mapCategoryId; //Field offset: 0x10
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private ActionListMode _actionListMode; //Field offset: 0x14
		[SerializeField]
		private Int32[] _actionCategoryIds; //Field offset: 0x18
		[SerializeField]
		private Int32[] _actionIds; //Field offset: 0x20
		private IList<Int32> _actionCategoryIdsReadOnly; //Field offset: 0x28
		private IList<Int32> _actionIdsReadOnly; //Field offset: 0x30

		public IList<Int32> actionCategoryIds
		{
			 get { } //Length: 146
		}

		public IList<Int32> actionIds
		{
			 get { } //Length: 156
		}

		public ActionListMode actionListMode
		{
			 get { } //Length: 4
		}

		public static MappingSet Default
		{
			 get { } //Length: 160
		}

		public bool isValid
		{
			 get { } //Length: 130
		}

		public int mapCategoryId
		{
			 get { } //Length: 4
		}

		public MappingSet() { }

		private MappingSet(int mapCategoryId, ActionListMode actionListMode, Int32[] actionCategoryIds, Int32[] actionIds) { }

		public IList<Int32> get_actionCategoryIds() { }

		public IList<Int32> get_actionIds() { }

		public ActionListMode get_actionListMode() { }

		public static MappingSet get_Default() { }

		public bool get_isValid() { }

		public int get_mapCategoryId() { }

	}

	private class Prefabs
	{
		[SerializeField]
		private GameObject _button; //Field offset: 0x10
		[SerializeField]
		private GameObject _fitButton; //Field offset: 0x18
		[SerializeField]
		private GameObject _inputGridLabel; //Field offset: 0x20
		[SerializeField]
		private GameObject _inputGridHeaderLabel; //Field offset: 0x28
		[SerializeField]
		private GameObject _inputGridFieldButton; //Field offset: 0x30
		[SerializeField]
		private GameObject _inputGridFieldInvertToggle; //Field offset: 0x38
		[SerializeField]
		private GameObject _window; //Field offset: 0x40
		[SerializeField]
		private GameObject _windowTitleText; //Field offset: 0x48
		[SerializeField]
		private GameObject _windowContentText; //Field offset: 0x50
		[SerializeField]
		private GameObject _fader; //Field offset: 0x58
		[SerializeField]
		private GameObject _calibrationWindow; //Field offset: 0x60
		[SerializeField]
		private GameObject _inputBehaviorsWindow; //Field offset: 0x68
		[SerializeField]
		private GameObject _centerStickGraphic; //Field offset: 0x70
		[SerializeField]
		private GameObject _moveStickGraphic; //Field offset: 0x78

		public GameObject button
		{
			 get { } //Length: 5
		}

		public GameObject calibrationWindow
		{
			 get { } //Length: 5
		}

		public GameObject centerStickGraphic
		{
			 get { } //Length: 5
		}

		public GameObject fader
		{
			 get { } //Length: 5
		}

		public GameObject fitButton
		{
			 get { } //Length: 5
		}

		public GameObject inputBehaviorsWindow
		{
			 get { } //Length: 5
		}

		public GameObject inputGridFieldButton
		{
			 get { } //Length: 5
		}

		public GameObject inputGridFieldInvertToggle
		{
			 get { } //Length: 5
		}

		public GameObject inputGridHeaderLabel
		{
			 get { } //Length: 5
		}

		public GameObject inputGridLabel
		{
			 get { } //Length: 5
		}

		public GameObject moveStickGraphic
		{
			 get { } //Length: 5
		}

		public GameObject window
		{
			 get { } //Length: 5
		}

		public GameObject windowContentText
		{
			 get { } //Length: 5
		}

		public GameObject windowTitleText
		{
			 get { } //Length: 5
		}

		public Prefabs() { }

		public bool Check() { }

		public GameObject get_button() { }

		public GameObject get_calibrationWindow() { }

		public GameObject get_centerStickGraphic() { }

		public GameObject get_fader() { }

		public GameObject get_fitButton() { }

		public GameObject get_inputBehaviorsWindow() { }

		public GameObject get_inputGridFieldButton() { }

		public GameObject get_inputGridFieldInvertToggle() { }

		public GameObject get_inputGridHeaderLabel() { }

		public GameObject get_inputGridLabel() { }

		public GameObject get_moveStickGraphic() { }

		public GameObject get_window() { }

		public GameObject get_windowContentText() { }

		public GameObject get_windowTitleText() { }

	}

	private class References
	{
		[SerializeField]
		private Canvas _canvas; //Field offset: 0x10
		[SerializeField]
		private CanvasGroup _mainCanvasGroup; //Field offset: 0x18
		[SerializeField]
		private Transform _mainContent; //Field offset: 0x20
		[SerializeField]
		private Transform _mainContentInner; //Field offset: 0x28
		[SerializeField]
		private UIGroup _playersGroup; //Field offset: 0x30
		[SerializeField]
		private Transform _controllerGroup; //Field offset: 0x38
		[SerializeField]
		private Transform _controllerGroupLabelGroup; //Field offset: 0x40
		[SerializeField]
		private UIGroup _controllerSettingsGroup; //Field offset: 0x48
		[SerializeField]
		private UIGroup _assignedControllersGroup; //Field offset: 0x50
		[SerializeField]
		private Transform _settingsAndMapCategoriesGroup; //Field offset: 0x58
		[SerializeField]
		private UIGroup _settingsGroup; //Field offset: 0x60
		[SerializeField]
		private UIGroup _mapCategoriesGroup; //Field offset: 0x68
		[SerializeField]
		private Transform _inputGridGroup; //Field offset: 0x70
		[SerializeField]
		private Transform _inputGridContainer; //Field offset: 0x78
		[SerializeField]
		private Transform _inputGridHeadersGroup; //Field offset: 0x80
		[SerializeField]
		private Scrollbar _inputGridVScrollbar; //Field offset: 0x88
		[SerializeField]
		private ScrollRect _inputGridScrollRect; //Field offset: 0x90
		[SerializeField]
		private Transform _inputGridInnerGroup; //Field offset: 0x98
		[SerializeField]
		private Text _controllerNameLabel; //Field offset: 0xA0
		[SerializeField]
		private Button _removeControllerButton; //Field offset: 0xA8
		[SerializeField]
		private Button _assignControllerButton; //Field offset: 0xB0
		[SerializeField]
		private Button _calibrateControllerButton; //Field offset: 0xB8
		[SerializeField]
		private Button _doneButton; //Field offset: 0xC0
		[SerializeField]
		private Button _restoreDefaultsButton; //Field offset: 0xC8
		[SerializeField]
		private Selectable _defaultSelection; //Field offset: 0xD0
		[SerializeField]
		private GameObject[] _fixedSelectableUIElements; //Field offset: 0xD8
		[SerializeField]
		private Image _mainBackgroundImage; //Field offset: 0xE0
		[CompilerGenerated]
		private LayoutElement <inputGridLayoutElement>k__BackingField; //Field offset: 0xE8
		[CompilerGenerated]
		private Transform <inputGridActionColumn>k__BackingField; //Field offset: 0xF0
		[CompilerGenerated]
		private Transform <inputGridKeyboardColumn>k__BackingField; //Field offset: 0xF8
		[CompilerGenerated]
		private Transform <inputGridMouseColumn>k__BackingField; //Field offset: 0x100
		[CompilerGenerated]
		private Transform <inputGridControllerColumn>k__BackingField; //Field offset: 0x108
		[CompilerGenerated]
		private Transform <inputGridHeader1>k__BackingField; //Field offset: 0x110
		[CompilerGenerated]
		private Transform <inputGridHeader2>k__BackingField; //Field offset: 0x118
		[CompilerGenerated]
		private Transform <inputGridHeader3>k__BackingField; //Field offset: 0x120
		[CompilerGenerated]
		private Transform <inputGridHeader4>k__BackingField; //Field offset: 0x128

		public Button assignControllerButton
		{
			 get { } //Length: 8
		}

		public UIGroup assignedControllersGroup
		{
			 get { } //Length: 5
		}

		public Button calibrateControllerButton
		{
			 get { } //Length: 8
		}

		public Canvas canvas
		{
			 get { } //Length: 5
		}

		public Transform controllerGroup
		{
			 get { } //Length: 5
		}

		public Transform controllerGroupLabelGroup
		{
			 get { } //Length: 5
		}

		public Text controllerNameLabel
		{
			 get { } //Length: 8
		}

		public UIGroup controllerSettingsGroup
		{
			 get { } //Length: 5
		}

		public Selectable defaultSelection
		{
			 get { } //Length: 8
		}

		public Button doneButton
		{
			 get { } //Length: 8
		}

		public GameObject[] fixedSelectableUIElements
		{
			 get { } //Length: 8
		}

		public Transform inputGridActionColumn
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridContainer
		{
			 get { } //Length: 5
		}

		public Transform inputGridControllerColumn
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridGroup
		{
			 get { } //Length: 5
		}

		public Transform inputGridHeader1
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridHeader2
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridHeader3
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridHeader4
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridHeadersGroup
		{
			 get { } //Length: 8
		}

		public Transform inputGridInnerGroup
		{
			 get { } //Length: 8
		}

		public Transform inputGridKeyboardColumn
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public LayoutElement inputGridLayoutElement
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public Transform inputGridMouseColumn
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			 set { } //Length: 15
		}

		public ScrollRect inputGridScrollRect
		{
			 get { } //Length: 8
		}

		public Scrollbar inputGridVScrollbar
		{
			 get { } //Length: 8
		}

		public Image mainBackgroundImage
		{
			 get { } //Length: 8
		}

		public CanvasGroup mainCanvasGroup
		{
			 get { } //Length: 5
		}

		public Transform mainContent
		{
			 get { } //Length: 5
		}

		public Transform mainContentInner
		{
			 get { } //Length: 5
		}

		public UIGroup mapCategoriesGroup
		{
			 get { } //Length: 5
		}

		public UIGroup playersGroup
		{
			 get { } //Length: 5
		}

		public Button removeControllerButton
		{
			 get { } //Length: 8
		}

		public Button restoreDefaultsButton
		{
			 get { } //Length: 8
		}

		public Transform settingsAndMapCategoriesGroup
		{
			 get { } //Length: 5
		}

		public UIGroup settingsGroup
		{
			 get { } //Length: 5
		}

		public References() { }

		public bool Check() { }

		public Button get_assignControllerButton() { }

		public UIGroup get_assignedControllersGroup() { }

		public Button get_calibrateControllerButton() { }

		public Canvas get_canvas() { }

		public Transform get_controllerGroup() { }

		public Transform get_controllerGroupLabelGroup() { }

		public Text get_controllerNameLabel() { }

		public UIGroup get_controllerSettingsGroup() { }

		public Selectable get_defaultSelection() { }

		public Button get_doneButton() { }

		public GameObject[] get_fixedSelectableUIElements() { }

		[CompilerGenerated]
		public Transform get_inputGridActionColumn() { }

		public Transform get_inputGridContainer() { }

		[CompilerGenerated]
		public Transform get_inputGridControllerColumn() { }

		public Transform get_inputGridGroup() { }

		[CompilerGenerated]
		public Transform get_inputGridHeader1() { }

		[CompilerGenerated]
		public Transform get_inputGridHeader2() { }

		[CompilerGenerated]
		public Transform get_inputGridHeader3() { }

		[CompilerGenerated]
		public Transform get_inputGridHeader4() { }

		public Transform get_inputGridHeadersGroup() { }

		public Transform get_inputGridInnerGroup() { }

		[CompilerGenerated]
		public Transform get_inputGridKeyboardColumn() { }

		[CompilerGenerated]
		public LayoutElement get_inputGridLayoutElement() { }

		[CompilerGenerated]
		public Transform get_inputGridMouseColumn() { }

		public ScrollRect get_inputGridScrollRect() { }

		public Scrollbar get_inputGridVScrollbar() { }

		public Image get_mainBackgroundImage() { }

		public CanvasGroup get_mainCanvasGroup() { }

		public Transform get_mainContent() { }

		public Transform get_mainContentInner() { }

		public UIGroup get_mapCategoriesGroup() { }

		public UIGroup get_playersGroup() { }

		public Button get_removeControllerButton() { }

		public Button get_restoreDefaultsButton() { }

		public Transform get_settingsAndMapCategoriesGroup() { }

		public UIGroup get_settingsGroup() { }

		[CompilerGenerated]
		public void set_inputGridActionColumn(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridControllerColumn(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridHeader1(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridHeader2(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridHeader3(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridHeader4(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridKeyboardColumn(Transform value) { }

		[CompilerGenerated]
		public void set_inputGridLayoutElement(LayoutElement value) { }

		[CompilerGenerated]
		public void set_inputGridMouseColumn(Transform value) { }

	}

	private class WindowManager
	{
		private List<Window> windows; //Field offset: 0x10
		private GameObject windowPrefab; //Field offset: 0x18
		private Transform parent; //Field offset: 0x20
		private GameObject fader; //Field offset: 0x28
		private int idCounter; //Field offset: 0x30

		public bool isWindowOpen
		{
			 get { } //Length: 200
		}

		public Window topWindow
		{
			 get { } //Length: 221
		}

		public WindowManager(GameObject windowPrefab, GameObject faderPrefab, Transform parent) { }

		public void CancelAll() { }

		public void ClearCompletely() { }

		public void CloseAll() { }

		public void CloseTop() { }

		public void CloseWindow(int windowId) { }

		public void CloseWindow(Window window) { }

		private void DefocusOtherWindows(int focusedWindowId) { }

		private void DestroyWindow(Window window) { }

		public void Focus(Window window) { }

		public void Focus(int windowId) { }

		private void FocusTopWindow() { }

		public bool get_isWindowOpen() { }

		public Window get_topWindow() { }

		private int GetNewId() { }

		public Window GetWindow(int windowId) { }

		private Window InstantiateWindow(string name, int width, int height) { }

		private Window InstantiateWindow(string name, GameObject windowPrefab) { }

		public bool IsFocused(int windowId) { }

		public Window OpenWindow(GameObject windowPrefab, string name) { }

		public Window OpenWindow(string name, int width, int height) { }

		private void SetFaderActive(bool state) { }

		private void UpdateFader() { }

	}

	private enum WindowType
	{
		None = 0,
		ChooseJoystick = 1,
		JoystickAssignmentConflict = 2,
		ElementAssignment = 3,
		ElementAssignmentPrePolling = 4,
		ElementAssignmentPolling = 5,
		ElementAssignmentResult = 6,
		ElementAssignmentConflict = 7,
		Calibration = 8,
		CalibrateStep1 = 9,
		CalibrateStep2 = 10,
	}

	public const int versionMajor = 1; //Field offset: 0x0
	private const string buttonIdentifier_restoreDefaults = "RestoreDefaults"; //Field offset: 0x0
	private const string buttonIdentifier_done = "Done"; //Field offset: 0x0
	private const string buttonIdentifier_assignedControllerSelection = "AssignedControllerSelection"; //Field offset: 0x0
	private const string buttonIdentifier_mapCategorySelection = "MapCategorySelection"; //Field offset: 0x0
	private const string buttonIdentifier_editInputBehaviors = "EditInputBehaviors"; //Field offset: 0x0
	private const string buttonIdentifier_calibrateController = "CalibrateController"; //Field offset: 0x0
	private static ControlMapper Instance; //Field offset: 0x0
	private const string buttonIdentifier_removeController = "RemoveController"; //Field offset: 0x0
	public const int versionMinor = 1; //Field offset: 0x0
	public const bool usesTMPro = False; //Field offset: 0x0
	private const string buttonIdentifier_assignController = "AssignController"; //Field offset: 0x0
	private const string buttonIdentifier_playerSelection = "PlayerSelection"; //Field offset: 0x0
	private const float blockInputOnFocusTimeout = 0.1; //Field offset: 0x0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InputManager _rewiredInputManager; //Field offset: 0x18
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _dontDestroyOnLoad; //Field offset: 0x20
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _openOnStart; //Field offset: 0x21
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _keyboardMapDefaultLayout; //Field offset: 0x24
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _mouseMapDefaultLayout; //Field offset: 0x28
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _joystickMapDefaultLayout; //Field offset: 0x2C
	[SerializeField]
	private MappingSet[] _mappingSets; //Field offset: 0x30
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showPlayers; //Field offset: 0x38
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showControllers; //Field offset: 0x39
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showKeyboard; //Field offset: 0x3A
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showMouse; //Field offset: 0x3B
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _maxControllersPerPlayer; //Field offset: 0x3C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showActionCategoryLabels; //Field offset: 0x40
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _keyboardInputFieldCount; //Field offset: 0x44
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _mouseInputFieldCount; //Field offset: 0x48
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _controllerInputFieldCount; //Field offset: 0x4C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showFullAxisInputFields; //Field offset: 0x50
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showSplitAxisInputFields; //Field offset: 0x51
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _allowElementAssignmentConflicts; //Field offset: 0x52
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _allowElementAssignmentSwap; //Field offset: 0x53
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _actionLabelWidth; //Field offset: 0x54
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _keyboardColMaxWidth; //Field offset: 0x58
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _mouseColMaxWidth; //Field offset: 0x5C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _controllerColMaxWidth; //Field offset: 0x60
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _inputRowHeight; //Field offset: 0x64
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private RectOffset _inputRowPadding; //Field offset: 0x68
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _inputRowFieldSpacing; //Field offset: 0x70
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _inputColumnSpacing; //Field offset: 0x74
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _inputRowCategorySpacing; //Field offset: 0x78
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _invertToggleWidth; //Field offset: 0x7C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _defaultWindowWidth; //Field offset: 0x80
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _defaultWindowHeight; //Field offset: 0x84
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _controllerAssignmentTimeout; //Field offset: 0x88
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _preInputAssignmentTimeout; //Field offset: 0x8C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _inputAssignmentTimeout; //Field offset: 0x90
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private float _axisCalibrationTimeout; //Field offset: 0x94
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _ignoreMouseXAxisAssignment; //Field offset: 0x98
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _ignoreMouseYAxisAssignment; //Field offset: 0x99
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _screenToggleAction; //Field offset: 0x9C
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _screenOpenAction; //Field offset: 0xA0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _screenCloseAction; //Field offset: 0xA4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _universalCancelAction; //Field offset: 0xA8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _universalCancelClosesScreen; //Field offset: 0xAC
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showInputBehaviorSettings; //Field offset: 0xAD
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InputBehaviorSettings[] _inputBehaviorSettings; //Field offset: 0xB0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _useThemeSettings; //Field offset: 0xB8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ThemeSettings _themeSettings; //Field offset: 0xC0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private LanguageDataBase _language; //Field offset: 0xC8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private Prefabs prefabs; //Field offset: 0xD0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private References references; //Field offset: 0xD8
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showPlayersGroupLabel; //Field offset: 0xE0
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showControllerGroupLabel; //Field offset: 0xE1
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showAssignedControllersGroupLabel; //Field offset: 0xE2
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showSettingsGroupLabel; //Field offset: 0xE3
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showMapCategoriesGroupLabel; //Field offset: 0xE4
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showControllerNameLabel; //Field offset: 0xE5
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private bool _showAssignedControllers; //Field offset: 0xE6
	private Action _ScreenClosedEvent; //Field offset: 0xE8
	private Action _ScreenOpenedEvent; //Field offset: 0xF0
	private Action _PopupWindowOpenedEvent; //Field offset: 0xF8
	private Action _PopupWindowClosedEvent; //Field offset: 0x100
	private Action _InputPollingStartedEvent; //Field offset: 0x108
	private Action _InputPollingEndedEvent; //Field offset: 0x110
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onScreenClosed; //Field offset: 0x118
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onScreenOpened; //Field offset: 0x120
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onPopupWindowClosed; //Field offset: 0x128
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onPopupWindowOpened; //Field offset: 0x130
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInputPollingStarted; //Field offset: 0x138
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private UnityEvent _onInputPollingEnded; //Field offset: 0x140
	private bool initialized; //Field offset: 0x148
	private int playerCount; //Field offset: 0x14C
	private InputGrid inputGrid; //Field offset: 0x150
	private WindowManager windowManager; //Field offset: 0x158
	private int currentPlayerId; //Field offset: 0x160
	private int currentMapCategoryId; //Field offset: 0x164
	private List<GUIButton> playerButtons; //Field offset: 0x168
	private List<GUIButton> mapCategoryButtons; //Field offset: 0x170
	private List<GUIButton> assignedControllerButtons; //Field offset: 0x178
	private GUIButton assignedControllerButtonsPlaceholder; //Field offset: 0x180
	private List<GameObject> miscInstantiatedObjects; //Field offset: 0x188
	private GameObject canvas; //Field offset: 0x190
	private GameObject lastUISelection; //Field offset: 0x198
	private int currentJoystickId; //Field offset: 0x1A0
	private float blockInputOnFocusEndTime; //Field offset: 0x1A4
	private bool isPollingForInput; //Field offset: 0x1A8
	private InputMapping pendingInputMapping; //Field offset: 0x1B0
	private AxisCalibrator pendingAxisCalibration; //Field offset: 0x1B8
	private Action<InputFieldInfo> inputFieldActivatedDelegate; //Field offset: 0x1C0
	private Action<ToggleInfo, Boolean> inputFieldInvertToggleStateChangedDelegate; //Field offset: 0x1C8
	private Action _restoreDefaultsDelegate; //Field offset: 0x1D0

	public event Action InputPollingEndedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public event Action InputPollingStartedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public event UnityAction onInputPollingEnded
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction onInputPollingStarted
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction onPopupWindowClosed
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction onPopupWindowOpened
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction onScreenClosed
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event UnityAction onScreenOpened
	{
		 add { } //Length: 33
		 remove { } //Length: 33
	}

	public event Action PopupWindowClosedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public event Action PopupWindowOpenedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public event Action ScreenClosedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public event Action ScreenOpenedEvent
	{
		 add { } //Length: 127
		 remove { } //Length: 127
	}

	public int actionLabelWidth
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public bool allowElementAssignmentConflicts
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public bool allowElementAssignmentSwap
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	public float axisCalibrationTimeout
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public float controllerAssignmentTimeout
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public int controllerColMaxWidth
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int controllerInputFieldCount
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	private Joystick currentJoystick
	{
		private get { } //Length: 105
	}

	private InputCategory currentMapCategory
	{
		private get { } //Length: 105
	}

	private MappingSet currentMappingSet
	{
		private get { } //Length: 94
	}

	private Player currentPlayer
	{
		private get { } //Length: 105
	}

	private GameObject currentUISelection
	{
		private get { } //Length: 185
	}

	public int defaultWindowHeight
	{
		 get { } //Length: 7
		 set { } //Length: 22
	}

	public int defaultWindowWidth
	{
		 get { } //Length: 7
		 set { } //Length: 22
	}

	public bool dontDestroyOnLoad
	{
		 get { } //Length: 5
		 set { } //Length: 149
	}

	public bool ignoreMouseXAxisAssignment
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool ignoreMouseYAxisAssignment
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	private bool inputAllowed
	{
		private get { } //Length: 40
	}

	public float inputAssignmentTimeout
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public int inputColumnSpacing
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	private int inputGridColumnCount
	{
		private get { } //Length: 33
	}

	private int inputGridWidth
	{
		private get { } //Length: 117
	}

	public int inputRowCategorySpacing
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int inputRowHeight
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int invertToggleWidth
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	private bool isFocused
	{
		private get { } //Length: 54
	}

	private bool isJoystickSelected
	{
		private get { } //Length: 12
	}

	public bool isOpen
	{
		 get { } //Length: 207
	}

	public int joystickMapDefaultLayout
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int keyboardColMaxWidth
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int keyboardInputFieldCount
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int keyboardMapDefaultLayout
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public LanguageDataBase language
	{
		 get { } //Length: 8
		 set { } //Length: 183
	}

	public int maxControllersPerPlayer
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int mouseColMaxWidth
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int mouseInputFieldCount
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public int mouseMapDefaultLayout
	{
		 get { } //Length: 4
		 set { } //Length: 19
	}

	public float preInputAssignmentTimeout
	{
		 get { } //Length: 9
		 set { } //Length: 9
	}

	public Action restoreDefaultsDelegate
	{
		 get { } //Length: 8
		 set { } //Length: 15
	}

	public InputManager rewiredInputManager
	{
		 get { } //Length: 5
		 set { } //Length: 38
	}

	public bool showActionCategoryLabels
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool showAssignedControllers
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showAssignedControllersGroupLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showControllerGroupLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showControllerNameLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showControllers
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool showFullAxisInputFields
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool showInputBehaviorSettings
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showKeyboard
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	private bool showMapCategories
	{
		private get { } //Length: 21
	}

	public bool showMapCategoriesGroupLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showMouse
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool showPlayers
	{
		 get { } //Length: 119
		 set { } //Length: 19
	}

	public bool showPlayersGroupLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	private bool showSettings
	{
		private get { } //Length: 49
	}

	public bool showSettingsGroupLabel
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public bool showSplitAxisInputFields
	{
		 get { } //Length: 5
		 set { } //Length: 19
	}

	public bool universalCancelClosesScreen
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	public bool useThemeSettings
	{
		 get { } //Length: 8
		 set { } //Length: 22
	}

	public ControlMapper() { }

	public void add_InputPollingEndedEvent(Action value) { }

	public void add_InputPollingStartedEvent(Action value) { }

	public void add_onInputPollingEnded(UnityAction value) { }

	public void add_onInputPollingStarted(UnityAction value) { }

	public void add_onPopupWindowClosed(UnityAction value) { }

	public void add_onPopupWindowOpened(UnityAction value) { }

	public void add_onScreenClosed(UnityAction value) { }

	public void add_onScreenOpened(UnityAction value) { }

	public void add_PopupWindowClosedEvent(Action value) { }

	public void add_PopupWindowOpenedEvent(Action value) { }

	public void add_ScreenClosedEvent(Action value) { }

	public void add_ScreenOpenedEvent(Action value) { }

	public static void ApplyTheme(ElementInfo[] elementInfo) { }

	private void AssignController(Player player, int controllerId) { }

	private void Awake() { }

	private void CheckUISelection() { }

	private void ChildWindowClosed() { }

	private void ChildWindowOpened() { }

	private void Clear() { }

	private void ClearAllVars() { }

	private void ClearCompletely() { }

	private void ClearSpawnedObjects() { }

	private void ClearVarsOnJoystickChange() { }

	private void ClearVarsOnPlayerChange() { }

	public void Close(bool save) { }

	private void CloseAllWindows() { }

	private void CloseTopWindow() { }

	private void CloseWindow(int windowId) { }

	private int CountIEnumerable(IEnumerable<T> enumerable) { }

	private void CreateActionLabelColumn() { }

	private GUIButton CreateButton(string labelText, Transform parent, Vector2 offset) { }

	private bool CreateConflictCheck(InputMapping mapping, ElementAssignment assignment, out ElementAssignmentConflictCheck conflictCheck) { }

	private void CreateControllerInputFieldColumn() { }

	private GUIButton CreateFitButton(string labelText, Transform parent, Vector2 offset) { }

	private void CreateHeaderLabels() { }

	private void CreateInputActionLabels() { }

	private void CreateInputCategoryRow(ref int rowCount, InputCategory category) { }

	private GUIInputField CreateInputField(Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	private GUIInputField CreateInputField(Transform parent, Vector2 offset) { }

	private void CreateInputFieldColumn(string name, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis) { }

	private void CreateInputFields(Transform columnXform, ControllerType controllerType, int maxWidth, int cols, bool disableFullAxis) { }

	private void CreateInputFields() { }

	private void CreateInputFieldSet(Transform parent, int mapCategoryId, InputAction action, AxisRange axisRange, ControllerType controllerType, int cols, int fieldWidth, ref int yPos, bool disableFullAxis) { }

	private void CreateInputGrid() { }

	private void CreateKeyboardInputFieldColumn() { }

	private GUILabel CreateLabel(string labelText, Transform parent, Vector2 offset) { }

	private GUILabel CreateLabel(GameObject prefab, string labelText, Transform parent, Vector2 offset) { }

	private void CreateLayout() { }

	private void CreateMouseInputFieldColumn() { }

	private GameObject CreateNewColumnGroup(string name, Transform parent, int maxWidth) { }

	private GameObject CreateNewGUIObject(string name, Transform parent, Vector2 offset) { }

	private GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset, string label, int actionId, AxisRange axisRange, ControllerType controllerType, int fieldIndex) { }

	private GUIToggle CreateToggle(GameObject prefab, Transform parent, Vector2 offset) { }

	private void DisableInputFieldGroup(InputActionSet actionSet, ControllerType controllerType, int fieldCount) { }

	private void Draw() { }

	private void DrawControllersGroup() { }

	private void DrawMapCategoriesGroup() { }

	private void DrawPlayersGroup() { }

	private void DrawSettingsGroup() { }

	private void DrawWindowButtonsGroup() { }

	[IteratorStateMachine(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	private void EndAxisCalibration() { }

	private void ForceRefresh() { }

	public int get_actionLabelWidth() { }

	public bool get_allowElementAssignmentConflicts() { }

	public bool get_allowElementAssignmentSwap() { }

	public float get_axisCalibrationTimeout() { }

	public float get_controllerAssignmentTimeout() { }

	public int get_controllerColMaxWidth() { }

	public int get_controllerInputFieldCount() { }

	private Joystick get_currentJoystick() { }

	private InputCategory get_currentMapCategory() { }

	private MappingSet get_currentMappingSet() { }

	private Player get_currentPlayer() { }

	private GameObject get_currentUISelection() { }

	public int get_defaultWindowHeight() { }

	public int get_defaultWindowWidth() { }

	public bool get_dontDestroyOnLoad() { }

	public bool get_ignoreMouseXAxisAssignment() { }

	public bool get_ignoreMouseYAxisAssignment() { }

	private bool get_inputAllowed() { }

	public float get_inputAssignmentTimeout() { }

	public int get_inputColumnSpacing() { }

	private int get_inputGridColumnCount() { }

	private int get_inputGridWidth() { }

	public int get_inputRowCategorySpacing() { }

	public int get_inputRowHeight() { }

	public int get_invertToggleWidth() { }

	private bool get_isFocused() { }

	private bool get_isJoystickSelected() { }

	public bool get_isOpen() { }

	public int get_joystickMapDefaultLayout() { }

	public int get_keyboardColMaxWidth() { }

	public int get_keyboardInputFieldCount() { }

	public int get_keyboardMapDefaultLayout() { }

	public LanguageDataBase get_language() { }

	public int get_maxControllersPerPlayer() { }

	public int get_mouseColMaxWidth() { }

	public int get_mouseInputFieldCount() { }

	public int get_mouseMapDefaultLayout() { }

	public float get_preInputAssignmentTimeout() { }

	public Action get_restoreDefaultsDelegate() { }

	public InputManager get_rewiredInputManager() { }

	public bool get_showActionCategoryLabels() { }

	public bool get_showAssignedControllers() { }

	public bool get_showAssignedControllersGroupLabel() { }

	public bool get_showControllerGroupLabel() { }

	public bool get_showControllerNameLabel() { }

	public bool get_showControllers() { }

	public bool get_showFullAxisInputFields() { }

	public bool get_showInputBehaviorSettings() { }

	public bool get_showKeyboard() { }

	private bool get_showMapCategories() { }

	public bool get_showMapCategoriesGroupLabel() { }

	public bool get_showMouse() { }

	public bool get_showPlayers() { }

	public bool get_showPlayersGroupLabel() { }

	private bool get_showSettings() { }

	public bool get_showSettingsGroupLabel() { }

	public bool get_showSplitAxisInputFields() { }

	public bool get_universalCancelClosesScreen() { }

	public bool get_useThemeSettings() { }

	private int GetControllerInputFieldCount(ControllerType controllerType) { }

	private ControllerMap GetControllerMap(ControllerType type) { }

	private ControllerMap GetControllerMapOrCreateNew(ControllerType controllerType, int controllerId, int layoutId) { }

	private int GetDefaultMapCategoryId() { }

	private bool GetFirstElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict, bool skipOtherPlayers) { }

	private bool GetFirstElementAssignmentConflict(Player player, ElementAssignmentConflictCheck conflictCheck, out ElementAssignmentConflictInfo conflict) { }

	public static LanguageDataBase GetLanguage() { }

	private int GetMaxControllersPerPlayer() { }

	private bool HasElementAssignmentConflicts(Player player, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	private void Initialize() { }

	private void InitializeInputGrid() { }

	private GameObject InitializeNewGUIGameObject(GameObject gameObject, Transform parent, Vector2 offset) { }

	private void InputPollingStarted() { }

	private void InputPollingStopped() { }

	private void InspectorPropertyChanged(bool reset = false) { }

	private GameObject InstantiateGUIObject(GameObject prefab, Transform parent, Vector2 offset) { }

	private bool IsAllowedAssignment(InputMapping pendingInputMapping, ControllerPollingInfo pollingInfo) { }

	private bool IsBlockingAssignmentConflict(InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	private void OnAssignControllerWindowUpdate(int windowId) { }

	private void OnBeginElementAssignment(InputFieldInfo fieldInfo, ControllerMap map, ActionElementMap aem, string actionName) { }

	public void OnButtonActivated(ButtonInfo buttonInfo) { }

	private void OnCalibrateAxisStep1WindowUpdate(int windowId) { }

	private void OnCalibrateAxisStep2WindowUpdate(int windowId) { }

	private void OnControllerAssignmentConfirmed(int windowId, Player player, int controllerId) { }

	private void OnControllerSelected(int joystickId) { }

	private void OnDestroy() { }

	private void OnElementAssignmentAddConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment) { }

	private void OnElementAssignmentConflictReplaceConfirmed(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers, bool allowSwap) { }

	private void OnElementAssignmentPrePollingWindowUpdate(int windowId) { }

	public void OnInputFieldActivated(InputFieldInfo fieldInfo) { }

	public void OnInputFieldInvertToggleStateChanged(ToggleInfo toggleInfo, bool newState) { }

	private void OnJoystickConnected(ControllerStatusChangedEventArgs args) { }

	private void OnJoystickDisconnected(ControllerStatusChangedEventArgs args) { }

	private void OnJoystickElementAssignmentPollingWindowUpdate(int windowId) { }

	private void OnJoystickPreDisconnect(ControllerStatusChangedEventArgs args) { }

	private void OnKeyboardElementAssignmentPollingWindowUpdate(int windowId) { }

	private void OnMapCategorySelected(int id, bool redraw) { }

	private void OnMouseAssignmentConfirmed(int windowId, Player player) { }

	private void OnMouseElementAssignmentPollingWindowUpdate(int windowId) { }

	private void OnPlayerSelected(int playerId, bool redraw) { }

	private void OnRemoveCurrentController() { }

	private void OnRemoveElementAssignment(int windowId, ControllerMap map, ActionElementMap aem) { }

	private void OnRestoreDefaults() { }

	private void OnRestoreDefaultsConfirmed(int windowId) { }

	private void OnScreenCloseActionPressed(InputActionEventData data) { }

	private void OnScreenOpenActionPressed(InputActionEventData data) { }

	private void OnScreenToggleActionPressed(InputActionEventData data) { }

	private void OnUIElementSelected(GameObject selectedObject) { }

	private void OnUniversalCancelActionPressed(InputActionEventData data) { }

	private void OnWindowCancel(int windowId) { }

	private void Open(bool force) { }

	public void Open() { }

	private void OpenModal(string title, string message, string confirmText, Action<Int32> confirmAction, string cancelText, Action<Int32> cancelAction, bool closeOthers) { }

	private Window OpenWindow(GameObject windowPrefab, bool closeOthers) { }

	private Window OpenWindow(GameObject windowPrefab, string name, bool closeOthers) { }

	private Window OpenWindow(string name, bool closeOthers) { }

	private Window OpenWindow(bool closeOthers) { }

	private void PollKeyboardForAssignment(out ControllerPollingInfo pollingInfo, out bool modifierKeyPressed, out ModifierKeyFlags modifierFlags, out string label) { }

	private void PopulateInputFieldGroup(InputActionSet actionSet, ControllerMap controllerMap, ControllerType controllerType, int controllerId, int maxFields) { }

	private void PopulateInputFields() { }

	private void PreInitialize() { }

	private void Redraw(bool listsChanged, bool playTransitions) { }

	private void RedrawControllerGroup() { }

	private void RedrawInputGrid(bool listsChanged) { }

	private void RedrawMapCategoriesGroup(bool playTransitions) { }

	private void RedrawPlayerGroup(bool playTransitions) { }

	private void RefreshInputGridStructure() { }

	public void remove_InputPollingEndedEvent(Action value) { }

	public void remove_InputPollingStartedEvent(Action value) { }

	public void remove_onInputPollingEnded(UnityAction value) { }

	public void remove_onInputPollingStarted(UnityAction value) { }

	public void remove_onPopupWindowClosed(UnityAction value) { }

	public void remove_onPopupWindowOpened(UnityAction value) { }

	public void remove_onScreenClosed(UnityAction value) { }

	public void remove_onScreenOpened(UnityAction value) { }

	public void remove_PopupWindowClosedEvent(Action value) { }

	public void remove_PopupWindowOpenedEvent(Action value) { }

	public void remove_ScreenClosedEvent(Action value) { }

	public void remove_ScreenOpenedEvent(Action value) { }

	private void RemoveAllControllers(Player player) { }

	private void RemoveController(Player player, int controllerId) { }

	public void Reset() { }

	private void ResetInputGridScrollBar() { }

	private void RestoreLastUISelection() { }

	private void SelectDefaultMapCategory(bool redraw) { }

	public void set_actionLabelWidth(int value) { }

	public void set_allowElementAssignmentConflicts(bool value) { }

	public void set_allowElementAssignmentSwap(bool value) { }

	public void set_axisCalibrationTimeout(float value) { }

	public void set_controllerAssignmentTimeout(float value) { }

	public void set_controllerColMaxWidth(int value) { }

	public void set_controllerInputFieldCount(int value) { }

	public void set_defaultWindowHeight(int value) { }

	public void set_defaultWindowWidth(int value) { }

	public void set_dontDestroyOnLoad(bool value) { }

	public void set_ignoreMouseXAxisAssignment(bool value) { }

	public void set_ignoreMouseYAxisAssignment(bool value) { }

	public void set_inputAssignmentTimeout(float value) { }

	public void set_inputColumnSpacing(int value) { }

	public void set_inputRowCategorySpacing(int value) { }

	public void set_inputRowHeight(int value) { }

	public void set_invertToggleWidth(int value) { }

	public void set_joystickMapDefaultLayout(int value) { }

	public void set_keyboardColMaxWidth(int value) { }

	public void set_keyboardInputFieldCount(int value) { }

	public void set_keyboardMapDefaultLayout(int value) { }

	public void set_language(LanguageDataBase value) { }

	public void set_maxControllersPerPlayer(int value) { }

	public void set_mouseColMaxWidth(int value) { }

	public void set_mouseInputFieldCount(int value) { }

	public void set_mouseMapDefaultLayout(int value) { }

	public void set_preInputAssignmentTimeout(float value) { }

	public void set_restoreDefaultsDelegate(Action value) { }

	public void set_rewiredInputManager(InputManager value) { }

	public void set_showActionCategoryLabels(bool value) { }

	public void set_showAssignedControllers(bool value) { }

	public void set_showAssignedControllersGroupLabel(bool value) { }

	public void set_showControllerGroupLabel(bool value) { }

	public void set_showControllerNameLabel(bool value) { }

	public void set_showControllers(bool value) { }

	public void set_showFullAxisInputFields(bool value) { }

	public void set_showInputBehaviorSettings(bool value) { }

	public void set_showKeyboard(bool value) { }

	public void set_showMapCategoriesGroupLabel(bool value) { }

	public void set_showMouse(bool value) { }

	public void set_showPlayers(bool value) { }

	public void set_showPlayersGroupLabel(bool value) { }

	public void set_showSettingsGroupLabel(bool value) { }

	public void set_showSplitAxisInputFields(bool value) { }

	public void set_universalCancelClosesScreen(bool value) { }

	public void set_useThemeSettings(bool value) { }

	private void SetActionAxisInverted(bool state, ControllerType controllerType, int actionElementMapId) { }

	private void SetDefaultUISelection() { }

	private void SetIsFocused(bool state) { }

	private void SetUISelection(GameObject selection) { }

	private void ShowAssignControllerWindow() { }

	private bool ShowAssignedControllers() { }

	private void ShowBeginElementAssignmentReplacementWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, ActionElementMap aem, string actionName) { }

	private void ShowCalibrateAxisStep1Window() { }

	private void ShowCalibrateAxisStep2Window() { }

	private void ShowCalibrateControllerWindow() { }

	private void ShowControllerAssignmentConflictWindow(int controllerId) { }

	private void ShowCreateNewElementAssignmentWindow(InputFieldInfo fieldInfo, InputAction action, ControllerMap map, string actionName) { }

	private void ShowEditInputBehaviorsWindow() { }

	private void ShowElementAssignmentConflictWindow(ElementAssignment assignment, bool skipOtherPlayers) { }

	private void ShowElementAssignmentPollingWindow() { }

	private void ShowElementAssignmentPrePollingWindow() { }

	private void ShowJoystickElementAssignmentPollingWindow() { }

	private void ShowKeyboardElementAssignmentPollingWindow() { }

	private void ShowMouseAssignmentConflictWindow() { }

	private void ShowMouseElementAssignmentPollingWindow() { }

	private void ShowRestoreDefaultsWindow() { }

	private bool ShowSwapButton(int windowId, InputMapping mapping, ElementAssignment assignment, bool skipOtherPlayers) { }

	private void Start() { }

	private void StartAxisCalibration(int axisIndex) { }

	private void SubscribeFixedUISelectionEvents() { }

	private void SubscribeMenuControlInputEvents() { }

	private void SubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback) { }

	private bool SwapIsSameInputRange(ControllerElementType origElementType, AxisRange origAxisRange, Pole origAxisContribution, ControllerElementType conflictElementType, AxisRange conflictAxisRange, Pole conflictAxisContribution) { }

	public void Toggle() { }

	private void UnsubscribeMenuControlInputEvents() { }

	private void UnsubscribeRewiredInputEventAllPlayers(int actionId, Action<InputActionEventData> callback) { }

	private void Update() { }

}

