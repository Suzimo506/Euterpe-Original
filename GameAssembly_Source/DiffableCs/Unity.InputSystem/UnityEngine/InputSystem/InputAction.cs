namespace UnityEngine.InputSystem;

public sealed class InputAction : ICloneable, IDisposable
{
	[Flags]
	public enum ActionFlags
	{
		WantsInitialStateCheck = 1,
	}

	internal struct CallbackContext
	{
		internal InputActionState m_State; //Field offset: 0x0
		internal int m_ActionIndex; //Field offset: 0x8

		public InputAction action
		{
			 get { } //Length: 81
		}

		private int actionIndex
		{
			private get { } //Length: 4
		}

		private int bindingIndex
		{
			private get { } //Length: 51
		}

		public bool canceled
		{
			 get { } //Length: 63
		}

		public InputControl control
		{
			 get { } //Length: 115
		}

		private int controlIndex
		{
			private get { } //Length: 56
		}

		public double duration
		{
			 get { } //Length: 114
		}

		public IInputInteraction interaction
		{
			 get { } //Length: 116
		}

		private int interactionIndex
		{
			private get { } //Length: 56
		}

		public bool performed
		{
			 get { } //Length: 63
		}

		public InputActionPhase phase
		{
			 get { } //Length: 53
		}

		public bool started
		{
			 get { } //Length: 63
		}

		public double startTime
		{
			 get { } //Length: 56
		}

		public double time
		{
			 get { } //Length: 56
		}

		public int valueSizeInBytes
		{
			 get { } //Length: 138
		}

		public Type valueType
		{
			 get { } //Length: 138
		}

		public InputAction get_action() { }

		private int get_actionIndex() { }

		private int get_bindingIndex() { }

		public bool get_canceled() { }

		public InputControl get_control() { }

		private int get_controlIndex() { }

		public double get_duration() { }

		public IInputInteraction get_interaction() { }

		private int get_interactionIndex() { }

		public bool get_performed() { }

		public InputActionPhase get_phase() { }

		public bool get_started() { }

		public double get_startTime() { }

		public double get_time() { }

		public int get_valueSizeInBytes() { }

		public Type get_valueType() { }

		public void ReadValue(Void* buffer, int bufferSize) { }

		public TValue ReadValue() { }

		public bool ReadValueAsButton() { }

		public object ReadValueAsObject() { }

		public virtual string ToString() { }

	}

	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal string m_Name; //Field offset: 0x10
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal InputActionType m_Type; //Field offset: 0x18
	[FormerlySerializedAs(/*Cpp2IL Warning: missing at least one required parameter*/)]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal string m_ExpectedControlType; //Field offset: 0x20
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	internal string m_Id; //Field offset: 0x28
	[SerializeField]
	internal string m_Processors; //Field offset: 0x30
	[SerializeField]
	internal string m_Interactions; //Field offset: 0x38
	[SerializeField]
	internal InputBinding[] m_SingletonActionBindings; //Field offset: 0x40
	[SerializeField]
	internal ActionFlags m_Flags; //Field offset: 0x48
	internal Nullable<InputBinding> m_BindingMask; //Field offset: 0x50
	internal int m_BindingsStartIndex; //Field offset: 0xB0
	internal int m_BindingsCount; //Field offset: 0xB4
	internal int m_ControlStartIndex; //Field offset: 0xB8
	internal int m_ControlCount; //Field offset: 0xBC
	internal int m_ActionIndexInState; //Field offset: 0xC0
	internal InputActionMap m_ActionMap; //Field offset: 0xC8
	internal CallbackArray<Action`1<CallbackContext>> m_OnStarted; //Field offset: 0xD0
	internal CallbackArray<Action`1<CallbackContext>> m_OnCanceled; //Field offset: 0x120
	internal CallbackArray<Action`1<CallbackContext>> m_OnPerformed; //Field offset: 0x170

	public event Action<CallbackContext> canceled
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action<CallbackContext> performed
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public event Action<CallbackContext> started
	{
		 add { } //Length: 75
		 remove { } //Length: 75
	}

	public InputActionMap actionMap
	{
		 get { } //Length: 21
	}

	public InputControl activeControl
	{
		 get { } //Length: 141
	}

	public Nullable<InputBinding> bindingMask
	{
		 get { } //Length: 60
		 set { } //Length: 671
	}

	public ReadOnlyArray<InputBinding> bindings
	{
		 get { } //Length: 174
	}

	public ReadOnlyArray<InputControl> controls
	{
		 get { } //Length: 212
	}

	private TriggerState currentState
	{
		private get { } //Length: 106
	}

	public bool enabled
	{
		 get { } //Length: 95
	}

	public string expectedControlType
	{
		 get { } //Length: 5
		 set { } //Length: 12
	}

	public Guid id
	{
		 get { } //Length: 168
	}

	internal Guid idDontGenerate
	{
		internal get { } //Length: 78
	}

	public bool inProgress
	{
		 get { } //Length: 82
	}

	public string interactions
	{
		 get { } //Length: 5
	}

	internal bool isSingletonAction
	{
		internal get { } //Length: 23
	}

	public string name
	{
		 get { } //Length: 5
	}

	public InputActionPhase phase
	{
		 get { } //Length: 89
	}

	public string processors
	{
		 get { } //Length: 5
	}

	public bool triggered
	{
		 get { } //Length: 130
	}

	public InputActionType type
	{
		 get { } //Length: 4
	}

	public bool wantsInitialStateCheck
	{
		 get { } //Length: 16
		 set { } //Length: 25
	}

	public InputAction() { }

	public InputAction(string name = null, InputActionType type = 0, string binding = null, string interactions = null, string processors = null, string expectedControlType = null) { }

	public void add_canceled(Action<CallbackContext> value) { }

	public void add_performed(Action<CallbackContext> value) { }

	public void add_started(Action<CallbackContext> value) { }

	internal int BindingIndexOnActionToBindingIndexOnMap(int indexOfBindingOnAction) { }

	internal int BindingIndexOnMapToBindingIndexOnAction(int indexOfBindingOnMap) { }

	public InputAction Clone() { }

	private void CreateInternalActionMapForSingletonAction() { }

	public void Disable() { }

	public override void Dispose() { }

	public void Enable() { }

	internal Nullable<InputBinding> FindEffectiveBindingMask() { }

	internal void GenerateId() { }

	public InputActionMap get_actionMap() { }

	public InputControl get_activeControl() { }

	public Nullable<InputBinding> get_bindingMask() { }

	public ReadOnlyArray<InputBinding> get_bindings() { }

	public ReadOnlyArray<InputControl> get_controls() { }

	private TriggerState get_currentState() { }

	public bool get_enabled() { }

	public string get_expectedControlType() { }

	public Guid get_id() { }

	internal Guid get_idDontGenerate() { }

	public bool get_inProgress() { }

	public string get_interactions() { }

	internal bool get_isSingletonAction() { }

	public string get_name() { }

	public InputActionPhase get_phase() { }

	public string get_processors() { }

	public bool get_triggered() { }

	public InputActionType get_type() { }

	public bool get_wantsInitialStateCheck() { }

	internal InputActionMap GetOrCreateActionMap() { }

	public float GetTimeoutCompletionPercentage() { }

	public bool IsPressed() { }

	internal string MakeSureIdIsInPlace() { }

	public TValue ReadValue() { }

	public object ReadValueAsObject() { }

	public void remove_canceled(Action<CallbackContext> value) { }

	public void remove_performed(Action<CallbackContext> value) { }

	public void remove_started(Action<CallbackContext> value) { }

	public void Reset() { }

	public void set_bindingMask(Nullable<InputBinding> value) { }

	public void set_expectedControlType(string value) { }

	public void set_wantsInitialStateCheck(bool value) { }

	private override object System.ICloneable.Clone() { }

	public virtual string ToString() { }

	public bool WasPerformedThisFrame() { }

	public bool WasPressedThisFrame() { }

	public bool WasReleasedThisFrame() { }

}

