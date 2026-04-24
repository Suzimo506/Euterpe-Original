using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Integration.UnityUI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Rewired.Demos;

[Attribute(Name = "AddComponentMenu", RVA = "0x6530", Offset = "0x5930")]
[Token(Token = "0x200021C")]
public sealed class PlayerPointerEventHandlerExample : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler, IPointerClickHandler, IScrollHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000F5C")]
	public Text text;

	[Token(Token = "0x4000F5D")]
	private const int logLength = 10;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F5E")]
	private List<string> log;

	[Token(Token = "0x6001424")]
	[Address(RVA = "0xF9A630", Offset = "0xF98E30", Length = "0x70")]
	private void Log(string o)
	{
	}

	[Address(RVA = "0xF9D380", Offset = "0xF9BB80", Length = "0x18B")]
	[Token(Token = "0x6001425")]
	private void Update()
	{
	}

	[Address(RVA = "0xF9C0F0", Offset = "0xF9A8F0", Length = "0x467")]
	[Token(Token = "0x6001426")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9C560", Offset = "0xF9AD60", Length = "0x467")]
	[Token(Token = "0x6001427")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9C9D0", Offset = "0xF9B1D0", Length = "0x53F")]
	[Token(Token = "0x6001428")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9BBB0", Offset = "0xF9A3B0", Length = "0x53F")]
	[Token(Token = "0x6001429")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9B670", Offset = "0xF99E70", Length = "0x53F")]
	[Token(Token = "0x600142A")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600142B")]
	[Address(RVA = "0xF9CF10", Offset = "0xF9B710", Length = "0x467")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9A6B0", Offset = "0xF98EB0", Length = "0x53F")]
	[Token(Token = "0x600142C")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0xF9ABF0", Offset = "0xF993F0", Length = "0x53F")]
	[Token(Token = "0x600142D")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0xF9B130", Offset = "0xF99930", Length = "0x53F")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0xF9A510", Offset = "0xF98D10", Length = "0x114")]
	private static string GetSourceName(PlayerPointerEventData playerEventData)
	{
		return null;
	}

	[Address(RVA = "0xF9D510", Offset = "0xF9BD10", Length = "0x69")]
	[Token(Token = "0x6001430")]
	public PlayerPointerEventHandlerExample()
	{
	}
}
