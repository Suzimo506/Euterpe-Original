namespace UnityEngine.UIElements;

public abstract class CallbackEventHandler : IEventHandler
{
	private EventCallbackRegistry m_CallbackRegistry; //Field offset: 0x10

	protected override void ExecuteDefaultAction(EventBase evt) { }

	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	public override void HandleEvent(EventBase evt) { }

	internal void HandleEventAtTargetPhase(EventBase evt) { }

	public override bool HasBubbleUpHandlers() { }

	public override bool HasTrickleDownHandlers() { }

	public abstract void SendEvent(EventBase e) { }

}

