using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Assets.Scripts.PeroTools.UI;

[Token(Token = "0x20005B1")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x94560", Offset = "0x93960")]
public class LongPressButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400213B")]
	public bool longPressIncludePointerDown;

	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400213C")]
	public float delta;

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400213D")]
	public float triggerDelta;

	[Token(Token = "0x400213E")]
	[FieldOffset(Offset = "0x28")]
	public Action onPressDown;

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400213F")]
	public Action<bool> onPress;

	[Token(Token = "0x4002140")]
	[FieldOffset(Offset = "0x38")]
	public Action onPressUp;

	[Token(Token = "0x4002141")]
	[FieldOffset(Offset = "0x40")]
	private Button m_Button;

	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4002142")]
	private bool m_Flag;

	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4002143")]
	private float m_PressStartTime;

	[Token(Token = "0x4002144")]
	[FieldOffset(Offset = "0x50")]
	private float m_LastPressTime;

	[Address(RVA = "0x97F060", Offset = "0x97D860", Length = "0xBB")]
	[Token(Token = "0x6003947")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x97F120", Offset = "0x97D920", Length = "0x67")]
	[Token(Token = "0x6003948")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Address(RVA = "0x97F000", Offset = "0x97D800", Length = "0x27")]
	[Token(Token = "0x6003949")]
	public bool IsActive()
	{
		return default(bool);
	}

	[Token(Token = "0x600394A")]
	[Address(RVA = "0x97F030", Offset = "0x97D830", Length = "0x27")]
	public bool IsInteractable()
	{
		return default(bool);
	}

	[Address(RVA = "0x97F190", Offset = "0x97D990", Length = "0xA9")]
	[Token(Token = "0x600394B")]
	private void Update()
	{
	}

	[Address(RVA = "0x820CD0", Offset = "0x81F4D0", Length = "0x5")]
	[Token(Token = "0x600394C")]
	private void OnEnable()
	{
	}

	[Address(RVA = "0x97EFB0", Offset = "0x97D7B0", Length = "0x47")]
	[Token(Token = "0x600394D")]
	private void Awake()
	{
	}

	[Address(RVA = "0x97F240", Offset = "0x97DA40", Length = "0x12")]
	[Token(Token = "0x600394E")]
	public LongPressButton()
	{
	}
}
