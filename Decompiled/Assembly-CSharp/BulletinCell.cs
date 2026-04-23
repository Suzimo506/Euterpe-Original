using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000DB")]
public class BulletinCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000580")]
	public Toggle toggle;

	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x20")]
	public YlyRichText txtTile;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000582")]
	public Image imgBaseSelected;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000583")]
	public Image imgNew;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000584")]
	public YlyRichText txtTitleSelected;

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000654")]
	public BulletinCell()
	{
	}
}
