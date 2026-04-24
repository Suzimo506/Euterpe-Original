namespace UnityEngine.InputSystem.Controls;

public class QuaternionControl : InputControl<Quaternion>
{
	[CompilerGenerated]
	private AxisControl <x>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private AxisControl <y>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private AxisControl <z>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private AxisControl <w>k__BackingField; //Field offset: 0x108

	[InputControl]
	public private AxisControl w
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl x
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl y
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl z
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public QuaternionControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public AxisControl get_w() { }

	[CompilerGenerated]
	public AxisControl get_x() { }

	[CompilerGenerated]
	public AxisControl get_y() { }

	[CompilerGenerated]
	public AxisControl get_z() { }

	public virtual Quaternion ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	private void set_w(AxisControl value) { }

	[CompilerGenerated]
	private void set_x(AxisControl value) { }

	[CompilerGenerated]
	private void set_y(AxisControl value) { }

	[CompilerGenerated]
	private void set_z(AxisControl value) { }

	public virtual void WriteValueIntoState(Quaternion value, Void* statePtr) { }

}

