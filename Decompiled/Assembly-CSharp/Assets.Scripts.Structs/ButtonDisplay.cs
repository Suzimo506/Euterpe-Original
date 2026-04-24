using Cpp2ILInjected;
using UnityEngine.UI;

namespace Assets.Scripts.Structs;

[Token(Token = "0x200056C")]
public struct ButtonDisplay
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001FF7")]
	public Button btn;

	[Token(Token = "0x4001FF8")]
	[FieldOffset(Offset = "0x8")]
	public Image displayImg;
}
