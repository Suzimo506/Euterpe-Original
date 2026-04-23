using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.Common;

[Token(Token = "0x2000984")]
[Attribute(Name = "RequireComponent", RVA = "0x1CDA0", Offset = "0x1C1A0")]
public class TMPClickUrl : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4003413")]
	public bool isNoChannel;

	[Token(Token = "0x4003414")]
	[FieldOffset(Offset = "0x20")]
	private TextMeshProUGUI m_TextMeshPro;

	[Address(RVA = "0x702FD0", Offset = "0x7017D0", Length = "0x47")]
	[Token(Token = "0x6005690")]
	private void Awake()
	{
	}

	[Address(RVA = "0x703020", Offset = "0x701820", Length = "0x2F8")]
	[Token(Token = "0x6005691")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x6005692")]
	public TMPClickUrl()
	{
	}
}
