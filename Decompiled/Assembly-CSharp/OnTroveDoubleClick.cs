using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20000EF")]
public class OnTroveDoubleClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x40005F4")]
	[FieldOffset(Offset = "0x18")]
	private bool m_IsPotinterDowned;

	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x40005F5")]
	private bool m_BtnInvoked;

	[Address(RVA = "0x86F640", Offset = "0x86DE40", Length = "0x1A0")]
	[Token(Token = "0x60006FA")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Address(RVA = "0x86F630", Offset = "0x86DE30", Length = "0x7")]
	[Token(Token = "0x60006FB")]
	private void ClickWaitTimeOver()
	{
	}

	[Token(Token = "0x60006FC")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public OnTroveDoubleClick()
	{
	}
}
