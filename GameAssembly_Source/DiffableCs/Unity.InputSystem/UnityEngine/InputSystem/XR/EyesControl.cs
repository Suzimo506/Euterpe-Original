namespace UnityEngine.InputSystem.XR;

public class EyesControl : InputControl<Eyes>
{
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private Vector3Control <fixationPoint>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private AxisControl <leftEyeOpenAmount>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private AxisControl <rightEyeOpenAmount>k__BackingField; //Field offset: 0x120

	[InputControl]
	public private Vector3Control fixationPoint
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl leftEyeOpenAmount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control leftEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl leftEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private AxisControl rightEyeOpenAmount
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private Vector3Control rightEyePosition
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	[InputControl]
	public private QuaternionControl rightEyeRotation
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 15
	}

	public EyesControl() { }

	protected virtual void FinishSetup() { }

	[CompilerGenerated]
	public Vector3Control get_fixationPoint() { }

	[CompilerGenerated]
	public AxisControl get_leftEyeOpenAmount() { }

	[CompilerGenerated]
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	public AxisControl get_rightEyeOpenAmount() { }

	[CompilerGenerated]
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	public QuaternionControl get_rightEyeRotation() { }

	public virtual Eyes ReadUnprocessedValueFromState(Void* statePtr) { }

	[CompilerGenerated]
	private void set_fixationPoint(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeOpenAmount(AxisControl value) { }

	[CompilerGenerated]
	private void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	private void set_rightEyeOpenAmount(AxisControl value) { }

	[CompilerGenerated]
	private void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	private void set_rightEyeRotation(QuaternionControl value) { }

	public virtual void WriteValueIntoState(Eyes value, Void* statePtr) { }

}

