using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Common;

[Attribute(Name = "RequireComponent", RVA = "0x1B9E0", Offset = "0x1ADE0")]
[Token(Token = "0x2000977")]
public class AgreementTMPClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x40033D9")]
	[FieldOffset(Offset = "0x18")]
	private TextMeshProUGUI m_TextMeshPro;

	[Token(Token = "0x6005654")]
	[Address(RVA = "0x5921C0", Offset = "0x5909C0", Length = "0x47")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005655")]
	[Address(RVA = "0x592210", Offset = "0x590A10", Length = "0x1DD")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005656")]
	public AgreementTMPClick()
	{
	}
}
