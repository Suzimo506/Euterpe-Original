namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ButtonWithOneModifier : InputBindingComposite<Single>
{
	[InputControl]
	public int modifier; //Field offset: 0x10
	[InputControl]
	public int button; //Field offset: 0x14

	public ButtonWithOneModifier() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

