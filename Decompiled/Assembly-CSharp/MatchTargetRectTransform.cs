using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000166")]
public class MatchTargetRectTransform : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40008CC")]
	public GameObject targetObj;

	[Token(Token = "0x40008CD")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 offset;

	[Token(Token = "0x40008CE")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_Rect;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40008CF")]
	private Vector2 tempVect;

	[Address(RVA = "0x8C1750", Offset = "0x8BFF50", Length = "0x8F")]
	[Token(Token = "0x6000A34")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x8C17E0", Offset = "0x8BFFE0", Length = "0xE8")]
	[Token(Token = "0x6000A35")]
	private void Update()
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000A36")]
	public MatchTargetRectTransform()
	{
	}
}
