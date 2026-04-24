namespace UnityEngine.InputSystem.Composites;

[DisplayName]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Vector3Composite : InputBindingComposite<Vector3>
{
	internal enum Mode
	{
		Analog = 0,
		DigitalNormalized = 1,
		Digital = 2,
	}

	[InputControl]
	public int up; //Field offset: 0x10
	[InputControl]
	public int down; //Field offset: 0x14
	[InputControl]
	public int left; //Field offset: 0x18
	[InputControl]
	public int right; //Field offset: 0x1C
	[InputControl]
	public int forward; //Field offset: 0x20
	[InputControl]
	public int backward; //Field offset: 0x24
	public Mode mode; //Field offset: 0x28

	public Vector3Composite() { }

	public virtual Vector3 ReadValue(ref InputBindingCompositeContext context) { }

}

