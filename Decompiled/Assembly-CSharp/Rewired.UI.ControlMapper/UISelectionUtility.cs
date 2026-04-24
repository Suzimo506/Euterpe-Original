using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x200020E")]
public static class UISelectionUtility
{
	[Token(Token = "0x4000EEB")]
	private static Selectable[] s_reusableAllSelectables;

	[Address(RVA = "0xDCD510", Offset = "0xDCBD10", Length = "0x8DB")]
	[Token(Token = "0x6001364")]
	public static Selectable FindNextSelectable(Selectable selectable, Transform transform, Vector3 direction)
	{
		return null;
	}
}
