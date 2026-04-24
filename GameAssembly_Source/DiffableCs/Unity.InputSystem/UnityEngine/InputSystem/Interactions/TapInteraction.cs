namespace UnityEngine.InputSystem.Interactions;

[DisplayName]
public class TapInteraction : IInputInteraction
{
	public float duration; //Field offset: 0x10
	public float pressPoint; //Field offset: 0x14
	private double m_TapStartTime; //Field offset: 0x18

	private float durationOrDefault
	{
		private get { } //Length: 107
	}

	private float pressPointOrDefault
	{
		private get { } //Length: 73
	}

	private float releasePointOrDefault
	{
		private get { } //Length: 115
	}

	public TapInteraction() { }

	private float get_durationOrDefault() { }

	private float get_pressPointOrDefault() { }

	private float get_releasePointOrDefault() { }

	public override void Process(ref InputInteractionContext context) { }

	public override void Reset() { }

}

