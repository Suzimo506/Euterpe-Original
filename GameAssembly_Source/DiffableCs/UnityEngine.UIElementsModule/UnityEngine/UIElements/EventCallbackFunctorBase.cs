namespace UnityEngine.UIElements;

internal abstract class EventCallbackFunctorBase
{
	[CompilerGenerated]
	[DebuggerBrowsable(/*Cpp2IL Warning: missing at least one required parameter*/)]
	private CallbackPhase <phase>k__BackingField; //Field offset: 0x10

	public CallbackPhase phase
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[CompilerGenerated]
	public CallbackPhase get_phase() { }

	public abstract void Invoke(EventBase evt) { }

}

