using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x2000205")]
public class ScrollbarVisibilityHelper : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000EC7")]
	public ScrollRect scrollRect;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600133E")]
	public ScrollbarVisibilityHelper()
	{
	}
}
