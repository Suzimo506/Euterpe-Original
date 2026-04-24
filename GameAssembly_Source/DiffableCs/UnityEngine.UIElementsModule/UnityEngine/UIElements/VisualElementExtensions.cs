namespace UnityEngine.UIElements;

[Extension]
public static class VisualElementExtensions
{

	[Extension]
	public static Rect ChangeCoordinatesTo(VisualElement src, VisualElement dest, Rect rect) { }

	[Extension]
	public static Rect LocalToWorld(VisualElement ele, Rect r) { }

	[Extension]
	public static Vector2 WorldToLocal(VisualElement ele, Vector2 p) { }

	[Extension]
	public static Rect WorldToLocal(VisualElement ele, Rect r) { }

}

