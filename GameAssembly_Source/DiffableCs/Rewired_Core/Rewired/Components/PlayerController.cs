namespace Rewired.Components;

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class PlayerController : ComponentWrapper<PlayerController>, IPlayerController
{
	internal class AxisValueChangedHandler : UnityEvent<Int32, Single>
	{

		public AxisValueChangedHandler() { }

	}

	internal class ButtonStateChangedHandler : UnityEvent<Int32, Boolean>
	{

		public ButtonStateChangedHandler() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public sealed class ElementInfo
	{
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private string _name; //Field offset: 0x10
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private Type _elementType; //Field offset: 0x18
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _enabled; //Field offset: 0x1C
		[SerializeField]
		private ElementWithSourceInfo[] _elements; //Field offset: 0x20

		public ElementWithSourceInfo[] elements
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public Type elementType
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public string name
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public ElementInfo() { }

		public ElementWithSourceInfo[] get_elements() { }

		public Type get_elementType() { }

		public bool get_enabled() { }

		public string get_name() { }

		public void set_elements(ElementWithSourceInfo[] value) { }

		public void set_elementType(Type value) { }

		public void set_enabled(bool value) { }

		public void set_name(string value) { }

		public Definition ToDefinition() { }

	}

	[CustomClassObfuscation]
	[CustomObfuscation]
	public sealed class ElementWithSourceInfo
	{
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private string _name; //Field offset: 0x10
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private TypeWithSource _elementType; //Field offset: 0x18
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private bool _enabled; //Field offset: 0x1C
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private int _actionId; //Field offset: 0x20
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private AxisCoordinateMode _coordinateMode; //Field offset: 0x24
		[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _absoluteToRelativeSensitivity; //Field offset: 0x28
		[FieldRange(/*Cpp2IL Warning: missing at least one required parameter*/)]
		[SerializeField]
		[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
		private float _repeatRate; //Field offset: 0x2C

		public float absoluteSourceSensitivity
		{
			 get { } //Length: 6
			 set { } //Length: 6
		}

		public int actionId
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public AxisCoordinateMode coordinateMode
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public TypeWithSource elementType
		{
			 get { } //Length: 4
			 set { } //Length: 4
		}

		public bool enabled
		{
			 get { } //Length: 5
			 set { } //Length: 4
		}

		public string name
		{
			 get { } //Length: 5
			 set { } //Length: 12
		}

		public float repeatRate
		{
			 get { } //Length: 6
			 set { } //Length: 6
		}

		public ElementWithSourceInfo() { }

		public float get_absoluteSourceSensitivity() { }

		public int get_actionId() { }

		public AxisCoordinateMode get_coordinateMode() { }

		public TypeWithSource get_elementType() { }

		public bool get_enabled() { }

		public string get_name() { }

		public float get_repeatRate() { }

		public void set_absoluteSourceSensitivity(float value) { }

		public void set_actionId(int value) { }

		public void set_coordinateMode(AxisCoordinateMode value) { }

		public void set_elementType(TypeWithSource value) { }

		public void set_enabled(bool value) { }

		public void set_name(string value) { }

		public void set_repeatRate(float value) { }

		public Definition ToDefinition() { }

	}

	internal class EnabledStateChangedHandler : UnityEvent<Boolean>
	{

		public EnabledStateChangedHandler() { }

	}

	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private InputManager_Base _rewiredInputManager; //Field offset: 0x28
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private int _playerId; //Field offset: 0x30
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private List<ElementInfo> _elements; //Field offset: 0x38
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private ButtonStateChangedHandler _onButtonStateChanged; //Field offset: 0x40
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private AxisValueChangedHandler _onAxisValueChanged; //Field offset: 0x48
	[CustomObfuscation]
	[SerializeField]
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private EnabledStateChangedHandler _onEnabledStateChanged; //Field offset: 0x50

	public override event Action<Int32, Single> AxisValueChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public override event Action<Int32, Boolean> ButtonStateChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public override event Action<Boolean> EnabledStateChangedEvent
	{
		 add { } //Length: 85
		 remove { } //Length: 85
	}

	public override IList<Axis> axes
	{
		 get { } //Length: 85
	}

	public override int axisCount
	{
		 get { } //Length: 76
	}

	public override int buttonCount
	{
		 get { } //Length: 76
	}

	public override IList<Button> buttons
	{
		 get { } //Length: 85
	}

	public override int elementCount
	{
		 get { } //Length: 76
	}

	public override IList<Element> elements
	{
		 get { } //Length: 85
	}

	public override int playerId
	{
		 get { } //Length: 77
		 set { } //Length: 302
	}

	public PlayerController() { }

	public override void add_AxisValueChangedEvent(Action<Int32, Single> value) { }

	public override void add_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	public override void add_EnabledStateChangedEvent(Action<Boolean> value) { }

	protected virtual PlayerController CreateSource(object args) { }

	private void ETWVJYrjTRIhhFfWbCuYchmmOuNd(int unnamed_param_0, bool unnamed_param_1) { }

	public override IList<Axis> get_axes() { }

	public override int get_axisCount() { }

	public override int get_buttonCount() { }

	public override IList<Button> get_buttons() { }

	public override int get_elementCount() { }

	public override IList<Element> get_elements() { }

	public override int get_playerId() { }

	public override float GetAxis(int index) { }

	public override float GetAxisRaw(int index) { }

	public override bool GetButton(int index) { }

	public override bool GetButtonDown(int index) { }

	public override bool GetButtonUp(int index) { }

	protected virtual object GetCreateSourceArgs() { }

	public override T GetElement(int index) { }

	public override Element GetElement(int index) { }

	private void ieMcyvpFgFWQlKcpEPwaJMSabZuR() { }

	private void lcClkIXKkliropInwshOonlpvjz(int unnamed_param_0, float unnamed_param_1) { }

	private void MVmqCTleHSjQSCJyfVDDWbFfFgiu(bool unnamed_param_0) { }

	protected virtual void OnAwake() { }

	protected virtual void OnAwakeFinished() { }

	protected virtual void OnDisabled() { }

	protected virtual void OnEnabled() { }

	protected virtual void OnReset() { }

	protected virtual void OnValidated() { }

	internal override List<ElementInfo> QZBvwUoCzASpAhAnRnEuAlpcXtHW() { }

	public override void remove_AxisValueChangedEvent(Action<Int32, Single> value) { }

	public override void remove_ButtonStateChangedEvent(Action<Int32, Boolean> value) { }

	public override void remove_EnabledStateChangedEvent(Action<Boolean> value) { }

	private override bool Rewired.IPlayerController.get_enabled() { }

	private override void Rewired.IPlayerController.set_enabled(bool value) { }

	public override void set_playerId(int value) { }

	protected virtual void Subscribe() { }

	protected virtual void Unsubscribe() { }

}

