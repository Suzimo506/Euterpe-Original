namespace UnityEngine.InputSystem.Composites;

[DisplayName]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class Vector2Composite : InputBindingComposite<Vector2>
{
	internal enum Mode
	{
		Analog = 2,
		DigitalNormalized = 0,
		Digital = 1,
	}

	[InputControl]
	public int up; //Field offset: 0x10
	[InputControl]
	public int down; //Field offset: 0x14
	[InputControl]
	public int left; //Field offset: 0x18
	[InputControl]
	public int right; //Field offset: 0x1C
	[Obsolete]
	public bool normalize; //Field offset: 0x20
	public Mode mode; //Field offset: 0x24

	public Vector2Composite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	public virtual Vector2 ReadValue(ref InputBindingCompositeContext context) { }

}

