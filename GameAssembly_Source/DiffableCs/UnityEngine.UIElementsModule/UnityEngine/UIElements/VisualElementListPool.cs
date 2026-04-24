namespace UnityEngine.UIElements;

internal static class VisualElementListPool
{
	private static ObjectPool<List`1<VisualElement>> pool; //Field offset: 0x6B550

	private static VisualElementListPool() { }

	public static List<VisualElement> Get(int initialCapacity = 0) { }

	public static void Release(List<VisualElement> elements) { }

}

