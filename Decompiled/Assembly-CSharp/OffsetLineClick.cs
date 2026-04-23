using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x20000EE")]
public class OffsetLineClick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject parent;

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x86E200", Offset = "0x86CA00", Length = "0x50")]
	public void OnPointerDown(PointerEventData data)
	{
	}

	[Address(RVA = "0x86E260", Offset = "0x86CA60", Length = "0x50")]
	[Token(Token = "0x60006F8")]
	public void OnPointerUp(PointerEventData data)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	public OffsetLineClick()
	{
	}
}
