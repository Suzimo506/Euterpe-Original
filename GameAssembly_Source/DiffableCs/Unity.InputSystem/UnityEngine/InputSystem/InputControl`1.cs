namespace UnityEngine.InputSystem;

public abstract class InputControl : InputControl
{
	internal InlinedArray<InputProcessor`1<TValue>> m_ProcessorStack; //Field offset: 0x0

	internal InputProcessor<TValue>[] processors
	{
		internal get { } //Length: 27
	}

	public virtual int valueSizeInBytes
	{
		 get { } //Length: 21
	}

	public virtual Type valueType
	{
		 get { } //Length: 95
	}

	protected InputControl`1() { }

	internal virtual void AddProcessor(object processor) { }

	public virtual bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	internal InputProcessor<TValue>[] get_processors() { }

	public virtual int get_valueSizeInBytes() { }

	public virtual Type get_valueType() { }

	public TValue ProcessValue(TValue value) { }

	public TValue ReadDefaultValue() { }

	public TValue ReadUnprocessedValue() { }

	public abstract TValue ReadUnprocessedValueFromState(Void* statePtr) { }

	public TValue ReadValue() { }

	public virtual object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	public TValue ReadValueFromPreviousFrame() { }

	public TValue ReadValueFromState(Void* statePtr) { }

	public virtual object ReadValueFromStateAsObject(Void* statePtr) { }

	public virtual void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	internal TProcessor TryGetProcessor() { }

	public virtual void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	public virtual void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

	public override void WriteValueIntoState(TValue value, Void* statePtr) { }

}

