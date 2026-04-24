namespace UnityEngine.InputSystem.Composites;

[DesignTimeVisible(/*Cpp2IL Warning: missing at least one required parameter*/)]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class ButtonWithTwoModifiers : InputBindingComposite<Single>
{
	[InputControl]
	public int modifier1; //Field offset: 0x10
	[InputControl]
	public int modifier2; //Field offset: 0x14
	[InputControl]
	public int button; //Field offset: 0x18

	public ButtonWithTwoModifiers() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

