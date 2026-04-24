using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000976")]
[Attribute(Name = "RequireComponent", RVA = "0x1B710", Offset = "0x1AB10")]
public class AccountDeleteTMPClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40033D8")]
	private TextMeshProUGUI m_TextMeshPro;

	[Address(RVA = "0x58CB00", Offset = "0x58B300", Length = "0x47")]
	[Token(Token = "0x6005651")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005652")]
	[Address(RVA = "0x58CB50", Offset = "0x58B350", Length = "0x203")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6005653")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public AccountDeleteTMPClick()
	{
	}
}
