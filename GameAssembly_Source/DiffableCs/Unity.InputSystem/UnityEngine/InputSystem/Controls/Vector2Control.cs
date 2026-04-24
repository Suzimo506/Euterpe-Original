namespace UnityEngine.InputSystem.Controls;

public class Vector2Control : InputControl<Vector2>
{
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; //Field offset: 0xF8

	[InputControl]
	public AxisControl x
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	[InputControl]
	public AxisControl y
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector2Control() { }

	public virtual float EvaluateMagnitude(Void* statePtr) { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_x() { }

	[CompilerGenerated]
	public AxisControl get_y() { }

	public virtual Vector2 ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	public void set_y(AxisControl value) { }

	public virtual void WriteValueIntoState(Vector2 value, Void* statePtr) { }

}

