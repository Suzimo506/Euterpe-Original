using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000164")]
public class MatchChildWidth : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008C5")]
	public RectTransform selftRect;

	[Token(Token = "0x40008C6")]
	[FieldOffset(Offset = "0x20")]
	public RectTransform targetRect;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40008C7")]
	public Transform targetCenter;

	[Token(Token = "0x40008C8")]
	[FieldOffset(Offset = "0x30")]
	public int maxSize;

	[Token(Token = "0x40008C9")]
	[FieldOffset(Offset = "0x34")]
	private int lastWidth;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40008CA")]
	private int curWidth;

	[Address(RVA = "0x8C1410", Offset = "0x8BFC10", Length = "0xA4")]
	[Token(Token = "0x6000A2E")]
	private void Awake()
	{
	}

	[Address(RVA = "0x8C14C0", Offset = "0x8BFCC0", Length = "0xF7")]
	[Token(Token = "0x6000A2F")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public MatchChildWidth()
	{
	}
}
