using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x2000210")]
public static class UITools
{
	[Token(Token = "0x600136C")]
	[Address(RVA = "0xB4A2F0", Offset = "0xB48AF0", Length = "0x184")]
	public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600136D")]
	[Address(RVA = "0xB4A480", Offset = "0xB48C80", Length = "0x1DE")]
	public static GameObject InstantiateGUIObject<T>(GameObject prefab, Transform parent, string name, Vector2 pivot, Vector2 anchorMin, Vector2 anchorMax, Vector2 anchoredPosition) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600136E")]
	[Address(RVA = "0xB4A0D0", Offset = "0xB488D0", Length = "0x216")]
	private static GameObject InstantiateGUIObject_Pre<T>(GameObject prefab, Transform parent, string name) where T : Component
	{
		return null;
	}

	[Address(RVA = "0x635530", Offset = "0x633D30", Length = "0x288")]
	[Token(Token = "0x600136F")]
	public static Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x6357C0", Offset = "0x633FC0", Length = "0x2A4")]
	public static Rect GetWorldSpaceRect(RectTransform rt)
	{
		return default(Rect);
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x635D10", Offset = "0x634510", Length = "0x423")]
	public static Rect TransformRectTo(Transform from, Transform to, Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x635A70", Offset = "0x634270", Length = "0x9E")]
	public static Rect InvertY(Rect rect)
	{
		return default(Rect);
	}

	[Token(Token = "0x6001373")]
	[Address(RVA = "0x635B10", Offset = "0x634310", Length = "0x1F0")]
	public static void SetInteractable(Selectable selectable, bool state, bool playTransition)
	{
	}
}
