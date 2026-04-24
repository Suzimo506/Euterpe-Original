using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

[Token(Token = "0x200006C")]
public class FSVScrollBar : MonoBehaviour, IDragHandler, IBeginDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IEndDragHandler
{
	[Token(Token = "0x20009BF")]
	public delegate void OnDragBeginDelegate();

	[Token(Token = "0x20009C0")]
	public delegate void OnDragDelegate();

	[Token(Token = "0x20009C1")]
	public delegate void OnDragEndDelegate();

	[Token(Token = "0x20009C2")]
	public delegate void OnPointerDownDelegate();

	[Token(Token = "0x20009C3")]
	public delegate void OnPointerUpDelegate();

	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002F6")]
	public OnDragBeginDelegate onDragBeginEvent;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002F7")]
	public OnDragDelegate onDragEvent;

	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002F8")]
	public OnDragEndDelegate onDragEndEvent;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002F9")]
	public OnPointerDownDelegate onPointerDown;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x38")]
	public OnPointerDownDelegate onPointerUp;

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x44A100", Offset = "0x448900", Length = "0x1D")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x44A120", Offset = "0x448920", Length = "0x1D")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x44A140", Offset = "0x448940", Length = "0x1D")]
	[Token(Token = "0x6000327")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x44A160", Offset = "0x448960", Length = "0x1D")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x44A180", Offset = "0x448980", Length = "0x1D")]
	[Token(Token = "0x6000329")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x422B90", Offset = "0x421390", Length = "0x7")]
	[Token(Token = "0x600032A")]
	public FSVScrollBar()
	{
	}
}
