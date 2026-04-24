using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000D5")]
public class ArcadeControllerCell : MonoBehaviour
{
	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_Cover;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_Reverse;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x28")]
	private Image m_Selected;

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x596E40", Offset = "0x595640", Length = "0xAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x469780", Offset = "0x467F80", Length = "0x47")]
	public void SetReverse(bool isReverse)
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public ArcadeControllerCell()
	{
	}
}
