namespace UnityEngine.InputSystem.Interactions;

[DisplayName]
public class PressInteraction : IInputInteraction
{
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float pressPoint; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public PressBehavior behavior; //Field offset: 0x14
	private bool m_WaitingForRelease; //Field offset: 0x18

	private float pressPointOrDefault
	{
		private get { } //Length: 73
	}

	private float releasePointOrDefault
	{
		private get { } //Length: 115
	}

	public PressInteraction() { }

	private float get_pressPointOrDefault() { }

	private float get_releasePointOrDefault() { }

	public override void Process(ref InputInteractionContext context) { }

	public override void Reset() { }

}

