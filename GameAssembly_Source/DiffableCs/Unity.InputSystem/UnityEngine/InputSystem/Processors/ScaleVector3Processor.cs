namespace UnityEngine.InputSystem.Processors;

public class ScaleVector3Processor : InputProcessor<Vector3>
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float x; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float y; //Field offset: 0x14
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float z; //Field offset: 0x18

	public ScaleVector3Processor() { }

	public virtual Vector3 Process(Vector3 value, InputControl control) { }

	public virtual string ToString() { }

}

