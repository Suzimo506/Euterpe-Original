//Type is in global namespace

[AddComponentMenu(/*Cpp2IL Warning: missing at least one required parameter*/)]
public class VisMessageTrigger : VisTargetTrigger
{
	internal enum ControllerSourceValue
	{
		None = 0,
		Current = 1,
		Previous = 2,
		Difference = 3,
	}

	internal static class Defaults
	{
		public const string messageName = "TriggerMessage"; //Field offset: 0x0
		public const ControllerSourceValue messageParameter = 1; //Field offset: 0x0

	}

	public string messageName; //Field offset: 0x60
	public ControllerSourceValue messageParameter; //Field offset: 0x68

	public VisMessageTrigger() { }

	public virtual void OnTriggered(float current, float previous, float difference, float adjustedDifference) { }

	public virtual void Reset() { }

	public virtual void Start() { }

	public virtual void Update() { }

}

