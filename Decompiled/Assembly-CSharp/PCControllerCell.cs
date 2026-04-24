using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000F1")]
public class PCControllerCell : MonoBehaviour
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000603")]
	private GameObject m_Cover;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000604")]
	private GameObject m_Reverse;

	[Token(Token = "0x4000605")]
	[FieldOffset(Offset = "0x28")]
	private Image m_Selected;

	[Token(Token = "0x4000606")]
	[FieldOffset(Offset = "0x30")]
	public GameObject controllerTypePS4;

	[Token(Token = "0x4000607")]
	[FieldOffset(Offset = "0x38")]
	public GameObject controllerTypeXBox;

	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000608")]
	public GameObject controllerTypeNs;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000609")]
	private GameObject m_CurrentControllerType;

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x8727D0", Offset = "0x870FD0", Length = "0x1BE")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x872990", Offset = "0x871190", Length = "0x17F")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x423CE0", Offset = "0x4224E0", Length = "0x3")]
	[Token(Token = "0x6000719")]
	public void SetSelectColor(Color c)
	{
	}

	[Address(RVA = "0x469780", Offset = "0x467F80", Length = "0x47")]
	[Token(Token = "0x600071A")]
	public void SetReverse(bool isReverse)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600071B")]
	public PCControllerCell()
	{
	}
}
