namespace UnityEngine.InputSystem.Controls;

public class Vector3Control : InputControl<Vector3>
{
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; //Field offset: 0x100

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

	[InputControl]
	public AxisControl z
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 15
	}

	public Vector3Control() { }

	public virtual float EvaluateMagnitude(Void* statePtr) { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_x() { }

	[CompilerGenerated]
	public AxisControl get_y() { }

	[CompilerGenerated]
	public AxisControl get_z() { }

	public virtual Vector3 ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	public void set_x(AxisControl value) { }

	[CompilerGenerated]
	public void set_y(AxisControl value) { }

	[CompilerGenerated]
	public void set_z(AxisControl value) { }

	public virtual void WriteValueIntoState(Vector3 value, Void* statePtr) { }

}

