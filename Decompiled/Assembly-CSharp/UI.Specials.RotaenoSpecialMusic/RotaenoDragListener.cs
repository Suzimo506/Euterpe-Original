using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Specials.RotaenoSpecialMusic;

[Token(Token = "0x20001B8")]
public class RotaenoDragListener : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler, IBeginDragHandler, IPointerDownHandler
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3CD0", Offset = "0x30D0")]
	[Token(Token = "0x4000AB3")]
	private float duration;

	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x20")]
	public Action onBeginDragAction;

	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_DragDir;

	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x30")]
	private float m_DragSqrMagnitude;

	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsEndDrag;

	[Token(Token = "0x4000AB8")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsBeginDrag;

	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000AB9")]
	private Vector2 m_BeginDragPos;

	[Token(Token = "0x170000E8")]
	public bool IsBeginDrag
	{
		[Address(RVA = "0x4E2200", Offset = "0x4E0A00", Length = "0x5")]
		[Token(Token = "0x6000C42")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E9")]
	public Vector2 DragDir
	{
		[Address(RVA = "0x4E21E0", Offset = "0x4E09E0", Length = "0x13")]
		[Token(Token = "0x6000C43")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170000EA")]
	public float DragMagnitude
	{
		[Address(RVA = "0x46DDA0", Offset = "0x46C5A0", Length = "0x6")]
		[Token(Token = "0x6000C44")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000EB")]
	public Vector2 BeginDragPos
	{
		[Address(RVA = "0x4E21C0", Offset = "0x4E09C0", Length = "0x13")]
		[Token(Token = "0x6000C45")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000C46")]
	[Address(RVA = "0x4E2050", Offset = "0x4E0850", Length = "0x13E")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000C47")]
	[Address(RVA = "0x4E1F80", Offset = "0x4E0780", Length = "0x45")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x4E2190", Offset = "0x4E0990", Length = "0x5")]
	[Token(Token = "0x6000C48")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000C49")]
	[Address(RVA = "0x4E21A0", Offset = "0x4E09A0", Length = "0x8")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x4E1EE0", Offset = "0x4E06E0", Length = "0x9E")]
	[Token(Token = "0x6000C4A")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000C4B")]
	[Address(RVA = "0x4E1FD0", Offset = "0x4E07D0", Length = "0x77")]
	private void OnDisable()
	{
	}

	[Address(RVA = "0x4E21B0", Offset = "0x4E09B0", Length = "0xE")]
	[Token(Token = "0x6000C4C")]
	public RotaenoDragListener()
	{
	}
}
