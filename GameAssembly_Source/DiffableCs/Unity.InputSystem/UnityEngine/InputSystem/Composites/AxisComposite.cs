namespace UnityEngine.InputSystem.Composites;

[DisplayName]
[DisplayStringFormat(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class AxisComposite : InputBindingComposite<Single>
{
	internal enum WhichSideWins
	{
		Neither = 0,
		Positive = 1,
		Negative = 2,
	}

	[InputControl]
	public int negative; //Field offset: 0x10
	[InputControl]
	public int positive; //Field offset: 0x14
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float minValue; //Field offset: 0x18
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float maxValue; //Field offset: 0x1C
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public WhichSideWins whichSideWins; //Field offset: 0x20

	public float midPoint
	{
		 get { } //Length: 19
	}

	public AxisComposite() { }

	public virtual float EvaluateMagnitude(ref InputBindingCompositeContext context) { }

	public float get_midPoint() { }

	public virtual float ReadValue(ref InputBindingCompositeContext context) { }

}

