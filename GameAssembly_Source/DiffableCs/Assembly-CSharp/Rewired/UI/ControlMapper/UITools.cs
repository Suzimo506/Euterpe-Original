namespace Rewired.UI.ControlMapper;

public static class UITools
{

	public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir) { }

	public static Rect GetWorldSpaceRect(RectTransform rt) { }

	public static GameObject InstantiateGUIObject(GameObject prefab, Transform parent, string name) { }

	public static GameObject InstantiateGUIObject(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) { }

	private static GameObject InstantiateGUIObject_Pre(GameObject prefab, Transform parent, string name) { }

	public static Rect InvertY(Rect rect) { }

	public static void SetInteractable(Selectable selectable, bool state, bool playTransition) { }

	public static Rect TransformRectTo(Transform from, Transform to, Rect rect) { }

}

