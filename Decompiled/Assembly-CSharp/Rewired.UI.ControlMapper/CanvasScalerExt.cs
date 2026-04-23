using Cpp2ILInjected;
using UnityEngine.UI;

namespace Rewired.UI.ControlMapper;

[Token(Token = "0x20001F8")]
[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
public class CanvasScalerExt : CanvasScaler
{
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x884D90", Offset = "0x883590", Length = "0x11")]
	public void ForceRefresh()
	{
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x884DB0", Offset = "0x8835B0", Length = "0x7")]
	public CanvasScalerExt()
	{
	}
}
