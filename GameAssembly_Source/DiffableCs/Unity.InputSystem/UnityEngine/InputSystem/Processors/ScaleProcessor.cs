namespace UnityEngine.InputSystem.Processors;

public class ScaleProcessor : InputProcessor<Single>
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float factor; //Field offset: 0x10

	public ScaleProcessor() { }

	public virtual float Process(float value, InputControl control) { }

	public virtual string ToString() { }

}

