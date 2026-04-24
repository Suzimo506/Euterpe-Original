namespace UnityEngine.InputSystem.Processors;

public class ScaleVector2Processor : InputProcessor<Vector2>
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float x; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float y; //Field offset: 0x14

	public ScaleVector2Processor() { }

	public virtual Vector2 Process(Vector2 value, InputControl control) { }

	public virtual string ToString() { }

}

