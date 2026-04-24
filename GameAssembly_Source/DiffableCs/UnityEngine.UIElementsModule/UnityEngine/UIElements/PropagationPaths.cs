namespace UnityEngine.UIElements;

internal class PropagationPaths
{
	[Flags]
	internal enum Type
	{
		None = 0,
		TrickleDown = 1,
		BubbleUp = 2,
	}

	private static readonly ObjectPool<PropagationPaths> s_Pool; //Field offset: 0x0
	public readonly List<VisualElement> trickleDownPath; //Field offset: 0x10
	public readonly List<VisualElement> targetElements; //Field offset: 0x18
	public readonly List<VisualElement> bubbleUpPath; //Field offset: 0x20

	private static PropagationPaths() { }

	public PropagationPaths() { }

	public static PropagationPaths Build(VisualElement elem, Type pathTypesRequested) { }

	internal static PropagationPaths Copy(PropagationPaths paths) { }

	public void Release() { }

}

