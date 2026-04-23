using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000163")]
public class MatchAutoExpandText : MonoBehaviour
{
	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x18")]
	public Text text;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x20")]
	public ContentSizeFitter contentSizeFitter;

	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x28")]
	public int maxWidth;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008C3")]
	private string lastText;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008C4")]
	private RectTransform rectTrans;

	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x8C1270", Offset = "0x8BFA70", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x8C12C0", Offset = "0x8BFAC0", Length = "0x14D")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MatchAutoExpandText()
	{
	}
}
