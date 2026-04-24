namespace UnityEngine.InputSystem.Controls;

[InputControlLayout]
public class TouchControl : InputControl<TouchState>
{
	[CompilerGenerated]
	private TouchPressControl <press>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private IntegerControl <touchId>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector2Control <position>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private Vector2Control <delta>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private AxisControl <pressure>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Vector2Control <radius>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private TouchPhaseControl <phase>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private ButtonControl <indirectTouch>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private ButtonControl <tap>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private IntegerControl <tapCount>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private DoubleControl <startTime>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private Vector2Control <startPosition>k__BackingField; //Field offset: 0x148

	public Vector2Control delta
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public ButtonControl indirectTouch
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public bool isInProgress
	{
		 get { } //Length: 94
	}

	public TouchPhaseControl phase
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector2Control position
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public TouchPressControl press
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public AxisControl pressure
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector2Control radius
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector2Control startPosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public DoubleControl startTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public ButtonControl tap
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public IntegerControl tapCount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public IntegerControl touchId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public TouchControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector2Control get_delta() { }

	[CompilerGenerated]
	public ButtonControl get_indirectTouch() { }

	public bool get_isInProgress() { }

	[CompilerGenerated]
	public TouchPhaseControl get_phase() { }

	[CompilerGenerated]
	public Vector2Control get_position() { }

	[CompilerGenerated]
	public TouchPressControl get_press() { }

	[CompilerGenerated]
	public AxisControl get_pressure() { }

	[CompilerGenerated]
	public Vector2Control get_radius() { }

	[CompilerGenerated]
	public Vector2Control get_startPosition() { }

	[CompilerGenerated]
	public DoubleControl get_startTime() { }

	[CompilerGenerated]
	public ButtonControl get_tap() { }

	[CompilerGenerated]
	public IntegerControl get_tapCount() { }

	[CompilerGenerated]
	public IntegerControl get_touchId() { }

	public virtual TouchState ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_delta(Vector2Control value) { }

	[CompilerGenerated]
	public void set_indirectTouch(ButtonControl value) { }

	[CompilerGenerated]
	public void set_phase(TouchPhaseControl value) { }

	[CompilerGenerated]
	public void set_position(Vector2Control value) { }

	[CompilerGenerated]
	public void set_press(TouchPressControl value) { }

	[CompilerGenerated]
	public void set_pressure(AxisControl value) { }

	[CompilerGenerated]
	public void set_radius(Vector2Control value) { }

	[CompilerGenerated]
	public void set_startPosition(Vector2Control value) { }

	[CompilerGenerated]
	public void set_startTime(DoubleControl value) { }

	[CompilerGenerated]
	public void set_tap(ButtonControl value) { }

	[CompilerGenerated]
	public void set_tapCount(IntegerControl value) { }

	[CompilerGenerated]
	public void set_touchId(IntegerControl value) { }

	public virtual void WriteValueIntoState(TouchState value, Void* statePtr) { }

}

