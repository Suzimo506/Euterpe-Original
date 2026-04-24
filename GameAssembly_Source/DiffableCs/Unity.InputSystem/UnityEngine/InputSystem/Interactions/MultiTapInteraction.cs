namespace UnityEngine.InputSystem.Interactions;

public class MultiTapInteraction : IInputInteraction<Single>, IInputInteraction
{
	private enum TapPhase
	{
		None = 0,
		WaitingForNextRelease = 1,
		WaitingForNextPress = 2,
	}

	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float tapTime; //Field offset: 0x10
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public float tapDelay; //Field offset: 0x14
	[Tooltip(/*Cpp2IL Warning: missing at least one required parameter*/)]
	public int tapCount; //Field offset: 0x18
	public float pressPoint; //Field offset: 0x1C
	private TapPhase m_CurrentTapPhase; //Field offset: 0x20
	private int m_CurrentTapCount; //Field offset: 0x24
	private double m_CurrentTapStartTime; //Field offset: 0x28
	private double m_LastTapReleaseTime; //Field offset: 0x30

	private float pressPointOrDefault
	{
		private get { } //Length: 73
	}

	private float releasePointOrDefault
	{
		private get { } //Length: 115
	}

	internal float tapDelayOrDefault
	{
		internal get { } //Length: 107
	}

	private float tapTimeOrDefault
	{
		private get { } //Length: 107
	}

	public MultiTapInteraction() { }

	private float get_pressPointOrDefault() { }

	private float get_releasePointOrDefault() { }

	internal float get_tapDelayOrDefault() { }

	private float get_tapTimeOrDefault() { }

	public override void Process(ref InputInteractionContext context) { }

	public override void Reset() { }

}

