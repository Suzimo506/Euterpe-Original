using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.UI.Panels.PnlDLC;

[Token(Token = "0x2000920")]
[Attribute(Name = "RequireComponent", RVA = "0x880F0", Offset = "0x874F0")]
public class DLCTxtClick : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x400312A")]
	[FieldOffset(Offset = "0x18")]
	private Camera m_Camera;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400312B")]
	private TextMeshProUGUI m_TextMeshProUGUI;

	[Address(RVA = "0x429C50", Offset = "0x428450", Length = "0x5D")]
	[Token(Token = "0x60052D1")]
	private void Awake()
	{
	}

	[Address(RVA = "0x429CB0", Offset = "0x4284B0", Length = "0x15C")]
	[Token(Token = "0x60052D2")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x60052D3")]
	public DLCTxtClick()
	{
	}
}
