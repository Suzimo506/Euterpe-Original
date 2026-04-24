namespace UnityEngine.InputSystem.Controls;

public class AxisControl : InputControl<Single>
{
	internal enum Clamp
	{
		None = 0,
		BeforeNormalize = 1,
		AfterNormalize = 2,
		ToConstantBeforeNormalize = 3,
	}

	public Clamp clamp; //Field offset: 0xF0
	public float clampMin; //Field offset: 0xF4
	public float clampMax; //Field offset: 0xF8
	public float clampConstant; //Field offset: 0xFC
	public bool invert; //Field offset: 0x100
	public bool normalize; //Field offset: 0x101
	public float normalizeMin; //Field offset: 0x104
	public float normalizeMax; //Field offset: 0x108
	public float normalizeZero; //Field offset: 0x10C
	public bool scale; //Field offset: 0x110
	public float scaleFactor; //Field offset: 0x114

	public AxisControl() { }

	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	public virtual float EvaluateMagnitude(Void* statePtr) { }

	protected virtual void FinishSetup() { }

	protected float Preprocess(float value) { }

	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

