using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.UI.Specials;

[Attribute(Name = "RequireComponent", RVA = "0x324C0", Offset = "0x318C0")]
[Token(Token = "0x2000866")]
public class PnlTroveItemToggleEnterAsSelected : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4002BEF")]
	private Toggle m_Toggle;

	[Address(RVA = "0x616BB0", Offset = "0x6153B0", Length = "0xAF")]
	[Token(Token = "0x6004CD4")]
	private void Awake()
	{
	}

	[Address(RVA = "0x616CF0", Offset = "0x6154F0", Length = "0x101")]
	[Token(Token = "0x6004CD5")]
	private void OnToggleChange(bool state)
	{
	}

	[Token(Token = "0x6004CD6")]
	[Address(RVA = "0x616C60", Offset = "0x615460", Length = "0x87")]
	public void OnSelect(BaseEventData eventData)
	{
	}

	[Token(Token = "0x6004CD7")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public PnlTroveItemToggleEnterAsSelected()
	{
	}
}
