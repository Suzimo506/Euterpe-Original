using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000138")]
public class StageAlbumPointerEnter : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007AA")]
	public GameObject parent;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60008D7")]
	public StageAlbumPointerEnter()
	{
	}
}
