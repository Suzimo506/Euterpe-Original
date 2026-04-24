namespace UnityEngine.InputSystem;

public abstract class InputProcessor
{
	internal static TypeTable s_Processors; //Field offset: 0x685D0

	protected InputProcessor() { }

	internal static Type GetValueTypeFromType(Type processorType) { }

	public abstract void Process(Void* buffer, int bufferSize, InputControl control) { }

	public abstract object ProcessAsObject(object value, InputControl control) { }

}

