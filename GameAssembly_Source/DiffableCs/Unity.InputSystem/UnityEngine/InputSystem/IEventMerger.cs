namespace UnityEngine.InputSystem;

internal interface IEventMerger
{

	public bool MergeForward(InputEventPtr currentEventPtr, InputEventPtr nextEventPtr) { }

}

