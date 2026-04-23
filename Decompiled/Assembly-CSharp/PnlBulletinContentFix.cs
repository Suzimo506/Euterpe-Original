using System.Collections;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200018C")]
public class PnlBulletinContentFix : MonoBehaviour
{
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x18")]
	public RectTransform content;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40009B0")]
	public HorizontalOrVerticalLayoutGroup layout;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40009B1")]
	public RectTransform textRect;

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x4FBAC0", Offset = "0x4FA2C0", Length = "0x6F")]
	private void OnEnable()
	{
	}

	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x3D750", Offset = "0x3CB50")]
	[Address(RVA = "0x4FBA50", Offset = "0x4FA250", Length = "0x65")]
	[Token(Token = "0x6000B33")]
	private IEnumerator Fix()
	{
		return null;
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlBulletinContentFix()
	{
	}
}
