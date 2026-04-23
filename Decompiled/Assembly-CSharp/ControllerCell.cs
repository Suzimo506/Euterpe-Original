using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000DF")]
public class ControllerCell : MonoBehaviour
{
	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x18")]
	private GameObject m_Cover;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000596")]
	private GameObject m_Reverse;

	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x28")]
	private Image m_Selected;

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x469680", Offset = "0x467E80", Length = "0xF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0x4697D0", Offset = "0x467FD0", Length = "0x107")]
	public void SetSelectColor(Color c)
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x469780", Offset = "0x467F80", Length = "0x47")]
	public void SetReverse(bool isReverse)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6000670")]
	public ControllerCell()
	{
	}
}
