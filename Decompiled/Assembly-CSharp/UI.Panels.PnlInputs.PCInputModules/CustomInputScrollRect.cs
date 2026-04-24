using System;
using Cpp2ILInjected;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Panels.PnlInputs.PCInputModules;

[Token(Token = "0x20001C8")]
public class CustomInputScrollRect : ScrollRect
{
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000B31")]
	public Action<PointerEventData> onBeginDrag;

	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x130")]
	public Action<PointerEventData> onEndDrag;

	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000B33")]
	public bool isDragging;

	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x50A590", Offset = "0x508D90", Length = "0x66")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x50A600", Offset = "0x508E00", Length = "0x66")]
	[Token(Token = "0x6000CCB")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x50A670", Offset = "0x508E70", Length = "0x98")]
	[Token(Token = "0x6000CCC")]
	public override void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x50A710", Offset = "0x508F10", Length = "0x7")]
	public CustomInputScrollRect()
	{
	}
}
