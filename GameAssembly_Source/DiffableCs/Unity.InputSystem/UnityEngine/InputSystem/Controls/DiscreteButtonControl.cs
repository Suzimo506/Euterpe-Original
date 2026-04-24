namespace UnityEngine.InputSystem.Controls;

public class DiscreteButtonControl : ButtonControl
{
	public int minValue; //Field offset: 0x120
	public int maxValue; //Field offset: 0x124
	public int wrapAtValue; //Field offset: 0x128
	public int nullValue; //Field offset: 0x12C

	public DiscreteButtonControl() { }

	protected virtual void FinishSetup() { }

	public virtual float ReadUnprocessedValueFromState(Void* statePtr) { }

	public virtual void WriteValueIntoState(float value, Void* statePtr) { }

}

