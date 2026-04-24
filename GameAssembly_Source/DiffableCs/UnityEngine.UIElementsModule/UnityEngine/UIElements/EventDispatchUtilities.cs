namespace UnityEngine.UIElements;

internal static class EventDispatchUtilities
{

	public static void ExecuteDefaultAction(EventBase evt, IPanel panel) { }

	public static void PropagateEvent(EventBase evt) { }

	internal static void PropagateToIMGUIContainer(VisualElement root, EventBase evt) { }

}

